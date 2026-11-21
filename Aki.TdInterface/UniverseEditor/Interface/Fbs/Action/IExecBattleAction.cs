using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D79 RID: 28025
	public struct IExecBattleAction : IFlatbufferObject
	{
		// Token: 0x1700CD9E RID: 52638
		// (get) Token: 0x060305C1 RID: 198081 RVA: 0x00692469 File Offset: 0x00690669
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060305C2 RID: 198082 RVA: 0x00692476 File Offset: 0x00690676
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060305C3 RID: 198083 RVA: 0x00692480 File Offset: 0x00690680
		public static IExecBattleAction GetRootAsIExecBattleAction(ByteBuffer _bb)
		{
			return IExecBattleAction.GetRootAsIExecBattleAction(_bb, default(IExecBattleAction));
		}

		// Token: 0x060305C4 RID: 198084 RVA: 0x0069249C File Offset: 0x0069069C
		public static IExecBattleAction GetRootAsIExecBattleAction(ByteBuffer _bb, IExecBattleAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060305C5 RID: 198085 RVA: 0x006924B9 File Offset: 0x006906B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060305C6 RID: 198086 RVA: 0x006924C8 File Offset: 0x006906C8
		public IExecBattleAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD9F RID: 52639
		// (get) Token: 0x060305C7 RID: 198087 RVA: 0x006924D8 File Offset: 0x006906D8
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

		// Token: 0x060305C8 RID: 198088 RVA: 0x00692514 File Offset: 0x00690714
		public TTable? BattleOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060305C9 RID: 198089 RVA: 0x00692558 File Offset: 0x00690758
		public IAiAssistCharacterMoveToPoint BattleOptionAsIAiAssistCharacterMoveToPoint()
		{
			return this.BattleOption<IAiAssistCharacterMoveToPoint>().Value;
		}

		// Token: 0x060305CA RID: 198090 RVA: 0x00692574 File Offset: 0x00690774
		public IAiAssistCharacterStopMoveToPoint BattleOptionAsIAiAssistCharacterStopMoveToPoint()
		{
			return this.BattleOption<IAiAssistCharacterStopMoveToPoint>().Value;
		}

		// Token: 0x060305CB RID: 198091 RVA: 0x00692590 File Offset: 0x00690790
		public IExitMonsterMoveTarget BattleOptionAsIExitMonsterMoveTarget()
		{
			return this.BattleOption<IExitMonsterMoveTarget>().Value;
		}

		// Token: 0x060305CC RID: 198092 RVA: 0x006925AC File Offset: 0x006907AC
		public IExitMonsterMoveWithSpline BattleOptionAsIExitMonsterMoveWithSpline()
		{
			return this.BattleOption<IExitMonsterMoveWithSpline>().Value;
		}

		// Token: 0x060305CD RID: 198093 RVA: 0x006925C8 File Offset: 0x006907C8
		public ISendBattleEvents BattleOptionAsISendBattleEvents()
		{
			return this.BattleOption<ISendBattleEvents>().Value;
		}

		// Token: 0x060305CE RID: 198094 RVA: 0x006925E4 File Offset: 0x006907E4
		public ISendBattleEventsForMonsterSummon BattleOptionAsISendBattleEventsForMonsterSummon()
		{
			return this.BattleOption<ISendBattleEventsForMonsterSummon>().Value;
		}

		// Token: 0x060305CF RID: 198095 RVA: 0x00692600 File Offset: 0x00690800
		public ISetBattleTags BattleOptionAsISetBattleTags()
		{
			return this.BattleOption<ISetBattleTags>().Value;
		}

		// Token: 0x060305D0 RID: 198096 RVA: 0x0069261C File Offset: 0x0069081C
		public ISetMonsterMoveTarget BattleOptionAsISetMonsterMoveTarget()
		{
			return this.BattleOption<ISetMonsterMoveTarget>().Value;
		}

		// Token: 0x060305D1 RID: 198097 RVA: 0x00692638 File Offset: 0x00690838
		public ISetMonsterMoveWithSpline BattleOptionAsISetMonsterMoveWithSpline()
		{
			return this.BattleOption<ISetMonsterMoveWithSpline>().Value;
		}

		// Token: 0x060305D2 RID: 198098 RVA: 0x00692653 File Offset: 0x00690853
		public static Offset<IExecBattleAction> CreateIExecBattleAction(FlatBufferBuilder builder, TExecBattleOption BattleOption_type = TExecBattleOption.NONE, int BattleOptionOffset = 0)
		{
			builder.StartTable(2);
			IExecBattleAction.AddBattleOption(builder, BattleOptionOffset);
			IExecBattleAction.AddBattleOptionType(builder, BattleOption_type);
			return IExecBattleAction.EndIExecBattleAction(builder);
		}

		// Token: 0x060305D3 RID: 198099 RVA: 0x00692670 File Offset: 0x00690870
		public static void StartIExecBattleAction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060305D4 RID: 198100 RVA: 0x00692679 File Offset: 0x00690879
		public static void AddBattleOptionType(FlatBufferBuilder builder, TExecBattleOption battleOptionType)
		{
			builder.AddByte(0, (byte)battleOptionType, 0);
		}

		// Token: 0x060305D5 RID: 198101 RVA: 0x00692684 File Offset: 0x00690884
		public static void AddBattleOption(FlatBufferBuilder builder, int battleOptionOffset)
		{
			builder.AddOffset(1, battleOptionOffset, 0);
		}

		// Token: 0x060305D6 RID: 198102 RVA: 0x0069268F File Offset: 0x0069088F
		public static Offset<IExecBattleAction> EndIExecBattleAction(FlatBufferBuilder builder)
		{
			return new Offset<IExecBattleAction>(builder.EndTable());
		}

		// Token: 0x060305D7 RID: 198103 RVA: 0x0069269C File Offset: 0x0069089C
		public IExecBattleActionT UnPack()
		{
			IExecBattleActionT execBattleActionT = new IExecBattleActionT();
			this.UnPackTo(execBattleActionT);
			return execBattleActionT;
		}

		// Token: 0x060305D8 RID: 198104 RVA: 0x006926B8 File Offset: 0x006908B8
		public void UnPackTo(IExecBattleActionT _o)
		{
			_o.BattleOption = new TExecBattleOptionUnion();
			_o.BattleOption.Type = this.BattleOptionType;
			switch (this.BattleOptionType)
			{
			case TExecBattleOption.IAiAssistCharacterMoveToPoint:
				_o.BattleOption.Value = ((this.BattleOption<IAiAssistCharacterMoveToPoint>() != null) ? this.BattleOption<IAiAssistCharacterMoveToPoint>().Value.UnPack() : null);
				return;
			case TExecBattleOption.IAiAssistCharacterStopMoveToPoint:
				_o.BattleOption.Value = ((this.BattleOption<IAiAssistCharacterStopMoveToPoint>() != null) ? this.BattleOption<IAiAssistCharacterStopMoveToPoint>().Value.UnPack() : null);
				return;
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

		// Token: 0x060305D9 RID: 198105 RVA: 0x00692908 File Offset: 0x00690B08
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

		// Token: 0x04011BFF RID: 72703
		private Table __p;
	}
}
