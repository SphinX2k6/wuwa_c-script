using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004542 RID: 17730
	public struct IRemainScoreLeCondition : IFlatbufferObject
	{
		// Token: 0x17007DBF RID: 32191
		// (get) Token: 0x0601AAB3 RID: 109235 RVA: 0x003CDF76 File Offset: 0x003CC176
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AAB4 RID: 109236 RVA: 0x003CDF83 File Offset: 0x003CC183
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AAB5 RID: 109237 RVA: 0x003CDF8C File Offset: 0x003CC18C
		public static IRemainScoreLeCondition GetRootAsIRemainScoreLeCondition(ByteBuffer _bb)
		{
			return IRemainScoreLeCondition.GetRootAsIRemainScoreLeCondition(_bb, default(IRemainScoreLeCondition));
		}

		// Token: 0x0601AAB6 RID: 109238 RVA: 0x003CDFA8 File Offset: 0x003CC1A8
		public static IRemainScoreLeCondition GetRootAsIRemainScoreLeCondition(ByteBuffer _bb, IRemainScoreLeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AAB7 RID: 109239 RVA: 0x003CDFC5 File Offset: 0x003CC1C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AAB8 RID: 109240 RVA: 0x003CDFD4 File Offset: 0x003CC1D4
		public IRemainScoreLeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DC0 RID: 32192
		// (get) Token: 0x0601AAB9 RID: 109241 RVA: 0x003CDFE4 File Offset: 0x003CC1E4
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

		// Token: 0x17007DC1 RID: 32193
		// (get) Token: 0x0601AABA RID: 109242 RVA: 0x003CE020 File Offset: 0x003CC220
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

		// Token: 0x0601AABB RID: 109243 RVA: 0x003CE05C File Offset: 0x003CC25C
		public static Offset<IRemainScoreLeCondition> CreateIRemainScoreLeCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Score = 0)
		{
			builder.StartTable(2);
			IRemainScoreLeCondition.AddScore(builder, Score);
			IRemainScoreLeCondition.AddType(builder, Type);
			return IRemainScoreLeCondition.EndIRemainScoreLeCondition(builder);
		}

		// Token: 0x0601AABC RID: 109244 RVA: 0x003CE079 File Offset: 0x003CC279
		public static void StartIRemainScoreLeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AABD RID: 109245 RVA: 0x003CE082 File Offset: 0x003CC282
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AABE RID: 109246 RVA: 0x003CE08D File Offset: 0x003CC28D
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601AABF RID: 109247 RVA: 0x003CE098 File Offset: 0x003CC298
		public static Offset<IRemainScoreLeCondition> EndIRemainScoreLeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IRemainScoreLeCondition>(builder.EndTable());
		}

		// Token: 0x0601AAC0 RID: 109248 RVA: 0x003CE0A8 File Offset: 0x003CC2A8
		public IRemainScoreLeConditionT UnPack()
		{
			IRemainScoreLeConditionT remainScoreLeConditionT = new IRemainScoreLeConditionT();
			this.UnPackTo(remainScoreLeConditionT);
			return remainScoreLeConditionT;
		}

		// Token: 0x0601AAC1 RID: 109249 RVA: 0x003CE0C3 File Offset: 0x003CC2C3
		public void UnPackTo(IRemainScoreLeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
		}

		// Token: 0x0601AAC2 RID: 109250 RVA: 0x003CE0E0 File Offset: 0x003CC2E0
		public static Offset<IRemainScoreLeCondition> Pack(FlatBufferBuilder builder, IRemainScoreLeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRemainScoreLeCondition>);
			}
			return IRemainScoreLeCondition.CreateIRemainScoreLeCondition(builder, _o.Type, _o.Score);
		}

		// Token: 0x0400C5C7 RID: 50631
		private Table __p;
	}
}
