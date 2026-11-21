using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A29 RID: 27177
	public struct IClientEventUiPlayPiano : IFlatbufferObject
	{
		// Token: 0x1700C7C3 RID: 51139
		// (get) Token: 0x0602E9E9 RID: 190953 RVA: 0x0065B434 File Offset: 0x00659634
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E9EA RID: 190954 RVA: 0x0065B441 File Offset: 0x00659641
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E9EB RID: 190955 RVA: 0x0065B448 File Offset: 0x00659648
		public static IClientEventUiPlayPiano GetRootAsIClientEventUiPlayPiano(ByteBuffer _bb)
		{
			return IClientEventUiPlayPiano.GetRootAsIClientEventUiPlayPiano(_bb, default(IClientEventUiPlayPiano));
		}

		// Token: 0x0602E9EC RID: 190956 RVA: 0x0065B464 File Offset: 0x00659664
		public static IClientEventUiPlayPiano GetRootAsIClientEventUiPlayPiano(ByteBuffer _bb, IClientEventUiPlayPiano obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E9ED RID: 190957 RVA: 0x0065B481 File Offset: 0x00659681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E9EE RID: 190958 RVA: 0x0065B490 File Offset: 0x00659690
		public IClientEventUiPlayPiano __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7C4 RID: 51140
		// (get) Token: 0x0602E9EF RID: 190959 RVA: 0x0065B4A0 File Offset: 0x006596A0
		public EClientEventUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventUiType.PlayPiano;
				}
				return (EClientEventUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7C5 RID: 51141
		// (get) Token: 0x0602E9F0 RID: 190960 RVA: 0x0065B4DC File Offset: 0x006596DC
		public TClientEventPianoEvent EventTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TClientEventPianoEvent.NONE;
				}
				return (TClientEventPianoEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E9F1 RID: 190961 RVA: 0x0065B518 File Offset: 0x00659718
		public TTable? EventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E9F2 RID: 190962 RVA: 0x0065B55C File Offset: 0x0065975C
		public IClientEventPianoSwitchPhase EventTypeAsIClientEventPianoSwitchPhase()
		{
			return this.EventType<IClientEventPianoSwitchPhase>().Value;
		}

		// Token: 0x0602E9F3 RID: 190963 RVA: 0x0065B578 File Offset: 0x00659778
		public IClientEventPianoUpdateSubtitle EventTypeAsIClientEventPianoUpdateSubtitle()
		{
			return this.EventType<IClientEventPianoUpdateSubtitle>().Value;
		}

		// Token: 0x0602E9F4 RID: 190964 RVA: 0x0065B593 File Offset: 0x00659793
		public static Offset<IClientEventUiPlayPiano> CreateIClientEventUiPlayPiano(FlatBufferBuilder builder, EClientEventUiType Type = EClientEventUiType.PlayPiano, TClientEventPianoEvent EventType_type = TClientEventPianoEvent.NONE, int EventTypeOffset = 0)
		{
			builder.StartTable(3);
			IClientEventUiPlayPiano.AddEventType(builder, EventTypeOffset);
			IClientEventUiPlayPiano.AddEventTypeType(builder, EventType_type);
			IClientEventUiPlayPiano.AddType(builder, Type);
			return IClientEventUiPlayPiano.EndIClientEventUiPlayPiano(builder);
		}

		// Token: 0x0602E9F5 RID: 190965 RVA: 0x0065B5B7 File Offset: 0x006597B7
		public static void StartIClientEventUiPlayPiano(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E9F6 RID: 190966 RVA: 0x0065B5C0 File Offset: 0x006597C0
		public static void AddType(FlatBufferBuilder builder, EClientEventUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E9F7 RID: 190967 RVA: 0x0065B5CB File Offset: 0x006597CB
		public static void AddEventTypeType(FlatBufferBuilder builder, TClientEventPianoEvent eventTypeType)
		{
			builder.AddByte(1, (byte)eventTypeType, 0);
		}

		// Token: 0x0602E9F8 RID: 190968 RVA: 0x0065B5D6 File Offset: 0x006597D6
		public static void AddEventType(FlatBufferBuilder builder, int eventTypeOffset)
		{
			builder.AddOffset(2, eventTypeOffset, 0);
		}

		// Token: 0x0602E9F9 RID: 190969 RVA: 0x0065B5E1 File Offset: 0x006597E1
		public static Offset<IClientEventUiPlayPiano> EndIClientEventUiPlayPiano(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventUiPlayPiano>(builder.EndTable());
		}

		// Token: 0x0602E9FA RID: 190970 RVA: 0x0065B5F0 File Offset: 0x006597F0
		public IClientEventUiPlayPianoT UnPack()
		{
			IClientEventUiPlayPianoT clientEventUiPlayPianoT = new IClientEventUiPlayPianoT();
			this.UnPackTo(clientEventUiPlayPianoT);
			return clientEventUiPlayPianoT;
		}

		// Token: 0x0602E9FB RID: 190971 RVA: 0x0065B60C File Offset: 0x0065980C
		public void UnPackTo(IClientEventUiPlayPianoT _o)
		{
			_o.Type = this.Type;
			_o.EventType = new TClientEventPianoEventUnion();
			_o.EventType.Type = this.EventTypeType;
			TClientEventPianoEvent eventTypeType = this.EventTypeType;
			if (eventTypeType == TClientEventPianoEvent.IClientEventPianoSwitchPhase)
			{
				_o.EventType.Value = ((this.EventType<IClientEventPianoSwitchPhase>() != null) ? this.EventType<IClientEventPianoSwitchPhase>().Value.UnPack() : null);
				return;
			}
			if (eventTypeType != TClientEventPianoEvent.IClientEventPianoUpdateSubtitle)
			{
				return;
			}
			_o.EventType.Value = ((this.EventType<IClientEventPianoUpdateSubtitle>() != null) ? this.EventType<IClientEventPianoUpdateSubtitle>().Value.UnPack() : null);
		}

		// Token: 0x0602E9FC RID: 190972 RVA: 0x0065B6BC File Offset: 0x006598BC
		public static Offset<IClientEventUiPlayPiano> Pack(FlatBufferBuilder builder, IClientEventUiPlayPianoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventUiPlayPiano>);
			}
			TClientEventPianoEvent eventType_type = (_o.EventType == null) ? TClientEventPianoEvent.NONE : _o.EventType.Type;
			int eventTypeOffset = (_o.EventType == null) ? 0 : TClientEventPianoEventUnion.Pack(builder, _o.EventType);
			return IClientEventUiPlayPiano.CreateIClientEventUiPlayPiano(builder, _o.Type, eventType_type, eventTypeOffset);
		}

		// Token: 0x040117A1 RID: 71585
		private Table __p;
	}
}
