using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CCE RID: 19662
	public class BattleSkillLeftRouletteItem : UiPanelBase
	{
		// Token: 0x06031325 RID: 201509 RVA: 0x00DBBFA8 File Offset: 0x00DBA1A8
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

		// Token: 0x06031326 RID: 201510 RVA: 0x00DBBFF0 File Offset: 0x00DBA1F0
		protected override UniTask OnBeforeStartAsync()
		{
			BattleSkillLeftRouletteItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleSkillLeftRouletteItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031327 RID: 201511 RVA: 0x00DBC033 File Offset: 0x00DBA233
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiRouletteKeyChanged, new Action(this.OnRouletteKeyChanged));
		}

		// Token: 0x06031328 RID: 201512 RVA: 0x00DBC051 File Offset: 0x00DBA251
		private void OnRouletteKeyChanged()
		{
			this.RefreshKeyItem();
			this.RefreshVisible();
		}

		// Token: 0x06031329 RID: 201513 RVA: 0x00DBC060 File Offset: 0x00DBA260
		public void RefreshKeyItem()
		{
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData.RouletteKey == EKey.Gamepad_LeftShoulder)
			{
				return;
			}
			if (!string.IsNullOrEmpty(gamepadData.RouletteKey))
			{
				InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
				{
					ActionOrAxisName = "幻象探索选择界面"
				};
				this.KeyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
			}
		}

		// Token: 0x0603132A RID: 201514 RVA: 0x00DBC0BC File Offset: 0x00DBA2BC
		public void RefreshVisible()
		{
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			if (DangoAbyssModel.Instance.CheckIfInSmallWorldInstance())
			{
				this.SetActive(false);
				return;
			}
			if (!Info.Instance.IsInGamepad())
			{
				this.SetActive(false);
				return;
			}
			SkillButtonUiGamepadDataBase gamepadData = SkillButtonUiModel.Instance.GamepadData;
			if (gamepadData.GetIsPressCombineButton())
			{
				this.SetActive(false);
				return;
			}
			bool funcFlagEnable = LevelFuncFlagModel.Instance.GetFuncFlagEnable(ELevelFuncFlagId.ExploreSkillRoulette);
			bool active = gamepadData.RouletteKey != EKey.Gamepad_LeftShoulder && gamepadData.RouletteKey != null && funcFlagEnable;
			this.SetActive(active);
		}

		// Token: 0x0401A101 RID: 106753
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0200A94D RID: 43341
		private enum EChildType
		{
			// Token: 0x040344DF RID: 214239
			KeyItem
		}
	}
}
