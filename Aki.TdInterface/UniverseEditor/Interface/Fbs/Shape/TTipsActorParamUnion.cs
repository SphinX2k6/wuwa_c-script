using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C7D RID: 15485
	public class TTipsActorParamUnion
	{
		// Token: 0x17006AC2 RID: 27330
		// (get) Token: 0x060156F3 RID: 87795 RVA: 0x00318FFC File Offset: 0x003171FC
		// (set) Token: 0x060156F4 RID: 87796 RVA: 0x00319004 File Offset: 0x00317204
		public TTipsActorParam Type { get; set; }

		// Token: 0x17006AC3 RID: 27331
		// (get) Token: 0x060156F5 RID: 87797 RVA: 0x0031900D File Offset: 0x0031720D
		// (set) Token: 0x060156F6 RID: 87798 RVA: 0x00319015 File Offset: 0x00317215
		public object Value { get; set; }

		// Token: 0x060156F7 RID: 87799 RVA: 0x0031901E File Offset: 0x0031721E
		public TTipsActorParamUnion()
		{
			this.Type = TTipsActorParam.NONE;
			this.Value = null;
		}

		// Token: 0x060156F8 RID: 87800 RVA: 0x00319034 File Offset: 0x00317234
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060156F9 RID: 87801 RVA: 0x00319046 File Offset: 0x00317246
		public IBottomAlignSemiBoxTipsActorT AsIBottomAlignSemiBoxTipsActor()
		{
			return this.As<IBottomAlignSemiBoxTipsActorT>();
		}

		// Token: 0x060156FA RID: 87802 RVA: 0x0031904E File Offset: 0x0031724E
		public static TTipsActorParamUnion FromIBottomAlignSemiBoxTipsActor(IBottomAlignSemiBoxTipsActorT _ibottomalignsemiboxtipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IBottomAlignSemiBoxTipsActor,
				Value = _ibottomalignsemiboxtipsactor
			};
		}

		// Token: 0x060156FB RID: 87803 RVA: 0x00319063 File Offset: 0x00317263
		public IBoxTipsActorT AsIBoxTipsActor()
		{
			return this.As<IBoxTipsActorT>();
		}

		// Token: 0x060156FC RID: 87804 RVA: 0x0031906B File Offset: 0x0031726B
		public static TTipsActorParamUnion FromIBoxTipsActor(IBoxTipsActorT _iboxtipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IBoxTipsActor,
				Value = _iboxtipsactor
			};
		}

		// Token: 0x060156FD RID: 87805 RVA: 0x00319080 File Offset: 0x00317280
		public IConeTipsActorT AsIConeTipsActor()
		{
			return this.As<IConeTipsActorT>();
		}

		// Token: 0x060156FE RID: 87806 RVA: 0x00319088 File Offset: 0x00317288
		public static TTipsActorParamUnion FromIConeTipsActor(IConeTipsActorT _iconetipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IConeTipsActor,
				Value = _iconetipsactor
			};
		}

		// Token: 0x060156FF RID: 87807 RVA: 0x0031909D File Offset: 0x0031729D
		public ICylinderSectorTipsActorT AsICylinderSectorTipsActor()
		{
			return this.As<ICylinderSectorTipsActorT>();
		}

		// Token: 0x06015700 RID: 87808 RVA: 0x003190A5 File Offset: 0x003172A5
		public static TTipsActorParamUnion FromICylinderSectorTipsActor(ICylinderSectorTipsActorT _icylindersectortipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ICylinderSectorTipsActor,
				Value = _icylindersectortipsactor
			};
		}

		// Token: 0x06015701 RID: 87809 RVA: 0x003190BA File Offset: 0x003172BA
		public ICylinderTipsActorT AsICylinderTipsActor()
		{
			return this.As<ICylinderTipsActorT>();
		}

		// Token: 0x06015702 RID: 87810 RVA: 0x003190C2 File Offset: 0x003172C2
		public static TTipsActorParamUnion FromICylinderTipsActor(ICylinderTipsActorT _icylindertipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ICylinderTipsActor,
				Value = _icylindertipsactor
			};
		}

		// Token: 0x06015703 RID: 87811 RVA: 0x003190D7 File Offset: 0x003172D7
		public IGraphLineTipsActorT AsIGraphLineTipsActor()
		{
			return this.As<IGraphLineTipsActorT>();
		}

		// Token: 0x06015704 RID: 87812 RVA: 0x003190DF File Offset: 0x003172DF
		public static TTipsActorParamUnion FromIGraphLineTipsActor(IGraphLineTipsActorT _igraphlinetipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IGraphLineTipsActor,
				Value = _igraphlinetipsactor
			};
		}

		// Token: 0x06015705 RID: 87813 RVA: 0x003190F4 File Offset: 0x003172F4
		public IGraphPointTipsActorT AsIGraphPointTipsActor()
		{
			return this.As<IGraphPointTipsActorT>();
		}

		// Token: 0x06015706 RID: 87814 RVA: 0x003190FC File Offset: 0x003172FC
		public static TTipsActorParamUnion FromIGraphPointTipsActor(IGraphPointTipsActorT _igraphpointtipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IGraphPointTipsActor,
				Value = _igraphpointtipsactor
			};
		}

		// Token: 0x06015707 RID: 87815 RVA: 0x00319111 File Offset: 0x00317311
		public IHollowCylinderTipsActorT AsIHollowCylinderTipsActor()
		{
			return this.As<IHollowCylinderTipsActorT>();
		}

		// Token: 0x06015708 RID: 87816 RVA: 0x00319119 File Offset: 0x00317319
		public static TTipsActorParamUnion FromIHollowCylinderTipsActor(IHollowCylinderTipsActorT _ihollowcylindertipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IHollowCylinderTipsActor,
				Value = _ihollowcylindertipsactor
			};
		}

		// Token: 0x06015709 RID: 87817 RVA: 0x0031912E File Offset: 0x0031732E
		public IHollowSphereTipsActorT AsIHollowSphereTipsActor()
		{
			return this.As<IHollowSphereTipsActorT>();
		}

		// Token: 0x0601570A RID: 87818 RVA: 0x00319136 File Offset: 0x00317336
		public static TTipsActorParamUnion FromIHollowSphereTipsActor(IHollowSphereTipsActorT _ihollowspheretipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IHollowSphereTipsActor,
				Value = _ihollowspheretipsactor
			};
		}

		// Token: 0x0601570B RID: 87819 RVA: 0x0031914C File Offset: 0x0031734C
		public ILaserTipsActorT AsILaserTipsActor()
		{
			return this.As<ILaserTipsActorT>();
		}

		// Token: 0x0601570C RID: 87820 RVA: 0x00319154 File Offset: 0x00317354
		public static TTipsActorParamUnion FromILaserTipsActor(ILaserTipsActorT _ilasertipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ILaserTipsActor,
				Value = _ilasertipsactor
			};
		}

		// Token: 0x0601570D RID: 87821 RVA: 0x0031916A File Offset: 0x0031736A
		public ISectorTipsActorT AsISectorTipsActor()
		{
			return this.As<ISectorTipsActorT>();
		}

		// Token: 0x0601570E RID: 87822 RVA: 0x00319172 File Offset: 0x00317372
		public static TTipsActorParamUnion FromISectorTipsActor(ISectorTipsActorT _isectortipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISectorTipsActor,
				Value = _isectortipsactor
			};
		}

		// Token: 0x0601570F RID: 87823 RVA: 0x00319188 File Offset: 0x00317388
		public ISphereTipsActorT AsISphereTipsActor()
		{
			return this.As<ISphereTipsActorT>();
		}

		// Token: 0x06015710 RID: 87824 RVA: 0x00319190 File Offset: 0x00317390
		public static TTipsActorParamUnion FromISphereTipsActor(ISphereTipsActorT _ispheretipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISphereTipsActor,
				Value = _ispheretipsactor
			};
		}

		// Token: 0x06015711 RID: 87825 RVA: 0x003191A6 File Offset: 0x003173A6
		public ISplineEffectTipsActorT AsISplineEffectTipsActor()
		{
			return this.As<ISplineEffectTipsActorT>();
		}

		// Token: 0x06015712 RID: 87826 RVA: 0x003191AE File Offset: 0x003173AE
		public static TTipsActorParamUnion FromISplineEffectTipsActor(ISplineEffectTipsActorT _isplineeffecttipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISplineEffectTipsActor,
				Value = _isplineeffecttipsactor
			};
		}

		// Token: 0x06015713 RID: 87827 RVA: 0x003191C4 File Offset: 0x003173C4
		public ISplineTipsActorT AsISplineTipsActor()
		{
			return this.As<ISplineTipsActorT>();
		}

		// Token: 0x06015714 RID: 87828 RVA: 0x003191CC File Offset: 0x003173CC
		public static TTipsActorParamUnion FromISplineTipsActor(ISplineTipsActorT _isplinetipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISplineTipsActor,
				Value = _isplinetipsactor
			};
		}

		// Token: 0x06015715 RID: 87829 RVA: 0x003191E2 File Offset: 0x003173E2
		public ISpotlightTipsActorT AsISpotlightTipsActor()
		{
			return this.As<ISpotlightTipsActorT>();
		}

		// Token: 0x06015716 RID: 87830 RVA: 0x003191EA File Offset: 0x003173EA
		public static TTipsActorParamUnion FromISpotlightTipsActor(ISpotlightTipsActorT _ispotlighttipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISpotlightTipsActor,
				Value = _ispotlighttipsactor
			};
		}

		// Token: 0x06015717 RID: 87831 RVA: 0x00319200 File Offset: 0x00317400
		public ITargetPointTipsActorT AsITargetPointTipsActor()
		{
			return this.As<ITargetPointTipsActorT>();
		}

		// Token: 0x06015718 RID: 87832 RVA: 0x00319208 File Offset: 0x00317408
		public static TTipsActorParamUnion FromITargetPointTipsActor(ITargetPointTipsActorT _itargetpointtipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ITargetPointTipsActor,
				Value = _itargetpointtipsactor
			};
		}

		// Token: 0x06015719 RID: 87833 RVA: 0x0031921E File Offset: 0x0031741E
		public ITrackTipsActorT AsITrackTipsActor()
		{
			return this.As<ITrackTipsActorT>();
		}

		// Token: 0x0601571A RID: 87834 RVA: 0x00319226 File Offset: 0x00317426
		public static TTipsActorParamUnion FromITrackTipsActor(ITrackTipsActorT _itracktipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ITrackTipsActor,
				Value = _itracktipsactor
			};
		}

		// Token: 0x0601571B RID: 87835 RVA: 0x0031923C File Offset: 0x0031743C
		public static int Pack(FlatBufferBuilder builder, TTipsActorParamUnion _o)
		{
			switch (_o.Type)
			{
			case TTipsActorParam.IBottomAlignSemiBoxTipsActor:
				return IBottomAlignSemiBoxTipsActor.Pack(builder, _o.AsIBottomAlignSemiBoxTipsActor()).Value;
			case TTipsActorParam.IBoxTipsActor:
				return IBoxTipsActor.Pack(builder, _o.AsIBoxTipsActor()).Value;
			case TTipsActorParam.IConeTipsActor:
				return IConeTipsActor.Pack(builder, _o.AsIConeTipsActor()).Value;
			case TTipsActorParam.ICylinderSectorTipsActor:
				return ICylinderSectorTipsActor.Pack(builder, _o.AsICylinderSectorTipsActor()).Value;
			case TTipsActorParam.ICylinderTipsActor:
				return ICylinderTipsActor.Pack(builder, _o.AsICylinderTipsActor()).Value;
			case TTipsActorParam.IGraphLineTipsActor:
				return IGraphLineTipsActor.Pack(builder, _o.AsIGraphLineTipsActor()).Value;
			case TTipsActorParam.IGraphPointTipsActor:
				return IGraphPointTipsActor.Pack(builder, _o.AsIGraphPointTipsActor()).Value;
			case TTipsActorParam.IHollowCylinderTipsActor:
				return IHollowCylinderTipsActor.Pack(builder, _o.AsIHollowCylinderTipsActor()).Value;
			case TTipsActorParam.IHollowSphereTipsActor:
				return IHollowSphereTipsActor.Pack(builder, _o.AsIHollowSphereTipsActor()).Value;
			case TTipsActorParam.ILaserTipsActor:
				return ILaserTipsActor.Pack(builder, _o.AsILaserTipsActor()).Value;
			case TTipsActorParam.ISectorTipsActor:
				return ISectorTipsActor.Pack(builder, _o.AsISectorTipsActor()).Value;
			case TTipsActorParam.ISphereTipsActor:
				return ISphereTipsActor.Pack(builder, _o.AsISphereTipsActor()).Value;
			case TTipsActorParam.ISplineEffectTipsActor:
				return ISplineEffectTipsActor.Pack(builder, _o.AsISplineEffectTipsActor()).Value;
			case TTipsActorParam.ISplineTipsActor:
				return ISplineTipsActor.Pack(builder, _o.AsISplineTipsActor()).Value;
			case TTipsActorParam.ISpotlightTipsActor:
				return ISpotlightTipsActor.Pack(builder, _o.AsISpotlightTipsActor()).Value;
			case TTipsActorParam.ITargetPointTipsActor:
				return ITargetPointTipsActor.Pack(builder, _o.AsITargetPointTipsActor()).Value;
			case TTipsActorParam.ITrackTipsActor:
				return ITrackTipsActor.Pack(builder, _o.AsITrackTipsActor()).Value;
			default:
				return 0;
			}
		}
	}
}
