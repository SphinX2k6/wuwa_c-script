using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001611 RID: 5649
	public class BvbSkipChallenge : ActionParams
	{
		// Token: 0x06007F87 RID: 32647 RVA: 0x001300DC File Offset: 0x0012E2DC
		private BvbSkipChallenge_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("BvbSkipChallenge 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			BvbSkipChallenge_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new BvbSkipChallenge_SetValue());
			}
			return result;
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x00130114 File Offset: 0x0012E314
		public static BvbSkipChallenge Create([Nullable(2)] BvbSkipChallenge instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BvbSkipChallenge
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x00130127 File Offset: 0x0012E327
		public static BvbSkipChallenge CreateFromSetValue([Nullable(2)] BvbSkipChallenge_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new BvbSkipChallenge
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x0013013A File Offset: 0x0012E33A
		public BvbSkipChallenge_SetValue ToSetValue()
		{
			return new BvbSkipChallenge_SetValue
			{
				ChallengeId = this.ChallengeId
			};
		}

		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x06007F8B RID: 32651 RVA: 0x0013014D File Offset: 0x0012E34D
		// (set) Token: 0x06007F8C RID: 32652 RVA: 0x00130178 File Offset: 0x0012E378
		public virtual int ChallengeId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChallengeId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ChallengeId;
			}
			set
			{
				this.GetOrCreatePoco().ChallengeId = value;
			}
		}

		// Token: 0x040049BB RID: 18875
		[Nullable(2)]
		protected new BvbSkipChallenge FbInstance;

		// Token: 0x040049BC RID: 18876
		[Nullable(2)]
		protected BvbSkipChallenge_SetValue PocoInterface;
	}
}
