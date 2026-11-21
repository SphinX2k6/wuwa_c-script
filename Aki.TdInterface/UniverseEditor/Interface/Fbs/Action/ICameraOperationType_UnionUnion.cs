using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006908 RID: 26888
	public class ICameraOperationType_UnionUnion
	{
		// Token: 0x1700C5E1 RID: 50657
		// (get) Token: 0x0602E0F6 RID: 188662 RVA: 0x0064B6A5 File Offset: 0x006498A5
		// (set) Token: 0x0602E0F7 RID: 188663 RVA: 0x0064B6AD File Offset: 0x006498AD
		public ICameraOperationType_Union Type { get; set; }

		// Token: 0x1700C5E2 RID: 50658
		// (get) Token: 0x0602E0F8 RID: 188664 RVA: 0x0064B6B6 File Offset: 0x006498B6
		// (set) Token: 0x0602E0F9 RID: 188665 RVA: 0x0064B6BE File Offset: 0x006498BE
		public object Value { get; set; }

		// Token: 0x0602E0FA RID: 188666 RVA: 0x0064B6C7 File Offset: 0x006498C7
		public ICameraOperationType_UnionUnion()
		{
			this.Type = ICameraOperationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E0FB RID: 188667 RVA: 0x0064B6DD File Offset: 0x006498DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E0FC RID: 188668 RVA: 0x0064B6EF File Offset: 0x006498EF
		public ICameraOperationTypeT AsICameraOperationType()
		{
			return this.As<ICameraOperationTypeT>();
		}

		// Token: 0x0602E0FD RID: 188669 RVA: 0x0064B6F7 File Offset: 0x006498F7
		public static ICameraOperationType_UnionUnion FromICameraOperationType(ICameraOperationTypeT _icameraoperationtype)
		{
			return new ICameraOperationType_UnionUnion
			{
				Type = ICameraOperationType_Union.ICameraOperationType,
				Value = _icameraoperationtype
			};
		}

		// Token: 0x0602E0FE RID: 188670 RVA: 0x0064B70C File Offset: 0x0064990C
		public IEnableCameraOperationT AsIEnableCameraOperation()
		{
			return this.As<IEnableCameraOperationT>();
		}

		// Token: 0x0602E0FF RID: 188671 RVA: 0x0064B714 File Offset: 0x00649914
		public static ICameraOperationType_UnionUnion FromIEnableCameraOperation(IEnableCameraOperationT _ienablecameraoperation)
		{
			return new ICameraOperationType_UnionUnion
			{
				Type = ICameraOperationType_Union.IEnableCameraOperation,
				Value = _ienablecameraoperation
			};
		}

		// Token: 0x0602E100 RID: 188672 RVA: 0x0064B729 File Offset: 0x00649929
		public IEnableSectionalCameraOperationT AsIEnableSectionalCameraOperation()
		{
			return this.As<IEnableSectionalCameraOperationT>();
		}

		// Token: 0x0602E101 RID: 188673 RVA: 0x0064B731 File Offset: 0x00649931
		public static ICameraOperationType_UnionUnion FromIEnableSectionalCameraOperation(IEnableSectionalCameraOperationT _ienablesectionalcameraoperation)
		{
			return new ICameraOperationType_UnionUnion
			{
				Type = ICameraOperationType_Union.IEnableSectionalCameraOperation,
				Value = _ienablesectionalcameraoperation
			};
		}

		// Token: 0x0602E102 RID: 188674 RVA: 0x0064B746 File Offset: 0x00649946
		public IDisableCameraOperationT AsIDisableCameraOperation()
		{
			return this.As<IDisableCameraOperationT>();
		}

		// Token: 0x0602E103 RID: 188675 RVA: 0x0064B74E File Offset: 0x0064994E
		public static ICameraOperationType_UnionUnion FromIDisableCameraOperation(IDisableCameraOperationT _idisablecameraoperation)
		{
			return new ICameraOperationType_UnionUnion
			{
				Type = ICameraOperationType_Union.IDisableCameraOperation,
				Value = _idisablecameraoperation
			};
		}

		// Token: 0x0602E104 RID: 188676 RVA: 0x0064B764 File Offset: 0x00649964
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
