using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1D RID: 3869
	public struct PhotoWindDirection : IFlatbufferObject
	{
		// Token: 0x170028B0 RID: 10416
		// (get) Token: 0x0600AD92 RID: 44434 RVA: 0x002BE854 File Offset: 0x002BCA54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AD93 RID: 44435 RVA: 0x002BE861 File Offset: 0x002BCA61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AD94 RID: 44436 RVA: 0x002BE868 File Offset: 0x002BCA68
		public static PhotoWindDirection GetRootAsPhotoWindDirection(ByteBuffer _bb)
		{
			return PhotoWindDirection.GetRootAsPhotoWindDirection(_bb, default(PhotoWindDirection));
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x002BE884 File Offset: 0x002BCA84
		public static PhotoWindDirection GetRootAsPhotoWindDirection(ByteBuffer _bb, PhotoWindDirection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x002BE8A1 File Offset: 0x002BCAA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x002BE8B0 File Offset: 0x002BCAB0
		public PhotoWindDirection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028B1 RID: 10417
		// (get) Token: 0x0600AD98 RID: 44440 RVA: 0x002BE8C0 File Offset: 0x002BCAC0
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

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600AD99 RID: 44441 RVA: 0x002BE8FC File Offset: 0x002BCAFC
		public string Icon
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

		// Token: 0x0600AD9A RID: 44442 RVA: 0x002BE933 File Offset: 0x002BCB33
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AD9B RID: 44443 RVA: 0x002BE942 File Offset: 0x002BCB42
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600AD9C RID: 44444 RVA: 0x002BE95C File Offset: 0x002BCB5C
		public string Name
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

		// Token: 0x0600AD9D RID: 44445 RVA: 0x002BE993 File Offset: 0x002BCB93
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x002BE9A2 File Offset: 0x002BCBA2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x0600AD9F RID: 44447 RVA: 0x002BE9BC File Offset: 0x002BCBBC
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x0600ADA0 RID: 44448 RVA: 0x002BE9FC File Offset: 0x002BCBFC
		public int Direction
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x0600ADA1 RID: 44449 RVA: 0x002BEA3C File Offset: 0x002BCC3C
		public int DefaultStrength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 50;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FE6 RID: 20454
		private Table __p;
	}
}
