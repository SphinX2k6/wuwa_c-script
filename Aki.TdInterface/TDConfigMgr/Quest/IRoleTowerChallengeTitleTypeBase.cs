using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001106 RID: 4358
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06006282 RID: 25218 RVA: 0x000ED324 File Offset: 0x000EB524
		private IRoleTowerChallengeTitleTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerChallengeTitleTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerChallengeTitleTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerChallengeTitleTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x000ED35C File Offset: 0x000EB55C
		public static IRoleTowerChallengeTitleTypeBase Create([Nullable(2)] IRoleTowerChallengeTitleTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x000ED36F File Offset: 0x000EB56F
		public static IRoleTowerChallengeTitleTypeBase CreateFromSetValue([Nullable(2)] IRoleTowerChallengeTitleTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x000ED382 File Offset: 0x000EB582
		public IRoleTowerChallengeTitleTypeBase_SetValue ToSetValue()
		{
			return new IRoleTowerChallengeTitleTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06006286 RID: 25222 RVA: 0x000ED395 File Offset: 0x000EB595
		// (set) Token: 0x06006287 RID: 25223 RVA: 0x000ED3C0 File Offset: 0x000EB5C0
		public virtual ERoleTowerChallengeTitleType Type
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

		// Token: 0x04003B25 RID: 15141
		[Nullable(2)]
		protected IRoleTowerChallengeTitleTypeBase FbInstance;

		// Token: 0x04003B26 RID: 15142
		[Nullable(2)]
		protected IRoleTowerChallengeTitleTypeBase_SetValue PocoInterface;
	}
}
