using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200215A RID: 8538
	[NullableContext(1)]
	[Nullable(0)]
	public class RequestSystemFunction : ActionParams
	{
		// Token: 0x0600BBE2 RID: 48098 RVA: 0x001B186C File Offset: 0x001AFA6C
		private RequestSystemFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RequestSystemFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RequestSystemFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RequestSystemFunction_SetValue());
			}
			return result;
		}

		// Token: 0x0600BBE3 RID: 48099 RVA: 0x001B18A4 File Offset: 0x001AFAA4
		public static RequestSystemFunction Create([Nullable(2)] RequestSystemFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RequestSystemFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BBE4 RID: 48100 RVA: 0x001B18B7 File Offset: 0x001AFAB7
		public static RequestSystemFunction CreateFromSetValue([Nullable(2)] RequestSystemFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RequestSystemFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BBE5 RID: 48101 RVA: 0x001B18CA File Offset: 0x001AFACA
		public RequestSystemFunction_SetValue ToSetValue()
		{
			return new RequestSystemFunction_SetValue
			{
				SystemFunction = this.SystemFunction
			};
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0600BBE6 RID: 48102 RVA: 0x001B18E0 File Offset: 0x001AFAE0
		// (set) Token: 0x0600BBE7 RID: 48103 RVA: 0x001B1941 File Offset: 0x001AFB41
		public virtual IBuyGoods SystemFunction
		{
			get
			{
				if (this._SystemFunctionInited)
				{
					return this._SystemFunctionCache;
				}
				this._SystemFunctionInited = true;
				if (this.FbInstance != null)
				{
					this._SystemFunctionCache = IBuyGoods.Create(this.FbInstance.SystemFunction);
				}
				else
				{
					RequestSystemFunction_SetValue pocoInterface = this.PocoInterface;
					this._SystemFunctionCache = ((pocoInterface != null) ? pocoInterface.SystemFunction : null);
				}
				return this._SystemFunctionCache;
			}
			set
			{
				this.GetOrCreatePoco().SystemFunction = value;
				this._SystemFunctionInited = false;
			}
		}

		// Token: 0x04007047 RID: 28743
		[Nullable(2)]
		protected new RequestSystemFunction FbInstance;

		// Token: 0x04007048 RID: 28744
		[Nullable(2)]
		protected RequestSystemFunction_SetValue PocoInterface;

		// Token: 0x04007049 RID: 28745
		private IBuyGoods _SystemFunctionCache;

		// Token: 0x0400704A RID: 28746
		private bool _SystemFunctionInited;
	}
}
