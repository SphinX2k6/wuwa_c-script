using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745A RID: 29786
	public struct ITrapDefensePlayerOperationConstraint : IFlatbufferObject
	{
		// Token: 0x1700E21E RID: 57886
		// (get) Token: 0x060361D1 RID: 221649 RVA: 0x0075BC45 File Offset: 0x00759E45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060361D2 RID: 221650 RVA: 0x0075BC52 File Offset: 0x00759E52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060361D3 RID: 221651 RVA: 0x0075BC5C File Offset: 0x00759E5C
		public static ITrapDefensePlayerOperationConstraint GetRootAsITrapDefensePlayerOperationConstraint(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationConstraint.GetRootAsITrapDefensePlayerOperationConstraint(_bb, default(ITrapDefensePlayerOperationConstraint));
		}

		// Token: 0x060361D4 RID: 221652 RVA: 0x0075BC78 File Offset: 0x00759E78
		public static ITrapDefensePlayerOperationConstraint GetRootAsITrapDefensePlayerOperationConstraint(ByteBuffer _bb, ITrapDefensePlayerOperationConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060361D5 RID: 221653 RVA: 0x0075BC95 File Offset: 0x00759E95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060361D6 RID: 221654 RVA: 0x0075BCA4 File Offset: 0x00759EA4
		public ITrapDefensePlayerOperationConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E21F RID: 57887
		// (get) Token: 0x060361D7 RID: 221655 RVA: 0x0075BCB4 File Offset: 0x00759EB4
		public TTrapDefensePlayerOperationType DisableOperationType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTrapDefensePlayerOperationType.NONE;
				}
				return (TTrapDefensePlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060361D8 RID: 221656 RVA: 0x0075BCF0 File Offset: 0x00759EF0
		public TTable? DisableOperation<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060361D9 RID: 221657 RVA: 0x0075BD34 File Offset: 0x00759F34
		public ITrapDefensePlayerOperationConstructTrap DisableOperationAsITrapDefensePlayerOperationConstructTrap()
		{
			return this.DisableOperation<ITrapDefensePlayerOperationConstructTrap>().Value;
		}

		// Token: 0x060361DA RID: 221658 RVA: 0x0075BD50 File Offset: 0x00759F50
		public ITrapDefensePlayerOperationRecycleTrap DisableOperationAsITrapDefensePlayerOperationRecycleTrap()
		{
			return this.DisableOperation<ITrapDefensePlayerOperationRecycleTrap>().Value;
		}

		// Token: 0x060361DB RID: 221659 RVA: 0x0075BD6C File Offset: 0x00759F6C
		public ITrapDefensePlayerOperationSpawnMonster DisableOperationAsITrapDefensePlayerOperationSpawnMonster()
		{
			return this.DisableOperation<ITrapDefensePlayerOperationSpawnMonster>().Value;
		}

		// Token: 0x1700E220 RID: 57888
		// (get) Token: 0x060361DC RID: 221660 RVA: 0x0075BD88 File Offset: 0x00759F88
		public bool IsConstrained
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E221 RID: 57889
		// (get) Token: 0x060361DD RID: 221661 RVA: 0x0075BDC8 File Offset: 0x00759FC8
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

		// Token: 0x060361DE RID: 221662 RVA: 0x0075BE00 File Offset: 0x0075A000
		public Span<byte> GetTidPromptTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060361DF RID: 221663 RVA: 0x0075BE10 File Offset: 0x0075A010
		public byte[] GetTidPromptTxtArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060361E0 RID: 221664 RVA: 0x0075BE1F File Offset: 0x0075A01F
		public static Offset<ITrapDefensePlayerOperationConstraint> CreateITrapDefensePlayerOperationConstraint(FlatBufferBuilder builder, TTrapDefensePlayerOperationType DisableOperation_type = TTrapDefensePlayerOperationType.NONE, int DisableOperationOffset = 0, bool IsConstrained = false, StringOffset TidPromptTxtOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ITrapDefensePlayerOperationConstraint.AddTidPromptTxt(builder, TidPromptTxtOffset);
			ITrapDefensePlayerOperationConstraint.AddDisableOperation(builder, DisableOperationOffset);
			ITrapDefensePlayerOperationConstraint.AddIsConstrained(builder, IsConstrained);
			ITrapDefensePlayerOperationConstraint.AddDisableOperationType(builder, DisableOperation_type);
			return ITrapDefensePlayerOperationConstraint.EndITrapDefensePlayerOperationConstraint(builder);
		}

		// Token: 0x060361E1 RID: 221665 RVA: 0x0075BE4B File Offset: 0x0075A04B
		public static void StartITrapDefensePlayerOperationConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060361E2 RID: 221666 RVA: 0x0075BE54 File Offset: 0x0075A054
		public static void AddDisableOperationType(FlatBufferBuilder builder, TTrapDefensePlayerOperationType disableOperationType)
		{
			builder.AddByte(0, (byte)disableOperationType, 0);
		}

		// Token: 0x060361E3 RID: 221667 RVA: 0x0075BE5F File Offset: 0x0075A05F
		public static void AddDisableOperation(FlatBufferBuilder builder, int disableOperationOffset)
		{
			builder.AddOffset(1, disableOperationOffset, 0);
		}

		// Token: 0x060361E4 RID: 221668 RVA: 0x0075BE6A File Offset: 0x0075A06A
		public static void AddIsConstrained(FlatBufferBuilder builder, bool isConstrained)
		{
			builder.AddBool(2, isConstrained, false);
		}

		// Token: 0x060361E5 RID: 221669 RVA: 0x0075BE75 File Offset: 0x0075A075
		public static void AddTidPromptTxt(FlatBufferBuilder builder, StringOffset tidPromptTxtOffset)
		{
			builder.AddOffset(3, tidPromptTxtOffset.Value, 0);
		}

		// Token: 0x060361E6 RID: 221670 RVA: 0x0075BE85 File Offset: 0x0075A085
		public static Offset<ITrapDefensePlayerOperationConstraint> EndITrapDefensePlayerOperationConstraint(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationConstraint>(builder.EndTable());
		}

		// Token: 0x060361E7 RID: 221671 RVA: 0x0075BE94 File Offset: 0x0075A094
		public ITrapDefensePlayerOperationConstraintT UnPack()
		{
			ITrapDefensePlayerOperationConstraintT trapDefensePlayerOperationConstraintT = new ITrapDefensePlayerOperationConstraintT();
			this.UnPackTo(trapDefensePlayerOperationConstraintT);
			return trapDefensePlayerOperationConstraintT;
		}

		// Token: 0x060361E8 RID: 221672 RVA: 0x0075BEB0 File Offset: 0x0075A0B0
		public void UnPackTo(ITrapDefensePlayerOperationConstraintT _o)
		{
			_o.DisableOperation = new TTrapDefensePlayerOperationTypeUnion();
			_o.DisableOperation.Type = this.DisableOperationType;
			switch (this.DisableOperationType)
			{
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationConstructTrap:
				_o.DisableOperation.Value = ((this.DisableOperation<ITrapDefensePlayerOperationConstructTrap>() != null) ? this.DisableOperation<ITrapDefensePlayerOperationConstructTrap>().Value.UnPack() : null);
				break;
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationRecycleTrap:
				_o.DisableOperation.Value = ((this.DisableOperation<ITrapDefensePlayerOperationRecycleTrap>() != null) ? this.DisableOperation<ITrapDefensePlayerOperationRecycleTrap>().Value.UnPack() : null);
				break;
			case TTrapDefensePlayerOperationType.ITrapDefensePlayerOperationSpawnMonster:
				_o.DisableOperation.Value = ((this.DisableOperation<ITrapDefensePlayerOperationSpawnMonster>() != null) ? this.DisableOperation<ITrapDefensePlayerOperationSpawnMonster>().Value.UnPack() : null);
				break;
			}
			_o.IsConstrained = this.IsConstrained;
			_o.TidPromptTxt = this.TidPromptTxt;
		}

		// Token: 0x060361E9 RID: 221673 RVA: 0x0075BFB8 File Offset: 0x0075A1B8
		public static Offset<ITrapDefensePlayerOperationConstraint> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationConstraintT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationConstraint>);
			}
			TTrapDefensePlayerOperationType disableOperation_type = (_o.DisableOperation == null) ? TTrapDefensePlayerOperationType.NONE : _o.DisableOperation.Type;
			int disableOperationOffset = (_o.DisableOperation == null) ? 0 : TTrapDefensePlayerOperationTypeUnion.Pack(builder, _o.DisableOperation);
			StringOffset tidPromptTxtOffset = (_o.TidPromptTxt == null) ? default(StringOffset) : builder.CreateString(_o.TidPromptTxt);
			return ITrapDefensePlayerOperationConstraint.CreateITrapDefensePlayerOperationConstraint(builder, disableOperation_type, disableOperationOffset, _o.IsConstrained, tidPromptTxtOffset);
		}

		// Token: 0x040122E3 RID: 74467
		private Table __p;
	}
}
