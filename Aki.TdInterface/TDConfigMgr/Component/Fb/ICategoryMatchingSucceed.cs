using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5B RID: 2907
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceed : ICategoryMatchingSucceedBase
	{
		// Token: 0x060042F2 RID: 17138 RVA: 0x000AAC53 File Offset: 0x000A8E53
		[NullableContext(1)]
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

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x000AAC74 File Offset: 0x000A8E74
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

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x000AACAC File Offset: 0x000A8EAC
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

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x060042F5 RID: 17141 RVA: 0x000AACE4 File Offset: 0x000A8EE4
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

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x000AAD1A File Offset: 0x000A8F1A
		public override string ChangeSelfState
		{
			get
			{
				return this.Instance.ChangeSelfState;
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x060042F7 RID: 17143 RVA: 0x000AAD27 File Offset: 0x000A8F27
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

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x000AAD5C File Offset: 0x000A8F5C
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

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x060042F9 RID: 17145 RVA: 0x000AAD92 File Offset: 0x000A8F92
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

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x000AADC6 File Offset: 0x000A8FC6
		public override string ChangeSelfStateAfterDischarged
		{
			get
			{
				return this.Instance.ChangeSelfStateAfterDischarged;
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x000AADD3 File Offset: 0x000A8FD3
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

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x000AAE07 File Offset: 0x000A9007
		public virtual string DischargeSequence
		{
			get
			{
				return this.Instance.DischargeSequence;
			}
		}

		// Token: 0x040025C0 RID: 9664
		private ICategoryMatchingSucceed Instance;

		// Token: 0x040025C1 RID: 9665
		private IEntityState _ChangeItemStateCache;

		// Token: 0x040025C2 RID: 9666
		private bool _ChangeItemStateInited;

		// Token: 0x040025C3 RID: 9667
		private IEntityState _ChangeItemStateAfterDischargedCache;

		// Token: 0x040025C4 RID: 9668
		private bool _ChangeItemStateAfterDischargedInited;

		// Token: 0x040025C5 RID: 9669
		private IItemChangeAdsorbateState _ChangeAdsorbateStateCache;

		// Token: 0x040025C6 RID: 9670
		private bool _ChangeAdsorbateStateInited;
	}
}
