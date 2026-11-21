using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004475 RID: 17525
	public struct IQuestScheduleRoleTowerChallengeTitle : IFlatbufferObject
	{
		// Token: 0x170079A4 RID: 31140
		// (get) Token: 0x060192FB RID: 103163 RVA: 0x00397DDE File Offset: 0x00395FDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060192FC RID: 103164 RVA: 0x00397DEB File Offset: 0x00395FEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060192FD RID: 103165 RVA: 0x00397DF4 File Offset: 0x00395FF4
		public static IQuestScheduleRoleTowerChallengeTitle GetRootAsIQuestScheduleRoleTowerChallengeTitle(ByteBuffer _bb)
		{
			return IQuestScheduleRoleTowerChallengeTitle.GetRootAsIQuestScheduleRoleTowerChallengeTitle(_bb, default(IQuestScheduleRoleTowerChallengeTitle));
		}

		// Token: 0x060192FE RID: 103166 RVA: 0x00397E10 File Offset: 0x00396010
		public static IQuestScheduleRoleTowerChallengeTitle GetRootAsIQuestScheduleRoleTowerChallengeTitle(ByteBuffer _bb, IQuestScheduleRoleTowerChallengeTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060192FF RID: 103167 RVA: 0x00397E2D File Offset: 0x0039602D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019300 RID: 103168 RVA: 0x00397E3C File Offset: 0x0039603C
		public IQuestScheduleRoleTowerChallengeTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079A5 RID: 31141
		// (get) Token: 0x06019301 RID: 103169 RVA: 0x00397E4C File Offset: 0x0039604C
		public EQuestScheduleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EQuestScheduleType.None;
				}
				return (EQuestScheduleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170079A6 RID: 31142
		// (get) Token: 0x06019302 RID: 103170 RVA: 0x00397E88 File Offset: 0x00396088
		public TRoleTowerChallengeTitleType TitleTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TRoleTowerChallengeTitleType.NONE;
				}
				return (TRoleTowerChallengeTitleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019303 RID: 103171 RVA: 0x00397EC4 File Offset: 0x003960C4
		public TTable? TitleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019304 RID: 103172 RVA: 0x00397F08 File Offset: 0x00396108
		public IRoleTowerChallengeTitleCurrentFloor TitleTypeAsIRoleTowerChallengeTitleCurrentFloor()
		{
			return this.TitleType<IRoleTowerChallengeTitleCurrentFloor>().Value;
		}

		// Token: 0x06019305 RID: 103173 RVA: 0x00397F24 File Offset: 0x00396124
		public IRoleTowerChallengeTitleKillProgress TitleTypeAsIRoleTowerChallengeTitleKillProgress()
		{
			return this.TitleType<IRoleTowerChallengeTitleKillProgress>().Value;
		}

		// Token: 0x06019306 RID: 103174 RVA: 0x00397F40 File Offset: 0x00396140
		public IRoleTowerChallengeTitlePhantomExp TitleTypeAsIRoleTowerChallengeTitlePhantomExp()
		{
			return this.TitleType<IRoleTowerChallengeTitlePhantomExp>().Value;
		}

		// Token: 0x06019307 RID: 103175 RVA: 0x00397F5B File Offset: 0x0039615B
		public static Offset<IQuestScheduleRoleTowerChallengeTitle> CreateIQuestScheduleRoleTowerChallengeTitle(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, TRoleTowerChallengeTitleType TitleType_type = TRoleTowerChallengeTitleType.NONE, int TitleTypeOffset = 0)
		{
			builder.StartTable(3);
			IQuestScheduleRoleTowerChallengeTitle.AddTitleType(builder, TitleTypeOffset);
			IQuestScheduleRoleTowerChallengeTitle.AddTitleTypeType(builder, TitleType_type);
			IQuestScheduleRoleTowerChallengeTitle.AddType(builder, Type);
			return IQuestScheduleRoleTowerChallengeTitle.EndIQuestScheduleRoleTowerChallengeTitle(builder);
		}

		// Token: 0x06019308 RID: 103176 RVA: 0x00397F7F File Offset: 0x0039617F
		public static void StartIQuestScheduleRoleTowerChallengeTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06019309 RID: 103177 RVA: 0x00397F88 File Offset: 0x00396188
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601930A RID: 103178 RVA: 0x00397F93 File Offset: 0x00396193
		public static void AddTitleTypeType(FlatBufferBuilder builder, TRoleTowerChallengeTitleType titleTypeType)
		{
			builder.AddByte(1, (byte)titleTypeType, 0);
		}

		// Token: 0x0601930B RID: 103179 RVA: 0x00397F9E File Offset: 0x0039619E
		public static void AddTitleType(FlatBufferBuilder builder, int titleTypeOffset)
		{
			builder.AddOffset(2, titleTypeOffset, 0);
		}

		// Token: 0x0601930C RID: 103180 RVA: 0x00397FA9 File Offset: 0x003961A9
		public static Offset<IQuestScheduleRoleTowerChallengeTitle> EndIQuestScheduleRoleTowerChallengeTitle(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleRoleTowerChallengeTitle>(builder.EndTable());
		}

		// Token: 0x0601930D RID: 103181 RVA: 0x00397FB8 File Offset: 0x003961B8
		public IQuestScheduleRoleTowerChallengeTitleT UnPack()
		{
			IQuestScheduleRoleTowerChallengeTitleT questScheduleRoleTowerChallengeTitleT = new IQuestScheduleRoleTowerChallengeTitleT();
			this.UnPackTo(questScheduleRoleTowerChallengeTitleT);
			return questScheduleRoleTowerChallengeTitleT;
		}

		// Token: 0x0601930E RID: 103182 RVA: 0x00397FD4 File Offset: 0x003961D4
		public void UnPackTo(IQuestScheduleRoleTowerChallengeTitleT _o)
		{
			_o.Type = this.Type;
			_o.TitleType = new TRoleTowerChallengeTitleTypeUnion();
			_o.TitleType.Type = this.TitleTypeType;
			switch (this.TitleTypeType)
			{
			case TRoleTowerChallengeTitleType.IRoleTowerChallengeTitleCurrentFloor:
				_o.TitleType.Value = ((this.TitleType<IRoleTowerChallengeTitleCurrentFloor>() != null) ? this.TitleType<IRoleTowerChallengeTitleCurrentFloor>().Value.UnPack() : null);
				return;
			case TRoleTowerChallengeTitleType.IRoleTowerChallengeTitleKillProgress:
				_o.TitleType.Value = ((this.TitleType<IRoleTowerChallengeTitleKillProgress>() != null) ? this.TitleType<IRoleTowerChallengeTitleKillProgress>().Value.UnPack() : null);
				return;
			case TRoleTowerChallengeTitleType.IRoleTowerChallengeTitlePhantomExp:
				_o.TitleType.Value = ((this.TitleType<IRoleTowerChallengeTitlePhantomExp>() != null) ? this.TitleType<IRoleTowerChallengeTitlePhantomExp>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601930F RID: 103183 RVA: 0x003980C8 File Offset: 0x003962C8
		public static Offset<IQuestScheduleRoleTowerChallengeTitle> Pack(FlatBufferBuilder builder, IQuestScheduleRoleTowerChallengeTitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleRoleTowerChallengeTitle>);
			}
			TRoleTowerChallengeTitleType titleType_type = (_o.TitleType == null) ? TRoleTowerChallengeTitleType.NONE : _o.TitleType.Type;
			int titleTypeOffset = (_o.TitleType == null) ? 0 : TRoleTowerChallengeTitleTypeUnion.Pack(builder, _o.TitleType);
			return IQuestScheduleRoleTowerChallengeTitle.CreateIQuestScheduleRoleTowerChallengeTitle(builder, _o.Type, titleType_type, titleTypeOffset);
		}

		// Token: 0x0400C549 RID: 50505
		private Table __p;
	}
}
