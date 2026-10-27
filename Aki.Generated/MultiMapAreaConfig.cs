using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E75 RID: 3701
	public struct MultiMapAreaConfig : IFlatbufferObject
	{
		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x06009D7D RID: 40317 RVA: 0x0029A46B File Offset: 0x0029866B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x0029A478 File Offset: 0x00298678
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x0029A480 File Offset: 0x00298680
		public static MultiMapAreaConfig GetRootAsMultiMapAreaConfig(ByteBuffer _bb)
		{
			return MultiMapAreaConfig.GetRootAsMultiMapAreaConfig(_bb, default(MultiMapAreaConfig));
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x0029A49C File Offset: 0x0029869C
		public static MultiMapAreaConfig GetRootAsMultiMapAreaConfig(ByteBuffer _bb, MultiMapAreaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x0029A4B9 File Offset: 0x002986B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x0029A4C8 File Offset: 0x002986C8
		public MultiMapAreaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x06009D83 RID: 40323 RVA: 0x0029A4D8 File Offset: 0x002986D8
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D84 RID: 40324 RVA: 0x0029A50F File Offset: 0x0029870F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06009D85 RID: 40325 RVA: 0x0029A51E File Offset: 0x0029871E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x0029A538 File Offset: 0x00298738
		public string Block
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D87 RID: 40327 RVA: 0x0029A56F File Offset: 0x0029876F
		public Span<byte> GetBlockBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009D88 RID: 40328 RVA: 0x0029A57E File Offset: 0x0029877E
		public byte[] GetBlockArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x0029A598 File Offset: 0x00298798
		public int MultiMapList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x06009D8A RID: 40330 RVA: 0x0029A5D8 File Offset: 0x002987D8
		public int MultiMapListLength
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

		// Token: 0x06009D8B RID: 40331 RVA: 0x0029A603 File Offset: 0x00298803
		public Span<int> GetMultiMapListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x0029A612 File Offset: 0x00298812
		public int[] GetMultiMapListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x0029A62C File Offset: 0x0029882C
		public IntArray? MultiMapRangeList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x06009D8E RID: 40334 RVA: 0x0029A690 File Offset: 0x00298890
		public int MultiMapRangeListLength
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

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x06009D8F RID: 40335 RVA: 0x0029A6BC File Offset: 0x002988BC
		public int MapConfigId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06009D90 RID: 40336 RVA: 0x0029A6FC File Offset: 0x002988FC
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x0029A73C File Offset: 0x0029893C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MultiMapListIter()或GetMultiMapListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MultiMapList()
		{
			MultiMapAreaConfig multiMapAreaConfig = this;
			return multiMapAreaConfig.GetMultiMapListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x0029A760 File Offset: 0x00298960
		[NullableContext(1)]
		public readonly IEnumerable<int> MultiMapListIter()
		{
			MultiMapAreaConfig.<MultiMapListIter>d__29 <MultiMapListIter>d__ = new MultiMapAreaConfig.<MultiMapListIter>d__29(-2);
			<MultiMapListIter>d__.<>3__<>4__this = this;
			return <MultiMapListIter>d__;
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x0029A775 File Offset: 0x00298975
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MultiMapRangeListIter()或GetMultiMapRangeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] MultiMapRangeList()
		{
			return this.MultiMapRangeListIter().ToArray<IntArray>();
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x0029A782 File Offset: 0x00298982
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> MultiMapRangeListIter()
		{
			MultiMapAreaConfig.<MultiMapRangeListIter>d__31 <MultiMapRangeListIter>d__ = new MultiMapAreaConfig.<MultiMapRangeListIter>d__31(-2);
			<MultiMapRangeListIter>d__.<>3__<>4__this = this;
			return <MultiMapRangeListIter>d__;
		}

		// Token: 0x04004F23 RID: 20259
		private Table __p;
	}
}
