using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001321 RID: 4897
	public class IRoleTowerChallengeTitleKillProgress : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06007063 RID: 28771 RVA: 0x0010F748 File Offset: 0x0010D948
		[NullableContext(1)]
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

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x06007064 RID: 28772 RVA: 0x0010F767 File Offset: 0x0010D967
		public override ERoleTowerChallengeTitleType Type
		{
			get
			{
				return (ERoleTowerChallengeTitleType)this.Instance.Type;
			}
		}

		// Token: 0x040040D3 RID: 16595
		private IRoleTowerChallengeTitleKillProgress Instance;
	}
}
