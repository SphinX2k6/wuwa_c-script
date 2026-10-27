using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9A RID: 23194
	public class ITimeScheduleDistributionConfig_UnionUnion
	{
		// Token: 0x1700AEB9 RID: 44729
		// (get) Token: 0x06027846 RID: 161862 RVA: 0x0056FDA1 File Offset: 0x0056DFA1
		// (set) Token: 0x06027847 RID: 161863 RVA: 0x0056FDA9 File Offset: 0x0056DFA9
		public ITimeScheduleDistributionConfig_Union Type { get; set; }

		// Token: 0x1700AEBA RID: 44730
		// (get) Token: 0x06027848 RID: 161864 RVA: 0x0056FDB2 File Offset: 0x0056DFB2
		// (set) Token: 0x06027849 RID: 161865 RVA: 0x0056FDBA File Offset: 0x0056DFBA
		public object Value { get; set; }

		// Token: 0x0602784A RID: 161866 RVA: 0x0056FDC3 File Offset: 0x0056DFC3
		public ITimeScheduleDistributionConfig_UnionUnion()
		{
			this.Type = ITimeScheduleDistributionConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602784B RID: 161867 RVA: 0x0056FDD9 File Offset: 0x0056DFD9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602784C RID: 161868 RVA: 0x0056FDEB File Offset: 0x0056DFEB
		public ITimeScheduleDistributionConfigT AsITimeScheduleDistributionConfig()
		{
			return this.As<ITimeScheduleDistributionConfigT>();
		}

		// Token: 0x0602784D RID: 161869 RVA: 0x0056FDF3 File Offset: 0x0056DFF3
		public static ITimeScheduleDistributionConfig_UnionUnion FromITimeScheduleDistributionConfig(ITimeScheduleDistributionConfigT _itimescheduledistributionconfig)
		{
			return new ITimeScheduleDistributionConfig_UnionUnion
			{
				Type = ITimeScheduleDistributionConfig_Union.ITimeScheduleDistributionConfig,
				Value = _itimescheduledistributionconfig
			};
		}

		// Token: 0x0602784E RID: 161870 RVA: 0x0056FE08 File Offset: 0x0056E008
		public ITimeScheduleRandomSchedulePositionDistributionT AsITimeScheduleRandomSchedulePositionDistribution()
		{
			return this.As<ITimeScheduleRandomSchedulePositionDistributionT>();
		}

		// Token: 0x0602784F RID: 161871 RVA: 0x0056FE10 File Offset: 0x0056E010
		public static ITimeScheduleDistributionConfig_UnionUnion FromITimeScheduleRandomSchedulePositionDistribution(ITimeScheduleRandomSchedulePositionDistributionT _itimeschedulerandomschedulepositiondistribution)
		{
			return new ITimeScheduleDistributionConfig_UnionUnion
			{
				Type = ITimeScheduleDistributionConfig_Union.ITimeScheduleRandomSchedulePositionDistribution,
				Value = _itimeschedulerandomschedulepositiondistribution
			};
		}

		// Token: 0x06027850 RID: 161872 RVA: 0x0056FE28 File Offset: 0x0056E028
		public static int Pack(FlatBufferBuilder builder, ITimeScheduleDistributionConfig_UnionUnion _o)
		{
			ITimeScheduleDistributionConfig_Union type = _o.Type;
			if (type == ITimeScheduleDistributionConfig_Union.ITimeScheduleDistributionConfig)
			{
				return ITimeScheduleDistributionConfig.Pack(builder, _o.AsITimeScheduleDistributionConfig()).Value;
			}
			if (type != ITimeScheduleDistributionConfig_Union.ITimeScheduleRandomSchedulePositionDistribution)
			{
				return 0;
			}
			return ITimeScheduleRandomSchedulePositionDistribution.Pack(builder, _o.AsITimeScheduleRandomSchedulePositionDistribution()).Value;
		}
	}
}
