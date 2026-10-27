using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006230 RID: 25136
	public struct IBubbleIndex : IFlatbufferObject
	{
		// Token: 0x1700BB49 RID: 47945
		// (get) Token: 0x0602B53A RID: 177466 RVA: 0x005F7478 File Offset: 0x005F5678
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B53B RID: 177467 RVA: 0x005F7485 File Offset: 0x005F5685
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B53C RID: 177468 RVA: 0x005F748C File Offset: 0x005F568C
		public static IBubbleIndex GetRootAsIBubbleIndex(ByteBuffer _bb)
		{
			return IBubbleIndex.GetRootAsIBubbleIndex(_bb, default(IBubbleIndex));
		}

		// Token: 0x0602B53D RID: 177469 RVA: 0x005F74A8 File Offset: 0x005F56A8
		public static IBubbleIndex GetRootAsIBubbleIndex(ByteBuffer _bb, IBubbleIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B53E RID: 177470 RVA: 0x005F74C5 File Offset: 0x005F56C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B53F RID: 177471 RVA: 0x005F74D4 File Offset: 0x005F56D4
		public IBubbleIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB4A RID: 47946
		// (get) Token: 0x0602B540 RID: 177472 RVA: 0x005F74E4 File Offset: 0x005F56E4
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

		// Token: 0x0602B541 RID: 177473 RVA: 0x005F751B File Offset: 0x005F571B
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602B542 RID: 177474 RVA: 0x005F752A File Offset: 0x005F572A
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BB4B RID: 47947
		// (get) Token: 0x0602B543 RID: 177475 RVA: 0x005F7538 File Offset: 0x005F5738
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

		// Token: 0x1700BB4C RID: 47948
		// (get) Token: 0x0602B544 RID: 177476 RVA: 0x005F7574 File Offset: 0x005F5774
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

		// Token: 0x1700BB4D RID: 47949
		// (get) Token: 0x0602B545 RID: 177477 RVA: 0x005F75B0 File Offset: 0x005F57B0
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

		// Token: 0x0602B546 RID: 177478 RVA: 0x005F75ED File Offset: 0x005F57ED
		public static Offset<IBubbleIndex> CreateIBubbleIndex(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0, int StateId = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IBubbleIndex.AddStateId(builder, StateId);
			IBubbleIndex.AddFlowId(builder, FlowId);
			IBubbleIndex.AddFlowListName(builder, FlowListNameOffset);
			IBubbleIndex.AddNullMask(builder, NullMask);
			return IBubbleIndex.EndIBubbleIndex(builder);
		}

		// Token: 0x0602B547 RID: 177479 RVA: 0x005F7619 File Offset: 0x005F5819
		public static void StartIBubbleIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B548 RID: 177480 RVA: 0x005F7622 File Offset: 0x005F5822
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x0602B549 RID: 177481 RVA: 0x005F7632 File Offset: 0x005F5832
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x0602B54A RID: 177482 RVA: 0x005F763D File Offset: 0x005F583D
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(2, stateId, 0);
		}

		// Token: 0x0602B54B RID: 177483 RVA: 0x005F7648 File Offset: 0x005F5848
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602B54C RID: 177484 RVA: 0x005F7653 File Offset: 0x005F5853
		public static Offset<IBubbleIndex> EndIBubbleIndex(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleIndex>(builder.EndTable());
		}

		// Token: 0x0602B54D RID: 177485 RVA: 0x005F7660 File Offset: 0x005F5860
		public IBubbleIndexT UnPack()
		{
			IBubbleIndexT bubbleIndexT = new IBubbleIndexT();
			this.UnPackTo(bubbleIndexT);
			return bubbleIndexT;
		}

		// Token: 0x0602B54E RID: 177486 RVA: 0x005F767B File Offset: 0x005F587B
		public void UnPackTo(IBubbleIndexT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B54F RID: 177487 RVA: 0x005F76B0 File Offset: 0x005F58B0
		public static Offset<IBubbleIndex> Pack(FlatBufferBuilder builder, IBubbleIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBubbleIndex>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			return IBubbleIndex.CreateIBubbleIndex(builder, flowListNameOffset, _o.FlowId, _o.StateId, _o.NullMask);
		}

		// Token: 0x04010773 RID: 67443
		private Table __p;
	}
}
