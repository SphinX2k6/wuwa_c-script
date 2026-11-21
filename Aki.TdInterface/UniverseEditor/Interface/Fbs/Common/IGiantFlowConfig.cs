using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063F8 RID: 25592
	public struct IGiantFlowConfig : IFlatbufferObject
	{
		// Token: 0x1700BD0C RID: 48396
		// (get) Token: 0x0602B79C RID: 178076 RVA: 0x005EC2F0 File Offset: 0x005EA4F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B79D RID: 178077 RVA: 0x005EC2FD File Offset: 0x005EA4FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B79E RID: 178078 RVA: 0x005EC304 File Offset: 0x005EA504
		public static IGiantFlowConfig GetRootAsIGiantFlowConfig(ByteBuffer _bb)
		{
			return IGiantFlowConfig.GetRootAsIGiantFlowConfig(_bb, default(IGiantFlowConfig));
		}

		// Token: 0x0602B79F RID: 178079 RVA: 0x005EC320 File Offset: 0x005EA520
		public static IGiantFlowConfig GetRootAsIGiantFlowConfig(ByteBuffer _bb, IGiantFlowConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B7A0 RID: 178080 RVA: 0x005EC33D File Offset: 0x005EA53D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B7A1 RID: 178081 RVA: 0x005EC34C File Offset: 0x005EA54C
		public IGiantFlowConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD0D RID: 48397
		// (get) Token: 0x0602B7A2 RID: 178082 RVA: 0x005EC35C File Offset: 0x005EA55C
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

		// Token: 0x0602B7A3 RID: 178083 RVA: 0x005EC393 File Offset: 0x005EA593
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602B7A4 RID: 178084 RVA: 0x005EC3A2 File Offset: 0x005EA5A2
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BD0E RID: 48398
		// (get) Token: 0x0602B7A5 RID: 178085 RVA: 0x005EC3B0 File Offset: 0x005EA5B0
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

		// Token: 0x1700BD0F RID: 48399
		// (get) Token: 0x0602B7A6 RID: 178086 RVA: 0x005EC3EC File Offset: 0x005EA5EC
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

		// Token: 0x0602B7A7 RID: 178087 RVA: 0x005EC428 File Offset: 0x005EA628
		public static Offset<IGiantFlowConfig> CreateIGiantFlowConfig(FlatBufferBuilder builder, StringOffset FlowListNameOffset = default(StringOffset), int FlowId = 0, int StateId = 0)
		{
			builder.StartTable(3);
			IGiantFlowConfig.AddStateId(builder, StateId);
			IGiantFlowConfig.AddFlowId(builder, FlowId);
			IGiantFlowConfig.AddFlowListName(builder, FlowListNameOffset);
			return IGiantFlowConfig.EndIGiantFlowConfig(builder);
		}

		// Token: 0x0602B7A8 RID: 178088 RVA: 0x005EC44C File Offset: 0x005EA64C
		public static void StartIGiantFlowConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B7A9 RID: 178089 RVA: 0x005EC455 File Offset: 0x005EA655
		public static void AddFlowListName(FlatBufferBuilder builder, StringOffset flowListNameOffset)
		{
			builder.AddOffset(0, flowListNameOffset.Value, 0);
		}

		// Token: 0x0602B7AA RID: 178090 RVA: 0x005EC465 File Offset: 0x005EA665
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(1, flowId, 0);
		}

		// Token: 0x0602B7AB RID: 178091 RVA: 0x005EC470 File Offset: 0x005EA670
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(2, stateId, 0);
		}

		// Token: 0x0602B7AC RID: 178092 RVA: 0x005EC47B File Offset: 0x005EA67B
		public static Offset<IGiantFlowConfig> EndIGiantFlowConfig(FlatBufferBuilder builder)
		{
			return new Offset<IGiantFlowConfig>(builder.EndTable());
		}

		// Token: 0x0602B7AD RID: 178093 RVA: 0x005EC488 File Offset: 0x005EA688
		public IGiantFlowConfigT UnPack()
		{
			IGiantFlowConfigT giantFlowConfigT = new IGiantFlowConfigT();
			this.UnPackTo(giantFlowConfigT);
			return giantFlowConfigT;
		}

		// Token: 0x0602B7AE RID: 178094 RVA: 0x005EC4A3 File Offset: 0x005EA6A3
		public void UnPackTo(IGiantFlowConfigT _o)
		{
			_o.FlowListName = this.FlowListName;
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
		}

		// Token: 0x0602B7AF RID: 178095 RVA: 0x005EC4CC File Offset: 0x005EA6CC
		public static Offset<IGiantFlowConfig> Pack(FlatBufferBuilder builder, IGiantFlowConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantFlowConfig>);
			}
			StringOffset flowListNameOffset = (_o.FlowListName == null) ? default(StringOffset) : builder.CreateString(_o.FlowListName);
			return IGiantFlowConfig.CreateIGiantFlowConfig(builder, flowListNameOffset, _o.FlowId, _o.StateId);
		}

		// Token: 0x040104F6 RID: 66806
		private Table __p;
	}
}
