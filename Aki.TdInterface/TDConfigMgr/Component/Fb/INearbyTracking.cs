using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BEE RID: 3054
	public class INearbyTracking
	{
		// Token: 0x06004625 RID: 17957 RVA: 0x000B158F File Offset: 0x000AF78F
		[NullableContext(1)]
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

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x000B15AE File Offset: 0x000AF7AE
		public virtual ENearbyTrackingType Type
		{
			get
			{
				return (ENearbyTrackingType)this.Instance.Type;
			}
		}

		// Token: 0x040027F5 RID: 10229
		private INearbyTracking Instance;
	}
}
