using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D0 RID: 18128
	public struct IVisionSystemQuestCondition : IFlatbufferObject
	{
		// Token: 0x17007EEF RID: 32495
		// (get) Token: 0x0601AA41 RID: 109121 RVA: 0x003C9936 File Offset: 0x003C7B36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA42 RID: 109122 RVA: 0x003C9943 File Offset: 0x003C7B43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA43 RID: 109123 RVA: 0x003C994C File Offset: 0x003C7B4C
		public static IVisionSystemQuestCondition GetRootAsIVisionSystemQuestCondition(ByteBuffer _bb)
		{
			return IVisionSystemQuestCondition.GetRootAsIVisionSystemQuestCondition(_bb, default(IVisionSystemQuestCondition));
		}

		// Token: 0x0601AA44 RID: 109124 RVA: 0x003C9968 File Offset: 0x003C7B68
		public static IVisionSystemQuestCondition GetRootAsIVisionSystemQuestCondition(ByteBuffer _bb, IVisionSystemQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA45 RID: 109125 RVA: 0x003C9985 File Offset: 0x003C7B85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA46 RID: 109126 RVA: 0x003C9994 File Offset: 0x003C7B94
		public IVisionSystemQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EF0 RID: 32496
		// (get) Token: 0x0601AA47 RID: 109127 RVA: 0x003C99A4 File Offset: 0x003C7BA4
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

		// Token: 0x17007EF1 RID: 32497
		// (get) Token: 0x0601AA48 RID: 109128 RVA: 0x003C99E0 File Offset: 0x003C7BE0
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

		// Token: 0x17007EF2 RID: 32498
		// (get) Token: 0x0601AA49 RID: 109129 RVA: 0x003C9A40 File Offset: 0x003C7C40
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

		// Token: 0x0601AA4A RID: 109130 RVA: 0x003C9A7C File Offset: 0x003C7C7C
		public TTable? Quest<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601AA4B RID: 109131 RVA: 0x003C9AC4 File Offset: 0x003C7CC4
		public IVisionSystemQuestDoIdentify QuestAsIVisionSystemQuestDoIdentify()
		{
			return this.Quest<IVisionSystemQuestDoIdentify>().Value;
		}

		// Token: 0x0601AA4C RID: 109132 RVA: 0x003C9AE0 File Offset: 0x003C7CE0
		public IVisionSystemQuestSetActivated QuestAsIVisionSystemQuestSetActivated()
		{
			return this.Quest<IVisionSystemQuestSetActivated>().Value;
		}

		// Token: 0x0601AA4D RID: 109133 RVA: 0x003C9AFC File Offset: 0x003C7CFC
		public IVisionSystemQuestTargetLevel QuestAsIVisionSystemQuestTargetLevel()
		{
			return this.Quest<IVisionSystemQuestTargetLevel>().Value;
		}

		// Token: 0x0601AA4E RID: 109134 RVA: 0x003C9B17 File Offset: 0x003C7D17
		public static Offset<IVisionSystemQuestCondition> CreateIVisionSystemQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TVisionSystemQuest Quest_type = TVisionSystemQuest.NONE, int QuestOffset = 0)
		{
			builder.StartTable(4);
			IVisionSystemQuestCondition.AddQuest(builder, QuestOffset);
			IVisionSystemQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IVisionSystemQuestCondition.AddQuestType(builder, Quest_type);
			IVisionSystemQuestCondition.AddType(builder, Type);
			return IVisionSystemQuestCondition.EndIVisionSystemQuestCondition(builder);
		}

		// Token: 0x0601AA4F RID: 109135 RVA: 0x003C9B43 File Offset: 0x003C7D43
		public static void StartIVisionSystemQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601AA50 RID: 109136 RVA: 0x003C9B4C File Offset: 0x003C7D4C
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA51 RID: 109137 RVA: 0x003C9B57 File Offset: 0x003C7D57
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601AA52 RID: 109138 RVA: 0x003C9B67 File Offset: 0x003C7D67
		public static void AddQuestType(FlatBufferBuilder builder, TVisionSystemQuest questType)
		{
			builder.AddByte(2, (byte)questType, 0);
		}

		// Token: 0x0601AA53 RID: 109139 RVA: 0x003C9B72 File Offset: 0x003C7D72
		public static void AddQuest(FlatBufferBuilder builder, int questOffset)
		{
			builder.AddOffset(3, questOffset, 0);
		}

		// Token: 0x0601AA54 RID: 109140 RVA: 0x003C9B7D File Offset: 0x003C7D7D
		public static Offset<IVisionSystemQuestCondition> EndIVisionSystemQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IVisionSystemQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601AA55 RID: 109141 RVA: 0x003C9B8C File Offset: 0x003C7D8C
		public IVisionSystemQuestConditionT UnPack()
		{
			IVisionSystemQuestConditionT visionSystemQuestConditionT = new IVisionSystemQuestConditionT();
			this.UnPackTo(visionSystemQuestConditionT);
			return visionSystemQuestConditionT;
		}

		// Token: 0x0601AA56 RID: 109142 RVA: 0x003C9BA8 File Offset: 0x003C7DA8
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

		// Token: 0x0601AA57 RID: 109143 RVA: 0x003C9CD0 File Offset: 0x003C7ED0
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

		// Token: 0x0400C917 RID: 51479
		private Table __p;
	}
}
