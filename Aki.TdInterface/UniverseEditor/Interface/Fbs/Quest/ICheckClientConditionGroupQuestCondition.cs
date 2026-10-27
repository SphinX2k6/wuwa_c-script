using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D46 RID: 15686
	public struct ICheckClientConditionGroupQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006B9F RID: 27551
		// (get) Token: 0x06015AE7 RID: 88807 RVA: 0x00320D4B File Offset: 0x0031EF4B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015AE8 RID: 88808 RVA: 0x00320D58 File Offset: 0x0031EF58
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015AE9 RID: 88809 RVA: 0x00320D60 File Offset: 0x0031EF60
		public static ICheckClientConditionGroupQuestCondition GetRootAsICheckClientConditionGroupQuestCondition(ByteBuffer _bb)
		{
			return ICheckClientConditionGroupQuestCondition.GetRootAsICheckClientConditionGroupQuestCondition(_bb, default(ICheckClientConditionGroupQuestCondition));
		}

		// Token: 0x06015AEA RID: 88810 RVA: 0x00320D7C File Offset: 0x0031EF7C
		public static ICheckClientConditionGroupQuestCondition GetRootAsICheckClientConditionGroupQuestCondition(ByteBuffer _bb, ICheckClientConditionGroupQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015AEB RID: 88811 RVA: 0x00320D99 File Offset: 0x0031EF99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015AEC RID: 88812 RVA: 0x00320DA8 File Offset: 0x0031EFA8
		public ICheckClientConditionGroupQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BA0 RID: 27552
		// (get) Token: 0x06015AED RID: 88813 RVA: 0x00320DB8 File Offset: 0x0031EFB8
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BA1 RID: 27553
		// (get) Token: 0x06015AEE RID: 88814 RVA: 0x00320DF4 File Offset: 0x0031EFF4
		public IConditionGroup? PreConditions
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

		// Token: 0x17006BA2 RID: 27554
		// (get) Token: 0x06015AEF RID: 88815 RVA: 0x00320E54 File Offset: 0x0031F054
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015AF0 RID: 88816 RVA: 0x00320EB1 File Offset: 0x0031F0B1
		public static Offset<ICheckClientConditionGroupQuestCondition> CreateICheckClientConditionGroupQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			ICheckClientConditionGroupQuestCondition.AddCondition(builder, ConditionOffset);
			ICheckClientConditionGroupQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckClientConditionGroupQuestCondition.AddType(builder, Type);
			return ICheckClientConditionGroupQuestCondition.EndICheckClientConditionGroupQuestCondition(builder);
		}

		// Token: 0x06015AF1 RID: 88817 RVA: 0x00320ED5 File Offset: 0x0031F0D5
		public static void StartICheckClientConditionGroupQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015AF2 RID: 88818 RVA: 0x00320EDE File Offset: 0x0031F0DE
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015AF3 RID: 88819 RVA: 0x00320EE9 File Offset: 0x0031F0E9
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015AF4 RID: 88820 RVA: 0x00320EF9 File Offset: 0x0031F0F9
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06015AF5 RID: 88821 RVA: 0x00320F09 File Offset: 0x0031F109
		public static Offset<ICheckClientConditionGroupQuestCondition> EndICheckClientConditionGroupQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckClientConditionGroupQuestCondition>(builder.EndTable());
		}

		// Token: 0x06015AF6 RID: 88822 RVA: 0x00320F18 File Offset: 0x0031F118
		public ICheckClientConditionGroupQuestConditionT UnPack()
		{
			ICheckClientConditionGroupQuestConditionT checkClientConditionGroupQuestConditionT = new ICheckClientConditionGroupQuestConditionT();
			this.UnPackTo(checkClientConditionGroupQuestConditionT);
			return checkClientConditionGroupQuestConditionT;
		}

		// Token: 0x06015AF7 RID: 88823 RVA: 0x00320F34 File Offset: 0x0031F134
		public void UnPackTo(ICheckClientConditionGroupQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06015AF8 RID: 88824 RVA: 0x00320FAC File Offset: 0x0031F1AC
		public static Offset<ICheckClientConditionGroupQuestCondition> Pack(FlatBufferBuilder builder, ICheckClientConditionGroupQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckClientConditionGroupQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return ICheckClientConditionGroupQuestCondition.CreateICheckClientConditionGroupQuestCondition(builder, _o.Type, preConditionsOffset, conditionOffset);
		}

		// Token: 0x0400B61E RID: 46622
		private Table __p;
	}
}
