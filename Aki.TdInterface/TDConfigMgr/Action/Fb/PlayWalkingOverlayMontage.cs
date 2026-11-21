using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D8C RID: 11660
	public class PlayWalkingOverlayMontage : ActionParams
	{
		// Token: 0x0600FE36 RID: 65078 RVA: 0x0024ADEC File Offset: 0x00248FEC
		public static PlayWalkingOverlayMontage Create(IPlayWalkingOverlayMontage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayWalkingOverlayMontage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x0600FE37 RID: 65079 RVA: 0x0024AE0B File Offset: 0x0024900B
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004FCD RID: 20429
		// (get) Token: 0x0600FE38 RID: 65080 RVA: 0x0024AE18 File Offset: 0x00249018
		public virtual int OverlapMontageId
		{
			get
			{
				return this.Instance.OverlapMontageId;
			}
		}

		// Token: 0x17004FCE RID: 20430
		// (get) Token: 0x0600FE39 RID: 65081 RVA: 0x0024AE28 File Offset: 0x00249028
		public virtual float? LoopDuration
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.LoopDuration);
			}
		}

		// Token: 0x17004FCF RID: 20431
		// (get) Token: 0x0600FE3A RID: 65082 RVA: 0x0024AE60 File Offset: 0x00249060
		public virtual int? RepeatTimes
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.RepeatTimes);
			}
		}

		// Token: 0x04008AC6 RID: 35526
		private IPlayWalkingOverlayMontage Instance;
	}
}
