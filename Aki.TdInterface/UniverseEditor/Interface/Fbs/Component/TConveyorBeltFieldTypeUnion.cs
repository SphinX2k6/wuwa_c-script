using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFE RID: 23550
	public class TConveyorBeltFieldTypeUnion
	{
		// Token: 0x1700B1D7 RID: 45527
		// (get) Token: 0x06028661 RID: 165473 RVA: 0x0058FAD2 File Offset: 0x0058DCD2
		// (set) Token: 0x06028662 RID: 165474 RVA: 0x0058FADA File Offset: 0x0058DCDA
		public TConveyorBeltFieldType Type { get; set; }

		// Token: 0x1700B1D8 RID: 45528
		// (get) Token: 0x06028663 RID: 165475 RVA: 0x0058FAE3 File Offset: 0x0058DCE3
		// (set) Token: 0x06028664 RID: 165476 RVA: 0x0058FAEB File Offset: 0x0058DCEB
		public object Value { get; set; }

		// Token: 0x06028665 RID: 165477 RVA: 0x0058FAF4 File Offset: 0x0058DCF4
		public TConveyorBeltFieldTypeUnion()
		{
			this.Type = TConveyorBeltFieldType.NONE;
			this.Value = null;
		}

		// Token: 0x06028666 RID: 165478 RVA: 0x0058FB0A File Offset: 0x0058DD0A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028667 RID: 165479 RVA: 0x0058FB1C File Offset: 0x0058DD1C
		public IDirectionalFieldT AsIDirectionalField()
		{
			return this.As<IDirectionalFieldT>();
		}

		// Token: 0x06028668 RID: 165480 RVA: 0x0058FB24 File Offset: 0x0058DD24
		public static TConveyorBeltFieldTypeUnion FromIDirectionalField(IDirectionalFieldT _idirectionalfield)
		{
			return new TConveyorBeltFieldTypeUnion
			{
				Type = TConveyorBeltFieldType.IDirectionalField,
				Value = _idirectionalfield
			};
		}

		// Token: 0x06028669 RID: 165481 RVA: 0x0058FB39 File Offset: 0x0058DD39
		public IPointFieldT AsIPointField()
		{
			return this.As<IPointFieldT>();
		}

		// Token: 0x0602866A RID: 165482 RVA: 0x0058FB41 File Offset: 0x0058DD41
		public static TConveyorBeltFieldTypeUnion FromIPointField(IPointFieldT _ipointfield)
		{
			return new TConveyorBeltFieldTypeUnion
			{
				Type = TConveyorBeltFieldType.IPointField,
				Value = _ipointfield
			};
		}

		// Token: 0x0602866B RID: 165483 RVA: 0x0058FB58 File Offset: 0x0058DD58
		public static int Pack(FlatBufferBuilder builder, TConveyorBeltFieldTypeUnion _o)
		{
			TConveyorBeltFieldType type = _o.Type;
			if (type == TConveyorBeltFieldType.IDirectionalField)
			{
				return IDirectionalField.Pack(builder, _o.AsIDirectionalField()).Value;
			}
			if (type != TConveyorBeltFieldType.IPointField)
			{
				return 0;
			}
			return IPointField.Pack(builder, _o.AsIPointField()).Value;
		}
	}
}
