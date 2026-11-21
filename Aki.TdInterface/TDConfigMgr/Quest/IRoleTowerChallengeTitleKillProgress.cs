using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001230 RID: 4656
	public class IRoleTowerChallengeTitleKillProgress : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x0600686D RID: 26733 RVA: 0x000FA320 File Offset: 0x000F8520
		private IRoleTowerChallengeTitleKillProgress_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerChallengeTitleKillProgress 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerChallengeTitleKillProgress_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerChallengeTitleKillProgress_SetValue());
			}
			return result;
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x000FA358 File Offset: 0x000F8558
		public static IRoleTowerChallengeTitleKillProgress Create([Nullable(2)] IRoleTowerChallengeTitleKillProgress instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleKillProgress
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x000FA36B File Offset: 0x000F856B
		public static IRoleTowerChallengeTitleKillProgress CreateFromSetValue([Nullable(2)] IRoleTowerChallengeTitleKillProgress_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleKillProgress
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x000FA37E File Offset: 0x000F857E
		public new IRoleTowerChallengeTitleKillProgress_SetValue ToSetValue()
		{
			return new IRoleTowerChallengeTitleKillProgress_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x000FA391 File Offset: 0x000F8591
		// (set) Token: 0x06006872 RID: 26738 RVA: 0x000FA3BC File Offset: 0x000F85BC
		public override ERoleTowerChallengeTitleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERoleTowerChallengeTitleType.KillProgress;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E6D RID: 15981
		[Nullable(2)]
		protected new IRoleTowerChallengeTitleKillProgress FbInstance;

		// Token: 0x04003E6E RID: 15982
		[Nullable(2)]
		protected new IRoleTowerChallengeTitleKillProgress_SetValue PocoInterface;
	}
}
