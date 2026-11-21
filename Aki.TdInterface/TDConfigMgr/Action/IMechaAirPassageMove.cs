using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DAB RID: 7595
	public class IMechaAirPassageMove : ISplineMovePattern
	{
		// Token: 0x0600A137 RID: 41271 RVA: 0x00171874 File Offset: 0x0016FA74
		private IMechaAirPassageMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechaAirPassageMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechaAirPassageMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechaAirPassageMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x001718AC File Offset: 0x0016FAAC
		public static IMechaAirPassageMove Create([Nullable(2)] IMechaAirPassageMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaAirPassageMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x001718BF File Offset: 0x0016FABF
		public static IMechaAirPassageMove CreateFromSetValue([Nullable(2)] IMechaAirPassageMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechaAirPassageMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x001718D4 File Offset: 0x0016FAD4
		public new IMechaAirPassageMove_SetValue ToSetValue()
		{
			return new IMechaAirPassageMove_SetValue
			{
				Type = this.Type,
				MaxOffsetDistance = this.MaxOffsetDistance,
				IsOneWay = this.IsOneWay,
				LayerVerticalLimit = this.LayerVerticalLimit,
				DynamicGravity = this.DynamicGravity,
				GravitySwitchAngularVelocity = this.GravitySwitchAngularVelocity,
				AutoExitDistance = this.AutoExitDistance,
				ForwardAngleLimit = this.ForwardAngleLimit,
				ForwardAngleLimitCurve = this.ForwardAngleLimitCurve,
				InputCorrectionCurve = this.InputCorrectionCurve,
				InputCorrectionBaseAngle = this.InputCorrectionBaseAngle,
				CorrectionPredictionDistance = this.CorrectionPredictionDistance
			};
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600A13B RID: 41275 RVA: 0x00171976 File Offset: 0x0016FB76
		// (set) Token: 0x0600A13C RID: 41276 RVA: 0x001719A1 File Offset: 0x0016FBA1
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

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600A13D RID: 41277 RVA: 0x001719B0 File Offset: 0x0016FBB0
		// (set) Token: 0x0600A13E RID: 41278 RVA: 0x001719EA File Offset: 0x0016FBEA
		public override float? MaxOffsetDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxOffsetDistance;
				}
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600A13F RID: 41279 RVA: 0x001719F8 File Offset: 0x0016FBF8
		// (set) Token: 0x0600A140 RID: 41280 RVA: 0x00171A32 File Offset: 0x0016FC32
		public override bool? IsOneWay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOneWay;
				}
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600A141 RID: 41281 RVA: 0x00171A40 File Offset: 0x0016FC40
		// (set) Token: 0x0600A142 RID: 41282 RVA: 0x00171A7A File Offset: 0x0016FC7A
		public override float? LayerVerticalLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LayerVerticalLimit;
				}
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600A143 RID: 41283 RVA: 0x00171A88 File Offset: 0x0016FC88
		// (set) Token: 0x0600A144 RID: 41284 RVA: 0x00171AC2 File Offset: 0x0016FCC2
		public override bool? DynamicGravity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DynamicGravity;
				}
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600A145 RID: 41285 RVA: 0x00171AD0 File Offset: 0x0016FCD0
		// (set) Token: 0x0600A146 RID: 41286 RVA: 0x00171B0A File Offset: 0x0016FD0A
		public override float? GravitySwitchAngularVelocity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravitySwitchAngularVelocity;
				}
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600A147 RID: 41287 RVA: 0x00171B18 File Offset: 0x0016FD18
		// (set) Token: 0x0600A148 RID: 41288 RVA: 0x00171B52 File Offset: 0x0016FD52
		public override int? AutoExitDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoExitDistance;
				}
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600A149 RID: 41289 RVA: 0x00171B60 File Offset: 0x0016FD60
		// (set) Token: 0x0600A14A RID: 41290 RVA: 0x00171B8F File Offset: 0x0016FD8F
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

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600A14B RID: 41291 RVA: 0x00171B9D File Offset: 0x0016FD9D
		// (set) Token: 0x0600A14C RID: 41292 RVA: 0x00171BC4 File Offset: 0x0016FDC4
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
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600A14D RID: 41293 RVA: 0x00171BD2 File Offset: 0x0016FDD2
		// (set) Token: 0x0600A14E RID: 41294 RVA: 0x00171BFD File Offset: 0x0016FDFD
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

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600A14F RID: 41295 RVA: 0x00171C0C File Offset: 0x0016FE0C
		// (set) Token: 0x0600A150 RID: 41296 RVA: 0x00171C46 File Offset: 0x0016FE46
		public virtual float? InputCorrectionBaseAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InputCorrectionBaseAngle;
				}
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600A151 RID: 41297 RVA: 0x00171C54 File Offset: 0x0016FE54
		// (set) Token: 0x0600A152 RID: 41298 RVA: 0x00171C8E File Offset: 0x0016FE8E
		public virtual float? CorrectionPredictionDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CorrectionPredictionDistance;
				}
				IMechaAirPassageMove_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040061F0 RID: 25072
		[Nullable(2)]
		protected new IMechaAirPassageMove FbInstance;

		// Token: 0x040061F1 RID: 25073
		[Nullable(2)]
		protected new IMechaAirPassageMove_SetValue PocoInterface;
	}
}
