using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200489F RID: 18591
	public struct IBehindScoreGeCondition : IFlatbufferObject
	{
		// Token: 0x1700814A RID: 33098
		// (get) Token: 0x0601B771 RID: 112497 RVA: 0x003E2FCC File Offset: 0x003E11CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B772 RID: 112498 RVA: 0x003E2FD9 File Offset: 0x003E11D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B773 RID: 112499 RVA: 0x003E2FE0 File Offset: 0x003E11E0
		public static IBehindScoreGeCondition GetRootAsIBehindScoreGeCondition(ByteBuffer _bb)
		{
			return IBehindScoreGeCondition.GetRootAsIBehindScoreGeCondition(_bb, default(IBehindScoreGeCondition));
		}

		// Token: 0x0601B774 RID: 112500 RVA: 0x003E2FFC File Offset: 0x003E11FC
		public static IBehindScoreGeCondition GetRootAsIBehindScoreGeCondition(ByteBuffer _bb, IBehindScoreGeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B775 RID: 112501 RVA: 0x003E3019 File Offset: 0x003E1219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B776 RID: 112502 RVA: 0x003E3028 File Offset: 0x003E1228
		public IBehindScoreGeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700814B RID: 33099
		// (get) Token: 0x0601B777 RID: 112503 RVA: 0x003E3038 File Offset: 0x003E1238
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

		// Token: 0x1700814C RID: 33100
		// (get) Token: 0x0601B778 RID: 112504 RVA: 0x003E3074 File Offset: 0x003E1274
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

		// Token: 0x0601B779 RID: 112505 RVA: 0x003E30B0 File Offset: 0x003E12B0
		public static Offset<IBehindScoreGeCondition> CreateIBehindScoreGeCondition(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe, int Score = 0)
		{
			builder.StartTable(2);
			IBehindScoreGeCondition.AddScore(builder, Score);
			IBehindScoreGeCondition.AddType(builder, Type);
			return IBehindScoreGeCondition.EndIBehindScoreGeCondition(builder);
		}

		// Token: 0x0601B77A RID: 112506 RVA: 0x003E30CD File Offset: 0x003E12CD
		public static void StartIBehindScoreGeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B77B RID: 112507 RVA: 0x003E30D6 File Offset: 0x003E12D6
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B77C RID: 112508 RVA: 0x003E30E1 File Offset: 0x003E12E1
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601B77D RID: 112509 RVA: 0x003E30EC File Offset: 0x003E12EC
		public static Offset<IBehindScoreGeCondition> EndIBehindScoreGeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBehindScoreGeCondition>(builder.EndTable());
		}

		// Token: 0x0601B77E RID: 112510 RVA: 0x003E30FC File Offset: 0x003E12FC
		public IBehindScoreGeConditionT UnPack()
		{
			IBehindScoreGeConditionT behindScoreGeConditionT = new IBehindScoreGeConditionT();
			this.UnPackTo(behindScoreGeConditionT);
			return behindScoreGeConditionT;
		}

		// Token: 0x0601B77F RID: 112511 RVA: 0x003E3117 File Offset: 0x003E1317
		public void UnPackTo(IBehindScoreGeConditionT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
		}

		// Token: 0x0601B780 RID: 112512 RVA: 0x003E3134 File Offset: 0x003E1334
		public static Offset<IBehindScoreGeCondition> Pack(FlatBufferBuilder builder, IBehindScoreGeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehindScoreGeCondition>);
			}
			return IBehindScoreGeCondition.CreateIBehindScoreGeCondition(builder, _o.Type, _o.Score);
		}

		// Token: 0x0400CE33 RID: 52787
		private Table __p;
	}
}
