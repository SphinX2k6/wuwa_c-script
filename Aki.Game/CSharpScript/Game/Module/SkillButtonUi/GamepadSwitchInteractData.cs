using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004BFC RID: 19452
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadSwitchInteractData
	{
		// Token: 0x060324CF RID: 206031 RVA: 0x00BB039C File Offset: 0x00BAE59C
		public void Init(ESkillButtonGamepadDataType gamepadDataType, string exploreActionName)
		{
			this.GamepadDataType = gamepadDataType;
			this.ExploreActionName = exploreActionName;
			this.SwitchTime = ConfigCommonParamById.GetIntConfig("SwitchInteractTime").GetValueOrDefault(500);
		}

		// Token: 0x060324D0 RID: 206032 RVA: 0x00BB03D4 File Offset: 0x00BAE5D4
		public void SetInteractExist(bool exist, EGamepadInteractExistReason reason)
		{
			if (exist)
			{
				this.InteractExistReason.Add(reason);
			}
			else
			{
				this.InteractExistReason.Remove(reason);
			}
			this.SetHasInteract(this.InteractExistReason.Count > 0);
		}

		// Token: 0x060324D1 RID: 206033 RVA: 0x00BB040C File Offset: 0x00BAE60C
		public void RefreshSwitchInteractOpen(bool isInit = false)
		{
			bool gamepadOperationPreferences = MenuModel.Instance.GetGamepadOperationPreferences();
			if (gamepadOperationPreferences != this.IsSwitchInteractOpen)
			{
				this.IsSwitchInteractOpen = gamepadOperationPreferences;
				if (!isInit)
				{
					EventSystem.Instance.Emit<bool>(EEventName.BattleUiSwitchInteractOpenChanged, gamepadOperationPreferences);
				}
				this.SetHasInteract(this.InteractExistReason.Count > 0);
				InputDistributeController.Instance.RefreshInputTag();
			}
		}

		// Token: 0x060324D2 RID: 206034 RVA: 0x00BB0468 File Offset: 0x00BAE668
		public void InputInteractButton(bool bPress)
		{
			if (bPress)
			{
				if (this.IsSwitchInteractOpen && Info.Instance.IsInGamepad() && this.State == EGamepadSwitchInteractState.Explore)
				{
					this.IsPressExplore = true;
					InputDistributeController.Instance.InputAction(this.ExploreActionName, true);
					return;
				}
			}
			else if (this.IsPressExplore)
			{
				this.IsPressExplore = false;
				InputDistributeController.Instance.InputAction(this.ExploreActionName, false);
			}
		}

		// Token: 0x060324D3 RID: 206035 RVA: 0x00BB04D0 File Offset: 0x00BAE6D0
		private void SetHasInteract(bool value)
		{
			if (!this.IsSwitchInteractOpen)
			{
				this.SetState(EGamepadSwitchInteractState.Interact);
				return;
			}
			if (value)
			{
				EGamepadSwitchInteractState state = this.State;
				if (state != EGamepadSwitchInteractState.Interact && state - EGamepadSwitchInteractState.Switching <= 1)
				{
					this.DestroySwitchTimer();
					this.SetState(EGamepadSwitchInteractState.Interact);
					return;
				}
			}
			else
			{
				EGamepadSwitchInteractState state = this.State;
				if (state != EGamepadSwitchInteractState.Interact)
				{
					int num = state - EGamepadSwitchInteractState.Switching;
					return;
				}
				this.SetState(EGamepadSwitchInteractState.Switching);
				this.DestroySwitchTimer();
				this.SwitchTimer = TimerSystem.Instance.Delay(new TTimerAction(this.OnSwitchFinish), (float)this.SwitchTime, null, null, true, 1f);
			}
		}

		// Token: 0x060324D4 RID: 206036 RVA: 0x00BB0557 File Offset: 0x00BAE757
		private void SetState(EGamepadSwitchInteractState state)
		{
			if (this.State == state)
			{
				return;
			}
			this.State = state;
			EventSystem.Instance.Emit(EEventName.BattleUiSwitchInteractStateChanged);
		}

		// Token: 0x060324D5 RID: 206037 RVA: 0x00BB057A File Offset: 0x00BAE77A
		private void OnSwitchFinish(float _)
		{
			this.SetState(EGamepadSwitchInteractState.Explore);
			this.SwitchTimer = null;
		}

		// Token: 0x060324D6 RID: 206038 RVA: 0x00BB058A File Offset: 0x00BAE78A
		private void DestroySwitchTimer()
		{
			if (this.SwitchTimer != null)
			{
				this.SwitchTimer.Remove();
				this.SwitchTimer = null;
			}
		}

		// Token: 0x0401AC1B RID: 109595
		public ESkillButtonGamepadDataType GamepadDataType;

		// Token: 0x0401AC1C RID: 109596
		public bool IsSwitchInteractOpen;

		// Token: 0x0401AC1D RID: 109597
		public EGamepadSwitchInteractState State;

		// Token: 0x0401AC1E RID: 109598
		private readonly HashSet<EGamepadInteractExistReason> InteractExistReason = new HashSet<EGamepadInteractExistReason>();

		// Token: 0x0401AC1F RID: 109599
		public int SwitchTime;

		// Token: 0x0401AC20 RID: 109600
		[Nullable(2)]
		private TimerHandle SwitchTimer;

		// Token: 0x0401AC21 RID: 109601
		private bool IsPressExplore;

		// Token: 0x0401AC22 RID: 109602
		private string ExploreActionName = "幻象1";
	}
}
