using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028A9 RID: 10409
	public class ICameraLockParams
	{
		// Token: 0x0600E679 RID: 59001 RVA: 0x0021DC60 File Offset: 0x0021BE60
		[NullableContext(1)]
		public static ICameraLockParams Create(ICameraLockParams? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraLockParams
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046E9 RID: 18153
		// (get) Token: 0x0600E67A RID: 59002 RVA: 0x0021DC7F File Offset: 0x0021BE7F
		public virtual float RelativeYawHardMin
		{
			get
			{
				return this.Instance.RelativeYawHardMin;
			}
		}

		// Token: 0x170046EA RID: 18154
		// (get) Token: 0x0600E67B RID: 59003 RVA: 0x0021DC8C File Offset: 0x0021BE8C
		public virtual float RelativeYawHardMax
		{
			get
			{
				return this.Instance.RelativeYawHardMax;
			}
		}

		// Token: 0x170046EB RID: 18155
		// (get) Token: 0x0600E67C RID: 59004 RVA: 0x0021DC99 File Offset: 0x0021BE99
		public virtual float RelativePitchHardMin
		{
			get
			{
				return this.Instance.RelativePitchHardMin;
			}
		}

		// Token: 0x170046EC RID: 18156
		// (get) Token: 0x0600E67D RID: 59005 RVA: 0x0021DCA6 File Offset: 0x0021BEA6
		public virtual float RelativePitchHardMax
		{
			get
			{
				return this.Instance.RelativePitchHardMax;
			}
		}

		// Token: 0x170046ED RID: 18157
		// (get) Token: 0x0600E67E RID: 59006 RVA: 0x0021DCB3 File Offset: 0x0021BEB3
		public virtual float YawSignAdaptionLockDirection
		{
			get
			{
				return this.Instance.YawSignAdaptionLockDirection;
			}
		}

		// Token: 0x170046EE RID: 18158
		// (get) Token: 0x0600E67F RID: 59007 RVA: 0x0021DCC0 File Offset: 0x0021BEC0
		public virtual float RelativeRotationLagYawSpeedMin
		{
			get
			{
				return this.Instance.RelativeRotationLagYawSpeedMin;
			}
		}

		// Token: 0x170046EF RID: 18159
		// (get) Token: 0x0600E680 RID: 59008 RVA: 0x0021DCCD File Offset: 0x0021BECD
		public virtual float RelativeRotationLagYawSpeedMax
		{
			get
			{
				return this.Instance.RelativeRotationLagYawSpeedMax;
			}
		}

		// Token: 0x170046F0 RID: 18160
		// (get) Token: 0x0600E681 RID: 59009 RVA: 0x0021DCDA File Offset: 0x0021BEDA
		public virtual float RelativeRotationLagYawAngleRange
		{
			get
			{
				return this.Instance.RelativeRotationLagYawAngleRange;
			}
		}

		// Token: 0x170046F1 RID: 18161
		// (get) Token: 0x0600E682 RID: 59010 RVA: 0x0021DCE7 File Offset: 0x0021BEE7
		public virtual float RelativeRotationLagPitchSpeedMin
		{
			get
			{
				return this.Instance.RelativeRotationLagPitchSpeedMin;
			}
		}

		// Token: 0x170046F2 RID: 18162
		// (get) Token: 0x0600E683 RID: 59011 RVA: 0x0021DCF4 File Offset: 0x0021BEF4
		public virtual float RelativeRotationLagPitchSpeedMax
		{
			get
			{
				return this.Instance.RelativeRotationLagPitchSpeedMax;
			}
		}

		// Token: 0x170046F3 RID: 18163
		// (get) Token: 0x0600E684 RID: 59012 RVA: 0x0021DD01 File Offset: 0x0021BF01
		public virtual float RelativeRotationLagPitchAngleRange
		{
			get
			{
				return this.Instance.RelativeRotationLagPitchAngleRange;
			}
		}

		// Token: 0x170046F4 RID: 18164
		// (get) Token: 0x0600E685 RID: 59013 RVA: 0x0021DD0E File Offset: 0x0021BF0E
		public virtual float RelativeRotationLagRatioMin
		{
			get
			{
				return this.Instance.RelativeRotationLagRatioMin;
			}
		}

		// Token: 0x170046F5 RID: 18165
		// (get) Token: 0x0600E686 RID: 59014 RVA: 0x0021DD1B File Offset: 0x0021BF1B
		public virtual float RelativeRotationLagRatioMax
		{
			get
			{
				return this.Instance.RelativeRotationLagRatioMax;
			}
		}

		// Token: 0x170046F6 RID: 18166
		// (get) Token: 0x0600E687 RID: 59015 RVA: 0x0021DD28 File Offset: 0x0021BF28
		public virtual float RelativeRotationLagDistanceRangeMin
		{
			get
			{
				return this.Instance.RelativeRotationLagDistanceRangeMin;
			}
		}

		// Token: 0x170046F7 RID: 18167
		// (get) Token: 0x0600E688 RID: 59016 RVA: 0x0021DD35 File Offset: 0x0021BF35
		public virtual float RelativeRotationLagDistanceRangeMax
		{
			get
			{
				return this.Instance.RelativeRotationLagDistanceRangeMax;
			}
		}

		// Token: 0x04007F6B RID: 32619
		private ICameraLockParams Instance;
	}
}
