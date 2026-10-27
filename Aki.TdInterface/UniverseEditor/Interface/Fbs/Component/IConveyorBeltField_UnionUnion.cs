using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005031 RID: 20529
	public class IConveyorBeltField_UnionUnion
	{
		// Token: 0x170094FE RID: 38142
		// (get) Token: 0x06020E3F RID: 134719 RVA: 0x00492DD1 File Offset: 0x00490FD1
		// (set) Token: 0x06020E40 RID: 134720 RVA: 0x00492DD9 File Offset: 0x00490FD9
		public IConveyorBeltField_Union Type { get; set; }

		// Token: 0x170094FF RID: 38143
		// (get) Token: 0x06020E41 RID: 134721 RVA: 0x00492DE2 File Offset: 0x00490FE2
		// (set) Token: 0x06020E42 RID: 134722 RVA: 0x00492DEA File Offset: 0x00490FEA
		public object Value { get; set; }

		// Token: 0x06020E43 RID: 134723 RVA: 0x00492DF3 File Offset: 0x00490FF3
		public IConveyorBeltField_UnionUnion()
		{
			this.Type = IConveyorBeltField_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020E44 RID: 134724 RVA: 0x00492E09 File Offset: 0x00491009
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020E45 RID: 134725 RVA: 0x00492E1B File Offset: 0x0049101B
		public IConveyorBeltFieldT AsIConveyorBeltField()
		{
			return this.As<IConveyorBeltFieldT>();
		}

		// Token: 0x06020E46 RID: 134726 RVA: 0x00492E23 File Offset: 0x00491023
		public static IConveyorBeltField_UnionUnion FromIConveyorBeltField(IConveyorBeltFieldT _iconveyorbeltfield)
		{
			return new IConveyorBeltField_UnionUnion
			{
				Type = IConveyorBeltField_Union.IConveyorBeltField,
				Value = _iconveyorbeltfield
			};
		}

		// Token: 0x06020E47 RID: 134727 RVA: 0x00492E38 File Offset: 0x00491038
		public IDirectionalFieldT AsIDirectionalField()
		{
			return this.As<IDirectionalFieldT>();
		}

		// Token: 0x06020E48 RID: 134728 RVA: 0x00492E40 File Offset: 0x00491040
		public static IConveyorBeltField_UnionUnion FromIDirectionalField(IDirectionalFieldT _idirectionalfield)
		{
			return new IConveyorBeltField_UnionUnion
			{
				Type = IConveyorBeltField_Union.IDirectionalField,
				Value = _idirectionalfield
			};
		}

		// Token: 0x06020E49 RID: 134729 RVA: 0x00492E55 File Offset: 0x00491055
		public IPointFieldT AsIPointField()
		{
			return this.As<IPointFieldT>();
		}

		// Token: 0x06020E4A RID: 134730 RVA: 0x00492E5D File Offset: 0x0049105D
		public static IConveyorBeltField_UnionUnion FromIPointField(IPointFieldT _ipointfield)
		{
			return new IConveyorBeltField_UnionUnion
			{
				Type = IConveyorBeltField_Union.IPointField,
				Value = _ipointfield
			};
		}

		// Token: 0x06020E4B RID: 134731 RVA: 0x00492E74 File Offset: 0x00491074
		public static int Pack(FlatBufferBuilder builder, IConveyorBeltField_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IConveyorBeltField_Union.IConveyorBeltField:
				return IConveyorBeltField.Pack(builder, _o.AsIConveyorBeltField()).Value;
			case IConveyorBeltField_Union.IDirectionalField:
				return IDirectionalField.Pack(builder, _o.AsIDirectionalField()).Value;
			case IConveyorBeltField_Union.IPointField:
				return IPointField.Pack(builder, _o.AsIPointField()).Value;
			default:
				return 0;
			}
		}
	}
}
