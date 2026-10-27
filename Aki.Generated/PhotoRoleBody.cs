using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F15 RID: 3861
	public struct PhotoRoleBody : IFlatbufferObject
	{
		// Token: 0x1700286C RID: 10348
		// (get) Token: 0x0600ACEF RID: 44271 RVA: 0x002BD11C File Offset: 0x002BB31C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x002BD129 File Offset: 0x002BB329
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x002BD130 File Offset: 0x002BB330
		public static PhotoRoleBody GetRootAsPhotoRoleBody(ByteBuffer _bb)
		{
			return PhotoRoleBody.GetRootAsPhotoRoleBody(_bb, default(PhotoRoleBody));
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x002BD14C File Offset: 0x002BB34C
		public static PhotoRoleBody GetRootAsPhotoRoleBody(ByteBuffer _bb, PhotoRoleBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x002BD169 File Offset: 0x002BB369
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x002BD178 File Offset: 0x002BB378
		public PhotoRoleBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700286D RID: 10349
		// (get) Token: 0x0600ACF5 RID: 44277 RVA: 0x002BD188 File Offset: 0x002BB388
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

		// Token: 0x1700286E RID: 10350
		// (get) Token: 0x0600ACF6 RID: 44278 RVA: 0x002BD1C4 File Offset: 0x002BB3C4
		public int RoleId
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

		// Token: 0x1700286F RID: 10351
		// (get) Token: 0x0600ACF7 RID: 44279 RVA: 0x002BD200 File Offset: 0x002BB400
		public int Morph
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

		// Token: 0x17002870 RID: 10352
		// (get) Token: 0x0600ACF8 RID: 44280 RVA: 0x002BD23C File Offset: 0x002BB43C
		public string RoleBody
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

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x002BD274 File Offset: 0x002BB474
		public Span<byte> GetRoleBodyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ACFA RID: 44282 RVA: 0x002BD284 File Offset: 0x002BB484
		public byte[] GetRoleBodyArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FDD RID: 20445
		private Table __p;
	}
}
