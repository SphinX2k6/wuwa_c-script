using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004025 RID: 16421
	public struct IQuestScheduleMainTitle : IFlatbufferObject
	{
		// Token: 0x1700737D RID: 29565
		// (get) Token: 0x06017BAF RID: 97199 RVA: 0x0036C35E File Offset: 0x0036A55E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017BB0 RID: 97200 RVA: 0x0036C36B File Offset: 0x0036A56B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017BB1 RID: 97201 RVA: 0x0036C374 File Offset: 0x0036A574
		public static IQuestScheduleMainTitle GetRootAsIQuestScheduleMainTitle(ByteBuffer _bb)
		{
			return IQuestScheduleMainTitle.GetRootAsIQuestScheduleMainTitle(_bb, default(IQuestScheduleMainTitle));
		}

		// Token: 0x06017BB2 RID: 97202 RVA: 0x0036C390 File Offset: 0x0036A590
		public static IQuestScheduleMainTitle GetRootAsIQuestScheduleMainTitle(ByteBuffer _bb, IQuestScheduleMainTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017BB3 RID: 97203 RVA: 0x0036C3AD File Offset: 0x0036A5AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017BB4 RID: 97204 RVA: 0x0036C3BC File Offset: 0x0036A5BC
		public IQuestScheduleMainTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700737E RID: 29566
		// (get) Token: 0x06017BB5 RID: 97205 RVA: 0x0036C3CC File Offset: 0x0036A5CC
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

		// Token: 0x06017BB6 RID: 97206 RVA: 0x0036C403 File Offset: 0x0036A603
		public Span<byte> GetTidTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06017BB7 RID: 97207 RVA: 0x0036C412 File Offset: 0x0036A612
		public byte[] GetTidTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700737F RID: 29567
		// (get) Token: 0x06017BB8 RID: 97208 RVA: 0x0036C420 File Offset: 0x0036A620
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

		// Token: 0x06017BB9 RID: 97209 RVA: 0x0036C45C File Offset: 0x0036A65C
		public TTable? QuestScheduleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017BBA RID: 97210 RVA: 0x0036C4A0 File Offset: 0x0036A6A0
		public IQuestScheduleBtTreeVar QuestScheduleTypeAsIQuestScheduleBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleBtTreeVar>().Value;
		}

		// Token: 0x06017BBB RID: 97211 RVA: 0x0036C4BC File Offset: 0x0036A6BC
		public IQuestScheduleChildQuestCompleted QuestScheduleTypeAsIQuestScheduleChildQuestCompleted()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompleted>().Value;
		}

		// Token: 0x06017BBC RID: 97212 RVA: 0x0036C4D8 File Offset: 0x0036A6D8
		public IQuestScheduleChildQuestCompletedCount QuestScheduleTypeAsIQuestScheduleChildQuestCompletedCount()
		{
			return this.QuestScheduleType<IQuestScheduleChildQuestCompletedCount>().Value;
		}

		// Token: 0x06017BBD RID: 97213 RVA: 0x0036C4F4 File Offset: 0x0036A6F4
		public IQuestScheduleDistanceValue QuestScheduleTypeAsIQuestScheduleDistanceValue()
		{
			return this.QuestScheduleType<IQuestScheduleDistanceValue>().Value;
		}

		// Token: 0x06017BBE RID: 97214 RVA: 0x0036C510 File Offset: 0x0036A710
		public IQuestScheduleEntityHP QuestScheduleTypeAsIQuestScheduleEntityHP()
		{
			return this.QuestScheduleType<IQuestScheduleEntityHP>().Value;
		}

		// Token: 0x06017BBF RID: 97215 RVA: 0x0036C52C File Offset: 0x0036A72C
		public IQuestScheduleMeetCondition QuestScheduleTypeAsIQuestScheduleMeetCondition()
		{
			return this.QuestScheduleType<IQuestScheduleMeetCondition>().Value;
		}

		// Token: 0x06017BC0 RID: 97216 RVA: 0x0036C548 File Offset: 0x0036A748
		public IQuestScheduleMultiBtTreeVar QuestScheduleTypeAsIQuestScheduleMultiBtTreeVar()
		{
			return this.QuestScheduleType<IQuestScheduleMultiBtTreeVar>().Value;
		}

		// Token: 0x06017BC1 RID: 97217 RVA: 0x0036C564 File Offset: 0x0036A764
		public IQuestScheduleNone QuestScheduleTypeAsIQuestScheduleNone()
		{
			return this.QuestScheduleType<IQuestScheduleNone>().Value;
		}

		// Token: 0x06017BC2 RID: 97218 RVA: 0x0036C580 File Offset: 0x0036A780
		public IQuestScheduleProgressValue QuestScheduleTypeAsIQuestScheduleProgressValue()
		{
			return this.QuestScheduleType<IQuestScheduleProgressValue>().Value;
		}

		// Token: 0x06017BC3 RID: 97219 RVA: 0x0036C59C File Offset: 0x0036A79C
		public IQuestScheduleRoleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleRoleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleRoleTowerChallengeTitle>().Value;
		}

		// Token: 0x06017BC4 RID: 97220 RVA: 0x0036C5B8 File Offset: 0x0036A7B8
		public IQuestScheduleScore QuestScheduleTypeAsIQuestScheduleScore()
		{
			return this.QuestScheduleType<IQuestScheduleScore>().Value;
		}

		// Token: 0x06017BC5 RID: 97221 RVA: 0x0036C5D4 File Offset: 0x0036A7D4
		public IQuestScheduleTimeLeft QuestScheduleTypeAsIQuestScheduleTimeLeft()
		{
			return this.QuestScheduleType<IQuestScheduleTimeLeft>().Value;
		}

		// Token: 0x06017BC6 RID: 97222 RVA: 0x0036C5F0 File Offset: 0x0036A7F0
		public IQuestScheduleTowerChallengeTitle QuestScheduleTypeAsIQuestScheduleTowerChallengeTitle()
		{
			return this.QuestScheduleType<IQuestScheduleTowerChallengeTitle>().Value;
		}

		// Token: 0x17007380 RID: 29568
		// (get) Token: 0x06017BC7 RID: 97223 RVA: 0x0036C60C File Offset: 0x0036A80C
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

		// Token: 0x17007381 RID: 29569
		// (get) Token: 0x06017BC8 RID: 97224 RVA: 0x0036C64C File Offset: 0x0036A84C
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

		// Token: 0x06017BC9 RID: 97225 RVA: 0x0036C689 File Offset: 0x0036A889
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

		// Token: 0x06017BCA RID: 97226 RVA: 0x0036C6BD File Offset: 0x0036A8BD
		public static void StartIQuestScheduleMainTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06017BCB RID: 97227 RVA: 0x0036C6C6 File Offset: 0x0036A8C6
		public static void AddTidTitle(FlatBufferBuilder builder, StringOffset tidTitleOffset)
		{
			builder.AddOffset(0, tidTitleOffset.Value, 0);
		}

		// Token: 0x06017BCC RID: 97228 RVA: 0x0036C6D6 File Offset: 0x0036A8D6
		public static void AddQuestScheduleTypeType(FlatBufferBuilder builder, TQuestSchedule questScheduleTypeType)
		{
			builder.AddByte(1, (byte)questScheduleTypeType, 0);
		}

		// Token: 0x06017BCD RID: 97229 RVA: 0x0036C6E1 File Offset: 0x0036A8E1
		public static void AddQuestScheduleType(FlatBufferBuilder builder, int questScheduleTypeOffset)
		{
			builder.AddOffset(2, questScheduleTypeOffset, 0);
		}

		// Token: 0x06017BCE RID: 97230 RVA: 0x0036C6EC File Offset: 0x0036A8EC
		public static void AddCustomIcon(FlatBufferBuilder builder, int customIcon)
		{
			builder.AddInt(3, customIcon, 0);
		}

		// Token: 0x06017BCF RID: 97231 RVA: 0x0036C6F7 File Offset: 0x0036A8F7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06017BD0 RID: 97232 RVA: 0x0036C702 File Offset: 0x0036A902
		public static Offset<IQuestScheduleMainTitle> EndIQuestScheduleMainTitle(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleMainTitle>(builder.EndTable());
		}

		// Token: 0x06017BD1 RID: 97233 RVA: 0x0036C710 File Offset: 0x0036A910
		public IQuestScheduleMainTitleT UnPack()
		{
			IQuestScheduleMainTitleT questScheduleMainTitleT = new IQuestScheduleMainTitleT();
			this.UnPackTo(questScheduleMainTitleT);
			return questScheduleMainTitleT;
		}

		// Token: 0x06017BD2 RID: 97234 RVA: 0x0036C72C File Offset: 0x0036A92C
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

		// Token: 0x06017BD3 RID: 97235 RVA: 0x0036CAC0 File Offset: 0x0036ACC0
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

		// Token: 0x0400BB4E RID: 47950
		private Table __p;
	}
}
