using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001320 RID: 4896
	public class IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06007060 RID: 28768 RVA: 0x0010F714 File Offset: 0x0010D914
		[NullableContext(1)]
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

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x0010F733 File Offset: 0x0010D933
		public virtual ERoleTowerChallengeTitleType Type
		{
			get
			{
				return (ERoleTowerChallengeTitleType)this.Instance.Type;
			}
		}

		// Token: 0x040040D2 RID: 16594
		private IRoleTowerChallengeTitleTypeBase Instance;
	}
}
