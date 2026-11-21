using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BFD RID: 11261
	public class PlayRegisteredMontage : ActionParams
	{
		// Token: 0x0600F7FC RID: 63484 RVA: 0x00241234 File Offset: 0x0023F434
		public static PlayRegisteredMontage Create(IPlayRegisteredMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayRegisteredMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CB0 RID: 19632
		// (get) Token: 0x0600F7FD RID: 63485 RVA: 0x00241253 File Offset: 0x0023F453
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004CB1 RID: 19633
		// (get) Token: 0x0600F7FE RID: 63486 RVA: 0x00241260 File Offset: 0x0023F460
		public virtual int MontageId
		{
			get
			{
				return this.Instance.MontageId;
			}
		}

		// Token: 0x17004CB2 RID: 19634
		// (get) Token: 0x0600F7FF RID: 63487 RVA: 0x00241270 File Offset: 0x0023F470
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

		// Token: 0x17004CB3 RID: 19635
		// (get) Token: 0x0600F800 RID: 63488 RVA: 0x002412A8 File Offset: 0x0023F4A8
		public virtual bool? IsAbpMontage
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsAbpMontage);
			}
		}

		// Token: 0x17004CB4 RID: 19636
		// (get) Token: 0x0600F801 RID: 63489 RVA: 0x002412E0 File Offset: 0x0023F4E0
		public virtual int? FaceExpressionId
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FaceExpressionId);
			}
		}

		// Token: 0x17004CB5 RID: 19637
		// (get) Token: 0x0600F802 RID: 63490 RVA: 0x00241318 File Offset: 0x0023F518
		public virtual float? LoopDuration
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LoopDuration);
			}
		}

		// Token: 0x17004CB6 RID: 19638
		// (get) Token: 0x0600F803 RID: 63491 RVA: 0x00241350 File Offset: 0x0023F550
		public virtual int? RepeatTimes
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new int?(this.Instance.RepeatTimes);
			}
		}

		// Token: 0x17004CB7 RID: 19639
		// (get) Token: 0x0600F804 RID: 63492 RVA: 0x00241388 File Offset: 0x0023F588
		public virtual bool? KeepMontageWhenEnd
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepMontageWhenEnd);
			}
		}

		// Token: 0x17004CB8 RID: 19640
		// (get) Token: 0x0600F805 RID: 63493 RVA: 0x002413C0 File Offset: 0x0023F5C0
		public virtual bool? KeepMontageAfterFlow
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepMontageAfterFlow);
			}
		}

		// Token: 0x040087BF RID: 34751
		private IPlayRegisteredMontage Instance;
	}
}
