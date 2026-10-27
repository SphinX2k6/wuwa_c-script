using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001100 RID: 4352
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoleTowerChallengeTitleCurrentFloor : IRoleTowerChallengeTitleTypeBase
	{
		// Token: 0x0600626A RID: 25194 RVA: 0x000ED0F0 File Offset: 0x000EB2F0
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

		// Token: 0x0600626B RID: 25195 RVA: 0x000ED128 File Offset: 0x000EB328
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

		// Token: 0x0600626C RID: 25196 RVA: 0x000ED13B File Offset: 0x000EB33B
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

		// Token: 0x0600626D RID: 25197 RVA: 0x000ED14E File Offset: 0x000EB34E
		public new IRoleTowerChallengeTitleCurrentFloor_SetValue ToSetValue()
		{
			return new IRoleTowerChallengeTitleCurrentFloor_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x0600626E RID: 25198 RVA: 0x000ED161 File Offset: 0x000EB361
		// (set) Token: 0x0600626F RID: 25199 RVA: 0x000ED18C File Offset: 0x000EB38C
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

		// Token: 0x04003B1C RID: 15132
		[Nullable(2)]
		protected new IRoleTowerChallengeTitleCurrentFloor FbInstance;

		// Token: 0x04003B1D RID: 15133
		[Nullable(2)]
		protected new IRoleTowerChallengeTitleCurrentFloor_SetValue PocoInterface;
	}
}
