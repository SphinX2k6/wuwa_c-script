using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B8 RID: 25528
	public struct IClientEventUiPlayPiano : IFlatbufferObject
	{
		// Token: 0x1700BE3F RID: 48703
		// (get) Token: 0x0602C287 RID: 180871 RVA: 0x006103FC File Offset: 0x0060E5FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C288 RID: 180872 RVA: 0x00610409 File Offset: 0x0060E609
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C289 RID: 180873 RVA: 0x00610410 File Offset: 0x0060E610
		public static IClientEventUiPlayPiano GetRootAsIClientEventUiPlayPiano(ByteBuffer _bb)
		{
			return IClientEventUiPlayPiano.GetRootAsIClientEventUiPlayPiano(_bb, default(IClientEventUiPlayPiano));
		}

		// Token: 0x0602C28A RID: 180874 RVA: 0x0061042C File Offset: 0x0060E62C
		public static IClientEventUiPlayPiano GetRootAsIClientEventUiPlayPiano(ByteBuffer _bb, IClientEventUiPlayPiano obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C28B RID: 180875 RVA: 0x00610449 File Offset: 0x0060E649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C28C RID: 180876 RVA: 0x00610458 File Offset: 0x0060E658
		public IClientEventUiPlayPiano __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE40 RID: 48704
		// (get) Token: 0x0602C28D RID: 180877 RVA: 0x00610468 File Offset: 0x0060E668
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

		// Token: 0x1700BE41 RID: 48705
		// (get) Token: 0x0602C28E RID: 180878 RVA: 0x006104A4 File Offset: 0x0060E6A4
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

		// Token: 0x0602C28F RID: 180879 RVA: 0x006104E0 File Offset: 0x0060E6E0
		public TTable? EventType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C290 RID: 180880 RVA: 0x00610524 File Offset: 0x0060E724
		public IClientEventPianoSwitchPhase EventTypeAsIClientEventPianoSwitchPhase()
		{
			return this.EventType<IClientEventPianoSwitchPhase>().Value;
		}

		// Token: 0x0602C291 RID: 180881 RVA: 0x00610540 File Offset: 0x0060E740
		public IClientEventPianoUpdateSubtitle EventTypeAsIClientEventPianoUpdateSubtitle()
		{
			return this.EventType<IClientEventPianoUpdateSubtitle>().Value;
		}

		// Token: 0x0602C292 RID: 180882 RVA: 0x0061055B File Offset: 0x0060E75B
		public static Offset<IClientEventUiPlayPiano> CreateIClientEventUiPlayPiano(FlatBufferBuilder builder, EClientEventUiType Type = EClientEventUiType.PlayPiano, TClientEventPianoEvent EventType_type = TClientEventPianoEvent.NONE, int EventTypeOffset = 0)
		{
			builder.StartTable(3);
			IClientEventUiPlayPiano.AddEventType(builder, EventTypeOffset);
			IClientEventUiPlayPiano.AddEventTypeType(builder, EventType_type);
			IClientEventUiPlayPiano.AddType(builder, Type);
			return IClientEventUiPlayPiano.EndIClientEventUiPlayPiano(builder);
		}

		// Token: 0x0602C293 RID: 180883 RVA: 0x0061057F File Offset: 0x0060E77F
		public static void StartIClientEventUiPlayPiano(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C294 RID: 180884 RVA: 0x00610588 File Offset: 0x0060E788
		public static void AddType(FlatBufferBuilder builder, EClientEventUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C295 RID: 180885 RVA: 0x00610593 File Offset: 0x0060E793
		public static void AddEventTypeType(FlatBufferBuilder builder, TClientEventPianoEvent eventTypeType)
		{
			builder.AddByte(1, (byte)eventTypeType, 0);
		}

		// Token: 0x0602C296 RID: 180886 RVA: 0x0061059E File Offset: 0x0060E79E
		public static void AddEventType(FlatBufferBuilder builder, int eventTypeOffset)
		{
			builder.AddOffset(2, eventTypeOffset, 0);
		}

		// Token: 0x0602C297 RID: 180887 RVA: 0x006105A9 File Offset: 0x0060E7A9
		public static Offset<IClientEventUiPlayPiano> EndIClientEventUiPlayPiano(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventUiPlayPiano>(builder.EndTable());
		}

		// Token: 0x0602C298 RID: 180888 RVA: 0x006105B8 File Offset: 0x0060E7B8
		public IClientEventUiPlayPianoT UnPack()
		{
			IClientEventUiPlayPianoT clientEventUiPlayPianoT = new IClientEventUiPlayPianoT();
			this.UnPackTo(clientEventUiPlayPianoT);
			return clientEventUiPlayPianoT;
		}

		// Token: 0x0602C299 RID: 180889 RVA: 0x006105D4 File Offset: 0x0060E7D4
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

		// Token: 0x0602C29A RID: 180890 RVA: 0x00610684 File Offset: 0x0060E884
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

		// Token: 0x0401098E RID: 67982
		private Table __p;
	}
}
