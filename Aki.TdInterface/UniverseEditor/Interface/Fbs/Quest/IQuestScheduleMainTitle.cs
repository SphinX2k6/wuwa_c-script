using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004466 RID: 17510
	public struct IQuestScheduleMainTitle : IFlatbufferObject
	{
		// Token: 0x1700797F RID: 31103
		// (get) Token: 0x06019248 RID: 102984 RVA: 0x00396152 File Offset: 0x00394352
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019249 RID: 102985 RVA: 0x0039615F File Offset: 0x0039435F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601924A RID: 102986 RVA: 0x00396168 File Offset: 0x00394368
		public static IQuestScheduleMainTitle GetRootAsIQuestScheduleMainTitle(ByteBuffer _bb)
		{
			return IQuestScheduleMainTitle.GetRootAsIQuestScheduleMainTitle(_bb, default(IQuestScheduleMainTitle));
		}

		// Token: 0x0601924B RID: 102987 RVA: 0x00396184 File Offset: 0x00394384
		public static IQuestScheduleMainTitle GetRootAsIQuestScheduleMainTitle(ByteBuffer _bb, IQuestScheduleMainTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601924C RID: 102988 RVA: 0x003961A1 File Offset: 0x003943A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601924D RID: 102989 RVA: 0x003961B0 File Offset: 0x003943B0
		public IQuestScheduleMainTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007980 RID: 31104
		// (get) Token: 0x0601924E RID: 102990 RVA: 0x003961C0 File Offset: 0x003943C0
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

		// Token: 0x0601924F RID: 102991 RVA: 0x003961F7 File Offset: 0x003943F7
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06019250 RID: 102992 RVA: 0x00396206 File Offset: 0x00394406
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17007981 RID: 31105
		// (get) Token: 0x06019251 RID: 102993 RVA: 0x00396214 File Offset: 0x00394414
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

		// Token: 0x06019252 RID: 102994 RVA: 0x00396250 File Offset: 0x00394450
		public TTable? QuestScheduleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019253 RID: 102995 RVA: 0x00396294 File Offset: 0x00394494
		public IQuestScheduleBtTreeVar QuestScheduleTypeAsIQuestScheduleBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleBtTreeVar>().Value;
		}

		// Token: 0x06019254 RID: 102996 RVA: 0x003962B0 File Offset: 0x003944B0
		public IQuestScheduleChildQuestCompleted QuestScheduleTypeAsIQuestScheduleChildQuestCompleted()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompleted>().Value;
		}

		// Token: 0x06019255 RID: 102997 RVA: 0x003962CC File Offset: 0x003944CC
		public IQuestScheduleChildQuestCompletedCount QuestScheduleTypeAsIQuestScheduleChildQuestCompletedCount()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompletedCount>().Value;
		}

		// Token: 0x06019256 RID: 102998 RVA: 0x003962E8 File Offset: 0x003944E8
		public IQuestScheduleDistanceValue QuestScheduleTypeAsIQuestScheduleDistanceValue()
		{
			return this.QuestScheduleType<IQuestScheduleDistanceValue>().Value;
		}

		// Token: 0x06019257 RID: 102999 RVA: 0x00396304 File Offset: 0x00394504
		public IQuestScheduleEntityHP QuestScheduleTypeAsIQuestScheduleEntityHP()
		{
			return this.QuestScheduleType<IQuestScheduleEntityHP>().Value;
		}

		// Token: 0x06019258 RID: 103000 RVA: 0x00396320 File Offset: 0x00394520
		public IQuestScheduleMeetCondition QuestScheduleTypeAsIQuestScheduleMeetCondition()
		{
			return this.QuestScheduleType<IQuestScheduleMeetCondition>().Value;
		}

		// Token: 0x06019259 RID: 103001 RVA: 0x0039633C File Offset: 0x0039453C
		public IQuestScheduleMultiBtTreeVar QuestScheduleTypeAsIQuestScheduleMultiBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleMultiBtTreeVar>().Value;
		}

		// Token: 0x0601925A RID: 103002 RVA: 0x00396358 File Offset: 0x00394558
		public IQuestScheduleNone QuestScheduleTypeAsIQuestScheduleNone()
		{
			return this.QuestScheduleType<IQuestScheduleNone>().Value;
		}

		// Token: 0x0601925B RID: 103003 RVA: 0x00396374 File Offset: 0x00394574
		public IQuestScheduleProgressValue QuestScheduleTypeAsIQuestScheduleProgressValue()
		{
			return this.QuestScheduleType<IQuestScheduleProgressValue>().Value;
		}

		// Token: 0x0601925C RID: 103004 RVA: 0x00396390 File Offset: 0x00394590
		public IQuestScheduleRoleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleRoleTowerChallengeTitle>().Value;
		}

		// Token: 0x0601925D RID: 103005 RVA: 0x003963AC File Offset: 0x003945AC
		public IQuestScheduleScore QuestScheduleTypeAsIQuestScheduleScore()
		{
			return this.QuestScheduleType<IQuestScheduleScore>().Value;
		}

		// Token: 0x0601925E RID: 103006 RVA: 0x003963C8 File Offset: 0x003945C8
		public IQuestScheduleTimeLeft QuestScheduleTypeAsIQuestScheduleTimeLeft()
		{
			return this.QuestScheduleType<IQuestScheduleTimeLeft>().Value;
		}

		// Token: 0x0601925F RID: 103007 RVA: 0x003963E4 File Offset: 0x003945E4
		public IQuestScheduleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleTowerChallengeTitle>().Value;
		}

		// Token: 0x17007982 RID: 31106
		// (get) Token: 0x06019260 RID: 103008 RVA: 0x00396400 File Offset: 0x00394600
		public int CustomIcon
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

		// Token: 0x17007983 RID: 31107
		// (get) Token: 0x06019261 RID: 103009 RVA: 0x00396440 File Offset: 0x00394640
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019262 RID: 103010 RVA: 0x0039647D File Offset: 0x0039467D
		public static Offset<IQuestScheduleMainTitle> CreateIQuestScheduleMainTitle(FlatBufferBuilder builder, StringOffset TidTitleOffset = default(StringOffset), TQuestSchedule QuestScheduleType_type = TQuestSchedule.NONE, int QuestScheduleTypeOffset = 0, int CustomIcon = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IQuestScheduleMainTitle.AddCustomIcon(builder, CustomIcon);
			IQuestScheduleMainTitle.AddQuestScheduleType(builder, QuestScheduleTypeOffset);
			IQuestScheduleMainTitle.AddTidTitle(builder, TidTitleOffset);
			IQuestScheduleMainTitle.AddNullMask(builder, NullMask);
			IQuestScheduleMainTitle.AddQuestScheduleTypeType(builder, QuestScheduleType_type);
			return IQuestScheduleMainTitle.EndIQuestScheduleMainTitle(builder);
		}

		// Token: 0x06019263 RID: 103011 RVA: 0x003964B1 File Offset: 0x003946B1
		public static void StartIQuestScheduleMainTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06019264 RID: 103012 RVA: 0x003964BA File Offset: 0x003946BA
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(0, tidTitleOffset.Value, 0);
		}

		// Token: 0x06019265 RID: 103013 RVA: 0x003964CA File Offset: 0x003946CA
		public static void AddQuestScheduleTypeType(FlatBufferBuilder builder, TQuestSchedule questScheduleTypeType)
		{
			builder.AddByte(1, (byte)questScheduleTypeType, 0);
		}

		// Token: 0x06019266 RID: 103014 RVA: 0x003964D5 File Offset: 0x003946D5
		public static void AddQuestScheduleType(FlatBufferBuilder builder, int questScheduleTypeOffset)
		{
			builder.AddOffset(2, questScheduleTypeOffset, 0);
		}

		// Token: 0x06019267 RID: 103015 RVA: 0x003964E0 File Offset: 0x003946E0
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(3, customIcon, 0);
		}

		// Token: 0x06019268 RID: 103016 RVA: 0x003964EB File Offset: 0x003946EB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06019269 RID: 103017 RVA: 0x003964F6 File Offset: 0x003946F6
		public static Offset<IQuestScheduleMainTitle> EndIQuestScheduleMainTitle(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleMainTitle>(builder.EndTable());
		}

		// Token: 0x0601926A RID: 103018 RVA: 0x00396504 File Offset: 0x00394704
		public IQuestScheduleMainTitleT UnPack()
		{
			IQuestScheduleMainTitleT questScheduleMainTitleT = new IQuestScheduleMainTitleT();
			this.UnPackTo(questScheduleMainTitleT);
			return questScheduleMainTitleT;
		}

		// Token: 0x0601926B RID: 103019 RVA: 0x00396520 File Offset: 0x00394720
		public void UnPackTo(IQuestScheduleMainTitleT _o)
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
			_o.CustomIcon = this.CustomIcon;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601926C RID: 103020 RVA: 0x003968B4 File Offset: 0x00394AB4
		public static Offset<IQuestScheduleMainTitle> Pack(FlatBufferBuilder builder, IQuestScheduleMainTitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleMainTitle>);
			}
			StringOffset tidTitleOffset = (_o.TidTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidTitle);
			TQuestSchedule questScheduleType_type = (_o.QuestScheduleType == null) ? TQuestSchedule.NONE : _o.QuestScheduleType.Type;
			int questScheduleTypeOffset = (_o.QuestScheduleType == null) ? 0 : TQuestScheduleUnion.Pack(builder, _o.QuestScheduleType);
			return IQuestScheduleMainTitle.CreateIQuestScheduleMainTitle(builder, tidTitleOffset, questScheduleType_type, questScheduleTypeOffset, _o.CustomIcon, _o.NullMask);
		}

		// Token: 0x0400C535 RID: 50485
		private Table __p;
	}
}
