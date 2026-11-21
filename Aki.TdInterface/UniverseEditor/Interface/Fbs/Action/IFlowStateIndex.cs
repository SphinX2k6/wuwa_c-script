using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA2 RID: 28322
	public struct IFlowStateIndex : IFlatbufferObject
	{
		// Token: 0x1700CFBE RID: 53182
		// (get) Token: 0x06030FDC RID: 200668 RVA: 0x006A53E4 File Offset: 0x006A35E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030FDD RID: 200669 RVA: 0x006A53F1 File Offset: 0x006A35F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030FDE RID: 200670 RVA: 0x006A53F8 File Offset: 0x006A35F8
		public static IFlowStateIndex GetRootAsIFlowStateIndex(ByteBuffer _bb)
		{
			return IFlowStateIndex.GetRootAsIFlowStateIndex(_bb, default(IFlowStateIndex));
		}

		// Token: 0x06030FDF RID: 200671 RVA: 0x006A5414 File Offset: 0x006A3614
		public static IFlowStateIndex GetRootAsIFlowStateIndex(ByteBuffer _bb, IFlowStateIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030FE0 RID: 200672 RVA: 0x006A5431 File Offset: 0x006A3631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030FE1 RID: 200673 RVA: 0x006A5440 File Offset: 0x006A3640
		public IFlowStateIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFBF RID: 53183
		// (get) Token: 0x06030FE2 RID: 200674 RVA: 0x006A5450 File Offset: 0x006A3650
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

		// Token: 0x06030FE3 RID: 200675 RVA: 0x006A5487 File Offset: 0x006A3687
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06030FE4 RID: 200676 RVA: 0x006A5496 File Offset: 0x006A3696
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CFC0 RID: 53184
		// (get) Token: 0x06030FE5 RID: 200677 RVA: 0x006A54A4 File Offset: 0x006A36A4
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

		// Token: 0x1700CFC1 RID: 53185
		// (get) Token: 0x06030FE6 RID: 200678 RVA: 0x006A54E0 File Offset: 0x006A36E0
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

		// Token: 0x06030FE7 RID: 200679 RVA: 0x006A551C File Offset: 0x006A371C
		public static Offset<IFlowStateIndex> CreateIFlowStateIndex(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0, int StateId = 0)
		{
			builder.StartTable(3);
			IFlowStateIndex.AddStateId(builder, StateId);
			IFlowStateIndex.AddFlowId(builder, FlowId);
			IFlowStateIndex.AddFlowListName(builder, FlowListNameOffset);
			return IFlowStateIndex.EndIFlowStateIndex(builder);
		}

		// Token: 0x06030FE8 RID: 200680 RVA: 0x006A5540 File Offset: 0x006A3740
		public static void StartIFlowStateIndex(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030FE9 RID: 200681 RVA: 0x006A5549 File Offset: 0x006A3749
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x06030FEA RID: 200682 RVA: 0x006A5559 File Offset: 0x006A3759
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x06030FEB RID: 200683 RVA: 0x006A5564 File Offset: 0x006A3764
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(2, stateId, 0);
		}

		// Token: 0x06030FEC RID: 200684 RVA: 0x006A556F File Offset: 0x006A376F
		public static Offset<IFlowStateIndex> EndIFlowStateIndex(FlatBufferBuilder builder)
		{
			return new Offset<IFlowStateIndex>(builder.EndTable());
		}

		// Token: 0x06030FED RID: 200685 RVA: 0x006A557C File Offset: 0x006A377C
		public IFlowStateIndexT UnPack()
		{
			IFlowStateIndexT flowStateIndexT = new IFlowStateIndexT();
			this.UnPackTo(flowStateIndexT);
			return flowStateIndexT;
		}

		// Token: 0x06030FEE RID: 200686 RVA: 0x006A5597 File Offset: 0x006A3797
		public void UnPackTo(IFlowStateIndexT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
		}

		// Token: 0x06030FEF RID: 200687 RVA: 0x006A55C0 File Offset: 0x006A37C0
		public static Offset<IFlowStateIndex> Pack(FlatBufferBuilder builder, IFlowStateIndexT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowStateIndex>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			return IFlowStateIndex.CreateIFlowStateIndex(builder, flowListNameOffset, _o.FlowId, _o.StateId);
		}

		// Token: 0x04011D94 RID: 73108
		private Table __p;
	}
}
