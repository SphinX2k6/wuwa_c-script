using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF4 RID: 4084
	public struct RogueResCharacter : IFlatbufferObject
	{
		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x0600C110 RID: 49424 RVA: 0x002E99C4 File Offset: 0x002E7BC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C111 RID: 49425 RVA: 0x002E99D1 File Offset: 0x002E7BD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C112 RID: 49426 RVA: 0x002E99D8 File Offset: 0x002E7BD8
		public static RogueResCharacter GetRootAsRogueResCharacter(ByteBuffer _bb)
		{
			return RogueResCharacter.GetRootAsRogueResCharacter(_bb, default(RogueResCharacter));
		}

		// Token: 0x0600C113 RID: 49427 RVA: 0x002E99F4 File Offset: 0x002E7BF4
		public static RogueResCharacter GetRootAsRogueResCharacter(ByteBuffer _bb, RogueResCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C114 RID: 49428 RVA: 0x002E9A11 File Offset: 0x002E7C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C115 RID: 49429 RVA: 0x002E9A20 File Offset: 0x002E7C20
		public RogueResCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x0600C116 RID: 49430 RVA: 0x002E9A30 File Offset: 0x002E7C30
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

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x0600C117 RID: 49431 RVA: 0x002E9A6C File Offset: 0x002E7C6C
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

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0600C118 RID: 49432 RVA: 0x002E9AA8 File Offset: 0x002E7CA8
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

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0600C119 RID: 49433 RVA: 0x002E9AE4 File Offset: 0x002E7CE4
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

		// Token: 0x0600C11A RID: 49434 RVA: 0x002E9B1C File Offset: 0x002E7D1C
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C11B RID: 49435 RVA: 0x002E9B2C File Offset: 0x002E7D2C
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x0600C11C RID: 49436 RVA: 0x002E9B44 File Offset: 0x002E7D44
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

		// Token: 0x0600C11D RID: 49437 RVA: 0x002E9B7C File Offset: 0x002E7D7C
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C11E RID: 49438 RVA: 0x002E9B8C File Offset: 0x002E7D8C
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x0600C11F RID: 49439 RVA: 0x002E9BA4 File Offset: 0x002E7DA4
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

		// Token: 0x0600C120 RID: 49440 RVA: 0x002E9BDC File Offset: 0x002E7DDC
		public Span<byte> GetRoleBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C121 RID: 49441 RVA: 0x002E9BEC File Offset: 0x002E7DEC
		public byte[] GetRoleBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040050DC RID: 20700
		private Table __p;
	}
}
