using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002947 RID: 10567
	public class DestroyFishingBoat : ActionParams
	{
		// Token: 0x0600EAAF RID: 60079 RVA: 0x00229DF2 File Offset: 0x00227FF2
		public static DestroyFishingBoat Create(IDestroyFishingBoat? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyFishingBoat
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04008153 RID: 33107
		private IDestroyFishingBoat Instance;
	}
}
