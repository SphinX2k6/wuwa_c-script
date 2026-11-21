using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001470 RID: 5232
	public class IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06007700 RID: 30464 RVA: 0x0011DC80 File Offset: 0x0011BE80
		public static IRoleTowerChallengeTitleTypeBase Create(IRoleTowerChallengeTitleTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x06007701 RID: 30465 RVA: 0x0011DC9F File Offset: 0x0011BE9F
		public virtual ERoleTowerChallengeTitleType Type
		{
			get
			{
				return (ERoleTowerChallengeTitleType)this.Instance.Type;
			}
		}

		// Token: 0x0400444E RID: 17486
		private IRoleTowerChallengeTitleTypeBase Instance;
	}
}
