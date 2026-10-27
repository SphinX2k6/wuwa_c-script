using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF4 RID: 3572
	public struct MapRange : IFlatbufferObject
	{
		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x060091CA RID: 37322 RVA: 0x00280304 File Offset: 0x0027E504
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x00280311 File Offset: 0x0027E511
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x00280318 File Offset: 0x0027E518
		public static MapRange GetRootAsMapRange(ByteBuffer _bb)
		{
			return MapRange.GetRootAsMapRange(_bb, default(MapRange));
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x00280334 File Offset: 0x0027E534
		public static MapRange GetRootAsMapRange(ByteBuffer _bb, MapRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x00280351 File Offset: 0x0027E551
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091CF RID: 37327 RVA: 0x00280360 File Offset: 0x0027E560
		public MapRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x060091D0 RID: 37328 RVA: 0x00280370 File Offset: 0x0027E570
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

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x060091D1 RID: 37329 RVA: 0x002803AC File Offset: 0x0027E5AC
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x060091D2 RID: 37330 RVA: 0x002803E8 File Offset: 0x0027E5E8
		public string MapName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x0028041F File Offset: 0x0027E61F
		public Span<byte> GetMapNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x0028042E File Offset: 0x0027E62E
		public byte[] GetMapNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x00280448 File Offset: 0x0027E648
		public int AreaRange(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x060091D6 RID: 37334 RVA: 0x00280488 File Offset: 0x0027E688
		public int AreaRangeLength
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

		// Token: 0x060091D7 RID: 37335 RVA: 0x002804B4 File Offset: 0x0027E6B4
		public Span<int> GetAreaRangeBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x002804C4 File Offset: 0x0027E6C4
		public int[] GetAreaRangeArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x002804DC File Offset: 0x0027E6DC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaRangeIter()或GetAreaRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AreaRange()
		{
			MapRange mapRange = this;
			return mapRange.GetAreaRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x00280500 File Offset: 0x0027E700
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaRangeIter()
		{
			MapRange.<AreaRangeIter>d__22 <AreaRangeIter>d__ = new MapRange.<AreaRangeIter>d__22(-2);
			<AreaRangeIter>d__.<>3__<>4__this = this;
			return <AreaRangeIter>d__;
		}

		// Token: 0x04004E92 RID: 20114
		private Table __p;
	}
}
