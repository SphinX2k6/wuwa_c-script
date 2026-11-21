using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F97 RID: 24471
	public class ISplineType_UnionUnion
	{
		// Token: 0x1700B537 RID: 46391
		// (get) Token: 0x06029266 RID: 168550 RVA: 0x0059E751 File Offset: 0x0059C951
		// (set) Token: 0x06029267 RID: 168551 RVA: 0x0059E759 File Offset: 0x0059C959
		public ISplineType_Union Type { get; set; }

		// Token: 0x1700B538 RID: 46392
		// (get) Token: 0x06029268 RID: 168552 RVA: 0x0059E762 File Offset: 0x0059C962
		// (set) Token: 0x06029269 RID: 168553 RVA: 0x0059E76A File Offset: 0x0059C96A
		public object Value { get; set; }

		// Token: 0x0602926A RID: 168554 RVA: 0x0059E773 File Offset: 0x0059C973
		public ISplineType_UnionUnion()
		{
			this.Type = ISplineType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602926B RID: 168555 RVA: 0x0059E789 File Offset: 0x0059C989
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602926C RID: 168556 RVA: 0x0059E79B File Offset: 0x0059C99B
		public ISplineTypeT AsISplineType()
		{
			return this.As<ISplineTypeT>();
		}

		// Token: 0x0602926D RID: 168557 RVA: 0x0059E7A3 File Offset: 0x0059C9A3
		public static ISplineType_UnionUnion FromISplineType(ISplineTypeT _isplinetype)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ISplineType,
				Value = _isplinetype
			};
		}

		// Token: 0x0602926E RID: 168558 RVA: 0x0059E7B8 File Offset: 0x0059C9B8
		public ICommonSplineT AsICommonSpline()
		{
			return this.As<ICommonSplineT>();
		}

		// Token: 0x0602926F RID: 168559 RVA: 0x0059E7C0 File Offset: 0x0059C9C0
		public static ISplineType_UnionUnion FromICommonSpline(ICommonSplineT _icommonspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ICommonSpline,
				Value = _icommonspline
			};
		}

		// Token: 0x06029270 RID: 168560 RVA: 0x0059E7D5 File Offset: 0x0059C9D5
		public IParkourSplineT AsIParkourSpline()
		{
			return this.As<IParkourSplineT>();
		}

		// Token: 0x06029271 RID: 168561 RVA: 0x0059E7DD File Offset: 0x0059C9DD
		public static ISplineType_UnionUnion FromIParkourSpline(IParkourSplineT _iparkourspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IParkourSpline,
				Value = _iparkourspline
			};
		}

		// Token: 0x06029272 RID: 168562 RVA: 0x0059E7F2 File Offset: 0x0059C9F2
		public IButterflySplineT AsIButterflySpline()
		{
			return this.As<IButterflySplineT>();
		}

		// Token: 0x06029273 RID: 168563 RVA: 0x0059E7FA File Offset: 0x0059C9FA
		public static ISplineType_UnionUnion FromIButterflySpline(IButterflySplineT _ibutterflyspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IButterflySpline,
				Value = _ibutterflyspline
			};
		}

		// Token: 0x06029274 RID: 168564 RVA: 0x0059E80F File Offset: 0x0059CA0F
		public IEffectSplineT AsIEffectSpline()
		{
			return this.As<IEffectSplineT>();
		}

		// Token: 0x06029275 RID: 168565 RVA: 0x0059E817 File Offset: 0x0059CA17
		public static ISplineType_UnionUnion FromIEffectSpline(IEffectSplineT _ieffectspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IEffectSpline,
				Value = _ieffectspline
			};
		}

		// Token: 0x06029276 RID: 168566 RVA: 0x0059E82C File Offset: 0x0059CA2C
		public IPatrolSplineT AsIPatrolSpline()
		{
			return this.As<IPatrolSplineT>();
		}

		// Token: 0x06029277 RID: 168567 RVA: 0x0059E834 File Offset: 0x0059CA34
		public static ISplineType_UnionUnion FromIPatrolSpline(IPatrolSplineT _ipatrolspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IPatrolSpline,
				Value = _ipatrolspline
			};
		}

		// Token: 0x06029278 RID: 168568 RVA: 0x0059E849 File Offset: 0x0059CA49
		public ILevelAISplineT AsILevelAISpline()
		{
			return this.As<ILevelAISplineT>();
		}

		// Token: 0x06029279 RID: 168569 RVA: 0x0059E851 File Offset: 0x0059CA51
		public static ISplineType_UnionUnion FromILevelAISpline(ILevelAISplineT _ilevelaispline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ILevelAISpline,
				Value = _ilevelaispline
			};
		}

		// Token: 0x0602927A RID: 168570 RVA: 0x0059E866 File Offset: 0x0059CA66
		public IAirPassageSplineT AsIAirPassageSpline()
		{
			return this.As<IAirPassageSplineT>();
		}

		// Token: 0x0602927B RID: 168571 RVA: 0x0059E86E File Offset: 0x0059CA6E
		public static ISplineType_UnionUnion FromIAirPassageSpline(IAirPassageSplineT _iairpassagespline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IAirPassageSpline,
				Value = _iairpassagespline
			};
		}

		// Token: 0x0602927C RID: 168572 RVA: 0x0059E883 File Offset: 0x0059CA83
		public IContinuesVariableSpeedMovementSplineT AsIContinuesVariableSpeedMovementSpline()
		{
			return this.As<IContinuesVariableSpeedMovementSplineT>();
		}

		// Token: 0x0602927D RID: 168573 RVA: 0x0059E88B File Offset: 0x0059CA8B
		public static ISplineType_UnionUnion FromIContinuesVariableSpeedMovementSpline(IContinuesVariableSpeedMovementSplineT _icontinuesvariablespeedmovementspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IContinuesVariableSpeedMovementSpline,
				Value = _icontinuesvariablespeedmovementspline
			};
		}

		// Token: 0x0602927E RID: 168574 RVA: 0x0059E8A1 File Offset: 0x0059CAA1
		public ITimePatrolSplineT AsITimePatrolSpline()
		{
			return this.As<ITimePatrolSplineT>();
		}

		// Token: 0x0602927F RID: 168575 RVA: 0x0059E8A9 File Offset: 0x0059CAA9
		public static ISplineType_UnionUnion FromITimePatrolSpline(ITimePatrolSplineT _itimepatrolspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ITimePatrolSpline,
				Value = _itimepatrolspline
			};
		}

		// Token: 0x06029280 RID: 168576 RVA: 0x0059E8BF File Offset: 0x0059CABF
		public IRangeSplineT AsIRangeSpline()
		{
			return this.As<IRangeSplineT>();
		}

		// Token: 0x06029281 RID: 168577 RVA: 0x0059E8C7 File Offset: 0x0059CAC7
		public static ISplineType_UnionUnion FromIRangeSpline(IRangeSplineT _irangespline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IRangeSpline,
				Value = _irangespline
			};
		}

		// Token: 0x06029282 RID: 168578 RVA: 0x0059E8DD File Offset: 0x0059CADD
		public IWaySplineT AsIWaySpline()
		{
			return this.As<IWaySplineT>();
		}

		// Token: 0x06029283 RID: 168579 RVA: 0x0059E8E5 File Offset: 0x0059CAE5
		public static ISplineType_UnionUnion FromIWaySpline(IWaySplineT _iwayspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IWaySpline,
				Value = _iwayspline
			};
		}

		// Token: 0x06029284 RID: 168580 RVA: 0x0059E8FB File Offset: 0x0059CAFB
		public IMotorSlideSplineT AsIMotorSlideSpline()
		{
			return this.As<IMotorSlideSplineT>();
		}

		// Token: 0x06029285 RID: 168581 RVA: 0x0059E903 File Offset: 0x0059CB03
		public static ISplineType_UnionUnion FromIMotorSlideSpline(IMotorSlideSplineT _imotorslidespline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.IMotorSlideSpline,
				Value = _imotorslidespline
			};
		}

		// Token: 0x06029286 RID: 168582 RVA: 0x0059E919 File Offset: 0x0059CB19
		public ISwordRiderRailSplineT AsISwordRiderRailSpline()
		{
			return this.As<ISwordRiderRailSplineT>();
		}

		// Token: 0x06029287 RID: 168583 RVA: 0x0059E921 File Offset: 0x0059CB21
		public static ISplineType_UnionUnion FromISwordRiderRailSpline(ISwordRiderRailSplineT _iswordriderrailspline)
		{
			return new ISplineType_UnionUnion
			{
				Type = ISplineType_Union.ISwordRiderRailSpline,
				Value = _iswordriderrailspline
			};
		}

		// Token: 0x06029288 RID: 168584 RVA: 0x0059E938 File Offset: 0x0059CB38
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
