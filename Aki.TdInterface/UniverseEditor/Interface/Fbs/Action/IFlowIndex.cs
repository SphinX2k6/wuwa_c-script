using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006813 RID: 26643
	public struct IFlowIndex : IFlatbufferObject
	{
		// Token: 0x1700C5BF RID: 50623
		// (get) Token: 0x0602E668 RID: 190056 RVA: 0x00654FC4 File Offset: 0x006531C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E669 RID: 190057 RVA: 0x00654FD1 File Offset: 0x006531D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E66A RID: 190058 RVA: 0x00654FD8 File Offset: 0x006531D8
		public static IFlowIndex GetRootAsIFlowIndex(ByteBuffer _bb)
		{
			return IFlowIndex.GetRootAsIFlowIndex(_bb, default(IFlowIndex));
		}

		// Token: 0x0602E66B RID: 190059 RVA: 0x00654FF4 File Offset: 0x006531F4
		public static IFlowIndex GetRootAsIFlowIndex(ByteBuffer _bb, IFlowIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E66C RID: 190060 RVA: 0x00655011 File Offset: 0x00653211
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E66D RID: 190061 RVA: 0x00655020 File Offset: 0x00653220
		public IFlowIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5C0 RID: 50624
		// (get) Token: 0x0602E66E RID: 190062 RVA: 0x00655030 File Offset: 0x00653230
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

		// Token: 0x0602E66F RID: 190063 RVA: 0x00655067 File Offset: 0x00653267
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E670 RID: 190064 RVA: 0x00655076 File Offset: 0x00653276
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C5C1 RID: 50625
		// (get) Token: 0x0602E671 RID: 190065 RVA: 0x00655084 File Offset: 0x00653284
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

		// Token: 0x0602E672 RID: 190066 RVA: 0x006550C0 File Offset: 0x006532C0
		public static Offset<IFlowIndex> CreateIFlowIndex(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0)
		{
			builder.StartTable(2);
			IFlowIndex.AddFlowId(builder, FlowId);
			IFlowIndex.AddFlowListName(builder, FlowListNameOffset);
			return IFlowIndex.EndIFlowIndex(builder);
		}

		// Token: 0x0602E673 RID: 190067 RVA: 0x006550DD File Offset: 0x006532DD
		public static void StartIFlowIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E674 RID: 190068 RVA: 0x006550E6 File Offset: 0x006532E6
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x0602E675 RID: 190069 RVA: 0x006550F6 File Offset: 0x006532F6
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x0602E676 RID: 190070 RVA: 0x00655101 File Offset: 0x00653301
		public static Offset<IFlowIndex> EndIFlowIndex(FlatBufferBuilder builder)
		{
			return new Offset<IFlowIndex>(builder.EndTable());
		}

		// Token: 0x0602E677 RID: 190071 RVA: 0x00655110 File Offset: 0x00653310
		public IFlowIndexT UnPack()
		{
			IFlowIndexT flowIndexT = new IFlowIndexT();
			this.UnPackTo(flowIndexT);
			return flowIndexT;
		}

		// Token: 0x0602E678 RID: 190072 RVA: 0x0065512B File Offset: 0x0065332B
		public void UnPackTo(IFlowIndexT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
		}

		// Token: 0x0602E679 RID: 190073 RVA: 0x00655148 File Offset: 0x00653348
		public static Offset<IFlowIndex> Pack(FlatBufferBuilder builder, IFlowIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowIndex>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			return IFlowIndex.CreateIFlowIndex(builder, flowListNameOffset, _o.FlowId);
		}

		// Token: 0x04010F3B RID: 69435
		private Table __p;
	}
}
