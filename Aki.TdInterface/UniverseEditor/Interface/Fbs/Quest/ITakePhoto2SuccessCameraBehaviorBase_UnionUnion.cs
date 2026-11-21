using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E1 RID: 17889
	public class ITakePhoto2SuccessCameraBehaviorBase_UnionUnion
	{
		// Token: 0x17007D18 RID: 32024
		// (get) Token: 0x0601A20D RID: 107021 RVA: 0x003B8F15 File Offset: 0x003B7115
		// (set) Token: 0x0601A20E RID: 107022 RVA: 0x003B8F1D File Offset: 0x003B711D
		public ITakePhoto2SuccessCameraBehaviorBase_Union Type { get; set; }

		// Token: 0x17007D19 RID: 32025
		// (get) Token: 0x0601A20F RID: 107023 RVA: 0x003B8F26 File Offset: 0x003B7126
		// (set) Token: 0x0601A210 RID: 107024 RVA: 0x003B8F2E File Offset: 0x003B712E
		public object Value { get; set; }

		// Token: 0x0601A211 RID: 107025 RVA: 0x003B8F37 File Offset: 0x003B7137
		public ITakePhoto2SuccessCameraBehaviorBase_UnionUnion()
		{
			this.Type = ITakePhoto2SuccessCameraBehaviorBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A212 RID: 107026 RVA: 0x003B8F4D File Offset: 0x003B714D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A213 RID: 107027 RVA: 0x003B8F5F File Offset: 0x003B715F
		public ITakePhoto2SuccessCameraBehaviorBaseT AsITakePhoto2SuccessCameraBehaviorBase()
		{
			return this.As<ITakePhoto2SuccessCameraBehaviorBaseT>();
		}

		// Token: 0x0601A214 RID: 107028 RVA: 0x003B8F67 File Offset: 0x003B7167
		public static ITakePhoto2SuccessCameraBehaviorBase_UnionUnion FromITakePhoto2SuccessCameraBehaviorBase(ITakePhoto2SuccessCameraBehaviorBaseT _itakephoto2successcamerabehaviorbase)
		{
			return new ITakePhoto2SuccessCameraBehaviorBase_UnionUnion
			{
				Type = ITakePhoto2SuccessCameraBehaviorBase_Union.ITakePhoto2SuccessCameraBehaviorBase,
				Value = _itakephoto2successcamerabehaviorbase
			};
		}

		// Token: 0x0601A215 RID: 107029 RVA: 0x003B8F7C File Offset: 0x003B717C
		public ITakePhoto2KeepCameraOpenT AsITakePhoto2KeepCameraOpen()
		{
			return this.As<ITakePhoto2KeepCameraOpenT>();
		}

		// Token: 0x0601A216 RID: 107030 RVA: 0x003B8F84 File Offset: 0x003B7184
		public static ITakePhoto2SuccessCameraBehaviorBase_UnionUnion FromITakePhoto2KeepCameraOpen(ITakePhoto2KeepCameraOpenT _itakephoto2keepcameraopen)
		{
			return new ITakePhoto2SuccessCameraBehaviorBase_UnionUnion
			{
				Type = ITakePhoto2SuccessCameraBehaviorBase_Union.ITakePhoto2KeepCameraOpen,
				Value = _itakephoto2keepcameraopen
			};
		}

		// Token: 0x0601A217 RID: 107031 RVA: 0x003B8F99 File Offset: 0x003B7199
		public ITakePhoto2CloseCameraAfterFinishActionsT AsITakePhoto2CloseCameraAfterFinishActions()
		{
			return this.As<ITakePhoto2CloseCameraAfterFinishActionsT>();
		}

		// Token: 0x0601A218 RID: 107032 RVA: 0x003B8FA1 File Offset: 0x003B71A1
		public static ITakePhoto2SuccessCameraBehaviorBase_UnionUnion FromITakePhoto2CloseCameraAfterFinishActions(ITakePhoto2CloseCameraAfterFinishActionsT _itakephoto2closecameraafterfinishactions)
		{
			return new ITakePhoto2SuccessCameraBehaviorBase_UnionUnion
			{
				Type = ITakePhoto2SuccessCameraBehaviorBase_Union.ITakePhoto2CloseCameraAfterFinishActions,
				Value = _itakephoto2closecameraafterfinishactions
			};
		}

		// Token: 0x0601A219 RID: 107033 RVA: 0x003B8FB8 File Offset: 0x003B71B8
		public static int Pack(FlatBufferBuilder builder, ITakePhoto2SuccessCameraBehaviorBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITakePhoto2SuccessCameraBehaviorBase_Union.ITakePhoto2SuccessCameraBehaviorBase:
				return ITakePhoto2SuccessCameraBehaviorBase.Pack(builder, _o.AsITakePhoto2SuccessCameraBehaviorBase()).Value;
			case ITakePhoto2SuccessCameraBehaviorBase_Union.ITakePhoto2KeepCameraOpen:
				return ITakePhoto2KeepCameraOpen.Pack(builder, _o.AsITakePhoto2KeepCameraOpen()).Value;
			case ITakePhoto2SuccessCameraBehaviorBase_Union.ITakePhoto2CloseCameraAfterFinishActions:
				return ITakePhoto2CloseCameraAfterFinishActions.Pack(builder, _o.AsITakePhoto2CloseCameraAfterFinishActions()).Value;
			default:
				return 0;
			}
		}
	}
}
