using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8A RID: 2954
	public struct ComicDisplayConfig : IFlatbufferObject
	{
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06005733 RID: 22323 RVA: 0x001FA3C9 File Offset: 0x001F85C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x001FA3D6 File Offset: 0x001F85D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x001FA3E0 File Offset: 0x001F85E0
		public static ComicDisplayConfig GetRootAsComicDisplayConfig(ByteBuffer _bb)
		{
			return ComicDisplayConfig.GetRootAsComicDisplayConfig(_bb, default(ComicDisplayConfig));
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x001FA3FC File Offset: 0x001F85FC
		public static ComicDisplayConfig GetRootAsComicDisplayConfig(ByteBuffer _bb, ComicDisplayConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x001FA419 File Offset: 0x001F8619
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x001FA428 File Offset: 0x001F8628
		public ComicDisplayConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06005739 RID: 22329 RVA: 0x001FA438 File Offset: 0x001F8638
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

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600573A RID: 22330 RVA: 0x001FA474 File Offset: 0x001F8674
		public string ViewName
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

		// Token: 0x0600573B RID: 22331 RVA: 0x001FA4AB File Offset: 0x001F86AB
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x001FA4BA File Offset: 0x001F86BA
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x001FA4D4 File Offset: 0x001F86D4
		public string ResourceId
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

		// Token: 0x0600573E RID: 22334 RVA: 0x001FA50B File Offset: 0x001F870B
		public Span<byte> GetResourceIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x001FA51A File Offset: 0x001F871A
		public byte[] GetResourceIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x001FA534 File Offset: 0x001F8734
		public int PrefabList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06005741 RID: 22337 RVA: 0x001FA574 File Offset: 0x001F8774
		public int PrefabListLength
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

		// Token: 0x06005742 RID: 22338 RVA: 0x001FA5A0 File Offset: 0x001F87A0
		public Span<int> GetPrefabListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x001FA5B0 File Offset: 0x001F87B0
		public int[] GetPrefabListArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x001FA5C8 File Offset: 0x001F87C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PrefabListIter()或GetPrefabListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PrefabList()
		{
			ComicDisplayConfig comicDisplayConfig = this;
			return comicDisplayConfig.GetPrefabListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x001FA5EC File Offset: 0x001F87EC
		[NullableContext(1)]
		public readonly IEnumerable<int> PrefabListIter()
		{
			ComicDisplayConfig.<PrefabListIter>d__24 <PrefabListIter>d__ = new ComicDisplayConfig.<PrefabListIter>d__24(-2);
			<PrefabListIter>d__.<>3__<>4__this = this;
			return <PrefabListIter>d__;
		}

		// Token: 0x04004B99 RID: 19353
		private Table __p;
	}
}
