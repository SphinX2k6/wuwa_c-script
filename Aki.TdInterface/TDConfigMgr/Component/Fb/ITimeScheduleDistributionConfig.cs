using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDD RID: 3549
	public class ITimeScheduleDistributionConfig
	{
		// Token: 0x0600507C RID: 20604 RVA: 0x000C6CE5 File Offset: 0x000C4EE5
		[NullableContext(1)]
		public static ITimeScheduleDistributionConfig Create(ITimeScheduleDistributionConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleDistributionConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x0600507D RID: 20605 RVA: 0x000C6D04 File Offset: 0x000C4F04
		public virtual ETimeScheduleDistributionType Type
		{
			get
			{
				return (ETimeScheduleDistributionType)this.Instance.Type;
			}
		}

		// Token: 0x04002E36 RID: 11830
		private ITimeScheduleDistributionConfig Instance;
	}
}
