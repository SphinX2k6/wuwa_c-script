using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F78 RID: 28536
	public struct ISendSceneActorEvent : IFlatbufferObject
	{
		// Token: 0x1700D3F8 RID: 54264
		// (get) Token: 0x060326A1 RID: 206497 RVA: 0x006CE210 File Offset: 0x006CC410
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060326A2 RID: 206498 RVA: 0x006CE21D File Offset: 0x006CC41D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060326A3 RID: 206499 RVA: 0x006CE224 File Offset: 0x006CC424
		public static ISendSceneActorEvent GetRootAsISendSceneActorEvent(ByteBuffer _bb)
		{
			return ISendSceneActorEvent.GetRootAsISendSceneActorEvent(_bb, default(ISendSceneActorEvent));
		}

		// Token: 0x060326A4 RID: 206500 RVA: 0x006CE240 File Offset: 0x006CC440
		public static ISendSceneActorEvent GetRootAsISendSceneActorEvent(ByteBuffer _bb, ISendSceneActorEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060326A5 RID: 206501 RVA: 0x006CE25D File Offset: 0x006CC45D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060326A6 RID: 206502 RVA: 0x006CE26C File Offset: 0x006CC46C
		public ISendSceneActorEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3F9 RID: 54265
		// (get) Token: 0x060326A7 RID: 206503 RVA: 0x006CE27C File Offset: 0x006CC47C
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

		// Token: 0x060326A8 RID: 206504 RVA: 0x006CE2B8 File Offset: 0x006CC4B8
		public TTable? ActorEvent<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060326A9 RID: 206505 RVA: 0x006CE2FC File Offset: 0x006CC4FC
		public ISceneActorMusicLightsEvent ActorEventAsISceneActorMusicLightsEvent()
		{
			return this.ActorEvent<ISceneActorMusicLightsEvent>().Value;
		}

		// Token: 0x060326AA RID: 206506 RVA: 0x006CE318 File Offset: 0x006CC518
		public ISceneActorMusicPlantsEvent ActorEventAsISceneActorMusicPlantsEvent()
		{
			return this.ActorEvent<ISceneActorMusicPlantsEvent>().Value;
		}

		// Token: 0x060326AB RID: 206507 RVA: 0x006CE334 File Offset: 0x006CC534
		public ISceneActorProjection3dTo2dEvent ActorEventAsISceneActorProjection3dTo2dEvent()
		{
			return this.ActorEvent<ISceneActorProjection3dTo2dEvent>().Value;
		}

		// Token: 0x060326AC RID: 206508 RVA: 0x006CE34F File Offset: 0x006CC54F
		public static Offset<ISendSceneActorEvent> CreateISendSceneActorEvent(FlatBufferBuilder builder, TSceneActorEvent ActorEvent_type = TSceneActorEvent.NONE, int ActorEventOffset = 0)
		{
			builder.StartTable(2);
			ISendSceneActorEvent.AddActorEvent(builder, ActorEventOffset);
			ISendSceneActorEvent.AddActorEventType(builder, ActorEvent_type);
			return ISendSceneActorEvent.EndISendSceneActorEvent(builder);
		}

		// Token: 0x060326AD RID: 206509 RVA: 0x006CE36C File Offset: 0x006CC56C
		public static void StartISendSceneActorEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060326AE RID: 206510 RVA: 0x006CE375 File Offset: 0x006CC575
		public static void AddActorEventType(FlatBufferBuilder builder, TSceneActorEvent actorEventType)
		{
			builder.AddByte(0, (byte)actorEventType, 0);
		}

		// Token: 0x060326AF RID: 206511 RVA: 0x006CE380 File Offset: 0x006CC580
		public static void AddActorEvent(FlatBufferBuilder builder, int actorEventOffset)
		{
			builder.AddOffset(1, actorEventOffset, 0);
		}

		// Token: 0x060326B0 RID: 206512 RVA: 0x006CE38B File Offset: 0x006CC58B
		public static Offset<ISendSceneActorEvent> EndISendSceneActorEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISendSceneActorEvent>(builder.EndTable());
		}

		// Token: 0x060326B1 RID: 206513 RVA: 0x006CE398 File Offset: 0x006CC598
		public ISendSceneActorEventT UnPack()
		{
			ISendSceneActorEventT sendSceneActorEventT = new ISendSceneActorEventT();
			this.UnPackTo(sendSceneActorEventT);
			return sendSceneActorEventT;
		}

		// Token: 0x060326B2 RID: 206514 RVA: 0x006CE3B4 File Offset: 0x006CC5B4
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

		// Token: 0x060326B3 RID: 206515 RVA: 0x006CE49C File Offset: 0x006CC69C
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

		// Token: 0x04011975 RID: 72053
		private Table __p;
	}
}
