using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B90 RID: 11152
	[NullableContext(2)]
	[Nullable(0)]
	public class IAdjustFixedLookAtTargetRangeEntity : IAdjustFixedLookAtTargetBase
	{
		// Token: 0x0600F5A4 RID: 62884 RVA: 0x0023CC90 File Offset: 0x0023AE90
		[NullableContext(0)]
		public static IAdjustFixedLookAtTargetRangeEntity Create(IAdjustFixedLookAtTargetRangeEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetRangeEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B32 RID: 19250
		// (get) Token: 0x0600F5A5 RID: 62885 RVA: 0x0023CCAF File Offset: 0x0023AEAF
		public override EFixedLookAtTargetType Type
		{
			get
			{
				return (EFixedLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x17004B33 RID: 19251
		// (get) Token: 0x0600F5A6 RID: 62886 RVA: 0x0023CCBC File Offset: 0x0023AEBC
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004B34 RID: 19252
		// (get) Token: 0x0600F5A7 RID: 62887 RVA: 0x0023CCC9 File Offset: 0x0023AEC9
		public virtual IMovingCameraTimeParams MovingTimeParams
		{
			get
			{
				if (this._MovingTimeParamsInited)
				{
					return this._MovingTimeParamsCache;
				}
				this._MovingTimeParamsInited = true;
				this._MovingTimeParamsCache = IMovingCameraTimeParams.Create(this.Instance.MovingTimeParams);
				return this._MovingTimeParamsCache;
			}
		}

		// Token: 0x17004B35 RID: 19253
		// (get) Token: 0x0600F5A8 RID: 62888 RVA: 0x0023CCFD File Offset: 0x0023AEFD
		public virtual PlayFlow MovingFlow
		{
			get
			{
				if (this._MovingFlowInited)
				{
					return this._MovingFlowCache;
				}
				this._MovingFlowInited = true;
				this._MovingFlowCache = PlayFlow.Create(this.Instance.MovingFlow);
				return this._MovingFlowCache;
			}
		}

		// Token: 0x17004B36 RID: 19254
		// (get) Token: 0x0600F5A9 RID: 62889 RVA: 0x0023CD31 File Offset: 0x0023AF31
		public virtual ICutCameraConfig CutCameraConfig
		{
			get
			{
				if (this._CutCameraConfigInited)
				{
					return this._CutCameraConfigCache;
				}
				this._CutCameraConfigInited = true;
				this._CutCameraConfigCache = ICutCameraConfig.Create(this.Instance.CutCameraConfig);
				return this._CutCameraConfigCache;
			}
		}

		// Token: 0x040086AC RID: 34476
		private IAdjustFixedLookAtTargetRangeEntity Instance;

		// Token: 0x040086AD RID: 34477
		private IMovingCameraTimeParams _MovingTimeParamsCache;

		// Token: 0x040086AE RID: 34478
		private bool _MovingTimeParamsInited;

		// Token: 0x040086AF RID: 34479
		private PlayFlow _MovingFlowCache;

		// Token: 0x040086B0 RID: 34480
		private bool _MovingFlowInited;

		// Token: 0x040086B1 RID: 34481
		private ICutCameraConfig _CutCameraConfigCache;

		// Token: 0x040086B2 RID: 34482
		private bool _CutCameraConfigInited;
	}
}
