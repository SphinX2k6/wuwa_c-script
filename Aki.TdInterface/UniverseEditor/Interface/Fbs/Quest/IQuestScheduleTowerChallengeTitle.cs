using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004040 RID: 16448
	public struct IQuestScheduleTowerChallengeTitle : IFlatbufferObject
	{
		// Token: 0x170073CA RID: 29642
		// (get) Token: 0x06017D04 RID: 97540 RVA: 0x0036F998 File Offset: 0x0036DB98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017D05 RID: 97541 RVA: 0x0036F9A5 File Offset: 0x0036DBA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017D06 RID: 97542 RVA: 0x0036F9AC File Offset: 0x0036DBAC
		public static IQuestScheduleTowerChallengeTitle GetRootAsIQuestScheduleTowerChallengeTitle(ByteBuffer _bb)
		{
			return IQuestScheduleTowerChallengeTitle.GetRootAsIQuestScheduleTowerChallengeTitle(_bb, default(IQuestScheduleTowerChallengeTitle));
		}

		// Token: 0x06017D07 RID: 97543 RVA: 0x0036F9C8 File Offset: 0x0036DBC8
		public static IQuestScheduleTowerChallengeTitle GetRootAsIQuestScheduleTowerChallengeTitle(ByteBuffer _bb, IQuestScheduleTowerChallengeTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017D08 RID: 97544 RVA: 0x0036F9E5 File Offset: 0x0036DBE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017D09 RID: 97545 RVA: 0x0036F9F4 File Offset: 0x0036DBF4
		public IQuestScheduleTowerChallengeTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073CB RID: 29643
		// (get) Token: 0x06017D0A RID: 97546 RVA: 0x0036FA04 File Offset: 0x0036DC04
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

		// Token: 0x06017D0B RID: 97547 RVA: 0x0036FA40 File Offset: 0x0036DC40
		public static Offset<IQuestScheduleTowerChallengeTitle> CreateIQuestScheduleTowerChallengeTitle(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None)
		{
			builder.StartTable(1);
			IQuestScheduleTowerChallengeTitle.AddType(builder, Type);
			return IQuestScheduleTowerChallengeTitle.EndIQuestScheduleTowerChallengeTitle(builder);
		}

		// Token: 0x06017D0C RID: 97548 RVA: 0x0036FA56 File Offset: 0x0036DC56
		public static void StartIQuestScheduleTowerChallengeTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017D0D RID: 97549 RVA: 0x0036FA5F File Offset: 0x0036DC5F
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017D0E RID: 97550 RVA: 0x0036FA6A File Offset: 0x0036DC6A
		public static Offset<IQuestScheduleTowerChallengeTitle> EndIQuestScheduleTowerChallengeTitle(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleTowerChallengeTitle>(builder.EndTable());
		}

		// Token: 0x06017D0F RID: 97551 RVA: 0x0036FA78 File Offset: 0x0036DC78
		public IQuestScheduleTowerChallengeTitleT UnPack()
		{
			IQuestScheduleTowerChallengeTitleT questScheduleTowerChallengeTitleT = new IQuestScheduleTowerChallengeTitleT();
			this.UnPackTo(questScheduleTowerChallengeTitleT);
			return questScheduleTowerChallengeTitleT;
		}

		// Token: 0x06017D10 RID: 97552 RVA: 0x0036FA93 File Offset: 0x0036DC93
		public void UnPackTo(IQuestScheduleTowerChallengeTitleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017D11 RID: 97553 RVA: 0x0036FAA4 File Offset: 0x0036DCA4
		public static Offset<IQuestScheduleTowerChallengeTitle> Pack(FlatBufferBuilder builder, IQuestScheduleTowerChallengeTitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleTowerChallengeTitle>);
			}
			return IQuestScheduleTowerChallengeTitle.CreateIQuestScheduleTowerChallengeTitle(builder, _o.Type);
		}

		// Token: 0x0400BB78 RID: 47992
		private Table __p;
	}
}
