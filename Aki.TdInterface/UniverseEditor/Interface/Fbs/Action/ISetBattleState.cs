using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007780 RID: 30592
	public struct ISetBattleState : IFlatbufferObject
	{
		// Token: 0x1700E02E RID: 57390
		// (get) Token: 0x06035B1D RID: 219933 RVA: 0x00731F03 File Offset: 0x00730103
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B1E RID: 219934 RVA: 0x00731F10 File Offset: 0x00730110
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B1F RID: 219935 RVA: 0x00731F18 File Offset: 0x00730118
		public static ISetBattleState GetRootAsISetBattleState(ByteBuffer _bb)
		{
			return ISetBattleState.GetRootAsISetBattleState(_bb, default(ISetBattleState));
		}

		// Token: 0x06035B20 RID: 219936 RVA: 0x00731F34 File Offset: 0x00730134
		public static ISetBattleState GetRootAsISetBattleState(ByteBuffer _bb, ISetBattleState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B21 RID: 219937 RVA: 0x00731F51 File Offset: 0x00730151
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B22 RID: 219938 RVA: 0x00731F60 File Offset: 0x00730160
		public ISetBattleState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E02F RID: 57391
		// (get) Token: 0x06035B23 RID: 219939 RVA: 0x00731F70 File Offset: 0x00730170
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

		// Token: 0x06035B24 RID: 219940 RVA: 0x00731FAC File Offset: 0x007301AC
		public TTable? StateOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035B25 RID: 219941 RVA: 0x00731FF0 File Offset: 0x007301F0
		public INotifyMonsterPerception StateOptionAsINotifyMonsterPerception()
		{
			return this.StateOption<INotifyMonsterPerception>().Value;
		}

		// Token: 0x06035B26 RID: 219942 RVA: 0x0073200C File Offset: 0x0073020C
		public INotifyMonsterPlayStandbyTags StateOptionAsINotifyMonsterPlayStandbyTags()
		{
			return this.StateOption<INotifyMonsterPlayStandbyTags>().Value;
		}

		// Token: 0x06035B27 RID: 219943 RVA: 0x00732028 File Offset: 0x00730228
		public ISetBattleTag StateOptionAsISetBattleTag()
		{
			return this.StateOption<ISetBattleTag>().Value;
		}

		// Token: 0x06035B28 RID: 219944 RVA: 0x00732043 File Offset: 0x00730243
		public static Offset<ISetBattleState> CreateISetBattleState(FlatBufferBuilder builder, TStateOption StateOption_type = TStateOption.NONE, int StateOptionOffset = 0)
		{
			builder.StartTable(2);
			ISetBattleState.AddStateOption(builder, StateOptionOffset);
			ISetBattleState.AddStateOptionType(builder, StateOption_type);
			return ISetBattleState.EndISetBattleState(builder);
		}

		// Token: 0x06035B29 RID: 219945 RVA: 0x00732060 File Offset: 0x00730260
		public static void StartISetBattleState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035B2A RID: 219946 RVA: 0x00732069 File Offset: 0x00730269
		public static void AddStateOptionType(FlatBufferBuilder builder, TStateOption stateOptionType)
		{
			builder.AddByte(0, (byte)stateOptionType, 0);
		}

		// Token: 0x06035B2B RID: 219947 RVA: 0x00732074 File Offset: 0x00730274
		public static void AddStateOption(FlatBufferBuilder builder, int stateOptionOffset)
		{
			builder.AddOffset(1, stateOptionOffset, 0);
		}

		// Token: 0x06035B2C RID: 219948 RVA: 0x0073207F File Offset: 0x0073027F
		public static Offset<ISetBattleState> EndISetBattleState(FlatBufferBuilder builder)
		{
			return new Offset<ISetBattleState>(builder.EndTable());
		}

		// Token: 0x06035B2D RID: 219949 RVA: 0x0073208C File Offset: 0x0073028C
		public ISetBattleStateT UnPack()
		{
			ISetBattleStateT setBattleStateT = new ISetBattleStateT();
			this.UnPackTo(setBattleStateT);
			return setBattleStateT;
		}

		// Token: 0x06035B2E RID: 219950 RVA: 0x007320A8 File Offset: 0x007302A8
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

		// Token: 0x06035B2F RID: 219951 RVA: 0x00732190 File Offset: 0x00730390
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

		// Token: 0x040129A2 RID: 76194
		private Table __p;
	}
}
