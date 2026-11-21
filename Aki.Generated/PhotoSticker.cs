using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFD RID: 4093
	public struct PhotoSticker : IFlatbufferObject
	{
		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0600B358 RID: 45912 RVA: 0x002DA8A0 File Offset: 0x002D8AA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B359 RID: 45913 RVA: 0x002DA8AD File Offset: 0x002D8AAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B35A RID: 45914 RVA: 0x002DA8B4 File Offset: 0x002D8AB4
		public static PhotoSticker GetRootAsPhotoSticker(ByteBuffer _bb)
		{
			return PhotoSticker.GetRootAsPhotoSticker(_bb, default(PhotoSticker));
		}

		// Token: 0x0600B35B RID: 45915 RVA: 0x002DA8D0 File Offset: 0x002D8AD0
		public static PhotoSticker GetRootAsPhotoSticker(ByteBuffer _bb, PhotoSticker obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B35C RID: 45916 RVA: 0x002DA8ED File Offset: 0x002D8AED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x002DA8FC File Offset: 0x002D8AFC
		public PhotoSticker __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x0600B35E RID: 45918 RVA: 0x002DA90C File Offset: 0x002D8B0C
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

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x0600B35F RID: 45919 RVA: 0x002DA948 File Offset: 0x002D8B48
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

		// Token: 0x0600B360 RID: 45920 RVA: 0x002DA97F File Offset: 0x002D8B7F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B361 RID: 45921 RVA: 0x002DA98E File Offset: 0x002D8B8E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x0600B362 RID: 45922 RVA: 0x002DA9A8 File Offset: 0x002D8BA8
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

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x0600B363 RID: 45923 RVA: 0x002DA9E4 File Offset: 0x002D8BE4
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170028F8 RID: 10488
		// (get) Token: 0x0600B364 RID: 45924 RVA: 0x002DAA24 File Offset: 0x002D8C24
		public bool IsMultilingual
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x0600B365 RID: 45925 RVA: 0x002DAA64 File Offset: 0x002D8C64
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

		// Token: 0x0600B366 RID: 45926 RVA: 0x002DAA9C File Offset: 0x002D8C9C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B367 RID: 45927 RVA: 0x002DAAAC File Offset: 0x002D8CAC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600B368 RID: 45928 RVA: 0x002DAAC4 File Offset: 0x002D8CC4
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

		// Token: 0x0600B369 RID: 45929 RVA: 0x002DAAFC File Offset: 0x002D8CFC
		public Span<byte> GetLangIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x002DAB0C File Offset: 0x002D8D0C
		public byte[] GetLangIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600B36B RID: 45931 RVA: 0x002DAB24 File Offset: 0x002D8D24
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

		// Token: 0x0600B36C RID: 45932 RVA: 0x002DAB5C File Offset: 0x002D8D5C
		public Span<byte> GetPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x002DAB6C File Offset: 0x002D8D6C
		public byte[] GetPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x0600B36E RID: 45934 RVA: 0x002DAB84 File Offset: 0x002D8D84
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

		// Token: 0x0600B36F RID: 45935 RVA: 0x002DABBC File Offset: 0x002D8DBC
		public Span<byte> GetLangPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B370 RID: 45936 RVA: 0x002DABCC File Offset: 0x002D8DCC
		public byte[] GetLangPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x0600B371 RID: 45937 RVA: 0x002DABE4 File Offset: 0x002D8DE4
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

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x0600B372 RID: 45938 RVA: 0x002DAC28 File Offset: 0x002D8E28
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

		// Token: 0x040055C6 RID: 21958
		private Table __p;
	}
}
