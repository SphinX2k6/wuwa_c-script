using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001232 RID: 4658
	public class IRoleTowerChallengeTitlePhantomExp : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06006875 RID: 26741 RVA: 0x000FA3DC File Offset: 0x000F85DC
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

		// Token: 0x06006876 RID: 26742 RVA: 0x000FA414 File Offset: 0x000F8614
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

		// Token: 0x06006877 RID: 26743 RVA: 0x000FA427 File Offset: 0x000F8627
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

		// Token: 0x06006878 RID: 26744 RVA: 0x000FA43A File Offset: 0x000F863A
		public new IRoleTowerChallengeTitlePhantomExp_SetValue ToSetValue()
		{
			return new IRoleTowerChallengeTitlePhantomExp_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x06006879 RID: 26745 RVA: 0x000FA44D File Offset: 0x000F864D
		// (set) Token: 0x0600687A RID: 26746 RVA: 0x000FA478 File Offset: 0x000F8678
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

		// Token: 0x04003E70 RID: 15984
		[Nullable(2)]
		protected new IRoleTowerChallengeTitlePhantomExp FbInstance;

		// Token: 0x04003E71 RID: 15985
		[Nullable(2)]
		protected new IRoleTowerChallengeTitlePhantomExp_SetValue PocoInterface;
	}
}
