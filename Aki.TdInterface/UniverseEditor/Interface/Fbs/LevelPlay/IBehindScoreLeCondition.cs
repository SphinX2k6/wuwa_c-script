using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200443A RID: 17466
	public struct IBehindScoreLeCondition : IFlatbufferObject
	{
		// Token: 0x17007B10 RID: 31504
		// (get) Token: 0x06019FB6 RID: 106422 RVA: 0x003B6FBE File Offset: 0x003B51BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019FB7 RID: 106423 RVA: 0x003B6FCB File Offset: 0x003B51CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019FB8 RID: 106424 RVA: 0x003B6FD4 File Offset: 0x003B51D4
		public static IBehindScoreLeCondition GetRootAsIBehindScoreLeCondition(ByteBuffer _bb)
		{
			return IBehindScoreLeCondition.GetRootAsIBehindScoreLeCondition(_bb, default(IBehindScoreLeCondition));
		}

		// Token: 0x06019FB9 RID: 106425 RVA: 0x003B6FF0 File Offset: 0x003B51F0
		public static IBehindScoreLeCondition GetRootAsIBehindScoreLeCondition(ByteBuffer _bb, IBehindScoreLeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019FBA RID: 106426 RVA: 0x003B700D File Offset: 0x003B520D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019FBB RID: 106427 RVA: 0x003B701C File Offset: 0x003B521C
		public IBehindScoreLeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007B11 RID: 31505
		// (get) Token: 0x06019FBC RID: 106428 RVA: 0x003B702C File Offset: 0x003B522C
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

		// Token: 0x17007B12 RID: 31506
		// (get) Token: 0x06019FBD RID: 106429 RVA: 0x003B7068 File Offset: 0x003B5268
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

		// Token: 0x06019FBE RID: 106430 RVA: 0x003B70A4 File Offset: 0x003B52A4
		public static Offset<IBehindScoreLeCondition> CreateIBehindScoreLeCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Score = 0)
		{
			builder.StartTable(2);
			IBehindScoreLeCondition.AddScore(builder, Score);
			IBehindScoreLeCondition.AddType(builder, Type);
			return IBehindScoreLeCondition.EndIBehindScoreLeCondition(builder);
		}

		// Token: 0x06019FBF RID: 106431 RVA: 0x003B70C1 File Offset: 0x003B52C1
		public static void StartIBehindScoreLeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06019FC0 RID: 106432 RVA: 0x003B70CA File Offset: 0x003B52CA
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019FC1 RID: 106433 RVA: 0x003B70D5 File Offset: 0x003B52D5
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x06019FC2 RID: 106434 RVA: 0x003B70E0 File Offset: 0x003B52E0
		public static Offset<IBehindScoreLeCondition> EndIBehindScoreLeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBehindScoreLeCondition>(builder.EndTable());
		}

		// Token: 0x06019FC3 RID: 106435 RVA: 0x003B70F0 File Offset: 0x003B52F0
		public IBehindScoreLeConditionT UnPack()
		{
			IBehindScoreLeConditionT behindScoreLeConditionT = new IBehindScoreLeConditionT();
			this.UnPackTo(behindScoreLeConditionT);
			return behindScoreLeConditionT;
		}

		// Token: 0x06019FC4 RID: 106436 RVA: 0x003B710B File Offset: 0x003B530B
		public void UnPackTo(IBehindScoreLeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
		}

		// Token: 0x06019FC5 RID: 106437 RVA: 0x003B7128 File Offset: 0x003B5328
		public static Offset<IBehindScoreLeCondition> Pack(FlatBufferBuilder builder, IBehindScoreLeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehindScoreLeCondition>);
			}
			return IBehindScoreLeCondition.CreateIBehindScoreLeCondition(builder, _o.Type, _o.Score);
		}

		// Token: 0x0400C408 RID: 50184
		private Table __p;
	}
}
