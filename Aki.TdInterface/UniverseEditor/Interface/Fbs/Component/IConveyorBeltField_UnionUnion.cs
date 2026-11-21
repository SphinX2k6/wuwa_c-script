using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005590 RID: 21904
	public class IConveyorBeltField_UnionUnion
	{
		// Token: 0x17009CDF RID: 40159
		// (get) Token: 0x06022D5F RID: 142687 RVA: 0x004CC821 File Offset: 0x004CAA21
		// (set) Token: 0x06022D60 RID: 142688 RVA: 0x004CC829 File Offset: 0x004CAA29
		public IConveyorBeltField_Union Type { get; set; }

		// Token: 0x17009CE0 RID: 40160
		// (get) Token: 0x06022D61 RID: 142689 RVA: 0x004CC832 File Offset: 0x004CAA32
		// (set) Token: 0x06022D62 RID: 142690 RVA: 0x004CC83A File Offset: 0x004CAA3A
		public object Value { get; set; }

		// Token: 0x06022D63 RID: 142691 RVA: 0x004CC843 File Offset: 0x004CAA43
		public IConveyorBeltField_UnionUnion()
		{
			this.Type = IConveyorBeltField_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022D64 RID: 142692 RVA: 0x004CC859 File Offset: 0x004CAA59
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022D65 RID: 142693 RVA: 0x004CC86B File Offset: 0x004CAA6B
		public IConveyorBeltFieldT AsIConveyorBeltField()
		{
			return this.As<IConveyorBeltFieldT>();
		}

		// Token: 0x06022D66 RID: 142694 RVA: 0x004CC873 File Offset: 0x004CAA73
		public static IConveyorBeltField_UnionUnion FromIConveyorBeltField(IConveyorBeltFieldT _iconveyorbeltfield)
		{
			return new IConveyorBeltField_UnionUnion
			{
				Type = IConveyorBeltField_Union.IConveyorBeltField,
				Value = _iconveyorbeltfield
			};
		}

		// Token: 0x06022D67 RID: 142695 RVA: 0x004CC888 File Offset: 0x004CAA88
		public IDirectionalFieldT AsIDirectionalField()
		{
			return this.As<IDirectionalFieldT>();
		}

		// Token: 0x06022D68 RID: 142696 RVA: 0x004CC890 File Offset: 0x004CAA90
		public static IConveyorBeltField_UnionUnion FromIDirectionalField(IDirectionalFieldT _idirectionalfield)
		{
			return new IConveyorBeltField_UnionUnion
			{
				Type = IConveyorBeltField_Union.IDirectionalField,
				Value = _idirectionalfield
			};
		}

		// Token: 0x06022D69 RID: 142697 RVA: 0x004CC8A5 File Offset: 0x004CAAA5
		public IPointFieldT AsIPointField()
		{
			return this.As<IPointFieldT>();
		}

		// Token: 0x06022D6A RID: 142698 RVA: 0x004CC8AD File Offset: 0x004CAAAD
		public static IConveyorBeltField_UnionUnion FromIPointField(IPointFieldT _ipointfield)
		{
			return new IConveyorBeltField_UnionUnion
			{
				Type = IConveyorBeltField_Union.IPointField,
				Value = _ipointfield
			};
		}

		// Token: 0x06022D6B RID: 142699 RVA: 0x004CC8C4 File Offset: 0x004CAAC4
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
