using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001000 RID: 4096
	public struct PhotoTemplate : IFlatbufferObject
	{
		// Token: 0x1700290A RID: 10506
		// (get) Token: 0x0600B393 RID: 45971 RVA: 0x002DB041 File Offset: 0x002D9241
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x002DB04E File Offset: 0x002D924E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x002DB058 File Offset: 0x002D9258
		public static PhotoTemplate GetRootAsPhotoTemplate(ByteBuffer _bb)
		{
			return PhotoTemplate.GetRootAsPhotoTemplate(_bb, default(PhotoTemplate));
		}

		// Token: 0x0600B396 RID: 45974 RVA: 0x002DB074 File Offset: 0x002D9274
		public static PhotoTemplate GetRootAsPhotoTemplate(ByteBuffer _bb, PhotoTemplate obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B397 RID: 45975 RVA: 0x002DB091 File Offset: 0x002D9291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B398 RID: 45976 RVA: 0x002DB0A0 File Offset: 0x002D92A0
		public PhotoTemplate __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700290B RID: 10507
		// (get) Token: 0x0600B399 RID: 45977 RVA: 0x002DB0B0 File Offset: 0x002D92B0
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

		// Token: 0x1700290C RID: 10508
		// (get) Token: 0x0600B39A RID: 45978 RVA: 0x002DB0EC File Offset: 0x002D92EC
		public int GroupId
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

		// Token: 0x1700290D RID: 10509
		// (get) Token: 0x0600B39B RID: 45979 RVA: 0x002DB128 File Offset: 0x002D9328
		public string DAPath
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

		// Token: 0x0600B39C RID: 45980 RVA: 0x002DB15F File Offset: 0x002D935F
		public Span<byte> GetDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B39D RID: 45981 RVA: 0x002DB16E File Offset: 0x002D936E
		public byte[] GetDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700290E RID: 10510
		// (get) Token: 0x0600B39E RID: 45982 RVA: 0x002DB188 File Offset: 0x002D9388
		public string TextureMale
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

		// Token: 0x0600B39F RID: 45983 RVA: 0x002DB1C0 File Offset: 0x002D93C0
		public Span<byte> GetTextureMaleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B3A0 RID: 45984 RVA: 0x002DB1D0 File Offset: 0x002D93D0
		public byte[] GetTextureMaleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700290F RID: 10511
		// (get) Token: 0x0600B3A1 RID: 45985 RVA: 0x002DB1E8 File Offset: 0x002D93E8
		public string TextureFemale
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

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x002DB220 File Offset: 0x002D9420
		public Span<byte> GetTextureFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B3A3 RID: 45987 RVA: 0x002DB230 File Offset: 0x002D9430
		public byte[] GetTextureFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x0600B3A4 RID: 45988 RVA: 0x002DB248 File Offset: 0x002D9448
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040055C9 RID: 21961
		private Table __p;
	}
}
