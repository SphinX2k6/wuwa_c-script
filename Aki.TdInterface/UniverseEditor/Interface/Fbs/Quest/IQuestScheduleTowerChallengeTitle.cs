using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004481 RID: 17537
	public struct IQuestScheduleTowerChallengeTitle : IFlatbufferObject
	{
		// Token: 0x170079CC RID: 31180
		// (get) Token: 0x0601939D RID: 103325 RVA: 0x0039978C File Offset: 0x0039798C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601939E RID: 103326 RVA: 0x00399799 File Offset: 0x00397999
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601939F RID: 103327 RVA: 0x003997A0 File Offset: 0x003979A0
		public static IQuestScheduleTowerChallengeTitle GetRootAsIQuestScheduleTowerChallengeTitle(ByteBuffer _bb)
		{
			return IQuestScheduleTowerChallengeTitle.GetRootAsIQuestScheduleTowerChallengeTitle(_bb, default(IQuestScheduleTowerChallengeTitle));
		}

		// Token: 0x060193A0 RID: 103328 RVA: 0x003997BC File Offset: 0x003979BC
		public static IQuestScheduleTowerChallengeTitle GetRootAsIQuestScheduleTowerChallengeTitle(ByteBuffer _bb, IQuestScheduleTowerChallengeTitle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060193A1 RID: 103329 RVA: 0x003997D9 File Offset: 0x003979D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060193A2 RID: 103330 RVA: 0x003997E8 File Offset: 0x003979E8
		public IQuestScheduleTowerChallengeTitle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079CD RID: 31181
		// (get) Token: 0x060193A3 RID: 103331 RVA: 0x003997F8 File Offset: 0x003979F8
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

		// Token: 0x060193A4 RID: 103332 RVA: 0x00399834 File Offset: 0x00397A34
		public static Offset<IQuestScheduleTowerChallengeTitle> CreateIQuestScheduleTowerChallengeTitle(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None)
		{
			builder.StartTable(1);
			IQuestScheduleTowerChallengeTitle.AddType(builder, Type);
			return IQuestScheduleTowerChallengeTitle.EndIQuestScheduleTowerChallengeTitle(builder);
		}

		// Token: 0x060193A5 RID: 103333 RVA: 0x0039984A File Offset: 0x00397A4A
		public static void StartIQuestScheduleTowerChallengeTitle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060193A6 RID: 103334 RVA: 0x00399853 File Offset: 0x00397A53
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060193A7 RID: 103335 RVA: 0x0039985E File Offset: 0x00397A5E
		public static Offset<IQuestScheduleTowerChallengeTitle> EndIQuestScheduleTowerChallengeTitle(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleTowerChallengeTitle>(builder.EndTable());
		}

		// Token: 0x060193A8 RID: 103336 RVA: 0x0039986C File Offset: 0x00397A6C
		public IQuestScheduleTowerChallengeTitleT UnPack()
		{
			IQuestScheduleTowerChallengeTitleT questScheduleTowerChallengeTitleT = new IQuestScheduleTowerChallengeTitleT();
			this.UnPackTo(questScheduleTowerChallengeTitleT);
			return questScheduleTowerChallengeTitleT;
		}

		// Token: 0x060193A9 RID: 103337 RVA: 0x00399887 File Offset: 0x00397A87
		public void UnPackTo(IQuestScheduleTowerChallengeTitleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060193AA RID: 103338 RVA: 0x00399898 File Offset: 0x00397A98
		public static Offset<IQuestScheduleTowerChallengeTitle> Pack(FlatBufferBuilder builder, IQuestScheduleTowerChallengeTitleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleTowerChallengeTitle>);
			}
			return IQuestScheduleTowerChallengeTitle.CreateIQuestScheduleTowerChallengeTitle(builder, _o.Type);
		}

		// Token: 0x0400C55F RID: 50527
		private Table __p;
	}
}
