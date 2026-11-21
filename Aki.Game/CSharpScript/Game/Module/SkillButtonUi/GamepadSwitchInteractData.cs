using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BAD RID: 15277
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadSwitchInteractData
	{
		// Token: 0x06027275 RID: 160373 RVA: 0x00AF49B0 File Offset: 0x00AF2BB0
		public void Init(ESkillButtonGamepadDataType gamepadDataType, string exploreActionName)
		{
			this.GamepadDataType = gamepadDataType;
			this.ExploreActionName = exploreActionName;
			this.SwitchTime = ConfigCommonParamById.GetIntConfig("SwitchInteractTime").GetValueOrDefault(500);
		}

		// Token: 0x06027276 RID: 160374 RVA: 0x00AF49E8 File Offset: 0x00AF2BE8
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

		// Token: 0x06027277 RID: 160375 RVA: 0x00AF4A20 File Offset: 0x00AF2C20
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

		// Token: 0x06027278 RID: 160376 RVA: 0x00AF4A7C File Offset: 0x00AF2C7C
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

		// Token: 0x06027279 RID: 160377 RVA: 0x00AF4AE4 File Offset: 0x00AF2CE4
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

		// Token: 0x0602727A RID: 160378 RVA: 0x00AF4B6B File Offset: 0x00AF2D6B
		private void SetState(EGamepadSwitchInteractState state)
		{
			if (this.State == state)
			{
				return;
			}
			this.State = state;
			EventSystem.Instance.Emit(EEventName.BattleUiSwitchInteractStateChanged);
		}

		// Token: 0x0602727B RID: 160379 RVA: 0x00AF4B8E File Offset: 0x00AF2D8E
		private void OnSwitchFinish(float _)
		{
			this.SetState(EGamepadSwitchInteractState.Explore);
			this.SwitchTimer = null;
		}

		// Token: 0x0602727C RID: 160380 RVA: 0x00AF4B9E File Offset: 0x00AF2D9E
		private void DestroySwitchTimer()
		{
			if (this.SwitchTimer != null)
			{
				this.SwitchTimer.Remove();
				this.SwitchTimer = null;
			}
		}

		// Token: 0x04015575 RID: 87413
		public ESkillButtonGamepadDataType GamepadDataType;

		// Token: 0x04015576 RID: 87414
		public bool IsSwitchInteractOpen;

		// Token: 0x04015577 RID: 87415
		public EGamepadSwitchInteractState State;

		// Token: 0x04015578 RID: 87416
		private readonly HashSet<EGamepadInteractExistReason> InteractExistReason = new HashSet<EGamepadInteractExistReason>();

		// Token: 0x04015579 RID: 87417
		public int SwitchTime;

		// Token: 0x0401557A RID: 87418
		[Nullable(2)]
		private TimerHandle SwitchTimer;

		// Token: 0x0401557B RID: 87419
		private bool IsPressExplore;

		// Token: 0x0401557C RID: 87420
		private string ExploreActionName = "幻象1";
	}
}
