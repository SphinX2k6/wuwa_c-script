using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x020063FF RID: 25599
	[NullableContext(2)]
	[Nullable(0)]
	public class TsPureKeyHandle
	{
		// Token: 0x0603E156 RID: 254294 RVA: 0x0120304B File Offset: 0x0120124B
		public void Initialize(TsBasePlayerController playerController, PlayerInputHandle playerInputHandle)
		{
			this.PlayerController = playerController;
			this.PlayerInputHandle = playerInputHandle;
		}

		// Token: 0x0603E157 RID: 254295 RVA: 0x0120305B File Offset: 0x0120125B
		public void Reset()
		{
			this.PlayerController = null;
			this.PlayerInputHandle = null;
		}

		// Token: 0x0603E158 RID: 254296 RVA: 0x0120306C File Offset: 0x0120126C
		public void BindKey()
		{
			if (this.OnPressAnyKeyDelegate == null)
			{
				this.OnPressAnyKeyDelegate = new FKeyBindingDelegate();
				this.OnPressAnyKeyDelegate.Bind(new Action<FKey>(this.OnPressAnyKey));
			}
			if (this.OnReleaseAnyKeyDelegate == null)
			{
				this.OnReleaseAnyKeyDelegate = new FKeyBindingDelegate();
				this.OnReleaseAnyKeyDelegate.Bind(new Action<FKey>(this.OnReleaseAnyKey));
			}
			FInputChord finputChord = new FInputChord();
			finputChord.Key = new FKey
			{
				KeyName = (FNameUtil.GetDynamicFName("AnyKey") ?? FName.NAME_None)
			};
			EInputEvent keyEvent = EInputEvent.IE_Pressed;
			TsBasePlayerController playerController = this.PlayerController;
			if (playerController == null)
			{
				throw new NullReferenceException();
			}
			UKuroInputDelegateLibrary.RegisterKeyBinding(finputChord, keyEvent, playerController, this.OnPressAnyKeyDelegate);
			FInputChord finputChord2 = new FInputChord();
			finputChord2.Key = new FKey
			{
				KeyName = (FNameUtil.GetDynamicFName("AnyKey") ?? FName.NAME_None)
			};
			EInputEvent keyEvent2 = EInputEvent.IE_Released;
			TsBasePlayerController playerController2 = this.PlayerController;
			if (playerController2 == null)
			{
				throw new NullReferenceException();
			}
			UKuroInputDelegateLibrary.RegisterKeyBinding(finputChord2, keyEvent2, playerController2, this.OnReleaseAnyKeyDelegate);
		}

		// Token: 0x0603E159 RID: 254297 RVA: 0x01203175 File Offset: 0x01201375
		[NullableContext(1)]
		protected void OnPressAnyKey(FKey key)
		{
			PlatformModel.Instance.OnPressAnyKey(key);
			LogReportModel.Instance.RecordOperateTime(false, "", 0.0);
			PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
			if (playerInputHandle == null)
			{
				throw new NullReferenceException();
			}
			playerInputHandle.PressAnyKey(key);
		}

		// Token: 0x0603E15A RID: 254298 RVA: 0x012031B1 File Offset: 0x012013B1
		[NullableContext(1)]
		protected void OnReleaseAnyKey(FKey key)
		{
			PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
			if (playerInputHandle == null)
			{
				throw new NullReferenceException();
			}
			playerInputHandle.ReleaseAnyKey(key);
		}

		// Token: 0x04020F2A RID: 134954
		private TsBasePlayerController PlayerController;

		// Token: 0x04020F2B RID: 134955
		private PlayerInputHandle PlayerInputHandle;

		// Token: 0x04020F2C RID: 134956
		private FKeyBindingDelegate OnPressAnyKeyDelegate;

		// Token: 0x04020F2D RID: 134957
		private FKeyBindingDelegate OnReleaseAnyKeyDelegate;
	}
}
