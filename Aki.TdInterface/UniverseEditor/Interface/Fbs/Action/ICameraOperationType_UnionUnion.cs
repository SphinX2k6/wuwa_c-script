using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006297 RID: 25239
	public class ICameraOperationType_UnionUnion
	{
		// Token: 0x1700BC59 RID: 48217
		// (get) Token: 0x0602B995 RID: 178581 RVA: 0x0060089D File Offset: 0x005FEA9D
		// (set) Token: 0x0602B996 RID: 178582 RVA: 0x006008A5 File Offset: 0x005FEAA5
		public ICameraOperationType_Union Type { get; set; }

		// Token: 0x1700BC5A RID: 48218
		// (get) Token: 0x0602B997 RID: 178583 RVA: 0x006008AE File Offset: 0x005FEAAE
		// (set) Token: 0x0602B998 RID: 178584 RVA: 0x006008B6 File Offset: 0x005FEAB6
		public object Value { get; set; }

		// Token: 0x0602B999 RID: 178585 RVA: 0x006008BF File Offset: 0x005FEABF
		public ICameraOperationType_UnionUnion()
		{
			this.Type = ICameraOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B99A RID: 178586 RVA: 0x006008D5 File Offset: 0x005FEAD5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B99B RID: 178587 RVA: 0x006008E7 File Offset: 0x005FEAE7
		public ICameraOperationTypeT AsICameraOperationType()
		{
			return this.As<ICameraOperationTypeT>();
		}

		// Token: 0x0602B99C RID: 178588 RVA: 0x006008EF File Offset: 0x005FEAEF
		public static ICameraOperationType_UnionUnion FromICameraOperationType(ICameraOperationTypeT _icameraoperationtype)
		{
			return new ICameraOperationType_UnionUnion
			{
				Type = ICameraOperationType_Union.ICameraOperationType,
				Value = _icameraoperationtype
			};
		}

		// Token: 0x0602B99D RID: 178589 RVA: 0x00600904 File Offset: 0x005FEB04
		public IEnableCameraOperationT AsIEnableCameraOperation()
		{
			return this.As<IEnableCameraOperationT>();
		}

		// Token: 0x0602B99E RID: 178590 RVA: 0x0060090C File Offset: 0x005FEB0C
		public static ICameraOperationType_UnionUnion FromIEnableCameraOperation(IEnableCameraOperationT _ienablecameraoperation)
		{
			return new ICameraOperationType_UnionUnion
			{
				Type = ICameraOperationType_Union.IEnableCameraOperation,
				Value = _ienablecameraoperation
			};
		}

		// Token: 0x0602B99F RID: 178591 RVA: 0x00600921 File Offset: 0x005FEB21
		public IEnableSectionalCameraOperationT AsIEnableSectionalCameraOperation()
		{
			return this.As<IEnableSectionalCameraOperationT>();
		}

		// Token: 0x0602B9A0 RID: 178592 RVA: 0x00600929 File Offset: 0x005FEB29
		public static ICameraOperationType_UnionUnion FromIEnableSectionalCameraOperation(IEnableSectionalCameraOperationT _ienablesectionalcameraoperation)
		{
			return new ICameraOperationType_UnionUnion
			{
				Type = ICameraOperationType_Union.IEnableSectionalCameraOperation,
				Value = _ienablesectionalcameraoperation
			};
		}

		// Token: 0x0602B9A1 RID: 178593 RVA: 0x0060093E File Offset: 0x005FEB3E
		public IDisableCameraOperationT AsIDisableCameraOperation()
		{
			return this.As<IDisableCameraOperationT>();
		}

		// Token: 0x0602B9A2 RID: 178594 RVA: 0x00600946 File Offset: 0x005FEB46
		public static ICameraOperationType_UnionUnion FromIDisableCameraOperation(IDisableCameraOperationT _idisablecameraoperation)
		{
			return new ICameraOperationType_UnionUnion
			{
				Type = ICameraOperationType_Union.IDisableCameraOperation,
				Value = _idisablecameraoperation
			};
		}

		// Token: 0x0602B9A3 RID: 178595 RVA: 0x0060095C File Offset: 0x005FEB5C
		public static int Pack(FlatBufferBuilder builder, ICameraOperationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICameraOperationType_Union.ICameraOperationType:
				return ICameraOperationType.Pack(builder, _o.AsICameraOperationType()).Value;
			case ICameraOperationType_Union.IEnableCameraOperation:
				return IEnableCameraOperation.Pack(builder, _o.AsIEnableCameraOperation()).Value;
			case ICameraOperationType_Union.IEnableSectionalCameraOperation:
				return IEnableSectionalCameraOperation.Pack(builder, _o.AsIEnableSectionalCameraOperation()).Value;
			case ICameraOperationType_Union.IDisableCameraOperation:
				return IDisableCameraOperation.Pack(builder, _o.AsIDisableCameraOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
