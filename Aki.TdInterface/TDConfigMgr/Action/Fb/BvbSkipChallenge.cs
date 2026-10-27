using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2D RID: 10797
	public class BvbSkipChallenge : ActionParams
	{
		// Token: 0x0600EDE8 RID: 60904 RVA: 0x0022AAB2 File Offset: 0x00228CB2
		[NullableContext(1)]
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

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x0600EDE9 RID: 60905 RVA: 0x0022AAD1 File Offset: 0x00228CD1
		public virtual int ChallengeId
		{
			get
			{
				return this.Instance.ChallengeId;
			}
		}

		// Token: 0x040082F1 RID: 33521
		private IBvbSkipChallenge Instance;
	}
}
