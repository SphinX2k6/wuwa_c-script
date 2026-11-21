using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001290 RID: 4752
	public struct TrapDefenseBdDraw : IFlatbufferObject
	{
		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x0600F02A RID: 61482 RVA: 0x00361CDB File Offset: 0x0035FEDB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F02B RID: 61483 RVA: 0x00361CE8 File Offset: 0x0035FEE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F02C RID: 61484 RVA: 0x00361CF0 File Offset: 0x0035FEF0
		public static TrapDefenseBdDraw GetRootAsTrapDefenseBdDraw(ByteBuffer _bb)
		{
			return TrapDefenseBdDraw.GetRootAsTrapDefenseBdDraw(_bb, default(TrapDefenseBdDraw));
		}

		// Token: 0x0600F02D RID: 61485 RVA: 0x00361D0C File Offset: 0x0035FF0C
		public static TrapDefenseBdDraw GetRootAsTrapDefenseBdDraw(ByteBuffer _bb, TrapDefenseBdDraw obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F02E RID: 61486 RVA: 0x00361D29 File Offset: 0x0035FF29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F02F RID: 61487 RVA: 0x00361D38 File Offset: 0x0035FF38
		public TrapDefenseBdDraw __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x0600F030 RID: 61488 RVA: 0x00361D48 File Offset: 0x0035FF48
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

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x0600F031 RID: 61489 RVA: 0x00361D84 File Offset: 0x0035FF84
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

		// Token: 0x0600F032 RID: 61490 RVA: 0x00361DC0 File Offset: 0x0035FFC0
		public IntArray? BdWeights(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x0600F033 RID: 61491 RVA: 0x00361E20 File Offset: 0x00360020
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

		// Token: 0x0600F034 RID: 61492 RVA: 0x00361E4C File Offset: 0x0036004C
		public int QualityWeight(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x0600F035 RID: 61493 RVA: 0x00361E8C File Offset: 0x0036008C
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

		// Token: 0x0600F036 RID: 61494 RVA: 0x00361EB8 File Offset: 0x003600B8
		public Span<int> GetQualityWeightBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600F037 RID: 61495 RVA: 0x00361EC8 File Offset: 0x003600C8
		public int[] GetQualityWeightArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600F038 RID: 61496 RVA: 0x00361EE0 File Offset: 0x003600E0
		public int MostBdBounusWeight(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x0600F039 RID: 61497 RVA: 0x00361F20 File Offset: 0x00360120
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

		// Token: 0x0600F03A RID: 61498 RVA: 0x00361F4C File Offset: 0x0036014C
		public Span<int> GetMostBdBounusWeightBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600F03B RID: 61499 RVA: 0x00361F5C File Offset: 0x0036015C
		public int[] GetMostBdBounusWeightArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600F03C RID: 61500 RVA: 0x00361F74 File Offset: 0x00360174
		[NullableContext(1)]
		public IntArray[] BdWeights()
		{
			return this.BdWeightsIter().ToArray<IntArray>();
		}

		// Token: 0x0600F03D RID: 61501 RVA: 0x00361F81 File Offset: 0x00360181
		[NullableContext(1)]
		public IEnumerable<IntArray> BdWeightsIter()
		{
			TrapDefenseBdDraw.<BdWeightsIter>d__26 <BdWeightsIter>d__ = new TrapDefenseBdDraw.<BdWeightsIter>d__26(-2);
			<BdWeightsIter>d__.<>3__<>4__this = this;
			return <BdWeightsIter>d__;
		}

		// Token: 0x0600F03E RID: 61502 RVA: 0x00361F96 File Offset: 0x00360196
		[NullableContext(1)]
		public int[] MostBdBounusWeight()
		{
			return this.GetMostBdBounusWeightArray();
		}

		// Token: 0x0600F03F RID: 61503 RVA: 0x00361F9E File Offset: 0x0036019E
		[NullableContext(1)]
		public IEnumerable<int> MostBdBounusWeightIter()
		{
			TrapDefenseBdDraw.<MostBdBounusWeightIter>d__28 <MostBdBounusWeightIter>d__ = new TrapDefenseBdDraw.<MostBdBounusWeightIter>d__28(-2);
			<MostBdBounusWeightIter>d__.<>3__<>4__this = this;
			return <MostBdBounusWeightIter>d__;
		}

		// Token: 0x0600F040 RID: 61504 RVA: 0x00361FB3 File Offset: 0x003601B3
		[NullableContext(1)]
		public int[] QualityWeight()
		{
			return this.GetQualityWeightArray();
		}

		// Token: 0x0600F041 RID: 61505 RVA: 0x00361FBB File Offset: 0x003601BB
		[NullableContext(1)]
		public IEnumerable<int> QualityWeightIter()
		{
			TrapDefenseBdDraw.<QualityWeightIter>d__30 <QualityWeightIter>d__ = new TrapDefenseBdDraw.<QualityWeightIter>d__30(-2);
			<QualityWeightIter>d__.<>3__<>4__this = this;
			return <QualityWeightIter>d__;
		}

		// Token: 0x040058E2 RID: 22754
		private Table __p;
	}
}
