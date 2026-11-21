using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001473 RID: 5235
	public class IRoleTowerChallengeTitleCurrentFloor : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06007709 RID: 30473 RVA: 0x0011DD1C File Offset: 0x0011BF1C
		public static IRoleTowerChallengeTitleCurrentFloor Create(IRoleTowerChallengeTitleCurrentFloor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleCurrentFloor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x0600770A RID: 30474 RVA: 0x0011DD3B File Offset: 0x0011BF3B
		public override ERoleTowerChallengeTitleType Type
		{
			get
			{
				return (ERoleTowerChallengeTitleType)this.Instance.Type;
			}
		}

		// Token: 0x04004451 RID: 17489
		private IRoleTowerChallengeTitleCurrentFloor Instance;
	}
}
