using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004037 RID: 16439
	public struct IQuestScheduleScore : IFlatbufferObject
	{
		// Token: 0x170073A7 RID: 29607
		// (get) Token: 0x06017C7D RID: 97405 RVA: 0x0036E3C8 File Offset: 0x0036C5C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017C7E RID: 97406 RVA: 0x0036E3D5 File Offset: 0x0036C5D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017C7F RID: 97407 RVA: 0x0036E3DC File Offset: 0x0036C5DC
		public static IQuestScheduleScore GetRootAsIQuestScheduleScore(ByteBuffer _bb)
		{
			return IQuestScheduleScore.GetRootAsIQuestScheduleScore(_bb, default(IQuestScheduleScore));
		}

		// Token: 0x06017C80 RID: 97408 RVA: 0x0036E3F8 File Offset: 0x0036C5F8
		public static IQuestScheduleScore GetRootAsIQuestScheduleScore(ByteBuffer _bb, IQuestScheduleScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017C81 RID: 97409 RVA: 0x0036E415 File Offset: 0x0036C615
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017C82 RID: 97410 RVA: 0x0036E424 File Offset: 0x0036C624
		public IQuestScheduleScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073A8 RID: 29608
		// (get) Token: 0x06017C83 RID: 97411 RVA: 0x0036E434 File Offset: 0x0036C634
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

		// Token: 0x06017C84 RID: 97412 RVA: 0x0036E470 File Offset: 0x0036C670
		public static Offset<IQuestScheduleScore> CreateIQuestScheduleScore(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None)
		{
			builder.StartTable(1);
			IQuestScheduleScore.AddType(builder, Type);
			return IQuestScheduleScore.EndIQuestScheduleScore(builder);
		}

		// Token: 0x06017C85 RID: 97413 RVA: 0x0036E486 File Offset: 0x0036C686
		public static void StartIQuestScheduleScore(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06017C86 RID: 97414 RVA: 0x0036E48F File Offset: 0x0036C68F
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017C87 RID: 97415 RVA: 0x0036E49A File Offset: 0x0036C69A
		public static Offset<IQuestScheduleScore> EndIQuestScheduleScore(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleScore>(builder.EndTable());
		}

		// Token: 0x06017C88 RID: 97416 RVA: 0x0036E4A8 File Offset: 0x0036C6A8
		public IQuestScheduleScoreT UnPack()
		{
			IQuestScheduleScoreT questScheduleScoreT = new IQuestScheduleScoreT();
			this.UnPackTo(questScheduleScoreT);
			return questScheduleScoreT;
		}

		// Token: 0x06017C89 RID: 97417 RVA: 0x0036E4C3 File Offset: 0x0036C6C3
		public void UnPackTo(IQuestScheduleScoreT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06017C8A RID: 97418 RVA: 0x0036E4D4 File Offset: 0x0036C6D4
		public static Offset<IQuestScheduleScore> Pack(FlatBufferBuilder builder, IQuestScheduleScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleScore>);
			}
			return IQuestScheduleScore.CreateIQuestScheduleScore(builder, _o.Type);
		}

		// Token: 0x0400BB65 RID: 47973
		private Table __p;
	}
}
