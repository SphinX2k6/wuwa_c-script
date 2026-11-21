using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041CF RID: 16847
	public struct IConditionText : IFlatbufferObject
	{
		// Token: 0x170072C6 RID: 29382
		// (get) Token: 0x060175C7 RID: 95687 RVA: 0x00356D4D File Offset: 0x00354F4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060175C8 RID: 95688 RVA: 0x00356D5A File Offset: 0x00354F5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060175C9 RID: 95689 RVA: 0x00356D64 File Offset: 0x00354F64
		public static IConditionText GetRootAsIConditionText(ByteBuffer _bb)
		{
			return IConditionText.GetRootAsIConditionText(_bb, default(IConditionText));
		}

		// Token: 0x060175CA RID: 95690 RVA: 0x00356D80 File Offset: 0x00354F80
		public static IConditionText GetRootAsIConditionText(ByteBuffer _bb, IConditionText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060175CB RID: 95691 RVA: 0x00356D9D File Offset: 0x00354F9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060175CC RID: 95692 RVA: 0x00356DAC File Offset: 0x00354FAC
		public IConditionText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072C7 RID: 29383
		// (get) Token: 0x060175CD RID: 95693 RVA: 0x00356DBC File Offset: 0x00354FBC
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170072C8 RID: 29384
		// (get) Token: 0x060175CE RID: 95694 RVA: 0x00356E1C File Offset: 0x0035501C
		public string TidTitle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060175CF RID: 95695 RVA: 0x00356E53 File Offset: 0x00355053
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060175D0 RID: 95696 RVA: 0x00356E62 File Offset: 0x00355062
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170072C9 RID: 29385
		// (get) Token: 0x060175D1 RID: 95697 RVA: 0x00356E70 File Offset: 0x00355070
		public TQuestSchedule QuestScheduleTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TQuestSchedule.NONE;
				}
				return (TQuestSchedule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060175D2 RID: 95698 RVA: 0x00356EAC File Offset: 0x003550AC
		public TTable? QuestScheduleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060175D3 RID: 95699 RVA: 0x00356EF4 File Offset: 0x003550F4
		public IQuestScheduleBtTreeVar QuestScheduleTypeAsIQuestScheduleBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleBtTreeVar>().Value;
		}

		// Token: 0x060175D4 RID: 95700 RVA: 0x00356F10 File Offset: 0x00355110
		public IQuestScheduleChildQuestCompleted QuestScheduleTypeAsIQuestScheduleChildQuestCompleted()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompleted>().Value;
		}

		// Token: 0x060175D5 RID: 95701 RVA: 0x00356F2C File Offset: 0x0035512C
		public IQuestScheduleChildQuestCompletedCount QuestScheduleTypeAsIQuestScheduleChildQuestCompletedCount()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompletedCount>().Value;
		}

		// Token: 0x060175D6 RID: 95702 RVA: 0x00356F48 File Offset: 0x00355148
		public IQuestScheduleDistanceValue QuestScheduleTypeAsIQuestScheduleDistanceValue()
		{
			return this.QuestScheduleType<IQuestScheduleDistanceValue>().Value;
		}

		// Token: 0x060175D7 RID: 95703 RVA: 0x00356F64 File Offset: 0x00355164
		public IQuestScheduleEntityHP QuestScheduleTypeAsIQuestScheduleEntityHP()
		{
			return this.QuestScheduleType<IQuestScheduleEntityHP>().Value;
		}

		// Token: 0x060175D8 RID: 95704 RVA: 0x00356F80 File Offset: 0x00355180
		public IQuestScheduleMeetCondition QuestScheduleTypeAsIQuestScheduleMeetCondition()
		{
			return this.QuestScheduleType<IQuestScheduleMeetCondition>().Value;
		}

		// Token: 0x060175D9 RID: 95705 RVA: 0x00356F9C File Offset: 0x0035519C
		public IQuestScheduleMultiBtTreeVar QuestScheduleTypeAsIQuestScheduleMultiBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleMultiBtTreeVar>().Value;
		}

		// Token: 0x060175DA RID: 95706 RVA: 0x00356FB8 File Offset: 0x003551B8
		public IQuestScheduleNone QuestScheduleTypeAsIQuestScheduleNone()
		{
			return this.QuestScheduleType<IQuestScheduleNone>().Value;
		}

		// Token: 0x060175DB RID: 95707 RVA: 0x00356FD4 File Offset: 0x003551D4
		public IQuestScheduleProgressValue QuestScheduleTypeAsIQuestScheduleProgressValue()
		{
			return this.QuestScheduleType<IQuestScheduleProgressValue>().Value;
		}

		// Token: 0x060175DC RID: 95708 RVA: 0x00356FF0 File Offset: 0x003551F0
		public IQuestScheduleRoleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleRoleTowerChallengeTitle>().Value;
		}

		// Token: 0x060175DD RID: 95709 RVA: 0x0035700C File Offset: 0x0035520C
		public IQuestScheduleScore QuestScheduleTypeAsIQuestScheduleScore()
		{
			return this.QuestScheduleType<IQuestScheduleScore>().Value;
		}

		// Token: 0x060175DE RID: 95710 RVA: 0x00357028 File Offset: 0x00355228
		public IQuestScheduleTimeLeft QuestScheduleTypeAsIQuestScheduleTimeLeft()
		{
			return this.QuestScheduleType<IQuestScheduleTimeLeft>().Value;
		}

		// Token: 0x060175DF RID: 95711 RVA: 0x00357044 File Offset: 0x00355244
		public IQuestScheduleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleTowerChallengeTitle>().Value;
		}

		// Token: 0x170072CA RID: 29386
		// (get) Token: 0x060175E0 RID: 95712 RVA: 0x00357060 File Offset: 0x00355260
		public IProgressBar? ProgressBar
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IProgressBar?(default(IProgressBar).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060175E1 RID: 95713 RVA: 0x003570BE File Offset: 0x003552BE
		public static Offset<IConditionText> CreateIConditionText(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), StringOffset TidTitleOffset = default(StringOffset), TQuestSchedule QuestScheduleType_type = TQuestSchedule.NONE, int QuestScheduleTypeOffset = 0, Offset<IProgressBar> ProgressBarOffset = default(Offset<IProgressBar>))
		{
			builder.StartTable(5);
			IConditionText.AddProgressBar(builder, ProgressBarOffset);
			IConditionText.AddQuestScheduleType(builder, QuestScheduleTypeOffset);
			IConditionText.AddTidTitle(builder, TidTitleOffset);
			IConditionText.AddCondition(builder, ConditionOffset);
			IConditionText.AddQuestScheduleTypeType(builder, QuestScheduleType_type);
			return IConditionText.EndIConditionText(builder);
		}

		// Token: 0x060175E2 RID: 95714 RVA: 0x003570F2 File Offset: 0x003552F2
		public static void StartIConditionText(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060175E3 RID: 95715 RVA: 0x003570FB File Offset: 0x003552FB
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060175E4 RID: 95716 RVA: 0x0035710B File Offset: 0x0035530B
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(1, tidTitleOffset.Value, 0);
		}

		// Token: 0x060175E5 RID: 95717 RVA: 0x0035711B File Offset: 0x0035531B
		public static void AddQuestScheduleTypeType(FlatBufferBuilder builder, TQuestSchedule questScheduleTypeType)
		{
			builder.AddByte(2, (byte)questScheduleTypeType, 0);
		}

		// Token: 0x060175E6 RID: 95718 RVA: 0x00357126 File Offset: 0x00355326
		public static void AddQuestScheduleType(FlatBufferBuilder builder, int questScheduleTypeOffset)
		{
			builder.AddOffset(3, questScheduleTypeOffset, 0);
		}

		// Token: 0x060175E7 RID: 95719 RVA: 0x00357131 File Offset: 0x00355331
		public static void AddProgressBar(FlatBufferBuilder builder, Offset<IProgressBar> progressBarOffset)
		{
			builder.AddOffset(4, progressBarOffset.Value, 0);
		}

		// Token: 0x060175E8 RID: 95720 RVA: 0x00357141 File Offset: 0x00355341
		public static Offset<IConditionText> EndIConditionText(FlatBufferBuilder builder)
		{
			return new Offset<IConditionText>(builder.EndTable());
		}

		// Token: 0x060175E9 RID: 95721 RVA: 0x00357150 File Offset: 0x00355350
		public IConditionTextT UnPack()
		{
			IConditionTextT conditionTextT = new IConditionTextT();
			this.UnPackTo(conditionTextT);
			return conditionTextT;
		}

		// Token: 0x060175EA RID: 95722 RVA: 0x0035716C File Offset: 0x0035536C
		public void UnPackTo(IConditionTextT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.TidTitle = this.TidTitle;
			_o.QuestScheduleType = new TQuestScheduleUnion();
			_o.QuestScheduleType.Type = this.QuestScheduleTypeType;
			switch (this.QuestScheduleTypeType)
			{
			case TQuestSchedule.IQuestScheduleBtTreeVar:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleBtTreeVar>() != null) ? this.QuestScheduleType<IQuestScheduleBtTreeVar>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleChildQuestCompleted:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleChildQuestCompleted>() != null) ? this.QuestScheduleType<IQuestScheduleChildQuestCompleted>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleChildQuestCompletedCount:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleChildQuestCompletedCount>() != null) ? this.QuestScheduleType<IQuestScheduleChildQuestCompletedCount>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleDistanceValue:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleDistanceValue>() != null) ? this.QuestScheduleType<IQuestScheduleDistanceValue>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleEntityHP:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleEntityHP>() != null) ? this.QuestScheduleType<IQuestScheduleEntityHP>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleMeetCondition:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleMeetCondition>() != null) ? this.QuestScheduleType<IQuestScheduleMeetCondition>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleMultiBtTreeVar:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleMultiBtTreeVar>() != null) ? this.QuestScheduleType<IQuestScheduleMultiBtTreeVar>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleNone:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleNone>() != null) ? this.QuestScheduleType<IQuestScheduleNone>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleProgressValue:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleProgressValue>() != null) ? this.QuestScheduleType<IQuestScheduleProgressValue>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleRoleTowerChallengeTitle:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleRoleTowerChallengeTitle>() != null) ? this.QuestScheduleType<IQuestScheduleRoleTowerChallengeTitle>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleScore:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleScore>() != null) ? this.QuestScheduleType<IQuestScheduleScore>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleTimeLeft:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleTimeLeft>() != null) ? this.QuestScheduleType<IQuestScheduleTimeLeft>().Value.UnPack() : null);
				break;
			case TQuestSchedule.IQuestScheduleTowerChallengeTitle:
				_o.QuestScheduleType.Value = ((this.QuestScheduleType<IQuestScheduleTowerChallengeTitle>() != null) ? this.QuestScheduleType<IQuestScheduleTowerChallengeTitle>().Value.UnPack() : null);
				break;
			}
			_o.ProgressBar = ((this.ProgressBar != null) ? this.ProgressBar.Value.UnPack() : null);
		}

		// Token: 0x060175EB RID: 95723 RVA: 0x0035754C File Offset: 0x0035574C
		public static Offset<IConditionText> Pack(FlatBufferBuilder builder, IConditionTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionText>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			StringOffset tidTitleOffset = (_o.TidTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidTitle);
			TQuestSchedule questScheduleType_type = (_o.QuestScheduleType == null) ? TQuestSchedule.NONE : _o.QuestScheduleType.Type;
			int questScheduleTypeOffset = (_o.QuestScheduleType == null) ? 0 : TQuestScheduleUnion.Pack(builder, _o.QuestScheduleType);
			Offset<IProgressBar> progressBarOffset = (_o.ProgressBar == null) ? default(Offset<IProgressBar>) : IProgressBar.Pack(builder, _o.ProgressBar);
			return IConditionText.CreateIConditionText(builder, conditionOffset, tidTitleOffset, questScheduleType_type, questScheduleTypeOffset, progressBarOffset);
		}

		// Token: 0x0400C0A3 RID: 49315
		private Table __p;
	}
}
