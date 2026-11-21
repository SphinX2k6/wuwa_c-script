using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D02 RID: 3330
	public struct EdgeRunnerUnlock : IFlatbufferObject
	{
		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06006D6B RID: 28011 RVA: 0x0023F1AC File Offset: 0x0023D3AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x0023F1B9 File Offset: 0x0023D3B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x0023F1C0 File Offset: 0x0023D3C0
		public static EdgeRunnerUnlock GetRootAsEdgeRunnerUnlock(ByteBuffer _bb)
		{
			return EdgeRunnerUnlock.GetRootAsEdgeRunnerUnlock(_bb, default(EdgeRunnerUnlock));
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x0023F1DC File Offset: 0x0023D3DC
		public static EdgeRunnerUnlock GetRootAsEdgeRunnerUnlock(ByteBuffer _bb, EdgeRunnerUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x0023F1F9 File Offset: 0x0023D3F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x0023F208 File Offset: 0x0023D408
		public EdgeRunnerUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x0023F218 File Offset: 0x0023D418
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06006D72 RID: 28018 RVA: 0x0023F254 File Offset: 0x0023D454
		public int ActivityId
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

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06006D73 RID: 28019 RVA: 0x0023F290 File Offset: 0x0023D490
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06006D74 RID: 28020 RVA: 0x0023F2CC File Offset: 0x0023D4CC
		public int PreConditionGroup
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

		// Token: 0x06006D75 RID: 28021 RVA: 0x0023F30C File Offset: 0x0023D50C
		public int RecommendTask(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06006D76 RID: 28022 RVA: 0x0023F34C File Offset: 0x0023D54C
		public int RecommendTaskLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x0023F378 File Offset: 0x0023D578
		public Span<int> GetRecommendTaskBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x0023F388 File Offset: 0x0023D588
		public int[] GetRecommendTaskArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x0023F3A0 File Offset: 0x0023D5A0
		[NullableContext(1)]
		public int[] RecommendTask()
		{
			return this.GetRecommendTaskArray();
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x0023F3A8 File Offset: 0x0023D5A8
		[NullableContext(1)]
		public IEnumerable<int> RecommendTaskIter()
		{
			EdgeRunnerUnlock.<RecommendTaskIter>d__22 <RecommendTaskIter>d__ = new EdgeRunnerUnlock.<RecommendTaskIter>d__22(-2);
			<RecommendTaskIter>d__.<>3__<>4__this = this;
			return <RecommendTaskIter>d__;
		}

		// Token: 0x04005242 RID: 21058
		private Table __p;
	}
}
