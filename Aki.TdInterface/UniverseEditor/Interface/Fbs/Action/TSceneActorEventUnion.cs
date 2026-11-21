using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F9E RID: 32670
	public class TSceneActorEventUnion
	{
		// Token: 0x1700F2E1 RID: 62177
		// (get) Token: 0x0603ADC5 RID: 241093 RVA: 0x007E8DCE File Offset: 0x007E6FCE
		// (set) Token: 0x0603ADC6 RID: 241094 RVA: 0x007E8DD6 File Offset: 0x007E6FD6
		public TSceneActorEvent Type { get; set; }

		// Token: 0x1700F2E2 RID: 62178
		// (get) Token: 0x0603ADC7 RID: 241095 RVA: 0x007E8DDF File Offset: 0x007E6FDF
		// (set) Token: 0x0603ADC8 RID: 241096 RVA: 0x007E8DE7 File Offset: 0x007E6FE7
		public object Value { get; set; }

		// Token: 0x0603ADC9 RID: 241097 RVA: 0x007E8DF0 File Offset: 0x007E6FF0
		public TSceneActorEventUnion()
		{
			this.Type = TSceneActorEvent.NONE;
			this.Value = null;
		}

		// Token: 0x0603ADCA RID: 241098 RVA: 0x007E8E06 File Offset: 0x007E7006
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ADCB RID: 241099 RVA: 0x007E8E18 File Offset: 0x007E7018
		public ISceneActorMusicLightsEventT AsISceneActorMusicLightsEvent()
		{
			return this.As<ISceneActorMusicLightsEventT>();
		}

		// Token: 0x0603ADCC RID: 241100 RVA: 0x007E8E20 File Offset: 0x007E7020
		public static TSceneActorEventUnion FromISceneActorMusicLightsEvent(ISceneActorMusicLightsEventT _isceneactormusiclightsevent)
		{
			return new TSceneActorEventUnion
			{
				Type = TSceneActorEvent.ISceneActorMusicLightsEvent,
				Value = _isceneactormusiclightsevent
			};
		}

		// Token: 0x0603ADCD RID: 241101 RVA: 0x007E8E35 File Offset: 0x007E7035
		public ISceneActorMusicPlantsEventT AsISceneActorMusicPlantsEvent()
		{
			return this.As<ISceneActorMusicPlantsEventT>();
		}

		// Token: 0x0603ADCE RID: 241102 RVA: 0x007E8E3D File Offset: 0x007E703D
		public static TSceneActorEventUnion FromISceneActorMusicPlantsEvent(ISceneActorMusicPlantsEventT _isceneactormusicplantsevent)
		{
			return new TSceneActorEventUnion
			{
				Type = TSceneActorEvent.ISceneActorMusicPlantsEvent,
				Value = _isceneactormusicplantsevent
			};
		}

		// Token: 0x0603ADCF RID: 241103 RVA: 0x007E8E52 File Offset: 0x007E7052
		public ISceneActorProjection3dTo2dEventT AsISceneActorProjection3dTo2dEvent()
		{
			return this.As<ISceneActorProjection3dTo2dEventT>();
		}

		// Token: 0x0603ADD0 RID: 241104 RVA: 0x007E8E5A File Offset: 0x007E705A
		public static TSceneActorEventUnion FromISceneActorProjection3dTo2dEvent(ISceneActorProjection3dTo2dEventT _isceneactorprojection3dto2devent)
		{
			return new TSceneActorEventUnion
			{
				Type = TSceneActorEvent.ISceneActorProjection3dTo2dEvent,
				Value = _isceneactorprojection3dto2devent
			};
		}

		// Token: 0x0603ADD1 RID: 241105 RVA: 0x007E8E70 File Offset: 0x007E7070
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
