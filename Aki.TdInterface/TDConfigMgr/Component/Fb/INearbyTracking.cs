using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CBD RID: 3261
	public class INearbyTracking
	{
		// Token: 0x06004A83 RID: 19075 RVA: 0x000BB70B File Offset: 0x000B990B
		public static INearbyTracking Create(INearbyTracking? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INearbyTracking
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x000BB72A File Offset: 0x000B992A
		public virtual ENearbyTrackingType Type
		{
			get
			{
				return (ENearbyTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x04002A40 RID: 10816
		private INearbyTracking Instance;
	}
}
