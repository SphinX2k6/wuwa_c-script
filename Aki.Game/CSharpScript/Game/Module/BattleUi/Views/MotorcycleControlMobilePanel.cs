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
	// Token: 0x02004D7B RID: 19835
	public class MotorcycleControlMobilePanel : MotorcycleControlPanelBase
	{
		// Token: 0x06031C6E RID: 203886 RVA: 0x00DEB778 File Offset: 0x00DE9978
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

		// Token: 0x06031C6F RID: 203887 RVA: 0x00DEB7E4 File Offset: 0x00DE99E4
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleControlMobilePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleControlMobilePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031C70 RID: 203888 RVA: 0x00DEB828 File Offset: 0x00DE9A28
		private UniTask NewSkillButtonPanel()
		{
			MotorcycleControlMobilePanel.<NewSkillButtonPanel>d__6 <NewSkillButtonPanel>d__;
			<NewSkillButtonPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewSkillButtonPanel>d__.<>4__this = this;
			<NewSkillButtonPanel>d__.<>1__state = -1;
			<NewSkillButtonPanel>d__.<>t__builder.Start<MotorcycleControlMobilePanel.<NewSkillButtonPanel>d__6>(ref <NewSkillButtonPanel>d__);
			return <NewSkillButtonPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06031C71 RID: 203889 RVA: 0x00DEB86C File Offset: 0x00DE9A6C
		private UniTask NewJoysticks()
		{
			MotorcycleControlMobilePanel.<NewJoysticks>d__7 <NewJoysticks>d__;
			<NewJoysticks>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewJoysticks>d__.<>4__this = this;
			<NewJoysticks>d__.<>1__state = -1;
			<NewJoysticks>d__.<>t__builder.Start<MotorcycleControlMobilePanel.<NewJoysticks>d__7>(ref <NewJoysticks>d__);
			return <NewJoysticks>d__.<>t__builder.Task;
		}

		// Token: 0x06031C72 RID: 203890 RVA: 0x00DEB8AF File Offset: 0x00DE9AAF
		protected override void OnStart()
		{
			base.OnStart();
			this.RefreshJoystickEnable();
			EventSystem.Instance.Add<bool>(EEventName.OnMotorcycleRoundJoystickChanged, new Action<bool>(this.OnMotorcycleRoundJoystickChanged));
		}

		// Token: 0x06031C73 RID: 203891 RVA: 0x00DEB8D9 File Offset: 0x00DE9AD9
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

		// Token: 0x06031C74 RID: 203892 RVA: 0x00DEB916 File Offset: 0x00DE9B16
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

		// Token: 0x06031C75 RID: 203893 RVA: 0x00DEB94D File Offset: 0x00DE9B4D
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

		// Token: 0x06031C76 RID: 203894 RVA: 0x00DEB984 File Offset: 0x00DE9B84
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

		// Token: 0x06031C77 RID: 203895 RVA: 0x00DEB9EB File Offset: 0x00DE9BEB
		private void CacheTouchUiEditInitData()
		{
			TouchUiEditApplyHelper.CacheTouchUiEditInitData(ECommonTouchUiEditGroup.Motorcycle, this.SkillButtonPanel, "UiItem_MotorcycleMobileKey");
			TouchUiEditApplyHelper.CacheTouchUiEditInitData(ECommonTouchUiEditGroup.MotorcycleRoundStick, this.SkillButtonPanel, "UiItem_MotorcycleMobileKeyRoundStickEdit");
		}

		// Token: 0x06031C78 RID: 203896 RVA: 0x00DEBA10 File Offset: 0x00DE9C10
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

		// Token: 0x06031C79 RID: 203897 RVA: 0x00DEBA69 File Offset: 0x00DE9C69
		private void OnTouchUiEditSave(ECommonTouchUiEditGroup group)
		{
			if (group != ECommonTouchUiEditGroup.Motorcycle && group != ECommonTouchUiEditGroup.MotorcycleRoundStick)
			{
				return;
			}
			this.ApplyTouchUiEditData();
		}

		// Token: 0x06031C7A RID: 203898 RVA: 0x00DEBA7A File Offset: 0x00DE9C7A
		private void OnMotorcycleRoundJoystickChanged(bool b)
		{
			this.RefreshJoystickEnable();
			this.ApplyTouchUiEditData();
		}

		// Token: 0x06031C7B RID: 203899 RVA: 0x00DEBA88 File Offset: 0x00DE9C88
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

		// Token: 0x0401A59F RID: 107935
		[Nullable(2)]
		private MotorcycleSkillButtonMobilePanel SkillButtonPanel;

		// Token: 0x0401A5A0 RID: 107936
		[Nullable(2)]
		private MotorcycleJoystick Joystick;

		// Token: 0x0401A5A1 RID: 107937
		private bool JoystickEnable;

		// Token: 0x0200AA6A RID: 43626
		private enum EChildType
		{
			// Token: 0x04034A9F RID: 215711
			SkillButtonPanel,
			// Token: 0x04034AA0 RID: 215712
			JoystickItem
		}
	}
}
