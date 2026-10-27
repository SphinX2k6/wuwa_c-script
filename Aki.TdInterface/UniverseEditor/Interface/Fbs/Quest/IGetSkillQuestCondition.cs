using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E7B RID: 15995
	public struct IGetSkillQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006EEC RID: 28396
		// (get) Token: 0x06016897 RID: 92311 RVA: 0x00341BA6 File Offset: 0x0033FDA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016898 RID: 92312 RVA: 0x00341BB3 File Offset: 0x0033FDB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016899 RID: 92313 RVA: 0x00341BBC File Offset: 0x0033FDBC
		public static IGetSkillQuestCondition GetRootAsIGetSkillQuestCondition(ByteBuffer _bb)
		{
			return IGetSkillQuestCondition.GetRootAsIGetSkillQuestCondition(_bb, default(IGetSkillQuestCondition));
		}

		// Token: 0x0601689A RID: 92314 RVA: 0x00341BD8 File Offset: 0x0033FDD8
		public static IGetSkillQuestCondition GetRootAsIGetSkillQuestCondition(ByteBuffer _bb, IGetSkillQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601689B RID: 92315 RVA: 0x00341BF5 File Offset: 0x0033FDF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601689C RID: 92316 RVA: 0x00341C04 File Offset: 0x0033FE04
		public IGetSkillQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EED RID: 28397
		// (get) Token: 0x0601689D RID: 92317 RVA: 0x00341C14 File Offset: 0x0033FE14
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

		// Token: 0x17006EEE RID: 28398
		// (get) Token: 0x0601689E RID: 92318 RVA: 0x00341C50 File Offset: 0x0033FE50
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

		// Token: 0x17006EEF RID: 28399
		// (get) Token: 0x0601689F RID: 92319 RVA: 0x00341CB0 File Offset: 0x0033FEB0
		public ESkillType SkillType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ESkillType.NormalSkill;
				}
				return (ESkillType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006EF0 RID: 28400
		// (get) Token: 0x060168A0 RID: 92320 RVA: 0x00341CEC File Offset: 0x0033FEEC
		public int SkillId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060168A1 RID: 92321 RVA: 0x00341D29 File Offset: 0x0033FF29
		public static Offset<IGetSkillQuestCondition> CreateIGetSkillQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), ESkillType SkillType = ESkillType.NormalSkill, int SkillId = 0)
		{
			builder.StartTable(4);
			IGetSkillQuestCondition.AddSkillId(builder, SkillId);
			IGetSkillQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IGetSkillQuestCondition.AddSkillType(builder, SkillType);
			IGetSkillQuestCondition.AddType(builder, Type);
			return IGetSkillQuestCondition.EndIGetSkillQuestCondition(builder);
		}

		// Token: 0x060168A2 RID: 92322 RVA: 0x00341D55 File Offset: 0x0033FF55
		public static void StartIGetSkillQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060168A3 RID: 92323 RVA: 0x00341D5E File Offset: 0x0033FF5E
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060168A4 RID: 92324 RVA: 0x00341D69 File Offset: 0x0033FF69
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060168A5 RID: 92325 RVA: 0x00341D79 File Offset: 0x0033FF79
		public static void AddSkillType(FlatBufferBuilder builder, ESkillType skillType)
		{
			builder.AddByte(2, (byte)skillType, 0);
		}

		// Token: 0x060168A6 RID: 92326 RVA: 0x00341D84 File Offset: 0x0033FF84
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(3, skillId, 0);
		}

		// Token: 0x060168A7 RID: 92327 RVA: 0x00341D8F File Offset: 0x0033FF8F
		public static Offset<IGetSkillQuestCondition> EndIGetSkillQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGetSkillQuestCondition>(builder.EndTable());
		}

		// Token: 0x060168A8 RID: 92328 RVA: 0x00341D9C File Offset: 0x0033FF9C
		public IGetSkillQuestConditionT UnPack()
		{
			IGetSkillQuestConditionT getSkillQuestConditionT = new IGetSkillQuestConditionT();
			this.UnPackTo(getSkillQuestConditionT);
			return getSkillQuestConditionT;
		}

		// Token: 0x060168A9 RID: 92329 RVA: 0x00341DB8 File Offset: 0x0033FFB8
		public void UnPackTo(IGetSkillQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.SkillType = this.SkillType;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x060168AA RID: 92330 RVA: 0x00341E18 File Offset: 0x00340018
		public static Offset<IGetSkillQuestCondition> Pack(FlatBufferBuilder builder, IGetSkillQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetSkillQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IGetSkillQuestCondition.CreateIGetSkillQuestCondition(builder, _o.Type, preConditionsOffset, _o.SkillType, _o.SkillId);
		}

		// Token: 0x0400B832 RID: 47154
		private Table __p;
	}
}
