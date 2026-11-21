using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060B3 RID: 24755
	public class ITimeScheduleGenerateParams_UnionUnion
	{
		// Token: 0x1700B80B RID: 47115
		// (get) Token: 0x06029E2E RID: 171566 RVA: 0x005B7CD5 File Offset: 0x005B5ED5
		// (set) Token: 0x06029E2F RID: 171567 RVA: 0x005B7CDD File Offset: 0x005B5EDD
		public ITimeScheduleGenerateParams_Union Type { get; set; }

		// Token: 0x1700B80C RID: 47116
		// (get) Token: 0x06029E30 RID: 171568 RVA: 0x005B7CE6 File Offset: 0x005B5EE6
		// (set) Token: 0x06029E31 RID: 171569 RVA: 0x005B7CEE File Offset: 0x005B5EEE
		public object Value { get; set; }

		// Token: 0x06029E32 RID: 171570 RVA: 0x005B7CF7 File Offset: 0x005B5EF7
		public ITimeScheduleGenerateParams_UnionUnion()
		{
			this.Type = ITimeScheduleGenerateParams_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029E33 RID: 171571 RVA: 0x005B7D0D File Offset: 0x005B5F0D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029E34 RID: 171572 RVA: 0x005B7D1F File Offset: 0x005B5F1F
		public ITimeScheduleGenerateParamsT AsITimeScheduleGenerateParams()
		{
			return this.As<ITimeScheduleGenerateParamsT>();
		}

		// Token: 0x06029E35 RID: 171573 RVA: 0x005B7D27 File Offset: 0x005B5F27
		public static ITimeScheduleGenerateParams_UnionUnion FromITimeScheduleGenerateParams(ITimeScheduleGenerateParamsT _itimeschedulegenerateparams)
		{
			return new ITimeScheduleGenerateParams_UnionUnion
			{
				Type = ITimeScheduleGenerateParams_Union.ITimeScheduleGenerateParams,
				Value = _itimeschedulegenerateparams
			};
		}

		// Token: 0x06029E36 RID: 171574 RVA: 0x005B7D3C File Offset: 0x005B5F3C
		public ITimeScheduleFixedIntervalRefreshT AsITimeScheduleFixedIntervalRefresh()
		{
			return this.As<ITimeScheduleFixedIntervalRefreshT>();
		}

		// Token: 0x06029E37 RID: 171575 RVA: 0x005B7D44 File Offset: 0x005B5F44
		public static ITimeScheduleGenerateParams_UnionUnion FromITimeScheduleFixedIntervalRefresh(ITimeScheduleFixedIntervalRefreshT _itimeschedulefixedintervalrefresh)
		{
			return new ITimeScheduleGenerateParams_UnionUnion
			{
				Type = ITimeScheduleGenerateParams_Union.ITimeScheduleFixedIntervalRefresh,
				Value = _itimeschedulefixedintervalrefresh
			};
		}

		// Token: 0x06029E38 RID: 171576 RVA: 0x005B7D5C File Offset: 0x005B5F5C
		public static int Pack(FlatBufferBuilder builder, ITimeScheduleGenerateParams_UnionUnion _o)
		{
			ITimeScheduleGenerateParams_Union type = _o.Type;
			if (type == ITimeScheduleGenerateParams_Union.ITimeScheduleGenerateParams)
			{
				return ITimeScheduleGenerateParams.Pack(builder, _o.AsITimeScheduleGenerateParams()).Value;
			}
			if (type != ITimeScheduleGenerateParams_Union.ITimeScheduleFixedIntervalRefresh)
			{
				return 0;
			}
			return ITimeScheduleFixedIntervalRefresh.Pack(builder, _o.AsITimeScheduleFixedIntervalRefresh()).Value;
		}
	}
}
