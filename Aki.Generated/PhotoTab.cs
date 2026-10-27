using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1A RID: 3866
	public struct PhotoTab : IFlatbufferObject
	{
		// Token: 0x1700289D RID: 10397
		// (get) Token: 0x0600AD5D RID: 44381 RVA: 0x002BE1B5 File Offset: 0x002BC3B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD5E RID: 44382 RVA: 0x002BE1C2 File Offset: 0x002BC3C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD5F RID: 44383 RVA: 0x002BE1CC File Offset: 0x002BC3CC
		public static PhotoTab GetRootAsPhotoTab(ByteBuffer _bb)
		{
			return PhotoTab.GetRootAsPhotoTab(_bb, default(PhotoTab));
		}

		// Token: 0x0600AD60 RID: 44384 RVA: 0x002BE1E8 File Offset: 0x002BC3E8
		public static PhotoTab GetRootAsPhotoTab(ByteBuffer _bb, PhotoTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x002BE205 File Offset: 0x002BC405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x002BE214 File Offset: 0x002BC414
		public PhotoTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700289E RID: 10398
		// (get) Token: 0x0600AD63 RID: 44387 RVA: 0x002BE224 File Offset: 0x002BC424
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

		// Token: 0x1700289F RID: 10399
		// (get) Token: 0x0600AD64 RID: 44388 RVA: 0x002BE260 File Offset: 0x002BC460
		public int Type
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

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x0600AD65 RID: 44389 RVA: 0x002BE29C File Offset: 0x002BC49C
		public int SortId
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

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x0600AD66 RID: 44390 RVA: 0x002BE2D8 File Offset: 0x002BC4D8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x002BE310 File Offset: 0x002BC510
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x002BE320 File Offset: 0x002BC520
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AD69 RID: 44393 RVA: 0x002BE338 File Offset: 0x002BC538
		public int PhotoSubTabList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x0600AD6A RID: 44394 RVA: 0x002BE378 File Offset: 0x002BC578
		public int PhotoSubTabListLength
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

		// Token: 0x0600AD6B RID: 44395 RVA: 0x002BE3A4 File Offset: 0x002BC5A4
		public Span<int> GetPhotoSubTabListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x002BE3B4 File Offset: 0x002BC5B4
		public int[] GetPhotoSubTabListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x170028A3 RID: 10403
		// (get) Token: 0x0600AD6D RID: 44397 RVA: 0x002BE3CC File Offset: 0x002BC5CC
		public string DetalPanelResId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x002BE404 File Offset: 0x002BC604
		public Span<byte> GetDetalPanelResIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x002BE414 File Offset: 0x002BC614
		public byte[] GetDetalPanelResIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x002BE42C File Offset: 0x002BC62C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhotoSubTabListIter()或GetPhotoSubTabListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhotoSubTabList()
		{
			PhotoTab photoTab = this;
			return photoTab.GetPhotoSubTabListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AD71 RID: 44401 RVA: 0x002BE450 File Offset: 0x002BC650
		[NullableContext(1)]
		public readonly IEnumerable<int> PhotoSubTabListIter()
		{
			PhotoTab.<PhotoSubTabListIter>d__28 <PhotoSubTabListIter>d__ = new PhotoTab.<PhotoSubTabListIter>d__28(-2);
			<PhotoSubTabListIter>d__.<>3__<>4__this = this;
			return <PhotoSubTabListIter>d__;
		}

		// Token: 0x04004FE3 RID: 20451
		private Table __p;
	}
}
