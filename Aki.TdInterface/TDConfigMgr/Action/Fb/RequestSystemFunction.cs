using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A4D RID: 10829
	[NullableContext(1)]
	[Nullable(0)]
	public class RequestSystemFunction : ActionParams
	{
		// Token: 0x0600EE57 RID: 61015 RVA: 0x0022B389 File Offset: 0x00229589
		public static RequestSystemFunction Create(IRequestSystemFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RequestSystemFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B7F RID: 19327
		// (get) Token: 0x0600EE58 RID: 61016 RVA: 0x0022B3A8 File Offset: 0x002295A8
		public virtual IBuyGoods SystemFunction
		{
			get
			{
				if (this._SystemFunctionInited)
				{
					return this._SystemFunctionCache;
				}
				this._SystemFunctionInited = true;
				this._SystemFunctionCache = IBuyGoods.Create(this.Instance.SystemFunction);
				return this._SystemFunctionCache;
			}
		}

		// Token: 0x04008327 RID: 33575
		private IRequestSystemFunction Instance;

		// Token: 0x04008328 RID: 33576
		[Nullable(2)]
		private IBuyGoods _SystemFunctionCache;

		// Token: 0x04008329 RID: 33577
		private bool _SystemFunctionInited;
	}
}
