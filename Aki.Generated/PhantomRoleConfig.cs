using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDD RID: 4061
	public struct PhantomRoleConfig : IFlatbufferObject
	{
		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x0600B048 RID: 45128 RVA: 0x002D3A4F File Offset: 0x002D1C4F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x002D3A5C File Offset: 0x002D1C5C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x002D3A64 File Offset: 0x002D1C64
		public static PhantomRoleConfig GetRootAsPhantomRoleConfig(ByteBuffer _bb)
		{
			return PhantomRoleConfig.GetRootAsPhantomRoleConfig(_bb, default(PhantomRoleConfig));
		}

		// Token: 0x0600B04B RID: 45131 RVA: 0x002D3A80 File Offset: 0x002D1C80
		public static PhantomRoleConfig GetRootAsPhantomRoleConfig(ByteBuffer _bb, PhantomRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B04C RID: 45132 RVA: 0x002D3A9D File Offset: 0x002D1C9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B04D RID: 45133 RVA: 0x002D3AAC File Offset: 0x002D1CAC
		public PhantomRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x0600B04E RID: 45134 RVA: 0x002D3ABC File Offset: 0x002D1CBC
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

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x0600B04F RID: 45135 RVA: 0x002D3AF8 File Offset: 0x002D1CF8
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

		// Token: 0x0600B050 RID: 45136 RVA: 0x002D3B2F File Offset: 0x002D1D2F
		public Span<byte> GetGeDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B051 RID: 45137 RVA: 0x002D3B3E File Offset: 0x002D1D3E
		public byte[] GetGeDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x0600B052 RID: 45138 RVA: 0x002D3B58 File Offset: 0x002D1D58
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

		// Token: 0x0600B053 RID: 45139 RVA: 0x002D3B8F File Offset: 0x002D1D8F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x002D3B9E File Offset: 0x002D1D9E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x0600B055 RID: 45141 RVA: 0x002D3BB8 File Offset: 0x002D1DB8
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

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x0600B056 RID: 45142 RVA: 0x002D3BF8 File Offset: 0x002D1DF8
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

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0600B057 RID: 45143 RVA: 0x002D3C38 File Offset: 0x002D1E38
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

		// Token: 0x170027B8 RID: 10168
		// (get) Token: 0x0600B058 RID: 45144 RVA: 0x002D3C78 File Offset: 0x002D1E78
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

		// Token: 0x170027B9 RID: 10169
		// (get) Token: 0x0600B059 RID: 45145 RVA: 0x002D3CB8 File Offset: 0x002D1EB8
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

		// Token: 0x170027BA RID: 10170
		// (get) Token: 0x0600B05A RID: 45146 RVA: 0x002D3CFC File Offset: 0x002D1EFC
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

		// Token: 0x170027BB RID: 10171
		// (get) Token: 0x0600B05B RID: 45147 RVA: 0x002D3D3C File Offset: 0x002D1F3C
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

		// Token: 0x0600B05C RID: 45148 RVA: 0x002D3D74 File Offset: 0x002D1F74
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x002D3D84 File Offset: 0x002D1F84
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170027BC RID: 10172
		// (get) Token: 0x0600B05E RID: 45150 RVA: 0x002D3D9C File Offset: 0x002D1F9C
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

		// Token: 0x170027BD RID: 10173
		// (get) Token: 0x0600B05F RID: 45151 RVA: 0x002D3DDC File Offset: 0x002D1FDC
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

		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x0600B060 RID: 45152 RVA: 0x002D3E1C File Offset: 0x002D201C
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

		// Token: 0x040055A4 RID: 21924
		private Table __p;
	}
}
