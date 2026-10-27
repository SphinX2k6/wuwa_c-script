using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F22 RID: 28450
	public class ISceneActorEvent_UnionUnion
	{
		// Token: 0x1700D37C RID: 54140
		// (get) Token: 0x06032433 RID: 205875 RVA: 0x006CA1A9 File Offset: 0x006C83A9
		// (set) Token: 0x06032434 RID: 205876 RVA: 0x006CA1B1 File Offset: 0x006C83B1
		public ISceneActorEvent_Union Type { get; set; }

		// Token: 0x1700D37D RID: 54141
		// (get) Token: 0x06032435 RID: 205877 RVA: 0x006CA1BA File Offset: 0x006C83BA
		// (set) Token: 0x06032436 RID: 205878 RVA: 0x006CA1C2 File Offset: 0x006C83C2
		public object Value { get; set; }

		// Token: 0x06032437 RID: 205879 RVA: 0x006CA1CB File Offset: 0x006C83CB
		public ISceneActorEvent_UnionUnion()
		{
			this.Type = ISceneActorEvent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032438 RID: 205880 RVA: 0x006CA1E1 File Offset: 0x006C83E1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032439 RID: 205881 RVA: 0x006CA1F3 File Offset: 0x006C83F3
		public ISceneActorEventT AsISceneActorEvent()
		{
			return this.As<ISceneActorEventT>();
		}

		// Token: 0x0603243A RID: 205882 RVA: 0x006CA1FB File Offset: 0x006C83FB
		public static ISceneActorEvent_UnionUnion FromISceneActorEvent(ISceneActorEventT _isceneactorevent)
		{
			return new ISceneActorEvent_UnionUnion
			{
				Type = ISceneActorEvent_Union.ISceneActorEvent,
				Value = _isceneactorevent
			};
		}

		// Token: 0x0603243B RID: 205883 RVA: 0x006CA210 File Offset: 0x006C8410
		public ISceneActorMusicPlantsEventT AsISceneActorMusicPlantsEvent()
		{
			return this.As<ISceneActorMusicPlantsEventT>();
		}

		// Token: 0x0603243C RID: 205884 RVA: 0x006CA218 File Offset: 0x006C8418
		public static ISceneActorEvent_UnionUnion FromISceneActorMusicPlantsEvent(ISceneActorMusicPlantsEventT _isceneactormusicplantsevent)
		{
			return new ISceneActorEvent_UnionUnion
			{
				Type = ISceneActorEvent_Union.ISceneActorMusicPlantsEvent,
				Value = _isceneactormusicplantsevent
			};
		}

		// Token: 0x0603243D RID: 205885 RVA: 0x006CA22D File Offset: 0x006C842D
		public ISceneActorMusicLightsEventT AsISceneActorMusicLightsEvent()
		{
			return this.As<ISceneActorMusicLightsEventT>();
		}

		// Token: 0x0603243E RID: 205886 RVA: 0x006CA235 File Offset: 0x006C8435
		public static ISceneActorEvent_UnionUnion FromISceneActorMusicLightsEvent(ISceneActorMusicLightsEventT _isceneactormusiclightsevent)
		{
			return new ISceneActorEvent_UnionUnion
			{
				Type = ISceneActorEvent_Union.ISceneActorMusicLightsEvent,
				Value = _isceneactormusiclightsevent
			};
		}

		// Token: 0x0603243F RID: 205887 RVA: 0x006CA24A File Offset: 0x006C844A
		public ISceneActorProjection3dTo2dEventT AsISceneActorProjection3dTo2dEvent()
		{
			return this.As<ISceneActorProjection3dTo2dEventT>();
		}

		// Token: 0x06032440 RID: 205888 RVA: 0x006CA252 File Offset: 0x006C8452
		public static ISceneActorEvent_UnionUnion FromISceneActorProjection3dTo2dEvent(ISceneActorProjection3dTo2dEventT _isceneactorprojection3dto2devent)
		{
			return new ISceneActorEvent_UnionUnion
			{
				Type = ISceneActorEvent_Union.ISceneActorProjection3dTo2dEvent,
				Value = _isceneactorprojection3dto2devent
			};
		}

		// Token: 0x06032441 RID: 205889 RVA: 0x006CA268 File Offset: 0x006C8468
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
