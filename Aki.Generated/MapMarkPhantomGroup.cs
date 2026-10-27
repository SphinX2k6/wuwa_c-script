using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEF RID: 3567
	public struct MapMarkPhantomGroup : IFlatbufferObject
	{
		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06009159 RID: 37209 RVA: 0x0027F324 File Offset: 0x0027D524
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600915A RID: 37210 RVA: 0x0027F331 File Offset: 0x0027D531
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x0027F338 File Offset: 0x0027D538
		public static MapMarkPhantomGroup GetRootAsMapMarkPhantomGroup(ByteBuffer _bb)
		{
			return MapMarkPhantomGroup.GetRootAsMapMarkPhantomGroup(_bb, default(MapMarkPhantomGroup));
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x0027F354 File Offset: 0x0027D554
		public static MapMarkPhantomGroup GetRootAsMapMarkPhantomGroup(ByteBuffer _bb, MapMarkPhantomGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x0027F371 File Offset: 0x0027D571
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x0027F380 File Offset: 0x0027D580
		public MapMarkPhantomGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x0600915F RID: 37215 RVA: 0x0027F390 File Offset: 0x0027D590
		public int MarkId
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

		// Token: 0x06009160 RID: 37216 RVA: 0x0027F3CC File Offset: 0x0027D5CC
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06009161 RID: 37217 RVA: 0x0027F40C File Offset: 0x0027D60C
		public int ShowRangeLength
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

		// Token: 0x06009162 RID: 37218 RVA: 0x0027F437 File Offset: 0x0027D637
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009163 RID: 37219 RVA: 0x0027F446 File Offset: 0x0027D646
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009164 RID: 37220 RVA: 0x0027F460 File Offset: 0x0027D660
		public int ShowPhantom(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06009165 RID: 37221 RVA: 0x0027F4A0 File Offset: 0x0027D6A0
		public int ShowPhantomLength
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

		// Token: 0x06009166 RID: 37222 RVA: 0x0027F4CB File Offset: 0x0027D6CB
		public Span<int> GetShowPhantomBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009167 RID: 37223 RVA: 0x0027F4DA File Offset: 0x0027D6DA
		public int[] GetShowPhantomArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06009168 RID: 37224 RVA: 0x0027F4F4 File Offset: 0x0027D6F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowPhantomIter()或GetShowPhantomBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowPhantom()
		{
			MapMarkPhantomGroup mapMarkPhantomGroup = this;
			return mapMarkPhantomGroup.GetShowPhantomArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009169 RID: 37225 RVA: 0x0027F518 File Offset: 0x0027D718
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowPhantomIter()
		{
			MapMarkPhantomGroup.<ShowPhantomIter>d__21 <ShowPhantomIter>d__ = new MapMarkPhantomGroup.<ShowPhantomIter>d__21(-2);
			<ShowPhantomIter>d__.<>3__<>4__this = this;
			return <ShowPhantomIter>d__;
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x0027F530 File Offset: 0x0027D730
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			MapMarkPhantomGroup mapMarkPhantomGroup = this;
			return mapMarkPhantomGroup.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x0027F554 File Offset: 0x0027D754
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			MapMarkPhantomGroup.<ShowRangeIter>d__23 <ShowRangeIter>d__ = new MapMarkPhantomGroup.<ShowRangeIter>d__23(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x04004E8C RID: 20108
		private Table __p;
	}
}
