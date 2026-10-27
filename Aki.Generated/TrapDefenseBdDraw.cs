using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115A RID: 4442
	public struct TrapDefenseBdDraw : IFlatbufferObject
	{
		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x0600E2BC RID: 58044 RVA: 0x00336B6D File Offset: 0x00334D6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E2BD RID: 58045 RVA: 0x00336B7A File Offset: 0x00334D7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E2BE RID: 58046 RVA: 0x00336B84 File Offset: 0x00334D84
		public static TrapDefenseBdDraw GetRootAsTrapDefenseBdDraw(ByteBuffer _bb)
		{
			return TrapDefenseBdDraw.GetRootAsTrapDefenseBdDraw(_bb, default(TrapDefenseBdDraw));
		}

		// Token: 0x0600E2BF RID: 58047 RVA: 0x00336BA0 File Offset: 0x00334DA0
		public static TrapDefenseBdDraw GetRootAsTrapDefenseBdDraw(ByteBuffer _bb, TrapDefenseBdDraw obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E2C0 RID: 58048 RVA: 0x00336BBD File Offset: 0x00334DBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E2C1 RID: 58049 RVA: 0x00336BCC File Offset: 0x00334DCC
		public TrapDefenseBdDraw __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0600E2C2 RID: 58050 RVA: 0x00336BDC File Offset: 0x00334DDC
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

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0600E2C3 RID: 58051 RVA: 0x00336C18 File Offset: 0x00334E18
		public int DrawMode
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

		// Token: 0x0600E2C4 RID: 58052 RVA: 0x00336C54 File Offset: 0x00334E54
		public IntArray? BdWeights(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0600E2C5 RID: 58053 RVA: 0x00336CB4 File Offset: 0x00334EB4
		public int BdWeightsLength
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

		// Token: 0x0600E2C6 RID: 58054 RVA: 0x00336CE0 File Offset: 0x00334EE0
		public int QualityWeight(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0600E2C7 RID: 58055 RVA: 0x00336D20 File Offset: 0x00334F20
		public int QualityWeightLength
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

		// Token: 0x0600E2C8 RID: 58056 RVA: 0x00336D4C File Offset: 0x00334F4C
		public Span<int> GetQualityWeightBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E2C9 RID: 58057 RVA: 0x00336D5C File Offset: 0x00334F5C
		public int[] GetQualityWeightArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600E2CA RID: 58058 RVA: 0x00336D74 File Offset: 0x00334F74
		public int MostBdBounusWeight(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0600E2CB RID: 58059 RVA: 0x00336DB4 File Offset: 0x00334FB4
		public int MostBdBounusWeightLength
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

		// Token: 0x0600E2CC RID: 58060 RVA: 0x00336DE0 File Offset: 0x00334FE0
		public Span<int> GetMostBdBounusWeightBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E2CD RID: 58061 RVA: 0x00336DF0 File Offset: 0x00334FF0
		public int[] GetMostBdBounusWeightArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600E2CE RID: 58062 RVA: 0x00336E08 File Offset: 0x00335008
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BdWeightsIter()或GetBdWeightsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] BdWeights()
		{
			return this.BdWeightsIter().ToArray<IntArray>();
		}

		// Token: 0x0600E2CF RID: 58063 RVA: 0x00336E15 File Offset: 0x00335015
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> BdWeightsIter()
		{
			TrapDefenseBdDraw.<BdWeightsIter>d__26 <BdWeightsIter>d__ = new TrapDefenseBdDraw.<BdWeightsIter>d__26(-2);
			<BdWeightsIter>d__.<>3__<>4__this = this;
			return <BdWeightsIter>d__;
		}

		// Token: 0x0600E2D0 RID: 58064 RVA: 0x00336E2C File Offset: 0x0033502C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MostBdBounusWeightIter()或GetMostBdBounusWeightBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MostBdBounusWeight()
		{
			TrapDefenseBdDraw trapDefenseBdDraw = this;
			return trapDefenseBdDraw.GetMostBdBounusWeightArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E2D1 RID: 58065 RVA: 0x00336E50 File Offset: 0x00335050
		[NullableContext(1)]
		public readonly IEnumerable<int> MostBdBounusWeightIter()
		{
			TrapDefenseBdDraw.<MostBdBounusWeightIter>d__28 <MostBdBounusWeightIter>d__ = new TrapDefenseBdDraw.<MostBdBounusWeightIter>d__28(-2);
			<MostBdBounusWeightIter>d__.<>3__<>4__this = this;
			return <MostBdBounusWeightIter>d__;
		}

		// Token: 0x0600E2D2 RID: 58066 RVA: 0x00336E68 File Offset: 0x00335068
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QualityWeightIter()或GetQualityWeightBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QualityWeight()
		{
			TrapDefenseBdDraw trapDefenseBdDraw = this;
			return trapDefenseBdDraw.GetQualityWeightArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E2D3 RID: 58067 RVA: 0x00336E8C File Offset: 0x0033508C
		[NullableContext(1)]
		public readonly IEnumerable<int> QualityWeightIter()
		{
			TrapDefenseBdDraw.<QualityWeightIter>d__30 <QualityWeightIter>d__ = new TrapDefenseBdDraw.<QualityWeightIter>d__30(-2);
			<QualityWeightIter>d__.<>3__<>4__this = this;
			return <QualityWeightIter>d__;
		}

		// Token: 0x0400529F RID: 21151
		private Table __p;
	}
}
