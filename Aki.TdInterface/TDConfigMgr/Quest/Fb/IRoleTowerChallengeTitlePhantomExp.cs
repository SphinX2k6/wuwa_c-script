using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001322 RID: 4898
	public class IRoleTowerChallengeTitlePhantomExp : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06007066 RID: 28774 RVA: 0x0010F77C File Offset: 0x0010D97C
		[NullableContext(1)]
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

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x0010F79B File Offset: 0x0010D99B
		public override ERoleTowerChallengeTitleType Type
		{
			get
			{
				return (ERoleTowerChallengeTitleType)this.Instance.Type;
			}
		}

		// Token: 0x040040D4 RID: 16596
		private IRoleTowerChallengeTitlePhantomExp Instance;
	}
}
