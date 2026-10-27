using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FDB RID: 4059
	public struct RogueCharacter : IFlatbufferObject
	{
		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x0600BE6A RID: 48746 RVA: 0x002E3848 File Offset: 0x002E1A48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x002E3855 File Offset: 0x002E1A55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE6C RID: 48748 RVA: 0x002E385C File Offset: 0x002E1A5C
		public static RogueCharacter GetRootAsRogueCharacter(ByteBuffer _bb)
		{
			return RogueCharacter.GetRootAsRogueCharacter(_bb, default(RogueCharacter));
		}

		// Token: 0x0600BE6D RID: 48749 RVA: 0x002E3878 File Offset: 0x002E1A78
		public static RogueCharacter GetRootAsRogueCharacter(ByteBuffer _bb, RogueCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE6E RID: 48750 RVA: 0x002E3895 File Offset: 0x002E1A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x002E38A4 File Offset: 0x002E1AA4
		public RogueCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x0600BE70 RID: 48752 RVA: 0x002E38B4 File Offset: 0x002E1AB4
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

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x0600BE71 RID: 48753 RVA: 0x002E38F0 File Offset: 0x002E1AF0
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

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x0600BE72 RID: 48754 RVA: 0x002E392C File Offset: 0x002E1B2C
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

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x0600BE73 RID: 48755 RVA: 0x002E3968 File Offset: 0x002E1B68
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

		// Token: 0x0600BE74 RID: 48756 RVA: 0x002E39A8 File Offset: 0x002E1BA8
		public int SupportSkillList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0600BE75 RID: 48757 RVA: 0x002E39E8 File Offset: 0x002E1BE8
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

		// Token: 0x0600BE76 RID: 48758 RVA: 0x002E3A14 File Offset: 0x002E1C14
		public Span<int> GetSupportSkillListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600BE77 RID: 48759 RVA: 0x002E3A24 File Offset: 0x002E1C24
		public int[] GetSupportSkillListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0600BE78 RID: 48760 RVA: 0x002E3A3C File Offset: 0x002E1C3C
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

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0600BE79 RID: 48761 RVA: 0x002E3A7C File Offset: 0x002E1C7C
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

		// Token: 0x0600BE7A RID: 48762 RVA: 0x002E3AB4 File Offset: 0x002E1CB4
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BE7B RID: 48763 RVA: 0x002E3AC4 File Offset: 0x002E1CC4
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0600BE7C RID: 48764 RVA: 0x002E3ADC File Offset: 0x002E1CDC
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

		// Token: 0x0600BE7D RID: 48765 RVA: 0x002E3B14 File Offset: 0x002E1D14
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BE7E RID: 48766 RVA: 0x002E3B24 File Offset: 0x002E1D24
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0600BE7F RID: 48767 RVA: 0x002E3B3C File Offset: 0x002E1D3C
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

		// Token: 0x0600BE80 RID: 48768 RVA: 0x002E3B74 File Offset: 0x002E1D74
		public Span<byte> GetRoleBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BE81 RID: 48769 RVA: 0x002E3B84 File Offset: 0x002E1D84
		public byte[] GetRoleBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BE82 RID: 48770 RVA: 0x002E3B9C File Offset: 0x002E1D9C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SupportSkillListIter()或GetSupportSkillListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SupportSkillList()
		{
			RogueCharacter rogueCharacter = this;
			return rogueCharacter.GetSupportSkillListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BE83 RID: 48771 RVA: 0x002E3BC0 File Offset: 0x002E1DC0
		[NullableContext(1)]
		public readonly IEnumerable<int> SupportSkillListIter()
		{
			RogueCharacter.<SupportSkillListIter>d__36 <SupportSkillListIter>d__ = new RogueCharacter.<SupportSkillListIter>d__36(-2);
			<SupportSkillListIter>d__.<>3__<>4__this = this;
			return <SupportSkillListIter>d__;
		}

		// Token: 0x040050B8 RID: 20664
		private Table __p;
	}
}
