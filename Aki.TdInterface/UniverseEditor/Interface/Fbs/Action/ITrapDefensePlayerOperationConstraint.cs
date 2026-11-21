using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C4D RID: 31821
	public struct ITrapDefensePlayerOperationConstraint : IFlatbufferObject
	{
		// Token: 0x1700EE3B RID: 60987
		// (get) Token: 0x060395BA RID: 234938 RVA: 0x007BE971 File Offset: 0x007BCB71
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060395BB RID: 234939 RVA: 0x007BE97E File Offset: 0x007BCB7E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060395BC RID: 234940 RVA: 0x007BE988 File Offset: 0x007BCB88
		public static ITrapDefensePlayerOperationConstraint GetRootAsITrapDefensePlayerOperationConstraint(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationConstraint.GetRootAsITrapDefensePlayerOperationConstraint(_bb, default(ITrapDefensePlayerOperationConstraint));
		}

		// Token: 0x060395BD RID: 234941 RVA: 0x007BE9A4 File Offset: 0x007BCBA4
		public static ITrapDefensePlayerOperationConstraint GetRootAsITrapDefensePlayerOperationConstraint(ByteBuffer _bb, ITrapDefensePlayerOperationConstraint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060395BE RID: 234942 RVA: 0x007BE9C1 File Offset: 0x007BCBC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060395BF RID: 234943 RVA: 0x007BE9D0 File Offset: 0x007BCBD0
		public ITrapDefensePlayerOperationConstraint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE3C RID: 60988
		// (get) Token: 0x060395C0 RID: 234944 RVA: 0x007BE9E0 File Offset: 0x007BCBE0
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

		// Token: 0x060395C1 RID: 234945 RVA: 0x007BEA1C File Offset: 0x007BCC1C
		public TTable? DisableOperation<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060395C2 RID: 234946 RVA: 0x007BEA60 File Offset: 0x007BCC60
		public ITrapDefensePlayerOperationConstructTrap DisableOperationAsITrapDefensePlayerOperationConstructTrap()
		{
			return this.DisableOperation<ITrapDefensePlayerOperationConstructTrap>().Value;
		}

		// Token: 0x060395C3 RID: 234947 RVA: 0x007BEA7C File Offset: 0x007BCC7C
		public ITrapDefensePlayerOperationRecycleTrap DisableOperationAsITrapDefensePlayerOperationRecycleTrap()
		{
			return this.DisableOperation<ITrapDefensePlayerOperationRecycleTrap>().Value;
		}

		// Token: 0x060395C4 RID: 234948 RVA: 0x007BEA98 File Offset: 0x007BCC98
		public ITrapDefensePlayerOperationSpawnMonster DisableOperationAsITrapDefensePlayerOperationSpawnMonster()
		{
			return this.DisableOperation<ITrapDefensePlayerOperationSpawnMonster>().Value;
		}

		// Token: 0x1700EE3D RID: 60989
		// (get) Token: 0x060395C5 RID: 234949 RVA: 0x007BEAB4 File Offset: 0x007BCCB4
		public bool IsConstrained
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EE3E RID: 60990
		// (get) Token: 0x060395C6 RID: 234950 RVA: 0x007BEAF4 File Offset: 0x007BCCF4
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

		// Token: 0x060395C7 RID: 234951 RVA: 0x007BEB2C File Offset: 0x007BCD2C
		public Span<byte> GetTidPromptTxtBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060395C8 RID: 234952 RVA: 0x007BEB3C File Offset: 0x007BCD3C
		public byte[] GetTidPromptTxtArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x060395C9 RID: 234953 RVA: 0x007BEB4B File Offset: 0x007BCD4B
		public static Offset<ITrapDefensePlayerOperationConstraint> CreateITrapDefensePlayerOperationConstraint(FlatBufferBuilder builder, TTrapDefensePlayerOperationType DisableOperation_type = TTrapDefensePlayerOperationType.NONE, int DisableOperationOffset = 0, bool IsConstrained = false, StringOffset TidPromptTxtOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ITrapDefensePlayerOperationConstraint.AddTidPromptTxt(builder, TidPromptTxtOffset);
			ITrapDefensePlayerOperationConstraint.AddDisableOperation(builder, DisableOperationOffset);
			ITrapDefensePlayerOperationConstraint.AddIsConstrained(builder, IsConstrained);
			ITrapDefensePlayerOperationConstraint.AddDisableOperationType(builder, DisableOperation_type);
			return ITrapDefensePlayerOperationConstraint.EndITrapDefensePlayerOperationConstraint(builder);
		}

		// Token: 0x060395CA RID: 234954 RVA: 0x007BEB77 File Offset: 0x007BCD77
		public static void StartITrapDefensePlayerOperationConstraint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060395CB RID: 234955 RVA: 0x007BEB80 File Offset: 0x007BCD80
		public static void AddDisableOperationType(FlatBufferBuilder builder, TTrapDefensePlayerOperationType disableOperationType)
		{
			builder.AddByte(0, (byte)disableOperationType, 0);
		}

		// Token: 0x060395CC RID: 234956 RVA: 0x007BEB8B File Offset: 0x007BCD8B
		public static void AddDisableOperation(FlatBufferBuilder builder, int disableOperationOffset)
		{
			builder.AddOffset(1, disableOperationOffset, 0);
		}

		// Token: 0x060395CD RID: 234957 RVA: 0x007BEB96 File Offset: 0x007BCD96
		public static void AddIsConstrained(FlatBufferBuilder builder, bool isConstrained)
		{
			builder.AddBool(2, isConstrained, false);
		}

		// Token: 0x060395CE RID: 234958 RVA: 0x007BEBA1 File Offset: 0x007BCDA1
		public static void AddTidPromptTxt(FlatBufferBuilder builder, StringOffset tidPromptTxtOffset)
		{
			builder.AddOffset(3, tidPromptTxtOffset.Value, 0);
		}

		// Token: 0x060395CF RID: 234959 RVA: 0x007BEBB1 File Offset: 0x007BCDB1
		public static Offset<ITrapDefensePlayerOperationConstraint> EndITrapDefensePlayerOperationConstraint(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationConstraint>(builder.EndTable());
		}

		// Token: 0x060395D0 RID: 234960 RVA: 0x007BEBC0 File Offset: 0x007BCDC0
		public ITrapDefensePlayerOperationConstraintT UnPack()
		{
			ITrapDefensePlayerOperationConstraintT trapDefensePlayerOperationConstraintT = new ITrapDefensePlayerOperationConstraintT();
			this.UnPackTo(trapDefensePlayerOperationConstraintT);
			return trapDefensePlayerOperationConstraintT;
		}

		// Token: 0x060395D1 RID: 234961 RVA: 0x007BEBDC File Offset: 0x007BCDDC
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

		// Token: 0x060395D2 RID: 234962 RVA: 0x007BECE4 File Offset: 0x007BCEE4
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

		// Token: 0x0401330A RID: 78602
		private Table __p;
	}
}
