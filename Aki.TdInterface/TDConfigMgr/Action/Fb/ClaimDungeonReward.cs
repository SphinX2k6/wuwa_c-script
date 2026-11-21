using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296B RID: 10603
	public class ClaimDungeonReward : ActionParams
	{
		// Token: 0x0600EB56 RID: 60246 RVA: 0x0022AEA3 File Offset: 0x002290A3
		public static ClaimDungeonReward Create(IClaimDungeonReward? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClaimDungeonReward
			{
				Instance = instance.Value
			};
		}

		// Token: 0x0400819D RID: 33181
		private IClaimDungeonReward Instance;
	}
}
