using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB5 RID: 23221
	public class ITimeScheduleRefreshConfig_UnionUnion
	{
		// Token: 0x1700AEDE RID: 44766
		// (get) Token: 0x060278FA RID: 162042 RVA: 0x005710F5 File Offset: 0x0056F2F5
		// (set) Token: 0x060278FB RID: 162043 RVA: 0x005710FD File Offset: 0x0056F2FD
		public ITimeScheduleRefreshConfig_Union Type { get; set; }

		// Token: 0x1700AEDF RID: 44767
		// (get) Token: 0x060278FC RID: 162044 RVA: 0x00571106 File Offset: 0x0056F306
		// (set) Token: 0x060278FD RID: 162045 RVA: 0x0057110E File Offset: 0x0056F30E
		public object Value { get; set; }

		// Token: 0x060278FE RID: 162046 RVA: 0x00571117 File Offset: 0x0056F317
		public ITimeScheduleRefreshConfig_UnionUnion()
		{
			this.Type = ITimeScheduleRefreshConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060278FF RID: 162047 RVA: 0x0057112D File Offset: 0x0056F32D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027900 RID: 162048 RVA: 0x0057113F File Offset: 0x0056F33F
		public ITimeScheduleRefreshConfigT AsITimeScheduleRefreshConfig()
		{
			return this.As<ITimeScheduleRefreshConfigT>();
		}

		// Token: 0x06027901 RID: 162049 RVA: 0x00571147 File Offset: 0x0056F347
		public static ITimeScheduleRefreshConfig_UnionUnion FromITimeScheduleRefreshConfig(ITimeScheduleRefreshConfigT _itimeschedulerefreshconfig)
		{
			return new ITimeScheduleRefreshConfig_UnionUnion
			{
				Type = ITimeScheduleRefreshConfig_Union.ITimeScheduleRefreshConfig,
				Value = _itimeschedulerefreshconfig
			};
		}

		// Token: 0x06027902 RID: 162050 RVA: 0x0057115C File Offset: 0x0056F35C
		public ITimeScheduleGameDailyRefreshT AsITimeScheduleGameDailyRefresh()
		{
			return this.As<ITimeScheduleGameDailyRefreshT>();
		}

		// Token: 0x06027903 RID: 162051 RVA: 0x00571164 File Offset: 0x0056F364
		public static ITimeScheduleRefreshConfig_UnionUnion FromITimeScheduleGameDailyRefresh(ITimeScheduleGameDailyRefreshT _itimeschedulegamedailyrefresh)
		{
			return new ITimeScheduleRefreshConfig_UnionUnion
			{
				Type = ITimeScheduleRefreshConfig_Union.ITimeScheduleGameDailyRefresh,
				Value = _itimeschedulegamedailyrefresh
			};
		}

		// Token: 0x06027904 RID: 162052 RVA: 0x0057117C File Offset: 0x0056F37C
		public static int Pack(FlatBufferBuilder builder, ITimeScheduleRefreshConfig_UnionUnion _o)
		{
			ITimeScheduleRefreshConfig_Union type = _o.Type;
			if (type == ITimeScheduleRefreshConfig_Union.ITimeScheduleRefreshConfig)
			{
				return ITimeScheduleRefreshConfig.Pack(builder, _o.AsITimeScheduleRefreshConfig()).Value;
			}
			if (type != ITimeScheduleRefreshConfig_Union.ITimeScheduleGameDailyRefresh)
			{
				return 0;
			}
			return ITimeScheduleGameDailyRefresh.Pack(builder, _o.AsITimeScheduleGameDailyRefresh()).Value;
		}
	}
}
