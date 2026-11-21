using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D3A RID: 11578
	public class RequestSystemFunction : ActionParams
	{
		// Token: 0x0600FCEF RID: 64751 RVA: 0x00248D3D File Offset: 0x00246F3D
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

		// Token: 0x17004F29 RID: 20265
		// (get) Token: 0x0600FCF0 RID: 64752 RVA: 0x00248D5C File Offset: 0x00246F5C
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

		// Token: 0x04008A1A RID: 35354
		private IRequestSystemFunction Instance;

		// Token: 0x04008A1B RID: 35355
		[Nullable(2)]
		private IBuyGoods _SystemFunctionCache;

		// Token: 0x04008A1C RID: 35356
		private bool _SystemFunctionInited;
	}
}
