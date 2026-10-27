using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007772 RID: 30578
	public class TSceneActorEventUnion
	{
		// Token: 0x1700E68F RID: 59023
		// (get) Token: 0x0603787C RID: 227452 RVA: 0x00783CFE File Offset: 0x00781EFE
		// (set) Token: 0x0603787D RID: 227453 RVA: 0x00783D06 File Offset: 0x00781F06
		public TSceneActorEvent Type { get; set; }

		// Token: 0x1700E690 RID: 59024
		// (get) Token: 0x0603787E RID: 227454 RVA: 0x00783D0F File Offset: 0x00781F0F
		// (set) Token: 0x0603787F RID: 227455 RVA: 0x00783D17 File Offset: 0x00781F17
		public object Value { get; set; }

		// Token: 0x06037880 RID: 227456 RVA: 0x00783D20 File Offset: 0x00781F20
		public TSceneActorEventUnion()
		{
			this.Type = TSceneActorEvent.NONE;
			this.Value = null;
		}

		// Token: 0x06037881 RID: 227457 RVA: 0x00783D36 File Offset: 0x00781F36
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037882 RID: 227458 RVA: 0x00783D48 File Offset: 0x00781F48
		public ISceneActorMusicLightsEventT AsISceneActorMusicLightsEvent()
		{
			return this.As<ISceneActorMusicLightsEventT>();
		}

		// Token: 0x06037883 RID: 227459 RVA: 0x00783D50 File Offset: 0x00781F50
		public static TSceneActorEventUnion FromISceneActorMusicLightsEvent(ISceneActorMusicLightsEventT _isceneactormusiclightsevent)
		{
			return new TSceneActorEventUnion
			{
				Type = TSceneActorEvent.ISceneActorMusicLightsEvent,
				Value = _isceneactormusiclightsevent
			};
		}

		// Token: 0x06037884 RID: 227460 RVA: 0x00783D65 File Offset: 0x00781F65
		public ISceneActorMusicPlantsEventT AsISceneActorMusicPlantsEvent()
		{
			return this.As<ISceneActorMusicPlantsEventT>();
		}

		// Token: 0x06037885 RID: 227461 RVA: 0x00783D6D File Offset: 0x00781F6D
		public static TSceneActorEventUnion FromISceneActorMusicPlantsEvent(ISceneActorMusicPlantsEventT _isceneactormusicplantsevent)
		{
			return new TSceneActorEventUnion
			{
				Type = TSceneActorEvent.ISceneActorMusicPlantsEvent,
				Value = _isceneactormusicplantsevent
			};
		}

		// Token: 0x06037886 RID: 227462 RVA: 0x00783D82 File Offset: 0x00781F82
		public ISceneActorProjection3dTo2dEventT AsISceneActorProjection3dTo2dEvent()
		{
			return this.As<ISceneActorProjection3dTo2dEventT>();
		}

		// Token: 0x06037887 RID: 227463 RVA: 0x00783D8A File Offset: 0x00781F8A
		public static TSceneActorEventUnion FromISceneActorProjection3dTo2dEvent(ISceneActorProjection3dTo2dEventT _isceneactorprojection3dto2devent)
		{
			return new TSceneActorEventUnion
			{
				Type = TSceneActorEvent.ISceneActorProjection3dTo2dEvent,
				Value = _isceneactorprojection3dto2devent
			};
		}

		// Token: 0x06037888 RID: 227464 RVA: 0x00783DA0 File Offset: 0x00781FA0
		public static int Pack(FlatBufferBuilder builder, TSceneActorEventUnion _o)
		{
			switch (_o.Type)
			{
			case TSceneActorEvent.ISceneActorMusicLightsEvent:
				return ISceneActorMusicLightsEvent.Pack(builder, _o.AsISceneActorMusicLightsEvent()).Value;
			case TSceneActorEvent.ISceneActorMusicPlantsEvent:
				return ISceneActorMusicPlantsEvent.Pack(builder, _o.AsISceneActorMusicPlantsEvent()).Value;
			case TSceneActorEvent.ISceneActorProjection3dTo2dEvent:
				return ISceneActorProjection3dTo2dEvent.Pack(builder, _o.AsISceneActorProjection3dTo2dEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
