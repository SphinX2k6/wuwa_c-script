using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D5 RID: 22485
	public struct IRaceStrategy : IFlatbufferObject
	{
		// Token: 0x1700A7DC RID: 42972
		// (get) Token: 0x06025C0C RID: 154636 RVA: 0x00534D10 File Offset: 0x00532F10
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025C0D RID: 154637 RVA: 0x00534D1D File Offset: 0x00532F1D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025C0E RID: 154638 RVA: 0x00534D24 File Offset: 0x00532F24
		public static IRaceStrategy GetRootAsIRaceStrategy(ByteBuffer _bb)
		{
			return IRaceStrategy.GetRootAsIRaceStrategy(_bb, default(IRaceStrategy));
		}

		// Token: 0x06025C0F RID: 154639 RVA: 0x00534D40 File Offset: 0x00532F40
		public static IRaceStrategy GetRootAsIRaceStrategy(ByteBuffer _bb, IRaceStrategy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025C10 RID: 154640 RVA: 0x00534D5D File Offset: 0x00532F5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025C11 RID: 154641 RVA: 0x00534D6C File Offset: 0x00532F6C
		public IRaceStrategy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A7DD RID: 42973
		// (get) Token: 0x06025C12 RID: 154642 RVA: 0x00534D7C File Offset: 0x00532F7C
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

		// Token: 0x1700A7DE RID: 42974
		// (get) Token: 0x06025C13 RID: 154643 RVA: 0x00534DB8 File Offset: 0x00532FB8
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

		// Token: 0x1700A7DF RID: 42975
		// (get) Token: 0x06025C14 RID: 154644 RVA: 0x00534E18 File Offset: 0x00533018
		public int SplineEntityId
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

		// Token: 0x1700A7E0 RID: 42976
		// (get) Token: 0x06025C15 RID: 154645 RVA: 0x00534E54 File Offset: 0x00533054
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

		// Token: 0x06025C16 RID: 154646 RVA: 0x00534E8C File Offset: 0x0053308C
		public Span<byte> GetCommonConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06025C17 RID: 154647 RVA: 0x00534E9C File Offset: 0x0053309C
		public byte[] GetCommonConfigArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06025C18 RID: 154648 RVA: 0x00534EAB File Offset: 0x005330AB
		public static Offset<IRaceStrategy> CreateIRaceStrategy(FlatBufferBuilder builder, EAiGearStrategy Type = EAiGearStrategy.RenjuStrategy, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), int SplineEntityId = 0, StringOffset CommonConfigOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IRaceStrategy.AddCommonConfig(builder, CommonConfigOffset);
			IRaceStrategy.AddSplineEntityId(builder, SplineEntityId);
			IRaceStrategy.AddCondition(builder, ConditionOffset);
			IRaceStrategy.AddType(builder, Type);
			return IRaceStrategy.EndIRaceStrategy(builder);
		}

		// Token: 0x06025C19 RID: 154649 RVA: 0x00534ED7 File Offset: 0x005330D7
		public static void StartIRaceStrategy(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06025C1A RID: 154650 RVA: 0x00534EE0 File Offset: 0x005330E0
		public static void AddType(FlatBufferBuilder builder, EAiGearStrategy type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025C1B RID: 154651 RVA: 0x00534EEB File Offset: 0x005330EB
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06025C1C RID: 154652 RVA: 0x00534EFB File Offset: 0x005330FB
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06025C1D RID: 154653 RVA: 0x00534F06 File Offset: 0x00533106
		public static void AddCommonConfig(FlatBufferBuilder builder, StringOffset commonConfigOffset)
		{
			builder.AddOffset(3, commonConfigOffset.Value, 0);
		}

		// Token: 0x06025C1E RID: 154654 RVA: 0x00534F16 File Offset: 0x00533116
		public static Offset<IRaceStrategy> EndIRaceStrategy(FlatBufferBuilder builder)
		{
			return new Offset<IRaceStrategy>(builder.EndTable());
		}

		// Token: 0x06025C1F RID: 154655 RVA: 0x00534F24 File Offset: 0x00533124
		public IRaceStrategyT UnPack()
		{
			IRaceStrategyT raceStrategyT = new IRaceStrategyT();
			this.UnPackTo(raceStrategyT);
			return raceStrategyT;
		}

		// Token: 0x06025C20 RID: 154656 RVA: 0x00534F40 File Offset: 0x00533140
		public void UnPackTo(IRaceStrategyT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.CommonConfig = this.CommonConfig;
		}

		// Token: 0x06025C21 RID: 154657 RVA: 0x00534FA0 File Offset: 0x005331A0
		public static Offset<IRaceStrategy> Pack(FlatBufferBuilder builder, IRaceStrategyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRaceStrategy>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			StringOffset commonConfigOffset = (_o.CommonConfig == null) ? default(StringOffset) : builder.CreateString(_o.CommonConfig);
			return IRaceStrategy.CreateIRaceStrategy(builder, _o.Type, conditionOffset, _o.SplineEntityId, commonConfigOffset);
		}

		// Token: 0x0400ECBA RID: 60602
		private Table __p;
	}
}
