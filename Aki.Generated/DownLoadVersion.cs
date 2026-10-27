using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFB RID: 3067
	public struct DownLoadVersion : IFlatbufferObject
	{
		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x0600631D RID: 25373 RVA: 0x002153C0 File Offset: 0x002135C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x002153CD File Offset: 0x002135CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x002153D4 File Offset: 0x002135D4
		public static DownLoadVersion GetRootAsDownLoadVersion(ByteBuffer _bb)
		{
			return DownLoadVersion.GetRootAsDownLoadVersion(_bb, default(DownLoadVersion));
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x002153F0 File Offset: 0x002135F0
		public static DownLoadVersion GetRootAsDownLoadVersion(ByteBuffer _bb, DownLoadVersion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x0021540D File Offset: 0x0021360D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x0021541C File Offset: 0x0021361C
		public DownLoadVersion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06006323 RID: 25379 RVA: 0x0021542C File Offset: 0x0021362C
		public int Version
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

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06006324 RID: 25380 RVA: 0x00215468 File Offset: 0x00213668
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

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06006325 RID: 25381 RVA: 0x002154A4 File Offset: 0x002136A4
		public string Title
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

		// Token: 0x06006326 RID: 25382 RVA: 0x002154DB File Offset: 0x002136DB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x002154EA File Offset: 0x002136EA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06006328 RID: 25384 RVA: 0x00215504 File Offset: 0x00213704
		public int SortId
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

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06006329 RID: 25385 RVA: 0x00215544 File Offset: 0x00213744
		public string HelpTitle
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

		// Token: 0x0600632A RID: 25386 RVA: 0x0021557C File Offset: 0x0021377C
		public Span<byte> GetHelpTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x0021558C File Offset: 0x0021378C
		public byte[] GetHelpTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x0600632C RID: 25388 RVA: 0x002155A4 File Offset: 0x002137A4
		public string HelpDesc
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

		// Token: 0x0600632D RID: 25389 RVA: 0x002155DC File Offset: 0x002137DC
		public Span<byte> GetHelpDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x002155EC File Offset: 0x002137EC
		public byte[] GetHelpDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x0600632F RID: 25391 RVA: 0x00215604 File Offset: 0x00213804
		public string Pic
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

		// Token: 0x06006330 RID: 25392 RVA: 0x0021563C File Offset: 0x0021383C
		public Span<byte> GetPicBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x0021564C File Offset: 0x0021384C
		public byte[] GetPicArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06006332 RID: 25394 RVA: 0x00215664 File Offset: 0x00213864
		public bool IsRecommend
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004C28 RID: 19496
		private Table __p;
	}
}
