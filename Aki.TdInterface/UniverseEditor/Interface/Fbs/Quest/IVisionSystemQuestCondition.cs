using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004274 RID: 17012
	public struct IVisionSystemQuestCondition : IFlatbufferObject
	{
		// Token: 0x170078BE RID: 30910
		// (get) Token: 0x060192D5 RID: 103125 RVA: 0x0039E25E File Offset: 0x0039C45E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060192D6 RID: 103126 RVA: 0x0039E26B File Offset: 0x0039C46B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060192D7 RID: 103127 RVA: 0x0039E274 File Offset: 0x0039C474
		public static IVisionSystemQuestCondition GetRootAsIVisionSystemQuestCondition(ByteBuffer _bb)
		{
			return IVisionSystemQuestCondition.GetRootAsIVisionSystemQuestCondition(_bb, default(IVisionSystemQuestCondition));
		}

		// Token: 0x060192D8 RID: 103128 RVA: 0x0039E290 File Offset: 0x0039C490
		public static IVisionSystemQuestCondition GetRootAsIVisionSystemQuestCondition(ByteBuffer _bb, IVisionSystemQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060192D9 RID: 103129 RVA: 0x0039E2AD File Offset: 0x0039C4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060192DA RID: 103130 RVA: 0x0039E2BC File Offset: 0x0039C4BC
		public IVisionSystemQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078BF RID: 30911
		// (get) Token: 0x060192DB RID: 103131 RVA: 0x0039E2CC File Offset: 0x0039C4CC
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

		// Token: 0x170078C0 RID: 30912
		// (get) Token: 0x060192DC RID: 103132 RVA: 0x0039E308 File Offset: 0x0039C508
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

		// Token: 0x170078C1 RID: 30913
		// (get) Token: 0x060192DD RID: 103133 RVA: 0x0039E368 File Offset: 0x0039C568
		public TVisionSystemQuest QuestType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TVisionSystemQuest.NONE;
				}
				return (TVisionSystemQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060192DE RID: 103134 RVA: 0x0039E3A4 File Offset: 0x0039C5A4
		public TTable? Quest<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060192DF RID: 103135 RVA: 0x0039E3EC File Offset: 0x0039C5EC
		public IVisionSystemQuestDoIdentify QuestAsIVisionSystemQuestDoIdentify()
		{
			return this.Quest<IVisionSystemQuestDoIdentify>().Value;
		}

		// Token: 0x060192E0 RID: 103136 RVA: 0x0039E408 File Offset: 0x0039C608
		public IVisionSystemQuestSetActivated QuestAsIVisionSystemQuestSetActivated()
		{
			return this.Quest<IVisionSystemQuestSetActivated>().Value;
		}

		// Token: 0x060192E1 RID: 103137 RVA: 0x0039E424 File Offset: 0x0039C624
		public IVisionSystemQuestTargetLevel QuestAsIVisionSystemQuestTargetLevel()
		{
			return this.Quest<IVisionSystemQuestTargetLevel>().Value;
		}

		// Token: 0x060192E2 RID: 103138 RVA: 0x0039E43F File Offset: 0x0039C63F
		public static Offset<IVisionSystemQuestCondition> CreateIVisionSystemQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TVisionSystemQuest Quest_type = TVisionSystemQuest.NONE, int QuestOffset = 0)
		{
			builder.StartTable(4);
			IVisionSystemQuestCondition.AddQuest(builder, QuestOffset);
			IVisionSystemQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IVisionSystemQuestCondition.AddQuestType(builder, Quest_type);
			IVisionSystemQuestCondition.AddType(builder, Type);
			return IVisionSystemQuestCondition.EndIVisionSystemQuestCondition(builder);
		}

		// Token: 0x060192E3 RID: 103139 RVA: 0x0039E46B File Offset: 0x0039C66B
		public static void StartIVisionSystemQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060192E4 RID: 103140 RVA: 0x0039E474 File Offset: 0x0039C674
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060192E5 RID: 103141 RVA: 0x0039E47F File Offset: 0x0039C67F
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060192E6 RID: 103142 RVA: 0x0039E48F File Offset: 0x0039C68F
		public static void AddQuestType(FlatBufferBuilder builder, TVisionSystemQuest questType)
		{
			builder.AddByte(2, (byte)questType, 0);
		}

		// Token: 0x060192E7 RID: 103143 RVA: 0x0039E49A File Offset: 0x0039C69A
		public static void AddQuest(FlatBufferBuilder builder, int questOffset)
		{
			builder.AddOffset(3, questOffset, 0);
		}

		// Token: 0x060192E8 RID: 103144 RVA: 0x0039E4A5 File Offset: 0x0039C6A5
		public static Offset<IVisionSystemQuestCondition> EndIVisionSystemQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestCondition>(builder.EndTable());
		}

		// Token: 0x060192E9 RID: 103145 RVA: 0x0039E4B4 File Offset: 0x0039C6B4
		public IVisionSystemQuestConditionT UnPack()
		{
			IVisionSystemQuestConditionT visionSystemQuestConditionT = new IVisionSystemQuestConditionT();
			this.UnPackTo(visionSystemQuestConditionT);
			return visionSystemQuestConditionT;
		}

		// Token: 0x060192EA RID: 103146 RVA: 0x0039E4D0 File Offset: 0x0039C6D0
		public void UnPackTo(IVisionSystemQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Quest = new TVisionSystemQuestUnion();
			_o.Quest.Type = this.QuestType;
			switch (this.QuestType)
			{
			case TVisionSystemQuest.IVisionSystemQuestDoIdentify:
				_o.Quest.Value = ((this.Quest<IVisionSystemQuestDoIdentify>() != null) ? this.Quest<IVisionSystemQuestDoIdentify>().Value.UnPack() : null);
				return;
			case TVisionSystemQuest.IVisionSystemQuestSetActivated:
				_o.Quest.Value = ((this.Quest<IVisionSystemQuestSetActivated>() != null) ? this.Quest<IVisionSystemQuestSetActivated>().Value.UnPack() : null);
				return;
			case TVisionSystemQuest.IVisionSystemQuestTargetLevel:
				_o.Quest.Value = ((this.Quest<IVisionSystemQuestTargetLevel>() != null) ? this.Quest<IVisionSystemQuestTargetLevel>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x060192EB RID: 103147 RVA: 0x0039E5F8 File Offset: 0x0039C7F8
		public static Offset<IVisionSystemQuestCondition> Pack(FlatBufferBuilder builder, IVisionSystemQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisionSystemQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TVisionSystemQuest quest_type = (_o.Quest == null) ? TVisionSystemQuest.NONE : _o.Quest.Type;
			int questOffset = (_o.Quest == null) ? 0 : TVisionSystemQuestUnion.Pack(builder, _o.Quest);
			return IVisionSystemQuestCondition.CreateIVisionSystemQuestCondition(builder, _o.Type, preConditionsOffset, quest_type, questOffset);
		}

		// Token: 0x0400BF0A RID: 48906
		private Table __p;
	}
}
