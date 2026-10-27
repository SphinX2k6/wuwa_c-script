using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x0200727E RID: 29310
	[NullableContext(2)]
	[Nullable(0)]
	public class TsPureActionHandle
	{
		// Token: 0x06047D89 RID: 294281 RVA: 0x01262276 File Offset: 0x01260476
		[NullableContext(1)]
		public void Initialize(TsBasePlayerController playerController)
		{
			this.PlayerController = playerController;
			this.OnPressStat = Stat.Create("TsPureActionHandle.OnPressAction", "", "STATGROUP_KuroBattle");
			this.OnReleaseStat = Stat.Create("TsPureActionHandle.OnReleaseAction", "", "STATGROUP_KuroBattle");
		}

		// Token: 0x06047D8A RID: 294282 RVA: 0x012622B4 File Offset: 0x012604B4
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

		// Token: 0x06047D8B RID: 294283 RVA: 0x01262340 File Offset: 0x01260540
		[NullableContext(1)]
		private void OnPressAction(FKey key)
		{
			if (this.OnInputActionCallback != null)
			{
				this.OnInputActionCallback(this.ActionName, true, key);
			}
		}

		// Token: 0x06047D8C RID: 294284 RVA: 0x0126235D File Offset: 0x0126055D
		[NullableContext(1)]
		private void OnReleaseAction(FKey key)
		{
			if (this.OnInputActionCallback != null)
			{
				this.OnInputActionCallback(this.ActionName, false, key);
			}
		}

		// Token: 0x06047D8D RID: 294285 RVA: 0x0126237C File Offset: 0x0126057C
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

		// Token: 0x04025C5C RID: 154716
		private TsBasePlayerController PlayerController;

		// Token: 0x04025C5D RID: 154717
		private string ActionName;

		// Token: 0x04025C5E RID: 154718
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Action<string, bool, FKey> OnInputActionCallback;

		// Token: 0x04025C5F RID: 154719
		private Stat OnPressStat;

		// Token: 0x04025C60 RID: 154720
		private Stat OnReleaseStat;

		// Token: 0x04025C61 RID: 154721
		private FActionBindingDelegate OnPressActionDelegate;

		// Token: 0x04025C62 RID: 154722
		private FActionBindingDelegate OnReleaseActionDelegate;
	}
}
