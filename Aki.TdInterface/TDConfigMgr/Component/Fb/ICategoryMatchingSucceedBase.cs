using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B5A RID: 2906
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceedBase
	{
		// Token: 0x060042E8 RID: 17128 RVA: 0x000AAACA File Offset: 0x000A8CCA
		[NullableContext(1)]
		public static ICategoryMatchingSucceedBase Create(ICategoryMatchingSucceedBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICategoryMatchingSucceedBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060042E9 RID: 17129 RVA: 0x000AAAEC File Offset: 0x000A8CEC
		public virtual bool? IsSilent
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

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x000AAB24 File Offset: 0x000A8D24
		public virtual bool? IsDestroy
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

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x060042EB RID: 17131 RVA: 0x000AAB5C File Offset: 0x000A8D5C
		public virtual bool? SyncAdsorbatePerformance
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x000AAB92 File Offset: 0x000A8D92
		public virtual string ChangeSelfState
		{
			get
			{
				return this.Instance.ChangeSelfState;
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x060042ED RID: 17133 RVA: 0x000AAB9F File Offset: 0x000A8D9F
		public virtual IEntityState ChangeItemState
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

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x000AABD4 File Offset: 0x000A8DD4
		public virtual int? DelayDischarge
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

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x060042EF RID: 17135 RVA: 0x000AAC0A File Offset: 0x000A8E0A
		public virtual IEntityState ChangeItemStateAfterDischarged
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

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x000AAC3E File Offset: 0x000A8E3E
		public virtual string ChangeSelfStateAfterDischarged
		{
			get
			{
				return this.Instance.ChangeSelfStateAfterDischarged;
			}
		}

		// Token: 0x040025BB RID: 9659
		private ICategoryMatchingSucceedBase Instance;

		// Token: 0x040025BC RID: 9660
		private IEntityState _ChangeItemStateCache;

		// Token: 0x040025BD RID: 9661
		private bool _ChangeItemStateInited;

		// Token: 0x040025BE RID: 9662
		private IEntityState _ChangeItemStateAfterDischargedCache;

		// Token: 0x040025BF RID: 9663
		private bool _ChangeItemStateAfterDischargedInited;
	}
}
