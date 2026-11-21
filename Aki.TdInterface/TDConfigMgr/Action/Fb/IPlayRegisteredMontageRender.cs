using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BFE RID: 11262
	public class IPlayRegisteredMontageRender
	{
		// Token: 0x0600F807 RID: 63495 RVA: 0x002413FF File Offset: 0x0023F5FF
		public static IPlayRegisteredMontageRender Create(IPlayRegisteredMontageRender? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayRegisteredMontageRender
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x0600F808 RID: 63496 RVA: 0x0024141E File Offset: 0x0023F61E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x0600F809 RID: 63497 RVA: 0x0024142C File Offset: 0x0023F62C
		public virtual bool? IsOverlayMontage
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsOverlayMontage);
			}
		}

		// Token: 0x17004CBB RID: 19643
		// (get) Token: 0x0600F80A RID: 63498 RVA: 0x00241462 File Offset: 0x0023F662
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				this._MontageIdCache = IMontageId.Create(this.Instance.MontageId);
				return this._MontageIdCache;
			}
		}

		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x0600F80B RID: 63499 RVA: 0x00241498 File Offset: 0x0023F698
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x0600F80C RID: 63500 RVA: 0x002414D0 File Offset: 0x0023F6D0
		public virtual float? LoopDuration
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LoopDuration);
			}
		}

		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x0600F80D RID: 63501 RVA: 0x00241508 File Offset: 0x0023F708
		public virtual int? RepeatTimes
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new int?(this.Instance.RepeatTimes);
			}
		}

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x0600F80E RID: 63502 RVA: 0x00241540 File Offset: 0x0023F740
		public virtual bool? KeepMontageWhenEnd
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepMontageWhenEnd);
			}
		}

		// Token: 0x17004CC0 RID: 19648
		// (get) Token: 0x0600F80F RID: 63503 RVA: 0x00241578 File Offset: 0x0023F778
		public virtual bool? KeepMontageAfterFlow
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepMontageAfterFlow);
			}
		}

		// Token: 0x040087C0 RID: 34752
		private IPlayRegisteredMontageRender Instance;

		// Token: 0x040087C1 RID: 34753
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x040087C2 RID: 34754
		private bool _MontageIdInited;
	}
}
