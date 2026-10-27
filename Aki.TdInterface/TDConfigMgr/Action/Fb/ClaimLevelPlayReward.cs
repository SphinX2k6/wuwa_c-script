using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200267E RID: 9854
	public class ClaimLevelPlayReward : ActionParams
	{
		// Token: 0x0600DCC7 RID: 56519 RVA: 0x0020D4D6 File Offset: 0x0020B6D6
		[NullableContext(1)]
		public static ClaimLevelPlayReward Create(IClaimLevelPlayReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClaimLevelPlayReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04007AAE RID: 31406
		private IClaimLevelPlayReward Instance;
	}
}
