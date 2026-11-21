using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023BB RID: 9147
	public class RequestSystemFunction : ActionParams
	{
		// Token: 0x0600C770 RID: 51056 RVA: 0x001C8A20 File Offset: 0x001C6C20
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

		// Token: 0x0600C771 RID: 51057 RVA: 0x001C8A58 File Offset: 0x001C6C58
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

		// Token: 0x0600C772 RID: 51058 RVA: 0x001C8A6B File Offset: 0x001C6C6B
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

		// Token: 0x0600C773 RID: 51059 RVA: 0x001C8A7E File Offset: 0x001C6C7E
		public RequestSystemFunction_SetValue ToSetValue()
		{
			return new RequestSystemFunction_SetValue
			{
				SystemFunction = this.SystemFunction
			};
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x0600C774 RID: 51060 RVA: 0x001C8A94 File Offset: 0x001C6C94
		// (set) Token: 0x0600C775 RID: 51061 RVA: 0x001C8AF5 File Offset: 0x001C6CF5
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

		// Token: 0x0400767C RID: 30332
		[Nullable(2)]
		protected new RequestSystemFunction FbInstance;

		// Token: 0x0400767D RID: 30333
		[Nullable(2)]
		protected RequestSystemFunction_SetValue PocoInterface;

		// Token: 0x0400767E RID: 30334
		private IBuyGoods _SystemFunctionCache;

		// Token: 0x0400767F RID: 30335
		private bool _SystemFunctionInited;
	}
}
