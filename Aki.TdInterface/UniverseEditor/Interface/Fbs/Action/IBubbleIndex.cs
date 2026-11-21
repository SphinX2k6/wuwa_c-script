using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A1 RID: 26785
	public struct IBubbleIndex : IFlatbufferObject
	{
		// Token: 0x1700C4D1 RID: 50385
		// (get) Token: 0x0602DC9B RID: 187547 RVA: 0x00642280 File Offset: 0x00640480
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DC9C RID: 187548 RVA: 0x0064228D File Offset: 0x0064048D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DC9D RID: 187549 RVA: 0x00642294 File Offset: 0x00640494
		public static IBubbleIndex GetRootAsIBubbleIndex(ByteBuffer _bb)
		{
			return IBubbleIndex.GetRootAsIBubbleIndex(_bb, default(IBubbleIndex));
		}

		// Token: 0x0602DC9E RID: 187550 RVA: 0x006422B0 File Offset: 0x006404B0
		public static IBubbleIndex GetRootAsIBubbleIndex(ByteBuffer _bb, IBubbleIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DC9F RID: 187551 RVA: 0x006422CD File Offset: 0x006404CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DCA0 RID: 187552 RVA: 0x006422DC File Offset: 0x006404DC
		public IBubbleIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4D2 RID: 50386
		// (get) Token: 0x0602DCA1 RID: 187553 RVA: 0x006422EC File Offset: 0x006404EC
		public string FlowListName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DCA2 RID: 187554 RVA: 0x00642323 File Offset: 0x00640523
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602DCA3 RID: 187555 RVA: 0x00642332 File Offset: 0x00640532
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C4D3 RID: 50387
		// (get) Token: 0x0602DCA4 RID: 187556 RVA: 0x00642340 File Offset: 0x00640540
		public int FlowId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4D4 RID: 50388
		// (get) Token: 0x0602DCA5 RID: 187557 RVA: 0x0064237C File Offset: 0x0064057C
		public int StateId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C4D5 RID: 50389
		// (get) Token: 0x0602DCA6 RID: 187558 RVA: 0x006423B8 File Offset: 0x006405B8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DCA7 RID: 187559 RVA: 0x006423F5 File Offset: 0x006405F5
		public static Offset<IBubbleIndex> CreateIBubbleIndex(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0, int StateId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IBubbleIndex.AddStateId(builder, StateId);
			IBubbleIndex.AddFlowId(builder, FlowId);
			IBubbleIndex.AddFlowListName(builder, FlowListNameOffset);
			IBubbleIndex.AddNullMask(builder, NullMask);
			return IBubbleIndex.EndIBubbleIndex(builder);
		}

		// Token: 0x0602DCA8 RID: 187560 RVA: 0x00642421 File Offset: 0x00640621
		public static void StartIBubbleIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DCA9 RID: 187561 RVA: 0x0064242A File Offset: 0x0064062A
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x0602DCAA RID: 187562 RVA: 0x0064243A File Offset: 0x0064063A
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x0602DCAB RID: 187563 RVA: 0x00642445 File Offset: 0x00640645
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(2, stateId, 0);
		}

		// Token: 0x0602DCAC RID: 187564 RVA: 0x00642450 File Offset: 0x00640650
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DCAD RID: 187565 RVA: 0x0064245B File Offset: 0x0064065B
		public static Offset<IBubbleIndex> EndIBubbleIndex(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleIndex>(builder.EndTable());
		}

		// Token: 0x0602DCAE RID: 187566 RVA: 0x00642468 File Offset: 0x00640668
		public IBubbleIndexT UnPack()
		{
			IBubbleIndexT bubbleIndexT = new IBubbleIndexT();
			this.UnPackTo(bubbleIndexT);
			return bubbleIndexT;
		}

		// Token: 0x0602DCAF RID: 187567 RVA: 0x00642483 File Offset: 0x00640683
		public void UnPackTo(IBubbleIndexT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DCB0 RID: 187568 RVA: 0x006424B8 File Offset: 0x006406B8
		public static Offset<IBubbleIndex> Pack(FlatBufferBuilder builder, IBubbleIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBubbleIndex>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			return IBubbleIndex.CreateIBubbleIndex(builder, flowListNameOffset, _o.FlowId, _o.StateId, _o.NullMask);
		}

		// Token: 0x04011588 RID: 71048
		private Table __p;
	}
}
