using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DDC RID: 24028
	public struct IRaceStrategy : IFlatbufferObject
	{
		// Token: 0x1700B100 RID: 45312
		// (get) Token: 0x0602812C RID: 164140 RVA: 0x0057AE9C File Offset: 0x0057909C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602812D RID: 164141 RVA: 0x0057AEA9 File Offset: 0x005790A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602812E RID: 164142 RVA: 0x0057AEB0 File Offset: 0x005790B0
		public static IRaceStrategy GetRootAsIRaceStrategy(ByteBuffer _bb)
		{
			return IRaceStrategy.GetRootAsIRaceStrategy(_bb, default(IRaceStrategy));
		}

		// Token: 0x0602812F RID: 164143 RVA: 0x0057AECC File Offset: 0x005790CC
		public static IRaceStrategy GetRootAsIRaceStrategy(ByteBuffer _bb, IRaceStrategy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028130 RID: 164144 RVA: 0x0057AEE9 File Offset: 0x005790E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028131 RID: 164145 RVA: 0x0057AEF8 File Offset: 0x005790F8
		public IRaceStrategy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B101 RID: 45313
		// (get) Token: 0x06028132 RID: 164146 RVA: 0x0057AF08 File Offset: 0x00579108
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

		// Token: 0x1700B102 RID: 45314
		// (get) Token: 0x06028133 RID: 164147 RVA: 0x0057AF44 File Offset: 0x00579144
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

		// Token: 0x1700B103 RID: 45315
		// (get) Token: 0x06028134 RID: 164148 RVA: 0x0057AFA4 File Offset: 0x005791A4
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

		// Token: 0x1700B104 RID: 45316
		// (get) Token: 0x06028135 RID: 164149 RVA: 0x0057AFE0 File Offset: 0x005791E0
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

		// Token: 0x06028136 RID: 164150 RVA: 0x0057B018 File Offset: 0x00579218
		public Span<byte> GetCommonConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06028137 RID: 164151 RVA: 0x0057B028 File Offset: 0x00579228
		public byte[] GetCommonConfigArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06028138 RID: 164152 RVA: 0x0057B037 File Offset: 0x00579237
		public static Offset<IRaceStrategy> CreateIRaceStrategy(FlatBufferBuilder builder, EAiGearStrategy Type = EAiGearStrategy.RenjuStrategy, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), int SplineEntityId = 0, StringOffset CommonConfigOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IRaceStrategy.AddCommonConfig(builder, CommonConfigOffset);
			IRaceStrategy.AddSplineEntityId(builder, SplineEntityId);
			IRaceStrategy.AddCondition(builder, ConditionOffset);
			IRaceStrategy.AddType(builder, Type);
			return IRaceStrategy.EndIRaceStrategy(builder);
		}

		// Token: 0x06028139 RID: 164153 RVA: 0x0057B063 File Offset: 0x00579263
		public static void StartIRaceStrategy(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602813A RID: 164154 RVA: 0x0057B06C File Offset: 0x0057926C
		public static void AddType(FlatBufferBuilder builder, EAiGearStrategy type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602813B RID: 164155 RVA: 0x0057B077 File Offset: 0x00579277
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0602813C RID: 164156 RVA: 0x0057B087 File Offset: 0x00579287
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x0602813D RID: 164157 RVA: 0x0057B092 File Offset: 0x00579292
		public static void AddCommonConfig(FlatBufferBuilder builder, StringOffset commonConfigOffset)
		{
			builder.AddOffset(3, commonConfigOffset.Value, 0);
		}

		// Token: 0x0602813E RID: 164158 RVA: 0x0057B0A2 File Offset: 0x005792A2
		public static Offset<IRaceStrategy> EndIRaceStrategy(FlatBufferBuilder builder)
		{
			return new Offset<IRaceStrategy>(builder.EndTable());
		}

		// Token: 0x0602813F RID: 164159 RVA: 0x0057B0B0 File Offset: 0x005792B0
		public IRaceStrategyT UnPack()
		{
			IRaceStrategyT raceStrategyT = new IRaceStrategyT();
			this.UnPackTo(raceStrategyT);
			return raceStrategyT;
		}

		// Token: 0x06028140 RID: 164160 RVA: 0x0057B0CC File Offset: 0x005792CC
		public void UnPackTo(IRaceStrategyT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.CommonConfig = this.CommonConfig;
		}

		// Token: 0x06028141 RID: 164161 RVA: 0x0057B12C File Offset: 0x0057932C
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

		// Token: 0x0400F9A5 RID: 63909
		private Table __p;
	}
}
