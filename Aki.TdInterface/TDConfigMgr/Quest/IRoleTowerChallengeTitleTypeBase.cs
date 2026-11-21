using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001234 RID: 4660
	public class IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x0600687D RID: 26749 RVA: 0x000FA498 File Offset: 0x000F8698
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

		// Token: 0x0600687E RID: 26750 RVA: 0x000FA4D0 File Offset: 0x000F86D0
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

		// Token: 0x0600687F RID: 26751 RVA: 0x000FA4E3 File Offset: 0x000F86E3
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

		// Token: 0x06006880 RID: 26752 RVA: 0x000FA4F6 File Offset: 0x000F86F6
		public IRoleTowerChallengeTitleTypeBase_SetValue ToSetValue()
		{
			return new IRoleTowerChallengeTitleTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06006881 RID: 26753 RVA: 0x000FA509 File Offset: 0x000F8709
		// (set) Token: 0x06006882 RID: 26754 RVA: 0x000FA534 File Offset: 0x000F8734
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

		// Token: 0x04003E73 RID: 15987
		[Nullable(2)]
		protected IRoleTowerChallengeTitleTypeBase FbInstance;

		// Token: 0x04003E74 RID: 15988
		[Nullable(2)]
		protected IRoleTowerChallengeTitleTypeBase_SetValue PocoInterface;
	}
}
