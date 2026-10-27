using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E55 RID: 28245
	public struct IRemovePreloadFlows : IFlatbufferObject
	{
		// Token: 0x1700D269 RID: 53865
		// (get) Token: 0x06031E8E RID: 204430 RVA: 0x006C0C08 File Offset: 0x006BEE08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031E8F RID: 204431 RVA: 0x006C0C15 File Offset: 0x006BEE15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031E90 RID: 204432 RVA: 0x006C0C1C File Offset: 0x006BEE1C
		public static IRemovePreloadFlows GetRootAsIRemovePreloadFlows(ByteBuffer _bb)
		{
			return IRemovePreloadFlows.GetRootAsIRemovePreloadFlows(_bb, default(IRemovePreloadFlows));
		}

		// Token: 0x06031E91 RID: 204433 RVA: 0x006C0C38 File Offset: 0x006BEE38
		public static IRemovePreloadFlows GetRootAsIRemovePreloadFlows(ByteBuffer _bb, IRemovePreloadFlows obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031E92 RID: 204434 RVA: 0x006C0C55 File Offset: 0x006BEE55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031E93 RID: 204435 RVA: 0x006C0C64 File Offset: 0x006BEE64
		public IRemovePreloadFlows __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D26A RID: 53866
		// (get) Token: 0x06031E94 RID: 204436 RVA: 0x006C0C74 File Offset: 0x006BEE74
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

		// Token: 0x1700D26B RID: 53867
		// (get) Token: 0x06031E95 RID: 204437 RVA: 0x006C0CB0 File Offset: 0x006BEEB0
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

		// Token: 0x06031E96 RID: 204438 RVA: 0x006C0D0D File Offset: 0x006BEF0D
		public static Offset<IRemovePreloadFlows> CreateIRemovePreloadFlows(FlatBufferBuilder builder, ERemovePreloadResourceObjectType Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter, Offset<IPlayFlow> FlowIdOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(2);
			IRemovePreloadFlows.AddFlowId(builder, FlowIdOffset);
			IRemovePreloadFlows.AddType(builder, Type);
			return IRemovePreloadFlows.EndIRemovePreloadFlows(builder);
		}

		// Token: 0x06031E97 RID: 204439 RVA: 0x006C0D2A File Offset: 0x006BEF2A
		public static void StartIRemovePreloadFlows(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031E98 RID: 204440 RVA: 0x006C0D33 File Offset: 0x006BEF33
		public static void AddType(FlatBufferBuilder builder, ERemovePreloadResourceObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031E99 RID: 204441 RVA: 0x006C0D3E File Offset: 0x006BEF3E
		public static void AddFlowId(FlatBufferBuilder builder, Offset<IPlayFlow> flowIdOffset)
		{
			builder.AddOffset(1, flowIdOffset.Value, 0);
		}

		// Token: 0x06031E9A RID: 204442 RVA: 0x006C0D4E File Offset: 0x006BEF4E
		public static Offset<IRemovePreloadFlows> EndIRemovePreloadFlows(FlatBufferBuilder builder)
		{
			return new Offset<IRemovePreloadFlows>(builder.EndTable());
		}

		// Token: 0x06031E9B RID: 204443 RVA: 0x006C0D5C File Offset: 0x006BEF5C
		public IRemovePreloadFlowsT UnPack()
		{
			IRemovePreloadFlowsT removePreloadFlowsT = new IRemovePreloadFlowsT();
			this.UnPackTo(removePreloadFlowsT);
			return removePreloadFlowsT;
		}

		// Token: 0x06031E9C RID: 204444 RVA: 0x006C0D78 File Offset: 0x006BEF78
		public void UnPackTo(IRemovePreloadFlowsT _o)
		{
			_o.Type = this.Type;
			_o.FlowId = ((this.FlowId != null) ? this.FlowId.Value.UnPack() : null);
		}

		// Token: 0x06031E9D RID: 204445 RVA: 0x006C0DC0 File Offset: 0x006BEFC0
		public static Offset<IRemovePreloadFlows> Pack(FlatBufferBuilder builder, IRemovePreloadFlowsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemovePreloadFlows>);
			}
			Offset<IPlayFlow> flowIdOffset = (_o.FlowId == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.FlowId);
			return IRemovePreloadFlows.CreateIRemovePreloadFlows(builder, _o.Type, flowIdOffset);
		}

		// Token: 0x0401183A RID: 71738
		private Table __p;
	}
}
