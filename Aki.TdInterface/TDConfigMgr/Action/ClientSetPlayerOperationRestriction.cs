using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001503 RID: 5379
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientSetPlayerOperationRestriction : ActionParams
	{
		// Token: 0x06007A4A RID: 31306 RVA: 0x00124178 File Offset: 0x00122378
		private ClientSetPlayerOperationRestriction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ClientSetPlayerOperationRestriction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ClientSetPlayerOperationRestriction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ClientSetPlayerOperationRestriction_SetValue());
			}
			return result;
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x001241B0 File Offset: 0x001223B0
		public static ClientSetPlayerOperationRestriction Create([Nullable(2)] ClientSetPlayerOperationRestriction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientSetPlayerOperationRestriction
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x001241C3 File Offset: 0x001223C3
		public static ClientSetPlayerOperationRestriction CreateFromSetValue([Nullable(2)] ClientSetPlayerOperationRestriction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ClientSetPlayerOperationRestriction
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x001241D6 File Offset: 0x001223D6
		public ClientSetPlayerOperationRestriction_SetValue ToSetValue()
		{
			return new ClientSetPlayerOperationRestriction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x06007A4E RID: 31310 RVA: 0x001241E9 File Offset: 0x001223E9
		// (set) Token: 0x06007A4F RID: 31311 RVA: 0x00124214 File Offset: 0x00122414
		public virtual EPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040046DA RID: 18138
		[Nullable(2)]
		protected new ClientSetPlayerOperationRestriction FbInstance;

		// Token: 0x040046DB RID: 18139
		[Nullable(2)]
		protected ClientSetPlayerOperationRestriction_SetValue PocoInterface;
	}
}
