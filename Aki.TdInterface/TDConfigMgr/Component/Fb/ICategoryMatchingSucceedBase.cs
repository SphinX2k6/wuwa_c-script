using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C28 RID: 3112
	[NullableContext(2)]
	[Nullable(0)]
	public class ICategoryMatchingSucceedBase
	{
		// Token: 0x06004741 RID: 18241 RVA: 0x000B4B8E File Offset: 0x000B2D8E
		[NullableContext(0)]
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

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x000B4BB0 File Offset: 0x000B2DB0
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

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x000B4BE8 File Offset: 0x000B2DE8
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

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x000B4C20 File Offset: 0x000B2E20
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

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06004745 RID: 18245 RVA: 0x000B4C56 File Offset: 0x000B2E56
		public virtual string ChangeSelfState
		{
			get
			{
				return this.Instance.ChangeSelfState;
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x000B4C63 File Offset: 0x000B2E63
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

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06004747 RID: 18247 RVA: 0x000B4C98 File Offset: 0x000B2E98
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

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06004748 RID: 18248 RVA: 0x000B4CCE File Offset: 0x000B2ECE
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

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06004749 RID: 18249 RVA: 0x000B4D02 File Offset: 0x000B2F02
		public virtual string ChangeSelfStateAfterDischarged
		{
			get
			{
				return this.Instance.ChangeSelfStateAfterDischarged;
			}
		}

		// Token: 0x04002803 RID: 10243
		private ICategoryMatchingSucceedBase Instance;

		// Token: 0x04002804 RID: 10244
		private IEntityState _ChangeItemStateCache;

		// Token: 0x04002805 RID: 10245
		private bool _ChangeItemStateInited;

		// Token: 0x04002806 RID: 10246
		private IEntityState _ChangeItemStateAfterDischargedCache;

		// Token: 0x04002807 RID: 10247
		private bool _ChangeItemStateAfterDischargedInited;
	}
}
