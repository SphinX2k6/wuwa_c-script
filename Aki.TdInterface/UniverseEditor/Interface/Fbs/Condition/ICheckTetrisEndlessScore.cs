using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B5C RID: 19292
	public struct ICheckTetrisEndlessScore : IFlatbufferObject
	{
		// Token: 0x17008BF7 RID: 35831
		// (get) Token: 0x0601E629 RID: 124457 RVA: 0x00441AAC File Offset: 0x0043FCAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E62A RID: 124458 RVA: 0x00441AB9 File Offset: 0x0043FCB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E62B RID: 124459 RVA: 0x00441AC0 File Offset: 0x0043FCC0
		public static ICheckTetrisEndlessScore GetRootAsICheckTetrisEndlessScore(ByteBuffer _bb)
		{
			return ICheckTetrisEndlessScore.GetRootAsICheckTetrisEndlessScore(_bb, default(ICheckTetrisEndlessScore));
		}

		// Token: 0x0601E62C RID: 124460 RVA: 0x00441ADC File Offset: 0x0043FCDC
		public static ICheckTetrisEndlessScore GetRootAsICheckTetrisEndlessScore(ByteBuffer _bb, ICheckTetrisEndlessScore obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E62D RID: 124461 RVA: 0x00441AF9 File Offset: 0x0043FCF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E62E RID: 124462 RVA: 0x00441B08 File Offset: 0x0043FD08
		public ICheckTetrisEndlessScore __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008BF8 RID: 35832
		// (get) Token: 0x0601E62F RID: 124463 RVA: 0x00441B18 File Offset: 0x0043FD18
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

		// Token: 0x17008BF9 RID: 35833
		// (get) Token: 0x0601E630 RID: 124464 RVA: 0x00441B54 File Offset: 0x0043FD54
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

		// Token: 0x17008BFA RID: 35834
		// (get) Token: 0x0601E631 RID: 124465 RVA: 0x00441B90 File Offset: 0x0043FD90
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

		// Token: 0x17008BFB RID: 35835
		// (get) Token: 0x0601E632 RID: 124466 RVA: 0x00441BCC File Offset: 0x0043FDCC
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

		// Token: 0x0601E633 RID: 124467 RVA: 0x00441C09 File Offset: 0x0043FE09
		public static Offset<ICheckTetrisEndlessScore> CreateICheckTetrisEndlessScore(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, ECompare Compare = ECompare.Eq, int TargetScore = 0)
		{
			builder.StartTable(4);
			ICheckTetrisEndlessScore.AddTargetScore(builder, TargetScore);
			ICheckTetrisEndlessScore.AddDungeonId(builder, DungeonId);
			ICheckTetrisEndlessScore.AddCompare(builder, Compare);
			ICheckTetrisEndlessScore.AddType(builder, Type);
			return ICheckTetrisEndlessScore.EndICheckTetrisEndlessScore(builder);
		}

		// Token: 0x0601E634 RID: 124468 RVA: 0x00441C35 File Offset: 0x0043FE35
		public static void StartICheckTetrisEndlessScore(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E635 RID: 124469 RVA: 0x00441C3E File Offset: 0x0043FE3E
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E636 RID: 124470 RVA: 0x00441C49 File Offset: 0x0043FE49
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601E637 RID: 124471 RVA: 0x00441C54 File Offset: 0x0043FE54
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E638 RID: 124472 RVA: 0x00441C5F File Offset: 0x0043FE5F
		public static void AddTargetScore(FlatBufferBuilder builder, int targetScore)
		{
			builder.AddInt(3, targetScore, 0);
		}

		// Token: 0x0601E639 RID: 124473 RVA: 0x00441C6A File Offset: 0x0043FE6A
		public static Offset<ICheckTetrisEndlessScore> EndICheckTetrisEndlessScore(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTetrisEndlessScore>(builder.EndTable());
		}

		// Token: 0x0601E63A RID: 124474 RVA: 0x00441C78 File Offset: 0x0043FE78
		public ICheckTetrisEndlessScoreT UnPack()
		{
			ICheckTetrisEndlessScoreT checkTetrisEndlessScoreT = new ICheckTetrisEndlessScoreT();
			this.UnPackTo(checkTetrisEndlessScoreT);
			return checkTetrisEndlessScoreT;
		}

		// Token: 0x0601E63B RID: 124475 RVA: 0x00441C93 File Offset: 0x0043FE93
		public void UnPackTo(ICheckTetrisEndlessScoreT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.Compare = this.Compare;
			_o.TargetScore = this.TargetScore;
		}

		// Token: 0x0601E63C RID: 124476 RVA: 0x00441CC8 File Offset: 0x0043FEC8
		public static Offset<ICheckTetrisEndlessScore> Pack(FlatBufferBuilder builder, ICheckTetrisEndlessScoreT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTetrisEndlessScore>);
			}
			return ICheckTetrisEndlessScore.CreateICheckTetrisEndlessScore(builder, _o.Type, _o.DungeonId, _o.Compare, _o.TargetScore);
		}

		// Token: 0x0400D420 RID: 54304
		private Table __p;
	}
}
