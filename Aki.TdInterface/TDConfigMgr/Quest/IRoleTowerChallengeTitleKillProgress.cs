using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001102 RID: 4354
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerChallengeTitleKillProgress : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06006272 RID: 25202 RVA: 0x000ED1AC File Offset: 0x000EB3AC
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

		// Token: 0x06006273 RID: 25203 RVA: 0x000ED1E4 File Offset: 0x000EB3E4
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

		// Token: 0x06006274 RID: 25204 RVA: 0x000ED1F7 File Offset: 0x000EB3F7
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

		// Token: 0x06006275 RID: 25205 RVA: 0x000ED20A File Offset: 0x000EB40A
		public new IRoleTowerChallengeTitleKillProgress_SetValue ToSetValue()
		{
			return new IRoleTowerChallengeTitleKillProgress_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06006276 RID: 25206 RVA: 0x000ED21D File Offset: 0x000EB41D
		// (set) Token: 0x06006277 RID: 25207 RVA: 0x000ED248 File Offset: 0x000EB448
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

		// Token: 0x04003B1F RID: 15135
		[Nullable(2)]
		protected new IRoleTowerChallengeTitleKillProgress FbInstance;

		// Token: 0x04003B20 RID: 15136
		[Nullable(2)]
		protected new IRoleTowerChallengeTitleKillProgress_SetValue PocoInterface;
	}
}
