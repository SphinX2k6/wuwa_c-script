using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773E RID: 30526
	public struct ISendSceneActorEvent : IFlatbufferObject
	{
		// Token: 0x1700DFC7 RID: 57287
		// (get) Token: 0x060358F1 RID: 219377 RVA: 0x0072DBC8 File Offset: 0x0072BDC8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060358F2 RID: 219378 RVA: 0x0072DBD5 File Offset: 0x0072BDD5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060358F3 RID: 219379 RVA: 0x0072DBDC File Offset: 0x0072BDDC
		public static ISendSceneActorEvent GetRootAsISendSceneActorEvent(ByteBuffer _bb)
		{
			return ISendSceneActorEvent.GetRootAsISendSceneActorEvent(_bb, default(ISendSceneActorEvent));
		}

		// Token: 0x060358F4 RID: 219380 RVA: 0x0072DBF8 File Offset: 0x0072BDF8
		public static ISendSceneActorEvent GetRootAsISendSceneActorEvent(ByteBuffer _bb, ISendSceneActorEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060358F5 RID: 219381 RVA: 0x0072DC15 File Offset: 0x0072BE15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060358F6 RID: 219382 RVA: 0x0072DC24 File Offset: 0x0072BE24
		public ISendSceneActorEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DFC8 RID: 57288
		// (get) Token: 0x060358F7 RID: 219383 RVA: 0x0072DC34 File Offset: 0x0072BE34
		public TSceneActorEvent ActorEventType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSceneActorEvent.NONE;
				}
				return (TSceneActorEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060358F8 RID: 219384 RVA: 0x0072DC70 File Offset: 0x0072BE70
		public TTable? ActorEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060358F9 RID: 219385 RVA: 0x0072DCB4 File Offset: 0x0072BEB4
		public ISceneActorMusicLightsEvent ActorEventAsISceneActorMusicLightsEvent()
		{
			return this.ActorEvent<ISceneActorMusicLightsEvent>().Value;
		}

		// Token: 0x060358FA RID: 219386 RVA: 0x0072DCD0 File Offset: 0x0072BED0
		public ISceneActorMusicPlantsEvent ActorEventAsISceneActorMusicPlantsEvent()
		{
			return this.ActorEvent<ISceneActorMusicPlantsEvent>().Value;
		}

		// Token: 0x060358FB RID: 219387 RVA: 0x0072DCEC File Offset: 0x0072BEEC
		public ISceneActorProjection3dTo2dEvent ActorEventAsISceneActorProjection3dTo2dEvent()
		{
			return this.ActorEvent<ISceneActorProjection3dTo2dEvent>().Value;
		}

		// Token: 0x060358FC RID: 219388 RVA: 0x0072DD07 File Offset: 0x0072BF07
		public static Offset<ISendSceneActorEvent> CreateISendSceneActorEvent(FlatBufferBuilder builder, TSceneActorEvent ActorEvent_type = TSceneActorEvent.NONE, int ActorEventOffset = 0)
		{
			builder.StartTable(2);
			ISendSceneActorEvent.AddActorEvent(builder, ActorEventOffset);
			ISendSceneActorEvent.AddActorEventType(builder, ActorEvent_type);
			return ISendSceneActorEvent.EndISendSceneActorEvent(builder);
		}

		// Token: 0x060358FD RID: 219389 RVA: 0x0072DD24 File Offset: 0x0072BF24
		public static void StartISendSceneActorEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060358FE RID: 219390 RVA: 0x0072DD2D File Offset: 0x0072BF2D
		public static void AddActorEventType(FlatBufferBuilder builder, TSceneActorEvent actorEventType)
		{
			builder.AddByte(0, (byte)actorEventType, 0);
		}

		// Token: 0x060358FF RID: 219391 RVA: 0x0072DD38 File Offset: 0x0072BF38
		public static void AddActorEvent(FlatBufferBuilder builder, int actorEventOffset)
		{
			builder.AddOffset(1, actorEventOffset, 0);
		}

		// Token: 0x06035900 RID: 219392 RVA: 0x0072DD43 File Offset: 0x0072BF43
		public static Offset<ISendSceneActorEvent> EndISendSceneActorEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISendSceneActorEvent>(builder.EndTable());
		}

		// Token: 0x06035901 RID: 219393 RVA: 0x0072DD50 File Offset: 0x0072BF50
		public ISendSceneActorEventT UnPack()
		{
			ISendSceneActorEventT sendSceneActorEventT = new ISendSceneActorEventT();
			this.UnPackTo(sendSceneActorEventT);
			return sendSceneActorEventT;
		}

		// Token: 0x06035902 RID: 219394 RVA: 0x0072DD6C File Offset: 0x0072BF6C
		public void UnPackTo(ISendSceneActorEventT _o)
		{
			_o.ActorEvent = new TSceneActorEventUnion();
			_o.ActorEvent.Type = this.ActorEventType;
			switch (this.ActorEventType)
			{
			case TSceneActorEvent.ISceneActorMusicLightsEvent:
				_o.ActorEvent.Value = ((this.ActorEvent<ISceneActorMusicLightsEvent>() != null) ? this.ActorEvent<ISceneActorMusicLightsEvent>().Value.UnPack() : null);
				return;
			case TSceneActorEvent.ISceneActorMusicPlantsEvent:
				_o.ActorEvent.Value = ((this.ActorEvent<ISceneActorMusicPlantsEvent>() != null) ? this.ActorEvent<ISceneActorMusicPlantsEvent>().Value.UnPack() : null);
				return;
			case TSceneActorEvent.ISceneActorProjection3dTo2dEvent:
				_o.ActorEvent.Value = ((this.ActorEvent<ISceneActorProjection3dTo2dEvent>() != null) ? this.ActorEvent<ISceneActorProjection3dTo2dEvent>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06035903 RID: 219395 RVA: 0x0072DE54 File Offset: 0x0072C054
		public static Offset<ISendSceneActorEvent> Pack(FlatBufferBuilder builder, ISendSceneActorEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendSceneActorEvent>);
			}
			TSceneActorEvent actorEvent_type = (_o.ActorEvent == null) ? TSceneActorEvent.NONE : _o.ActorEvent.Type;
			int actorEventOffset = (_o.ActorEvent == null) ? 0 : TSceneActorEventUnion.Pack(builder, _o.ActorEvent);
			return ISendSceneActorEvent.CreateISendSceneActorEvent(builder, actorEvent_type, actorEventOffset);
		}

		// Token: 0x04012957 RID: 76119
		private Table __p;
	}
}
