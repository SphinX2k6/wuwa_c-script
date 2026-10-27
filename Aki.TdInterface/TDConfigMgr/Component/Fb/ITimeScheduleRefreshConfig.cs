using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDB RID: 3547
	public class ITimeScheduleRefreshConfig
	{
		// Token: 0x06005076 RID: 20598 RVA: 0x000C6C7D File Offset: 0x000C4E7D
		[NullableContext(1)]
		public static ITimeScheduleRefreshConfig Create(ITimeScheduleRefreshConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06005077 RID: 20599 RVA: 0x000C6C9C File Offset: 0x000C4E9C
		public virtual ETimeScheduleRefreshType Type
		{
			get
			{
				return (ETimeScheduleRefreshType)this.Instance.Type;
			}
		}

		// Token: 0x04002E34 RID: 11828
		private ITimeScheduleRefreshConfig Instance;
	}
}
