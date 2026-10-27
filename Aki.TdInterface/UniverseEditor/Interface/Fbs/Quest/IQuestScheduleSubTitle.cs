using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200403A RID: 16442
	public struct IQuestScheduleSubTitle : IFlatbufferObject
	{
		// Token: 0x170073AA RID: 29610
		// (get) Token: 0x06017C8F RID: 97423 RVA: 0x0036E53D File Offset: 0x0036C73D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017C90 RID: 97424 RVA: 0x0036E54A File Offset: 0x0036C74A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017C91 RID: 97425 RVA: 0x0036E554 File Offset: 0x0036C754
		public static IQuestScheduleSubTitle GetRootAsIQuestScheduleSubTitle(ByteBuffer _bb)
		{
			return IQuestScheduleSubTitle.GetRootAsIQuestScheduleSubTitle(_bb, default(IQuestScheduleSubTitle));
		}

		// Token: 0x06017C92 RID: 97426 RVA: 0x0036E570 File Offset: 0x0036C770
		public static IQuestScheduleSubTitle GetRootAsIQuestScheduleSubTitle(ByteBuffer _bb, IQuestScheduleSubTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017C93 RID: 97427 RVA: 0x0036E58D File Offset: 0x0036C78D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017C94 RID: 97428 RVA: 0x0036E59C File Offset: 0x0036C79C
		public IQuestScheduleSubTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073AB RID: 29611
		// (get) Token: 0x06017C95 RID: 97429 RVA: 0x0036E5AC File Offset: 0x0036C7AC
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

		// Token: 0x06017C96 RID: 97430 RVA: 0x0036E5E3 File Offset: 0x0036C7E3
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06017C97 RID: 97431 RVA: 0x0036E5F2 File Offset: 0x0036C7F2
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170073AC RID: 29612
		// (get) Token: 0x06017C98 RID: 97432 RVA: 0x0036E600 File Offset: 0x0036C800
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

		// Token: 0x06017C99 RID: 97433 RVA: 0x0036E63C File Offset: 0x0036C83C
		public TTable? QuestScheduleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017C9A RID: 97434 RVA: 0x0036E680 File Offset: 0x0036C880
		public IQuestScheduleBtTreeVar QuestScheduleTypeAsIQuestScheduleBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleBtTreeVar>().Value;
		}

		// Token: 0x06017C9B RID: 97435 RVA: 0x0036E69C File Offset: 0x0036C89C
		public IQuestScheduleChildQuestCompleted QuestScheduleTypeAsIQuestScheduleChildQuestCompleted()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompleted>().Value;
		}

		// Token: 0x06017C9C RID: 97436 RVA: 0x0036E6B8 File Offset: 0x0036C8B8
		public IQuestScheduleChildQuestCompletedCount QuestScheduleTypeAsIQuestScheduleChildQuestCompletedCount()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompletedCount>().Value;
		}

		// Token: 0x06017C9D RID: 97437 RVA: 0x0036E6D4 File Offset: 0x0036C8D4
		public IQuestScheduleDistanceValue QuestScheduleTypeAsIQuestScheduleDistanceValue()
		{
			return this.QuestScheduleType<IQuestScheduleDistanceValue>().Value;
		}

		// Token: 0x06017C9E RID: 97438 RVA: 0x0036E6F0 File Offset: 0x0036C8F0
		public IQuestScheduleEntityHP QuestScheduleTypeAsIQuestScheduleEntityHP()
		{
			return this.QuestScheduleType<IQuestScheduleEntityHP>().Value;
		}

		// Token: 0x06017C9F RID: 97439 RVA: 0x0036E70C File Offset: 0x0036C90C
		public IQuestScheduleMeetCondition QuestScheduleTypeAsIQuestScheduleMeetCondition()
		{
			return this.QuestScheduleType<IQuestScheduleMeetCondition>().Value;
		}

		// Token: 0x06017CA0 RID: 97440 RVA: 0x0036E728 File Offset: 0x0036C928
		public IQuestScheduleMultiBtTreeVar QuestScheduleTypeAsIQuestScheduleMultiBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleMultiBtTreeVar>().Value;
		}

		// Token: 0x06017CA1 RID: 97441 RVA: 0x0036E744 File Offset: 0x0036C944
		public IQuestScheduleNone QuestScheduleTypeAsIQuestScheduleNone()
		{
			return this.QuestScheduleType<IQuestScheduleNone>().Value;
		}

		// Token: 0x06017CA2 RID: 97442 RVA: 0x0036E760 File Offset: 0x0036C960
		public IQuestScheduleProgressValue QuestScheduleTypeAsIQuestScheduleProgressValue()
		{
			return this.QuestScheduleType<IQuestScheduleProgressValue>().Value;
		}

		// Token: 0x06017CA3 RID: 97443 RVA: 0x0036E77C File Offset: 0x0036C97C
		public IQuestScheduleRoleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleRoleTowerChallengeTitle>().Value;
		}

		// Token: 0x06017CA4 RID: 97444 RVA: 0x0036E798 File Offset: 0x0036C998
		public IQuestScheduleScore QuestScheduleTypeAsIQuestScheduleScore()
		{
			return this.QuestScheduleType<IQuestScheduleScore>().Value;
		}

		// Token: 0x06017CA5 RID: 97445 RVA: 0x0036E7B4 File Offset: 0x0036C9B4
		public IQuestScheduleTimeLeft QuestScheduleTypeAsIQuestScheduleTimeLeft()
		{
			return this.QuestScheduleType<IQuestScheduleTimeLeft>().Value;
		}

		// Token: 0x06017CA6 RID: 97446 RVA: 0x0036E7D0 File Offset: 0x0036C9D0
		public IQuestScheduleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleTowerChallengeTitle>().Value;
		}

		// Token: 0x170073AD RID: 29613
		// (get) Token: 0x06017CA7 RID: 97447 RVA: 0x0036E7EC File Offset: 0x0036C9EC
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

		// Token: 0x170073AE RID: 29614
		// (get) Token: 0x06017CA8 RID: 97448 RVA: 0x0036E84C File Offset: 0x0036CA4C
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

		// Token: 0x170073AF RID: 29615
		// (get) Token: 0x06017CA9 RID: 97449 RVA: 0x0036E88C File Offset: 0x0036CA8C
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

		// Token: 0x06017CAA RID: 97450 RVA: 0x0036E8EC File Offset: 0x0036CAEC
		public IConditionText? ConditionText(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IConditionText?(default(IConditionText).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170073B0 RID: 29616
		// (get) Token: 0x06017CAB RID: 97451 RVA: 0x0036E950 File Offset: 0x0036CB50
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

		// Token: 0x170073B1 RID: 29617
		// (get) Token: 0x06017CAC RID: 97452 RVA: 0x0036E97C File Offset: 0x0036CB7C
		public bool BlankTitleStillShow
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06017CAD RID: 97453 RVA: 0x0036E9BC File Offset: 0x0036CBBC
		public ICustomPlaceholderBindingProgress? CustomPlaceholderBindingProgressList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new ICustomPlaceholderBindingProgress?(default(ICustomPlaceholderBindingProgress).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170073B2 RID: 29618
		// (get) Token: 0x06017CAE RID: 97454 RVA: 0x0036EA20 File Offset: 0x0036CC20
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

		// Token: 0x170073B3 RID: 29619
		// (get) Token: 0x06017CAF RID: 97455 RVA: 0x0036EA4C File Offset: 0x0036CC4C
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

		// Token: 0x06017CB0 RID: 97456 RVA: 0x0036EA8C File Offset: 0x0036CC8C
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

		// Token: 0x06017CB1 RID: 97457 RVA: 0x0036EAF4 File Offset: 0x0036CCF4
		public static void StartIQuestScheduleSubTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06017CB2 RID: 97458 RVA: 0x0036EAFE File Offset: 0x0036CCFE
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(0, tidTitleOffset.Value, 0);
		}

		// Token: 0x06017CB3 RID: 97459 RVA: 0x0036EB0E File Offset: 0x0036CD0E
		public static void AddQuestScheduleTypeType(FlatBufferBuilder builder, TQuestSchedule questScheduleTypeType)
		{
			builder.AddByte(1, (byte)questScheduleTypeType, 0);
		}

		// Token: 0x06017CB4 RID: 97460 RVA: 0x0036EB19 File Offset: 0x0036CD19
		public static void AddQuestScheduleType(FlatBufferBuilder builder, int questScheduleTypeOffset)
		{
			builder.AddOffset(2, questScheduleTypeOffset, 0);
		}

		// Token: 0x06017CB5 RID: 97461 RVA: 0x0036EB24 File Offset: 0x0036CD24
		public static void AddShowConditions(FlatBufferBuilder builder, Offset<IConditionGroup> showConditionsOffset)
		{
			builder.AddOffset(3, showConditionsOffset.Value, 0);
		}

		// Token: 0x06017CB6 RID: 97462 RVA: 0x0036EB34 File Offset: 0x0036CD34
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(4, customIcon, 0);
		}

		// Token: 0x06017CB7 RID: 97463 RVA: 0x0036EB3F File Offset: 0x0036CD3F
		public static void AddProgressBar(FlatBufferBuilder builder, Offset<IProgressBar> progressBarOffset)
		{
			builder.AddOffset(5, progressBarOffset.Value, 0);
		}

		// Token: 0x06017CB8 RID: 97464 RVA: 0x0036EB4F File Offset: 0x0036CD4F
		public static void AddConditionText(FlatBufferBuilder builder, VectorOffset conditionTextOffset)
		{
			builder.AddOffset(6, conditionTextOffset.Value, 0);
		}

		// Token: 0x06017CB9 RID: 97465 RVA: 0x0036EB60 File Offset: 0x0036CD60
		public static VectorOffset CreateConditionTextVector(FlatBufferBuilder builder, Offset<IConditionText>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017CBA RID: 97466 RVA: 0x0036EBA0 File Offset: 0x0036CDA0
		public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, Offset<IConditionText>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionText>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017CBB RID: 97467 RVA: 0x0036EBBA File Offset: 0x0036CDBA
		public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionText>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionText>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017CBC RID: 97468 RVA: 0x0036EBD8 File Offset: 0x0036CDD8
		public static VectorOffset CreateConditionTextVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionText>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017CBD RID: 97469 RVA: 0x0036EBF1 File Offset: 0x0036CDF1
		public static void StartConditionTextVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017CBE RID: 97470 RVA: 0x0036EBFC File Offset: 0x0036CDFC
		public static void AddBlankTitleStillShow(FlatBufferBuilder builder, bool blankTitleStillShow)
		{
			builder.AddBool(7, blankTitleStillShow, false);
		}

		// Token: 0x06017CBF RID: 97471 RVA: 0x0036EC07 File Offset: 0x0036CE07
		public static void AddCustomPlaceholderBindingProgressList(FlatBufferBuilder builder, VectorOffset customPlaceholderBindingProgressListOffset)
		{
			builder.AddOffset(8, customPlaceholderBindingProgressListOffset.Value, 0);
		}

		// Token: 0x06017CC0 RID: 97472 RVA: 0x0036EC18 File Offset: 0x0036CE18
		public static VectorOffset CreateCustomPlaceholderBindingProgressListVector(FlatBufferBuilder builder, Offset<ICustomPlaceholderBindingProgress>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017CC1 RID: 97473 RVA: 0x0036EC58 File Offset: 0x0036CE58
		public static VectorOffset CreateCustomPlaceholderBindingProgressListVectorBlock(FlatBufferBuilder builder, Offset<ICustomPlaceholderBindingProgress>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICustomPlaceholderBindingProgress>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017CC2 RID: 97474 RVA: 0x0036EC72 File Offset: 0x0036CE72
		public static VectorOffset CreateCustomPlaceholderBindingProgressListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICustomPlaceholderBindingProgress>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICustomPlaceholderBindingProgress>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017CC3 RID: 97475 RVA: 0x0036EC90 File Offset: 0x0036CE90
		public static VectorOffset CreateCustomPlaceholderBindingProgressListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICustomPlaceholderBindingProgress>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017CC4 RID: 97476 RVA: 0x0036ECA9 File Offset: 0x0036CEA9
		public static void StartCustomPlaceholderBindingProgressListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017CC5 RID: 97477 RVA: 0x0036ECB4 File Offset: 0x0036CEB4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06017CC6 RID: 97478 RVA: 0x0036ECC0 File Offset: 0x0036CEC0
		public static Offset<IQuestScheduleSubTitle> EndIQuestScheduleSubTitle(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleSubTitle>(builder.EndTable());
		}

		// Token: 0x06017CC7 RID: 97479 RVA: 0x0036ECD0 File Offset: 0x0036CED0
		public IQuestScheduleSubTitleT UnPack()
		{
			IQuestScheduleSubTitleT questScheduleSubTitleT = new IQuestScheduleSubTitleT();
			this.UnPackTo(questScheduleSubTitleT);
			return questScheduleSubTitleT;
		}

		// Token: 0x06017CC8 RID: 97480 RVA: 0x0036ECEC File Offset: 0x0036CEEC
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

		// Token: 0x06017CC9 RID: 97481 RVA: 0x0036F1A4 File Offset: 0x0036D3A4
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

		// Token: 0x0400BB67 RID: 47975
		private Table __p;
	}
}
