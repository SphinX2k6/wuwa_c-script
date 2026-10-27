using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001323 RID: 4899
	public class IRoleTowerChallengeTitleCurrentFloor : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06007069 RID: 28777 RVA: 0x0010F7B0 File Offset: 0x0010D9B0
		[NullableContext(1)]
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

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x0600706A RID: 28778 RVA: 0x0010F7CF File Offset: 0x0010D9CF
		public override ERoleTowerChallengeTitleType Type
		{
			get
			{
				return (ERoleTowerChallengeTitleType)this.Instance.Type;
			}
		}

		// Token: 0x040040D5 RID: 16597
		private IRoleTowerChallengeTitleCurrentFloor Instance;
	}
}
