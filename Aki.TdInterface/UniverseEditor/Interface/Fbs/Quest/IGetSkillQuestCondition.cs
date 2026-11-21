using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B6 RID: 17078
	public struct IGetSkillQuestCondition : IFlatbufferObject
	{
		// Token: 0x170074D4 RID: 29908
		// (get) Token: 0x06017ECE RID: 97998 RVA: 0x0036A92A File Offset: 0x00368B2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017ECF RID: 97999 RVA: 0x0036A937 File Offset: 0x00368B37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017ED0 RID: 98000 RVA: 0x0036A940 File Offset: 0x00368B40
		public static IGetSkillQuestCondition GetRootAsIGetSkillQuestCondition(ByteBuffer _bb)
		{
			return IGetSkillQuestCondition.GetRootAsIGetSkillQuestCondition(_bb, default(IGetSkillQuestCondition));
		}

		// Token: 0x06017ED1 RID: 98001 RVA: 0x0036A95C File Offset: 0x00368B5C
		public static IGetSkillQuestCondition GetRootAsIGetSkillQuestCondition(ByteBuffer _bb, IGetSkillQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017ED2 RID: 98002 RVA: 0x0036A979 File Offset: 0x00368B79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017ED3 RID: 98003 RVA: 0x0036A988 File Offset: 0x00368B88
		public IGetSkillQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074D5 RID: 29909
		// (get) Token: 0x06017ED4 RID: 98004 RVA: 0x0036A998 File Offset: 0x00368B98
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

		// Token: 0x170074D6 RID: 29910
		// (get) Token: 0x06017ED5 RID: 98005 RVA: 0x0036A9D4 File Offset: 0x00368BD4
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

		// Token: 0x170074D7 RID: 29911
		// (get) Token: 0x06017ED6 RID: 98006 RVA: 0x0036AA34 File Offset: 0x00368C34
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

		// Token: 0x170074D8 RID: 29912
		// (get) Token: 0x06017ED7 RID: 98007 RVA: 0x0036AA70 File Offset: 0x00368C70
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

		// Token: 0x06017ED8 RID: 98008 RVA: 0x0036AAAD File Offset: 0x00368CAD
		public static Offset<IGetSkillQuestCondition> CreateIGetSkillQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), ESkillType SkillType = ESkillType.NormalSkill, int SkillId = 0)
		{
			builder.StartTable(4);
			IGetSkillQuestCondition.AddSkillId(builder, SkillId);
			IGetSkillQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IGetSkillQuestCondition.AddSkillType(builder, SkillType);
			IGetSkillQuestCondition.AddType(builder, Type);
			return IGetSkillQuestCondition.EndIGetSkillQuestCondition(builder);
		}

		// Token: 0x06017ED9 RID: 98009 RVA: 0x0036AAD9 File Offset: 0x00368CD9
		public static void StartIGetSkillQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017EDA RID: 98010 RVA: 0x0036AAE2 File Offset: 0x00368CE2
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017EDB RID: 98011 RVA: 0x0036AAED File Offset: 0x00368CED
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017EDC RID: 98012 RVA: 0x0036AAFD File Offset: 0x00368CFD
		public static void AddSkillType(FlatBufferBuilder builder, ESkillType skillType)
		{
			builder.AddByte(2, (byte)skillType, 0);
		}

		// Token: 0x06017EDD RID: 98013 RVA: 0x0036AB08 File Offset: 0x00368D08
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(3, skillId, 0);
		}

		// Token: 0x06017EDE RID: 98014 RVA: 0x0036AB13 File Offset: 0x00368D13
		public static Offset<IGetSkillQuestCondition> EndIGetSkillQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGetSkillQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017EDF RID: 98015 RVA: 0x0036AB20 File Offset: 0x00368D20
		public IGetSkillQuestConditionT UnPack()
		{
			IGetSkillQuestConditionT getSkillQuestConditionT = new IGetSkillQuestConditionT();
			this.UnPackTo(getSkillQuestConditionT);
			return getSkillQuestConditionT;
		}

		// Token: 0x06017EE0 RID: 98016 RVA: 0x0036AB3C File Offset: 0x00368D3C
		public void UnPackTo(IGetSkillQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.SkillType = this.SkillType;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x06017EE1 RID: 98017 RVA: 0x0036AB9C File Offset: 0x00368D9C
		public static Offset<IGetSkillQuestCondition> Pack(FlatBufferBuilder builder, IGetSkillQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetSkillQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IGetSkillQuestCondition.CreateIGetSkillQuestCondition(builder, _o.Type, preConditionsOffset, _o.SkillType, _o.SkillId);
		}

		// Token: 0x0400C20B RID: 49675
		private Table __p;
	}
}
