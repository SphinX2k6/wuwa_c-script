using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BC4 RID: 7108
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechaAirPassageMove : ISplineMovePattern
	{
		// Token: 0x06009833 RID: 38963 RVA: 0x0015EDB4 File Offset: 0x0015CFB4
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

		// Token: 0x06009834 RID: 38964 RVA: 0x0015EDEC File Offset: 0x0015CFEC
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

		// Token: 0x06009835 RID: 38965 RVA: 0x0015EDFF File Offset: 0x0015CFFF
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

		// Token: 0x06009836 RID: 38966 RVA: 0x0015EE14 File Offset: 0x0015D014
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

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x06009837 RID: 38967 RVA: 0x0015EEB6 File Offset: 0x0015D0B6
		// (set) Token: 0x06009838 RID: 38968 RVA: 0x0015EEE1 File Offset: 0x0015D0E1
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

		// Token: 0x17002FCB RID: 12235
		// (get) Token: 0x06009839 RID: 38969 RVA: 0x0015EEF0 File Offset: 0x0015D0F0
		// (set) Token: 0x0600983A RID: 38970 RVA: 0x0015EF2A File Offset: 0x0015D12A
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

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x0600983B RID: 38971 RVA: 0x0015EF38 File Offset: 0x0015D138
		// (set) Token: 0x0600983C RID: 38972 RVA: 0x0015EF72 File Offset: 0x0015D172
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

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x0600983D RID: 38973 RVA: 0x0015EF80 File Offset: 0x0015D180
		// (set) Token: 0x0600983E RID: 38974 RVA: 0x0015EFBA File Offset: 0x0015D1BA
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

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x0600983F RID: 38975 RVA: 0x0015EFC8 File Offset: 0x0015D1C8
		// (set) Token: 0x06009840 RID: 38976 RVA: 0x0015F002 File Offset: 0x0015D202
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

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x06009841 RID: 38977 RVA: 0x0015F010 File Offset: 0x0015D210
		// (set) Token: 0x06009842 RID: 38978 RVA: 0x0015F04A File Offset: 0x0015D24A
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

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x06009843 RID: 38979 RVA: 0x0015F058 File Offset: 0x0015D258
		// (set) Token: 0x06009844 RID: 38980 RVA: 0x0015F092 File Offset: 0x0015D292
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

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x06009845 RID: 38981 RVA: 0x0015F0A0 File Offset: 0x0015D2A0
		// (set) Token: 0x06009846 RID: 38982 RVA: 0x0015F0CF File Offset: 0x0015D2CF
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

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x06009847 RID: 38983 RVA: 0x0015F0DD File Offset: 0x0015D2DD
		// (set) Token: 0x06009848 RID: 38984 RVA: 0x0015F104 File Offset: 0x0015D304
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

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x06009849 RID: 38985 RVA: 0x0015F112 File Offset: 0x0015D312
		// (set) Token: 0x0600984A RID: 38986 RVA: 0x0015F13D File Offset: 0x0015D33D
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

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0600984B RID: 38987 RVA: 0x0015F14C File Offset: 0x0015D34C
		// (set) Token: 0x0600984C RID: 38988 RVA: 0x0015F186 File Offset: 0x0015D386
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

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0600984D RID: 38989 RVA: 0x0015F194 File Offset: 0x0015D394
		// (set) Token: 0x0600984E RID: 38990 RVA: 0x0015F1CE File Offset: 0x0015D3CE
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

		// Token: 0x04005CDB RID: 23771
		[Nullable(2)]
		protected new IMechaAirPassageMove FbInstance;

		// Token: 0x04005CDC RID: 23772
		[Nullable(2)]
		protected new IMechaAirPassageMove_SetValue PocoInterface;
	}
}
