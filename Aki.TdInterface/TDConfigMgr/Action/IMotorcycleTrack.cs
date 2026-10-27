using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C18 RID: 7192
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorcycleTrack : ISplineMovePattern
	{
		// Token: 0x06009A39 RID: 39481 RVA: 0x00162C64 File Offset: 0x00160E64
		private IMotorcycleTrack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorcycleTrack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorcycleTrack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorcycleTrack_SetValue());
			}
			return result;
		}

		// Token: 0x06009A3A RID: 39482 RVA: 0x00162C9C File Offset: 0x00160E9C
		public static IMotorcycleTrack Create([Nullable(2)] IMotorcycleTrack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorcycleTrack
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A3B RID: 39483 RVA: 0x00162CAF File Offset: 0x00160EAF
		public static IMotorcycleTrack CreateFromSetValue([Nullable(2)] IMotorcycleTrack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorcycleTrack
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A3C RID: 39484 RVA: 0x00162CC4 File Offset: 0x00160EC4
		public new IMotorcycleTrack_SetValue ToSetValue()
		{
			return new IMotorcycleTrack_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance,
				DisableAutoForward = this.DisableAutoForward,
				LongitudinalAngleLimit = this.LongitudinalAngleLimit,
				ForwardAngleLimit = this.ForwardAngleLimit,
				ForwardAngleLimitCurve = this.ForwardAngleLimitCurve,
				InputCorrectionCurve = this.InputCorrectionCurve,
				InputCorrectionBaseAngle = this.InputCorrectionBaseAngle,
				CorrectionPredictionDistance = this.CorrectionPredictionDistance,
				AccelerationCorrectionCurve = this.AccelerationCorrectionCurve,
				AutomaticDrive = this.AutomaticDrive
			};
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x06009A3D RID: 39485 RVA: 0x00162D96 File Offset: 0x00160F96
		// (set) Token: 0x06009A3E RID: 39486 RVA: 0x00162DC1 File Offset: 0x00160FC1
		public override ESplineMovePattern Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMovePattern.PathLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x06009A3F RID: 39487 RVA: 0x00162DD0 File Offset: 0x00160FD0
		// (set) Token: 0x06009A40 RID: 39488 RVA: 0x00162E0A File Offset: 0x0016100A
		public override float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaxOffsetDistance;
			}
			set
			{
				this.GetOrCreatePoco().MaxOffsetDistance = value;
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x06009A41 RID: 39489 RVA: 0x00162E18 File Offset: 0x00161018
		// (set) Token: 0x06009A42 RID: 39490 RVA: 0x00162E52 File Offset: 0x00161052
		public override bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOneWay;
			}
			set
			{
				this.GetOrCreatePoco().IsOneWay = value;
			}
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x06009A43 RID: 39491 RVA: 0x00162E60 File Offset: 0x00161060
		// (set) Token: 0x06009A44 RID: 39492 RVA: 0x00162E9A File Offset: 0x0016109A
		public override float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LayerVerticalLimit;
			}
			set
			{
				this.GetOrCreatePoco().LayerVerticalLimit = value;
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x06009A45 RID: 39493 RVA: 0x00162EA8 File Offset: 0x001610A8
		// (set) Token: 0x06009A46 RID: 39494 RVA: 0x00162EE2 File Offset: 0x001610E2
		public override bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DynamicGravity;
			}
			set
			{
				this.GetOrCreatePoco().DynamicGravity = value;
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x06009A47 RID: 39495 RVA: 0x00162EF0 File Offset: 0x001610F0
		// (set) Token: 0x06009A48 RID: 39496 RVA: 0x00162F2A File Offset: 0x0016112A
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravitySwitchAngularVelocity;
			}
			set
			{
				this.GetOrCreatePoco().GravitySwitchAngularVelocity = value;
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x06009A49 RID: 39497 RVA: 0x00162F38 File Offset: 0x00161138
		// (set) Token: 0x06009A4A RID: 39498 RVA: 0x00162F72 File Offset: 0x00161172
		public override int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoExitDistance;
			}
			set
			{
				this.GetOrCreatePoco().AutoExitDistance = value;
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x06009A4B RID: 39499 RVA: 0x00162F80 File Offset: 0x00161180
		// (set) Token: 0x06009A4C RID: 39500 RVA: 0x00162FBA File Offset: 0x001611BA
		public virtual bool? DisableAutoForward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableAutoForward;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableAutoForward;
			}
			set
			{
				this.GetOrCreatePoco().DisableAutoForward = value;
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x06009A4D RID: 39501 RVA: 0x00162FC8 File Offset: 0x001611C8
		// (set) Token: 0x06009A4E RID: 39502 RVA: 0x00163002 File Offset: 0x00161202
		public virtual float? LongitudinalAngleLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LongitudinalAngleLimit;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LongitudinalAngleLimit;
			}
			set
			{
				this.GetOrCreatePoco().LongitudinalAngleLimit = value;
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x06009A4F RID: 39503 RVA: 0x00163010 File Offset: 0x00161210
		// (set) Token: 0x06009A50 RID: 39504 RVA: 0x0016303F File Offset: 0x0016123F
		public virtual float ForwardAngleLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardAngleLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ForwardAngleLimit;
			}
			set
			{
				this.GetOrCreatePoco().ForwardAngleLimit = value;
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x06009A51 RID: 39505 RVA: 0x0016304D File Offset: 0x0016124D
		// (set) Token: 0x06009A52 RID: 39506 RVA: 0x00163074 File Offset: 0x00161274
		[Nullable(2)]
		public virtual string ForwardAngleLimitCurve
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForwardAngleLimitCurve;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForwardAngleLimitCurve;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ForwardAngleLimitCurve = value;
			}
		}

		// Token: 0x1700305A RID: 12378
		// (get) Token: 0x06009A53 RID: 39507 RVA: 0x00163082 File Offset: 0x00161282
		// (set) Token: 0x06009A54 RID: 39508 RVA: 0x001630AD File Offset: 0x001612AD
		public virtual string InputCorrectionCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InputCorrectionCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.InputCorrectionCurve;
			}
			set
			{
				this.GetOrCreatePoco().InputCorrectionCurve = value;
			}
		}

		// Token: 0x1700305B RID: 12379
		// (get) Token: 0x06009A55 RID: 39509 RVA: 0x001630BC File Offset: 0x001612BC
		// (set) Token: 0x06009A56 RID: 39510 RVA: 0x001630F6 File Offset: 0x001612F6
		public virtual float? InputCorrectionBaseAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InputCorrectionBaseAngle;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InputCorrectionBaseAngle;
			}
			set
			{
				this.GetOrCreatePoco().InputCorrectionBaseAngle = value;
			}
		}

		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x06009A57 RID: 39511 RVA: 0x00163104 File Offset: 0x00161304
		// (set) Token: 0x06009A58 RID: 39512 RVA: 0x0016313E File Offset: 0x0016133E
		public virtual float? CorrectionPredictionDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CorrectionPredictionDistance;
				}
				IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CorrectionPredictionDistance;
			}
			set
			{
				this.GetOrCreatePoco().CorrectionPredictionDistance = value;
			}
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x06009A59 RID: 39513 RVA: 0x0016314C File Offset: 0x0016134C
		// (set) Token: 0x06009A5A RID: 39514 RVA: 0x00163177 File Offset: 0x00161377
		public virtual string AccelerationCorrectionCurve
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AccelerationCorrectionCurve;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AccelerationCorrectionCurve;
			}
			set
			{
				this.GetOrCreatePoco().AccelerationCorrectionCurve = value;
			}
		}

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x06009A5B RID: 39515 RVA: 0x00163188 File Offset: 0x00161388
		// (set) Token: 0x06009A5C RID: 39516 RVA: 0x001631E9 File Offset: 0x001613E9
		[Nullable(2)]
		public virtual IAutomaticDrive AutomaticDrive
		{
			[NullableContext(2)]
			get
			{
				if (this._AutomaticDriveInited)
				{
					return this._AutomaticDriveCache;
				}
				this._AutomaticDriveInited = true;
				if (this.FbInstance != null)
				{
					this._AutomaticDriveCache = IAutomaticDrive.Create(this.FbInstance.AutomaticDrive);
				}
				else
				{
					IMotorcycleTrack_SetValue pocoInterface = this.PocoInterface;
					this._AutomaticDriveCache = ((pocoInterface != null) ? pocoInterface.AutomaticDrive : null);
				}
				return this._AutomaticDriveCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AutomaticDrive = value;
				this._AutomaticDriveInited = false;
			}
		}

		// Token: 0x04005DD6 RID: 24022
		[Nullable(2)]
		protected new IMotorcycleTrack FbInstance;

		// Token: 0x04005DD7 RID: 24023
		[Nullable(2)]
		protected new IMotorcycleTrack_SetValue PocoInterface;

		// Token: 0x04005DD8 RID: 24024
		private IAutomaticDrive _AutomaticDriveCache;

		// Token: 0x04005DD9 RID: 24025
		private bool _AutomaticDriveInited;
	}
}
