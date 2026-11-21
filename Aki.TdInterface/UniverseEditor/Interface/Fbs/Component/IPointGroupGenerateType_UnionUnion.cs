using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D6B RID: 23915
	public class IPointGroupGenerateType_UnionUnion
	{
		// Token: 0x1700B002 RID: 45058
		// (get) Token: 0x06027CF7 RID: 163063 RVA: 0x00572309 File Offset: 0x00570509
		// (set) Token: 0x06027CF8 RID: 163064 RVA: 0x00572311 File Offset: 0x00570511
		public IPointGroupGenerateType_Union Type { get; set; }

		// Token: 0x1700B003 RID: 45059
		// (get) Token: 0x06027CF9 RID: 163065 RVA: 0x0057231A File Offset: 0x0057051A
		// (set) Token: 0x06027CFA RID: 163066 RVA: 0x00572322 File Offset: 0x00570522
		public object Value { get; set; }

		// Token: 0x06027CFB RID: 163067 RVA: 0x0057232B File Offset: 0x0057052B
		public IPointGroupGenerateType_UnionUnion()
		{
			this.Type = IPointGroupGenerateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027CFC RID: 163068 RVA: 0x00572341 File Offset: 0x00570541
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027CFD RID: 163069 RVA: 0x00572353 File Offset: 0x00570553
		public IPointGroupGenerateTypeT AsIPointGroupGenerateType()
		{
			return this.As<IPointGroupGenerateTypeT>();
		}

		// Token: 0x06027CFE RID: 163070 RVA: 0x0057235B File Offset: 0x0057055B
		public static IPointGroupGenerateType_UnionUnion FromIPointGroupGenerateType(IPointGroupGenerateTypeT _ipointgroupgeneratetype)
		{
			return new IPointGroupGenerateType_UnionUnion
			{
				Type = IPointGroupGenerateType_Union.IPointGroupGenerateType,
				Value = _ipointgroupgeneratetype
			};
		}

		// Token: 0x06027CFF RID: 163071 RVA: 0x00572370 File Offset: 0x00570570
		public IPointGroupByLayerT AsIPointGroupByLayer()
		{
			return this.As<IPointGroupByLayerT>();
		}

		// Token: 0x06027D00 RID: 163072 RVA: 0x00572378 File Offset: 0x00570578
		public static IPointGroupGenerateType_UnionUnion FromIPointGroupByLayer(IPointGroupByLayerT _ipointgroupbylayer)
		{
			return new IPointGroupGenerateType_UnionUnion
			{
				Type = IPointGroupGenerateType_Union.IPointGroupByLayer,
				Value = _ipointgroupbylayer
			};
		}

		// Token: 0x06027D01 RID: 163073 RVA: 0x00572390 File Offset: 0x00570590
		public static int Pack(FlatBufferBuilder builder, IPointGroupGenerateType_UnionUnion _o)
		{
			IPointGroupGenerateType_Union type = _o.Type;
			if (type == IPointGroupGenerateType_Union.IPointGroupGenerateType)
			{
				return IPointGroupGenerateType.Pack(builder, _o.AsIPointGroupGenerateType()).Value;
			}
			if (type != IPointGroupGenerateType_Union.IPointGroupByLayer)
			{
				return 0;
			}
			return IPointGroupByLayer.Pack(builder, _o.AsIPointGroupByLayer()).Value;
		}
	}
}
