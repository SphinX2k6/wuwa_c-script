using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D99 RID: 23961
	public class MotorcycleControlMobilePanel : MotorcycleControlPanelBase
	{
		// Token: 0x0603CD11 RID: 249105 RVA: 0x00E9AEC0 File Offset: 0x00E990C0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CD12 RID: 249106 RVA: 0x00E9AF2C File Offset: 0x00E9912C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleControlMobilePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleControlMobilePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD13 RID: 249107 RVA: 0x00E9AF70 File Offset: 0x00E99170
		private UniTask NewSkillButtonPanel()
		{
			MotorcycleControlMobilePanel.<NewSkillButtonPanel>d__6 <NewSkillButtonPanel>d__;
			<NewSkillButtonPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSkillButtonPanel>d__.<>4__this = this;
			<NewSkillButtonPanel>d__.<>1__state = -1;
			<NewSkillButtonPanel>d__.<>t__builder.Start<MotorcycleControlMobilePanel.<NewSkillButtonPanel>d__6>(ref <NewSkillButtonPanel>d__);
			return <NewSkillButtonPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD14 RID: 249108 RVA: 0x00E9AFB4 File Offset: 0x00E991B4
		private UniTask NewJoysticks()
		{
			MotorcycleControlMobilePanel.<NewJoysticks>d__7 <NewJoysticks>d__;
			<NewJoysticks>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewJoysticks>d__.<>4__this = this;
			<NewJoysticks>d__.<>1__state = -1;
			<NewJoysticks>d__.<>t__builder.Start<MotorcycleControlMobilePanel.<NewJoysticks>d__7>(ref <NewJoysticks>d__);
			return <NewJoysticks>d__.<>t__builder.Task;
		}

		// Token: 0x0603CD15 RID: 249109 RVA: 0x00E9AFF7 File Offset: 0x00E991F7
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshJoystickEnable();
			EventSystem.Instance.Add<bool>(EEventName.OnMotorcycleRoundJoystickChanged, new Action<bool>(this.OnMotorcycleRoundJoystickChanged));
		}

		// Token: 0x0603CD16 RID: 249110 RVA: 0x00E9B021 File Offset: 0x00E99221
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			MotorcycleSkillButtonMobilePanel skillButtonPanel = this.SkillButtonPanel;
			if (skillButtonPanel != null)
			{
				skillButtonPanel.SetVisible(0, true);
			}
			this.ApplyTouchUiEditData();
			EventSystem.Instance.Add<ECommonTouchUiEditGroup>(EEventName.OnTouchUiEditSave, new Action<ECommonTouchUiEditGroup>(this.OnTouchUiEditSave));
		}

		// Token: 0x0603CD17 RID: 249111 RVA: 0x00E9B05E File Offset: 0x00E9925E
		protected override void OnBeforeHide()
		{
			base.OnBeforeHide();
			MotorcycleSkillButtonMobilePanel skillButtonPanel = this.SkillButtonPanel;
			if (skillButtonPanel != null)
			{
				skillButtonPanel.SetVisible(0, false);
			}
			EventSystem.Instance.Remove(EEventName.OnTouchUiEditSave, new Action<ECommonTouchUiEditGroup>(this.OnTouchUiEditSave));
		}

		// Token: 0x0603CD18 RID: 249112 RVA: 0x00E9B095 File Offset: 0x00E99295
		public override void Tick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			MotorcycleSkillButtonMobilePanel skillButtonPanel = this.SkillButtonPanel;
			if (skillButtonPanel != null)
			{
				skillButtonPanel.Tick(delta);
			}
			if (this.JoystickEnable)
			{
				MotorcycleJoystick joystick = this.Joystick;
				if (joystick == null)
				{
					return;
				}
				joystick.Tick((double)delta);
			}
		}

		// Token: 0x0603CD19 RID: 249113 RVA: 0x00E9B0CC File Offset: 0x00E992CC
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			EventSystem.Instance.Remove(EEventName.OnMotorcycleRoundJoystickChanged, new Action<bool>(this.OnMotorcycleRoundJoystickChanged));
			MotorcycleSkillButtonMobilePanel skillButtonPanel = this.SkillButtonPanel;
			if (skillButtonPanel != null)
			{
				skillButtonPanel.Destroy(null);
			}
			this.SkillButtonPanel = null;
			MotorcycleJoystick joystick = this.Joystick;
			if (joystick != null)
			{
				joystick.Destroy(null);
			}
			this.Joystick = null;
			base.Reset();
		}

		// Token: 0x0603CD1A RID: 249114 RVA: 0x00E9B133 File Offset: 0x00E99333
		private void CacheTouchUiEditInitData()
		{
			TouchUiEditApplyHelper.CacheTouchUiEditInitData(ECommonTouchUiEditGroup.Motorcycle, this.SkillButtonPanel, "UiItem_MotorcycleMobileKey");
			TouchUiEditApplyHelper.CacheTouchUiEditInitData(ECommonTouchUiEditGroup.MotorcycleRoundStick, this.SkillButtonPanel, "UiItem_MotorcycleMobileKeyRoundStickEdit");
		}

		// Token: 0x0603CD1B RID: 249115 RVA: 0x00E9B158 File Offset: 0x00E99358
		private void ApplyTouchUiEditData()
		{
			this.CacheTouchUiEditInitData();
			if (BattleUiModel.Instance.MotorcycleData.GetIsRoundJoystickButtonLayout())
			{
				TouchUiEditApplyHelper.ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup.MotorcycleRoundStick, this.SkillButtonPanel, "UiItem_MotorcycleMobileKeyRoundStickEdit");
			}
			else
			{
				TouchUiEditApplyHelper.ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup.Motorcycle, this.SkillButtonPanel, "UiItem_MotorcycleMobileKey");
			}
			TouchUiEditApplyHelper.ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup.Motorcycle, this.Joystick, "UiItem_MotorcycleJoystickEdit");
		}

		// Token: 0x0603CD1C RID: 249116 RVA: 0x00E9B1B1 File Offset: 0x00E993B1
		private void OnTouchUiEditSave(ECommonTouchUiEditGroup group)
		{
			if (group != ECommonTouchUiEditGroup.Motorcycle && group != ECommonTouchUiEditGroup.MotorcycleRoundStick)
			{
				return;
			}
			this.ApplyTouchUiEditData();
		}

		// Token: 0x0603CD1D RID: 249117 RVA: 0x00E9B1C2 File Offset: 0x00E993C2
		private void OnMotorcycleRoundJoystickChanged(bool b)
		{
			this.RefreshJoystickEnable();
			this.ApplyTouchUiEditData();
		}

		// Token: 0x0603CD1E RID: 249118 RVA: 0x00E9B1D0 File Offset: 0x00E993D0
		private void RefreshJoystickEnable()
		{
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			this.JoystickEnable = !motorcycleData.GetIsRoundJoystick();
			MotorcycleJoystick joystick = this.Joystick;
			if (joystick == null)
			{
				return;
			}
			joystick.SetEnable(this.JoystickEnable);
		}

		// Token: 0x0401FAE7 RID: 129767
		[Nullable(2)]
		private MotorcycleSkillButtonMobilePanel SkillButtonPanel;

		// Token: 0x0401FAE8 RID: 129768
		[Nullable(2)]
		private MotorcycleJoystick Joystick;

		// Token: 0x0401FAE9 RID: 129769
		private bool JoystickEnable;

		// Token: 0x0200C064 RID: 49252
		private enum EChildType
		{
			// Token: 0x0403A0DC RID: 237788
			SkillButtonPanel,
			// Token: 0x0403A0DD RID: 237789
			JoystickItem
		}
	}
}
