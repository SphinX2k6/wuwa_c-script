using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5F RID: 3679
	public struct MotorOnlineRoleSkin : IFlatbufferObject
	{
		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x06009B15 RID: 39701 RVA: 0x00295179 File Offset: 0x00293379
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x00295186 File Offset: 0x00293386
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x00295190 File Offset: 0x00293390
		public static MotorOnlineRoleSkin GetRootAsMotorOnlineRoleSkin(ByteBuffer _bb)
		{
			return MotorOnlineRoleSkin.GetRootAsMotorOnlineRoleSkin(_bb, default(MotorOnlineRoleSkin));
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x002951AC File Offset: 0x002933AC
		public static MotorOnlineRoleSkin GetRootAsMotorOnlineRoleSkin(ByteBuffer _bb, MotorOnlineRoleSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x002951C9 File Offset: 0x002933C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x002951D8 File Offset: 0x002933D8
		public MotorOnlineRoleSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x06009B1B RID: 39707 RVA: 0x002951E8 File Offset: 0x002933E8
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

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x06009B1C RID: 39708 RVA: 0x00295224 File Offset: 0x00293424
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

		// Token: 0x06009B1D RID: 39709 RVA: 0x0029525B File Offset: 0x0029345B
		public Span<byte> GetRoleStandBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B1E RID: 39710 RVA: 0x0029526A File Offset: 0x0029346A
		public byte[] GetRoleStandArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F0B RID: 20235
		private Table __p;
	}
}
