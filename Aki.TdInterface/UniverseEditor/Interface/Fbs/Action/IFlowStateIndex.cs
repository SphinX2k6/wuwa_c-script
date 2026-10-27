using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681F RID: 26655
	public struct IFlowStateIndex : IFlatbufferObject
	{
		// Token: 0x1700C5FD RID: 50685
		// (get) Token: 0x0602E766 RID: 190310 RVA: 0x0065761C File Offset: 0x0065581C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E767 RID: 190311 RVA: 0x00657629 File Offset: 0x00655829
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E768 RID: 190312 RVA: 0x00657630 File Offset: 0x00655830
		public static IFlowStateIndex GetRootAsIFlowStateIndex(ByteBuffer _bb)
		{
			return IFlowStateIndex.GetRootAsIFlowStateIndex(_bb, default(IFlowStateIndex));
		}

		// Token: 0x0602E769 RID: 190313 RVA: 0x0065764C File Offset: 0x0065584C
		public static IFlowStateIndex GetRootAsIFlowStateIndex(ByteBuffer _bb, IFlowStateIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E76A RID: 190314 RVA: 0x00657669 File Offset: 0x00655869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E76B RID: 190315 RVA: 0x00657678 File Offset: 0x00655878
		public IFlowStateIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5FE RID: 50686
		// (get) Token: 0x0602E76C RID: 190316 RVA: 0x00657688 File Offset: 0x00655888
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

		// Token: 0x0602E76D RID: 190317 RVA: 0x006576BF File Offset: 0x006558BF
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602E76E RID: 190318 RVA: 0x006576CE File Offset: 0x006558CE
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C5FF RID: 50687
		// (get) Token: 0x0602E76F RID: 190319 RVA: 0x006576DC File Offset: 0x006558DC
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

		// Token: 0x1700C600 RID: 50688
		// (get) Token: 0x0602E770 RID: 190320 RVA: 0x00657718 File Offset: 0x00655918
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

		// Token: 0x0602E771 RID: 190321 RVA: 0x00657754 File Offset: 0x00655954
		public static Offset<IFlowStateIndex> CreateIFlowStateIndex(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0, int StateId = 0)
		{
			builder.StartTable(3);
			IFlowStateIndex.AddStateId(builder, StateId);
			IFlowStateIndex.AddFlowId(builder, FlowId);
			IFlowStateIndex.AddFlowListName(builder, FlowListNameOffset);
			return IFlowStateIndex.EndIFlowStateIndex(builder);
		}

		// Token: 0x0602E772 RID: 190322 RVA: 0x00657778 File Offset: 0x00655978
		public static void StartIFlowStateIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E773 RID: 190323 RVA: 0x00657781 File Offset: 0x00655981
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x0602E774 RID: 190324 RVA: 0x00657791 File Offset: 0x00655991
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x0602E775 RID: 190325 RVA: 0x0065779C File Offset: 0x0065599C
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(2, stateId, 0);
		}

		// Token: 0x0602E776 RID: 190326 RVA: 0x006577A7 File Offset: 0x006559A7
		public static Offset<IFlowStateIndex> EndIFlowStateIndex(FlatBufferBuilder builder)
		{
			return new Offset<IFlowStateIndex>(builder.EndTable());
		}

		// Token: 0x0602E777 RID: 190327 RVA: 0x006577B4 File Offset: 0x006559B4
		public IFlowStateIndexT UnPack()
		{
			IFlowStateIndexT flowStateIndexT = new IFlowStateIndexT();
			this.UnPackTo(flowStateIndexT);
			return flowStateIndexT;
		}

		// Token: 0x0602E778 RID: 190328 RVA: 0x006577CF File Offset: 0x006559CF
		public void UnPackTo(IFlowStateIndexT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
		}

		// Token: 0x0602E779 RID: 190329 RVA: 0x006577F8 File Offset: 0x006559F8
		public static Offset<IFlowStateIndex> Pack(FlatBufferBuilder builder, IFlowStateIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowStateIndex>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			return IFlowStateIndex.CreateIFlowStateIndex(builder, flowListNameOffset, _o.FlowId, _o.StateId);
		}

		// Token: 0x04010F5C RID: 69468
		private Table __p;
	}
}
