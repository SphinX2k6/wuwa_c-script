using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002723 RID: 10019
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcFollowConfig
	{
		// Token: 0x0600DF6D RID: 57197 RVA: 0x00211BA9 File Offset: 0x0020FDA9
		public static INpcFollowConfig Create(INpcFollowConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcFollowConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042E9 RID: 17129
		// (get) Token: 0x0600DF6E RID: 57198 RVA: 0x00211BC8 File Offset: 0x0020FDC8
		public virtual IPerformerRangeBoundaryActionTrigger PerformerWhenEnter
		{
			get
			{
				if (this._PerformerWhenEnterInited)
				{
					return this._PerformerWhenEnterCache;
				}
				this._PerformerWhenEnterInited = true;
				this._PerformerWhenEnterCache = IPerformerRangeBoundaryActionTrigger.Create(this.Instance.PerformerWhenEnter);
				return this._PerformerWhenEnterCache;
			}
		}

		// Token: 0x170042EA RID: 17130
		// (get) Token: 0x0600DF6F RID: 57199 RVA: 0x00211BFC File Offset: 0x0020FDFC
		public virtual IPerformerRangeBoundaryActionTrigger PerformerWhenExit
		{
			get
			{
				if (this._PerformerWhenExitInited)
				{
					return this._PerformerWhenExitCache;
				}
				this._PerformerWhenExitInited = true;
				this._PerformerWhenExitCache = IPerformerRangeBoundaryActionTrigger.Create(this.Instance.PerformerWhenExit);
				return this._PerformerWhenExitCache;
			}
		}

		// Token: 0x04007BFD RID: 31741
		private INpcFollowConfig Instance;

		// Token: 0x04007BFE RID: 31742
		[Nullable(2)]
		private IPerformerRangeBoundaryActionTrigger _PerformerWhenEnterCache;

		// Token: 0x04007BFF RID: 31743
		private bool _PerformerWhenEnterInited;

		// Token: 0x04007C00 RID: 31744
		[Nullable(2)]
		private IPerformerRangeBoundaryActionTrigger _PerformerWhenExitCache;

		// Token: 0x04007C01 RID: 31745
		private bool _PerformerWhenExitInited;
	}
}
