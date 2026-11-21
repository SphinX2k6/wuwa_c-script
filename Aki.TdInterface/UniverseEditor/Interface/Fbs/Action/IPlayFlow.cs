using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748F RID: 29839
	public struct IPlayFlow : IFlatbufferObject
	{
		// Token: 0x1700DB30 RID: 56112
		// (get) Token: 0x060343C8 RID: 213960 RVA: 0x00709160 File Offset: 0x00707360
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060343C9 RID: 213961 RVA: 0x0070916D File Offset: 0x0070736D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060343CA RID: 213962 RVA: 0x00709174 File Offset: 0x00707374
		public static IPlayFlow GetRootAsIPlayFlow(ByteBuffer _bb)
		{
			return IPlayFlow.GetRootAsIPlayFlow(_bb, default(IPlayFlow));
		}

		// Token: 0x060343CB RID: 213963 RVA: 0x00709190 File Offset: 0x00707390
		public static IPlayFlow GetRootAsIPlayFlow(ByteBuffer _bb, IPlayFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060343CC RID: 213964 RVA: 0x007091AD File Offset: 0x007073AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060343CD RID: 213965 RVA: 0x007091BC File Offset: 0x007073BC
		public IPlayFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB31 RID: 56113
		// (get) Token: 0x060343CE RID: 213966 RVA: 0x007091CC File Offset: 0x007073CC
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

		// Token: 0x060343CF RID: 213967 RVA: 0x00709203 File Offset: 0x00707403
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060343D0 RID: 213968 RVA: 0x00709212 File Offset: 0x00707412
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700DB32 RID: 56114
		// (get) Token: 0x060343D1 RID: 213969 RVA: 0x00709220 File Offset: 0x00707420
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

		// Token: 0x1700DB33 RID: 56115
		// (get) Token: 0x060343D2 RID: 213970 RVA: 0x0070925C File Offset: 0x0070745C
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

		// Token: 0x1700DB34 RID: 56116
		// (get) Token: 0x060343D3 RID: 213971 RVA: 0x00709298 File Offset: 0x00707498
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

		// Token: 0x060343D4 RID: 213972 RVA: 0x007092D0 File Offset: 0x007074D0
		public Span<byte> GetFlowGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060343D5 RID: 213973 RVA: 0x007092E0 File Offset: 0x007074E0
		public byte[] GetFlowGuidArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060343D6 RID: 213974 RVA: 0x007092EF File Offset: 0x007074EF
		public static Offset<IPlayFlow> CreateIPlayFlow(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0, int StateId = 0, StringOffset FlowGuidOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IPlayFlow.AddFlowGuid(builder, FlowGuidOffset);
			IPlayFlow.AddStateId(builder, StateId);
			IPlayFlow.AddFlowId(builder, FlowId);
			IPlayFlow.AddFlowListName(builder, FlowListNameOffset);
			return IPlayFlow.EndIPlayFlow(builder);
		}

		// Token: 0x060343D7 RID: 213975 RVA: 0x0070931B File Offset: 0x0070751B
		public static void StartIPlayFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060343D8 RID: 213976 RVA: 0x00709324 File Offset: 0x00707524
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x060343D9 RID: 213977 RVA: 0x00709334 File Offset: 0x00707534
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x060343DA RID: 213978 RVA: 0x0070933F File Offset: 0x0070753F
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(2, stateId, 0);
		}

		// Token: 0x060343DB RID: 213979 RVA: 0x0070934A File Offset: 0x0070754A
		public static void AddFlowGuid(FlatBufferBuilder builder, StringOffset flowGuidOffset)
		{
			builder.AddOffset(3, flowGuidOffset.Value, 0);
		}

		// Token: 0x060343DC RID: 213980 RVA: 0x0070935A File Offset: 0x0070755A
		public static Offset<IPlayFlow> EndIPlayFlow(FlatBufferBuilder builder)
		{
			return new Offset<IPlayFlow>(builder.EndTable());
		}

		// Token: 0x060343DD RID: 213981 RVA: 0x00709368 File Offset: 0x00707568
		public IPlayFlowT UnPack()
		{
			IPlayFlowT playFlowT = new IPlayFlowT();
			this.UnPackTo(playFlowT);
			return playFlowT;
		}

		// Token: 0x060343DE RID: 213982 RVA: 0x00709383 File Offset: 0x00707583
		public void UnPackTo(IPlayFlowT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
			_o.FlowGuid = this.FlowGuid;
		}

		// Token: 0x060343DF RID: 213983 RVA: 0x007093B8 File Offset: 0x007075B8
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

		// Token: 0x04012609 RID: 75273
		private Table __p;
	}
}
