using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014F8 RID: 5368
	public class ClearFishingCabinInSaleItems : ActionParams
	{
		// Token: 0x06007A10 RID: 31248 RVA: 0x00123B36 File Offset: 0x00121D36
		[NullableContext(1)]
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

		// Token: 0x040046C0 RID: 18112
		[Nullable(2)]
		protected new ClearFishingCabinInSaleItems FbInstance;
	}
}
