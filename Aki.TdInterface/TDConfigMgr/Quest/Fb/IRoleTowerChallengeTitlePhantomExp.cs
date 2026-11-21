using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001472 RID: 5234
	public class IRoleTowerChallengeTitlePhantomExp : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06007706 RID: 30470 RVA: 0x0011DCE8 File Offset: 0x0011BEE8
		public static IRoleTowerChallengeTitlePhantomExp Create(IRoleTowerChallengeTitlePhantomExp? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitlePhantomExp
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x06007707 RID: 30471 RVA: 0x0011DD07 File Offset: 0x0011BF07
		public override ERoleTowerChallengeTitleType Type
		{
			get
			{
				return (ERoleTowerChallengeTitleType)this.Instance.Type;
			}
		}

		// Token: 0x04004450 RID: 17488
		private IRoleTowerChallengeTitlePhantomExp Instance;
	}
}
