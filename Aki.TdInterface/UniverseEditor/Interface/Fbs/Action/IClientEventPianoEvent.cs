using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A0 RID: 25504
	public struct IClientEventPianoEvent : IFlatbufferObject
	{
		// Token: 0x1700BE23 RID: 48675
		// (get) Token: 0x0602C1F3 RID: 180723 RVA: 0x0060F5E4 File Offset: 0x0060D7E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C1F4 RID: 180724 RVA: 0x0060F5F1 File Offset: 0x0060D7F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C1F5 RID: 180725 RVA: 0x0060F5F8 File Offset: 0x0060D7F8
		public static IClientEventPianoEvent GetRootAsIClientEventPianoEvent(ByteBuffer _bb)
		{
			return IClientEventPianoEvent.GetRootAsIClientEventPianoEvent(_bb, default(IClientEventPianoEvent));
		}

		// Token: 0x0602C1F6 RID: 180726 RVA: 0x0060F614 File Offset: 0x0060D814
		public static IClientEventPianoEvent GetRootAsIClientEventPianoEvent(ByteBuffer _bb, IClientEventPianoEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C1F7 RID: 180727 RVA: 0x0060F631 File Offset: 0x0060D831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C1F8 RID: 180728 RVA: 0x0060F640 File Offset: 0x0060D840
		public IClientEventPianoEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE24 RID: 48676
		// (get) Token: 0x0602C1F9 RID: 180729 RVA: 0x0060F650 File Offset: 0x0060D850
		public EClientEventPianoEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventPianoEventType.UpdateSubtitle;
				}
				return (EClientEventPianoEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C1FA RID: 180730 RVA: 0x0060F68C File Offset: 0x0060D88C
		public static Offset<IClientEventPianoEvent> CreateIClientEventPianoEvent(FlatBufferBuilder builder, EClientEventPianoEventType Type = EClientEventPianoEventType.UpdateSubtitle)
		{
			builder.StartTable(1);
			IClientEventPianoEvent.AddType(builder, Type);
			return IClientEventPianoEvent.EndIClientEventPianoEvent(builder);
		}

		// Token: 0x0602C1FB RID: 180731 RVA: 0x0060F6A2 File Offset: 0x0060D8A2
		public static void StartIClientEventPianoEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C1FC RID: 180732 RVA: 0x0060F6AB File Offset: 0x0060D8AB
		public static void AddType(FlatBufferBuilder builder, EClientEventPianoEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C1FD RID: 180733 RVA: 0x0060F6B6 File Offset: 0x0060D8B6
		public static Offset<IClientEventPianoEvent> EndIClientEventPianoEvent(FlatBufferBuilder builder)
		{
			return new Offset<IClientEventPianoEvent>(builder.EndTable());
		}

		// Token: 0x0602C1FE RID: 180734 RVA: 0x0060F6C4 File Offset: 0x0060D8C4
		public IClientEventPianoEventT UnPack()
		{
			IClientEventPianoEventT clientEventPianoEventT = new IClientEventPianoEventT();
			this.UnPackTo(clientEventPianoEventT);
			return clientEventPianoEventT;
		}

		// Token: 0x0602C1FF RID: 180735 RVA: 0x0060F6DF File Offset: 0x0060D8DF
		public void UnPackTo(IClientEventPianoEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602C200 RID: 180736 RVA: 0x0060F6F0 File Offset: 0x0060D8F0
		public static Offset<IClientEventPianoEvent> Pack(FlatBufferBuilder builder, IClientEventPianoEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientEventPianoEvent>);
			}
			return IClientEventPianoEvent.CreateIClientEventPianoEvent(builder, _o.Type);
		}

		// Token: 0x04010971 RID: 67953
		private Table __p;
	}
}
