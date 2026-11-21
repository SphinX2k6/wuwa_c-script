using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005043 RID: 20547
	public struct ICheckTetrisEndlessScore : IFlatbufferObject
	{
		// Token: 0x17009307 RID: 37639
		// (get) Token: 0x060201B7 RID: 131511 RVA: 0x004742F8 File Offset: 0x004724F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060201B8 RID: 131512 RVA: 0x00474305 File Offset: 0x00472505
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060201B9 RID: 131513 RVA: 0x0047430C File Offset: 0x0047250C
		public static ICheckTetrisEndlessScore GetRootAsICheckTetrisEndlessScore(ByteBuffer _bb)
		{
			return ICheckTetrisEndlessScore.GetRootAsICheckTetrisEndlessScore(_bb, default(ICheckTetrisEndlessScore));
		}

		// Token: 0x060201BA RID: 131514 RVA: 0x00474328 File Offset: 0x00472528
		public static ICheckTetrisEndlessScore GetRootAsICheckTetrisEndlessScore(ByteBuffer _bb, ICheckTetrisEndlessScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060201BB RID: 131515 RVA: 0x00474345 File Offset: 0x00472545
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060201BC RID: 131516 RVA: 0x00474354 File Offset: 0x00472554
		public ICheckTetrisEndlessScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009308 RID: 37640
		// (get) Token: 0x060201BD RID: 131517 RVA: 0x00474364 File Offset: 0x00472564
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009309 RID: 37641
		// (get) Token: 0x060201BE RID: 131518 RVA: 0x004743A0 File Offset: 0x004725A0
		public int DungeonId
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

		// Token: 0x1700930A RID: 37642
		// (get) Token: 0x060201BF RID: 131519 RVA: 0x004743DC File Offset: 0x004725DC
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700930B RID: 37643
		// (get) Token: 0x060201C0 RID: 131520 RVA: 0x00474418 File Offset: 0x00472618
		public int TargetScore
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060201C1 RID: 131521 RVA: 0x00474455 File Offset: 0x00472655
		public static Offset<ICheckTetrisEndlessScore> CreateICheckTetrisEndlessScore(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, ECompare Compare = ECompare.Eq, int TargetScore = 0)
		{
			builder.StartTable(4);
			ICheckTetrisEndlessScore.AddTargetScore(builder, TargetScore);
			ICheckTetrisEndlessScore.AddDungeonId(builder, DungeonId);
			ICheckTetrisEndlessScore.AddCompare(builder, Compare);
			ICheckTetrisEndlessScore.AddType(builder, Type);
			return ICheckTetrisEndlessScore.EndICheckTetrisEndlessScore(builder);
		}

		// Token: 0x060201C2 RID: 131522 RVA: 0x00474481 File Offset: 0x00472681
		public static void StartICheckTetrisEndlessScore(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060201C3 RID: 131523 RVA: 0x0047448A File Offset: 0x0047268A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060201C4 RID: 131524 RVA: 0x00474495 File Offset: 0x00472695
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x060201C5 RID: 131525 RVA: 0x004744A0 File Offset: 0x004726A0
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x060201C6 RID: 131526 RVA: 0x004744AB File Offset: 0x004726AB
		public static void AddTargetScore(FlatBufferBuilder builder, int targetScore)
		{
			builder.AddInt(3, targetScore, 0);
		}

		// Token: 0x060201C7 RID: 131527 RVA: 0x004744B6 File Offset: 0x004726B6
		public static Offset<ICheckTetrisEndlessScore> EndICheckTetrisEndlessScore(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTetrisEndlessScore>(builder.EndTable());
		}

		// Token: 0x060201C8 RID: 131528 RVA: 0x004744C4 File Offset: 0x004726C4
		public ICheckTetrisEndlessScoreT UnPack()
		{
			ICheckTetrisEndlessScoreT checkTetrisEndlessScoreT = new ICheckTetrisEndlessScoreT();
			this.UnPackTo(checkTetrisEndlessScoreT);
			return checkTetrisEndlessScoreT;
		}

		// Token: 0x060201C9 RID: 131529 RVA: 0x004744DF File Offset: 0x004726DF
		public void UnPackTo(ICheckTetrisEndlessScoreT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.Compare = this.Compare;
			_o.TargetScore = this.TargetScore;
		}

		// Token: 0x060201CA RID: 131530 RVA: 0x00474514 File Offset: 0x00472714
		public static Offset<ICheckTetrisEndlessScore> Pack(FlatBufferBuilder builder, ICheckTetrisEndlessScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTetrisEndlessScore>);
			}
			return ICheckTetrisEndlessScore.CreateICheckTetrisEndlessScore(builder, _o.Type, _o.DungeonId, _o.Compare, _o.TargetScore);
		}

		// Token: 0x0400DF20 RID: 57120
		private Table __p;
	}
}
