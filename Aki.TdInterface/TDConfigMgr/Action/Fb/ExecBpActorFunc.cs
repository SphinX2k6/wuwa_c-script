using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AE2 RID: 10978
	[NullableContext(1)]
	[Nullable(0)]
	public class ExecBpActorFunc : ActionParams
	{
		// Token: 0x0600F0A7 RID: 61607 RVA: 0x0022EF68 File Offset: 0x0022D168
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

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x0600F0A8 RID: 61608 RVA: 0x0022EF87 File Offset: 0x0022D187
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

		// Token: 0x04008466 RID: 33894
		private IExecBpActorFunc Instance;

		// Token: 0x04008467 RID: 33895
		private IBpActorFuncTypeBase _ExecFuncTypeCache;

		// Token: 0x04008468 RID: 33896
		private bool _ExecFuncTypeInited;
	}
}
