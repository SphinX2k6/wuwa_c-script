using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006401 RID: 25601
	public struct IGiantResponsePlayFlow : IFlatbufferObject
	{
		// Token: 0x1700BD1D RID: 48413
		// (get) Token: 0x0602B7E4 RID: 178148 RVA: 0x005EC9A6 File Offset: 0x005EABA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B7E5 RID: 178149 RVA: 0x005EC9B3 File Offset: 0x005EABB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B7E6 RID: 178150 RVA: 0x005EC9BC File Offset: 0x005EABBC
		public static IGiantResponsePlayFlow GetRootAsIGiantResponsePlayFlow(ByteBuffer _bb)
		{
			return IGiantResponsePlayFlow.GetRootAsIGiantResponsePlayFlow(_bb, default(IGiantResponsePlayFlow));
		}

		// Token: 0x0602B7E7 RID: 178151 RVA: 0x005EC9D8 File Offset: 0x005EABD8
		public static IGiantResponsePlayFlow GetRootAsIGiantResponsePlayFlow(ByteBuffer _bb, IGiantResponsePlayFlow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B7E8 RID: 178152 RVA: 0x005EC9F5 File Offset: 0x005EABF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B7E9 RID: 178153 RVA: 0x005ECA04 File Offset: 0x005EAC04
		public IGiantResponsePlayFlow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD1E RID: 48414
		// (get) Token: 0x0602B7EA RID: 178154 RVA: 0x005ECA14 File Offset: 0x005EAC14
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

		// Token: 0x1700BD1F RID: 48415
		// (get) Token: 0x0602B7EB RID: 178155 RVA: 0x005ECA50 File Offset: 0x005EAC50
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

		// Token: 0x0602B7EC RID: 178156 RVA: 0x005ECAAD File Offset: 0x005EACAD
		public static Offset<IGiantResponsePlayFlow> CreateIGiantResponsePlayFlow(FlatBufferBuilder builder, EGiantResponseType Type = EGiantResponseType.PlayAnimation, Offset<IGiantFlowConfig> FlowConfigOffset = default(Offset<IGiantFlowConfig>))
		{
			builder.StartTable(2);
			IGiantResponsePlayFlow.AddFlowConfig(builder, FlowConfigOffset);
			IGiantResponsePlayFlow.AddType(builder, Type);
			return IGiantResponsePlayFlow.EndIGiantResponsePlayFlow(builder);
		}

		// Token: 0x0602B7ED RID: 178157 RVA: 0x005ECACA File Offset: 0x005EACCA
		public static void StartIGiantResponsePlayFlow(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B7EE RID: 178158 RVA: 0x005ECAD3 File Offset: 0x005EACD3
		public static void AddType(FlatBufferBuilder builder, EGiantResponseType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B7EF RID: 178159 RVA: 0x005ECADE File Offset: 0x005EACDE
		public static void AddFlowConfig(FlatBufferBuilder builder, Offset<IGiantFlowConfig> flowConfigOffset)
		{
			builder.AddOffset(1, flowConfigOffset.Value, 0);
		}

		// Token: 0x0602B7F0 RID: 178160 RVA: 0x005ECAEE File Offset: 0x005EACEE
		public static Offset<IGiantResponsePlayFlow> EndIGiantResponsePlayFlow(FlatBufferBuilder builder)
		{
			return new Offset<IGiantResponsePlayFlow>(builder.EndTable());
		}

		// Token: 0x0602B7F1 RID: 178161 RVA: 0x005ECAFC File Offset: 0x005EACFC
		public IGiantResponsePlayFlowT UnPack()
		{
			IGiantResponsePlayFlowT giantResponsePlayFlowT = new IGiantResponsePlayFlowT();
			this.UnPackTo(giantResponsePlayFlowT);
			return giantResponsePlayFlowT;
		}

		// Token: 0x0602B7F2 RID: 178162 RVA: 0x005ECB18 File Offset: 0x005EAD18
		public void UnPackTo(IGiantResponsePlayFlowT _o)
		{
			_o.Type = this.Type;
			_o.FlowConfig = ((this.FlowConfig != null) ? this.FlowConfig.Value.UnPack() : null);
		}

		// Token: 0x0602B7F3 RID: 178163 RVA: 0x005ECB60 File Offset: 0x005EAD60
		public static Offset<IGiantResponsePlayFlow> Pack(FlatBufferBuilder builder, IGiantResponsePlayFlowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantResponsePlayFlow>);
			}
			Offset<IGiantFlowConfig> flowConfigOffset = (_o.FlowConfig == null) ? default(Offset<IGiantFlowConfig>) : IGiantFlowConfig.Pack(builder, _o.FlowConfig);
			return IGiantResponsePlayFlow.CreateIGiantResponsePlayFlow(builder, _o.Type, flowConfigOffset);
		}

		// Token: 0x04010500 RID: 66816
		private Table __p;
	}
}
