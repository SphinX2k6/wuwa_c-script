using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E62 RID: 32354
	public class TCameraOperationUnion
	{
		// Token: 0x1700F209 RID: 61961
		// (get) Token: 0x0603A715 RID: 239381 RVA: 0x007DE5D2 File Offset: 0x007DC7D2
		// (set) Token: 0x0603A716 RID: 239382 RVA: 0x007DE5DA File Offset: 0x007DC7DA
		public TCameraOperation Type { get; set; }

		// Token: 0x1700F20A RID: 61962
		// (get) Token: 0x0603A717 RID: 239383 RVA: 0x007DE5E3 File Offset: 0x007DC7E3
		// (set) Token: 0x0603A718 RID: 239384 RVA: 0x007DE5EB File Offset: 0x007DC7EB
		public object Value { get; set; }

		// Token: 0x0603A719 RID: 239385 RVA: 0x007DE5F4 File Offset: 0x007DC7F4
		public TCameraOperationUnion()
		{
			this.Type = TCameraOperation.NONE;
			this.Value = null;
		}

		// Token: 0x0603A71A RID: 239386 RVA: 0x007DE60A File Offset: 0x007DC80A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A71B RID: 239387 RVA: 0x007DE61C File Offset: 0x007DC81C
		public IDisableCameraOperationT AsIDisableCameraOperation()
		{
			return this.As<IDisableCameraOperationT>();
		}

		// Token: 0x0603A71C RID: 239388 RVA: 0x007DE624 File Offset: 0x007DC824
		public static TCameraOperationUnion FromIDisableCameraOperation(IDisableCameraOperationT _idisablecameraoperation)
		{
			return new TCameraOperationUnion
			{
				Type = TCameraOperation.IDisableCameraOperation,
				Value = _idisablecameraoperation
			};
		}

		// Token: 0x0603A71D RID: 239389 RVA: 0x007DE639 File Offset: 0x007DC839
		public IEnableCameraOperationT AsIEnableCameraOperation()
		{
			return this.As<IEnableCameraOperationT>();
		}

		// Token: 0x0603A71E RID: 239390 RVA: 0x007DE641 File Offset: 0x007DC841
		public static TCameraOperationUnion FromIEnableCameraOperation(IEnableCameraOperationT _ienablecameraoperation)
		{
			return new TCameraOperationUnion
			{
				Type = TCameraOperation.IEnableCameraOperation,
				Value = _ienablecameraoperation
			};
		}

		// Token: 0x0603A71F RID: 239391 RVA: 0x007DE656 File Offset: 0x007DC856
		public IEnableSectionalCameraOperationT AsIEnableSectionalCameraOperation()
		{
			return this.As<IEnableSectionalCameraOperationT>();
		}

		// Token: 0x0603A720 RID: 239392 RVA: 0x007DE65E File Offset: 0x007DC85E
		public static TCameraOperationUnion FromIEnableSectionalCameraOperation(IEnableSectionalCameraOperationT _ienablesectionalcameraoperation)
		{
			return new TCameraOperationUnion
			{
				Type = TCameraOperation.IEnableSectionalCameraOperation,
				Value = _ienablesectionalcameraoperation
			};
		}

		// Token: 0x0603A721 RID: 239393 RVA: 0x007DE674 File Offset: 0x007DC874
		public static int Pack(FlatBufferBuilder builder, TCameraOperationUnion _o)
		{
			switch (_o.Type)
			{
			case TCameraOperation.IDisableCameraOperation:
				return IDisableCameraOperation.Pack(builder, _o.AsIDisableCameraOperation()).Value;
			case TCameraOperation.IEnableCameraOperation:
				return IEnableCameraOperation.Pack(builder, _o.AsIEnableCameraOperation()).Value;
			case TCameraOperation.IEnableSectionalCameraOperation:
				return IEnableSectionalCameraOperation.Pack(builder, _o.AsIEnableSectionalCameraOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
