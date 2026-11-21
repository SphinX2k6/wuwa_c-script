using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048A2 RID: 18594
	public struct IBehindScoreLeCondition : IFlatbufferObject
	{
		// Token: 0x1700814F RID: 33103
		// (get) Token: 0x0601B787 RID: 112519 RVA: 0x003E31CA File Offset: 0x003E13CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B788 RID: 112520 RVA: 0x003E31D7 File Offset: 0x003E13D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B789 RID: 112521 RVA: 0x003E31E0 File Offset: 0x003E13E0
		public static IBehindScoreLeCondition GetRootAsIBehindScoreLeCondition(ByteBuffer _bb)
		{
			return IBehindScoreLeCondition.GetRootAsIBehindScoreLeCondition(_bb, default(IBehindScoreLeCondition));
		}

		// Token: 0x0601B78A RID: 112522 RVA: 0x003E31FC File Offset: 0x003E13FC
		public static IBehindScoreLeCondition GetRootAsIBehindScoreLeCondition(ByteBuffer _bb, IBehindScoreLeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B78B RID: 112523 RVA: 0x003E3219 File Offset: 0x003E1419
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B78C RID: 112524 RVA: 0x003E3228 File Offset: 0x003E1428
		public IBehindScoreLeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008150 RID: 33104
		// (get) Token: 0x0601B78D RID: 112525 RVA: 0x003E3238 File Offset: 0x003E1438
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

		// Token: 0x17008151 RID: 33105
		// (get) Token: 0x0601B78E RID: 112526 RVA: 0x003E3274 File Offset: 0x003E1474
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

		// Token: 0x0601B78F RID: 112527 RVA: 0x003E32B0 File Offset: 0x003E14B0
		public static Offset<IBehindScoreLeCondition> CreateIBehindScoreLeCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Score = 0)
		{
			builder.StartTable(2);
			IBehindScoreLeCondition.AddScore(builder, Score);
			IBehindScoreLeCondition.AddType(builder, Type);
			return IBehindScoreLeCondition.EndIBehindScoreLeCondition(builder);
		}

		// Token: 0x0601B790 RID: 112528 RVA: 0x003E32CD File Offset: 0x003E14CD
		public static void StartIBehindScoreLeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B791 RID: 112529 RVA: 0x003E32D6 File Offset: 0x003E14D6
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B792 RID: 112530 RVA: 0x003E32E1 File Offset: 0x003E14E1
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601B793 RID: 112531 RVA: 0x003E32EC File Offset: 0x003E14EC
		public static Offset<IBehindScoreLeCondition> EndIBehindScoreLeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBehindScoreLeCondition>(builder.EndTable());
		}

		// Token: 0x0601B794 RID: 112532 RVA: 0x003E32FC File Offset: 0x003E14FC
		public IBehindScoreLeConditionT UnPack()
		{
			IBehindScoreLeConditionT behindScoreLeConditionT = new IBehindScoreLeConditionT();
			this.UnPackTo(behindScoreLeConditionT);
			return behindScoreLeConditionT;
		}

		// Token: 0x0601B795 RID: 112533 RVA: 0x003E3317 File Offset: 0x003E1517
		public void UnPackTo(IBehindScoreLeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
		}

		// Token: 0x0601B796 RID: 112534 RVA: 0x003E3334 File Offset: 0x003E1534
		public static Offset<IBehindScoreLeCondition> Pack(FlatBufferBuilder builder, IBehindScoreLeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehindScoreLeCondition>);
			}
			return IBehindScoreLeCondition.CreateIBehindScoreLeCondition(builder, _o.Type, _o.Score);
		}

		// Token: 0x0400CE36 RID: 52790
		private Table __p;
	}
}
