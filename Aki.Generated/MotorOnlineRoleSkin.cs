using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F44 RID: 3908
	public struct MotorOnlineRoleSkin : IFlatbufferObject
	{
		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x0600A135 RID: 41269 RVA: 0x002B2B25 File Offset: 0x002B0D25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A136 RID: 41270 RVA: 0x002B2B32 File Offset: 0x002B0D32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A137 RID: 41271 RVA: 0x002B2B3C File Offset: 0x002B0D3C
		public static MotorOnlineRoleSkin GetRootAsMotorOnlineRoleSkin(ByteBuffer _bb)
		{
			return MotorOnlineRoleSkin.GetRootAsMotorOnlineRoleSkin(_bb, default(MotorOnlineRoleSkin));
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x002B2B58 File Offset: 0x002B0D58
		public static MotorOnlineRoleSkin GetRootAsMotorOnlineRoleSkin(ByteBuffer _bb, MotorOnlineRoleSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x002B2B75 File Offset: 0x002B0D75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x002B2B84 File Offset: 0x002B0D84
		public MotorOnlineRoleSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x0600A13B RID: 41275 RVA: 0x002B2B94 File Offset: 0x002B0D94
		public int RoleSkinId
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

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x0600A13C RID: 41276 RVA: 0x002B2BD0 File Offset: 0x002B0DD0
		public string RoleStand
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

		// Token: 0x0600A13D RID: 41277 RVA: 0x002B2C07 File Offset: 0x002B0E07
		public Span<byte> GetRoleStandBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x002B2C16 File Offset: 0x002B0E16
		public byte[] GetRoleStandArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040054F0 RID: 21744
		private Table __p;
	}
}
