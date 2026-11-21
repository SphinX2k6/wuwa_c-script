using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EDA RID: 3802
	public class ITimeScheduleRefreshPosition
	{
		// Token: 0x060055A6 RID: 21926 RVA: 0x000D25DD File Offset: 0x000D07DD
		public static ITimeScheduleRefreshPosition Create(ITimeScheduleRefreshPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleRefreshPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x060055A7 RID: 21927 RVA: 0x000D25FC File Offset: 0x000D07FC
		public virtual ETimeScheduleRefreshPositionType Type
		{
			get
			{
				return (ETimeScheduleRefreshPositionType)this.Instance.Type;
			}
		}

		// Token: 0x040030FF RID: 12543
		private ITimeScheduleRefreshPosition Instance;
	}
}
