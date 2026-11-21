using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E68 RID: 24168
	public struct IRenjuStrategy : IFlatbufferObject
	{
		// Token: 0x1700B23D RID: 45629
		// (get) Token: 0x0602869F RID: 165535 RVA: 0x00586969 File Offset: 0x00584B69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060286A0 RID: 165536 RVA: 0x00586976 File Offset: 0x00584B76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060286A1 RID: 165537 RVA: 0x00586980 File Offset: 0x00584B80
		public static IRenjuStrategy GetRootAsIRenjuStrategy(ByteBuffer _bb)
		{
			return IRenjuStrategy.GetRootAsIRenjuStrategy(_bb, default(IRenjuStrategy));
		}

		// Token: 0x060286A2 RID: 165538 RVA: 0x0058699C File Offset: 0x00584B9C
		public static IRenjuStrategy GetRootAsIRenjuStrategy(ByteBuffer _bb, IRenjuStrategy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060286A3 RID: 165539 RVA: 0x005869B9 File Offset: 0x00584BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060286A4 RID: 165540 RVA: 0x005869C8 File Offset: 0x00584BC8
		public IRenjuStrategy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B23E RID: 45630
		// (get) Token: 0x060286A5 RID: 165541 RVA: 0x005869D8 File Offset: 0x00584BD8
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

		// Token: 0x1700B23F RID: 45631
		// (get) Token: 0x060286A6 RID: 165542 RVA: 0x00586A14 File Offset: 0x00584C14
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

		// Token: 0x1700B240 RID: 45632
		// (get) Token: 0x060286A7 RID: 165543 RVA: 0x00586A74 File Offset: 0x00584C74
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

		// Token: 0x1700B241 RID: 45633
		// (get) Token: 0x060286A8 RID: 165544 RVA: 0x00586AB0 File Offset: 0x00584CB0
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

		// Token: 0x060286A9 RID: 165545 RVA: 0x00586AE8 File Offset: 0x00584CE8
		public Span<byte> GetCommonConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060286AA RID: 165546 RVA: 0x00586AF8 File Offset: 0x00584CF8
		public byte[] GetCommonConfigArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700B242 RID: 45634
		// (get) Token: 0x060286AB RID: 165547 RVA: 0x00586B08 File Offset: 0x00584D08
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

		// Token: 0x060286AC RID: 165548 RVA: 0x00586B45 File Offset: 0x00584D45
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

		// Token: 0x060286AD RID: 165549 RVA: 0x00586B79 File Offset: 0x00584D79
		public static void StartIRenjuStrategy(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060286AE RID: 165550 RVA: 0x00586B82 File Offset: 0x00584D82
		public static void AddType(FlatBufferBuilder builder, EAiGearStrategy type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060286AF RID: 165551 RVA: 0x00586B8D File Offset: 0x00584D8D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060286B0 RID: 165552 RVA: 0x00586B9D File Offset: 0x00584D9D
		public static void AddChessboard(FlatBufferBuilder builder, int chessboard)
		{
			builder.AddInt(2, chessboard, 0);
		}

		// Token: 0x060286B1 RID: 165553 RVA: 0x00586BA8 File Offset: 0x00584DA8
		public static void AddCommonConfig(FlatBufferBuilder builder, StringOffset commonConfigOffset)
		{
			builder.AddOffset(3, commonConfigOffset.Value, 0);
		}

		// Token: 0x060286B2 RID: 165554 RVA: 0x00586BB8 File Offset: 0x00584DB8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060286B3 RID: 165555 RVA: 0x00586BC3 File Offset: 0x00584DC3
		public static Offset<IRenjuStrategy> EndIRenjuStrategy(FlatBufferBuilder builder)
		{
			return new Offset<IRenjuStrategy>(builder.EndTable());
		}

		// Token: 0x060286B4 RID: 165556 RVA: 0x00586BD0 File Offset: 0x00584DD0
		public IRenjuStrategyT UnPack()
		{
			IRenjuStrategyT renjuStrategyT = new IRenjuStrategyT();
			this.UnPackTo(renjuStrategyT);
			return renjuStrategyT;
		}

		// Token: 0x060286B5 RID: 165557 RVA: 0x00586BEC File Offset: 0x00584DEC
		public void UnPackTo(IRenjuStrategyT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Chessboard = this.Chessboard;
			_o.CommonConfig = this.CommonConfig;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060286B6 RID: 165558 RVA: 0x00586C58 File Offset: 0x00584E58
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

		// Token: 0x0400FA7E RID: 64126
		private Table __p;
	}
}
