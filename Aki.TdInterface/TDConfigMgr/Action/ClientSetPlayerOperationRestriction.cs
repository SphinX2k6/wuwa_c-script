using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200165E RID: 5726
	public class ClientSetPlayerOperationRestriction : ActionParams
	{
		// Token: 0x0600811D RID: 33053 RVA: 0x00132E58 File Offset: 0x00131058
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

		// Token: 0x0600811E RID: 33054 RVA: 0x00132E90 File Offset: 0x00131090
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

		// Token: 0x0600811F RID: 33055 RVA: 0x00132EA3 File Offset: 0x001310A3
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

		// Token: 0x06008120 RID: 33056 RVA: 0x00132EB6 File Offset: 0x001310B6
		public ClientSetPlayerOperationRestriction_SetValue ToSetValue()
		{
			return new ClientSetPlayerOperationRestriction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x06008121 RID: 33057 RVA: 0x00132EC9 File Offset: 0x001310C9
		// (set) Token: 0x06008122 RID: 33058 RVA: 0x00132EF4 File Offset: 0x001310F4
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

		// Token: 0x04004A79 RID: 19065
		[Nullable(2)]
		protected new ClientSetPlayerOperationRestriction FbInstance;

		// Token: 0x04004A7A RID: 19066
		[Nullable(2)]
		protected ClientSetPlayerOperationRestriction_SetValue PocoInterface;
	}
}
