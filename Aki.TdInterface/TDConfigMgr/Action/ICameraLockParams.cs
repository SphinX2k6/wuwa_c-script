using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001842 RID: 6210
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraLockParams
	{
		// Token: 0x06008547 RID: 34119 RVA: 0x0013D0EC File Offset: 0x0013B2EC
		private ICameraLockParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraLockParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraLockParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraLockParams_SetValue());
			}
			return result;
		}

		// Token: 0x06008548 RID: 34120 RVA: 0x0013D124 File Offset: 0x0013B324
		public static ICameraLockParams Create([Nullable(2)] ICameraLockParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraLockParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008549 RID: 34121 RVA: 0x0013D137 File Offset: 0x0013B337
		public static ICameraLockParams CreateFromSetValue([Nullable(2)] ICameraLockParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraLockParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600854A RID: 34122 RVA: 0x0013D14C File Offset: 0x0013B34C
		public ICameraLockParams_SetValue ToSetValue()
		{
			return new ICameraLockParams_SetValue
			{
				RelativeYawHardMin = this.RelativeYawHardMin,
				RelativeYawHardMax = this.RelativeYawHardMax,
				RelativePitchHardMin = this.RelativePitchHardMin,
				RelativePitchHardMax = this.RelativePitchHardMax,
				YawSignAdaptionLockDirection = this.YawSignAdaptionLockDirection,
				RelativeRotationLagYawSpeedMin = this.RelativeRotationLagYawSpeedMin,
				RelativeRotationLagYawSpeedMax = this.RelativeRotationLagYawSpeedMax,
				RelativeRotationLagYawAngleRange = this.RelativeRotationLagYawAngleRange,
				RelativeRotationLagPitchSpeedMin = this.RelativeRotationLagPitchSpeedMin,
				RelativeRotationLagPitchSpeedMax = this.RelativeRotationLagPitchSpeedMax,
				RelativeRotationLagPitchAngleRange = this.RelativeRotationLagPitchAngleRange,
				RelativeRotationLagRatioMin = this.RelativeRotationLagRatioMin,
				RelativeRotationLagRatioMax = this.RelativeRotationLagRatioMax,
				RelativeRotationLagDistanceRangeMin = this.RelativeRotationLagDistanceRangeMin,
				RelativeRotationLagDistanceRangeMax = this.RelativeRotationLagDistanceRangeMax
			};
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x0013D212 File Offset: 0x0013B412
		// (set) Token: 0x0600854C RID: 34124 RVA: 0x0013D241 File Offset: 0x0013B441
		public virtual float RelativeYawHardMin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeYawHardMin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeYawHardMin;
			}
			set
			{
				this.GetOrCreatePoco().RelativeYawHardMin = value;
			}
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x0600854D RID: 34125 RVA: 0x0013D24F File Offset: 0x0013B44F
		// (set) Token: 0x0600854E RID: 34126 RVA: 0x0013D27E File Offset: 0x0013B47E
		public virtual float RelativeYawHardMax
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeYawHardMax;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeYawHardMax;
			}
			set
			{
				this.GetOrCreatePoco().RelativeYawHardMax = value;
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x0600854F RID: 34127 RVA: 0x0013D28C File Offset: 0x0013B48C
		// (set) Token: 0x06008550 RID: 34128 RVA: 0x0013D2BB File Offset: 0x0013B4BB
		public virtual float RelativePitchHardMin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativePitchHardMin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativePitchHardMin;
			}
			set
			{
				this.GetOrCreatePoco().RelativePitchHardMin = value;
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x0013D2C9 File Offset: 0x0013B4C9
		// (set) Token: 0x06008552 RID: 34130 RVA: 0x0013D2F8 File Offset: 0x0013B4F8
		public virtual float RelativePitchHardMax
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativePitchHardMax;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativePitchHardMax;
			}
			set
			{
				this.GetOrCreatePoco().RelativePitchHardMax = value;
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x06008553 RID: 34131 RVA: 0x0013D306 File Offset: 0x0013B506
		// (set) Token: 0x06008554 RID: 34132 RVA: 0x0013D335 File Offset: 0x0013B535
		public virtual float YawSignAdaptionLockDirection
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.YawSignAdaptionLockDirection;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.YawSignAdaptionLockDirection;
			}
			set
			{
				this.GetOrCreatePoco().YawSignAdaptionLockDirection = value;
			}
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x06008555 RID: 34133 RVA: 0x0013D343 File Offset: 0x0013B543
		// (set) Token: 0x06008556 RID: 34134 RVA: 0x0013D372 File Offset: 0x0013B572
		public virtual float RelativeRotationLagYawSpeedMin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagYawSpeedMin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagYawSpeedMin;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagYawSpeedMin = value;
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x06008557 RID: 34135 RVA: 0x0013D380 File Offset: 0x0013B580
		// (set) Token: 0x06008558 RID: 34136 RVA: 0x0013D3AF File Offset: 0x0013B5AF
		public virtual float RelativeRotationLagYawSpeedMax
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagYawSpeedMax;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagYawSpeedMax;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagYawSpeedMax = value;
			}
		}

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x06008559 RID: 34137 RVA: 0x0013D3BD File Offset: 0x0013B5BD
		// (set) Token: 0x0600855A RID: 34138 RVA: 0x0013D3EC File Offset: 0x0013B5EC
		public virtual float RelativeRotationLagYawAngleRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagYawAngleRange;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagYawAngleRange;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagYawAngleRange = value;
			}
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x0600855B RID: 34139 RVA: 0x0013D3FA File Offset: 0x0013B5FA
		// (set) Token: 0x0600855C RID: 34140 RVA: 0x0013D429 File Offset: 0x0013B629
		public virtual float RelativeRotationLagPitchSpeedMin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagPitchSpeedMin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagPitchSpeedMin;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagPitchSpeedMin = value;
			}
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x0600855D RID: 34141 RVA: 0x0013D437 File Offset: 0x0013B637
		// (set) Token: 0x0600855E RID: 34142 RVA: 0x0013D466 File Offset: 0x0013B666
		public virtual float RelativeRotationLagPitchSpeedMax
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagPitchSpeedMax;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagPitchSpeedMax;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagPitchSpeedMax = value;
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x0600855F RID: 34143 RVA: 0x0013D474 File Offset: 0x0013B674
		// (set) Token: 0x06008560 RID: 34144 RVA: 0x0013D4A3 File Offset: 0x0013B6A3
		public virtual float RelativeRotationLagPitchAngleRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagPitchAngleRange;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagPitchAngleRange;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagPitchAngleRange = value;
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x06008561 RID: 34145 RVA: 0x0013D4B1 File Offset: 0x0013B6B1
		// (set) Token: 0x06008562 RID: 34146 RVA: 0x0013D4E0 File Offset: 0x0013B6E0
		public virtual float RelativeRotationLagRatioMin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagRatioMin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagRatioMin;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagRatioMin = value;
			}
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x06008563 RID: 34147 RVA: 0x0013D4EE File Offset: 0x0013B6EE
		// (set) Token: 0x06008564 RID: 34148 RVA: 0x0013D51D File Offset: 0x0013B71D
		public virtual float RelativeRotationLagRatioMax
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagRatioMax;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagRatioMax;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagRatioMax = value;
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x06008565 RID: 34149 RVA: 0x0013D52B File Offset: 0x0013B72B
		// (set) Token: 0x06008566 RID: 34150 RVA: 0x0013D55A File Offset: 0x0013B75A
		public virtual float RelativeRotationLagDistanceRangeMin
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagDistanceRangeMin;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagDistanceRangeMin;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagDistanceRangeMin = value;
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x06008567 RID: 34151 RVA: 0x0013D568 File Offset: 0x0013B768
		// (set) Token: 0x06008568 RID: 34152 RVA: 0x0013D597 File Offset: 0x0013B797
		public virtual float RelativeRotationLagDistanceRangeMax
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RelativeRotationLagDistanceRangeMax;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.RelativeRotationLagDistanceRangeMax;
			}
			set
			{
				this.GetOrCreatePoco().RelativeRotationLagDistanceRangeMax = value;
			}
		}

		// Token: 0x04005436 RID: 21558
		[Nullable(2)]
		protected ICameraLockParams FbInstance;

		// Token: 0x04005437 RID: 21559
		[Nullable(2)]
		protected ICameraLockParams_SetValue PocoInterface;
	}
}
