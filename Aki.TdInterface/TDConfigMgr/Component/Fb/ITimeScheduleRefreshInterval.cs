using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ED9 RID: 3801
	public class ITimeScheduleRefreshInterval
	{
		// Token: 0x060055A2 RID: 21922 RVA: 0x000D259C File Offset: 0x000D079C
		public static ITimeScheduleRefreshInterval Create(ITimeScheduleRefreshInterval? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshInterval
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x000D25BB File Offset: 0x000D07BB
		public virtual float MaxInterval
		{
			get
			{
				return this.Instance.MaxInterval;
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x060055A4 RID: 21924 RVA: 0x000D25C8 File Offset: 0x000D07C8
		public virtual float MinInterval
		{
			get
			{
				return this.Instance.MinInterval;
			}
		}

		// Token: 0x040030FE RID: 12542
		private ITimeScheduleRefreshInterval Instance;
	}
}
