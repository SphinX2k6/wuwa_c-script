using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105F RID: 4191
	public struct RoleSkinTrialInfo : IFlatbufferObject
	{
		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600CB30 RID: 52016 RVA: 0x00300535 File Offset: 0x002FE735
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x00300542 File Offset: 0x002FE742
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB32 RID: 52018 RVA: 0x0030054C File Offset: 0x002FE74C
		public static RoleSkinTrialInfo GetRootAsRoleSkinTrialInfo(ByteBuffer _bb)
		{
			return RoleSkinTrialInfo.GetRootAsRoleSkinTrialInfo(_bb, default(RoleSkinTrialInfo));
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x00300568 File Offset: 0x002FE768
		public static RoleSkinTrialInfo GetRootAsRoleSkinTrialInfo(ByteBuffer _bb, RoleSkinTrialInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x00300585 File Offset: 0x002FE785
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x00300594 File Offset: 0x002FE794
		public RoleSkinTrialInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600CB36 RID: 52022 RVA: 0x003005A4 File Offset: 0x002FE7A4
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

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600CB37 RID: 52023 RVA: 0x003005E0 File Offset: 0x002FE7E0
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

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600CB38 RID: 52024 RVA: 0x0030061C File Offset: 0x002FE81C
		public int TrialRoleId
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

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600CB39 RID: 52025 RVA: 0x00300658 File Offset: 0x002FE858
		public int PreviewSkinId
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

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600CB3A RID: 52026 RVA: 0x00300698 File Offset: 0x002FE898
		public int InstanceId
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

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600CB3B RID: 52027 RVA: 0x003006D8 File Offset: 0x002FE8D8
		public int AccessId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600CB3C RID: 52028 RVA: 0x00300718 File Offset: 0x002FE918
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600CB3D RID: 52029 RVA: 0x00300758 File Offset: 0x002FE958
		public string RoleIcon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB3E RID: 52030 RVA: 0x00300790 File Offset: 0x002FE990
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CB3F RID: 52031 RVA: 0x003007A0 File Offset: 0x002FE9A0
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600CB40 RID: 52032 RVA: 0x003007B8 File Offset: 0x002FE9B8
		public string Introduction
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x003007F0 File Offset: 0x002FE9F0
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CB42 RID: 52034 RVA: 0x00300800 File Offset: 0x002FEA00
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600CB43 RID: 52035 RVA: 0x00300818 File Offset: 0x002FEA18
		public int UiConfigId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005163 RID: 20835
		private Table __p;
	}
}
