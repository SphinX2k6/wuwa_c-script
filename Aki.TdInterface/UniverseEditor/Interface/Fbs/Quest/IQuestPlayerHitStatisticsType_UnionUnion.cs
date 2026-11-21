using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004449 RID: 17481
	public class IQuestPlayerHitStatisticsType_UnionUnion
	{
		// Token: 0x17007931 RID: 31025
		// (get) Token: 0x0601910D RID: 102669 RVA: 0x003935D5 File Offset: 0x003917D5
		// (set) Token: 0x0601910E RID: 102670 RVA: 0x003935DD File Offset: 0x003917DD
		public IQuestPlayerHitStatisticsType_Union Type { get; set; }

		// Token: 0x17007932 RID: 31026
		// (get) Token: 0x0601910F RID: 102671 RVA: 0x003935E6 File Offset: 0x003917E6
		// (set) Token: 0x06019110 RID: 102672 RVA: 0x003935EE File Offset: 0x003917EE
		public object Value { get; set; }

		// Token: 0x06019111 RID: 102673 RVA: 0x003935F7 File Offset: 0x003917F7
		public IQuestPlayerHitStatisticsType_UnionUnion()
		{
			this.Type = IQuestPlayerHitStatisticsType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019112 RID: 102674 RVA: 0x0039360D File Offset: 0x0039180D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019113 RID: 102675 RVA: 0x0039361F File Offset: 0x0039181F
		public IQuestPlayerHitStatisticsTypeT AsIQuestPlayerHitStatisticsType()
		{
			return this.As<IQuestPlayerHitStatisticsTypeT>();
		}

		// Token: 0x06019114 RID: 102676 RVA: 0x00393627 File Offset: 0x00391827
		public static IQuestPlayerHitStatisticsType_UnionUnion FromIQuestPlayerHitStatisticsType(IQuestPlayerHitStatisticsTypeT _iquestplayerhitstatisticstype)
		{
			return new IQuestPlayerHitStatisticsType_UnionUnion
			{
				Type = IQuestPlayerHitStatisticsType_Union.IQuestPlayerHitStatisticsType,
				Value = _iquestplayerhitstatisticstype
			};
		}

		// Token: 0x06019115 RID: 102677 RVA: 0x0039363C File Offset: 0x0039183C
		public IQuestPlayerHitCountT AsIQuestPlayerHitCount()
		{
			return this.As<IQuestPlayerHitCountT>();
		}

		// Token: 0x06019116 RID: 102678 RVA: 0x00393644 File Offset: 0x00391844
		public static IQuestPlayerHitStatisticsType_UnionUnion FromIQuestPlayerHitCount(IQuestPlayerHitCountT _iquestplayerhitcount)
		{
			return new IQuestPlayerHitStatisticsType_UnionUnion
			{
				Type = IQuestPlayerHitStatisticsType_Union.IQuestPlayerHitCount,
				Value = _iquestplayerhitcount
			};
		}

		// Token: 0x06019117 RID: 102679 RVA: 0x00393659 File Offset: 0x00391859
		public IQuestPlayerBeDamageT AsIQuestPlayerBeDamage()
		{
			return this.As<IQuestPlayerBeDamageT>();
		}

		// Token: 0x06019118 RID: 102680 RVA: 0x00393661 File Offset: 0x00391861
		public static IQuestPlayerHitStatisticsType_UnionUnion FromIQuestPlayerBeDamage(IQuestPlayerBeDamageT _iquestplayerbedamage)
		{
			return new IQuestPlayerHitStatisticsType_UnionUnion
			{
				Type = IQuestPlayerHitStatisticsType_Union.IQuestPlayerBeDamage,
				Value = _iquestplayerbedamage
			};
		}

		// Token: 0x06019119 RID: 102681 RVA: 0x00393678 File Offset: 0x00391878
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
