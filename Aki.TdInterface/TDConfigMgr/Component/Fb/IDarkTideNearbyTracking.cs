using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC2 RID: 3266
	public class IDarkTideNearbyTracking : INearbyTracking
	{
		// Token: 0x06004AA2 RID: 19106 RVA: 0x000BBA69 File Offset: 0x000B9C69
		public static IDarkTideNearbyTracking Create(IDarkTideNearbyTracking? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDarkTideNearbyTracking
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06004AA3 RID: 19107 RVA: 0x000BBA88 File Offset: 0x000B9C88
		public override ENearbyTrackingType Type
		{
			get
			{
				return (ENearbyTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x000BBA95 File Offset: 0x000B9C95
		public virtual int ShowRange
		{
			get
			{
				return this.Instance.ShowRange;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06004AA5 RID: 19109 RVA: 0x000BBAA2 File Offset: 0x000B9CA2
		public virtual int HideRange
		{
			get
			{
				return this.Instance.HideRange;
			}
		}

		// Token: 0x04002A4D RID: 10829
		private IDarkTideNearbyTracking Instance;
	}
}
