using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200447B RID: 17531
	public struct IQuestScheduleSubTitle : IFlatbufferObject
	{
		// Token: 0x170079AC RID: 31148
		// (get) Token: 0x06019328 RID: 103208 RVA: 0x00398331 File Offset: 0x00396531
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019329 RID: 103209 RVA: 0x0039833E File Offset: 0x0039653E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601932A RID: 103210 RVA: 0x00398348 File Offset: 0x00396548
		public static IQuestScheduleSubTitle GetRootAsIQuestScheduleSubTitle(ByteBuffer _bb)
		{
			return IQuestScheduleSubTitle.GetRootAsIQuestScheduleSubTitle(_bb, default(IQuestScheduleSubTitle));
		}

		// Token: 0x0601932B RID: 103211 RVA: 0x00398364 File Offset: 0x00396564
		public static IQuestScheduleSubTitle GetRootAsIQuestScheduleSubTitle(ByteBuffer _bb, IQuestScheduleSubTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601932C RID: 103212 RVA: 0x00398381 File Offset: 0x00396581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601932D RID: 103213 RVA: 0x00398390 File Offset: 0x00396590
		public IQuestScheduleSubTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079AD RID: 31149
		// (get) Token: 0x0601932E RID: 103214 RVA: 0x003983A0 File Offset: 0x003965A0
		public string TidTitle
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601932F RID: 103215 RVA: 0x003983D7 File Offset: 0x003965D7
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06019330 RID: 103216 RVA: 0x003983E6 File Offset: 0x003965E6
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170079AE RID: 31150
		// (get) Token: 0x06019331 RID: 103217 RVA: 0x003983F4 File Offset: 0x003965F4
		public TQuestSchedule QuestScheduleTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TQuestSchedule.NONE;
				}
				return (TQuestSchedule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019332 RID: 103218 RVA: 0x00398430 File Offset: 0x00396630
		public TTable? QuestScheduleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019333 RID: 103219 RVA: 0x00398474 File Offset: 0x00396674
		public IQuestScheduleBtTreeVar QuestScheduleTypeAsIQuestScheduleBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleBtTreeVar>().Value;
		}

		// Token: 0x06019334 RID: 103220 RVA: 0x00398490 File Offset: 0x00396690
		public IQuestScheduleChildQuestCompleted QuestScheduleTypeAsIQuestScheduleChildQuestCompleted()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompleted>().Value;
		}

		// Token: 0x06019335 RID: 103221 RVA: 0x003984AC File Offset: 0x003966AC
		public IQuestScheduleChildQuestCompletedCount QuestScheduleTypeAsIQuestScheduleChildQuestCompletedCount()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompletedCount>().Value;
		}

		// Token: 0x06019336 RID: 103222 RVA: 0x003984C8 File Offset: 0x003966C8
		public IQuestScheduleDistanceValue QuestScheduleTypeAsIQuestScheduleDistanceValue()
		{
			return this.QuestScheduleType<IQuestScheduleDistanceValue>().Value;
		}

		// Token: 0x06019337 RID: 103223 RVA: 0x003984E4 File Offset: 0x003966E4
		public IQuestScheduleEntityHP QuestScheduleTypeAsIQuestScheduleEntityHP()
		{
			return this.QuestScheduleType<IQuestScheduleEntityHP>().Value;
		}

		// Token: 0x06019338 RID: 103224 RVA: 0x00398500 File Offset: 0x00396700
		public IQuestScheduleMeetCondition QuestScheduleTypeAsIQuestScheduleMeetCondition()
		{
			return this.QuestScheduleType<IQuestScheduleMeetCondition>().Value;
		}

		// Token: 0x06019339 RID: 103225 RVA: 0x0039851C File Offset: 0x0039671C
		public IQuestScheduleMultiBtTreeVar QuestScheduleTypeAsIQuestScheduleMultiBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleMultiBtTreeVar>().Value;
		}

		// Token: 0x0601933A RID: 103226 RVA: 0x00398538 File Offset: 0x00396738
		public IQuestScheduleNone QuestScheduleTypeAsIQuestScheduleNone()
		{
			return this.QuestScheduleType<IQuestScheduleNone>().Value;
		}

		// Token: 0x0601933B RID: 103227 RVA: 0x00398554 File Offset: 0x00396754
		public IQuestScheduleProgressValue QuestScheduleTypeAsIQuestScheduleProgressValue()
		{
			return this.QuestScheduleType<IQuestScheduleProgressValue>().Value;
		}

		// Token: 0x0601933C RID: 103228 RVA: 0x00398570 File Offset: 0x00396770
		public IQuestScheduleRoleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleRoleTowerChallengeTitle>().Value;
		}

		// Token: 0x0601933D RID: 103229 RVA: 0x0039858C File Offset: 0x0039678C
		public IQuestScheduleScore QuestScheduleTypeAsIQuestScheduleScore()
		{
			return this.QuestScheduleType<IQuestScheduleScore>().Value;
		}

		// Token: 0x0601933E RID: 103230 RVA: 0x003985A8 File Offset: 0x003967A8
		public IQuestScheduleTimeLeft QuestScheduleTypeAsIQuestScheduleTimeLeft()
		{
			return this.QuestScheduleType<IQuestScheduleTimeLeft>().Value;
		}

		// Token: 0x0601933F RID: 103231 RVA: 0x003985C4 File Offset: 0x003967C4
		public IQuestScheduleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleTowerChallengeTitle>().Value;
		}

		// Token: 0x170079AF RID: 31151
		// (get) Token: 0x06019340 RID: 103232 RVA: 0x003985E0 File Offset: 0x003967E0
		public IConditionGroup? ShowConditions
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170079B0 RID: 31152
		// (get) Token: 0x06019341 RID: 103233 RVA: 0x00398640 File Offset: 0x00396840
		public int CustomIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170079B1 RID: 31153
		// (get) Token: 0x06019342 RID: 103234 RVA: 0x00398680 File Offset: 0x00396880
		public IProgressBar? ProgressBar
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IProgressBar?(default(IProgressBar).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06019343 RID: 103235 RVA: 0x003986E0 File Offset: 0x003968E0
		public IConditionText? ConditionText(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IConditionText?(default(IConditionText).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170079B2 RID: 31154
		// (get) Token: 0x06019344 RID: 103236 RVA: 0x00398744 File Offset: 0x00396944
		public int ConditionTextLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170079B3 RID: 31155
		// (get) Token: 0x06019345 RID: 103237 RVA: 0x00398770 File Offset: 0x00396970
		public bool BlankTitleStillShow
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06019346 RID: 103238 RVA: 0x003987B0 File Offset: 0x003969B0
		public ICustomPlaceholderBindingProgress? CustomPlaceholderBindingProgressList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new ICustomPlaceholderBindingProgress?(default(ICustomPlaceholderBindingProgress).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170079B4 RID: 31156
		// (get) Token: 0x06019347 RID: 103239 RVA: 0x00398814 File Offset: 0x00396A14
		public int CustomPlaceholderBindingProgressListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170079B5 RID: 31157
		// (get) Token: 0x06019348 RID: 103240 RVA: 0x00398840 File Offset: 0x00396A40
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019349 RID: 103241 RVA: 0x00398880 File Offset: 0x00396A80
		public static Offset<IQuestScheduleSubTitle> CreateIQuestScheduleSubTitle(FlatBufferBuilder builder, StringOffset TidTitleOffset = default(StringOffset), TQuestSchedule QuestScheduleType_type = TQuestSchedule.NONE, int QuestScheduleTypeOffset = 0, Offset<IConditionGroup> ShowConditionsOffset = default(Offset<IConditionGroup>), int CustomIcon = 0, Offset<IProgressBar> ProgressBarOffset = default(Offset<IProgressBar>), VectorOffset ConditionTextOffset = default(VectorOffset), bool BlankTitleStillShow = false, VectorOffset CustomPlaceholderBindingProgressListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(10);
			IQuestScheduleSubTitle.AddCustomPlaceholderBindingProgressList(builder, CustomPlaceholderBindingProgressListOffset);
			IQuestScheduleSubTitle.AddConditionText(builder, ConditionTextOffset);
			IQuestScheduleSubTitle.AddProgressBar(builder, ProgressBarOffset);
			IQuestScheduleSubTitle.AddCustomIcon(builder, CustomIcon);
			IQuestScheduleSubTitle.AddShowConditions(builder, ShowConditionsOffset);
			IQuestScheduleSubTitle.AddQuestScheduleType(builder, QuestScheduleTypeOffset);
			IQuestScheduleSubTitle.AddTidTitle(builder, TidTitleOffset);
			IQuestScheduleSubTitle.AddNullMask(builder, NullMask);
			IQuestScheduleSubTitle.AddBlankTitleStillShow(builder, BlankTitleStillShow);
			IQuestScheduleSubTitle.AddQuestScheduleTypeType(builder, QuestScheduleType_type);
			return IQuestScheduleSubTitle.EndIQuestScheduleSubTitle(builder);
		}

		// Token: 0x0601934A RID: 103242 RVA: 0x003988E8 File Offset: 0x00396AE8
		public static void StartIQuestScheduleSubTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0601934B RID: 103243 RVA: 0x003988F2 File Offset: 0x00396AF2
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(0, tidTitleOffset.Value, 0);
		}

		// Token: 0x0601934C RID: 103244 RVA: 0x00398902 File Offset: 0x00396B02
		public static void AddQuestScheduleTypeType(FlatBufferBuilder builder, TQuestSchedule questScheduleTypeType)
		{
			builder.AddByte(1, (byte)questScheduleTypeType, 0);
		}

		// Token: 0x0601934D RID: 103245 RVA: 0x0039890D File Offset: 0x00396B0D
		public static void AddQuestScheduleType(FlatBufferBuilder builder, int questScheduleTypeOffset)
		{
			builder.AddOffset(2, questScheduleTypeOffset, 0);
		}

		// Token: 0x0601934E RID: 103246 RVA: 0x00398918 File Offset: 0x00396B18
		public static void AddShowConditions(FlatBufferBuilder builder, Offset<IConditionGroup> showConditionsOffset)
		{
			builder.AddOffset(3, showConditionsOffset.Value, 0);
		}

		// Token: 0x0601934F RID: 103247 RVA: 0x00398928 File Offset: 0x00396B28
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(4, customIcon, 0);
		}

		// Token: 0x06019350 RID: 103248 RVA: 0x00398933 File Offset: 0x00396B33
		public static void AddProgressBar(FlatBufferBuilder builder, Offset<IProgressBar> progressBarOffset)
		{
			builder.AddOffset(5, progressBarOffset.Value, 0);
		}

		// Token: 0x06019351 RID: 103249 RVA: 0x00398943 File Offset: 0x00396B43
		public static void AddConditionText(FlatBufferBuilder builder, VectorOffset conditionTextOffset)
		{
			builder.AddOffset(6, conditionTextOffset.Value, 0);
		}

		// Token: 0x06019352 RID: 103250 RVA: 0x00398954 File Offset: 0x00396B54
		public static VectorOffset CreateConditionTextVector(FlatBufferBuilder builder, Offset<IConditionText>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06019353 RID: 103251 RVA: 0x00398994 File Offset: 0x00396B94
		public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, Offset<IConditionText>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionText>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019354 RID: 103252 RVA: 0x003989AE File Offset: 0x00396BAE
		public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionText>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionText>>(data);
			return builder.EndVector();
		}

		// Token: 0x06019355 RID: 103253 RVA: 0x003989CC File Offset: 0x00396BCC
		public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionText>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019356 RID: 103254 RVA: 0x003989E5 File Offset: 0x00396BE5
		public static void StartConditionTextVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019357 RID: 103255 RVA: 0x003989F0 File Offset: 0x00396BF0
		public static void AddBlankTitleStillShow(FlatBufferBuilder builder, bool blankTitleStillShow)
		{
			builder.AddBool(7, blankTitleStillShow, false);
		}

		// Token: 0x06019358 RID: 103256 RVA: 0x003989FB File Offset: 0x00396BFB
		public static void AddCustomPlaceholderBindingProgressList(FlatBufferBuilder builder, VectorOffset customPlaceholderBindingProgressListOffset)
		{
			builder.AddOffset(8, customPlaceholderBindingProgressListOffset.Value, 0);
		}

		// Token: 0x06019359 RID: 103257 RVA: 0x00398A0C File Offset: 0x00396C0C
		public static VectorOffset CreateCustomPlaceholderBindingProgressListVector(FlatBufferBuilder builder, Offset<ICustomPlaceholderBindingProgress>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601935A RID: 103258 RVA: 0x00398A4C File Offset: 0x00396C4C
		public static VectorOffset CreateCustomPlaceholderBindingProgressListVectorBlock(FlatBufferBuilder builder, Offset<ICustomPlaceholderBindingProgress>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICustomPlaceholderBindingProgress>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601935B RID: 103259 RVA: 0x00398A66 File Offset: 0x00396C66
		public static VectorOffset CreateCustomPlaceholderBindingProgressListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICustomPlaceholderBindingProgress>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICustomPlaceholderBindingProgress>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601935C RID: 103260 RVA: 0x00398A84 File Offset: 0x00396C84
		public static VectorOffset CreateCustomPlaceholderBindingProgressListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICustomPlaceholderBindingProgress>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601935D RID: 103261 RVA: 0x00398A9D File Offset: 0x00396C9D
		public static void StartCustomPlaceholderBindingProgressListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601935E RID: 103262 RVA: 0x00398AA8 File Offset: 0x00396CA8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x0601935F RID: 103263 RVA: 0x00398AB4 File Offset: 0x00396CB4
		public static Offset<IQuestScheduleSubTitle> EndIQuestScheduleSubTitle(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleSubTitle>(builder.EndTable());
		}

		// Token: 0x06019360 RID: 103264 RVA: 0x00398AC4 File Offset: 0x00396CC4
		public IQuestScheduleSubTitleT UnPack()
		{
			IQuestScheduleSubTitleT questScheduleSubTitleT = new IQuestScheduleSubTitleT();
			this.UnPackTo(questScheduleSubTitleT);
			return questScheduleSubTitleT;
		}

		// Token: 0x06019361 RID: 103265 RVA: 0x00398AE0 File Offset: 0x00396CE0
		public void UnPackTo(IQuestScheduleSubTitleT _o)
		{
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
			_o.ShowConditions = ((this.ShowConditions != null) ? this.ShowConditions.Value.UnPack() : null);
			_o.CustomIcon = this.CustomIcon;
			_o.ProgressBar = ((this.ProgressBar != null) ? this.ProgressBar.Value.UnPack() : null);
			_o.ConditionText = new List<IConditionTextT>();
			for (int i = 0; i < this.ConditionTextLength; i++)
			{
				_o.ConditionText.Add((this.ConditionText(i) != null) ? this.ConditionText(i).Value.UnPack() : null);
			}
			_o.BlankTitleStillShow = this.BlankTitleStillShow;
			_o.CustomPlaceholderBindingProgressList = new List<ICustomPlaceholderBindingProgressT>();
			for (int j = 0; j < this.CustomPlaceholderBindingProgressListLength; j++)
			{
				_o.CustomPlaceholderBindingProgressList.Add((this.CustomPlaceholderBindingProgressList(j) != null) ? this.CustomPlaceholderBindingProgressList(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019362 RID: 103266 RVA: 0x00398F98 File Offset: 0x00397198
		public static Offset<IQuestScheduleSubTitle> Pack(FlatBufferBuilder builder, IQuestScheduleSubTitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleSubTitle>);
			}
			StringOffset tidTitleOffset = (_o.TidTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidTitle);
			TQuestSchedule questScheduleType_type = (_o.QuestScheduleType == null) ? TQuestSchedule.NONE : _o.QuestScheduleType.Type;
			int questScheduleTypeOffset = (_o.QuestScheduleType == null) ? 0 : TQuestScheduleUnion.Pack(builder, _o.QuestScheduleType);
			Offset<IConditionGroup> showConditionsOffset = (_o.ShowConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ShowConditions);
			Offset<IProgressBar> progressBarOffset = (_o.ProgressBar == null) ? default(Offset<IProgressBar>) : IProgressBar.Pack(builder, _o.ProgressBar);
			VectorOffset conditionTextOffset = default(VectorOffset);
			if (_o.ConditionText != null)
			{
				Offset<IConditionText>[] array = new Offset<IConditionText>[_o.ConditionText.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConditionText.Pack(builder, _o.ConditionText[i]);
				}
				conditionTextOffset = IQuestScheduleSubTitle.CreateConditionTextVector(builder, array);
			}
			VectorOffset customPlaceholderBindingProgressListOffset = default(VectorOffset);
			if (_o.CustomPlaceholderBindingProgressList != null)
			{
				Offset<ICustomPlaceholderBindingProgress>[] array2 = new Offset<ICustomPlaceholderBindingProgress>[_o.CustomPlaceholderBindingProgressList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ICustomPlaceholderBindingProgress.Pack(builder, _o.CustomPlaceholderBindingProgressList[j]);
				}
				customPlaceholderBindingProgressListOffset = IQuestScheduleSubTitle.CreateCustomPlaceholderBindingProgressListVector(builder, array2);
			}
			return IQuestScheduleSubTitle.CreateIQuestScheduleSubTitle(builder, tidTitleOffset, questScheduleType_type, questScheduleTypeOffset, showConditionsOffset, _o.CustomIcon, progressBarOffset, conditionTextOffset, _o.BlankTitleStillShow, customPlaceholderBindingProgressListOffset, _o.NullMask);
		}

		// Token: 0x0400C54E RID: 50510
		private Table __p;
	}
}
