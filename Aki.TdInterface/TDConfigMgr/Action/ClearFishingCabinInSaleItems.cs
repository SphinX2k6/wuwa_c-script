using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001651 RID: 5713
	public class ClearFishingCabinInSaleItems : ActionParams
	{
		// Token: 0x060080DD RID: 32989 RVA: 0x0013276E File Offset: 0x0013096E
		public static ClearFishingCabinInSaleItems Create([Nullable(2)] ClearFishingCabinInSaleItems instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearFishingCabinInSaleItems
			{
				FbInstance = instance
			};
		}

		// Token: 0x04004A5B RID: 19035
		[Nullable(2)]
		protected new ClearFishingCabinInSaleItems FbInstance;
	}
}
