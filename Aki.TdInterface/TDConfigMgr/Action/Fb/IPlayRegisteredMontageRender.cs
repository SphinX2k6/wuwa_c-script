using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002922 RID: 10530
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayRegisteredMontageRender
	{
		// Token: 0x0600E9B5 RID: 59829 RVA: 0x002240A7 File Offset: 0x002222A7
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

		// Token: 0x17004933 RID: 18739
		// (get) Token: 0x0600E9B6 RID: 59830 RVA: 0x002240C6 File Offset: 0x002222C6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004934 RID: 18740
		// (get) Token: 0x0600E9B7 RID: 59831 RVA: 0x002240D4 File Offset: 0x002222D4
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

		// Token: 0x17004935 RID: 18741
		// (get) Token: 0x0600E9B8 RID: 59832 RVA: 0x0022410A File Offset: 0x0022230A
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

		// Token: 0x17004936 RID: 18742
		// (get) Token: 0x0600E9B9 RID: 59833 RVA: 0x00224140 File Offset: 0x00222340
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

		// Token: 0x17004937 RID: 18743
		// (get) Token: 0x0600E9BA RID: 59834 RVA: 0x00224178 File Offset: 0x00222378
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

		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x0600E9BB RID: 59835 RVA: 0x002241B0 File Offset: 0x002223B0
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

		// Token: 0x17004939 RID: 18745
		// (get) Token: 0x0600E9BC RID: 59836 RVA: 0x002241E8 File Offset: 0x002223E8
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

		// Token: 0x1700493A RID: 18746
		// (get) Token: 0x0600E9BD RID: 59837 RVA: 0x00224220 File Offset: 0x00222420
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

		// Token: 0x040080F2 RID: 33010
		private IPlayRegisteredMontageRender Instance;

		// Token: 0x040080F3 RID: 33011
		[Nullable(2)]
		private IMontageId _MontageIdCache;

		// Token: 0x040080F4 RID: 33012
		private bool _MontageIdInited;
	}
}
