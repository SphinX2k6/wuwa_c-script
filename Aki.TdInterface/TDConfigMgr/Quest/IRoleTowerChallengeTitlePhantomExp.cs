using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001104 RID: 4356
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerChallengeTitlePhantomExp : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x0600627A RID: 25210 RVA: 0x000ED268 File Offset: 0x000EB468
		private IRoleTowerChallengeTitlePhantomExp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerChallengeTitlePhantomExp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerChallengeTitlePhantomExp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerChallengeTitlePhantomExp_SetValue());
			}
			return result;
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x000ED2A0 File Offset: 0x000EB4A0
		public static IRoleTowerChallengeTitlePhantomExp Create([Nullable(2)] IRoleTowerChallengeTitlePhantomExp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitlePhantomExp
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x000ED2B3 File Offset: 0x000EB4B3
		public static IRoleTowerChallengeTitlePhantomExp CreateFromSetValue([Nullable(2)] IRoleTowerChallengeTitlePhantomExp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitlePhantomExp
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x000ED2C6 File Offset: 0x000EB4C6
		public new IRoleTowerChallengeTitlePhantomExp_SetValue ToSetValue()
		{
			return new IRoleTowerChallengeTitlePhantomExp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x0600627E RID: 25214 RVA: 0x000ED2D9 File Offset: 0x000EB4D9
		// (set) Token: 0x0600627F RID: 25215 RVA: 0x000ED304 File Offset: 0x000EB504
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

		// Token: 0x04003B22 RID: 15138
		[Nullable(2)]
		protected new IRoleTowerChallengeTitlePhantomExp FbInstance;

		// Token: 0x04003B23 RID: 15139
		[Nullable(2)]
		protected new IRoleTowerChallengeTitlePhantomExp_SetValue PocoInterface;
	}
}
