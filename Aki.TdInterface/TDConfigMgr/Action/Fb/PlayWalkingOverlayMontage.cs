using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A98 RID: 10904
	public class PlayWalkingOverlayMontage : ActionParams
	{
		// Token: 0x0600EF80 RID: 61312 RVA: 0x0022D0E0 File Offset: 0x0022B2E0
		[NullableContext(1)]
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

		// Token: 0x17004C12 RID: 19474
		// (get) Token: 0x0600EF81 RID: 61313 RVA: 0x0022D0FF File Offset: 0x0022B2FF
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004C13 RID: 19475
		// (get) Token: 0x0600EF82 RID: 61314 RVA: 0x0022D10C File Offset: 0x0022B30C
		public virtual int OverlapMontageId
		{
			get
			{
				return this.Instance.OverlapMontageId;
			}
		}

		// Token: 0x17004C14 RID: 19476
		// (get) Token: 0x0600EF83 RID: 61315 RVA: 0x0022D11C File Offset: 0x0022B31C
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

		// Token: 0x17004C15 RID: 19477
		// (get) Token: 0x0600EF84 RID: 61316 RVA: 0x0022D154 File Offset: 0x0022B354
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

		// Token: 0x040083C2 RID: 33730
		private IPlayWalkingOverlayMontage Instance;
	}
}
