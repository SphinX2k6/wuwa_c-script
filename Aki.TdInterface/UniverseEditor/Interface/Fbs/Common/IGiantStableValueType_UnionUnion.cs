using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DE0 RID: 24032
	public class IGiantStableValueType_UnionUnion
	{
		// Token: 0x1700B3E3 RID: 46051
		// (get) Token: 0x0602921E RID: 168478 RVA: 0x005A5139 File Offset: 0x005A3339
		// (set) Token: 0x0602921F RID: 168479 RVA: 0x005A5141 File Offset: 0x005A3341
		public IGiantStableValueType_Union Type { get; set; }

		// Token: 0x1700B3E4 RID: 46052
		// (get) Token: 0x06029220 RID: 168480 RVA: 0x005A514A File Offset: 0x005A334A
		// (set) Token: 0x06029221 RID: 168481 RVA: 0x005A5152 File Offset: 0x005A3352
		public object Value { get; set; }

		// Token: 0x06029222 RID: 168482 RVA: 0x005A515B File Offset: 0x005A335B
		public IGiantStableValueType_UnionUnion()
		{
			this.Type = IGiantStableValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029223 RID: 168483 RVA: 0x005A5171 File Offset: 0x005A3371
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029224 RID: 168484 RVA: 0x005A5183 File Offset: 0x005A3383
		public IGiantStableValueTypeT AsIGiantStableValueType()
		{
			return this.As<IGiantStableValueTypeT>();
		}

		// Token: 0x06029225 RID: 168485 RVA: 0x005A518B File Offset: 0x005A338B
		public static IGiantStableValueType_UnionUnion FromIGiantStableValueType(IGiantStableValueTypeT _igiantstablevaluetype)
		{
			return new IGiantStableValueType_UnionUnion
			{
				Type = IGiantStableValueType_Union.IGiantStableValueType,
				Value = _igiantstablevaluetype
			};
		}

		// Token: 0x06029226 RID: 168486 RVA: 0x005A51A0 File Offset: 0x005A33A0
		public IGiantStableValueRegionT AsIGiantStableValueRegion()
		{
			return this.As<IGiantStableValueRegionT>();
		}

		// Token: 0x06029227 RID: 168487 RVA: 0x005A51A8 File Offset: 0x005A33A8
		public static IGiantStableValueType_UnionUnion FromIGiantStableValueRegion(IGiantStableValueRegionT _igiantstablevalueregion)
		{
			return new IGiantStableValueType_UnionUnion
			{
				Type = IGiantStableValueType_Union.IGiantStableValueRegion,
				Value = _igiantstablevalueregion
			};
		}

		// Token: 0x06029228 RID: 168488 RVA: 0x005A51BD File Offset: 0x005A33BD
		public IGiantStableValueTotalT AsIGiantStableValueTotal()
		{
			return this.As<IGiantStableValueTotalT>();
		}

		// Token: 0x06029229 RID: 168489 RVA: 0x005A51C5 File Offset: 0x005A33C5
		public static IGiantStableValueType_UnionUnion FromIGiantStableValueTotal(IGiantStableValueTotalT _igiantstablevaluetotal)
		{
			return new IGiantStableValueType_UnionUnion
			{
				Type = IGiantStableValueType_Union.IGiantStableValueTotal,
				Value = _igiantstablevaluetotal
			};
		}

		// Token: 0x0602922A RID: 168490 RVA: 0x005A51DC File Offset: 0x005A33DC
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
