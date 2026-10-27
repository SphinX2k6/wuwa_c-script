using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028BB RID: 10427
	[NullableContext(2)]
	[Nullable(0)]
	public class IAdjustFixedLookAtTargetRangeEntity : IAdjustFixedLookAtTargetBase
	{
		// Token: 0x0600E775 RID: 59253 RVA: 0x0021FD10 File Offset: 0x0021DF10
		[NullableContext(1)]
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

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x0600E776 RID: 59254 RVA: 0x0021FD2F File Offset: 0x0021DF2F
		public override EFixedLookAtTargetType Type
		{
			get
			{
				return (EFixedLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x0600E777 RID: 59255 RVA: 0x0021FD3C File Offset: 0x0021DF3C
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170047C3 RID: 18371
		// (get) Token: 0x0600E778 RID: 59256 RVA: 0x0021FD49 File Offset: 0x0021DF49
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

		// Token: 0x170047C4 RID: 18372
		// (get) Token: 0x0600E779 RID: 59257 RVA: 0x0021FD7D File Offset: 0x0021DF7D
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

		// Token: 0x170047C5 RID: 18373
		// (get) Token: 0x0600E77A RID: 59258 RVA: 0x0021FDB1 File Offset: 0x0021DFB1
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

		// Token: 0x04007FED RID: 32749
		private IAdjustFixedLookAtTargetRangeEntity Instance;

		// Token: 0x04007FEE RID: 32750
		private IMovingCameraTimeParams _MovingTimeParamsCache;

		// Token: 0x04007FEF RID: 32751
		private bool _MovingTimeParamsInited;

		// Token: 0x04007FF0 RID: 32752
		private PlayFlow _MovingFlowCache;

		// Token: 0x04007FF1 RID: 32753
		private bool _MovingFlowInited;

		// Token: 0x04007FF2 RID: 32754
		private ICutCameraConfig _CutCameraConfigCache;

		// Token: 0x04007FF3 RID: 32755
		private bool _CutCameraConfigInited;
	}
}
