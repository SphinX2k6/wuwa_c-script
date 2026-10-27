using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DC4 RID: 24004
	public struct IGiantResponsePlayFlow : IFlatbufferObject
	{
		// Token: 0x1700B3B7 RID: 46007
		// (get) Token: 0x0602915A RID: 168282 RVA: 0x005A3C76 File Offset: 0x005A1E76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602915B RID: 168283 RVA: 0x005A3C83 File Offset: 0x005A1E83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602915C RID: 168284 RVA: 0x005A3C8C File Offset: 0x005A1E8C
		public static IGiantResponsePlayFlow GetRootAsIGiantResponsePlayFlow(ByteBuffer _bb)
		{
			return IGiantResponsePlayFlow.GetRootAsIGiantResponsePlayFlow(_bb, default(IGiantResponsePlayFlow));
		}

		// Token: 0x0602915D RID: 168285 RVA: 0x005A3CA8 File Offset: 0x005A1EA8
		public static IGiantResponsePlayFlow GetRootAsIGiantResponsePlayFlow(ByteBuffer _bb, IGiantResponsePlayFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602915E RID: 168286 RVA: 0x005A3CC5 File Offset: 0x005A1EC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602915F RID: 168287 RVA: 0x005A3CD4 File Offset: 0x005A1ED4
		public IGiantResponsePlayFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3B8 RID: 46008
		// (get) Token: 0x06029160 RID: 168288 RVA: 0x005A3CE4 File Offset: 0x005A1EE4
		public EGiantResponseType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantResponseType.PlayAnimation;
				}
				return (EGiantResponseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B3B9 RID: 46009
		// (get) Token: 0x06029161 RID: 168289 RVA: 0x005A3D20 File Offset: 0x005A1F20
		public IGiantFlowConfig? FlowConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IGiantFlowConfig?(default(IGiantFlowConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029162 RID: 168290 RVA: 0x005A3D7D File Offset: 0x005A1F7D
		public static Offset<IGiantResponsePlayFlow> CreateIGiantResponsePlayFlow(FlatBufferBuilder builder, EGiantResponseType Type = EGiantResponseType.PlayAnimation, Offset<IGiantFlowConfig> FlowConfigOffset = default(Offset<IGiantFlowConfig>))
		{
			builder.StartTable(2);
			IGiantResponsePlayFlow.AddFlowConfig(builder, FlowConfigOffset);
			IGiantResponsePlayFlow.AddType(builder, Type);
			return IGiantResponsePlayFlow.EndIGiantResponsePlayFlow(builder);
		}

		// Token: 0x06029163 RID: 168291 RVA: 0x005A3D9A File Offset: 0x005A1F9A
		public static void StartIGiantResponsePlayFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029164 RID: 168292 RVA: 0x005A3DA3 File Offset: 0x005A1FA3
		public static void AddType(FlatBufferBuilder builder, EGiantResponseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029165 RID: 168293 RVA: 0x005A3DAE File Offset: 0x005A1FAE
		public static void AddFlowConfig(FlatBufferBuilder builder, Offset<IGiantFlowConfig> flowConfigOffset)
		{
			builder.AddOffset(1, flowConfigOffset.Value, 0);
		}

		// Token: 0x06029166 RID: 168294 RVA: 0x005A3DBE File Offset: 0x005A1FBE
		public static Offset<IGiantResponsePlayFlow> EndIGiantResponsePlayFlow(FlatBufferBuilder builder)
		{
			return new Offset<IGiantResponsePlayFlow>(builder.EndTable());
		}

		// Token: 0x06029167 RID: 168295 RVA: 0x005A3DCC File Offset: 0x005A1FCC
		public IGiantResponsePlayFlowT UnPack()
		{
			IGiantResponsePlayFlowT giantResponsePlayFlowT = new IGiantResponsePlayFlowT();
			this.UnPackTo(giantResponsePlayFlowT);
			return giantResponsePlayFlowT;
		}

		// Token: 0x06029168 RID: 168296 RVA: 0x005A3DE8 File Offset: 0x005A1FE8
		public void UnPackTo(IGiantResponsePlayFlowT _o)
		{
			_o.Type = this.Type;
			_o.FlowConfig = ((this.FlowConfig != null) ? this.FlowConfig.Value.UnPack() : null);
		}

		// Token: 0x06029169 RID: 168297 RVA: 0x005A3E30 File Offset: 0x005A2030
		public static Offset<IGiantResponsePlayFlow> Pack(FlatBufferBuilder builder, IGiantResponsePlayFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantResponsePlayFlow>);
			}
			Offset<IGiantFlowConfig> flowConfigOffset = (_o.FlowConfig == null) ? default(Offset<IGiantFlowConfig>) : IGiantFlowConfig.Pack(builder, _o.FlowConfig);
			return IGiantResponsePlayFlow.CreateIGiantResponsePlayFlow(builder, _o.Type, flowConfigOffset);
		}

		// Token: 0x0400F7A5 RID: 63397
		private Table __p;
	}
}
