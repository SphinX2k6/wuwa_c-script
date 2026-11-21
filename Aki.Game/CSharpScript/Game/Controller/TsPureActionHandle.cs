using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x020063FD RID: 25597
	[NullableContext(2)]
	[Nullable(0)]
	public class TsPureActionHandle
	{
		// Token: 0x0603E149 RID: 254281 RVA: 0x01202CBA File Offset: 0x01200EBA
		[NullableContext(1)]
		public void Initialize(TsBasePlayerController playerController)
		{
			this.PlayerController = playerController;
			this.OnPressStat = Stat.Create("TsPureActionHandle.OnPressAction", "", "STATGROUP_KuroBattle");
			this.OnReleaseStat = Stat.Create("TsPureActionHandle.OnReleaseAction", "", "STATGROUP_KuroBattle");
		}

		// Token: 0x0603E14A RID: 254282 RVA: 0x01202CF8 File Offset: 0x01200EF8
		[NullableContext(1)]
		public void AddActionBinding(string actionName, Action<string, bool, FKey> onInputAction)
		{
			this.ActionName = actionName;
			this.OnInputActionCallback = onInputAction;
			FName value = FNameUtil.GetDynamicFName(actionName).Value;
			if (this.OnPressActionDelegate == null)
			{
				this.OnPressActionDelegate = DelegateUtils.ToManualReleaseDelegate<FActionBindingDelegate>(new Action<FKey>(this.OnPressAction));
			}
			UKuroInputDelegateLibrary.RegisterActionBinding(value, EInputEvent.IE_Pressed, this.PlayerController, this.OnPressActionDelegate);
			if (this.OnReleaseActionDelegate == null)
			{
				this.OnReleaseActionDelegate = DelegateUtils.ToManualReleaseDelegate<FActionBindingDelegate>(new Action<FKey>(this.OnReleaseAction));
			}
			UKuroInputDelegateLibrary.RegisterActionBinding(value, EInputEvent.IE_Released, this.PlayerController, this.OnReleaseActionDelegate);
		}

		// Token: 0x0603E14B RID: 254283 RVA: 0x01202D84 File Offset: 0x01200F84
		[NullableContext(1)]
		private void OnPressAction(FKey key)
		{
			if (this.OnInputActionCallback != null)
			{
				this.OnInputActionCallback(this.ActionName, true, key);
			}
		}

		// Token: 0x0603E14C RID: 254284 RVA: 0x01202DA1 File Offset: 0x01200FA1
		[NullableContext(1)]
		private void OnReleaseAction(FKey key)
		{
			if (this.OnInputActionCallback != null)
			{
				this.OnInputActionCallback(this.ActionName, false, key);
			}
		}

		// Token: 0x0603E14D RID: 254285 RVA: 0x01202DC0 File Offset: 0x01200FC0
		public void Reset()
		{
			this.PlayerController = null;
			this.ActionName = null;
			this.OnInputActionCallback = null;
			if (this.OnReleaseActionDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FKey>(this.OnPressAction));
				this.OnReleaseActionDelegate = null;
			}
			if (this.OnPressActionDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<FKey>(this.OnReleaseAction));
				this.OnPressActionDelegate = null;
			}
		}

		// Token: 0x04020F1C RID: 134940
		private TsBasePlayerController PlayerController;

		// Token: 0x04020F1D RID: 134941
		private string ActionName;

		// Token: 0x04020F1E RID: 134942
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<string, bool, FKey> OnInputActionCallback;

		// Token: 0x04020F1F RID: 134943
		private Stat OnPressStat;

		// Token: 0x04020F20 RID: 134944
		private Stat OnReleaseStat;

		// Token: 0x04020F21 RID: 134945
		private FActionBindingDelegate OnPressActionDelegate;

		// Token: 0x04020F22 RID: 134946
		private FActionBindingDelegate OnReleaseActionDelegate;
	}
}
