using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CAC RID: 23724
	public class TSplineOptionUnion
	{
		// Token: 0x1700B250 RID: 45648
		// (get) Token: 0x060289DD RID: 166365 RVA: 0x00594FCA File Offset: 0x005931CA
		// (set) Token: 0x060289DE RID: 166366 RVA: 0x00594FD2 File Offset: 0x005931D2
		public TSplineOption Type { get; set; }

		// Token: 0x1700B251 RID: 45649
		// (get) Token: 0x060289DF RID: 166367 RVA: 0x00594FDB File Offset: 0x005931DB
		// (set) Token: 0x060289E0 RID: 166368 RVA: 0x00594FE3 File Offset: 0x005931E3
		public object Value { get; set; }

		// Token: 0x060289E1 RID: 166369 RVA: 0x00594FEC File Offset: 0x005931EC
		public TSplineOptionUnion()
		{
			this.Type = TSplineOption.NONE;
			this.Value = null;
		}

		// Token: 0x060289E2 RID: 166370 RVA: 0x00595002 File Offset: 0x00593202
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060289E3 RID: 166371 RVA: 0x00595014 File Offset: 0x00593214
		public IAirPassageSplineT AsIAirPassageSpline()
		{
			return this.As<IAirPassageSplineT>();
		}

		// Token: 0x060289E4 RID: 166372 RVA: 0x0059501C File Offset: 0x0059321C
		public static TSplineOptionUnion FromIAirPassageSpline(IAirPassageSplineT _iairpassagespline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IAirPassageSpline,
				Value = _iairpassagespline
			};
		}

		// Token: 0x060289E5 RID: 166373 RVA: 0x00595031 File Offset: 0x00593231
		public IButterflySplineT AsIButterflySpline()
		{
			return this.As<IButterflySplineT>();
		}

		// Token: 0x060289E6 RID: 166374 RVA: 0x00595039 File Offset: 0x00593239
		public static TSplineOptionUnion FromIButterflySpline(IButterflySplineT _ibutterflyspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IButterflySpline,
				Value = _ibutterflyspline
			};
		}

		// Token: 0x060289E7 RID: 166375 RVA: 0x0059504E File Offset: 0x0059324E
		public ICommonSplineT AsICommonSpline()
		{
			return this.As<ICommonSplineT>();
		}

		// Token: 0x060289E8 RID: 166376 RVA: 0x00595056 File Offset: 0x00593256
		public static TSplineOptionUnion FromICommonSpline(ICommonSplineT _icommonspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.ICommonSpline,
				Value = _icommonspline
			};
		}

		// Token: 0x060289E9 RID: 166377 RVA: 0x0059506B File Offset: 0x0059326B
		public IContinuesVariableSpeedMovementSplineT AsIContinuesVariableSpeedMovementSpline()
		{
			return this.As<IContinuesVariableSpeedMovementSplineT>();
		}

		// Token: 0x060289EA RID: 166378 RVA: 0x00595073 File Offset: 0x00593273
		public static TSplineOptionUnion FromIContinuesVariableSpeedMovementSpline(IContinuesVariableSpeedMovementSplineT _icontinuesvariablespeedmovementspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IContinuesVariableSpeedMovementSpline,
				Value = _icontinuesvariablespeedmovementspline
			};
		}

		// Token: 0x060289EB RID: 166379 RVA: 0x00595088 File Offset: 0x00593288
		public IEffectSplineT AsIEffectSpline()
		{
			return this.As<IEffectSplineT>();
		}

		// Token: 0x060289EC RID: 166380 RVA: 0x00595090 File Offset: 0x00593290
		public static TSplineOptionUnion FromIEffectSpline(IEffectSplineT _ieffectspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IEffectSpline,
				Value = _ieffectspline
			};
		}

		// Token: 0x060289ED RID: 166381 RVA: 0x005950A5 File Offset: 0x005932A5
		public ILevelAISplineT AsILevelAISpline()
		{
			return this.As<ILevelAISplineT>();
		}

		// Token: 0x060289EE RID: 166382 RVA: 0x005950AD File Offset: 0x005932AD
		public static TSplineOptionUnion FromILevelAISpline(ILevelAISplineT _ilevelaispline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.ILevelAISpline,
				Value = _ilevelaispline
			};
		}

		// Token: 0x060289EF RID: 166383 RVA: 0x005950C2 File Offset: 0x005932C2
		public IMotorSlideSplineT AsIMotorSlideSpline()
		{
			return this.As<IMotorSlideSplineT>();
		}

		// Token: 0x060289F0 RID: 166384 RVA: 0x005950CA File Offset: 0x005932CA
		public static TSplineOptionUnion FromIMotorSlideSpline(IMotorSlideSplineT _imotorslidespline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IMotorSlideSpline,
				Value = _imotorslidespline
			};
		}

		// Token: 0x060289F1 RID: 166385 RVA: 0x005950DF File Offset: 0x005932DF
		public IParkourSplineT AsIParkourSpline()
		{
			return this.As<IParkourSplineT>();
		}

		// Token: 0x060289F2 RID: 166386 RVA: 0x005950E7 File Offset: 0x005932E7
		public static TSplineOptionUnion FromIParkourSpline(IParkourSplineT _iparkourspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IParkourSpline,
				Value = _iparkourspline
			};
		}

		// Token: 0x060289F3 RID: 166387 RVA: 0x005950FC File Offset: 0x005932FC
		public IPatrolSplineT AsIPatrolSpline()
		{
			return this.As<IPatrolSplineT>();
		}

		// Token: 0x060289F4 RID: 166388 RVA: 0x00595104 File Offset: 0x00593304
		public static TSplineOptionUnion FromIPatrolSpline(IPatrolSplineT _ipatrolspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IPatrolSpline,
				Value = _ipatrolspline
			};
		}

		// Token: 0x060289F5 RID: 166389 RVA: 0x0059511A File Offset: 0x0059331A
		public IRangeSplineT AsIRangeSpline()
		{
			return this.As<IRangeSplineT>();
		}

		// Token: 0x060289F6 RID: 166390 RVA: 0x00595122 File Offset: 0x00593322
		public static TSplineOptionUnion FromIRangeSpline(IRangeSplineT _irangespline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IRangeSpline,
				Value = _irangespline
			};
		}

		// Token: 0x060289F7 RID: 166391 RVA: 0x00595138 File Offset: 0x00593338
		public ISwordRiderRailSplineT AsISwordRiderRailSpline()
		{
			return this.As<ISwordRiderRailSplineT>();
		}

		// Token: 0x060289F8 RID: 166392 RVA: 0x00595140 File Offset: 0x00593340
		public static TSplineOptionUnion FromISwordRiderRailSpline(ISwordRiderRailSplineT _iswordriderrailspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.ISwordRiderRailSpline,
				Value = _iswordriderrailspline
			};
		}

		// Token: 0x060289F9 RID: 166393 RVA: 0x00595156 File Offset: 0x00593356
		public ITimePatrolSplineT AsITimePatrolSpline()
		{
			return this.As<ITimePatrolSplineT>();
		}

		// Token: 0x060289FA RID: 166394 RVA: 0x0059515E File Offset: 0x0059335E
		public static TSplineOptionUnion FromITimePatrolSpline(ITimePatrolSplineT _itimepatrolspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.ITimePatrolSpline,
				Value = _itimepatrolspline
			};
		}

		// Token: 0x060289FB RID: 166395 RVA: 0x00595174 File Offset: 0x00593374
		public IWaySplineT AsIWaySpline()
		{
			return this.As<IWaySplineT>();
		}

		// Token: 0x060289FC RID: 166396 RVA: 0x0059517C File Offset: 0x0059337C
		public static TSplineOptionUnion FromIWaySpline(IWaySplineT _iwayspline)
		{
			return new TSplineOptionUnion
			{
				Type = TSplineOption.IWaySpline,
				Value = _iwayspline
			};
		}

		// Token: 0x060289FD RID: 166397 RVA: 0x00595194 File Offset: 0x00593394
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
