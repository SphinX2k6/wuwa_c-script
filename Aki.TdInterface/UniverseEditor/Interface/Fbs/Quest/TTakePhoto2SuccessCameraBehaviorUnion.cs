using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200477D RID: 18301
	public class TTakePhoto2SuccessCameraBehaviorUnion
	{
		// Token: 0x17007FA9 RID: 32681
		// (get) Token: 0x0601AF37 RID: 110391 RVA: 0x003D23C0 File Offset: 0x003D05C0
		// (set) Token: 0x0601AF38 RID: 110392 RVA: 0x003D23C8 File Offset: 0x003D05C8
		public TTakePhoto2SuccessCameraBehavior Type { get; set; }

		// Token: 0x17007FAA RID: 32682
		// (get) Token: 0x0601AF39 RID: 110393 RVA: 0x003D23D1 File Offset: 0x003D05D1
		// (set) Token: 0x0601AF3A RID: 110394 RVA: 0x003D23D9 File Offset: 0x003D05D9
		public object Value { get; set; }

		// Token: 0x0601AF3B RID: 110395 RVA: 0x003D23E2 File Offset: 0x003D05E2
		public TTakePhoto2SuccessCameraBehaviorUnion()
		{
			this.Type = TTakePhoto2SuccessCameraBehavior.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF3C RID: 110396 RVA: 0x003D23F8 File Offset: 0x003D05F8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF3D RID: 110397 RVA: 0x003D240A File Offset: 0x003D060A
		public ITakePhoto2CloseCameraAfterFinishActionsT AsITakePhoto2CloseCameraAfterFinishActions()
		{
			return this.As<ITakePhoto2CloseCameraAfterFinishActionsT>();
		}

		// Token: 0x0601AF3E RID: 110398 RVA: 0x003D2412 File Offset: 0x003D0612
		public static TTakePhoto2SuccessCameraBehaviorUnion FromITakePhoto2CloseCameraAfterFinishActions(ITakePhoto2CloseCameraAfterFinishActionsT _itakephoto2closecameraafterfinishactions)
		{
			return new TTakePhoto2SuccessCameraBehaviorUnion
			{
				Type = TTakePhoto2SuccessCameraBehavior.ITakePhoto2CloseCameraAfterFinishActions,
				Value = _itakephoto2closecameraafterfinishactions
			};
		}

		// Token: 0x0601AF3F RID: 110399 RVA: 0x003D2427 File Offset: 0x003D0627
		public ITakePhoto2KeepCameraOpenT AsITakePhoto2KeepCameraOpen()
		{
			return this.As<ITakePhoto2KeepCameraOpenT>();
		}

		// Token: 0x0601AF40 RID: 110400 RVA: 0x003D242F File Offset: 0x003D062F
		public static TTakePhoto2SuccessCameraBehaviorUnion FromITakePhoto2KeepCameraOpen(ITakePhoto2KeepCameraOpenT _itakephoto2keepcameraopen)
		{
			return new TTakePhoto2SuccessCameraBehaviorUnion
			{
				Type = TTakePhoto2SuccessCameraBehavior.ITakePhoto2KeepCameraOpen,
				Value = _itakephoto2keepcameraopen
			};
		}

		// Token: 0x0601AF41 RID: 110401 RVA: 0x003D2444 File Offset: 0x003D0644
		public static int Pack(FlatBufferBuilder builder, TTakePhoto2SuccessCameraBehaviorUnion _o)
		{
			TTakePhoto2SuccessCameraBehavior type = _o.Type;
			if (type == TTakePhoto2SuccessCameraBehavior.ITakePhoto2CloseCameraAfterFinishActions)
			{
				return ITakePhoto2CloseCameraAfterFinishActions.Pack(builder, _o.AsITakePhoto2CloseCameraAfterFinishActions()).Value;
			}
			if (type != TTakePhoto2SuccessCameraBehavior.ITakePhoto2KeepCameraOpen)
			{
				return 0;
			}
			return ITakePhoto2KeepCameraOpen.Pack(builder, _o.AsITakePhoto2KeepCameraOpen()).Value;
		}
	}
}
