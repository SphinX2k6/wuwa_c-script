using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002E2D RID: 11821
	public class LiveSetSc : ActionParams
	{
		// Token: 0x060100A8 RID: 65704 RVA: 0x0024E93D File Offset: 0x0024CB3D
		public static LiveSetSc Create(ILiveSetSc? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LiveSetSc
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050FC RID: 20732
		// (get) Token: 0x060100A9 RID: 65705 RVA: 0x0024E95C File Offset: 0x0024CB5C
		public virtual ILiveScOperation Operation
		{
			get
			{
				if (this._OperationInited)
				{
					return this._OperationCache;
				}
				this._OperationInited = true;
				this._OperationCache = ActionReadHelper.ReadLiveSetSc_Operation(this.Instance);
				return this._OperationCache;
			}
		}

		// Token: 0x04008BFF RID: 35839
		private ILiveSetSc Instance;

		// Token: 0x04008C00 RID: 35840
		private ILiveScOperation _OperationCache;

		// Token: 0x04008C01 RID: 35841
		private bool _OperationInited;
	}
}
