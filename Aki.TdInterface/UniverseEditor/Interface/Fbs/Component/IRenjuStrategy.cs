using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585B RID: 22619
	public struct IRenjuStrategy : IFlatbufferObject
	{
		// Token: 0x1700A90D RID: 43277
		// (get) Token: 0x0602613D RID: 155965 RVA: 0x0053FE1D File Offset: 0x0053E01D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602613E RID: 155966 RVA: 0x0053FE2A File Offset: 0x0053E02A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602613F RID: 155967 RVA: 0x0053FE34 File Offset: 0x0053E034
		public static IRenjuStrategy GetRootAsIRenjuStrategy(ByteBuffer _bb)
		{
			return IRenjuStrategy.GetRootAsIRenjuStrategy(_bb, default(IRenjuStrategy));
		}

		// Token: 0x06026140 RID: 155968 RVA: 0x0053FE50 File Offset: 0x0053E050
		public static IRenjuStrategy GetRootAsIRenjuStrategy(ByteBuffer _bb, IRenjuStrategy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026141 RID: 155969 RVA: 0x0053FE6D File Offset: 0x0053E06D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026142 RID: 155970 RVA: 0x0053FE7C File Offset: 0x0053E07C
		public IRenjuStrategy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A90E RID: 43278
		// (get) Token: 0x06026143 RID: 155971 RVA: 0x0053FE8C File Offset: 0x0053E08C
		public EAiGearStrategy Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAiGearStrategy.RenjuStrategy;
				}
				return (EAiGearStrategy)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A90F RID: 43279
		// (get) Token: 0x06026144 RID: 155972 RVA: 0x0053FEC8 File Offset: 0x0053E0C8
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A910 RID: 43280
		// (get) Token: 0x06026145 RID: 155973 RVA: 0x0053FF28 File Offset: 0x0053E128
		public int Chessboard
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A911 RID: 43281
		// (get) Token: 0x06026146 RID: 155974 RVA: 0x0053FF64 File Offset: 0x0053E164
		public string CommonConfig
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

		// Token: 0x06026147 RID: 155975 RVA: 0x0053FF9C File Offset: 0x0053E19C
		public Span<byte> GetCommonConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06026148 RID: 155976 RVA: 0x0053FFAC File Offset: 0x0053E1AC
		public byte[] GetCommonConfigArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A912 RID: 43282
		// (get) Token: 0x06026149 RID: 155977 RVA: 0x0053FFBC File Offset: 0x0053E1BC
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

		// Token: 0x0602614A RID: 155978 RVA: 0x0053FFF9 File Offset: 0x0053E1F9
		public static Offset<IRenjuStrategy> CreateIRenjuStrategy(FlatBufferBuilder builder, EAiGearStrategy Type = EAiGearStrategy.RenjuStrategy, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), int Chessboard = 0, StringOffset CommonConfigOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IRenjuStrategy.AddCommonConfig(builder, CommonConfigOffset);
			IRenjuStrategy.AddChessboard(builder, Chessboard);
			IRenjuStrategy.AddCondition(builder, ConditionOffset);
			IRenjuStrategy.AddNullMask(builder, NullMask);
			IRenjuStrategy.AddType(builder, Type);
			return IRenjuStrategy.EndIRenjuStrategy(builder);
		}

		// Token: 0x0602614B RID: 155979 RVA: 0x0054002D File Offset: 0x0053E22D
		public static void StartIRenjuStrategy(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602614C RID: 155980 RVA: 0x00540036 File Offset: 0x0053E236
		public static void AddType(FlatBufferBuilder builder, EAiGearStrategy type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602614D RID: 155981 RVA: 0x00540041 File Offset: 0x0053E241
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0602614E RID: 155982 RVA: 0x00540051 File Offset: 0x0053E251
		public static void AddChessboard(FlatBufferBuilder builder, int chessboard)
		{
			builder.AddInt(2, chessboard, 0);
		}

		// Token: 0x0602614F RID: 155983 RVA: 0x0054005C File Offset: 0x0053E25C
		public static void AddCommonConfig(FlatBufferBuilder builder, StringOffset commonConfigOffset)
		{
			builder.AddOffset(3, commonConfigOffset.Value, 0);
		}

		// Token: 0x06026150 RID: 155984 RVA: 0x0054006C File Offset: 0x0053E26C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06026151 RID: 155985 RVA: 0x00540077 File Offset: 0x0053E277
		public static Offset<IRenjuStrategy> EndIRenjuStrategy(FlatBufferBuilder builder)
		{
			return new Offset<IRenjuStrategy>(builder.EndTable());
		}

		// Token: 0x06026152 RID: 155986 RVA: 0x00540084 File Offset: 0x0053E284
		public IRenjuStrategyT UnPack()
		{
			IRenjuStrategyT renjuStrategyT = new IRenjuStrategyT();
			this.UnPackTo(renjuStrategyT);
			return renjuStrategyT;
		}

		// Token: 0x06026153 RID: 155987 RVA: 0x005400A0 File Offset: 0x0053E2A0
		public void UnPackTo(IRenjuStrategyT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Chessboard = this.Chessboard;
			_o.CommonConfig = this.CommonConfig;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026154 RID: 155988 RVA: 0x0054010C File Offset: 0x0053E30C
		public static Offset<IRenjuStrategy> Pack(FlatBufferBuilder builder, IRenjuStrategyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRenjuStrategy>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			StringOffset commonConfigOffset = (_o.CommonConfig == null) ? default(StringOffset) : builder.CreateString(_o.CommonConfig);
			return IRenjuStrategy.CreateIRenjuStrategy(builder, _o.Type, conditionOffset, _o.Chessboard, commonConfigOffset, _o.NullMask);
		}

		// Token: 0x0400ED8B RID: 60811
		private Table __p;
	}
}
