using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD1 RID: 19665
	public class BattleSkillRouletteItem : UiPanelBase
	{
		// Token: 0x06031345 RID: 201541 RVA: 0x00DBC630 File Offset: 0x00DBA830
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031346 RID: 201542 RVA: 0x00DBC678 File Offset: 0x00DBA878
		protected override UniTask OnBeforeStartAsync()
		{
			BattleSkillRouletteItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleSkillRouletteItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031347 RID: 201543 RVA: 0x00DBC6BB File Offset: 0x00DBA8BB
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiRouletteKeyChanged, new Action(this.OnRouletteKeyChanged));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}

		// Token: 0x06031348 RID: 201544 RVA: 0x00DBC6F5 File Offset: 0x00DBA8F5
		private void OnRouletteKeyChanged()
		{
			this.RefreshKeyItem();
			this.RefreshVisible();
		}

		// Token: 0x06031349 RID: 201545 RVA: 0x00DBC703 File Offset: 0x00DBA903
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshKeyItem();
		}

		// Token: 0x0603134A RID: 201546 RVA: 0x00DBC70C File Offset: 0x00DBA90C
		public void RefreshKeyItem()
		{
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData.RouletteKey == EKey.Gamepad_LeftShoulder)
			{
				InputKeyItemData singleInputKeyItemData = new InputKeyItemData
				{
					KeyName = EKey.Gamepad_Right2D
				};
				this.KeyItem.RefreshByKeyList(singleInputKeyItemData, null);
				return;
			}
			if (!string.IsNullOrEmpty(gamepadData.RouletteKey))
			{
				return;
			}
			if (!string.IsNullOrEmpty(gamepadData.RouletteSecondKey))
			{
				InputKeyItemData singleInputKeyItemData2 = new InputKeyItemData
				{
					KeyName = gamepadData.RouletteSecondKey
				};
				this.KeyItem.RefreshByKeyList(singleInputKeyItemData2, null);
			}
		}

		// Token: 0x0603134B RID: 201547 RVA: 0x00DBC79C File Offset: 0x00DBA99C
		public void RefreshVisible()
		{
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (!gamepadData.GetIsPressCombineButton())
			{
				this.SetActive(false);
				return;
			}
			bool active = gamepadData.RouletteKey == EKey.Gamepad_LeftShoulder || (gamepadData.RouletteKey == null && gamepadData.RouletteSecondKey != null);
			this.SetActive(active);
		}

		// Token: 0x0401A10D RID: 106765
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0200A953 RID: 43347
		private enum EChildType
		{
			// Token: 0x040344EE RID: 214254
			KeyItem
		}
	}
}
