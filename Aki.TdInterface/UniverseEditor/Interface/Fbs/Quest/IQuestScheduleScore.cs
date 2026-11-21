using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004478 RID: 17528
	public struct IQuestScheduleScore : IFlatbufferObject
	{
		// Token: 0x170079A9 RID: 31145
		// (get) Token: 0x06019316 RID: 103190 RVA: 0x003981BC File Offset: 0x003963BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019317 RID: 103191 RVA: 0x003981C9 File Offset: 0x003963C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019318 RID: 103192 RVA: 0x003981D0 File Offset: 0x003963D0
		public static IQuestScheduleScore GetRootAsIQuestScheduleScore(ByteBuffer _bb)
		{
			return IQuestScheduleScore.GetRootAsIQuestScheduleScore(_bb, default(IQuestScheduleScore));
		}

		// Token: 0x06019319 RID: 103193 RVA: 0x003981EC File Offset: 0x003963EC
		public static IQuestScheduleScore GetRootAsIQuestScheduleScore(ByteBuffer _bb, IQuestScheduleScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601931A RID: 103194 RVA: 0x00398209 File Offset: 0x00396409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601931B RID: 103195 RVA: 0x00398218 File Offset: 0x00396418
		public IQuestScheduleScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170079AA RID: 31146
		// (get) Token: 0x0601931C RID: 103196 RVA: 0x00398228 File Offset: 0x00396428
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

		// Token: 0x0601931D RID: 103197 RVA: 0x00398264 File Offset: 0x00396464
		public static Offset<IQuestScheduleScore> CreateIQuestScheduleScore(FlatBufferBuilder builder, EQuestScheduleType Type = EQuestScheduleType.None)
		{
			builder.StartTable(1);
			IQuestScheduleScore.AddType(builder, Type);
			return IQuestScheduleScore.EndIQuestScheduleScore(builder);
		}

		// Token: 0x0601931E RID: 103198 RVA: 0x0039827A File Offset: 0x0039647A
		public static void StartIQuestScheduleScore(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601931F RID: 103199 RVA: 0x00398283 File Offset: 0x00396483
		public static void AddType(FlatBufferBuilder builder, EQuestScheduleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019320 RID: 103200 RVA: 0x0039828E File Offset: 0x0039648E
		public static Offset<IQuestScheduleScore> EndIQuestScheduleScore(FlatBufferBuilder builder)
		{
			return new Offset<IQuestScheduleScore>(builder.EndTable());
		}

		// Token: 0x06019321 RID: 103201 RVA: 0x0039829C File Offset: 0x0039649C
		public IQuestScheduleScoreT UnPack()
		{
			IQuestScheduleScoreT questScheduleScoreT = new IQuestScheduleScoreT();
			this.UnPackTo(questScheduleScoreT);
			return questScheduleScoreT;
		}

		// Token: 0x06019322 RID: 103202 RVA: 0x003982B7 File Offset: 0x003964B7
		public void UnPackTo(IQuestScheduleScoreT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06019323 RID: 103203 RVA: 0x003982C8 File Offset: 0x003964C8
		public static Offset<IQuestScheduleScore> Pack(FlatBufferBuilder builder, IQuestScheduleScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestScheduleScore>);
			}
			return IQuestScheduleScore.CreateIQuestScheduleScore(builder, _o.Type);
		}

		// Token: 0x0400C54C RID: 50508
		private Table __p;
	}
}
