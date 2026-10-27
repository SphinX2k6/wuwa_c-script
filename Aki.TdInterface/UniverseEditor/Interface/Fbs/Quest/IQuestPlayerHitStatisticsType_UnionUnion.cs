using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004008 RID: 16392
	public class IQuestPlayerHitStatisticsType_UnionUnion
	{
		// Token: 0x1700732F RID: 29487
		// (get) Token: 0x06017A74 RID: 96884 RVA: 0x003697E1 File Offset: 0x003679E1
		// (set) Token: 0x06017A75 RID: 96885 RVA: 0x003697E9 File Offset: 0x003679E9
		public IQuestPlayerHitStatisticsType_Union Type { get; set; }

		// Token: 0x17007330 RID: 29488
		// (get) Token: 0x06017A76 RID: 96886 RVA: 0x003697F2 File Offset: 0x003679F2
		// (set) Token: 0x06017A77 RID: 96887 RVA: 0x003697FA File Offset: 0x003679FA
		public object Value { get; set; }

		// Token: 0x06017A78 RID: 96888 RVA: 0x00369803 File Offset: 0x00367A03
		public IQuestPlayerHitStatisticsType_UnionUnion()
		{
			this.Type = IQuestPlayerHitStatisticsType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06017A79 RID: 96889 RVA: 0x00369819 File Offset: 0x00367A19
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06017A7A RID: 96890 RVA: 0x0036982B File Offset: 0x00367A2B
		public IQuestPlayerHitStatisticsTypeT AsIQuestPlayerHitStatisticsType()
		{
			return this.As<IQuestPlayerHitStatisticsTypeT>();
		}

		// Token: 0x06017A7B RID: 96891 RVA: 0x00369833 File Offset: 0x00367A33
		public static IQuestPlayerHitStatisticsType_UnionUnion FromIQuestPlayerHitStatisticsType(IQuestPlayerHitStatisticsTypeT _iquestplayerhitstatisticstype)
		{
			return new IQuestPlayerHitStatisticsType_UnionUnion
			{
				Type = IQuestPlayerHitStatisticsType_Union.IQuestPlayerHitStatisticsType,
				Value = _iquestplayerhitstatisticstype
			};
		}

		// Token: 0x06017A7C RID: 96892 RVA: 0x00369848 File Offset: 0x00367A48
		public IQuestPlayerHitCountT AsIQuestPlayerHitCount()
		{
			return this.As<IQuestPlayerHitCountT>();
		}

		// Token: 0x06017A7D RID: 96893 RVA: 0x00369850 File Offset: 0x00367A50
		public static IQuestPlayerHitStatisticsType_UnionUnion FromIQuestPlayerHitCount(IQuestPlayerHitCountT _iquestplayerhitcount)
		{
			return new IQuestPlayerHitStatisticsType_UnionUnion
			{
				Type = IQuestPlayerHitStatisticsType_Union.IQuestPlayerHitCount,
				Value = _iquestplayerhitcount
			};
		}

		// Token: 0x06017A7E RID: 96894 RVA: 0x00369865 File Offset: 0x00367A65
		public IQuestPlayerBeDamageT AsIQuestPlayerBeDamage()
		{
			return this.As<IQuestPlayerBeDamageT>();
		}

		// Token: 0x06017A7F RID: 96895 RVA: 0x0036986D File Offset: 0x00367A6D
		public static IQuestPlayerHitStatisticsType_UnionUnion FromIQuestPlayerBeDamage(IQuestPlayerBeDamageT _iquestplayerbedamage)
		{
			return new IQuestPlayerHitStatisticsType_UnionUnion
			{
				Type = IQuestPlayerHitStatisticsType_Union.IQuestPlayerBeDamage,
				Value = _iquestplayerbedamage
			};
		}

		// Token: 0x06017A80 RID: 96896 RVA: 0x00369884 File Offset: 0x00367A84
		public static int Pack(FlatBufferBuilder builder, IQuestPlayerHitStatisticsType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IQuestPlayerHitStatisticsType_Union.IQuestPlayerHitStatisticsType:
				return IQuestPlayerHitStatisticsType.Pack(builder, _o.AsIQuestPlayerHitStatisticsType()).Value;
			case IQuestPlayerHitStatisticsType_Union.IQuestPlayerHitCount:
				return IQuestPlayerHitCount.Pack(builder, _o.AsIQuestPlayerHitCount()).Value;
			case IQuestPlayerHitStatisticsType_Union.IQuestPlayerBeDamage:
				return IQuestPlayerBeDamage.Pack(builder, _o.AsIQuestPlayerBeDamage()).Value;
			default:
				return 0;
			}
		}
	}
}
