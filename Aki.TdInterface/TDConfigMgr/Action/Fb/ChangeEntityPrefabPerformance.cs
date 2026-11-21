using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C3A RID: 11322
	public class ChangeEntityPrefabPerformance : ActionParams
	{
		// Token: 0x0600F91C RID: 63772 RVA: 0x00243359 File Offset: 0x00241559
		public static ChangeEntityPrefabPerformance Create(IChangeEntityPrefabPerformance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeEntityPrefabPerformance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D56 RID: 19798
		// (get) Token: 0x0600F91D RID: 63773 RVA: 0x00243378 File Offset: 0x00241578
		public virtual EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x04008832 RID: 34866
		private IChangeEntityPrefabPerformance Instance;
	}
}
