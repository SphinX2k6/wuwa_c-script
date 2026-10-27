using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002921 RID: 10529
	public class PlayRegisteredMontage : ActionParams
	{
		// Token: 0x0600E9AA RID: 59818 RVA: 0x00223EDC File Offset: 0x002220DC
		[NullableContext(1)]
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

		// Token: 0x1700492A RID: 18730
		// (get) Token: 0x0600E9AB RID: 59819 RVA: 0x00223EFB File Offset: 0x002220FB
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700492B RID: 18731
		// (get) Token: 0x0600E9AC RID: 59820 RVA: 0x00223F08 File Offset: 0x00222108
		public virtual int MontageId
		{
			get
			{
				return this.Instance.MontageId;
			}
		}

		// Token: 0x1700492C RID: 18732
		// (get) Token: 0x0600E9AD RID: 59821 RVA: 0x00223F18 File Offset: 0x00222118
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

		// Token: 0x1700492D RID: 18733
		// (get) Token: 0x0600E9AE RID: 59822 RVA: 0x00223F50 File Offset: 0x00222150
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

		// Token: 0x1700492E RID: 18734
		// (get) Token: 0x0600E9AF RID: 59823 RVA: 0x00223F88 File Offset: 0x00222188
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

		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x0600E9B0 RID: 59824 RVA: 0x00223FC0 File Offset: 0x002221C0
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

		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x0600E9B1 RID: 59825 RVA: 0x00223FF8 File Offset: 0x002221F8
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

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x0600E9B2 RID: 59826 RVA: 0x00224030 File Offset: 0x00222230
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

		// Token: 0x17004932 RID: 18738
		// (get) Token: 0x0600E9B3 RID: 59827 RVA: 0x00224068 File Offset: 0x00222268
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

		// Token: 0x040080F1 RID: 33009
		private IPlayRegisteredMontage Instance;
	}
}
