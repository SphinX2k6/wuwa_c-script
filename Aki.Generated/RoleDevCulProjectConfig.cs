using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103F RID: 4159
	public struct RoleDevCulProjectConfig : IFlatbufferObject
	{
		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600C79A RID: 51098 RVA: 0x002F850C File Offset: 0x002F670C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C79B RID: 51099 RVA: 0x002F8519 File Offset: 0x002F6719
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C79C RID: 51100 RVA: 0x002F8520 File Offset: 0x002F6720
		public static RoleDevCulProjectConfig GetRootAsRoleDevCulProjectConfig(ByteBuffer _bb)
		{
			return RoleDevCulProjectConfig.GetRootAsRoleDevCulProjectConfig(_bb, default(RoleDevCulProjectConfig));
		}

		// Token: 0x0600C79D RID: 51101 RVA: 0x002F853C File Offset: 0x002F673C
		public static RoleDevCulProjectConfig GetRootAsRoleDevCulProjectConfig(ByteBuffer _bb, RoleDevCulProjectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C79E RID: 51102 RVA: 0x002F8559 File Offset: 0x002F6759
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C79F RID: 51103 RVA: 0x002F8568 File Offset: 0x002F6768
		public RoleDevCulProjectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600C7A0 RID: 51104 RVA: 0x002F8578 File Offset: 0x002F6778
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

		// Token: 0x0600C7A1 RID: 51105 RVA: 0x002F85B4 File Offset: 0x002F67B4
		public int RoleLvUp(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600C7A2 RID: 51106 RVA: 0x002F85F4 File Offset: 0x002F67F4
		public int RoleLvUpLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C7A3 RID: 51107 RVA: 0x002F861F File Offset: 0x002F681F
		public Span<int> GetRoleLvUpBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C7A4 RID: 51108 RVA: 0x002F862E File Offset: 0x002F682E
		public int[] GetRoleLvUpArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C7A5 RID: 51109 RVA: 0x002F8648 File Offset: 0x002F6848
		public int WeaponLvUp(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600C7A6 RID: 51110 RVA: 0x002F8688 File Offset: 0x002F6888
		public int WeaponLvUpLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C7A7 RID: 51111 RVA: 0x002F86B3 File Offset: 0x002F68B3
		public Span<int> GetWeaponLvUpBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C7A8 RID: 51112 RVA: 0x002F86C2 File Offset: 0x002F68C2
		public int[] GetWeaponLvUpArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C7A9 RID: 51113 RVA: 0x002F86DC File Offset: 0x002F68DC
		public int SkillLvUp(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700321B RID: 12827
		// (get) Token: 0x0600C7AA RID: 51114 RVA: 0x002F871C File Offset: 0x002F691C
		public int SkillLvUpLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C7AB RID: 51115 RVA: 0x002F8748 File Offset: 0x002F6948
		public Span<int> GetSkillLvUpBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600C7AC RID: 51116 RVA: 0x002F8758 File Offset: 0x002F6958
		public int[] GetSkillLvUpArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600C7AD RID: 51117 RVA: 0x002F8770 File Offset: 0x002F6970
		public int UnknownItemId
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

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600C7AE RID: 51118 RVA: 0x002F87B0 File Offset: 0x002F69B0
		public string UnknownItemIcon
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

		// Token: 0x0600C7AF RID: 51119 RVA: 0x002F87E8 File Offset: 0x002F69E8
		public Span<byte> GetUnknownItemIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C7B0 RID: 51120 RVA: 0x002F87F8 File Offset: 0x002F69F8
		public byte[] GetUnknownItemIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600C7B1 RID: 51121 RVA: 0x002F8810 File Offset: 0x002F6A10
		public int OverflowExperience
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

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600C7B2 RID: 51122 RVA: 0x002F8850 File Offset: 0x002F6A50
		public int WeaponQualityThreshold
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

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600C7B3 RID: 51123 RVA: 0x002F8890 File Offset: 0x002F6A90
		public int PhantomNumThreshold
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

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600C7B4 RID: 51124 RVA: 0x002F88D0 File Offset: 0x002F6AD0
		public int PhantomQualityThreshold
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

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600C7B5 RID: 51125 RVA: 0x002F8910 File Offset: 0x002F6B10
		public int PhantomLevelThreshold
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

		// Token: 0x0600C7B6 RID: 51126 RVA: 0x002F8950 File Offset: 0x002F6B50
		public int PhantomSpecialGroupList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600C7B7 RID: 51127 RVA: 0x002F8990 File Offset: 0x002F6B90
		public int PhantomSpecialGroupListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C7B8 RID: 51128 RVA: 0x002F89BC File Offset: 0x002F6BBC
		public Span<int> GetPhantomSpecialGroupListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600C7B9 RID: 51129 RVA: 0x002F89CC File Offset: 0x002F6BCC
		public int[] GetPhantomSpecialGroupListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600C7BA RID: 51130 RVA: 0x002F89E4 File Offset: 0x002F6BE4
		public int PopTipsTime
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

		// Token: 0x0600C7BB RID: 51131 RVA: 0x002F8A24 File Offset: 0x002F6C24
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PhantomSpecialGroupListIter()或GetPhantomSpecialGroupListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PhantomSpecialGroupList()
		{
			RoleDevCulProjectConfig roleDevCulProjectConfig = this;
			return roleDevCulProjectConfig.GetPhantomSpecialGroupListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C7BC RID: 51132 RVA: 0x002F8A48 File Offset: 0x002F6C48
		[NullableContext(1)]
		public readonly IEnumerable<int> PhantomSpecialGroupListIter()
		{
			RoleDevCulProjectConfig.<PhantomSpecialGroupListIter>d__49 <PhantomSpecialGroupListIter>d__ = new RoleDevCulProjectConfig.<PhantomSpecialGroupListIter>d__49(-2);
			<PhantomSpecialGroupListIter>d__.<>3__<>4__this = this;
			return <PhantomSpecialGroupListIter>d__;
		}

		// Token: 0x0600C7BD RID: 51133 RVA: 0x002F8A60 File Offset: 0x002F6C60
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleLvUpIter()或GetRoleLvUpBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleLvUp()
		{
			RoleDevCulProjectConfig roleDevCulProjectConfig = this;
			return roleDevCulProjectConfig.GetRoleLvUpArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C7BE RID: 51134 RVA: 0x002F8A84 File Offset: 0x002F6C84
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleLvUpIter()
		{
			RoleDevCulProjectConfig.<RoleLvUpIter>d__51 <RoleLvUpIter>d__ = new RoleDevCulProjectConfig.<RoleLvUpIter>d__51(-2);
			<RoleLvUpIter>d__.<>3__<>4__this = this;
			return <RoleLvUpIter>d__;
		}

		// Token: 0x0600C7BF RID: 51135 RVA: 0x002F8A9C File Offset: 0x002F6C9C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillLvUpIter()或GetSkillLvUpBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillLvUp()
		{
			RoleDevCulProjectConfig roleDevCulProjectConfig = this;
			return roleDevCulProjectConfig.GetSkillLvUpArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C7C0 RID: 51136 RVA: 0x002F8AC0 File Offset: 0x002F6CC0
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillLvUpIter()
		{
			RoleDevCulProjectConfig.<SkillLvUpIter>d__53 <SkillLvUpIter>d__ = new RoleDevCulProjectConfig.<SkillLvUpIter>d__53(-2);
			<SkillLvUpIter>d__.<>3__<>4__this = this;
			return <SkillLvUpIter>d__;
		}

		// Token: 0x0600C7C1 RID: 51137 RVA: 0x002F8AD8 File Offset: 0x002F6CD8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponLvUpIter()或GetWeaponLvUpBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WeaponLvUp()
		{
			RoleDevCulProjectConfig roleDevCulProjectConfig = this;
			return roleDevCulProjectConfig.GetWeaponLvUpArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C7C2 RID: 51138 RVA: 0x002F8AFC File Offset: 0x002F6CFC
		[NullableContext(1)]
		public readonly IEnumerable<int> WeaponLvUpIter()
		{
			RoleDevCulProjectConfig.<WeaponLvUpIter>d__55 <WeaponLvUpIter>d__ = new RoleDevCulProjectConfig.<WeaponLvUpIter>d__55(-2);
			<WeaponLvUpIter>d__.<>3__<>4__this = this;
			return <WeaponLvUpIter>d__;
		}

		// Token: 0x0400513D RID: 20797
		private Table __p;
	}
}
