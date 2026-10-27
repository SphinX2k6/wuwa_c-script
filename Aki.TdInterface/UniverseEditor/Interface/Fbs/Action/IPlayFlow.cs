using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D14 RID: 27924
	public struct IPlayFlow : IFlatbufferObject
	{
		// Token: 0x1700CFEA RID: 53226
		// (get) Token: 0x060313D0 RID: 201680 RVA: 0x006ADB19 File Offset: 0x006ABD19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060313D1 RID: 201681 RVA: 0x006ADB26 File Offset: 0x006ABD26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060313D2 RID: 201682 RVA: 0x006ADB30 File Offset: 0x006ABD30
		public static IPlayFlow GetRootAsIPlayFlow(ByteBuffer _bb)
		{
			return IPlayFlow.GetRootAsIPlayFlow(_bb, default(IPlayFlow));
		}

		// Token: 0x060313D3 RID: 201683 RVA: 0x006ADB4C File Offset: 0x006ABD4C
		public static IPlayFlow GetRootAsIPlayFlow(ByteBuffer _bb, IPlayFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060313D4 RID: 201684 RVA: 0x006ADB69 File Offset: 0x006ABD69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060313D5 RID: 201685 RVA: 0x006ADB78 File Offset: 0x006ABD78
		public IPlayFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFEB RID: 53227
		// (get) Token: 0x060313D6 RID: 201686 RVA: 0x006ADB88 File Offset: 0x006ABD88
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

		// Token: 0x060313D7 RID: 201687 RVA: 0x006ADBBF File Offset: 0x006ABDBF
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060313D8 RID: 201688 RVA: 0x006ADBCE File Offset: 0x006ABDCE
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CFEC RID: 53228
		// (get) Token: 0x060313D9 RID: 201689 RVA: 0x006ADBDC File Offset: 0x006ABDDC
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

		// Token: 0x1700CFED RID: 53229
		// (get) Token: 0x060313DA RID: 201690 RVA: 0x006ADC18 File Offset: 0x006ABE18
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

		// Token: 0x1700CFEE RID: 53230
		// (get) Token: 0x060313DB RID: 201691 RVA: 0x006ADC54 File Offset: 0x006ABE54
		public string FlowGuid
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060313DC RID: 201692 RVA: 0x006ADC8C File Offset: 0x006ABE8C
		public Span<byte> GetFlowGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060313DD RID: 201693 RVA: 0x006ADC9C File Offset: 0x006ABE9C
		public byte[] GetFlowGuidArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060313DE RID: 201694 RVA: 0x006ADCAB File Offset: 0x006ABEAB
		public static Offset<IPlayFlow> CreateIPlayFlow(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0, int StateId = 0, StringOffset FlowGuidOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IPlayFlow.AddFlowGuid(builder, FlowGuidOffset);
			IPlayFlow.AddStateId(builder, StateId);
			IPlayFlow.AddFlowId(builder, FlowId);
			IPlayFlow.AddFlowListName(builder, FlowListNameOffset);
			return IPlayFlow.EndIPlayFlow(builder);
		}

		// Token: 0x060313DF RID: 201695 RVA: 0x006ADCD7 File Offset: 0x006ABED7
		public static void StartIPlayFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060313E0 RID: 201696 RVA: 0x006ADCE0 File Offset: 0x006ABEE0
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x060313E1 RID: 201697 RVA: 0x006ADCF0 File Offset: 0x006ABEF0
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x060313E2 RID: 201698 RVA: 0x006ADCFB File Offset: 0x006ABEFB
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(2, stateId, 0);
		}

		// Token: 0x060313E3 RID: 201699 RVA: 0x006ADD06 File Offset: 0x006ABF06
		public static void AddFlowGuid(FlatBufferBuilder builder, StringOffset flowGuidOffset)
		{
			builder.AddOffset(3, flowGuidOffset.Value, 0);
		}

		// Token: 0x060313E4 RID: 201700 RVA: 0x006ADD16 File Offset: 0x006ABF16
		public static Offset<IPlayFlow> EndIPlayFlow(FlatBufferBuilder builder)
		{
			return new Offset<IPlayFlow>(builder.EndTable());
		}

		// Token: 0x060313E5 RID: 201701 RVA: 0x006ADD24 File Offset: 0x006ABF24
		public IPlayFlowT UnPack()
		{
			IPlayFlowT playFlowT = new IPlayFlowT();
			this.UnPackTo(playFlowT);
			return playFlowT;
		}

		// Token: 0x060313E6 RID: 201702 RVA: 0x006ADD3F File Offset: 0x006ABF3F
		public void UnPackTo(IPlayFlowT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
			_o.FlowGuid = this.FlowGuid;
		}

		// Token: 0x060313E7 RID: 201703 RVA: 0x006ADD74 File Offset: 0x006ABF74
		public static Offset<IPlayFlow> Pack(FlatBufferBuilder builder, IPlayFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayFlow>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			StringOffset flowGuidOffset = (_o.FlowGuid == null) ? default(StringOffset) : builder.CreateString(_o.FlowGuid);
			return IPlayFlow.CreateIPlayFlow(builder, flowListNameOffset, _o.FlowId, _o.StateId, flowGuidOffset);
		}

		// Token: 0x0401168E RID: 71310
		private Table __p;
	}
}
