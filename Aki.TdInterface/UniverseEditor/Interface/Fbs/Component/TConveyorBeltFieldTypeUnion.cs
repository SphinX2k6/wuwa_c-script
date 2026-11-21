using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200621D RID: 25117
	public class TConveyorBeltFieldTypeUnion
	{
		// Token: 0x1700BB25 RID: 47909
		// (get) Token: 0x0602AC51 RID: 175185 RVA: 0x005D7A1A File Offset: 0x005D5C1A
		// (set) Token: 0x0602AC52 RID: 175186 RVA: 0x005D7A22 File Offset: 0x005D5C22
		public TConveyorBeltFieldType Type { get; set; }

		// Token: 0x1700BB26 RID: 47910
		// (get) Token: 0x0602AC53 RID: 175187 RVA: 0x005D7A2B File Offset: 0x005D5C2B
		// (set) Token: 0x0602AC54 RID: 175188 RVA: 0x005D7A33 File Offset: 0x005D5C33
		public object Value { get; set; }

		// Token: 0x0602AC55 RID: 175189 RVA: 0x005D7A3C File Offset: 0x005D5C3C
		public TConveyorBeltFieldTypeUnion()
		{
			this.Type = TConveyorBeltFieldType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AC56 RID: 175190 RVA: 0x005D7A52 File Offset: 0x005D5C52
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AC57 RID: 175191 RVA: 0x005D7A64 File Offset: 0x005D5C64
		public IDirectionalFieldT AsIDirectionalField()
		{
			return this.As<IDirectionalFieldT>();
		}

		// Token: 0x0602AC58 RID: 175192 RVA: 0x005D7A6C File Offset: 0x005D5C6C
		public static TConveyorBeltFieldTypeUnion FromIDirectionalField(IDirectionalFieldT _idirectionalfield)
		{
			return new TConveyorBeltFieldTypeUnion
			{
				Type = TConveyorBeltFieldType.IDirectionalField,
				Value = _idirectionalfield
			};
		}

		// Token: 0x0602AC59 RID: 175193 RVA: 0x005D7A81 File Offset: 0x005D5C81
		public IPointFieldT AsIPointField()
		{
			return this.As<IPointFieldT>();
		}

		// Token: 0x0602AC5A RID: 175194 RVA: 0x005D7A89 File Offset: 0x005D5C89
		public static TConveyorBeltFieldTypeUnion FromIPointField(IPointFieldT _ipointfield)
		{
			return new TConveyorBeltFieldTypeUnion
			{
				Type = TConveyorBeltFieldType.IPointField,
				Value = _ipointfield
			};
		}

		// Token: 0x0602AC5B RID: 175195 RVA: 0x005D7AA0 File Offset: 0x005D5CA0
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
