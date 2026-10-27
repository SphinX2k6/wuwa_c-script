using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F9 RID: 26361
	public struct IExecBattleAction : IFlatbufferObject
	{
		// Token: 0x1700C3E8 RID: 50152
		// (get) Token: 0x0602DD84 RID: 187780 RVA: 0x00644EF5 File Offset: 0x006430F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DD85 RID: 187781 RVA: 0x00644F02 File Offset: 0x00643102
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DD86 RID: 187782 RVA: 0x00644F0C File Offset: 0x0064310C
		public static IExecBattleAction GetRootAsIExecBattleAction(ByteBuffer _bb)
		{
			return IExecBattleAction.GetRootAsIExecBattleAction(_bb, default(IExecBattleAction));
		}

		// Token: 0x0602DD87 RID: 187783 RVA: 0x00644F28 File Offset: 0x00643128
		public static IExecBattleAction GetRootAsIExecBattleAction(ByteBuffer _bb, IExecBattleAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DD88 RID: 187784 RVA: 0x00644F45 File Offset: 0x00643145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DD89 RID: 187785 RVA: 0x00644F54 File Offset: 0x00643154
		public IExecBattleAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3E9 RID: 50153
		// (get) Token: 0x0602DD8A RID: 187786 RVA: 0x00644F64 File Offset: 0x00643164
		public TExecBattleOption BattleOptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TExecBattleOption.NONE;
				}
				return (TExecBattleOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DD8B RID: 187787 RVA: 0x00644FA0 File Offset: 0x006431A0
		public TTable? BattleOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DD8C RID: 187788 RVA: 0x00644FE4 File Offset: 0x006431E4
		public IExitMonsterMoveTarget BattleOptionAsIExitMonsterMoveTarget()
		{
			return this.BattleOption<IExitMonsterMoveTarget>().Value;
		}

		// Token: 0x0602DD8D RID: 187789 RVA: 0x00645000 File Offset: 0x00643200
		public IExitMonsterMoveWithSpline BattleOptionAsIExitMonsterMoveWithSpline()
		{
			return this.BattleOption<IExitMonsterMoveWithSpline>().Value;
		}

		// Token: 0x0602DD8E RID: 187790 RVA: 0x0064501C File Offset: 0x0064321C
		public ISendBattleEvents BattleOptionAsISendBattleEvents()
		{
			return this.BattleOption<ISendBattleEvents>().Value;
		}

		// Token: 0x0602DD8F RID: 187791 RVA: 0x00645038 File Offset: 0x00643238
		public ISendBattleEventsForMonsterSummon BattleOptionAsISendBattleEventsForMonsterSummon()
		{
			return this.BattleOption<ISendBattleEventsForMonsterSummon>().Value;
		}

		// Token: 0x0602DD90 RID: 187792 RVA: 0x00645054 File Offset: 0x00643254
		public ISetBattleTags BattleOptionAsISetBattleTags()
		{
			return this.BattleOption<ISetBattleTags>().Value;
		}

		// Token: 0x0602DD91 RID: 187793 RVA: 0x00645070 File Offset: 0x00643270
		public ISetMonsterMoveTarget BattleOptionAsISetMonsterMoveTarget()
		{
			return this.BattleOption<ISetMonsterMoveTarget>().Value;
		}

		// Token: 0x0602DD92 RID: 187794 RVA: 0x0064508C File Offset: 0x0064328C
		public ISetMonsterMoveWithSpline BattleOptionAsISetMonsterMoveWithSpline()
		{
			return this.BattleOption<ISetMonsterMoveWithSpline>().Value;
		}

		// Token: 0x0602DD93 RID: 187795 RVA: 0x006450A7 File Offset: 0x006432A7
		public static Offset<IExecBattleAction> CreateIExecBattleAction(FlatBufferBuilder builder, TExecBattleOption BattleOption_type = TExecBattleOption.NONE, int BattleOptionOffset = 0)
		{
			builder.StartTable(2);
			IExecBattleAction.AddBattleOption(builder, BattleOptionOffset);
			IExecBattleAction.AddBattleOptionType(builder, BattleOption_type);
			return IExecBattleAction.EndIExecBattleAction(builder);
		}

		// Token: 0x0602DD94 RID: 187796 RVA: 0x006450C4 File Offset: 0x006432C4
		public static void StartIExecBattleAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DD95 RID: 187797 RVA: 0x006450CD File Offset: 0x006432CD
		public static void AddBattleOptionType(FlatBufferBuilder builder, TExecBattleOption battleOptionType)
		{
			builder.AddByte(0, (byte)battleOptionType, 0);
		}

		// Token: 0x0602DD96 RID: 187798 RVA: 0x006450D8 File Offset: 0x006432D8
		public static void AddBattleOption(FlatBufferBuilder builder, int battleOptionOffset)
		{
			builder.AddOffset(1, battleOptionOffset, 0);
		}

		// Token: 0x0602DD97 RID: 187799 RVA: 0x006450E3 File Offset: 0x006432E3
		public static Offset<IExecBattleAction> EndIExecBattleAction(FlatBufferBuilder builder)
		{
			return new Offset<IExecBattleAction>(builder.EndTable());
		}

		// Token: 0x0602DD98 RID: 187800 RVA: 0x006450F0 File Offset: 0x006432F0
		public IExecBattleActionT UnPack()
		{
			IExecBattleActionT execBattleActionT = new IExecBattleActionT();
			this.UnPackTo(execBattleActionT);
			return execBattleActionT;
		}

		// Token: 0x0602DD99 RID: 187801 RVA: 0x0064510C File Offset: 0x0064330C
		public void UnPackTo(IExecBattleActionT _o)
		{
			_o.BattleOption = new TExecBattleOptionUnion();
			_o.BattleOption.Type = this.BattleOptionType;
			switch (this.BattleOptionType)
			{
			case TExecBattleOption.IExitMonsterMoveTarget:
				_o.BattleOption.Value = ((this.BattleOption<IExitMonsterMoveTarget>() != null) ? this.BattleOption<IExitMonsterMoveTarget>().Value.UnPack() : null);
				return;
			case TExecBattleOption.IExitMonsterMoveWithSpline:
				_o.BattleOption.Value = ((this.BattleOption<IExitMonsterMoveWithSpline>() != null) ? this.BattleOption<IExitMonsterMoveWithSpline>().Value.UnPack() : null);
				return;
			case TExecBattleOption.ISendBattleEvents:
				_o.BattleOption.Value = ((this.BattleOption<ISendBattleEvents>() != null) ? this.BattleOption<ISendBattleEvents>().Value.UnPack() : null);
				return;
			case TExecBattleOption.ISendBattleEventsForMonsterSummon:
				_o.BattleOption.Value = ((this.BattleOption<ISendBattleEventsForMonsterSummon>() != null) ? this.BattleOption<ISendBattleEventsForMonsterSummon>().Value.UnPack() : null);
				return;
			case TExecBattleOption.ISetBattleTags:
				_o.BattleOption.Value = ((this.BattleOption<ISetBattleTags>() != null) ? this.BattleOption<ISetBattleTags>().Value.UnPack() : null);
				return;
			case TExecBattleOption.ISetMonsterMoveTarget:
				_o.BattleOption.Value = ((this.BattleOption<ISetMonsterMoveTarget>() != null) ? this.BattleOption<ISetMonsterMoveTarget>().Value.UnPack() : null);
				return;
			case TExecBattleOption.ISetMonsterMoveWithSpline:
				_o.BattleOption.Value = ((this.BattleOption<ISetMonsterMoveWithSpline>() != null) ? this.BattleOption<ISetMonsterMoveWithSpline>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602DD9A RID: 187802 RVA: 0x006452E4 File Offset: 0x006434E4
		public static Offset<IExecBattleAction> Pack(FlatBufferBuilder builder, IExecBattleActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExecBattleAction>);
			}
			TExecBattleOption battleOption_type = (_o.BattleOption == null) ? TExecBattleOption.NONE : _o.BattleOption.Type;
			int battleOptionOffset = (_o.BattleOption == null) ? 0 : TExecBattleOptionUnion.Pack(builder, _o.BattleOption);
			return IExecBattleAction.CreateIExecBattleAction(builder, battleOption_type, battleOptionOffset);
		}

		// Token: 0x04010DD0 RID: 69072
		private Table __p;
	}
}
