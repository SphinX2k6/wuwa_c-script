using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FFA RID: 4090
	public struct PhotoRoleBody : IFlatbufferObject
	{
		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x0600B310 RID: 45840 RVA: 0x002D9D34 File Offset: 0x002D7F34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x002D9D41 File Offset: 0x002D7F41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x002D9D48 File Offset: 0x002D7F48
		public static PhotoRoleBody GetRootAsPhotoRoleBody(ByteBuffer _bb)
		{
			return PhotoRoleBody.GetRootAsPhotoRoleBody(_bb, default(PhotoRoleBody));
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x002D9D64 File Offset: 0x002D7F64
		public static PhotoRoleBody GetRootAsPhotoRoleBody(ByteBuffer _bb, PhotoRoleBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x002D9D81 File Offset: 0x002D7F81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x002D9D90 File Offset: 0x002D7F90
		public PhotoRoleBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x0600B316 RID: 45846 RVA: 0x002D9DA0 File Offset: 0x002D7FA0
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

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x0600B317 RID: 45847 RVA: 0x002D9DDC File Offset: 0x002D7FDC
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

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600B318 RID: 45848 RVA: 0x002D9E18 File Offset: 0x002D8018
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

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x0600B319 RID: 45849 RVA: 0x002D9E54 File Offset: 0x002D8054
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

		// Token: 0x0600B31A RID: 45850 RVA: 0x002D9E8C File Offset: 0x002D808C
		public Span<byte> GetRoleBodyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x002D9E9C File Offset: 0x002D809C
		public byte[] GetRoleBodyArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040055C2 RID: 21954
		private Table __p;
	}
}
