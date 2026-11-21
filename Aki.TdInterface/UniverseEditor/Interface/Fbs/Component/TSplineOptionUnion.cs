using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062DD RID: 25309
	public class TSplineOptionUnion
	{
		// Token: 0x1700BBAA RID: 48042
		// (get) Token: 0x0602B025 RID: 176165 RVA: 0x005DD73E File Offset: 0x005DB93E
		// (set) Token: 0x0602B026 RID: 176166 RVA: 0x005DD746 File Offset: 0x005DB946
		public TSplineOption Type { get; set; }

		// Token: 0x1700BBAB RID: 48043
		// (get) Token: 0x0602B027 RID: 176167 RVA: 0x005DD74F File Offset: 0x005DB94F
		// (set) Token: 0x0602B028 RID: 176168 RVA: 0x005DD757 File Offset: 0x005DB957
		public object Value { get; set; }

		// Token: 0x0602B029 RID: 176169 RVA: 0x005DD760 File Offset: 0x005DB960
		public TSplineOptionUnion()
		{
			this.Type = TSplineOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602B02A RID: 176170 RVA: 0x005DD776 File Offset: 0x005DB976
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B02B RID: 176171 RVA: 0x005DD788 File Offset: 0x005DB988
		public IAirPassageSplineT AsIAirPassageSpline()
		{
			return this.As<IAirPassageSplineT>();
		}

		// Token: 0x0602B02C RID: 176172 RVA: 0x005DD790 File Offset: 0x005DB990
		public static TSplineOptionUnion FromIAirPassageSpline(IAirPassageSplineT _iairpassagespline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IAirPassageSpline,
				Value = _iairpassagespline
			};
		}

		// Token: 0x0602B02D RID: 176173 RVA: 0x005DD7A5 File Offset: 0x005DB9A5
		public IButterflySplineT AsIButterflySpline()
		{
			return this.As<IButterflySplineT>();
		}

		// Token: 0x0602B02E RID: 176174 RVA: 0x005DD7AD File Offset: 0x005DB9AD
		public static TSplineOptionUnion FromIButterflySpline(IButterflySplineT _ibutterflyspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IButterflySpline,
				Value = _ibutterflyspline
			};
		}

		// Token: 0x0602B02F RID: 176175 RVA: 0x005DD7C2 File Offset: 0x005DB9C2
		public ICommonSplineT AsICommonSpline()
		{
			return this.As<ICommonSplineT>();
		}

		// Token: 0x0602B030 RID: 176176 RVA: 0x005DD7CA File Offset: 0x005DB9CA
		public static TSplineOptionUnion FromICommonSpline(ICommonSplineT _icommonspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.ICommonSpline,
				Value = _icommonspline
			};
		}

		// Token: 0x0602B031 RID: 176177 RVA: 0x005DD7DF File Offset: 0x005DB9DF
		public IContinuesVariableSpeedMovementSplineT AsIContinuesVariableSpeedMovementSpline()
		{
			return this.As<IContinuesVariableSpeedMovementSplineT>();
		}

		// Token: 0x0602B032 RID: 176178 RVA: 0x005DD7E7 File Offset: 0x005DB9E7
		public static TSplineOptionUnion FromIContinuesVariableSpeedMovementSpline(IContinuesVariableSpeedMovementSplineT _icontinuesvariablespeedmovementspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IContinuesVariableSpeedMovementSpline,
				Value = _icontinuesvariablespeedmovementspline
			};
		}

		// Token: 0x0602B033 RID: 176179 RVA: 0x005DD7FC File Offset: 0x005DB9FC
		public IEffectSplineT AsIEffectSpline()
		{
			return this.As<IEffectSplineT>();
		}

		// Token: 0x0602B034 RID: 176180 RVA: 0x005DD804 File Offset: 0x005DBA04
		public static TSplineOptionUnion FromIEffectSpline(IEffectSplineT _ieffectspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IEffectSpline,
				Value = _ieffectspline
			};
		}

		// Token: 0x0602B035 RID: 176181 RVA: 0x005DD819 File Offset: 0x005DBA19
		public ILevelAISplineT AsILevelAISpline()
		{
			return this.As<ILevelAISplineT>();
		}

		// Token: 0x0602B036 RID: 176182 RVA: 0x005DD821 File Offset: 0x005DBA21
		public static TSplineOptionUnion FromILevelAISpline(ILevelAISplineT _ilevelaispline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.ILevelAISpline,
				Value = _ilevelaispline
			};
		}

		// Token: 0x0602B037 RID: 176183 RVA: 0x005DD836 File Offset: 0x005DBA36
		public IMotorSlideSplineT AsIMotorSlideSpline()
		{
			return this.As<IMotorSlideSplineT>();
		}

		// Token: 0x0602B038 RID: 176184 RVA: 0x005DD83E File Offset: 0x005DBA3E
		public static TSplineOptionUnion FromIMotorSlideSpline(IMotorSlideSplineT _imotorslidespline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IMotorSlideSpline,
				Value = _imotorslidespline
			};
		}

		// Token: 0x0602B039 RID: 176185 RVA: 0x005DD853 File Offset: 0x005DBA53
		public IParkourSplineT AsIParkourSpline()
		{
			return this.As<IParkourSplineT>();
		}

		// Token: 0x0602B03A RID: 176186 RVA: 0x005DD85B File Offset: 0x005DBA5B
		public static TSplineOptionUnion FromIParkourSpline(IParkourSplineT _iparkourspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IParkourSpline,
				Value = _iparkourspline
			};
		}

		// Token: 0x0602B03B RID: 176187 RVA: 0x005DD870 File Offset: 0x005DBA70
		public IPatrolSplineT AsIPatrolSpline()
		{
			return this.As<IPatrolSplineT>();
		}

		// Token: 0x0602B03C RID: 176188 RVA: 0x005DD878 File Offset: 0x005DBA78
		public static TSplineOptionUnion FromIPatrolSpline(IPatrolSplineT _ipatrolspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IPatrolSpline,
				Value = _ipatrolspline
			};
		}

		// Token: 0x0602B03D RID: 176189 RVA: 0x005DD88E File Offset: 0x005DBA8E
		public IRangeSplineT AsIRangeSpline()
		{
			return this.As<IRangeSplineT>();
		}

		// Token: 0x0602B03E RID: 176190 RVA: 0x005DD896 File Offset: 0x005DBA96
		public static TSplineOptionUnion FromIRangeSpline(IRangeSplineT _irangespline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IRangeSpline,
				Value = _irangespline
			};
		}

		// Token: 0x0602B03F RID: 176191 RVA: 0x005DD8AC File Offset: 0x005DBAAC
		public ISwordRiderRailSplineT AsISwordRiderRailSpline()
		{
			return this.As<ISwordRiderRailSplineT>();
		}

		// Token: 0x0602B040 RID: 176192 RVA: 0x005DD8B4 File Offset: 0x005DBAB4
		public static TSplineOptionUnion FromISwordRiderRailSpline(ISwordRiderRailSplineT _iswordriderrailspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.ISwordRiderRailSpline,
				Value = _iswordriderrailspline
			};
		}

		// Token: 0x0602B041 RID: 176193 RVA: 0x005DD8CA File Offset: 0x005DBACA
		public ITimePatrolSplineT AsITimePatrolSpline()
		{
			return this.As<ITimePatrolSplineT>();
		}

		// Token: 0x0602B042 RID: 176194 RVA: 0x005DD8D2 File Offset: 0x005DBAD2
		public static TSplineOptionUnion FromITimePatrolSpline(ITimePatrolSplineT _itimepatrolspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.ITimePatrolSpline,
				Value = _itimepatrolspline
			};
		}

		// Token: 0x0602B043 RID: 176195 RVA: 0x005DD8E8 File Offset: 0x005DBAE8
		public IWaySplineT AsIWaySpline()
		{
			return this.As<IWaySplineT>();
		}

		// Token: 0x0602B044 RID: 176196 RVA: 0x005DD8F0 File Offset: 0x005DBAF0
		public static TSplineOptionUnion FromIWaySpline(IWaySplineT _iwayspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IWaySpline,
				Value = _iwayspline
			};
		}

		// Token: 0x0602B045 RID: 176197 RVA: 0x005DD908 File Offset: 0x005DBB08
		public static int Pack(FlatBufferBuilder builder, TSplineOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TSplineOption.IAirPassageSpline:
				return IAirPassageSpline.Pack(builder, _o.AsIAirPassageSpline()).Value;
			case TSplineOption.IButterflySpline:
				return IButterflySpline.Pack(builder, _o.AsIButterflySpline()).Value;
			case TSplineOption.ICommonSpline:
				return ICommonSpline.Pack(builder, _o.AsICommonSpline()).Value;
			case TSplineOption.IContinuesVariableSpeedMovementSpline:
				return IContinuesVariableSpeedMovementSpline.Pack(builder, _o.AsIContinuesVariableSpeedMovementSpline()).Value;
			case TSplineOption.IEffectSpline:
				return IEffectSpline.Pack(builder, _o.AsIEffectSpline()).Value;
			case TSplineOption.ILevelAISpline:
				return ILevelAISpline.Pack(builder, _o.AsILevelAISpline()).Value;
			case TSplineOption.IMotorSlideSpline:
				return IMotorSlideSpline.Pack(builder, _o.AsIMotorSlideSpline()).Value;
			case TSplineOption.IParkourSpline:
				return IParkourSpline.Pack(builder, _o.AsIParkourSpline()).Value;
			case TSplineOption.IPatrolSpline:
				return IPatrolSpline.Pack(builder, _o.AsIPatrolSpline()).Value;
			case TSplineOption.IRangeSpline:
				return IRangeSpline.Pack(builder, _o.AsIRangeSpline()).Value;
			case TSplineOption.ISwordRiderRailSpline:
				return ISwordRiderRailSpline.Pack(builder, _o.AsISwordRiderRailSpline()).Value;
			case TSplineOption.ITimePatrolSpline:
				return ITimePatrolSpline.Pack(builder, _o.AsITimePatrolSpline()).Value;
			case TSplineOption.IWaySpline:
				return IWaySpline.Pack(builder, _o.AsIWaySpline()).Value;
			default:
				return 0;
			}
		}
	}
}
