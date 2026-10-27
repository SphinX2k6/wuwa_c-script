using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x02007281 RID: 29313
	[NullableContext(2)]
	[Nullable(0)]
	public class TsPureTouchHandle
	{
		// Token: 0x06047D9C RID: 294300 RVA: 0x012627D1 File Offset: 0x012609D1
		public void Initialize(TsBasePlayerController playerController, PlayerInputHandle playerInputHandle)
		{
			this.PlayerController = playerController;
			this.PlayerInputHandle = playerInputHandle;
		}

		// Token: 0x06047D9D RID: 294301 RVA: 0x012627E4 File Offset: 0x012609E4
		public void Reset()
		{
			this.PlayerController = null;
			this.PlayerInputHandle = null;
			if (this.OnTouchBeginDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<TEnumAsByte<ETouchIndex>, FVector>(this.OnTouchBegin));
				this.OnTouchBeginDelegate = null;
			}
			if (this.OnTouchEndDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<TEnumAsByte<ETouchIndex>, FVector>(this.OnTouchEnd));
				this.OnTouchEndDelegate = null;
			}
			if (this.OnTouchMoveDelegate != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(new Action<TEnumAsByte<ETouchIndex>, FVector>(this.OnTouchMove));
				this.OnTouchMoveDelegate = null;
			}
		}

		// Token: 0x06047D9E RID: 294302 RVA: 0x01262860 File Offset: 0x01260A60
		public void BindTouch()
		{
			if (this.PlayerController == null)
			{
				Log.Instance.Error(ELogModule.Input, ELogAuthor.WLJ, "[TsPureTouchHandle::BindTouch]PlayerController为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.OnTouchBeginDelegate == null)
			{
				this.OnTouchBeginDelegate = DelegateUtils.ToManualReleaseDelegate<FTouchBindingDelegate>(new Action<TEnumAsByte<ETouchIndex>, FVector>(this.OnTouchBegin));
			}
			UKuroInputDelegateLibrary.RegisterTouchBinding(EInputEvent.IE_Pressed, this.PlayerController, this.OnTouchBeginDelegate);
			if (this.OnTouchEndDelegate == null)
			{
				this.OnTouchEndDelegate = DelegateUtils.ToManualReleaseDelegate<FTouchBindingDelegate>(new Action<TEnumAsByte<ETouchIndex>, FVector>(this.OnTouchEnd));
			}
			UKuroInputDelegateLibrary.RegisterTouchBinding(EInputEvent.IE_Released, this.PlayerController, this.OnTouchEndDelegate);
			if (this.OnTouchMoveDelegate == null)
			{
				this.OnTouchMoveDelegate = DelegateUtils.ToManualReleaseDelegate<FTouchBindingDelegate>(new Action<TEnumAsByte<ETouchIndex>, FVector>(this.OnTouchMove));
			}
			UKuroInputDelegateLibrary.RegisterTouchBinding(EInputEvent.IE_Repeat, this.PlayerController, this.OnTouchMoveDelegate);
		}

		// Token: 0x06047D9F RID: 294303 RVA: 0x01262925 File Offset: 0x01260B25
		[NullableContext(0)]
		protected void OnTouchBegin(TEnumAsByte<ETouchIndex> touchIndex, FVector position)
		{
			if (this.PlayerInputHandle == null)
			{
				return;
			}
			this.PlayerInputHandle.TouchBegin(touchIndex, position);
			LogReportModel.Instance.RecordOperateTime(false, "", 0.0);
		}

		// Token: 0x06047DA0 RID: 294304 RVA: 0x0126295B File Offset: 0x01260B5B
		[NullableContext(0)]
		protected void OnTouchEnd(TEnumAsByte<ETouchIndex> touchIndex, FVector position)
		{
			if (this.PlayerInputHandle == null)
			{
				return;
			}
			this.PlayerInputHandle.TouchEnd(touchIndex, position);
		}

		// Token: 0x06047DA1 RID: 294305 RVA: 0x01262978 File Offset: 0x01260B78
		[NullableContext(0)]
		protected void OnTouchMove(TEnumAsByte<ETouchIndex> touchIndex, FVector position)
		{
			if (this.PlayerInputHandle == null)
			{
				return;
			}
			this.PlayerInputHandle.TouchMove(touchIndex, position);
		}

		// Token: 0x04025C6E RID: 154734
		private TsBasePlayerController PlayerController;

		// Token: 0x04025C6F RID: 154735
		private PlayerInputHandle PlayerInputHandle;

		// Token: 0x04025C70 RID: 154736
		private FTouchBindingDelegate OnTouchBeginDelegate;

		// Token: 0x04025C71 RID: 154737
		private FTouchBindingDelegate OnTouchEndDelegate;

		// Token: 0x04025C72 RID: 154738
		private FTouchBindingDelegate OnTouchMoveDelegate;
	}
}
