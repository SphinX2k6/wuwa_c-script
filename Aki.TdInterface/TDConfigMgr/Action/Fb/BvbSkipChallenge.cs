using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D1A RID: 11546
	public class BvbSkipChallenge : ActionParams
	{
		// Token: 0x0600FC80 RID: 64640 RVA: 0x00248466 File Offset: 0x00246666
		public static BvbSkipChallenge Create(IBvbSkipChallenge? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BvbSkipChallenge
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EFA RID: 20218
		// (get) Token: 0x0600FC81 RID: 64641 RVA: 0x00248485 File Offset: 0x00246685
		public virtual int ChallengeId
		{
			get
			{
				return this.Instance.ChallengeId;
			}
		}

		// Token: 0x040089E4 RID: 35300
		private IBvbSkipChallenge Instance;
	}
}
