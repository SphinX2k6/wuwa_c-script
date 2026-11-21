using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C29 RID: 3113
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceed : ICategoryMatchingSucceedBase
	{
		// Token: 0x0600474B RID: 18251 RVA: 0x000B4D17 File Offset: 0x000B2F17
		[NullableContext(0)]
		public static ICategoryMatchingSucceed Create(ICategoryMatchingSucceed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingSucceed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600474C RID: 18252 RVA: 0x000B4D38 File Offset: 0x000B2F38
		public override bool? IsSilent
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsSilent);
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x0600474D RID: 18253 RVA: 0x000B4D70 File Offset: 0x000B2F70
		public override bool? IsDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDestroy);
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x0600474E RID: 18254 RVA: 0x000B4DA8 File Offset: 0x000B2FA8
		public override bool? SyncAdsorbatePerformance
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.SyncAdsorbatePerformance);
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x0600474F RID: 18255 RVA: 0x000B4DDE File Offset: 0x000B2FDE
		public override string ChangeSelfState
		{
			get
			{
				return this.Instance.ChangeSelfState;
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06004750 RID: 18256 RVA: 0x000B4DEB File Offset: 0x000B2FEB
		public override IEntityState ChangeItemState
		{
			get
			{
				if (this._ChangeItemStateInited)
				{
					return this._ChangeItemStateCache;
				}
				this._ChangeItemStateInited = true;
				this._ChangeItemStateCache = IEntityState.Create(this.Instance.ChangeItemState);
				return this._ChangeItemStateCache;
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06004751 RID: 18257 RVA: 0x000B4E20 File Offset: 0x000B3020
		public override int? DelayDischarge
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.DelayDischarge);
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x000B4E56 File Offset: 0x000B3056
		public override IEntityState ChangeItemStateAfterDischarged
		{
			get
			{
				if (this._ChangeItemStateAfterDischargedInited)
				{
					return this._ChangeItemStateAfterDischargedCache;
				}
				this._ChangeItemStateAfterDischargedInited = true;
				this._ChangeItemStateAfterDischargedCache = IEntityState.Create(this.Instance.ChangeItemStateAfterDischarged);
				return this._ChangeItemStateAfterDischargedCache;
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x000B4E8A File Offset: 0x000B308A
		public override string ChangeSelfStateAfterDischarged
		{
			get
			{
				return this.Instance.ChangeSelfStateAfterDischarged;
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x000B4E97 File Offset: 0x000B3097
		public virtual IItemChangeAdsorbateState ChangeAdsorbateState
		{
			get
			{
				if (this._ChangeAdsorbateStateInited)
				{
					return this._ChangeAdsorbateStateCache;
				}
				this._ChangeAdsorbateStateInited = true;
				this._ChangeAdsorbateStateCache = IItemChangeAdsorbateState.Create(this.Instance.ChangeAdsorbateState);
				return this._ChangeAdsorbateStateCache;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06004755 RID: 18261 RVA: 0x000B4ECB File Offset: 0x000B30CB
		public virtual string DischargeSequence
		{
			get
			{
				return this.Instance.DischargeSequence;
			}
		}

		// Token: 0x04002808 RID: 10248
		private ICategoryMatchingSucceed Instance;

		// Token: 0x04002809 RID: 10249
		private IEntityState _ChangeItemStateCache;

		// Token: 0x0400280A RID: 10250
		private bool _ChangeItemStateInited;

		// Token: 0x0400280B RID: 10251
		private IEntityState _ChangeItemStateAfterDischargedCache;

		// Token: 0x0400280C RID: 10252
		private bool _ChangeItemStateAfterDischargedInited;

		// Token: 0x0400280D RID: 10253
		private IItemChangeAdsorbateState _ChangeAdsorbateStateCache;

		// Token: 0x0400280E RID: 10254
		private bool _ChangeAdsorbateStateInited;
	}
}
