using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200624B RID: 25163
	public struct IBvbPlayerOperationConstraint : IFlatbufferObject
	{
		// Token: 0x1700BB88 RID: 48008
		// (get) Token: 0x0602B63E RID: 177726 RVA: 0x005F9045 File Offset: 0x005F7245
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B63F RID: 177727 RVA: 0x005F9052 File Offset: 0x005F7252
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B640 RID: 177728 RVA: 0x005F905C File Offset: 0x005F725C
		public static IBvbPlayerOperationConstraint GetRootAsIBvbPlayerOperationConstraint(ByteBuffer _bb)
		{
			return IBvbPlayerOperationConstraint.GetRootAsIBvbPlayerOperationConstraint(_bb, default(IBvbPlayerOperationConstraint));
		}

		// Token: 0x0602B641 RID: 177729 RVA: 0x005F9078 File Offset: 0x005F7278
		public static IBvbPlayerOperationConstraint GetRootAsIBvbPlayerOperationConstraint(ByteBuffer _bb, IBvbPlayerOperationConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B642 RID: 177730 RVA: 0x005F9095 File Offset: 0x005F7295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B643 RID: 177731 RVA: 0x005F90A4 File Offset: 0x005F72A4
		public IBvbPlayerOperationConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB89 RID: 48009
		// (get) Token: 0x0602B644 RID: 177732 RVA: 0x005F90B4 File Offset: 0x005F72B4
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

		// Token: 0x0602B645 RID: 177733 RVA: 0x005F90F0 File Offset: 0x005F72F0
		public TTable? EnableOperation<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B646 RID: 177734 RVA: 0x005F9134 File Offset: 0x005F7334
		public IBvbChangeBoardCard EnableOperationAsIBvbChangeBoardCard()
		{
			return this.EnableOperation<IBvbChangeBoardCard>().Value;
		}

		// Token: 0x0602B647 RID: 177735 RVA: 0x005F9150 File Offset: 0x005F7350
		public IBvbChangeHandCard EnableOperationAsIBvbChangeHandCard()
		{
			return this.EnableOperation<IBvbChangeHandCard>().Value;
		}

		// Token: 0x0602B648 RID: 177736 RVA: 0x005F916C File Offset: 0x005F736C
		public IBvbDeploy EnableOperationAsIBvbDeploy()
		{
			return this.EnableOperation<IBvbDeploy>().Value;
		}

		// Token: 0x0602B649 RID: 177737 RVA: 0x005F9188 File Offset: 0x005F7388
		public IBvbEndTurn EnableOperationAsIBvbEndTurn()
		{
			return this.EnableOperation<IBvbEndTurn>().Value;
		}

		// Token: 0x0602B64A RID: 177738 RVA: 0x005F91A4 File Offset: 0x005F73A4
		public IBvbEvolution EnableOperationAsIBvbEvolution()
		{
			return this.EnableOperation<IBvbEvolution>().Value;
		}

		// Token: 0x0602B64B RID: 177739 RVA: 0x005F91C0 File Offset: 0x005F73C0
		public IBvbRecycleBoardCard EnableOperationAsIBvbRecycleBoardCard()
		{
			return this.EnableOperation<IBvbRecycleBoardCard>().Value;
		}

		// Token: 0x0602B64C RID: 177740 RVA: 0x005F91DC File Offset: 0x005F73DC
		public IBvbRecycleHandCard EnableOperationAsIBvbRecycleHandCard()
		{
			return this.EnableOperation<IBvbRecycleHandCard>().Value;
		}

		// Token: 0x0602B64D RID: 177741 RVA: 0x005F91F8 File Offset: 0x005F73F8
		public IBvbSelectCard EnableOperationAsIBvbSelectCard()
		{
			return this.EnableOperation<IBvbSelectCard>().Value;
		}

		// Token: 0x0602B64E RID: 177742 RVA: 0x005F9214 File Offset: 0x005F7414
		public IBvbUseFieldCardSkill EnableOperationAsIBvbUseFieldCardSkill()
		{
			return this.EnableOperation<IBvbUseFieldCardSkill>().Value;
		}

		// Token: 0x0602B64F RID: 177743 RVA: 0x005F9230 File Offset: 0x005F7430
		public IBvbUseItemCardSkill EnableOperationAsIBvbUseItemCardSkill()
		{
			return this.EnableOperation<IBvbUseItemCardSkill>().Value;
		}

		// Token: 0x1700BB8A RID: 48010
		// (get) Token: 0x0602B650 RID: 177744 RVA: 0x005F924C File Offset: 0x005F744C
		public bool IsTheLast
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BB8B RID: 48011
		// (get) Token: 0x0602B651 RID: 177745 RVA: 0x005F928C File Offset: 0x005F748C
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

		// Token: 0x0602B652 RID: 177746 RVA: 0x005F92C4 File Offset: 0x005F74C4
		public Span<byte> GetTidPromptTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602B653 RID: 177747 RVA: 0x005F92D4 File Offset: 0x005F74D4
		public byte[] GetTidPromptTxtArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700BB8C RID: 48012
		// (get) Token: 0x0602B654 RID: 177748 RVA: 0x005F92E4 File Offset: 0x005F74E4
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

		// Token: 0x0602B655 RID: 177749 RVA: 0x005F9321 File Offset: 0x005F7521
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

		// Token: 0x0602B656 RID: 177750 RVA: 0x005F9355 File Offset: 0x005F7555
		public static void StartIBvbPlayerOperationConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602B657 RID: 177751 RVA: 0x005F935E File Offset: 0x005F755E
		public static void AddEnableOperationType(FlatBufferBuilder builder, TBvbPlayerOperationType enableOperationType)
		{
			builder.AddByte(0, (byte)enableOperationType, 0);
		}

		// Token: 0x0602B658 RID: 177752 RVA: 0x005F9369 File Offset: 0x005F7569
		public static void AddEnableOperation(FlatBufferBuilder builder, int enableOperationOffset)
		{
			builder.AddOffset(1, enableOperationOffset, 0);
		}

		// Token: 0x0602B659 RID: 177753 RVA: 0x005F9374 File Offset: 0x005F7574
		public static void AddIsTheLast(FlatBufferBuilder builder, bool isTheLast)
		{
			builder.AddBool(2, isTheLast, false);
		}

		// Token: 0x0602B65A RID: 177754 RVA: 0x005F937F File Offset: 0x005F757F
		public static void AddTidPromptTxt(FlatBufferBuilder builder, StringOffset tidPromptTxtOffset)
		{
			builder.AddOffset(3, tidPromptTxtOffset.Value, 0);
		}

		// Token: 0x0602B65B RID: 177755 RVA: 0x005F938F File Offset: 0x005F758F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602B65C RID: 177756 RVA: 0x005F939A File Offset: 0x005F759A
		public static Offset<IBvbPlayerOperationConstraint> EndIBvbPlayerOperationConstraint(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerOperationConstraint>(builder.EndTable());
		}

		// Token: 0x0602B65D RID: 177757 RVA: 0x005F93A8 File Offset: 0x005F75A8
		public IBvbPlayerOperationConstraintT UnPack()
		{
			IBvbPlayerOperationConstraintT bvbPlayerOperationConstraintT = new IBvbPlayerOperationConstraintT();
			this.UnPackTo(bvbPlayerOperationConstraintT);
			return bvbPlayerOperationConstraintT;
		}

		// Token: 0x0602B65E RID: 177758 RVA: 0x005F93C4 File Offset: 0x005F75C4
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

		// Token: 0x0602B65F RID: 177759 RVA: 0x005F9698 File Offset: 0x005F7898
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

		// Token: 0x04010797 RID: 67479
		private Table __p;
	}
}
