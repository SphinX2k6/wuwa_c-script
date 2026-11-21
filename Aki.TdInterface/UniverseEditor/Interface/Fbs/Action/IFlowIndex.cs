using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E93 RID: 28307
	public struct IFlowIndex : IFlatbufferObject
	{
		// Token: 0x1700CF75 RID: 53109
		// (get) Token: 0x06030EAE RID: 200366 RVA: 0x006A2708 File Offset: 0x006A0908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030EAF RID: 200367 RVA: 0x006A2715 File Offset: 0x006A0915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030EB0 RID: 200368 RVA: 0x006A271C File Offset: 0x006A091C
		public static IFlowIndex GetRootAsIFlowIndex(ByteBuffer _bb)
		{
			return IFlowIndex.GetRootAsIFlowIndex(_bb, default(IFlowIndex));
		}

		// Token: 0x06030EB1 RID: 200369 RVA: 0x006A2738 File Offset: 0x006A0938
		public static IFlowIndex GetRootAsIFlowIndex(ByteBuffer _bb, IFlowIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030EB2 RID: 200370 RVA: 0x006A2755 File Offset: 0x006A0955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030EB3 RID: 200371 RVA: 0x006A2764 File Offset: 0x006A0964
		public IFlowIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF76 RID: 53110
		// (get) Token: 0x06030EB4 RID: 200372 RVA: 0x006A2774 File Offset: 0x006A0974
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

		// Token: 0x06030EB5 RID: 200373 RVA: 0x006A27AB File Offset: 0x006A09AB
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030EB6 RID: 200374 RVA: 0x006A27BA File Offset: 0x006A09BA
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CF77 RID: 53111
		// (get) Token: 0x06030EB7 RID: 200375 RVA: 0x006A27C8 File Offset: 0x006A09C8
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

		// Token: 0x06030EB8 RID: 200376 RVA: 0x006A2804 File Offset: 0x006A0A04
		public static Offset<IFlowIndex> CreateIFlowIndex(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0)
		{
			builder.StartTable(2);
			IFlowIndex.AddFlowId(builder, FlowId);
			IFlowIndex.AddFlowListName(builder, FlowListNameOffset);
			return IFlowIndex.EndIFlowIndex(builder);
		}

		// Token: 0x06030EB9 RID: 200377 RVA: 0x006A2821 File Offset: 0x006A0A21
		public static void StartIFlowIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030EBA RID: 200378 RVA: 0x006A282A File Offset: 0x006A0A2A
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x06030EBB RID: 200379 RVA: 0x006A283A File Offset: 0x006A0A3A
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x06030EBC RID: 200380 RVA: 0x006A2845 File Offset: 0x006A0A45
		public static Offset<IFlowIndex> EndIFlowIndex(FlatBufferBuilder builder)
		{
			return new Offset<IFlowIndex>(builder.EndTable());
		}

		// Token: 0x06030EBD RID: 200381 RVA: 0x006A2854 File Offset: 0x006A0A54
		public IFlowIndexT UnPack()
		{
			IFlowIndexT flowIndexT = new IFlowIndexT();
			this.UnPackTo(flowIndexT);
			return flowIndexT;
		}

		// Token: 0x06030EBE RID: 200382 RVA: 0x006A286F File Offset: 0x006A0A6F
		public void UnPackTo(IFlowIndexT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
		}

		// Token: 0x06030EBF RID: 200383 RVA: 0x006A288C File Offset: 0x006A0A8C
		public static Offset<IFlowIndex> Pack(FlatBufferBuilder builder, IFlowIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowIndex>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			return IFlowIndex.CreateIFlowIndex(builder, flowListNameOffset, _o.FlowId);
		}

		// Token: 0x04011D6D RID: 73069
		private Table __p;
	}
}
