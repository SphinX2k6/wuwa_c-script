using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E7A RID: 20090
	public struct IAiGearStrategy : IFlatbufferObject
	{
		// Token: 0x17008FF0 RID: 36848
		// (get) Token: 0x0601F94E RID: 129358 RVA: 0x00466374 File Offset: 0x00464574
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F94F RID: 129359 RVA: 0x00466381 File Offset: 0x00464581
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F950 RID: 129360 RVA: 0x00466388 File Offset: 0x00464588
		public static IAiGearStrategy GetRootAsIAiGearStrategy(ByteBuffer _bb)
		{
			return IAiGearStrategy.GetRootAsIAiGearStrategy(_bb, default(IAiGearStrategy));
		}

		// Token: 0x0601F951 RID: 129361 RVA: 0x004663A4 File Offset: 0x004645A4
		public static IAiGearStrategy GetRootAsIAiGearStrategy(ByteBuffer _bb, IAiGearStrategy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F952 RID: 129362 RVA: 0x004663C1 File Offset: 0x004645C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F953 RID: 129363 RVA: 0x004663D0 File Offset: 0x004645D0
		public IAiGearStrategy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008FF1 RID: 36849
		// (get) Token: 0x0601F954 RID: 129364 RVA: 0x004663E0 File Offset: 0x004645E0
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

		// Token: 0x17008FF2 RID: 36850
		// (get) Token: 0x0601F955 RID: 129365 RVA: 0x0046641C File Offset: 0x0046461C
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

		// Token: 0x0601F956 RID: 129366 RVA: 0x00466479 File Offset: 0x00464679
		public static Offset<IAiGearStrategy> CreateIAiGearStrategy(FlatBufferBuilder builder, EAiGearStrategy Type = EAiGearStrategy.RenjuStrategy, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			IAiGearStrategy.AddCondition(builder, ConditionOffset);
			IAiGearStrategy.AddType(builder, Type);
			return IAiGearStrategy.EndIAiGearStrategy(builder);
		}

		// Token: 0x0601F957 RID: 129367 RVA: 0x00466496 File Offset: 0x00464696
		public static void StartIAiGearStrategy(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F958 RID: 129368 RVA: 0x0046649F File Offset: 0x0046469F
		public static void AddType(FlatBufferBuilder builder, EAiGearStrategy type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F959 RID: 129369 RVA: 0x004664AA File Offset: 0x004646AA
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601F95A RID: 129370 RVA: 0x004664BA File Offset: 0x004646BA
		public static Offset<IAiGearStrategy> EndIAiGearStrategy(FlatBufferBuilder builder)
		{
			return new Offset<IAiGearStrategy>(builder.EndTable());
		}

		// Token: 0x0601F95B RID: 129371 RVA: 0x004664C8 File Offset: 0x004646C8
		public IAiGearStrategyT UnPack()
		{
			IAiGearStrategyT aiGearStrategyT = new IAiGearStrategyT();
			this.UnPackTo(aiGearStrategyT);
			return aiGearStrategyT;
		}

		// Token: 0x0601F95C RID: 129372 RVA: 0x004664E4 File Offset: 0x004646E4
		public void UnPackTo(IAiGearStrategyT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x0601F95D RID: 129373 RVA: 0x0046652C File Offset: 0x0046472C
		public static Offset<IAiGearStrategy> Pack(FlatBufferBuilder builder, IAiGearStrategyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiGearStrategy>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IAiGearStrategy.CreateIAiGearStrategy(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400DC34 RID: 56372
		private Table __p;
	}
}
