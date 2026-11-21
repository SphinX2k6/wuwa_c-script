using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D6 RID: 30166
	public struct IRemovePreloadFlows : IFlatbufferObject
	{
		// Token: 0x1700DDBB RID: 56763
		// (get) Token: 0x06034EB6 RID: 216758 RVA: 0x0071C708 File Offset: 0x0071A908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034EB7 RID: 216759 RVA: 0x0071C715 File Offset: 0x0071A915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034EB8 RID: 216760 RVA: 0x0071C71C File Offset: 0x0071A91C
		public static IRemovePreloadFlows GetRootAsIRemovePreloadFlows(ByteBuffer _bb)
		{
			return IRemovePreloadFlows.GetRootAsIRemovePreloadFlows(_bb, default(IRemovePreloadFlows));
		}

		// Token: 0x06034EB9 RID: 216761 RVA: 0x0071C738 File Offset: 0x0071A938
		public static IRemovePreloadFlows GetRootAsIRemovePreloadFlows(ByteBuffer _bb, IRemovePreloadFlows obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034EBA RID: 216762 RVA: 0x0071C755 File Offset: 0x0071A955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034EBB RID: 216763 RVA: 0x0071C764 File Offset: 0x0071A964
		public IRemovePreloadFlows __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DDBC RID: 56764
		// (get) Token: 0x06034EBC RID: 216764 RVA: 0x0071C774 File Offset: 0x0071A974
		public ERemovePreloadResourceObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return (ERemovePreloadResourceObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DDBD RID: 56765
		// (get) Token: 0x06034EBD RID: 216765 RVA: 0x0071C7B0 File Offset: 0x0071A9B0
		public IPlayFlow? FlowId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06034EBE RID: 216766 RVA: 0x0071C80D File Offset: 0x0071AA0D
		public static Offset<IRemovePreloadFlows> CreateIRemovePreloadFlows(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter, Offset<IPlayFlow> FlowIdOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IRemovePreloadFlows.AddFlowId(builder, FlowIdOffset);
			IRemovePreloadFlows.AddType(builder, Type);
			return IRemovePreloadFlows.EndIRemovePreloadFlows(builder);
		}

		// Token: 0x06034EBF RID: 216767 RVA: 0x0071C82A File Offset: 0x0071AA2A
		public static void StartIRemovePreloadFlows(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06034EC0 RID: 216768 RVA: 0x0071C833 File Offset: 0x0071AA33
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06034EC1 RID: 216769 RVA: 0x0071C83E File Offset: 0x0071AA3E
		public static void AddFlowId(FlatBufferBuilder builder, Offset<IPlayFlow> flowIdOffset)
		{
			builder.AddOffset(1, flowIdOffset.Value, 0);
		}

		// Token: 0x06034EC2 RID: 216770 RVA: 0x0071C84E File Offset: 0x0071AA4E
		public static Offset<IRemovePreloadFlows> EndIRemovePreloadFlows(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadFlows>(builder.EndTable());
		}

		// Token: 0x06034EC3 RID: 216771 RVA: 0x0071C85C File Offset: 0x0071AA5C
		public IRemovePreloadFlowsT UnPack()
		{
			IRemovePreloadFlowsT removePreloadFlowsT = new IRemovePreloadFlowsT();
			this.UnPackTo(removePreloadFlowsT);
			return removePreloadFlowsT;
		}

		// Token: 0x06034EC4 RID: 216772 RVA: 0x0071C878 File Offset: 0x0071AA78
		public void UnPackTo(IRemovePreloadFlowsT _o)
		{
			_o.Type = this.Type;
			_o.FlowId = ((this.FlowId != null) ? this.FlowId.Value.UnPack() : null);
		}

		// Token: 0x06034EC5 RID: 216773 RVA: 0x0071C8C0 File Offset: 0x0071AAC0
		public static Offset<IRemovePreloadFlows> Pack(FlatBufferBuilder builder, IRemovePreloadFlowsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadFlows>);
			}
			Offset<IPlayFlow> flowIdOffset = (_o.FlowId == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.FlowId);
			return IRemovePreloadFlows.CreateIRemovePreloadFlows(builder, _o.Type, flowIdOffset);
		}

		// Token: 0x040127BC RID: 75708
		private Table __p;
	}
}
