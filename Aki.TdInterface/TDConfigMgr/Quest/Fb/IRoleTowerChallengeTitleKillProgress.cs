using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001471 RID: 5233
	public class IRoleTowerChallengeTitleKillProgress : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06007703 RID: 30467 RVA: 0x0011DCB4 File Offset: 0x0011BEB4
		public static IRoleTowerChallengeTitleKillProgress Create(IRoleTowerChallengeTitleKillProgress? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleKillProgress
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x06007704 RID: 30468 RVA: 0x0011DCD3 File Offset: 0x0011BED3
		public override ERoleTowerChallengeTitleType Type
		{
			get
			{
				return (ERoleTowerChallengeTitleType)this.Instance.Type;
			}
		}

		// Token: 0x0400444F RID: 17487
		private IRoleTowerChallengeTitleKillProgress Instance;
	}
}
