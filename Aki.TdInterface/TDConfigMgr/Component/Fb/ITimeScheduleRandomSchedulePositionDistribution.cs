using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDE RID: 3550
	public class ITimeScheduleRandomSchedulePositionDistribution : ITimeScheduleDistributionConfig
	{
		// Token: 0x0600507F RID: 20607 RVA: 0x000C6D19 File Offset: 0x000C4F19
		[NullableContext(1)]
		public static ITimeScheduleRandomSchedulePositionDistribution Create(ITimeScheduleRandomSchedulePositionDistribution? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleRandomSchedulePositionDistribution
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x000C6D38 File Offset: 0x000C4F38
		public override ETimeScheduleDistributionType Type
		{
			get
			{
				return (ETimeScheduleDistributionType)this.Instance.Type;
			}
		}

		// Token: 0x04002E37 RID: 11831
		private ITimeScheduleRandomSchedulePositionDistribution Instance;
	}
}
