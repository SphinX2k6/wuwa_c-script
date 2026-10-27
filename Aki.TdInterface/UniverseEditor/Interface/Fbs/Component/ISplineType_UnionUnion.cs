using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200598A RID: 22922
	public class ISplineType_UnionUnion
	{
		// Token: 0x1700AC03 RID: 44035
		// (get) Token: 0x06026CFC RID: 158972 RVA: 0x00557AE5 File Offset: 0x00555CE5
		// (set) Token: 0x06026CFD RID: 158973 RVA: 0x00557AED File Offset: 0x00555CED
		public ISplineType_Union Type { get; set; }

		// Token: 0x1700AC04 RID: 44036
		// (get) Token: 0x06026CFE RID: 158974 RVA: 0x00557AF6 File Offset: 0x00555CF6
		// (set) Token: 0x06026CFF RID: 158975 RVA: 0x00557AFE File Offset: 0x00555CFE
		public object Value { get; set; }

		// Token: 0x06026D00 RID: 158976 RVA: 0x00557B07 File Offset: 0x00555D07
		public ISplineType_UnionUnion()
		{
			this.Type = ISplineType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026D01 RID: 158977 RVA: 0x00557B1D File Offset: 0x00555D1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026D02 RID: 158978 RVA: 0x00557B2F File Offset: 0x00555D2F
		public ISplineTypeT AsISplineType()
		{
			return this.As<ISplineTypeT>();
		}

		// Token: 0x06026D03 RID: 158979 RVA: 0x00557B37 File Offset: 0x00555D37
		public static ISplineType_UnionUnion FromISplineType(ISplineTypeT _isplinetype)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ISplineType,
				Value = _isplinetype
			};
		}

		// Token: 0x06026D04 RID: 158980 RVA: 0x00557B4C File Offset: 0x00555D4C
		public ICommonSplineT AsICommonSpline()
		{
			return this.As<ICommonSplineT>();
		}

		// Token: 0x06026D05 RID: 158981 RVA: 0x00557B54 File Offset: 0x00555D54
		public static ISplineType_UnionUnion FromICommonSpline(ICommonSplineT _icommonspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ICommonSpline,
				Value = _icommonspline
			};
		}

		// Token: 0x06026D06 RID: 158982 RVA: 0x00557B69 File Offset: 0x00555D69
		public IParkourSplineT AsIParkourSpline()
		{
			return this.As<IParkourSplineT>();
		}

		// Token: 0x06026D07 RID: 158983 RVA: 0x00557B71 File Offset: 0x00555D71
		public static ISplineType_UnionUnion FromIParkourSpline(IParkourSplineT _iparkourspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IParkourSpline,
				Value = _iparkourspline
			};
		}

		// Token: 0x06026D08 RID: 158984 RVA: 0x00557B86 File Offset: 0x00555D86
		public IButterflySplineT AsIButterflySpline()
		{
			return this.As<IButterflySplineT>();
		}

		// Token: 0x06026D09 RID: 158985 RVA: 0x00557B8E File Offset: 0x00555D8E
		public static ISplineType_UnionUnion FromIButterflySpline(IButterflySplineT _ibutterflyspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IButterflySpline,
				Value = _ibutterflyspline
			};
		}

		// Token: 0x06026D0A RID: 158986 RVA: 0x00557BA3 File Offset: 0x00555DA3
		public IEffectSplineT AsIEffectSpline()
		{
			return this.As<IEffectSplineT>();
		}

		// Token: 0x06026D0B RID: 158987 RVA: 0x00557BAB File Offset: 0x00555DAB
		public static ISplineType_UnionUnion FromIEffectSpline(IEffectSplineT _ieffectspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IEffectSpline,
				Value = _ieffectspline
			};
		}

		// Token: 0x06026D0C RID: 158988 RVA: 0x00557BC0 File Offset: 0x00555DC0
		public IPatrolSplineT AsIPatrolSpline()
		{
			return this.As<IPatrolSplineT>();
		}

		// Token: 0x06026D0D RID: 158989 RVA: 0x00557BC8 File Offset: 0x00555DC8
		public static ISplineType_UnionUnion FromIPatrolSpline(IPatrolSplineT _ipatrolspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IPatrolSpline,
				Value = _ipatrolspline
			};
		}

		// Token: 0x06026D0E RID: 158990 RVA: 0x00557BDD File Offset: 0x00555DDD
		public ILevelAISplineT AsILevelAISpline()
		{
			return this.As<ILevelAISplineT>();
		}

		// Token: 0x06026D0F RID: 158991 RVA: 0x00557BE5 File Offset: 0x00555DE5
		public static ISplineType_UnionUnion FromILevelAISpline(ILevelAISplineT _ilevelaispline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ILevelAISpline,
				Value = _ilevelaispline
			};
		}

		// Token: 0x06026D10 RID: 158992 RVA: 0x00557BFA File Offset: 0x00555DFA
		public IAirPassageSplineT AsIAirPassageSpline()
		{
			return this.As<IAirPassageSplineT>();
		}

		// Token: 0x06026D11 RID: 158993 RVA: 0x00557C02 File Offset: 0x00555E02
		public static ISplineType_UnionUnion FromIAirPassageSpline(IAirPassageSplineT _iairpassagespline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IAirPassageSpline,
				Value = _iairpassagespline
			};
		}

		// Token: 0x06026D12 RID: 158994 RVA: 0x00557C17 File Offset: 0x00555E17
		public IContinuesVariableSpeedMovementSplineT AsIContinuesVariableSpeedMovementSpline()
		{
			return this.As<IContinuesVariableSpeedMovementSplineT>();
		}

		// Token: 0x06026D13 RID: 158995 RVA: 0x00557C1F File Offset: 0x00555E1F
		public static ISplineType_UnionUnion FromIContinuesVariableSpeedMovementSpline(IContinuesVariableSpeedMovementSplineT _icontinuesvariablespeedmovementspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IContinuesVariableSpeedMovementSpline,
				Value = _icontinuesvariablespeedmovementspline
			};
		}

		// Token: 0x06026D14 RID: 158996 RVA: 0x00557C35 File Offset: 0x00555E35
		public ITimePatrolSplineT AsITimePatrolSpline()
		{
			return this.As<ITimePatrolSplineT>();
		}

		// Token: 0x06026D15 RID: 158997 RVA: 0x00557C3D File Offset: 0x00555E3D
		public static ISplineType_UnionUnion FromITimePatrolSpline(ITimePatrolSplineT _itimepatrolspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ITimePatrolSpline,
				Value = _itimepatrolspline
			};
		}

		// Token: 0x06026D16 RID: 158998 RVA: 0x00557C53 File Offset: 0x00555E53
		public IRangeSplineT AsIRangeSpline()
		{
			return this.As<IRangeSplineT>();
		}

		// Token: 0x06026D17 RID: 158999 RVA: 0x00557C5B File Offset: 0x00555E5B
		public static ISplineType_UnionUnion FromIRangeSpline(IRangeSplineT _irangespline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IRangeSpline,
				Value = _irangespline
			};
		}

		// Token: 0x06026D18 RID: 159000 RVA: 0x00557C71 File Offset: 0x00555E71
		public IWaySplineT AsIWaySpline()
		{
			return this.As<IWaySplineT>();
		}

		// Token: 0x06026D19 RID: 159001 RVA: 0x00557C79 File Offset: 0x00555E79
		public static ISplineType_UnionUnion FromIWaySpline(IWaySplineT _iwayspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IWaySpline,
				Value = _iwayspline
			};
		}

		// Token: 0x06026D1A RID: 159002 RVA: 0x00557C8F File Offset: 0x00555E8F
		public IMotorSlideSplineT AsIMotorSlideSpline()
		{
			return this.As<IMotorSlideSplineT>();
		}

		// Token: 0x06026D1B RID: 159003 RVA: 0x00557C97 File Offset: 0x00555E97
		public static ISplineType_UnionUnion FromIMotorSlideSpline(IMotorSlideSplineT _imotorslidespline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IMotorSlideSpline,
				Value = _imotorslidespline
			};
		}

		// Token: 0x06026D1C RID: 159004 RVA: 0x00557CAD File Offset: 0x00555EAD
		public ISwordRiderRailSplineT AsISwordRiderRailSpline()
		{
			return this.As<ISwordRiderRailSplineT>();
		}

		// Token: 0x06026D1D RID: 159005 RVA: 0x00557CB5 File Offset: 0x00555EB5
		public static ISplineType_UnionUnion FromISwordRiderRailSpline(ISwordRiderRailSplineT _iswordriderrailspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ISwordRiderRailSpline,
				Value = _iswordriderrailspline
			};
		}

		// Token: 0x06026D1E RID: 159006 RVA: 0x00557CCC File Offset: 0x00555ECC
		public static int Pack(FlatBufferBuilder builder, ISplineType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISplineType_Union.ISplineType:
				return ISplineType.Pack(builder, _o.AsISplineType()).Value;
			case ISplineType_Union.ICommonSpline:
				return ICommonSpline.Pack(builder, _o.AsICommonSpline()).Value;
			case ISplineType_Union.IParkourSpline:
				return IParkourSpline.Pack(builder, _o.AsIParkourSpline()).Value;
			case ISplineType_Union.IButterflySpline:
				return IButterflySpline.Pack(builder, _o.AsIButterflySpline()).Value;
			case ISplineType_Union.IEffectSpline:
				return IEffectSpline.Pack(builder, _o.AsIEffectSpline()).Value;
			case ISplineType_Union.IPatrolSpline:
				return IPatrolSpline.Pack(builder, _o.AsIPatrolSpline()).Value;
			case ISplineType_Union.ILevelAISpline:
				return ILevelAISpline.Pack(builder, _o.AsILevelAISpline()).Value;
			case ISplineType_Union.IAirPassageSpline:
				return IAirPassageSpline.Pack(builder, _o.AsIAirPassageSpline()).Value;
			case ISplineType_Union.IContinuesVariableSpeedMovementSpline:
				return IContinuesVariableSpeedMovementSpline.Pack(builder, _o.AsIContinuesVariableSpeedMovementSpline()).Value;
			case ISplineType_Union.ITimePatrolSpline:
				return ITimePatrolSpline.Pack(builder, _o.AsITimePatrolSpline()).Value;
			case ISplineType_Union.IRangeSpline:
				return IRangeSpline.Pack(builder, _o.AsIRangeSpline()).Value;
			case ISplineType_Union.IWaySpline:
				return IWaySpline.Pack(builder, _o.AsIWaySpline()).Value;
			case ISplineType_Union.IMotorSlideSpline:
				return IMotorSlideSpline.Pack(builder, _o.AsIMotorSlideSpline()).Value;
			case ISplineType_Union.ISwordRiderRailSpline:
				return ISwordRiderRailSpline.Pack(builder, _o.AsISwordRiderRailSpline()).Value;
			default:
				return 0;
			}
		}
	}
}
