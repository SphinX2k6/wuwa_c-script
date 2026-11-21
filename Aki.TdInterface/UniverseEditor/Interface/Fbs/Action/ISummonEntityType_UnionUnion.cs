using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A0B RID: 31243
	public class ISummonEntityType_UnionUnion
	{
		// Token: 0x1700E4F1 RID: 58609
		// (get) Token: 0x060370BA RID: 225466 RVA: 0x0075B6A5 File Offset: 0x007598A5
		// (set) Token: 0x060370BB RID: 225467 RVA: 0x0075B6AD File Offset: 0x007598AD
		public ISummonEntityType_Union Type { get; set; }

		// Token: 0x1700E4F2 RID: 58610
		// (get) Token: 0x060370BC RID: 225468 RVA: 0x0075B6B6 File Offset: 0x007598B6
		// (set) Token: 0x060370BD RID: 225469 RVA: 0x0075B6BE File Offset: 0x007598BE
		public object Value { get; set; }

		// Token: 0x060370BE RID: 225470 RVA: 0x0075B6C7 File Offset: 0x007598C7
		public ISummonEntityType_UnionUnion()
		{
			this.Type = ISummonEntityType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060370BF RID: 225471 RVA: 0x0075B6DD File Offset: 0x007598DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060370C0 RID: 225472 RVA: 0x0075B6EF File Offset: 0x007598EF
		public ISummonEntityTypeT AsISummonEntityType()
		{
			return this.As<ISummonEntityTypeT>();
		}

		// Token: 0x060370C1 RID: 225473 RVA: 0x0075B6F7 File Offset: 0x007598F7
		public static ISummonEntityType_UnionUnion FromISummonEntityType(ISummonEntityTypeT _isummonentitytype)
		{
			return new ISummonEntityType_UnionUnion
			{
				Type = ISummonEntityType_Union.ISummonEntityType,
				Value = _isummonentitytype
			};
		}

		// Token: 0x060370C2 RID: 225474 RVA: 0x0075B70C File Offset: 0x0075990C
		public ISummonVehicleT AsISummonVehicle()
		{
			return this.As<ISummonVehicleT>();
		}

		// Token: 0x060370C3 RID: 225475 RVA: 0x0075B714 File Offset: 0x00759914
		public static ISummonEntityType_UnionUnion FromISummonVehicle(ISummonVehicleT _isummonvehicle)
		{
			return new ISummonEntityType_UnionUnion
			{
				Type = ISummonEntityType_Union.ISummonVehicle,
				Value = _isummonvehicle
			};
		}

		// Token: 0x060370C4 RID: 225476 RVA: 0x0075B72C File Offset: 0x0075992C
		public static int Pack(FlatBufferBuilder builder, ISummonEntityType_UnionUnion _o)
		{
			ISummonEntityType_Union type = _o.Type;
			if (type == ISummonEntityType_Union.ISummonEntityType)
			{
				return ISummonEntityType.Pack(builder, _o.AsISummonEntityType()).Value;
			}
			if (type != ISummonEntityType_Union.ISummonVehicle)
			{
				return 0;
			}
			return ISummonVehicle.Pack(builder, _o.AsISummonVehicle()).Value;
		}
	}
}
