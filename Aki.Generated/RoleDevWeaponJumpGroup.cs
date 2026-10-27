using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200104A RID: 4170
	public struct RoleDevWeaponJumpGroup : IFlatbufferObject
	{
		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600C874 RID: 51316 RVA: 0x002FA229 File Offset: 0x002F8429
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C875 RID: 51317 RVA: 0x002FA236 File Offset: 0x002F8436
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x002FA240 File Offset: 0x002F8440
		public static RoleDevWeaponJumpGroup GetRootAsRoleDevWeaponJumpGroup(ByteBuffer _bb)
		{
			return RoleDevWeaponJumpGroup.GetRootAsRoleDevWeaponJumpGroup(_bb, default(RoleDevWeaponJumpGroup));
		}

		// Token: 0x0600C877 RID: 51319 RVA: 0x002FA25C File Offset: 0x002F845C
		public static RoleDevWeaponJumpGroup GetRootAsRoleDevWeaponJumpGroup(ByteBuffer _bb, RoleDevWeaponJumpGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C878 RID: 51320 RVA: 0x002FA279 File Offset: 0x002F8479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C879 RID: 51321 RVA: 0x002FA288 File Offset: 0x002F8488
		public RoleDevWeaponJumpGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600C87A RID: 51322 RVA: 0x002FA298 File Offset: 0x002F8498
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

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600C87B RID: 51323 RVA: 0x002FA2D4 File Offset: 0x002F84D4
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

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600C87C RID: 51324 RVA: 0x002FA310 File Offset: 0x002F8510
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

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600C87D RID: 51325 RVA: 0x002FA34C File Offset: 0x002F854C
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

		// Token: 0x0600C87E RID: 51326 RVA: 0x002FA384 File Offset: 0x002F8584
		public Span<byte> GetPathDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x002FA394 File Offset: 0x002F8594
		public byte[] GetPathDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005148 RID: 20808
		private Table __p;
	}
}
