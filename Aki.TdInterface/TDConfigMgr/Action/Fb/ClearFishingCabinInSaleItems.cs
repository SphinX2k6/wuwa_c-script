using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002682 RID: 9858
	public class ClearFishingCabinInSaleItems : ActionParams
	{
		// Token: 0x0600DCD2 RID: 56530 RVA: 0x0020D5C0 File Offset: 0x0020B7C0
		[NullableContext(1)]
		public static ClearFishingCabinInSaleItems Create(IClearFishingCabinInSaleItems? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClearFishingCabinInSaleItems
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007AB4 RID: 31412
		private IClearFishingCabinInSaleItems Instance;
	}
}
