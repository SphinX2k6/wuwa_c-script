using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017C0 RID: 6080
	[NullableContext(2)]
	[Nullable(0)]
	public class IAdjustFixedLookAtTargetRangeEntity : IAdjustFixedLookAtTargetBase
	{
		// Token: 0x060081CD RID: 33229 RVA: 0x001361EC File Offset: 0x001343EC
		[NullableContext(1)]
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

		// Token: 0x060081CE RID: 33230 RVA: 0x00136224 File Offset: 0x00134424
		[NullableContext(1)]
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

		// Token: 0x060081CF RID: 33231 RVA: 0x00136237 File Offset: 0x00134437
		[NullableContext(1)]
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

		// Token: 0x060081D0 RID: 33232 RVA: 0x0013624C File Offset: 0x0013444C
		[NullableContext(1)]
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

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x060081D1 RID: 33233 RVA: 0x0013629A File Offset: 0x0013449A
		// (set) Token: 0x060081D2 RID: 33234 RVA: 0x001362C5 File Offset: 0x001344C5
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

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x060081D3 RID: 33235 RVA: 0x001362D3 File Offset: 0x001344D3
		// (set) Token: 0x060081D4 RID: 33236 RVA: 0x001362FE File Offset: 0x001344FE
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

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x060081D5 RID: 33237 RVA: 0x0013630C File Offset: 0x0013450C
		// (set) Token: 0x060081D6 RID: 33238 RVA: 0x0013636D File Offset: 0x0013456D
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

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x00136384 File Offset: 0x00134584
		// (set) Token: 0x060081D8 RID: 33240 RVA: 0x001363E5 File Offset: 0x001345E5
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

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x060081D9 RID: 33241 RVA: 0x001363FC File Offset: 0x001345FC
		// (set) Token: 0x060081DA RID: 33242 RVA: 0x0013645D File Offset: 0x0013465D
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

		// Token: 0x04005270 RID: 21104
		protected new IAdjustFixedLookAtTargetRangeEntity FbInstance;

		// Token: 0x04005271 RID: 21105
		protected new IAdjustFixedLookAtTargetRangeEntity_SetValue PocoInterface;

		// Token: 0x04005272 RID: 21106
		[Nullable(1)]
		private IMovingCameraTimeParams _MovingTimeParamsCache;

		// Token: 0x04005273 RID: 21107
		private bool _MovingTimeParamsInited;

		// Token: 0x04005274 RID: 21108
		[Nullable(1)]
		private PlayFlow _MovingFlowCache;

		// Token: 0x04005275 RID: 21109
		private bool _MovingFlowInited;

		// Token: 0x04005276 RID: 21110
		[Nullable(1)]
		private ICutCameraConfig _CutCameraConfigCache;

		// Token: 0x04005277 RID: 21111
		private bool _CutCameraConfigInited;
	}
}
