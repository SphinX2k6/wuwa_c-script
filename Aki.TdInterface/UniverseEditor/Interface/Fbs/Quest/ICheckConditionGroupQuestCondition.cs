using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D49 RID: 15689
	public struct ICheckConditionGroupQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006BA6 RID: 27558
		// (get) Token: 0x06015B01 RID: 88833 RVA: 0x003210DE File Offset: 0x0031F2DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015B02 RID: 88834 RVA: 0x003210EB File Offset: 0x0031F2EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015B03 RID: 88835 RVA: 0x003210F4 File Offset: 0x0031F2F4
		public static ICheckConditionGroupQuestCondition GetRootAsICheckConditionGroupQuestCondition(ByteBuffer _bb)
		{
			return ICheckConditionGroupQuestCondition.GetRootAsICheckConditionGroupQuestCondition(_bb, default(ICheckConditionGroupQuestCondition));
		}

		// Token: 0x06015B04 RID: 88836 RVA: 0x00321110 File Offset: 0x0031F310
		public static ICheckConditionGroupQuestCondition GetRootAsICheckConditionGroupQuestCondition(ByteBuffer _bb, ICheckConditionGroupQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015B05 RID: 88837 RVA: 0x0032112D File Offset: 0x0031F32D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015B06 RID: 88838 RVA: 0x0032113C File Offset: 0x0031F33C
		public ICheckConditionGroupQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BA7 RID: 27559
		// (get) Token: 0x06015B07 RID: 88839 RVA: 0x0032114C File Offset: 0x0031F34C
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

		// Token: 0x17006BA8 RID: 27560
		// (get) Token: 0x06015B08 RID: 88840 RVA: 0x00321188 File Offset: 0x0031F388
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

		// Token: 0x17006BA9 RID: 27561
		// (get) Token: 0x06015B09 RID: 88841 RVA: 0x003211E8 File Offset: 0x0031F3E8
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

		// Token: 0x06015B0A RID: 88842 RVA: 0x00321245 File Offset: 0x0031F445
		public static Offset<ICheckConditionGroupQuestCondition> CreateICheckConditionGroupQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(3);
			ICheckConditionGroupQuestCondition.AddCondition(builder, ConditionOffset);
			ICheckConditionGroupQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckConditionGroupQuestCondition.AddType(builder, Type);
			return ICheckConditionGroupQuestCondition.EndICheckConditionGroupQuestCondition(builder);
		}

		// Token: 0x06015B0B RID: 88843 RVA: 0x00321269 File Offset: 0x0031F469
		public static void StartICheckConditionGroupQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015B0C RID: 88844 RVA: 0x00321272 File Offset: 0x0031F472
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015B0D RID: 88845 RVA: 0x0032127D File Offset: 0x0031F47D
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015B0E RID: 88846 RVA: 0x0032128D File Offset: 0x0031F48D
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(2, conditionOffset.Value, 0);
		}

		// Token: 0x06015B0F RID: 88847 RVA: 0x0032129D File Offset: 0x0031F49D
		public static Offset<ICheckConditionGroupQuestCondition> EndICheckConditionGroupQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckConditionGroupQuestCondition>(builder.EndTable());
		}

		// Token: 0x06015B10 RID: 88848 RVA: 0x003212AC File Offset: 0x0031F4AC
		public ICheckConditionGroupQuestConditionT UnPack()
		{
			ICheckConditionGroupQuestConditionT checkConditionGroupQuestConditionT = new ICheckConditionGroupQuestConditionT();
			this.UnPackTo(checkConditionGroupQuestConditionT);
			return checkConditionGroupQuestConditionT;
		}

		// Token: 0x06015B11 RID: 88849 RVA: 0x003212C8 File Offset: 0x0031F4C8
		public void UnPackTo(ICheckConditionGroupQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
		}

		// Token: 0x06015B12 RID: 88850 RVA: 0x00321340 File Offset: 0x0031F540
		public static Offset<ICheckConditionGroupQuestCondition> Pack(FlatBufferBuilder builder, ICheckConditionGroupQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckConditionGroupQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			return ICheckConditionGroupQuestCondition.CreateICheckConditionGroupQuestCondition(builder, _o.Type, preConditionsOffset, conditionOffset);
		}

		// Token: 0x0400B622 RID: 46626
		private Table __p;
	}
}
