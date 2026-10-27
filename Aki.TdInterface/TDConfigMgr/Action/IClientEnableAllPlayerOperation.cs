using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A4 RID: 6308
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientEnableAllPlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x06008771 RID: 34673 RVA: 0x00141160 File Offset: 0x0013F360
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

		// Token: 0x06008772 RID: 34674 RVA: 0x00141198 File Offset: 0x0013F398
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

		// Token: 0x06008773 RID: 34675 RVA: 0x001411AB File Offset: 0x0013F3AB
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

		// Token: 0x06008774 RID: 34676 RVA: 0x001411BE File Offset: 0x0013F3BE
		public new IClientEnableAllPlayerOperation_SetValue ToSetValue()
		{
			return new IClientEnableAllPlayerOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x06008775 RID: 34677 RVA: 0x001411D1 File Offset: 0x0013F3D1
		// (set) Token: 0x06008776 RID: 34678 RVA: 0x001411FC File Offset: 0x0013F3FC
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

		// Token: 0x0400553E RID: 21822
		[Nullable(2)]
		protected new IClientEnableAllPlayerOperation FbInstance;

		// Token: 0x0400553F RID: 21823
		[Nullable(2)]
		protected new IClientEnableAllPlayerOperation_SetValue PocoInterface;
	}
}
