using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001154 RID: 4436
	public struct RoleTowerRole : IFlatbufferObject
	{
		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600D2A1 RID: 53921 RVA: 0x0031F09D File Offset: 0x0031D29D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D2A2 RID: 53922 RVA: 0x0031F0AA File Offset: 0x0031D2AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D2A3 RID: 53923 RVA: 0x0031F0B4 File Offset: 0x0031D2B4
		public static RoleTowerRole GetRootAsRoleTowerRole(ByteBuffer _bb)
		{
			return RoleTowerRole.GetRootAsRoleTowerRole(_bb, default(RoleTowerRole));
		}

		// Token: 0x0600D2A4 RID: 53924 RVA: 0x0031F0D0 File Offset: 0x0031D2D0
		public static RoleTowerRole GetRootAsRoleTowerRole(ByteBuffer _bb, RoleTowerRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D2A5 RID: 53925 RVA: 0x0031F0ED File Offset: 0x0031D2ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D2A6 RID: 53926 RVA: 0x0031F0FC File Offset: 0x0031D2FC
		public RoleTowerRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600D2A7 RID: 53927 RVA: 0x0031F10C File Offset: 0x0031D30C
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

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600D2A8 RID: 53928 RVA: 0x0031F148 File Offset: 0x0031D348
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

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600D2A9 RID: 53929 RVA: 0x0031F184 File Offset: 0x0031D384
		public int MainGroup
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600D2AA RID: 53930 RVA: 0x0031F1C0 File Offset: 0x0031D3C0
		public int AssistGroup
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400575B RID: 22363
		private Table __p;
	}
}
