using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200408F RID: 16527
	public class TTipsActorParamUnion
	{
		// Token: 0x1700707C RID: 28796
		// (get) Token: 0x06016C27 RID: 93223 RVA: 0x003401E8 File Offset: 0x0033E3E8
		// (set) Token: 0x06016C28 RID: 93224 RVA: 0x003401F0 File Offset: 0x0033E3F0
		public TTipsActorParam Type { get; set; }

		// Token: 0x1700707D RID: 28797
		// (get) Token: 0x06016C29 RID: 93225 RVA: 0x003401F9 File Offset: 0x0033E3F9
		// (set) Token: 0x06016C2A RID: 93226 RVA: 0x00340201 File Offset: 0x0033E401
		public object Value { get; set; }

		// Token: 0x06016C2B RID: 93227 RVA: 0x0034020A File Offset: 0x0033E40A
		public TTipsActorParamUnion()
		{
			this.Type = TTipsActorParam.NONE;
			this.Value = null;
		}

		// Token: 0x06016C2C RID: 93228 RVA: 0x00340220 File Offset: 0x0033E420
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016C2D RID: 93229 RVA: 0x00340232 File Offset: 0x0033E432
		public IBottomAlignSemiBoxTipsActorT AsIBottomAlignSemiBoxTipsActor()
		{
			return this.As<IBottomAlignSemiBoxTipsActorT>();
		}

		// Token: 0x06016C2E RID: 93230 RVA: 0x0034023A File Offset: 0x0033E43A
		public static TTipsActorParamUnion FromIBottomAlignSemiBoxTipsActor(IBottomAlignSemiBoxTipsActorT _ibottomalignsemiboxtipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IBottomAlignSemiBoxTipsActor,
				Value = _ibottomalignsemiboxtipsactor
			};
		}

		// Token: 0x06016C2F RID: 93231 RVA: 0x0034024F File Offset: 0x0033E44F
		public IBoxTipsActorT AsIBoxTipsActor()
		{
			return this.As<IBoxTipsActorT>();
		}

		// Token: 0x06016C30 RID: 93232 RVA: 0x00340257 File Offset: 0x0033E457
		public static TTipsActorParamUnion FromIBoxTipsActor(IBoxTipsActorT _iboxtipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IBoxTipsActor,
				Value = _iboxtipsactor
			};
		}

		// Token: 0x06016C31 RID: 93233 RVA: 0x0034026C File Offset: 0x0033E46C
		public IConeTipsActorT AsIConeTipsActor()
		{
			return this.As<IConeTipsActorT>();
		}

		// Token: 0x06016C32 RID: 93234 RVA: 0x00340274 File Offset: 0x0033E474
		public static TTipsActorParamUnion FromIConeTipsActor(IConeTipsActorT _iconetipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IConeTipsActor,
				Value = _iconetipsactor
			};
		}

		// Token: 0x06016C33 RID: 93235 RVA: 0x00340289 File Offset: 0x0033E489
		public ICylinderSectorTipsActorT AsICylinderSectorTipsActor()
		{
			return this.As<ICylinderSectorTipsActorT>();
		}

		// Token: 0x06016C34 RID: 93236 RVA: 0x00340291 File Offset: 0x0033E491
		public static TTipsActorParamUnion FromICylinderSectorTipsActor(ICylinderSectorTipsActorT _icylindersectortipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ICylinderSectorTipsActor,
				Value = _icylindersectortipsactor
			};
		}

		// Token: 0x06016C35 RID: 93237 RVA: 0x003402A6 File Offset: 0x0033E4A6
		public ICylinderTipsActorT AsICylinderTipsActor()
		{
			return this.As<ICylinderTipsActorT>();
		}

		// Token: 0x06016C36 RID: 93238 RVA: 0x003402AE File Offset: 0x0033E4AE
		public static TTipsActorParamUnion FromICylinderTipsActor(ICylinderTipsActorT _icylindertipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ICylinderTipsActor,
				Value = _icylindertipsactor
			};
		}

		// Token: 0x06016C37 RID: 93239 RVA: 0x003402C3 File Offset: 0x0033E4C3
		public IGraphLineTipsActorT AsIGraphLineTipsActor()
		{
			return this.As<IGraphLineTipsActorT>();
		}

		// Token: 0x06016C38 RID: 93240 RVA: 0x003402CB File Offset: 0x0033E4CB
		public static TTipsActorParamUnion FromIGraphLineTipsActor(IGraphLineTipsActorT _igraphlinetipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IGraphLineTipsActor,
				Value = _igraphlinetipsactor
			};
		}

		// Token: 0x06016C39 RID: 93241 RVA: 0x003402E0 File Offset: 0x0033E4E0
		public IGraphPointTipsActorT AsIGraphPointTipsActor()
		{
			return this.As<IGraphPointTipsActorT>();
		}

		// Token: 0x06016C3A RID: 93242 RVA: 0x003402E8 File Offset: 0x0033E4E8
		public static TTipsActorParamUnion FromIGraphPointTipsActor(IGraphPointTipsActorT _igraphpointtipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IGraphPointTipsActor,
				Value = _igraphpointtipsactor
			};
		}

		// Token: 0x06016C3B RID: 93243 RVA: 0x003402FD File Offset: 0x0033E4FD
		public IHollowCylinderTipsActorT AsIHollowCylinderTipsActor()
		{
			return this.As<IHollowCylinderTipsActorT>();
		}

		// Token: 0x06016C3C RID: 93244 RVA: 0x00340305 File Offset: 0x0033E505
		public static TTipsActorParamUnion FromIHollowCylinderTipsActor(IHollowCylinderTipsActorT _ihollowcylindertipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IHollowCylinderTipsActor,
				Value = _ihollowcylindertipsactor
			};
		}

		// Token: 0x06016C3D RID: 93245 RVA: 0x0034031A File Offset: 0x0033E51A
		public IHollowSphereTipsActorT AsIHollowSphereTipsActor()
		{
			return this.As<IHollowSphereTipsActorT>();
		}

		// Token: 0x06016C3E RID: 93246 RVA: 0x00340322 File Offset: 0x0033E522
		public static TTipsActorParamUnion FromIHollowSphereTipsActor(IHollowSphereTipsActorT _ihollowspheretipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.IHollowSphereTipsActor,
				Value = _ihollowspheretipsactor
			};
		}

		// Token: 0x06016C3F RID: 93247 RVA: 0x00340338 File Offset: 0x0033E538
		public ILaserTipsActorT AsILaserTipsActor()
		{
			return this.As<ILaserTipsActorT>();
		}

		// Token: 0x06016C40 RID: 93248 RVA: 0x00340340 File Offset: 0x0033E540
		public static TTipsActorParamUnion FromILaserTipsActor(ILaserTipsActorT _ilasertipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ILaserTipsActor,
				Value = _ilasertipsactor
			};
		}

		// Token: 0x06016C41 RID: 93249 RVA: 0x00340356 File Offset: 0x0033E556
		public INoiseBubbleTipsActorT AsINoiseBubbleTipsActor()
		{
			return this.As<INoiseBubbleTipsActorT>();
		}

		// Token: 0x06016C42 RID: 93250 RVA: 0x0034035E File Offset: 0x0033E55E
		public static TTipsActorParamUnion FromINoiseBubbleTipsActor(INoiseBubbleTipsActorT _inoisebubbletipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.INoiseBubbleTipsActor,
				Value = _inoisebubbletipsactor
			};
		}

		// Token: 0x06016C43 RID: 93251 RVA: 0x00340374 File Offset: 0x0033E574
		public ISectorTipsActorT AsISectorTipsActor()
		{
			return this.As<ISectorTipsActorT>();
		}

		// Token: 0x06016C44 RID: 93252 RVA: 0x0034037C File Offset: 0x0033E57C
		public static TTipsActorParamUnion FromISectorTipsActor(ISectorTipsActorT _isectortipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISectorTipsActor,
				Value = _isectortipsactor
			};
		}

		// Token: 0x06016C45 RID: 93253 RVA: 0x00340392 File Offset: 0x0033E592
		public ISphereTipsActorT AsISphereTipsActor()
		{
			return this.As<ISphereTipsActorT>();
		}

		// Token: 0x06016C46 RID: 93254 RVA: 0x0034039A File Offset: 0x0033E59A
		public static TTipsActorParamUnion FromISphereTipsActor(ISphereTipsActorT _ispheretipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISphereTipsActor,
				Value = _ispheretipsactor
			};
		}

		// Token: 0x06016C47 RID: 93255 RVA: 0x003403B0 File Offset: 0x0033E5B0
		public ISplineEffectTipsActorT AsISplineEffectTipsActor()
		{
			return this.As<ISplineEffectTipsActorT>();
		}

		// Token: 0x06016C48 RID: 93256 RVA: 0x003403B8 File Offset: 0x0033E5B8
		public static TTipsActorParamUnion FromISplineEffectTipsActor(ISplineEffectTipsActorT _isplineeffecttipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISplineEffectTipsActor,
				Value = _isplineeffecttipsactor
			};
		}

		// Token: 0x06016C49 RID: 93257 RVA: 0x003403CE File Offset: 0x0033E5CE
		public ISplineTipsActorT AsISplineTipsActor()
		{
			return this.As<ISplineTipsActorT>();
		}

		// Token: 0x06016C4A RID: 93258 RVA: 0x003403D6 File Offset: 0x0033E5D6
		public static TTipsActorParamUnion FromISplineTipsActor(ISplineTipsActorT _isplinetipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISplineTipsActor,
				Value = _isplinetipsactor
			};
		}

		// Token: 0x06016C4B RID: 93259 RVA: 0x003403EC File Offset: 0x0033E5EC
		public ISpotlightTipsActorT AsISpotlightTipsActor()
		{
			return this.As<ISpotlightTipsActorT>();
		}

		// Token: 0x06016C4C RID: 93260 RVA: 0x003403F4 File Offset: 0x0033E5F4
		public static TTipsActorParamUnion FromISpotlightTipsActor(ISpotlightTipsActorT _ispotlighttipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ISpotlightTipsActor,
				Value = _ispotlighttipsactor
			};
		}

		// Token: 0x06016C4D RID: 93261 RVA: 0x0034040A File Offset: 0x0033E60A
		public ITargetPointTipsActorT AsITargetPointTipsActor()
		{
			return this.As<ITargetPointTipsActorT>();
		}

		// Token: 0x06016C4E RID: 93262 RVA: 0x00340412 File Offset: 0x0033E612
		public static TTipsActorParamUnion FromITargetPointTipsActor(ITargetPointTipsActorT _itargetpointtipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ITargetPointTipsActor,
				Value = _itargetpointtipsactor
			};
		}

		// Token: 0x06016C4F RID: 93263 RVA: 0x00340428 File Offset: 0x0033E628
		public ITrackTipsActorT AsITrackTipsActor()
		{
			return this.As<ITrackTipsActorT>();
		}

		// Token: 0x06016C50 RID: 93264 RVA: 0x00340430 File Offset: 0x0033E630
		public static TTipsActorParamUnion FromITrackTipsActor(ITrackTipsActorT _itracktipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ITrackTipsActor,
				Value = _itracktipsactor
			};
		}

		// Token: 0x06016C51 RID: 93265 RVA: 0x00340446 File Offset: 0x0033E646
		public ITurntableConnectorTipsActorT AsITurntableConnectorTipsActor()
		{
			return this.As<ITurntableConnectorTipsActorT>();
		}

		// Token: 0x06016C52 RID: 93266 RVA: 0x0034044E File Offset: 0x0033E64E
		public static TTipsActorParamUnion FromITurntableConnectorTipsActor(ITurntableConnectorTipsActorT _iturntableconnectortipsactor)
		{
			return new TTipsActorParamUnion
			{
				Type = TTipsActorParam.ITurntableConnectorTipsActor,
				Value = _iturntableconnectortipsactor
			};
		}

		// Token: 0x06016C53 RID: 93267 RVA: 0x00340464 File Offset: 0x0033E664
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
			case TTipsActorParam.INoiseBubbleTipsActor:
				return INoiseBubbleTipsActor.Pack(builder, _o.AsINoiseBubbleTipsActor()).Value;
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
			case TTipsActorParam.ITurntableConnectorTipsActor:
				return ITurntableConnectorTipsActor.Pack(builder, _o.AsITurntableConnectorTipsActor()).Value;
			default:
				return 0;
			}
		}
	}
}
