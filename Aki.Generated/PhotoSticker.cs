using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F18 RID: 3864
	public struct PhotoSticker : IFlatbufferObject
	{
		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x0600AD37 RID: 44343 RVA: 0x002BDCA8 File Offset: 0x002BBEA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD38 RID: 44344 RVA: 0x002BDCB5 File Offset: 0x002BBEB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD39 RID: 44345 RVA: 0x002BDCBC File Offset: 0x002BBEBC
		public static PhotoSticker GetRootAsPhotoSticker(ByteBuffer _bb)
		{
			return PhotoSticker.GetRootAsPhotoSticker(_bb, default(PhotoSticker));
		}

		// Token: 0x0600AD3A RID: 44346 RVA: 0x002BDCD8 File Offset: 0x002BBED8
		public static PhotoSticker GetRootAsPhotoSticker(ByteBuffer _bb, PhotoSticker obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD3B RID: 44347 RVA: 0x002BDCF5 File Offset: 0x002BBEF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD3C RID: 44348 RVA: 0x002BDD04 File Offset: 0x002BBF04
		public PhotoSticker __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x0600AD3D RID: 44349 RVA: 0x002BDD14 File Offset: 0x002BBF14
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

		// Token: 0x1700288F RID: 10383
		// (get) Token: 0x0600AD3E RID: 44350 RVA: 0x002BDD50 File Offset: 0x002BBF50
		public string Name
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

		// Token: 0x0600AD3F RID: 44351 RVA: 0x002BDD87 File Offset: 0x002BBF87
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x002BDD96 File Offset: 0x002BBF96
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002890 RID: 10384
		// (get) Token: 0x0600AD41 RID: 44353 RVA: 0x002BDDB0 File Offset: 0x002BBFB0
		public int RelativeItem
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

		// Token: 0x17002891 RID: 10385
		// (get) Token: 0x0600AD42 RID: 44354 RVA: 0x002BDDEC File Offset: 0x002BBFEC
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002892 RID: 10386
		// (get) Token: 0x0600AD43 RID: 44355 RVA: 0x002BDE2C File Offset: 0x002BC02C
		public bool IsMultilingual
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x0600AD44 RID: 44356 RVA: 0x002BDE6C File Offset: 0x002BC06C
		public string Icon
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

		// Token: 0x0600AD45 RID: 44357 RVA: 0x002BDEA4 File Offset: 0x002BC0A4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AD46 RID: 44358 RVA: 0x002BDEB4 File Offset: 0x002BC0B4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x0600AD47 RID: 44359 RVA: 0x002BDECC File Offset: 0x002BC0CC
		public string LangIcon
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

		// Token: 0x0600AD48 RID: 44360 RVA: 0x002BDF04 File Offset: 0x002BC104
		public Span<byte> GetLangIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AD49 RID: 44361 RVA: 0x002BDF14 File Offset: 0x002BC114
		public byte[] GetLangIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x0600AD4A RID: 44362 RVA: 0x002BDF2C File Offset: 0x002BC12C
		public string PicturePath
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

		// Token: 0x0600AD4B RID: 44363 RVA: 0x002BDF64 File Offset: 0x002BC164
		public Span<byte> GetPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600AD4C RID: 44364 RVA: 0x002BDF74 File Offset: 0x002BC174
		public byte[] GetPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x0600AD4D RID: 44365 RVA: 0x002BDF8C File Offset: 0x002BC18C
		public string LangPicturePath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AD4E RID: 44366 RVA: 0x002BDFC4 File Offset: 0x002BC1C4
		public Span<byte> GetLangPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AD4F RID: 44367 RVA: 0x002BDFD4 File Offset: 0x002BC1D4
		public byte[] GetLangPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x0600AD50 RID: 44368 RVA: 0x002BDFEC File Offset: 0x002BC1EC
		public float MinScale
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x0600AD51 RID: 44369 RVA: 0x002BE030 File Offset: 0x002BC230
		public float MaxScale
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FE1 RID: 20449
		private Table __p;
	}
}
