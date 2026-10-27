using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDC RID: 3548
	public class ITimeScheduleGameDailyRefresh : ITimeScheduleRefreshConfig
	{
		// Token: 0x06005079 RID: 20601 RVA: 0x000C6CB1 File Offset: 0x000C4EB1
		[NullableContext(1)]
		public static ITimeScheduleGameDailyRefresh Create(ITimeScheduleGameDailyRefresh? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleGameDailyRefresh
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x0600507A RID: 20602 RVA: 0x000C6CD0 File Offset: 0x000C4ED0
		public override ETimeScheduleRefreshType Type
		{
			get
			{
				return (ETimeScheduleRefreshType)this.Instance.Type;
			}
		}

		// Token: 0x04002E35 RID: 11829
		private ITimeScheduleGameDailyRefresh Instance;
	}
}
