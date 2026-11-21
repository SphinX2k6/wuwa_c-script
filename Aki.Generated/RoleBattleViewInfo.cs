using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001121 RID: 4385
	public struct RoleBattleViewInfo : IFlatbufferObject
	{
		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600CD8B RID: 52619 RVA: 0x00313755 File Offset: 0x00311955
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CD8C RID: 52620 RVA: 0x00313762 File Offset: 0x00311962
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CD8D RID: 52621 RVA: 0x0031376C File Offset: 0x0031196C
		public static RoleBattleViewInfo GetRootAsRoleBattleViewInfo(ByteBuffer _bb)
		{
			return RoleBattleViewInfo.GetRootAsRoleBattleViewInfo(_bb, default(RoleBattleViewInfo));
		}

		// Token: 0x0600CD8E RID: 52622 RVA: 0x00313788 File Offset: 0x00311988
		public static RoleBattleViewInfo GetRootAsRoleBattleViewInfo(ByteBuffer _bb, RoleBattleViewInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CD8F RID: 52623 RVA: 0x003137A5 File Offset: 0x003119A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CD90 RID: 52624 RVA: 0x003137B4 File Offset: 0x003119B4
		public RoleBattleViewInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600CD91 RID: 52625 RVA: 0x003137C4 File Offset: 0x003119C4
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

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600CD92 RID: 52626 RVA: 0x00313800 File Offset: 0x00311A00
		public bool MiniMapVisible
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600CD93 RID: 52627 RVA: 0x00313840 File Offset: 0x00311A40
		public bool TopButtonVisible
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600CD94 RID: 52628 RVA: 0x00313880 File Offset: 0x00311A80
		public bool HomeButtonVisible
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600CD95 RID: 52629 RVA: 0x003138C0 File Offset: 0x00311AC0
		public bool RoleStateVisible
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600CD96 RID: 52630 RVA: 0x00313900 File Offset: 0x00311B00
		public bool ChatVisible
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600CD97 RID: 52631 RVA: 0x00313940 File Offset: 0x00311B40
		public bool FormationVisible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600CD98 RID: 52632 RVA: 0x00313980 File Offset: 0x00311B80
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

		// Token: 0x0400571E RID: 22302
		private Table __p;
	}
}
