using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004034 RID: 16436
	public struct IQuestScheduleRoleTowerChallengeTitle : IFlatbufferObject
	{
		// Token: 0x170073A2 RID: 29602
		// (get) Token: 0x06017C62 RID: 97378 RVA: 0x0036DFEA File Offset: 0x0036C1EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017C63 RID: 97379 RVA: 0x0036DFF7 File Offset: 0x0036C1F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017C64 RID: 97380 RVA: 0x0036E000 File Offset: 0x0036C200
		public static IQuestScheduleRoleTowerChallengeTitle GetRootAsIQuestScheduleRoleTowerChallengeTitle(ByteBuffer _bb)
		{
			return IQuestScheduleRoleTowerChallengeTitle.GetRootAsIQuestScheduleRoleTowerChallengeTitle(_bb, default(IQuestScheduleRoleTowerChallengeTitle));
		}

		// Token: 0x06017C65 RID: 97381 RVA: 0x0036E01C File Offset: 0x0036C21C
		public static IQuestScheduleRoleTowerChallengeTitle GetRootAsIQuestScheduleRoleTowerChallengeTitle(ByteBuffer _bb, IQuestScheduleRoleTowerChallengeTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017C66 RID: 97382 RVA: 0x0036E039 File Offset: 0x0036C239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017C67 RID: 97383 RVA: 0x0036E048 File Offset: 0x0036C248
		public IQuestScheduleRoleTowerChallengeTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073A3 RID: 29603
		// (get) Token: 0x06017C68 RID: 97384 RVA: 0x0036E058 File Offset: 0x0036C258
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

		// Token: 0x170073A4 RID: 29604
		// (get) Token: 0x06017C69 RID: 97385 RVA: 0x0036E094 File Offset: 0x0036C294
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

		// Token: 0x06017C6A RID: 97386 RVA: 0x0036E0D0 File Offset: 0x0036C2D0
		public TTable? TitleType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017C6B RID: 97387 RVA: 0x0036E114 File Offset: 0x0036C314
		public IRoleTowerChallengeTitleCurrentFloor TitleTypeAsIRoleTowerChallengeTitleCurrentFloor()
		{
			return this.TitleType<IRoleTowerChallengeTitleCurrentFloor>().Value;
		}

		// Token: 0x06017C6C RID: 97388 RVA: 0x0036E130 File Offset: 0x0036C330
		public IRoleTowerChallengeTitleKillProgress TitleTypeAsIRoleTowerChallengeTitleKillProgress()
		{
			return this.TitleType<IRoleTowerChallengeTitleKillProgress>().Value;
		}

		// Token: 0x06017C6D RID: 97389 RVA: 0x0036E14C File Offset: 0x0036C34C
		public IRoleTowerChallengeTitlePhantomExp TitleTypeAsIRoleTowerChallengeTitlePhantomExp()
		{
			return this.TitleType<IRoleTowerChallengeTitlePhantomExp>().Value;
		}

		// Token: 0x06017C6E RID: 97390 RVA: 0x0036E167 File Offset: 0x0036C367
		public static Offset<IQuestScheduleRoleTowerChallengeTitle> CreateIQuestScheduleRoleTowerChallengeTitle(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None, TRoleTowerChallengeTitleType TitleType_type = TRoleTowerChallengeTitleType.NONE, int TitleTypeOffset = 0)
		{
			builder.StartTable(3);
			IQuestScheduleRoleTowerChallengeTitle.AddTitleType(builder, TitleTypeOffset);
			IQuestScheduleRoleTowerChallengeTitle.AddTitleTypeType(builder, TitleType_type);
			IQuestScheduleRoleTowerChallengeTitle.AddType(builder, Type);
			return IQuestScheduleRoleTowerChallengeTitle.EndIQuestScheduleRoleTowerChallengeTitle(builder);
		}

		// Token: 0x06017C6F RID: 97391 RVA: 0x0036E18B File Offset: 0x0036C38B
		public static void StartIQuestScheduleRoleTowerChallengeTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017C70 RID: 97392 RVA: 0x0036E194 File Offset: 0x0036C394
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017C71 RID: 97393 RVA: 0x0036E19F File Offset: 0x0036C39F
		public static void AddTitleTypeType(FlatBufferBuilder builder, TRoleTowerChallengeTitleType titleTypeType)
		{
			builder.AddByte(1, (byte)titleTypeType, 0);
		}

		// Token: 0x06017C72 RID: 97394 RVA: 0x0036E1AA File Offset: 0x0036C3AA
		public static void AddTitleType(FlatBufferBuilder builder, int titleTypeOffset)
		{
			builder.AddOffset(2, titleTypeOffset, 0);
		}

		// Token: 0x06017C73 RID: 97395 RVA: 0x0036E1B5 File Offset: 0x0036C3B5
		public static Offset<IQuestScheduleRoleTowerChallengeTitle> EndIQuestScheduleRoleTowerChallengeTitle(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleRoleTowerChallengeTitle>(builder.EndTable());
		}

		// Token: 0x06017C74 RID: 97396 RVA: 0x0036E1C4 File Offset: 0x0036C3C4
		public IQuestScheduleRoleTowerChallengeTitleT UnPack()
		{
			IQuestScheduleRoleTowerChallengeTitleT questScheduleRoleTowerChallengeTitleT = new IQuestScheduleRoleTowerChallengeTitleT();
			this.UnPackTo(questScheduleRoleTowerChallengeTitleT);
			return questScheduleRoleTowerChallengeTitleT;
		}

		// Token: 0x06017C75 RID: 97397 RVA: 0x0036E1E0 File Offset: 0x0036C3E0
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

		// Token: 0x06017C76 RID: 97398 RVA: 0x0036E2D4 File Offset: 0x0036C4D4
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

		// Token: 0x0400BB62 RID: 47970
		private Table __p;
	}
}
