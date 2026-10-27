using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E01 RID: 3585
	public struct MatchThreePiece : IFlatbufferObject
	{
		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x060092FE RID: 37630 RVA: 0x00282E39 File Offset: 0x00281039
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060092FF RID: 37631 RVA: 0x00282E46 File Offset: 0x00281046
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009300 RID: 37632 RVA: 0x00282E50 File Offset: 0x00281050
		public static MatchThreePiece GetRootAsMatchThreePiece(ByteBuffer _bb)
		{
			return MatchThreePiece.GetRootAsMatchThreePiece(_bb, default(MatchThreePiece));
		}

		// Token: 0x06009301 RID: 37633 RVA: 0x00282E6C File Offset: 0x0028106C
		public static MatchThreePiece GetRootAsMatchThreePiece(ByteBuffer _bb, MatchThreePiece obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x00282E89 File Offset: 0x00281089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x00282E98 File Offset: 0x00281098
		public MatchThreePiece __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06009304 RID: 37636 RVA: 0x00282EA8 File Offset: 0x002810A8
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

		// Token: 0x06009305 RID: 37637 RVA: 0x00282EE4 File Offset: 0x002810E4
		public int BornComponents(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06009306 RID: 37638 RVA: 0x00282F24 File Offset: 0x00281124
		public int BornComponentsLength
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

		// Token: 0x06009307 RID: 37639 RVA: 0x00282F4F File Offset: 0x0028114F
		public Span<int> GetBornComponentsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009308 RID: 37640 RVA: 0x00282F5E File Offset: 0x0028115E
		public int[] GetBornComponentsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009309 RID: 37641 RVA: 0x00282F78 File Offset: 0x00281178
		public int Eliminates(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x0600930A RID: 37642 RVA: 0x00282FB8 File Offset: 0x002811B8
		public int EliminatesLength
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

		// Token: 0x0600930B RID: 37643 RVA: 0x00282FE3 File Offset: 0x002811E3
		public Span<int> GetEliminatesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600930C RID: 37644 RVA: 0x00282FF2 File Offset: 0x002811F2
		public int[] GetEliminatesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600930D RID: 37645 RVA: 0x0028300C File Offset: 0x0028120C
		public int Energy
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

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x0600930E RID: 37646 RVA: 0x0028304C File Offset: 0x0028124C
		public int Score
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600930F RID: 37647 RVA: 0x0028308C File Offset: 0x0028128C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornComponentsIter()或GetBornComponentsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornComponents()
		{
			MatchThreePiece matchThreePiece = this;
			return matchThreePiece.GetBornComponentsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009310 RID: 37648 RVA: 0x002830B0 File Offset: 0x002812B0
		[NullableContext(1)]
		public readonly IEnumerable<int> BornComponentsIter()
		{
			MatchThreePiece.<BornComponentsIter>d__25 <BornComponentsIter>d__ = new MatchThreePiece.<BornComponentsIter>d__25(-2);
			<BornComponentsIter>d__.<>3__<>4__this = this;
			return <BornComponentsIter>d__;
		}

		// Token: 0x06009311 RID: 37649 RVA: 0x002830C8 File Offset: 0x002812C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EliminatesIter()或GetEliminatesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Eliminates()
		{
			MatchThreePiece matchThreePiece = this;
			return matchThreePiece.GetEliminatesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009312 RID: 37650 RVA: 0x002830EC File Offset: 0x002812EC
		[NullableContext(1)]
		public readonly IEnumerable<int> EliminatesIter()
		{
			MatchThreePiece.<EliminatesIter>d__27 <EliminatesIter>d__ = new MatchThreePiece.<EliminatesIter>d__27(-2);
			<EliminatesIter>d__.<>3__<>4__this = this;
			return <EliminatesIter>d__;
		}

		// Token: 0x04004EA2 RID: 20130
		private Table __p;
	}
}
