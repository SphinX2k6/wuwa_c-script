using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014B8 RID: 5304
	[NullableContext(1)]
	[Nullable(0)]
	public class BvbSkipChallenge : ActionParams
	{
		// Token: 0x060078BA RID: 30906 RVA: 0x00121490 File Offset: 0x0011F690
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

		// Token: 0x060078BB RID: 30907 RVA: 0x001214C8 File Offset: 0x0011F6C8
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

		// Token: 0x060078BC RID: 30908 RVA: 0x001214DB File Offset: 0x0011F6DB
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

		// Token: 0x060078BD RID: 30909 RVA: 0x001214EE File Offset: 0x0011F6EE
		public BvbSkipChallenge_SetValue ToSetValue()
		{
			return new BvbSkipChallenge_SetValue
			{
				ChallengeId = this.ChallengeId
			};
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x060078BE RID: 30910 RVA: 0x00121501 File Offset: 0x0011F701
		// (set) Token: 0x060078BF RID: 30911 RVA: 0x0012152C File Offset: 0x0011F72C
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

		// Token: 0x04004620 RID: 17952
		[Nullable(2)]
		protected new BvbSkipChallenge FbInstance;

		// Token: 0x04004621 RID: 17953
		[Nullable(2)]
		protected BvbSkipChallenge_SetValue PocoInterface;
	}
}
