using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DBB RID: 23995
	public struct IGiantFlowConfig : IFlatbufferObject
	{
		// Token: 0x1700B3A6 RID: 45990
		// (get) Token: 0x06029112 RID: 168210 RVA: 0x005A35C0 File Offset: 0x005A17C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029113 RID: 168211 RVA: 0x005A35CD File Offset: 0x005A17CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029114 RID: 168212 RVA: 0x005A35D4 File Offset: 0x005A17D4
		public static IGiantFlowConfig GetRootAsIGiantFlowConfig(ByteBuffer _bb)
		{
			return IGiantFlowConfig.GetRootAsIGiantFlowConfig(_bb, default(IGiantFlowConfig));
		}

		// Token: 0x06029115 RID: 168213 RVA: 0x005A35F0 File Offset: 0x005A17F0
		public static IGiantFlowConfig GetRootAsIGiantFlowConfig(ByteBuffer _bb, IGiantFlowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029116 RID: 168214 RVA: 0x005A360D File Offset: 0x005A180D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029117 RID: 168215 RVA: 0x005A361C File Offset: 0x005A181C
		public IGiantFlowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3A7 RID: 45991
		// (get) Token: 0x06029118 RID: 168216 RVA: 0x005A362C File Offset: 0x005A182C
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

		// Token: 0x06029119 RID: 168217 RVA: 0x005A3663 File Offset: 0x005A1863
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602911A RID: 168218 RVA: 0x005A3672 File Offset: 0x005A1872
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B3A8 RID: 45992
		// (get) Token: 0x0602911B RID: 168219 RVA: 0x005A3680 File Offset: 0x005A1880
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

		// Token: 0x1700B3A9 RID: 45993
		// (get) Token: 0x0602911C RID: 168220 RVA: 0x005A36BC File Offset: 0x005A18BC
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

		// Token: 0x0602911D RID: 168221 RVA: 0x005A36F8 File Offset: 0x005A18F8
		public static Offset<IGiantFlowConfig> CreateIGiantFlowConfig(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0, int StateId = 0)
		{
			builder.StartTable(3);
			IGiantFlowConfig.AddStateId(builder, StateId);
			IGiantFlowConfig.AddFlowId(builder, FlowId);
			IGiantFlowConfig.AddFlowListName(builder, FlowListNameOffset);
			return IGiantFlowConfig.EndIGiantFlowConfig(builder);
		}

		// Token: 0x0602911E RID: 168222 RVA: 0x005A371C File Offset: 0x005A191C
		public static void StartIGiantFlowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602911F RID: 168223 RVA: 0x005A3725 File Offset: 0x005A1925
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x06029120 RID: 168224 RVA: 0x005A3735 File Offset: 0x005A1935
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x06029121 RID: 168225 RVA: 0x005A3740 File Offset: 0x005A1940
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(2, stateId, 0);
		}

		// Token: 0x06029122 RID: 168226 RVA: 0x005A374B File Offset: 0x005A194B
		public static Offset<IGiantFlowConfig> EndIGiantFlowConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGiantFlowConfig>(builder.EndTable());
		}

		// Token: 0x06029123 RID: 168227 RVA: 0x005A3758 File Offset: 0x005A1958
		public IGiantFlowConfigT UnPack()
		{
			IGiantFlowConfigT giantFlowConfigT = new IGiantFlowConfigT();
			this.UnPackTo(giantFlowConfigT);
			return giantFlowConfigT;
		}

		// Token: 0x06029124 RID: 168228 RVA: 0x005A3773 File Offset: 0x005A1973
		public void UnPackTo(IGiantFlowConfigT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
		}

		// Token: 0x06029125 RID: 168229 RVA: 0x005A379C File Offset: 0x005A199C
		public static Offset<IGiantFlowConfig> Pack(FlatBufferBuilder builder, IGiantFlowConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantFlowConfig>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			return IGiantFlowConfig.CreateIGiantFlowConfig(builder, flowListNameOffset, _o.FlowId, _o.StateId);
		}

		// Token: 0x0400F79B RID: 63387
		private Table __p;
	}
}
