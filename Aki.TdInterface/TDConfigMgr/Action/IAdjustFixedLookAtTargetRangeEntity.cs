using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001943 RID: 6467
	[NullableContext(2)]
	[Nullable(0)]
	public class IAdjustFixedLookAtTargetRangeEntity : IAdjustFixedLookAtTargetBase
	{
		// Token: 0x060088C7 RID: 35015 RVA: 0x0014554C File Offset: 0x0014374C
		[NullableContext(0)]
		private IAdjustFixedLookAtTargetRangeEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAdjustFixedLookAtTargetRangeEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAdjustFixedLookAtTargetRangeEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAdjustFixedLookAtTargetRangeEntity_SetValue());
			}
			return result;
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x00145584 File Offset: 0x00143784
		[NullableContext(0)]
		public static IAdjustFixedLookAtTargetRangeEntity Create([Nullable(2)] IAdjustFixedLookAtTargetRangeEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetRangeEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x00145597 File Offset: 0x00143797
		[NullableContext(0)]
		public static IAdjustFixedLookAtTargetRangeEntity CreateFromSetValue([Nullable(2)] IAdjustFixedLookAtTargetRangeEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetRangeEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x001455AC File Offset: 0x001437AC
		[NullableContext(0)]
		public new IAdjustFixedLookAtTargetRangeEntity_SetValue ToSetValue()
		{
			return new IAdjustFixedLookAtTargetRangeEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				MovingTimeParams = this.MovingTimeParams,
				MovingFlow = this.MovingFlow,
				CutCameraConfig = this.CutCameraConfig
			};
		}

		// Token: 0x17002C8B RID: 11403
		// (get) Token: 0x060088CB RID: 35019 RVA: 0x001455FA File Offset: 0x001437FA
		// (set) Token: 0x060088CC RID: 35020 RVA: 0x00145625 File Offset: 0x00143825
		public override EFixedLookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFixedLookAtTargetType.RangeEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x060088CD RID: 35021 RVA: 0x00145633 File Offset: 0x00143833
		// (set) Token: 0x060088CE RID: 35022 RVA: 0x0014565E File Offset: 0x0014385E
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x060088CF RID: 35023 RVA: 0x0014566C File Offset: 0x0014386C
		// (set) Token: 0x060088D0 RID: 35024 RVA: 0x001456CD File Offset: 0x001438CD
		public virtual IMovingCameraTimeParams MovingTimeParams
		{
			get
			{
				if (this._MovingTimeParamsInited)
				{
					return this._MovingTimeParamsCache;
				}
				this._MovingTimeParamsInited = true;
				if (this.FbInstance != null)
				{
					this._MovingTimeParamsCache = IMovingCameraTimeParams.Create(this.FbInstance.MovingTimeParams);
				}
				else
				{
					IAdjustFixedLookAtTargetRangeEntity_SetValue pocoInterface = this.PocoInterface;
					this._MovingTimeParamsCache = ((pocoInterface != null) ? pocoInterface.MovingTimeParams : null);
				}
				return this._MovingTimeParamsCache;
			}
			set
			{
				this.GetOrCreatePoco().MovingTimeParams = value;
				this._MovingTimeParamsInited = false;
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x060088D1 RID: 35025 RVA: 0x001456E4 File Offset: 0x001438E4
		// (set) Token: 0x060088D2 RID: 35026 RVA: 0x00145745 File Offset: 0x00143945
		public virtual PlayFlow MovingFlow
		{
			get
			{
				if (this._MovingFlowInited)
				{
					return this._MovingFlowCache;
				}
				this._MovingFlowInited = true;
				if (this.FbInstance != null)
				{
					this._MovingFlowCache = PlayFlow.Create(this.FbInstance.MovingFlow);
				}
				else
				{
					IAdjustFixedLookAtTargetRangeEntity_SetValue pocoInterface = this.PocoInterface;
					this._MovingFlowCache = ((pocoInterface != null) ? pocoInterface.MovingFlow : null);
				}
				return this._MovingFlowCache;
			}
			set
			{
				this.GetOrCreatePoco().MovingFlow = value;
				this._MovingFlowInited = false;
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x060088D3 RID: 35027 RVA: 0x0014575C File Offset: 0x0014395C
		// (set) Token: 0x060088D4 RID: 35028 RVA: 0x001457BD File Offset: 0x001439BD
		public virtual ICutCameraConfig CutCameraConfig
		{
			get
			{
				if (this._CutCameraConfigInited)
				{
					return this._CutCameraConfigCache;
				}
				this._CutCameraConfigInited = true;
				if (this.FbInstance != null)
				{
					this._CutCameraConfigCache = ICutCameraConfig.Create(this.FbInstance.CutCameraConfig);
				}
				else
				{
					IAdjustFixedLookAtTargetRangeEntity_SetValue pocoInterface = this.PocoInterface;
					this._CutCameraConfigCache = ((pocoInterface != null) ? pocoInterface.CutCameraConfig : null);
				}
				return this._CutCameraConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().CutCameraConfig = value;
				this._CutCameraConfigInited = false;
			}
		}

		// Token: 0x040056AA RID: 22186
		protected new IAdjustFixedLookAtTargetRangeEntity FbInstance;

		// Token: 0x040056AB RID: 22187
		protected new IAdjustFixedLookAtTargetRangeEntity_SetValue PocoInterface;

		// Token: 0x040056AC RID: 22188
		[Nullable(0)]
		private IMovingCameraTimeParams _MovingTimeParamsCache;

		// Token: 0x040056AD RID: 22189
		private bool _MovingTimeParamsInited;

		// Token: 0x040056AE RID: 22190
		[Nullable(0)]
		private PlayFlow _MovingFlowCache;

		// Token: 0x040056AF RID: 22191
		private bool _MovingFlowInited;

		// Token: 0x040056B0 RID: 22192
		[Nullable(0)]
		private ICutCameraConfig _CutCameraConfigCache;

		// Token: 0x040056B1 RID: 22193
		private bool _CutCameraConfigInited;
	}
}
