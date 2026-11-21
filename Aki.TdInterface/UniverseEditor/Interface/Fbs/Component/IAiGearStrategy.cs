using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538B RID: 21387
	public struct IAiGearStrategy : IFlatbufferObject
	{
		// Token: 0x17009729 RID: 38697
		// (get) Token: 0x06021599 RID: 136601 RVA: 0x0049A38C File Offset: 0x0049858C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602159A RID: 136602 RVA: 0x0049A399 File Offset: 0x00498599
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602159B RID: 136603 RVA: 0x0049A3A0 File Offset: 0x004985A0
		public static IAiGearStrategy GetRootAsIAiGearStrategy(ByteBuffer _bb)
		{
			return IAiGearStrategy.GetRootAsIAiGearStrategy(_bb, default(IAiGearStrategy));
		}

		// Token: 0x0602159C RID: 136604 RVA: 0x0049A3BC File Offset: 0x004985BC
		public static IAiGearStrategy GetRootAsIAiGearStrategy(ByteBuffer _bb, IAiGearStrategy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602159D RID: 136605 RVA: 0x0049A3D9 File Offset: 0x004985D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602159E RID: 136606 RVA: 0x0049A3E8 File Offset: 0x004985E8
		public IAiGearStrategy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700972A RID: 38698
		// (get) Token: 0x0602159F RID: 136607 RVA: 0x0049A3F8 File Offset: 0x004985F8
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

		// Token: 0x1700972B RID: 38699
		// (get) Token: 0x060215A0 RID: 136608 RVA: 0x0049A434 File Offset: 0x00498634
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

		// Token: 0x060215A1 RID: 136609 RVA: 0x0049A491 File Offset: 0x00498691
		public static Offset<IAiGearStrategy> CreateIAiGearStrategy(FlatBufferBuilder builder, EAiGearStrategy Type = EAiGearStrategy.RenjuStrategy, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			IAiGearStrategy.AddCondition(builder, ConditionOffset);
			IAiGearStrategy.AddType(builder, Type);
			return IAiGearStrategy.EndIAiGearStrategy(builder);
		}

		// Token: 0x060215A2 RID: 136610 RVA: 0x0049A4AE File Offset: 0x004986AE
		public static void StartIAiGearStrategy(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060215A3 RID: 136611 RVA: 0x0049A4B7 File Offset: 0x004986B7
		public static void AddType(FlatBufferBuilder builder, EAiGearStrategy type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060215A4 RID: 136612 RVA: 0x0049A4C2 File Offset: 0x004986C2
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060215A5 RID: 136613 RVA: 0x0049A4D2 File Offset: 0x004986D2
		public static Offset<IAiGearStrategy> EndIAiGearStrategy(FlatBufferBuilder builder)
		{
			return new Offset<IAiGearStrategy>(builder.EndTable());
		}

		// Token: 0x060215A6 RID: 136614 RVA: 0x0049A4E0 File Offset: 0x004986E0
		public IAiGearStrategyT UnPack()
		{
			IAiGearStrategyT aiGearStrategyT = new IAiGearStrategyT();
			this.UnPackTo(aiGearStrategyT);
			return aiGearStrategyT;
		}

		// Token: 0x060215A7 RID: 136615 RVA: 0x0049A4FC File Offset: 0x004986FC
		public void UnPackTo(IAiGearStrategyT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x060215A8 RID: 136616 RVA: 0x0049A544 File Offset: 0x00498744
		public static Offset<IAiGearStrategy> Pack(FlatBufferBuilder builder, IAiGearStrategyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAiGearStrategy>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return IAiGearStrategy.CreateIAiGearStrategy(builder, _o.Type, conditionOffset);
		}

		// Token: 0x0400E7AE RID: 59310
		private Table __p;
	}
}
