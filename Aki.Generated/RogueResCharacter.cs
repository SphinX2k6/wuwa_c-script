using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DC RID: 4316
	public struct RogueResCharacter : IFlatbufferObject
	{
		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x0600C75A RID: 51034 RVA: 0x00305C8C File Offset: 0x00303E8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C75B RID: 51035 RVA: 0x00305C99 File Offset: 0x00303E99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C75C RID: 51036 RVA: 0x00305CA0 File Offset: 0x00303EA0
		public static RogueResCharacter GetRootAsRogueResCharacter(ByteBuffer _bb)
		{
			return RogueResCharacter.GetRootAsRogueResCharacter(_bb, default(RogueResCharacter));
		}

		// Token: 0x0600C75D RID: 51037 RVA: 0x00305CBC File Offset: 0x00303EBC
		public static RogueResCharacter GetRootAsRogueResCharacter(ByteBuffer _bb, RogueResCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C75E RID: 51038 RVA: 0x00305CD9 File Offset: 0x00303ED9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C75F RID: 51039 RVA: 0x00305CE8 File Offset: 0x00303EE8
		public RogueResCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x0600C760 RID: 51040 RVA: 0x00305CF8 File Offset: 0x00303EF8
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

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x0600C761 RID: 51041 RVA: 0x00305D34 File Offset: 0x00303F34
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

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x0600C762 RID: 51042 RVA: 0x00305D70 File Offset: 0x00303F70
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x0600C763 RID: 51043 RVA: 0x00305DAC File Offset: 0x00303FAC
		public string RoleIcon
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

		// Token: 0x0600C764 RID: 51044 RVA: 0x00305DE4 File Offset: 0x00303FE4
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C765 RID: 51045 RVA: 0x00305DF4 File Offset: 0x00303FF4
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x0600C766 RID: 51046 RVA: 0x00305E0C File Offset: 0x0030400C
		public string RoleName
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C767 RID: 51047 RVA: 0x00305E44 File Offset: 0x00304044
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C768 RID: 51048 RVA: 0x00305E54 File Offset: 0x00304054
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x0600C769 RID: 51049 RVA: 0x00305E6C File Offset: 0x0030406C
		public string RoleBigIcon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C76A RID: 51050 RVA: 0x00305EA4 File Offset: 0x003040A4
		public Span<byte> GetRoleBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C76B RID: 51051 RVA: 0x00305EB4 File Offset: 0x003040B4
		public byte[] GetRoleBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040056C4 RID: 22212
		private Table __p;
	}
}
