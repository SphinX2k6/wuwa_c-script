using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C4 RID: 21444
	public struct IAnEvent : IFlatbufferObject
	{
		// Token: 0x170097AC RID: 38828
		// (get) Token: 0x060217A3 RID: 137123 RVA: 0x0049E05B File Offset: 0x0049C25B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060217A4 RID: 137124 RVA: 0x0049E068 File Offset: 0x0049C268
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060217A5 RID: 137125 RVA: 0x0049E070 File Offset: 0x0049C270
		public static IAnEvent GetRootAsIAnEvent(ByteBuffer _bb)
		{
			return IAnEvent.GetRootAsIAnEvent(_bb, default(IAnEvent));
		}

		// Token: 0x060217A6 RID: 137126 RVA: 0x0049E08C File Offset: 0x0049C28C
		public static IAnEvent GetRootAsIAnEvent(ByteBuffer _bb, IAnEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060217A7 RID: 137127 RVA: 0x0049E0A9 File Offset: 0x0049C2A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060217A8 RID: 137128 RVA: 0x0049E0B8 File Offset: 0x0049C2B8
		public IAnEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097AD RID: 38829
		// (get) Token: 0x060217A9 RID: 137129 RVA: 0x0049E0C8 File Offset: 0x0049C2C8
		public ESceneItemSeqEventCbType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESceneItemSeqEventCbType.ANS;
				}
				return (ESceneItemSeqEventCbType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170097AE RID: 38830
		// (get) Token: 0x060217AA RID: 137130 RVA: 0x0049E104 File Offset: 0x0049C304
		public string EventName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060217AB RID: 137131 RVA: 0x0049E13B File Offset: 0x0049C33B
		public Span<byte> GetEventNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060217AC RID: 137132 RVA: 0x0049E14A File Offset: 0x0049C34A
		public byte[] GetEventNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170097AF RID: 38831
		// (get) Token: 0x060217AD RID: 137133 RVA: 0x0049E158 File Offset: 0x0049C358
		public IActionInfo? Action
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060217AE RID: 137134 RVA: 0x0049E1B5 File Offset: 0x0049C3B5
		public static Offset<IAnEvent> CreateIAnEvent(FlatBufferBuilder builder, ESceneItemSeqEventCbType Type = ESceneItemSeqEventCbType.ANS, StringOffset EventNameOffset = default(StringOffset), Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(3);
			IAnEvent.AddAction(builder, ActionOffset);
			IAnEvent.AddEventName(builder, EventNameOffset);
			IAnEvent.AddType(builder, Type);
			return IAnEvent.EndIAnEvent(builder);
		}

		// Token: 0x060217AF RID: 137135 RVA: 0x0049E1D9 File Offset: 0x0049C3D9
		public static void StartIAnEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060217B0 RID: 137136 RVA: 0x0049E1E2 File Offset: 0x0049C3E2
		public static void AddType(FlatBufferBuilder builder, ESceneItemSeqEventCbType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060217B1 RID: 137137 RVA: 0x0049E1ED File Offset: 0x0049C3ED
		public static void AddEventName(FlatBufferBuilder builder, StringOffset eventNameOffset)
		{
			builder.AddOffset(1, eventNameOffset.Value, 0);
		}

		// Token: 0x060217B2 RID: 137138 RVA: 0x0049E1FD File Offset: 0x0049C3FD
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(2, actionOffset.Value, 0);
		}

		// Token: 0x060217B3 RID: 137139 RVA: 0x0049E20D File Offset: 0x0049C40D
		public static Offset<IAnEvent> EndIAnEvent(FlatBufferBuilder builder)
		{
			return new Offset<IAnEvent>(builder.EndTable());
		}

		// Token: 0x060217B4 RID: 137140 RVA: 0x0049E21C File Offset: 0x0049C41C
		public IAnEventT UnPack()
		{
			IAnEventT anEventT = new IAnEventT();
			this.UnPackTo(anEventT);
			return anEventT;
		}

		// Token: 0x060217B5 RID: 137141 RVA: 0x0049E238 File Offset: 0x0049C438
		public void UnPackTo(IAnEventT _o)
		{
			_o.Type = this.Type;
			_o.EventName = this.EventName;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
		}

		// Token: 0x060217B6 RID: 137142 RVA: 0x0049E28C File Offset: 0x0049C48C
		public static Offset<IAnEvent> Pack(FlatBufferBuilder builder, IAnEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAnEvent>);
			}
			StringOffset eventNameOffset = (_o.EventName == null) ? default(StringOffset) : builder.CreateString(_o.EventName);
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return IAnEvent.CreateIAnEvent(builder, _o.Type, eventNameOffset, actionOffset);
		}

		// Token: 0x0400E80F RID: 59407
		private Table __p;
	}
}
