using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001132 RID: 4402
	public struct RoleDevWeaponJumpGroup : IFlatbufferObject
	{
		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600CEBE RID: 52926 RVA: 0x00315EF5 File Offset: 0x003140F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CEBF RID: 52927 RVA: 0x00315F02 File Offset: 0x00314102
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CEC0 RID: 52928 RVA: 0x00315F0C File Offset: 0x0031410C
		public static RoleDevWeaponJumpGroup GetRootAsRoleDevWeaponJumpGroup(ByteBuffer _bb)
		{
			return RoleDevWeaponJumpGroup.GetRootAsRoleDevWeaponJumpGroup(_bb, default(RoleDevWeaponJumpGroup));
		}

		// Token: 0x0600CEC1 RID: 52929 RVA: 0x00315F28 File Offset: 0x00314128
		public static RoleDevWeaponJumpGroup GetRootAsRoleDevWeaponJumpGroup(ByteBuffer _bb, RoleDevWeaponJumpGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEC2 RID: 52930 RVA: 0x00315F45 File Offset: 0x00314145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEC3 RID: 52931 RVA: 0x00315F54 File Offset: 0x00314154
		public RoleDevWeaponJumpGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600CEC4 RID: 52932 RVA: 0x00315F64 File Offset: 0x00314164
		public int WeaponId
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

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600CEC5 RID: 52933 RVA: 0x00315FA0 File Offset: 0x003141A0
		public int JumpType
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

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600CEC6 RID: 52934 RVA: 0x00315FDC File Offset: 0x003141DC
		public int JumpPath
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

		// Token: 0x170032DC RID: 13020
		// (get) Token: 0x0600CEC7 RID: 52935 RVA: 0x00316018 File Offset: 0x00314218
		public string PathDescribe
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

		// Token: 0x0600CEC8 RID: 52936 RVA: 0x00316050 File Offset: 0x00314250
		public Span<byte> GetPathDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CEC9 RID: 52937 RVA: 0x00316060 File Offset: 0x00314260
		public byte[] GetPathDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005730 RID: 22320
		private Table __p;
	}
}
