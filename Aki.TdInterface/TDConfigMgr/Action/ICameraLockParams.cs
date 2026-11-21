using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019CD RID: 6605
	public class ICameraLockParams
	{
		// Token: 0x06008C6D RID: 35949 RVA: 0x0014C8E0 File Offset: 0x0014AAE0
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

		// Token: 0x06008C6E RID: 35950 RVA: 0x0014C918 File Offset: 0x0014AB18
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

		// Token: 0x06008C6F RID: 35951 RVA: 0x0014C92B File Offset: 0x0014AB2B
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

		// Token: 0x06008C70 RID: 35952 RVA: 0x0014C940 File Offset: 0x0014AB40
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

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x06008C71 RID: 35953 RVA: 0x0014CA06 File Offset: 0x0014AC06
		// (set) Token: 0x06008C72 RID: 35954 RVA: 0x0014CA35 File Offset: 0x0014AC35
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

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x06008C73 RID: 35955 RVA: 0x0014CA43 File Offset: 0x0014AC43
		// (set) Token: 0x06008C74 RID: 35956 RVA: 0x0014CA72 File Offset: 0x0014AC72
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

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x06008C75 RID: 35957 RVA: 0x0014CA80 File Offset: 0x0014AC80
		// (set) Token: 0x06008C76 RID: 35958 RVA: 0x0014CAAF File Offset: 0x0014ACAF
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

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x0014CABD File Offset: 0x0014ACBD
		// (set) Token: 0x06008C78 RID: 35960 RVA: 0x0014CAEC File Offset: 0x0014ACEC
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

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x06008C79 RID: 35961 RVA: 0x0014CAFA File Offset: 0x0014ACFA
		// (set) Token: 0x06008C7A RID: 35962 RVA: 0x0014CB29 File Offset: 0x0014AD29
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

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x06008C7B RID: 35963 RVA: 0x0014CB37 File Offset: 0x0014AD37
		// (set) Token: 0x06008C7C RID: 35964 RVA: 0x0014CB66 File Offset: 0x0014AD66
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

		// Token: 0x17002D95 RID: 11669
		// (get) Token: 0x06008C7D RID: 35965 RVA: 0x0014CB74 File Offset: 0x0014AD74
		// (set) Token: 0x06008C7E RID: 35966 RVA: 0x0014CBA3 File Offset: 0x0014ADA3
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

		// Token: 0x17002D96 RID: 11670
		// (get) Token: 0x06008C7F RID: 35967 RVA: 0x0014CBB1 File Offset: 0x0014ADB1
		// (set) Token: 0x06008C80 RID: 35968 RVA: 0x0014CBE0 File Offset: 0x0014ADE0
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

		// Token: 0x17002D97 RID: 11671
		// (get) Token: 0x06008C81 RID: 35969 RVA: 0x0014CBEE File Offset: 0x0014ADEE
		// (set) Token: 0x06008C82 RID: 35970 RVA: 0x0014CC1D File Offset: 0x0014AE1D
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

		// Token: 0x17002D98 RID: 11672
		// (get) Token: 0x06008C83 RID: 35971 RVA: 0x0014CC2B File Offset: 0x0014AE2B
		// (set) Token: 0x06008C84 RID: 35972 RVA: 0x0014CC5A File Offset: 0x0014AE5A
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

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x06008C85 RID: 35973 RVA: 0x0014CC68 File Offset: 0x0014AE68
		// (set) Token: 0x06008C86 RID: 35974 RVA: 0x0014CC97 File Offset: 0x0014AE97
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

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x06008C87 RID: 35975 RVA: 0x0014CCA5 File Offset: 0x0014AEA5
		// (set) Token: 0x06008C88 RID: 35976 RVA: 0x0014CCD4 File Offset: 0x0014AED4
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

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x06008C89 RID: 35977 RVA: 0x0014CCE2 File Offset: 0x0014AEE2
		// (set) Token: 0x06008C8A RID: 35978 RVA: 0x0014CD11 File Offset: 0x0014AF11
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

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x06008C8B RID: 35979 RVA: 0x0014CD1F File Offset: 0x0014AF1F
		// (set) Token: 0x06008C8C RID: 35980 RVA: 0x0014CD4E File Offset: 0x0014AF4E
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

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x06008C8D RID: 35981 RVA: 0x0014CD5C File Offset: 0x0014AF5C
		// (set) Token: 0x06008C8E RID: 35982 RVA: 0x0014CD8B File Offset: 0x0014AF8B
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

		// Token: 0x04005882 RID: 22658
		[Nullable(2)]
		protected ICameraLockParams FbInstance;

		// Token: 0x04005883 RID: 22659
		[Nullable(2)]
		protected ICameraLockParams_SetValue PocoInterface;
	}
}
