using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FB7 RID: 28599
	public struct ISetBattleState : IFlatbufferObject
	{
		// Token: 0x1700D45A RID: 54362
		// (get) Token: 0x060328B7 RID: 207031 RVA: 0x006D22BF File Offset: 0x006D04BF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060328B8 RID: 207032 RVA: 0x006D22CC File Offset: 0x006D04CC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060328B9 RID: 207033 RVA: 0x006D22D4 File Offset: 0x006D04D4
		public static ISetBattleState GetRootAsISetBattleState(ByteBuffer _bb)
		{
			return ISetBattleState.GetRootAsISetBattleState(_bb, default(ISetBattleState));
		}

		// Token: 0x060328BA RID: 207034 RVA: 0x006D22F0 File Offset: 0x006D04F0
		public static ISetBattleState GetRootAsISetBattleState(ByteBuffer _bb, ISetBattleState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060328BB RID: 207035 RVA: 0x006D230D File Offset: 0x006D050D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060328BC RID: 207036 RVA: 0x006D231C File Offset: 0x006D051C
		public ISetBattleState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D45B RID: 54363
		// (get) Token: 0x060328BD RID: 207037 RVA: 0x006D232C File Offset: 0x006D052C
		public TStateOption StateOptionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TStateOption.NONE;
				}
				return (TStateOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060328BE RID: 207038 RVA: 0x006D2368 File Offset: 0x006D0568
		public TTable? StateOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060328BF RID: 207039 RVA: 0x006D23AC File Offset: 0x006D05AC
		public INotifyMonsterPerception StateOptionAsINotifyMonsterPerception()
		{
			return this.StateOption<INotifyMonsterPerception>().Value;
		}

		// Token: 0x060328C0 RID: 207040 RVA: 0x006D23C8 File Offset: 0x006D05C8
		public INotifyMonsterPlayStandbyTags StateOptionAsINotifyMonsterPlayStandbyTags()
		{
			return this.StateOption<INotifyMonsterPlayStandbyTags>().Value;
		}

		// Token: 0x060328C1 RID: 207041 RVA: 0x006D23E4 File Offset: 0x006D05E4
		public ISetBattleTag StateOptionAsISetBattleTag()
		{
			return this.StateOption<ISetBattleTag>().Value;
		}

		// Token: 0x060328C2 RID: 207042 RVA: 0x006D23FF File Offset: 0x006D05FF
		public static Offset<ISetBattleState> CreateISetBattleState(FlatBufferBuilder builder, TStateOption StateOption_type = TStateOption.NONE, int StateOptionOffset = 0)
		{
			builder.StartTable(2);
			ISetBattleState.AddStateOption(builder, StateOptionOffset);
			ISetBattleState.AddStateOptionType(builder, StateOption_type);
			return ISetBattleState.EndISetBattleState(builder);
		}

		// Token: 0x060328C3 RID: 207043 RVA: 0x006D241C File Offset: 0x006D061C
		public static void StartISetBattleState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060328C4 RID: 207044 RVA: 0x006D2425 File Offset: 0x006D0625
		public static void AddStateOptionType(FlatBufferBuilder builder, TStateOption stateOptionType)
		{
			builder.AddByte(0, (byte)stateOptionType, 0);
		}

		// Token: 0x060328C5 RID: 207045 RVA: 0x006D2430 File Offset: 0x006D0630
		public static void AddStateOption(FlatBufferBuilder builder, int stateOptionOffset)
		{
			builder.AddOffset(1, stateOptionOffset, 0);
		}

		// Token: 0x060328C6 RID: 207046 RVA: 0x006D243B File Offset: 0x006D063B
		public static Offset<ISetBattleState> EndISetBattleState(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleState>(builder.EndTable());
		}

		// Token: 0x060328C7 RID: 207047 RVA: 0x006D2448 File Offset: 0x006D0648
		public ISetBattleStateT UnPack()
		{
			ISetBattleStateT setBattleStateT = new ISetBattleStateT();
			this.UnPackTo(setBattleStateT);
			return setBattleStateT;
		}

		// Token: 0x060328C8 RID: 207048 RVA: 0x006D2464 File Offset: 0x006D0664
		public void UnPackTo(ISetBattleStateT _o)
		{
			_o.StateOption = new TStateOptionUnion();
			_o.StateOption.Type = this.StateOptionType;
			switch (this.StateOptionType)
			{
			case TStateOption.INotifyMonsterPerception:
				_o.StateOption.Value = ((this.StateOption<INotifyMonsterPerception>() != null) ? this.StateOption<INotifyMonsterPerception>().Value.UnPack() : null);
				return;
			case TStateOption.INotifyMonsterPlayStandbyTags:
				_o.StateOption.Value = ((this.StateOption<INotifyMonsterPlayStandbyTags>() != null) ? this.StateOption<INotifyMonsterPlayStandbyTags>().Value.UnPack() : null);
				return;
			case TStateOption.ISetBattleTag:
				_o.StateOption.Value = ((this.StateOption<ISetBattleTag>() != null) ? this.StateOption<ISetBattleTag>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060328C9 RID: 207049 RVA: 0x006D254C File Offset: 0x006D074C
		public static Offset<ISetBattleState> Pack(FlatBufferBuilder builder, ISetBattleStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBattleState>);
			}
			TStateOption stateOption_type = (_o.StateOption == null) ? TStateOption.NONE : _o.StateOption.Type;
			int stateOptionOffset = (_o.StateOption == null) ? 0 : TStateOptionUnion.Pack(builder, _o.StateOption);
			return ISetBattleState.CreateISetBattleState(builder, stateOption_type, stateOptionOffset);
		}

		// Token: 0x040119BD RID: 72125
		private Table __p;
	}
}
