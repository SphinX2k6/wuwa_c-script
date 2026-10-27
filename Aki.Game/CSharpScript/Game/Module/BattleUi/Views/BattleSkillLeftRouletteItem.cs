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
	// Token: 0x02005CEC RID: 23788
	public class BattleSkillLeftRouletteItem : UiPanelBase
	{
		// Token: 0x0603C3CF RID: 246735 RVA: 0x00E6B9F4 File Offset: 0x00E69BF4
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

		// Token: 0x0603C3D0 RID: 246736 RVA: 0x00E6BA3C File Offset: 0x00E69C3C
		protected override UniTask OnBeforeStartAsync()
		{
			BattleSkillLeftRouletteItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleSkillLeftRouletteItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C3D1 RID: 246737 RVA: 0x00E6BA7F File Offset: 0x00E69C7F
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiRouletteKeyChanged, new Action(this.OnRouletteKeyChanged));
		}

		// Token: 0x0603C3D2 RID: 246738 RVA: 0x00E6BA9D File Offset: 0x00E69C9D
		private void OnRouletteKeyChanged()
		{
			this.RefreshKeyItem();
			this.RefreshVisible();
		}

		// Token: 0x0603C3D3 RID: 246739 RVA: 0x00E6BAAC File Offset: 0x00E69CAC
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

		// Token: 0x0603C3D4 RID: 246740 RVA: 0x00E6BB08 File Offset: 0x00E69D08
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

		// Token: 0x0401F648 RID: 128584
		[Nullable(2)]
		private InputMultiKeyItem KeyItem;

		// Token: 0x0200BF47 RID: 48967
		private enum EChildType
		{
			// Token: 0x04039B1D RID: 236317
			KeyItem
		}
	}
}
