using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF8 RID: 3832
	public struct PhantomRoleConfig : IFlatbufferObject
	{
		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x0600AA27 RID: 43559 RVA: 0x002B6C31 File Offset: 0x002B4E31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA28 RID: 43560 RVA: 0x002B6C3E File Offset: 0x002B4E3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA29 RID: 43561 RVA: 0x002B6C48 File Offset: 0x002B4E48
		public static PhantomRoleConfig GetRootAsPhantomRoleConfig(ByteBuffer _bb)
		{
			return PhantomRoleConfig.GetRootAsPhantomRoleConfig(_bb, default(PhantomRoleConfig));
		}

		// Token: 0x0600AA2A RID: 43562 RVA: 0x002B6C64 File Offset: 0x002B4E64
		public static PhantomRoleConfig GetRootAsPhantomRoleConfig(ByteBuffer _bb, PhantomRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA2B RID: 43563 RVA: 0x002B6C81 File Offset: 0x002B4E81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA2C RID: 43564 RVA: 0x002B6C90 File Offset: 0x002B4E90
		public PhantomRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x0600AA2D RID: 43565 RVA: 0x002B6CA0 File Offset: 0x002B4EA0
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

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x0600AA2E RID: 43566 RVA: 0x002B6CDC File Offset: 0x002B4EDC
		public string GeDesc
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

		// Token: 0x0600AA2F RID: 43567 RVA: 0x002B6D13 File Offset: 0x002B4F13
		public Span<byte> GetGeDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x002B6D22 File Offset: 0x002B4F22
		public byte[] GetGeDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x0600AA31 RID: 43569 RVA: 0x002B6D3C File Offset: 0x002B4F3C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x002B6D73 File Offset: 0x002B4F73
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AA33 RID: 43571 RVA: 0x002B6D82 File Offset: 0x002B4F82
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x0600AA34 RID: 43572 RVA: 0x002B6D9C File Offset: 0x002B4F9C
		public int MeshId
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

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x0600AA35 RID: 43573 RVA: 0x002B6DDC File Offset: 0x002B4FDC
		public int SkillId
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

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x0600AA36 RID: 43574 RVA: 0x002B6E1C File Offset: 0x002B501C
		public int SkillTreeGroupId
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

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x0600AA37 RID: 43575 RVA: 0x002B6E5C File Offset: 0x002B505C
		public int CameraConfig
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

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x0600AA38 RID: 43576 RVA: 0x002B6E9C File Offset: 0x002B509C
		public float CameraFloatHeight
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x0600AA39 RID: 43577 RVA: 0x002B6EE0 File Offset: 0x002B50E0
		public int PropertyId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x0600AA3A RID: 43578 RVA: 0x002B6F20 File Offset: 0x002B5120
		public string RoleHeadIcon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA3B RID: 43579 RVA: 0x002B6F58 File Offset: 0x002B5158
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AA3C RID: 43580 RVA: 0x002B6F68 File Offset: 0x002B5168
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x0600AA3D RID: 43581 RVA: 0x002B6F80 File Offset: 0x002B5180
		public int CameraId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x0600AA3E RID: 43582 RVA: 0x002B6FC0 File Offset: 0x002B51C0
		public int SearchId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x0600AA3F RID: 43583 RVA: 0x002B7000 File Offset: 0x002B5200
		public int HUDId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004FBF RID: 20415
		private Table __p;
	}
}
