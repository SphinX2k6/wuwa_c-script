using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200453F RID: 17727
	public struct IRemainScoreGeCondition : IFlatbufferObject
	{
		// Token: 0x17007DBA RID: 32186
		// (get) Token: 0x0601AA9D RID: 109213 RVA: 0x003CDD75 File Offset: 0x003CBF75
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA9E RID: 109214 RVA: 0x003CDD82 File Offset: 0x003CBF82
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA9F RID: 109215 RVA: 0x003CDD8C File Offset: 0x003CBF8C
		public static IRemainScoreGeCondition GetRootAsIRemainScoreGeCondition(ByteBuffer _bb)
		{
			return IRemainScoreGeCondition.GetRootAsIRemainScoreGeCondition(_bb, default(IRemainScoreGeCondition));
		}

		// Token: 0x0601AAA0 RID: 109216 RVA: 0x003CDDA8 File Offset: 0x003CBFA8
		public static IRemainScoreGeCondition GetRootAsIRemainScoreGeCondition(ByteBuffer _bb, IRemainScoreGeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AAA1 RID: 109217 RVA: 0x003CDDC5 File Offset: 0x003CBFC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AAA2 RID: 109218 RVA: 0x003CDDD4 File Offset: 0x003CBFD4
		public IRemainScoreGeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DBB RID: 32187
		// (get) Token: 0x0601AAA3 RID: 109219 RVA: 0x003CDDE4 File Offset: 0x003CBFE4
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

		// Token: 0x17007DBC RID: 32188
		// (get) Token: 0x0601AAA4 RID: 109220 RVA: 0x003CDE20 File Offset: 0x003CC020
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

		// Token: 0x0601AAA5 RID: 109221 RVA: 0x003CDE5C File Offset: 0x003CC05C
		public static Offset<IRemainScoreGeCondition> CreateIRemainScoreGeCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Score = 0)
		{
			builder.StartTable(2);
			IRemainScoreGeCondition.AddScore(builder, Score);
			IRemainScoreGeCondition.AddType(builder, Type);
			return IRemainScoreGeCondition.EndIRemainScoreGeCondition(builder);
		}

		// Token: 0x0601AAA6 RID: 109222 RVA: 0x003CDE79 File Offset: 0x003CC079
		public static void StartIRemainScoreGeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AAA7 RID: 109223 RVA: 0x003CDE82 File Offset: 0x003CC082
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AAA8 RID: 109224 RVA: 0x003CDE8D File Offset: 0x003CC08D
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601AAA9 RID: 109225 RVA: 0x003CDE98 File Offset: 0x003CC098
		public static Offset<IRemainScoreGeCondition> EndIRemainScoreGeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRemainScoreGeCondition>(builder.EndTable());
		}

		// Token: 0x0601AAAA RID: 109226 RVA: 0x003CDEA8 File Offset: 0x003CC0A8
		public IRemainScoreGeConditionT UnPack()
		{
			IRemainScoreGeConditionT remainScoreGeConditionT = new IRemainScoreGeConditionT();
			this.UnPackTo(remainScoreGeConditionT);
			return remainScoreGeConditionT;
		}

		// Token: 0x0601AAAB RID: 109227 RVA: 0x003CDEC3 File Offset: 0x003CC0C3
		public void UnPackTo(IRemainScoreGeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
		}

		// Token: 0x0601AAAC RID: 109228 RVA: 0x003CDEE0 File Offset: 0x003CC0E0
		public static Offset<IRemainScoreGeCondition> Pack(FlatBufferBuilder builder, IRemainScoreGeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemainScoreGeCondition>);
			}
			return IRemainScoreGeCondition.CreateIRemainScoreGeCondition(builder, _o.Type, _o.Score);
		}

		// Token: 0x0400C5C4 RID: 50628
		private Table __p;
	}
}
