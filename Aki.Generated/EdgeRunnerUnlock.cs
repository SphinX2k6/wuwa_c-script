using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1F RID: 3103
	public struct EdgeRunnerUnlock : IFlatbufferObject
	{
		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06006778 RID: 26488 RVA: 0x0021FDD0 File Offset: 0x0021DFD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006779 RID: 26489 RVA: 0x0021FDDD File Offset: 0x0021DFDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600677A RID: 26490 RVA: 0x0021FDE4 File Offset: 0x0021DFE4
		public static EdgeRunnerUnlock GetRootAsEdgeRunnerUnlock(ByteBuffer _bb)
		{
			return EdgeRunnerUnlock.GetRootAsEdgeRunnerUnlock(_bb, default(EdgeRunnerUnlock));
		}

		// Token: 0x0600677B RID: 26491 RVA: 0x0021FE00 File Offset: 0x0021E000
		public static EdgeRunnerUnlock GetRootAsEdgeRunnerUnlock(ByteBuffer _bb, EdgeRunnerUnlock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600677C RID: 26492 RVA: 0x0021FE1D File Offset: 0x0021E01D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600677D RID: 26493 RVA: 0x0021FE2C File Offset: 0x0021E02C
		public EdgeRunnerUnlock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x0600677E RID: 26494 RVA: 0x0021FE3C File Offset: 0x0021E03C
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

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x0600677F RID: 26495 RVA: 0x0021FE78 File Offset: 0x0021E078
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

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06006780 RID: 26496 RVA: 0x0021FEB4 File Offset: 0x0021E0B4
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

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06006781 RID: 26497 RVA: 0x0021FEF0 File Offset: 0x0021E0F0
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

		// Token: 0x06006782 RID: 26498 RVA: 0x0021FF30 File Offset: 0x0021E130
		public int RecommendTask(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06006783 RID: 26499 RVA: 0x0021FF70 File Offset: 0x0021E170
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

		// Token: 0x06006784 RID: 26500 RVA: 0x0021FF9C File Offset: 0x0021E19C
		public Span<int> GetRecommendTaskBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006785 RID: 26501 RVA: 0x0021FFAC File Offset: 0x0021E1AC
		public int[] GetRecommendTaskArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06006786 RID: 26502 RVA: 0x0021FFC4 File Offset: 0x0021E1C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendTaskIter()或GetRecommendTaskBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendTask()
		{
			EdgeRunnerUnlock edgeRunnerUnlock = this;
			return edgeRunnerUnlock.GetRecommendTaskArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006787 RID: 26503 RVA: 0x0021FFE8 File Offset: 0x0021E1E8
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendTaskIter()
		{
			EdgeRunnerUnlock.<RecommendTaskIter>d__22 <RecommendTaskIter>d__ = new EdgeRunnerUnlock.<RecommendTaskIter>d__22(-2);
			<RecommendTaskIter>d__.<>3__<>4__this = this;
			return <RecommendTaskIter>d__;
		}

		// Token: 0x04004C5F RID: 19551
		private Table __p;
	}
}
