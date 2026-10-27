using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2A RID: 3882
	public struct PinballDeathrattle : IFlatbufferObject
	{
		// Token: 0x17002938 RID: 10552
		// (get) Token: 0x0600AEB5 RID: 44725 RVA: 0x002C1381 File Offset: 0x002BF581
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AEB6 RID: 44726 RVA: 0x002C138E File Offset: 0x002BF58E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AEB7 RID: 44727 RVA: 0x002C1398 File Offset: 0x002BF598
		public static PinballDeathrattle GetRootAsPinballDeathrattle(ByteBuffer _bb)
		{
			return PinballDeathrattle.GetRootAsPinballDeathrattle(_bb, default(PinballDeathrattle));
		}

		// Token: 0x0600AEB8 RID: 44728 RVA: 0x002C13B4 File Offset: 0x002BF5B4
		public static PinballDeathrattle GetRootAsPinballDeathrattle(ByteBuffer _bb, PinballDeathrattle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AEB9 RID: 44729 RVA: 0x002C13D1 File Offset: 0x002BF5D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AEBA RID: 44730 RVA: 0x002C13E0 File Offset: 0x002BF5E0
		public PinballDeathrattle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002939 RID: 10553
		// (get) Token: 0x0600AEBB RID: 44731 RVA: 0x002C13F0 File Offset: 0x002BF5F0
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

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600AEBC RID: 44732 RVA: 0x002C142C File Offset: 0x002BF62C
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x002C1468 File Offset: 0x002BF668
		public int SpawnDrops(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x0600AEBE RID: 44734 RVA: 0x002C14A8 File Offset: 0x002BF6A8
		public int SpawnDropsLength
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

		// Token: 0x0600AEBF RID: 44735 RVA: 0x002C14D3 File Offset: 0x002BF6D3
		public Span<int> GetSpawnDropsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x002C14E2 File Offset: 0x002BF6E2
		public int[] GetSpawnDropsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x002C14FC File Offset: 0x002BF6FC
		public int SpawnDropWeights(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x0600AEC2 RID: 44738 RVA: 0x002C153C File Offset: 0x002BF73C
		public int SpawnDropWeightsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x002C1568 File Offset: 0x002BF768
		public Span<int> GetSpawnDropWeightsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x002C1578 File Offset: 0x002BF778
		public int[] GetSpawnDropWeightsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x002C1590 File Offset: 0x002BF790
		public int BuffIdList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600AEC6 RID: 44742 RVA: 0x002C15D0 File Offset: 0x002BF7D0
		public int BuffIdListLength
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

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x002C15FC File Offset: 0x002BF7FC
		public Span<int> GetBuffIdListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x002C160C File Offset: 0x002BF80C
		public int[] GetBuffIdListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x002C1624 File Offset: 0x002BF824
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdListIter()或GetBuffIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffIdList()
		{
			PinballDeathrattle pinballDeathrattle = this;
			return pinballDeathrattle.GetBuffIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AECA RID: 44746 RVA: 0x002C1648 File Offset: 0x002BF848
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffIdListIter()
		{
			PinballDeathrattle.<BuffIdListIter>d__28 <BuffIdListIter>d__ = new PinballDeathrattle.<BuffIdListIter>d__28(-2);
			<BuffIdListIter>d__.<>3__<>4__this = this;
			return <BuffIdListIter>d__;
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x002C1660 File Offset: 0x002BF860
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnDropWeightsIter()或GetSpawnDropWeightsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnDropWeights()
		{
			PinballDeathrattle pinballDeathrattle = this;
			return pinballDeathrattle.GetSpawnDropWeightsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x002C1684 File Offset: 0x002BF884
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnDropWeightsIter()
		{
			PinballDeathrattle.<SpawnDropWeightsIter>d__30 <SpawnDropWeightsIter>d__ = new PinballDeathrattle.<SpawnDropWeightsIter>d__30(-2);
			<SpawnDropWeightsIter>d__.<>3__<>4__this = this;
			return <SpawnDropWeightsIter>d__;
		}

		// Token: 0x0600AECD RID: 44749 RVA: 0x002C169C File Offset: 0x002BF89C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpawnDropsIter()或GetSpawnDropsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SpawnDrops()
		{
			PinballDeathrattle pinballDeathrattle = this;
			return pinballDeathrattle.GetSpawnDropsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AECE RID: 44750 RVA: 0x002C16C0 File Offset: 0x002BF8C0
		[NullableContext(1)]
		public readonly IEnumerable<int> SpawnDropsIter()
		{
			PinballDeathrattle.<SpawnDropsIter>d__32 <SpawnDropsIter>d__ = new PinballDeathrattle.<SpawnDropsIter>d__32(-2);
			<SpawnDropsIter>d__.<>3__<>4__this = this;
			return <SpawnDropsIter>d__;
		}

		// Token: 0x04004FF3 RID: 20467
		private Table __p;
	}
}
