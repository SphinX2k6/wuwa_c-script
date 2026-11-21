using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A9 RID: 30377
	public class ISceneActorEvent_UnionUnion
	{
		// Token: 0x1700DED8 RID: 57048
		// (get) Token: 0x0603548B RID: 218251 RVA: 0x00726111 File Offset: 0x00724311
		// (set) Token: 0x0603548C RID: 218252 RVA: 0x00726119 File Offset: 0x00724319
		public ISceneActorEvent_Union Type { get; set; }

		// Token: 0x1700DED9 RID: 57049
		// (get) Token: 0x0603548D RID: 218253 RVA: 0x00726122 File Offset: 0x00724322
		// (set) Token: 0x0603548E RID: 218254 RVA: 0x0072612A File Offset: 0x0072432A
		public object Value { get; set; }

		// Token: 0x0603548F RID: 218255 RVA: 0x00726133 File Offset: 0x00724333
		public ISceneActorEvent_UnionUnion()
		{
			this.Type = ISceneActorEvent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035490 RID: 218256 RVA: 0x00726149 File Offset: 0x00724349
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035491 RID: 218257 RVA: 0x0072615B File Offset: 0x0072435B
		public ISceneActorEventT AsISceneActorEvent()
		{
			return this.As<ISceneActorEventT>();
		}

		// Token: 0x06035492 RID: 218258 RVA: 0x00726163 File Offset: 0x00724363
		public static ISceneActorEvent_UnionUnion FromISceneActorEvent(ISceneActorEventT _isceneactorevent)
		{
			return new ISceneActorEvent_UnionUnion
			{
				Type = ISceneActorEvent_Union.ISceneActorEvent,
				Value = _isceneactorevent
			};
		}

		// Token: 0x06035493 RID: 218259 RVA: 0x00726178 File Offset: 0x00724378
		public ISceneActorMusicPlantsEventT AsISceneActorMusicPlantsEvent()
		{
			return this.As<ISceneActorMusicPlantsEventT>();
		}

		// Token: 0x06035494 RID: 218260 RVA: 0x00726180 File Offset: 0x00724380
		public static ISceneActorEvent_UnionUnion FromISceneActorMusicPlantsEvent(ISceneActorMusicPlantsEventT _isceneactormusicplantsevent)
		{
			return new ISceneActorEvent_UnionUnion
			{
				Type = ISceneActorEvent_Union.ISceneActorMusicPlantsEvent,
				Value = _isceneactormusicplantsevent
			};
		}

		// Token: 0x06035495 RID: 218261 RVA: 0x00726195 File Offset: 0x00724395
		public ISceneActorMusicLightsEventT AsISceneActorMusicLightsEvent()
		{
			return this.As<ISceneActorMusicLightsEventT>();
		}

		// Token: 0x06035496 RID: 218262 RVA: 0x0072619D File Offset: 0x0072439D
		public static ISceneActorEvent_UnionUnion FromISceneActorMusicLightsEvent(ISceneActorMusicLightsEventT _isceneactormusiclightsevent)
		{
			return new ISceneActorEvent_UnionUnion
			{
				Type = ISceneActorEvent_Union.ISceneActorMusicLightsEvent,
				Value = _isceneactormusiclightsevent
			};
		}

		// Token: 0x06035497 RID: 218263 RVA: 0x007261B2 File Offset: 0x007243B2
		public ISceneActorProjection3dTo2dEventT AsISceneActorProjection3dTo2dEvent()
		{
			return this.As<ISceneActorProjection3dTo2dEventT>();
		}

		// Token: 0x06035498 RID: 218264 RVA: 0x007261BA File Offset: 0x007243BA
		public static ISceneActorEvent_UnionUnion FromISceneActorProjection3dTo2dEvent(ISceneActorProjection3dTo2dEventT _isceneactorprojection3dto2devent)
		{
			return new ISceneActorEvent_UnionUnion
			{
				Type = ISceneActorEvent_Union.ISceneActorProjection3dTo2dEvent,
				Value = _isceneactorprojection3dto2devent
			};
		}

		// Token: 0x06035499 RID: 218265 RVA: 0x007261D0 File Offset: 0x007243D0
		public static int Pack(FlatBufferBuilder builder, ISceneActorEvent_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneActorEvent_Union.ISceneActorEvent:
				return ISceneActorEvent.Pack(builder, _o.AsISceneActorEvent()).Value;
			case ISceneActorEvent_Union.ISceneActorMusicPlantsEvent:
				return ISceneActorMusicPlantsEvent.Pack(builder, _o.AsISceneActorMusicPlantsEvent()).Value;
			case ISceneActorEvent_Union.ISceneActorMusicLightsEvent:
				return ISceneActorMusicLightsEvent.Pack(builder, _o.AsISceneActorMusicLightsEvent()).Value;
			case ISceneActorEvent_Union.ISceneActorProjection3dTo2dEvent:
				return ISceneActorProjection3dTo2dEvent.Pack(builder, _o.AsISceneActorProjection3dTo2dEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
