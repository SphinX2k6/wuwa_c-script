using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200122E RID: 4654
	public class IRoleTowerChallengeTitleCurrentFloor : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x06006865 RID: 26725 RVA: 0x000FA264 File Offset: 0x000F8464
		private IRoleTowerChallengeTitleCurrentFloor_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoleTowerChallengeTitleCurrentFloor 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoleTowerChallengeTitleCurrentFloor_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoleTowerChallengeTitleCurrentFloor_SetValue());
			}
			return result;
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x000FA29C File Offset: 0x000F849C
		public static IRoleTowerChallengeTitleCurrentFloor Create([Nullable(2)] IRoleTowerChallengeTitleCurrentFloor instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleCurrentFloor
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x000FA2AF File Offset: 0x000F84AF
		public static IRoleTowerChallengeTitleCurrentFloor CreateFromSetValue([Nullable(2)] IRoleTowerChallengeTitleCurrentFloor_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoleTowerChallengeTitleCurrentFloor
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x000FA2C2 File Offset: 0x000F84C2
		public new IRoleTowerChallengeTitleCurrentFloor_SetValue ToSetValue()
		{
			return new IRoleTowerChallengeTitleCurrentFloor_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x06006869 RID: 26729 RVA: 0x000FA2D5 File Offset: 0x000F84D5
		// (set) Token: 0x0600686A RID: 26730 RVA: 0x000FA300 File Offset: 0x000F8500
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

		// Token: 0x04003E6A RID: 15978
		[Nullable(2)]
		protected new IRoleTowerChallengeTitleCurrentFloor FbInstance;

		// Token: 0x04003E6B RID: 15979
		[Nullable(2)]
		protected new IRoleTowerChallengeTitleCurrentFloor_SetValue PocoInterface;
	}
}
