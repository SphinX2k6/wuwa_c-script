using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DD6 RID: 11734
	public class ExecBpActorFunc : ActionParams
	{
		// Token: 0x0600FF5D RID: 65373 RVA: 0x0024CC74 File Offset: 0x0024AE74
		public static ExecBpActorFunc Create(IExecBpActorFunc? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExecBpActorFunc
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700505F RID: 20575
		// (get) Token: 0x0600FF5E RID: 65374 RVA: 0x0024CC93 File Offset: 0x0024AE93
		public virtual IBpActorFuncTypeBase ExecFuncType
		{
			get
			{
				if (this._ExecFuncTypeInited)
				{
					return this._ExecFuncTypeCache;
				}
				this._ExecFuncTypeInited = true;
				this._ExecFuncTypeCache = ActionReadHelper.ReadExecBpActorFunc_ExecFuncType(this.Instance);
				return this._ExecFuncTypeCache;
			}
		}

		// Token: 0x04008B6A RID: 35690
		private IExecBpActorFunc Instance;

		// Token: 0x04008B6B RID: 35691
		private IBpActorFuncTypeBase _ExecFuncTypeCache;

		// Token: 0x04008B6C RID: 35692
		private bool _ExecFuncTypeInited;
	}
}
