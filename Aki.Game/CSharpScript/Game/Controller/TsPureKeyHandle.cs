using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x02007280 RID: 29312
	[NullableContext(2)]
	[Nullable(0)]
	public class TsPureKeyHandle
	{
		// Token: 0x06047D96 RID: 294294 RVA: 0x01262607 File Offset: 0x01260807
		public void Initialize(TsBasePlayerController playerController, PlayerInputHandle playerInputHandle)
		{
			this.PlayerController = playerController;
			this.PlayerInputHandle = playerInputHandle;
		}

		// Token: 0x06047D97 RID: 294295 RVA: 0x01262617 File Offset: 0x01260817
		public void Reset()
		{
			this.PlayerController = null;
			this.PlayerInputHandle = null;
		}

		// Token: 0x06047D98 RID: 294296 RVA: 0x01262628 File Offset: 0x01260828
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
			FInputChord chord = new FInputChord(new FKey(FNameUtil.GetDynamicFName("AnyKey") ?? FName.NAME_None), false, false, false, false);
			EInputEvent keyEvent = EInputEvent.IE_Pressed;
			TsBasePlayerController playerController = this.PlayerController;
			if (playerController == null)
			{
				throw new NullReferenceException();
			}
			UKuroInputDelegateLibrary.RegisterKeyBinding(chord, keyEvent, playerController, this.OnPressAnyKeyDelegate);
			FInputChord chord2 = new FInputChord(new FKey(FNameUtil.GetDynamicFName("AnyKey") ?? FName.NAME_None), false, false, false, false);
			EInputEvent keyEvent2 = EInputEvent.IE_Released;
			TsBasePlayerController playerController2 = this.PlayerController;
			if (playerController2 == null)
			{
				throw new NullReferenceException();
			}
			UKuroInputDelegateLibrary.RegisterKeyBinding(chord2, keyEvent2, playerController2, this.OnReleaseAnyKeyDelegate);
		}

		// Token: 0x06047D99 RID: 294297 RVA: 0x01262724 File Offset: 0x01260924
		[NullableContext(1)]
		protected void OnPressAnyKey(FKey key)
		{
			if (!Info.Instance.IsBuildShipping)
			{
				TsBasePlayerController playerController = this.PlayerController;
				if (playerController == null)
				{
					throw new NullReferenceException();
				}
				playerController.OnPressAnyKey(key);
				return;
			}
			else
			{
				PlatformModel.Instance.OnPressAnyKey(key);
				LogReportModel.Instance.RecordOperateTime(false, "", 0.0);
				PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
				if (playerInputHandle == null)
				{
					throw new NullReferenceException();
				}
				playerInputHandle.PressAnyKey(key);
				return;
			}
		}

		// Token: 0x06047D9A RID: 294298 RVA: 0x0126278E File Offset: 0x0126098E
		[NullableContext(1)]
		protected void OnReleaseAnyKey(FKey key)
		{
			if (!Info.Instance.IsBuildShipping)
			{
				TsBasePlayerController playerController = this.PlayerController;
				if (playerController == null)
				{
					throw new NullReferenceException();
				}
				playerController.OnReleaseAnyKey(key);
				return;
			}
			else
			{
				PlayerInputHandle playerInputHandle = this.PlayerInputHandle;
				if (playerInputHandle == null)
				{
					throw new NullReferenceException();
				}
				playerInputHandle.ReleaseAnyKey(key);
				return;
			}
		}

		// Token: 0x04025C6A RID: 154730
		private TsBasePlayerController PlayerController;

		// Token: 0x04025C6B RID: 154731
		private PlayerInputHandle PlayerInputHandle;

		// Token: 0x04025C6C RID: 154732
		private FKeyBindingDelegate OnPressAnyKeyDelegate;

		// Token: 0x04025C6D RID: 154733
		private FKeyBindingDelegate OnReleaseAnyKeyDelegate;
	}
}
