using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFA RID: 3066
	public struct DownLoadTab : IFlatbufferObject
	{
		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06006301 RID: 25345 RVA: 0x00215075 File Offset: 0x00213275
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00215082 File Offset: 0x00213282
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x0021508C File Offset: 0x0021328C
		public static DownLoadTab GetRootAsDownLoadTab(ByteBuffer _bb)
		{
			return DownLoadTab.GetRootAsDownLoadTab(_bb, default(DownLoadTab));
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x002150A8 File Offset: 0x002132A8
		public static DownLoadTab GetRootAsDownLoadTab(ByteBuffer _bb, DownLoadTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x002150C5 File Offset: 0x002132C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x002150D4 File Offset: 0x002132D4
		public DownLoadTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06006307 RID: 25351 RVA: 0x002150E4 File Offset: 0x002132E4
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

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06006308 RID: 25352 RVA: 0x00215120 File Offset: 0x00213320
		public string Title
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

		// Token: 0x06006309 RID: 25353 RVA: 0x00215157 File Offset: 0x00213357
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x00215166 File Offset: 0x00213366
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x0600630B RID: 25355 RVA: 0x00215180 File Offset: 0x00213380
		public string ContentTitle
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

		// Token: 0x0600630C RID: 25356 RVA: 0x002151B7 File Offset: 0x002133B7
		public Span<byte> GetContentTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x002151C6 File Offset: 0x002133C6
		public byte[] GetContentTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x0600630E RID: 25358 RVA: 0x002151E0 File Offset: 0x002133E0
		public string Content
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

		// Token: 0x0600630F RID: 25359 RVA: 0x00215218 File Offset: 0x00213418
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x00215228 File Offset: 0x00213428
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06006311 RID: 25361 RVA: 0x00215240 File Offset: 0x00213440
		public string ContentTitleHD
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x00215278 File Offset: 0x00213478
		public Span<byte> GetContentTitleHDBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x00215288 File Offset: 0x00213488
		public byte[] GetContentTitleHDArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06006314 RID: 25364 RVA: 0x002152A0 File Offset: 0x002134A0
		public string ContentHD
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

		// Token: 0x06006315 RID: 25365 RVA: 0x002152D8 File Offset: 0x002134D8
		public Span<byte> GetContentHDBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x002152E8 File Offset: 0x002134E8
		public byte[] GetContentHDArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06006317 RID: 25367 RVA: 0x00215300 File Offset: 0x00213500
		public string ContentTitleSD
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x00215338 File Offset: 0x00213538
		public Span<byte> GetContentTitleSDBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x00215348 File Offset: 0x00213548
		public byte[] GetContentTitleSDArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x0600631A RID: 25370 RVA: 0x00215360 File Offset: 0x00213560
		public string ContentSD
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x00215398 File Offset: 0x00213598
		public Span<byte> GetContentSDBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x002153A8 File Offset: 0x002135A8
		public byte[] GetContentSDArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C27 RID: 19495
		private Table __p;
	}
}
