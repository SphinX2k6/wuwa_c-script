using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C3 RID: 4291
	public struct RogueCharacter : IFlatbufferObject
	{
		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x0600C4B4 RID: 50356 RVA: 0x002FFDD4 File Offset: 0x002FDFD4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C4B5 RID: 50357 RVA: 0x002FFDE1 File Offset: 0x002FDFE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C4B6 RID: 50358 RVA: 0x002FFDE8 File Offset: 0x002FDFE8
		public static RogueCharacter GetRootAsRogueCharacter(ByteBuffer _bb)
		{
			return RogueCharacter.GetRootAsRogueCharacter(_bb, default(RogueCharacter));
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x002FFE04 File Offset: 0x002FE004
		public static RogueCharacter GetRootAsRogueCharacter(ByteBuffer _bb, RogueCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x002FFE21 File Offset: 0x002FE021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C4B9 RID: 50361 RVA: 0x002FFE30 File Offset: 0x002FE030
		public RogueCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F77 RID: 12151
		// (get) Token: 0x0600C4BA RID: 50362 RVA: 0x002FFE40 File Offset: 0x002FE040
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

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x0600C4BB RID: 50363 RVA: 0x002FFE7C File Offset: 0x002FE07C
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

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0600C4BC RID: 50364 RVA: 0x002FFEB8 File Offset: 0x002FE0B8
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

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x0600C4BD RID: 50365 RVA: 0x002FFEF4 File Offset: 0x002FE0F4
		public int UnlockInst
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

		// Token: 0x0600C4BE RID: 50366 RVA: 0x002FFF34 File Offset: 0x002FE134
		public int SupportSkillList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x0600C4BF RID: 50367 RVA: 0x002FFF74 File Offset: 0x002FE174
		public int SupportSkillListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C4C0 RID: 50368 RVA: 0x002FFFA0 File Offset: 0x002FE1A0
		public Span<int> GetSupportSkillListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x002FFFB0 File Offset: 0x002FE1B0
		public int[] GetSupportSkillListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002F7C RID: 12156
		// (get) Token: 0x0600C4C2 RID: 50370 RVA: 0x002FFFC8 File Offset: 0x002FE1C8
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002F7D RID: 12157
		// (get) Token: 0x0600C4C3 RID: 50371 RVA: 0x00300008 File Offset: 0x002FE208
		public string RoleIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x00300040 File Offset: 0x002FE240
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x00300050 File Offset: 0x002FE250
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x0600C4C6 RID: 50374 RVA: 0x00300068 File Offset: 0x002FE268
		public string RoleName
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

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x003000A0 File Offset: 0x002FE2A0
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x003000B0 File Offset: 0x002FE2B0
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x0600C4C9 RID: 50377 RVA: 0x003000C8 File Offset: 0x002FE2C8
		public string RoleBigIcon
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

		// Token: 0x0600C4CA RID: 50378 RVA: 0x00300100 File Offset: 0x002FE300
		public Span<byte> GetRoleBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x00300110 File Offset: 0x002FE310
		public byte[] GetRoleBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C4CC RID: 50380 RVA: 0x00300128 File Offset: 0x002FE328
		[NullableContext(1)]
		public int[] SupportSkillList()
		{
			return this.GetSupportSkillListArray();
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x00300130 File Offset: 0x002FE330
		[NullableContext(1)]
		public IEnumerable<int> SupportSkillListIter()
		{
			RogueCharacter.<SupportSkillListIter>d__36 <SupportSkillListIter>d__ = new RogueCharacter.<SupportSkillListIter>d__36(-2);
			<SupportSkillListIter>d__.<>3__<>4__this = this;
			return <SupportSkillListIter>d__;
		}

		// Token: 0x040056A0 RID: 22176
		private Table __p;
	}
}
