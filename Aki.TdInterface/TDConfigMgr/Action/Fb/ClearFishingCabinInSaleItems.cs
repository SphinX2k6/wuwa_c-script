using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002945 RID: 10565
	public class ClearFishingCabinInSaleItems : ActionParams
	{
		// Token: 0x0600EAA9 RID: 60073 RVA: 0x00229D5E File Offset: 0x00227F5E
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

		// Token: 0x04008151 RID: 33105
		private IClearFishingCabinInSaleItems Instance;
	}
}
