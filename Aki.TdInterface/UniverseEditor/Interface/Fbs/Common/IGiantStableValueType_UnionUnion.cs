using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200641D RID: 25629
	public class IGiantStableValueType_UnionUnion
	{
		// Token: 0x1700BD49 RID: 48457
		// (get) Token: 0x0602B8A8 RID: 178344 RVA: 0x005EDE69 File Offset: 0x005EC069
		// (set) Token: 0x0602B8A9 RID: 178345 RVA: 0x005EDE71 File Offset: 0x005EC071
		public IGiantStableValueType_Union Type { get; set; }

		// Token: 0x1700BD4A RID: 48458
		// (get) Token: 0x0602B8AA RID: 178346 RVA: 0x005EDE7A File Offset: 0x005EC07A
		// (set) Token: 0x0602B8AB RID: 178347 RVA: 0x005EDE82 File Offset: 0x005EC082
		public object Value { get; set; }

		// Token: 0x0602B8AC RID: 178348 RVA: 0x005EDE8B File Offset: 0x005EC08B
		public IGiantStableValueType_UnionUnion()
		{
			this.Type = IGiantStableValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B8AD RID: 178349 RVA: 0x005EDEA1 File Offset: 0x005EC0A1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B8AE RID: 178350 RVA: 0x005EDEB3 File Offset: 0x005EC0B3
		public IGiantStableValueTypeT AsIGiantStableValueType()
		{
			return this.As<IGiantStableValueTypeT>();
		}

		// Token: 0x0602B8AF RID: 178351 RVA: 0x005EDEBB File Offset: 0x005EC0BB
		public static IGiantStableValueType_UnionUnion FromIGiantStableValueType(IGiantStableValueTypeT _igiantstablevaluetype)
		{
			return new IGiantStableValueType_UnionUnion
			{
				Type = IGiantStableValueType_Union.IGiantStableValueType,
				Value = _igiantstablevaluetype
			};
		}

		// Token: 0x0602B8B0 RID: 178352 RVA: 0x005EDED0 File Offset: 0x005EC0D0
		public IGiantStableValueRegionT AsIGiantStableValueRegion()
		{
			return this.As<IGiantStableValueRegionT>();
		}

		// Token: 0x0602B8B1 RID: 178353 RVA: 0x005EDED8 File Offset: 0x005EC0D8
		public static IGiantStableValueType_UnionUnion FromIGiantStableValueRegion(IGiantStableValueRegionT _igiantstablevalueregion)
		{
			return new IGiantStableValueType_UnionUnion
			{
				Type = IGiantStableValueType_Union.IGiantStableValueRegion,
				Value = _igiantstablevalueregion
			};
		}

		// Token: 0x0602B8B2 RID: 178354 RVA: 0x005EDEED File Offset: 0x005EC0ED
		public IGiantStableValueTotalT AsIGiantStableValueTotal()
		{
			return this.As<IGiantStableValueTotalT>();
		}

		// Token: 0x0602B8B3 RID: 178355 RVA: 0x005EDEF5 File Offset: 0x005EC0F5
		public static IGiantStableValueType_UnionUnion FromIGiantStableValueTotal(IGiantStableValueTotalT _igiantstablevaluetotal)
		{
			return new IGiantStableValueType_UnionUnion
			{
				Type = IGiantStableValueType_Union.IGiantStableValueTotal,
				Value = _igiantstablevaluetotal
			};
		}

		// Token: 0x0602B8B4 RID: 178356 RVA: 0x005EDF0C File Offset: 0x005EC10C
		public static int Pack(FlatBufferBuilder builder, IGiantStableValueType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGiantStableValueType_Union.IGiantStableValueType:
				return IGiantStableValueType.Pack(builder, _o.AsIGiantStableValueType()).Value;
			case IGiantStableValueType_Union.IGiantStableValueRegion:
				return IGiantStableValueRegion.Pack(builder, _o.AsIGiantStableValueRegion()).Value;
			case IGiantStableValueType_Union.IGiantStableValueTotal:
				return IGiantStableValueTotal.Pack(builder, _o.AsIGiantStableValueTotal()).Value;
			default:
				return 0;
			}
		}
	}
}
