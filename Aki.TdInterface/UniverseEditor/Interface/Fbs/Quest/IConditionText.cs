using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB8 RID: 15800
	public struct IConditionText : IFlatbufferObject
	{
		// Token: 0x17006D0C RID: 27916
		// (get) Token: 0x0601608E RID: 90254 RVA: 0x0032F9C5 File Offset: 0x0032DBC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601608F RID: 90255 RVA: 0x0032F9D2 File Offset: 0x0032DBD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016090 RID: 90256 RVA: 0x0032F9DC File Offset: 0x0032DBDC
		public static IConditionText GetRootAsIConditionText(ByteBuffer _bb)
		{
			return IConditionText.GetRootAsIConditionText(_bb, default(IConditionText));
		}

		// Token: 0x06016091 RID: 90257 RVA: 0x0032F9F8 File Offset: 0x0032DBF8
		public static IConditionText GetRootAsIConditionText(ByteBuffer _bb, IConditionText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016092 RID: 90258 RVA: 0x0032FA15 File Offset: 0x0032DC15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016093 RID: 90259 RVA: 0x0032FA24 File Offset: 0x0032DC24
		public IConditionText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006D0D RID: 27917
		// (get) Token: 0x06016094 RID: 90260 RVA: 0x0032FA34 File Offset: 0x0032DC34
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

		// Token: 0x17006D0E RID: 27918
		// (get) Token: 0x06016095 RID: 90261 RVA: 0x0032FA94 File Offset: 0x0032DC94
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

		// Token: 0x06016096 RID: 90262 RVA: 0x0032FACB File Offset: 0x0032DCCB
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016097 RID: 90263 RVA: 0x0032FADA File Offset: 0x0032DCDA
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006D0F RID: 27919
		// (get) Token: 0x06016098 RID: 90264 RVA: 0x0032FAE8 File Offset: 0x0032DCE8
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

		// Token: 0x06016099 RID: 90265 RVA: 0x0032FB24 File Offset: 0x0032DD24
		public TTable? QuestScheduleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601609A RID: 90266 RVA: 0x0032FB6C File Offset: 0x0032DD6C
		public IQuestScheduleBtTreeVar QuestScheduleTypeAsIQuestScheduleBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleBtTreeVar>().Value;
		}

		// Token: 0x0601609B RID: 90267 RVA: 0x0032FB88 File Offset: 0x0032DD88
		public IQuestScheduleChildQuestCompleted QuestScheduleTypeAsIQuestScheduleChildQuestCompleted()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompleted>().Value;
		}

		// Token: 0x0601609C RID: 90268 RVA: 0x0032FBA4 File Offset: 0x0032DDA4
		public IQuestScheduleChildQuestCompletedCount QuestScheduleTypeAsIQuestScheduleChildQuestCompletedCount()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompletedCount>().Value;
		}

		// Token: 0x0601609D RID: 90269 RVA: 0x0032FBC0 File Offset: 0x0032DDC0
		public IQuestScheduleDistanceValue QuestScheduleTypeAsIQuestScheduleDistanceValue()
		{
			return this.QuestScheduleType<IQuestScheduleDistanceValue>().Value;
		}

		// Token: 0x0601609E RID: 90270 RVA: 0x0032FBDC File Offset: 0x0032DDDC
		public IQuestScheduleEntityHP QuestScheduleTypeAsIQuestScheduleEntityHP()
		{
			return this.QuestScheduleType<IQuestScheduleEntityHP>().Value;
		}

		// Token: 0x0601609F RID: 90271 RVA: 0x0032FBF8 File Offset: 0x0032DDF8
		public IQuestScheduleMeetCondition QuestScheduleTypeAsIQuestScheduleMeetCondition()
		{
			return this.QuestScheduleType<IQuestScheduleMeetCondition>().Value;
		}

		// Token: 0x060160A0 RID: 90272 RVA: 0x0032FC14 File Offset: 0x0032DE14
		public IQuestScheduleMultiBtTreeVar QuestScheduleTypeAsIQuestScheduleMultiBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleMultiBtTreeVar>().Value;
		}

		// Token: 0x060160A1 RID: 90273 RVA: 0x0032FC30 File Offset: 0x0032DE30
		public IQuestScheduleNone QuestScheduleTypeAsIQuestScheduleNone()
		{
			return this.QuestScheduleType<IQuestScheduleNone>().Value;
		}

		// Token: 0x060160A2 RID: 90274 RVA: 0x0032FC4C File Offset: 0x0032DE4C
		public IQuestScheduleProgressValue QuestScheduleTypeAsIQuestScheduleProgressValue()
		{
			return this.QuestScheduleType<IQuestScheduleProgressValue>().Value;
		}

		// Token: 0x060160A3 RID: 90275 RVA: 0x0032FC68 File Offset: 0x0032DE68
		public IQuestScheduleRoleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleRoleTowerChallengeTitle>().Value;
		}

		// Token: 0x060160A4 RID: 90276 RVA: 0x0032FC84 File Offset: 0x0032DE84
		public IQuestScheduleScore QuestScheduleTypeAsIQuestScheduleScore()
		{
			return this.QuestScheduleType<IQuestScheduleScore>().Value;
		}

		// Token: 0x060160A5 RID: 90277 RVA: 0x0032FCA0 File Offset: 0x0032DEA0
		public IQuestScheduleTimeLeft QuestScheduleTypeAsIQuestScheduleTimeLeft()
		{
			return this.QuestScheduleType<IQuestScheduleTimeLeft>().Value;
		}

		// Token: 0x060160A6 RID: 90278 RVA: 0x0032FCBC File Offset: 0x0032DEBC
		public IQuestScheduleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleTowerChallengeTitle>().Value;
		}

		// Token: 0x17006D10 RID: 27920
		// (get) Token: 0x060160A7 RID: 90279 RVA: 0x0032FCD8 File Offset: 0x0032DED8
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

		// Token: 0x060160A8 RID: 90280 RVA: 0x0032FD36 File Offset: 0x0032DF36
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

		// Token: 0x060160A9 RID: 90281 RVA: 0x0032FD6A File Offset: 0x0032DF6A
		public static void StartIConditionText(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060160AA RID: 90282 RVA: 0x0032FD73 File Offset: 0x0032DF73
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060160AB RID: 90283 RVA: 0x0032FD83 File Offset: 0x0032DF83
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(1, tidTitleOffset.Value, 0);
		}

		// Token: 0x060160AC RID: 90284 RVA: 0x0032FD93 File Offset: 0x0032DF93
		public static void AddQuestScheduleTypeType(FlatBufferBuilder builder, TQuestSchedule questScheduleTypeType)
		{
			builder.AddByte(2, (byte)questScheduleTypeType, 0);
		}

		// Token: 0x060160AD RID: 90285 RVA: 0x0032FD9E File Offset: 0x0032DF9E
		public static void AddQuestScheduleType(FlatBufferBuilder builder, int questScheduleTypeOffset)
		{
			builder.AddOffset(3, questScheduleTypeOffset, 0);
		}

		// Token: 0x060160AE RID: 90286 RVA: 0x0032FDA9 File Offset: 0x0032DFA9
		public static void AddProgressBar(FlatBufferBuilder builder, Offset<IProgressBar> progressBarOffset)
		{
			builder.AddOffset(4, progressBarOffset.Value, 0);
		}

		// Token: 0x060160AF RID: 90287 RVA: 0x0032FDB9 File Offset: 0x0032DFB9
		public static Offset<IConditionText> EndIConditionText(FlatBufferBuilder builder)
		{
			return new Offset<IConditionText>(builder.EndTable());
		}

		// Token: 0x060160B0 RID: 90288 RVA: 0x0032FDC8 File Offset: 0x0032DFC8
		public IConditionTextT UnPack()
		{
			IConditionTextT conditionTextT = new IConditionTextT();
			this.UnPackTo(conditionTextT);
			return conditionTextT;
		}

		// Token: 0x060160B1 RID: 90289 RVA: 0x0032FDE4 File Offset: 0x0032DFE4
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

		// Token: 0x060160B2 RID: 90290 RVA: 0x003301C4 File Offset: 0x0032E3C4
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

		// Token: 0x0400B6F6 RID: 46838
		private Table __p;
	}
}
