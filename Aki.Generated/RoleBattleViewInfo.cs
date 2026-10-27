using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001039 RID: 4153
	public struct RoleBattleViewInfo : IFlatbufferObject
	{
		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600C741 RID: 51009 RVA: 0x002F78E1 File Offset: 0x002F5AE1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C742 RID: 51010 RVA: 0x002F78EE File Offset: 0x002F5AEE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C743 RID: 51011 RVA: 0x002F78F8 File Offset: 0x002F5AF8
		public static RoleBattleViewInfo GetRootAsRoleBattleViewInfo(ByteBuffer _bb)
		{
			return RoleBattleViewInfo.GetRootAsRoleBattleViewInfo(_bb, default(RoleBattleViewInfo));
		}

		// Token: 0x0600C744 RID: 51012 RVA: 0x002F7914 File Offset: 0x002F5B14
		public static RoleBattleViewInfo GetRootAsRoleBattleViewInfo(ByteBuffer _bb, RoleBattleViewInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C745 RID: 51013 RVA: 0x002F7931 File Offset: 0x002F5B31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C746 RID: 51014 RVA: 0x002F7940 File Offset: 0x002F5B40
		public RoleBattleViewInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600C747 RID: 51015 RVA: 0x002F7950 File Offset: 0x002F5B50
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

		// Token: 0x170031F6 RID: 12790
		// (get) Token: 0x0600C748 RID: 51016 RVA: 0x002F798C File Offset: 0x002F5B8C
		public bool MiniMapVisible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170031F7 RID: 12791
		// (get) Token: 0x0600C749 RID: 51017 RVA: 0x002F79CC File Offset: 0x002F5BCC
		public bool TopButtonVisible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170031F8 RID: 12792
		// (get) Token: 0x0600C74A RID: 51018 RVA: 0x002F7A0C File Offset: 0x002F5C0C
		public bool HomeButtonVisible
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170031F9 RID: 12793
		// (get) Token: 0x0600C74B RID: 51019 RVA: 0x002F7A4C File Offset: 0x002F5C4C
		public bool RoleStateVisible
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170031FA RID: 12794
		// (get) Token: 0x0600C74C RID: 51020 RVA: 0x002F7A8C File Offset: 0x002F5C8C
		public bool ChatVisible
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170031FB RID: 12795
		// (get) Token: 0x0600C74D RID: 51021 RVA: 0x002F7ACC File Offset: 0x002F5CCC
		public bool FormationVisible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170031FC RID: 12796
		// (get) Token: 0x0600C74E RID: 51022 RVA: 0x002F7B0C File Offset: 0x002F5D0C
		public int JoystickType
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005136 RID: 20790
		private Table __p;
	}
}
