using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002941 RID: 10561
	public class ClaimLevelPlayReward : ActionParams
	{
		// Token: 0x0600EA9E RID: 60062 RVA: 0x00229C74 File Offset: 0x00227E74
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

		// Token: 0x0400814B RID: 33099
		private IClaimLevelPlayReward Instance;
	}
}
