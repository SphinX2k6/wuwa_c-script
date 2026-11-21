using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BC RID: 26812
	public struct IBvbPlayerOperationConstraint : IFlatbufferObject
	{
		// Token: 0x1700C510 RID: 50448
		// (get) Token: 0x0602DD9F RID: 187807 RVA: 0x00643E4D File Offset: 0x0064204D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DDA0 RID: 187808 RVA: 0x00643E5A File Offset: 0x0064205A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DDA1 RID: 187809 RVA: 0x00643E64 File Offset: 0x00642064
		public static IBvbPlayerOperationConstraint GetRootAsIBvbPlayerOperationConstraint(ByteBuffer _bb)
		{
			return IBvbPlayerOperationConstraint.GetRootAsIBvbPlayerOperationConstraint(_bb, default(IBvbPlayerOperationConstraint));
		}

		// Token: 0x0602DDA2 RID: 187810 RVA: 0x00643E80 File Offset: 0x00642080
		public static IBvbPlayerOperationConstraint GetRootAsIBvbPlayerOperationConstraint(ByteBuffer _bb, IBvbPlayerOperationConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DDA3 RID: 187811 RVA: 0x00643E9D File Offset: 0x0064209D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DDA4 RID: 187812 RVA: 0x00643EAC File Offset: 0x006420AC
		public IBvbPlayerOperationConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C511 RID: 50449
		// (get) Token: 0x0602DDA5 RID: 187813 RVA: 0x00643EBC File Offset: 0x006420BC
		public TBvbPlayerOperationType EnableOperationType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TBvbPlayerOperationType.NONE;
				}
				return (TBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DDA6 RID: 187814 RVA: 0x00643EF8 File Offset: 0x006420F8
		public TTable? EnableOperation<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DDA7 RID: 187815 RVA: 0x00643F3C File Offset: 0x0064213C
		public IBvbChangeBoardCard EnableOperationAsIBvbChangeBoardCard()
		{
			return this.EnableOperation<IBvbChangeBoardCard>().Value;
		}

		// Token: 0x0602DDA8 RID: 187816 RVA: 0x00643F58 File Offset: 0x00642158
		public IBvbChangeHandCard EnableOperationAsIBvbChangeHandCard()
		{
			return this.EnableOperation<IBvbChangeHandCard>().Value;
		}

		// Token: 0x0602DDA9 RID: 187817 RVA: 0x00643F74 File Offset: 0x00642174
		public IBvbDeploy EnableOperationAsIBvbDeploy()
		{
			return this.EnableOperation<IBvbDeploy>().Value;
		}

		// Token: 0x0602DDAA RID: 187818 RVA: 0x00643F90 File Offset: 0x00642190
		public IBvbEndTurn EnableOperationAsIBvbEndTurn()
		{
			return this.EnableOperation<IBvbEndTurn>().Value;
		}

		// Token: 0x0602DDAB RID: 187819 RVA: 0x00643FAC File Offset: 0x006421AC
		public IBvbEvolution EnableOperationAsIBvbEvolution()
		{
			return this.EnableOperation<IBvbEvolution>().Value;
		}

		// Token: 0x0602DDAC RID: 187820 RVA: 0x00643FC8 File Offset: 0x006421C8
		public IBvbRecycleBoardCard EnableOperationAsIBvbRecycleBoardCard()
		{
			return this.EnableOperation<IBvbRecycleBoardCard>().Value;
		}

		// Token: 0x0602DDAD RID: 187821 RVA: 0x00643FE4 File Offset: 0x006421E4
		public IBvbRecycleHandCard EnableOperationAsIBvbRecycleHandCard()
		{
			return this.EnableOperation<IBvbRecycleHandCard>().Value;
		}

		// Token: 0x0602DDAE RID: 187822 RVA: 0x00644000 File Offset: 0x00642200
		public IBvbSelectCard EnableOperationAsIBvbSelectCard()
		{
			return this.EnableOperation<IBvbSelectCard>().Value;
		}

		// Token: 0x0602DDAF RID: 187823 RVA: 0x0064401C File Offset: 0x0064221C
		public IBvbUseFieldCardSkill EnableOperationAsIBvbUseFieldCardSkill()
		{
			return this.EnableOperation<IBvbUseFieldCardSkill>().Value;
		}

		// Token: 0x0602DDB0 RID: 187824 RVA: 0x00644038 File Offset: 0x00642238
		public IBvbUseItemCardSkill EnableOperationAsIBvbUseItemCardSkill()
		{
			return this.EnableOperation<IBvbUseItemCardSkill>().Value;
		}

		// Token: 0x1700C512 RID: 50450
		// (get) Token: 0x0602DDB1 RID: 187825 RVA: 0x00644054 File Offset: 0x00642254
		public bool IsTheLast
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C513 RID: 50451
		// (get) Token: 0x0602DDB2 RID: 187826 RVA: 0x00644094 File Offset: 0x00642294
		public string TidPromptTxt
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

		// Token: 0x0602DDB3 RID: 187827 RVA: 0x006440CC File Offset: 0x006422CC
		public Span<byte> GetTidPromptTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602DDB4 RID: 187828 RVA: 0x006440DC File Offset: 0x006422DC
		public byte[] GetTidPromptTxtArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C514 RID: 50452
		// (get) Token: 0x0602DDB5 RID: 187829 RVA: 0x006440EC File Offset: 0x006422EC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DDB6 RID: 187830 RVA: 0x00644129 File Offset: 0x00642329
		public static Offset<IBvbPlayerOperationConstraint> CreateIBvbPlayerOperationConstraint(FlatBufferBuilder builder, TBvbPlayerOperationType EnableOperation_type = TBvbPlayerOperationType.NONE, int EnableOperationOffset = 0, bool IsTheLast = false, StringOffset TidPromptTxtOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IBvbPlayerOperationConstraint.AddTidPromptTxt(builder, TidPromptTxtOffset);
			IBvbPlayerOperationConstraint.AddEnableOperation(builder, EnableOperationOffset);
			IBvbPlayerOperationConstraint.AddNullMask(builder, NullMask);
			IBvbPlayerOperationConstraint.AddIsTheLast(builder, IsTheLast);
			IBvbPlayerOperationConstraint.AddEnableOperationType(builder, EnableOperation_type);
			return IBvbPlayerOperationConstraint.EndIBvbPlayerOperationConstraint(builder);
		}

		// Token: 0x0602DDB7 RID: 187831 RVA: 0x0064415D File Offset: 0x0064235D
		public static void StartIBvbPlayerOperationConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602DDB8 RID: 187832 RVA: 0x00644166 File Offset: 0x00642366
		public static void AddEnableOperationType(FlatBufferBuilder builder, TBvbPlayerOperationType enableOperationType)
		{
			builder.AddByte(0, (byte)enableOperationType, 0);
		}

		// Token: 0x0602DDB9 RID: 187833 RVA: 0x00644171 File Offset: 0x00642371
		public static void AddEnableOperation(FlatBufferBuilder builder, int enableOperationOffset)
		{
			builder.AddOffset(1, enableOperationOffset, 0);
		}

		// Token: 0x0602DDBA RID: 187834 RVA: 0x0064417C File Offset: 0x0064237C
		public static void AddIsTheLast(FlatBufferBuilder builder, bool isTheLast)
		{
			builder.AddBool(2, isTheLast, false);
		}

		// Token: 0x0602DDBB RID: 187835 RVA: 0x00644187 File Offset: 0x00642387
		public static void AddTidPromptTxt(FlatBufferBuilder builder, StringOffset tidPromptTxtOffset)
		{
			builder.AddOffset(3, tidPromptTxtOffset.Value, 0);
		}

		// Token: 0x0602DDBC RID: 187836 RVA: 0x00644197 File Offset: 0x00642397
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602DDBD RID: 187837 RVA: 0x006441A2 File Offset: 0x006423A2
		public static Offset<IBvbPlayerOperationConstraint> EndIBvbPlayerOperationConstraint(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerOperationConstraint>(builder.EndTable());
		}

		// Token: 0x0602DDBE RID: 187838 RVA: 0x006441B0 File Offset: 0x006423B0
		public IBvbPlayerOperationConstraintT UnPack()
		{
			IBvbPlayerOperationConstraintT bvbPlayerOperationConstraintT = new IBvbPlayerOperationConstraintT();
			this.UnPackTo(bvbPlayerOperationConstraintT);
			return bvbPlayerOperationConstraintT;
		}

		// Token: 0x0602DDBF RID: 187839 RVA: 0x006441CC File Offset: 0x006423CC
		public void UnPackTo(IBvbPlayerOperationConstraintT _o)
		{
			_o.EnableOperation = new TBvbPlayerOperationTypeUnion();
			_o.EnableOperation.Type = this.EnableOperationType;
			switch (this.EnableOperationType)
			{
			case TBvbPlayerOperationType.IBvbChangeBoardCard:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbChangeBoardCard>() != null) ? this.EnableOperation<IBvbChangeBoardCard>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbChangeHandCard:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbChangeHandCard>() != null) ? this.EnableOperation<IBvbChangeHandCard>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbDeploy:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbDeploy>() != null) ? this.EnableOperation<IBvbDeploy>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbEndTurn:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbEndTurn>() != null) ? this.EnableOperation<IBvbEndTurn>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbEvolution:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbEvolution>() != null) ? this.EnableOperation<IBvbEvolution>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbRecycleBoardCard:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbRecycleBoardCard>() != null) ? this.EnableOperation<IBvbRecycleBoardCard>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbRecycleHandCard:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbRecycleHandCard>() != null) ? this.EnableOperation<IBvbRecycleHandCard>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbSelectCard:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbSelectCard>() != null) ? this.EnableOperation<IBvbSelectCard>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbUseFieldCardSkill:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbUseFieldCardSkill>() != null) ? this.EnableOperation<IBvbUseFieldCardSkill>().Value.UnPack() : null);
				break;
			case TBvbPlayerOperationType.IBvbUseItemCardSkill:
				_o.EnableOperation.Value = ((this.EnableOperation<IBvbUseItemCardSkill>() != null) ? this.EnableOperation<IBvbUseItemCardSkill>().Value.UnPack() : null);
				break;
			}
			_o.IsTheLast = this.IsTheLast;
			_o.TidPromptTxt = this.TidPromptTxt;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DDC0 RID: 187840 RVA: 0x006444A0 File Offset: 0x006426A0
		public static Offset<IBvbPlayerOperationConstraint> Pack(FlatBufferBuilder builder, IBvbPlayerOperationConstraintT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerOperationConstraint>);
			}
			TBvbPlayerOperationType enableOperation_type = (_o.EnableOperation == null) ? TBvbPlayerOperationType.NONE : _o.EnableOperation.Type;
			int enableOperationOffset = (_o.EnableOperation == null) ? 0 : TBvbPlayerOperationTypeUnion.Pack(builder, _o.EnableOperation);
			StringOffset tidPromptTxtOffset = (_o.TidPromptTxt == null) ? default(StringOffset) : builder.CreateString(_o.TidPromptTxt);
			return IBvbPlayerOperationConstraint.CreateIBvbPlayerOperationConstraint(builder, enableOperation_type, enableOperationOffset, _o.IsTheLast, tidPromptTxtOffset, _o.NullMask);
		}

		// Token: 0x040115AC RID: 71084
		private Table __p;
	}
}
