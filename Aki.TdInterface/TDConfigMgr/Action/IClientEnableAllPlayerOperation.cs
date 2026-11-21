using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A2F RID: 6703
	public class IClientEnableAllPlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x06008E99 RID: 36505 RVA: 0x00150994 File Offset: 0x0014EB94
		private IClientEnableAllPlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientEnableAllPlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientEnableAllPlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientEnableAllPlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008E9A RID: 36506 RVA: 0x001509CC File Offset: 0x0014EBCC
		public static IClientEnableAllPlayerOperation Create([Nullable(2)] IClientEnableAllPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEnableAllPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E9B RID: 36507 RVA: 0x001509DF File Offset: 0x0014EBDF
		public static IClientEnableAllPlayerOperation CreateFromSetValue([Nullable(2)] IClientEnableAllPlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientEnableAllPlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E9C RID: 36508 RVA: 0x001509F2 File Offset: 0x0014EBF2
		public new IClientEnableAllPlayerOperation_SetValue ToSetValue()
		{
			return new IClientEnableAllPlayerOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x06008E9D RID: 36509 RVA: 0x00150A05 File Offset: 0x0014EC05
		// (set) Token: 0x06008E9E RID: 36510 RVA: 0x00150A30 File Offset: 0x0014EC30
		public override EPlayerOperationType Type
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

		// Token: 0x0400598B RID: 22923
		[Nullable(2)]
		protected new IClientEnableAllPlayerOperation FbInstance;

		// Token: 0x0400598C RID: 22924
		[Nullable(2)]
		protected new IClientEnableAllPlayerOperation_SetValue PocoInterface;
	}
}
