using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A8 RID: 9896
	public class ClaimDungeonReward : ActionParams
	{
		// Token: 0x0600DD7F RID: 56703 RVA: 0x0020E703 File Offset: 0x0020C903
		[NullableContext(1)]
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

		// Token: 0x04007B00 RID: 31488
		private IClaimDungeonReward Instance;
	}
}
