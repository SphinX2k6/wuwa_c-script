using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0C RID: 3340
	public struct GPUMonsterSpawn : IFlatbufferObject
	{
		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x06007BAF RID: 31663 RVA: 0x0024DCC9 File Offset: 0x0024BEC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x0024DCD6 File Offset: 0x0024BED6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x0024DCE0 File Offset: 0x0024BEE0
		public static GPUMonsterSpawn GetRootAsGPUMonsterSpawn(ByteBuffer _bb)
		{
			return GPUMonsterSpawn.GetRootAsGPUMonsterSpawn(_bb, default(GPUMonsterSpawn));
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x0024DCFC File Offset: 0x0024BEFC
		public static GPUMonsterSpawn GetRootAsGPUMonsterSpawn(ByteBuffer _bb, GPUMonsterSpawn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x0024DD19 File Offset: 0x0024BF19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x0024DD28 File Offset: 0x0024BF28
		public GPUMonsterSpawn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06007BB5 RID: 31669 RVA: 0x0024DD38 File Offset: 0x0024BF38
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

		// Token: 0x06007BB6 RID: 31670 RVA: 0x0024DD74 File Offset: 0x0024BF74
		public int MonsterIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06007BB7 RID: 31671 RVA: 0x0024DDB4 File Offset: 0x0024BFB4
		public int MonsterIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x0024DDDF File Offset: 0x0024BFDF
		public Span<int> GetMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007BB9 RID: 31673 RVA: 0x0024DDEE File Offset: 0x0024BFEE
		public int[] GetMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x0024DE08 File Offset: 0x0024C008
		public int SplineList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x06007BBB RID: 31675 RVA: 0x0024DE48 File Offset: 0x0024C048
		public int SplineListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x0024DE73 File Offset: 0x0024C073
		public Span<int> GetSplineListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x0024DE82 File Offset: 0x0024C082
		public int[] GetSplineListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x0024DE9C File Offset: 0x0024C09C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MonsterIdsIter()或GetMonsterIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MonsterIds()
		{
			GPUMonsterSpawn gpumonsterSpawn = this;
			return gpumonsterSpawn.GetMonsterIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x0024DEC0 File Offset: 0x0024C0C0
		[NullableContext(1)]
		public readonly IEnumerable<int> MonsterIdsIter()
		{
			GPUMonsterSpawn.<MonsterIdsIter>d__21 <MonsterIdsIter>d__ = new GPUMonsterSpawn.<MonsterIdsIter>d__21(-2);
			<MonsterIdsIter>d__.<>3__<>4__this = this;
			return <MonsterIdsIter>d__;
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x0024DED8 File Offset: 0x0024C0D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SplineListIter()或GetSplineListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SplineList()
		{
			GPUMonsterSpawn gpumonsterSpawn = this;
			return gpumonsterSpawn.GetSplineListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x0024DEFC File Offset: 0x0024C0FC
		[NullableContext(1)]
		public readonly IEnumerable<int> SplineListIter()
		{
			GPUMonsterSpawn.<SplineListIter>d__23 <SplineListIter>d__ = new GPUMonsterSpawn.<SplineListIter>d__23(-2);
			<SplineListIter>d__.<>3__<>4__this = this;
			return <SplineListIter>d__;
		}

		// Token: 0x04004D82 RID: 19842
		private Table __p;
	}
}
