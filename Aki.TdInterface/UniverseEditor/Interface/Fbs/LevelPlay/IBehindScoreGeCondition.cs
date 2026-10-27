using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004437 RID: 17463
	public struct IBehindScoreGeCondition : IFlatbufferObject
	{
		// Token: 0x17007B0B RID: 31499
		// (get) Token: 0x06019FA0 RID: 106400 RVA: 0x003B6DC0 File Offset: 0x003B4FC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FA1 RID: 106401 RVA: 0x003B6DCD File Offset: 0x003B4FCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FA2 RID: 106402 RVA: 0x003B6DD4 File Offset: 0x003B4FD4
		public static IBehindScoreGeCondition GetRootAsIBehindScoreGeCondition(ByteBuffer _bb)
		{
			return IBehindScoreGeCondition.GetRootAsIBehindScoreGeCondition(_bb, default(IBehindScoreGeCondition));
		}

		// Token: 0x06019FA3 RID: 106403 RVA: 0x003B6DF0 File Offset: 0x003B4FF0
		public static IBehindScoreGeCondition GetRootAsIBehindScoreGeCondition(ByteBuffer _bb, IBehindScoreGeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019FA4 RID: 106404 RVA: 0x003B6E0D File Offset: 0x003B500D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019FA5 RID: 106405 RVA: 0x003B6E1C File Offset: 0x003B501C
		public IBehindScoreGeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B0C RID: 31500
		// (get) Token: 0x06019FA6 RID: 106406 RVA: 0x003B6E2C File Offset: 0x003B502C
		public EDartSkillConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillConditionType.RemainScoreGe;
				}
				return (EDartSkillConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007B0D RID: 31501
		// (get) Token: 0x06019FA7 RID: 106407 RVA: 0x003B6E68 File Offset: 0x003B5068
		public int Score
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019FA8 RID: 106408 RVA: 0x003B6EA4 File Offset: 0x003B50A4
		public static Offset<IBehindScoreGeCondition> CreateIBehindScoreGeCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Score = 0)
		{
			builder.StartTable(2);
			IBehindScoreGeCondition.AddScore(builder, Score);
			IBehindScoreGeCondition.AddType(builder, Type);
			return IBehindScoreGeCondition.EndIBehindScoreGeCondition(builder);
		}

		// Token: 0x06019FA9 RID: 106409 RVA: 0x003B6EC1 File Offset: 0x003B50C1
		public static void StartIBehindScoreGeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019FAA RID: 106410 RVA: 0x003B6ECA File Offset: 0x003B50CA
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019FAB RID: 106411 RVA: 0x003B6ED5 File Offset: 0x003B50D5
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x06019FAC RID: 106412 RVA: 0x003B6EE0 File Offset: 0x003B50E0
		public static Offset<IBehindScoreGeCondition> EndIBehindScoreGeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBehindScoreGeCondition>(builder.EndTable());
		}

		// Token: 0x06019FAD RID: 106413 RVA: 0x003B6EF0 File Offset: 0x003B50F0
		public IBehindScoreGeConditionT UnPack()
		{
			IBehindScoreGeConditionT behindScoreGeConditionT = new IBehindScoreGeConditionT();
			this.UnPackTo(behindScoreGeConditionT);
			return behindScoreGeConditionT;
		}

		// Token: 0x06019FAE RID: 106414 RVA: 0x003B6F0B File Offset: 0x003B510B
		public void UnPackTo(IBehindScoreGeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
		}

		// Token: 0x06019FAF RID: 106415 RVA: 0x003B6F28 File Offset: 0x003B5128
		public static Offset<IBehindScoreGeCondition> Pack(FlatBufferBuilder builder, IBehindScoreGeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehindScoreGeCondition>);
			}
			return IBehindScoreGeCondition.CreateIBehindScoreGeCondition(builder, _o.Type, _o.Score);
		}

		// Token: 0x0400C405 RID: 50181
		private Table __p;
	}
}
