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
	// Token: 0x02005CEF RID: 23791
	public class BattleSkillRouletteItem : UiPanelBase
	{
		// Token: 0x0603C3EF RID: 246767 RVA: 0x00E6C07C File Offset: 0x00E6A27C
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

		// Token: 0x0603C3F0 RID: 246768 RVA: 0x00E6C0C4 File Offset: 0x00E6A2C4
		protected override UniTask OnBeforeStartAsync()
		{
			BattleSkillRouletteItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleSkillRouletteItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C3F1 RID: 246769 RVA: 0x00E6C107 File Offset: 0x00E6A307
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiRouletteKeyChanged, new Action(this.OnRouletteKeyChanged));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}

		// Token: 0x0603C3F2 RID: 246770 RVA: 0x00E6C141 File Offset: 0x00E6A341
		private void OnRouletteKeyChanged()
		{
			this.RefreshKeyItem();
			this.RefreshVisible();
		}

		// Token: 0x0603C3F3 RID: 246771 RVA: 0x00E6C14F File Offset: 0x00E6A34F
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshKeyItem();
		}

		// Token: 0x0603C3F4 RID: 246772 RVA: 0x00E6C158 File Offset: 0x00E6A358
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

		// Token: 0x0603C3F5 RID: 246773 RVA: 0x00E6C1E8 File Offset: 0x00E6A3E8
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

		// Token: 0x0401F654 RID: 128596
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0200BF4D RID: 48973
		private enum EChildType
		{
			// Token: 0x04039B2C RID: 236332
			KeyItem
		}
	}
}
