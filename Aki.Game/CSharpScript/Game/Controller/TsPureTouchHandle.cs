using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Controller
{
	// Token: 0x02006400 RID: 25600
	[NullableContext(2)]
	[Nullable(0)]
	public class TsPureTouchHandle
	{
		// Token: 0x0603E15C RID: 254300 RVA: 0x012031D1 File Offset: 0x012013D1
		public void Initialize(TsBasePlayerController playerController, PlayerInputHandle playerInputHandle)
		{
			this.PlayerController = playerController;
			this.PlayerInputHandle = playerInputHandle;
		}

		// Token: 0x0603E15D RID: 254301 RVA: 0x012031E4 File Offset: 0x012013E4
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

		// Token: 0x0603E15E RID: 254302 RVA: 0x01203260 File Offset: 0x01201460
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

		// Token: 0x0603E15F RID: 254303 RVA: 0x01203325 File Offset: 0x01201525
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

		// Token: 0x0603E160 RID: 254304 RVA: 0x0120335B File Offset: 0x0120155B
		[NullableContext(0)]
		protected void OnTouchEnd(TEnumAsByte<ETouchIndex> touchIndex, FVector position)
		{
			if (this.PlayerInputHandle == null)
			{
				return;
			}
			this.PlayerInputHandle.TouchEnd(touchIndex, position);
		}

		// Token: 0x0603E161 RID: 254305 RVA: 0x01203378 File Offset: 0x01201578
		[NullableContext(0)]
		protected void OnTouchMove(TEnumAsByte<ETouchIndex> touchIndex, FVector position)
		{
			if (this.PlayerInputHandle == null)
			{
				return;
			}
			this.PlayerInputHandle.TouchMove(touchIndex, position);
		}

		// Token: 0x04020F2E RID: 134958
		private TsBasePlayerController PlayerController;

		// Token: 0x04020F2F RID: 134959
		private PlayerInputHandle PlayerInputHandle;

		// Token: 0x04020F30 RID: 134960
		private FTouchBindingDelegate OnTouchBeginDelegate;

		// Token: 0x04020F31 RID: 134961
		private FTouchBindingDelegate OnTouchEndDelegate;

		// Token: 0x04020F32 RID: 134962
		private FTouchBindingDelegate OnTouchMoveDelegate;
	}
}
