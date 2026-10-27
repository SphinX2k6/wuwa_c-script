using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200105B RID: 4187
	public struct RoleSkin : IFlatbufferObject
	{
		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600CA26 RID: 51750 RVA: 0x002FE139 File Offset: 0x002FC339
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA27 RID: 51751 RVA: 0x002FE146 File Offset: 0x002FC346
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA28 RID: 51752 RVA: 0x002FE150 File Offset: 0x002FC350
		public static RoleSkin GetRootAsRoleSkin(ByteBuffer _bb)
		{
			return RoleSkin.GetRootAsRoleSkin(_bb, default(RoleSkin));
		}

		// Token: 0x0600CA29 RID: 51753 RVA: 0x002FE16C File Offset: 0x002FC36C
		public static RoleSkin GetRootAsRoleSkin(ByteBuffer _bb, RoleSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA2A RID: 51754 RVA: 0x002FE189 File Offset: 0x002FC389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA2B RID: 51755 RVA: 0x002FE198 File Offset: 0x002FC398
		public RoleSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600CA2C RID: 51756 RVA: 0x002FE1A8 File Offset: 0x002FC3A8
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

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600CA2D RID: 51757 RVA: 0x002FE1E4 File Offset: 0x002FC3E4
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

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600CA2E RID: 51758 RVA: 0x002FE220 File Offset: 0x002FC420
		public int GroupId
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

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600CA2F RID: 51759 RVA: 0x002FE25C File Offset: 0x002FC45C
		public int SuitWeaponSkinId
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

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600CA30 RID: 51760 RVA: 0x002FE29C File Offset: 0x002FC49C
		public int HeadId
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

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600CA31 RID: 51761 RVA: 0x002FE2DC File Offset: 0x002FC4DC
		public int QualityId
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

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600CA32 RID: 51762 RVA: 0x002FE31C File Offset: 0x002FC51C
		public string Name
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

		// Token: 0x0600CA33 RID: 51763 RVA: 0x002FE354 File Offset: 0x002FC554
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CA34 RID: 51764 RVA: 0x002FE364 File Offset: 0x002FC564
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600CA35 RID: 51765 RVA: 0x002FE37C File Offset: 0x002FC57C
		public string TitleName
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

		// Token: 0x0600CA36 RID: 51766 RVA: 0x002FE3B4 File Offset: 0x002FC5B4
		public Span<byte> GetTitleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CA37 RID: 51767 RVA: 0x002FE3C4 File Offset: 0x002FC5C4
		public byte[] GetTitleNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600CA38 RID: 51768 RVA: 0x002FE3DC File Offset: 0x002FC5DC
		public string SubDecName
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

		// Token: 0x0600CA39 RID: 51769 RVA: 0x002FE414 File Offset: 0x002FC614
		public Span<byte> GetSubDecNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x002FE424 File Offset: 0x002FC624
		public byte[] GetSubDecNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600CA3B RID: 51771 RVA: 0x002FE43C File Offset: 0x002FC63C
		public string TypeDescription
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

		// Token: 0x0600CA3C RID: 51772 RVA: 0x002FE474 File Offset: 0x002FC674
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600CA3D RID: 51773 RVA: 0x002FE484 File Offset: 0x002FC684
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600CA3E RID: 51774 RVA: 0x002FE49C File Offset: 0x002FC69C
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA3F RID: 51775 RVA: 0x002FE4D4 File Offset: 0x002FC6D4
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600CA40 RID: 51776 RVA: 0x002FE4E4 File Offset: 0x002FC6E4
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600CA41 RID: 51777 RVA: 0x002FE4FC File Offset: 0x002FC6FC
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA42 RID: 51778 RVA: 0x002FE534 File Offset: 0x002FC734
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600CA43 RID: 51779 RVA: 0x002FE544 File Offset: 0x002FC744
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600CA44 RID: 51780 RVA: 0x002FE55C File Offset: 0x002FC75C
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA45 RID: 51781 RVA: 0x002FE594 File Offset: 0x002FC794
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600CA46 RID: 51782 RVA: 0x002FE5A4 File Offset: 0x002FC7A4
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600CA47 RID: 51783 RVA: 0x002FE5BC File Offset: 0x002FC7BC
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA48 RID: 51784 RVA: 0x002FE5F4 File Offset: 0x002FC7F4
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600CA49 RID: 51785 RVA: 0x002FE604 File Offset: 0x002FC804
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CA4A RID: 51786 RVA: 0x002FE61C File Offset: 0x002FC81C
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600CA4B RID: 51787 RVA: 0x002FE65C File Offset: 0x002FC85C
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CA4C RID: 51788 RVA: 0x002FE688 File Offset: 0x002FC888
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x002FE698 File Offset: 0x002FC898
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600CA4E RID: 51790 RVA: 0x002FE6B0 File Offset: 0x002FC8B0
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600CA4F RID: 51791 RVA: 0x002FE6F0 File Offset: 0x002FC8F0
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600CA50 RID: 51792 RVA: 0x002FE730 File Offset: 0x002FC930
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600CA51 RID: 51793 RVA: 0x002FE770 File Offset: 0x002FC970
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA52 RID: 51794 RVA: 0x002FE7A8 File Offset: 0x002FC9A8
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600CA53 RID: 51795 RVA: 0x002FE7B8 File Offset: 0x002FC9B8
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600CA54 RID: 51796 RVA: 0x002FE7D0 File Offset: 0x002FC9D0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA55 RID: 51797 RVA: 0x002FE808 File Offset: 0x002FCA08
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600CA56 RID: 51798 RVA: 0x002FE818 File Offset: 0x002FCA18
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600CA57 RID: 51799 RVA: 0x002FE830 File Offset: 0x002FCA30
		public string FunctionDesc
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA58 RID: 51800 RVA: 0x002FE868 File Offset: 0x002FCA68
		public Span<byte> GetFunctionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600CA59 RID: 51801 RVA: 0x002FE878 File Offset: 0x002FCA78
		public byte[] GetFunctionDescArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600CA5A RID: 51802 RVA: 0x002FE890 File Offset: 0x002FCA90
		public string FirstObtainDesc
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA5B RID: 51803 RVA: 0x002FE8C8 File Offset: 0x002FCAC8
		public Span<byte> GetFirstObtainDescBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600CA5C RID: 51804 RVA: 0x002FE8D8 File Offset: 0x002FCAD8
		public byte[] GetFirstObtainDescArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600CA5D RID: 51805 RVA: 0x002FE8F0 File Offset: 0x002FCAF0
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600CA5E RID: 51806 RVA: 0x002FE930 File Offset: 0x002FCB30
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA5F RID: 51807 RVA: 0x002FE968 File Offset: 0x002FCB68
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600CA60 RID: 51808 RVA: 0x002FE978 File Offset: 0x002FCB78
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600CA61 RID: 51809 RVA: 0x002FE990 File Offset: 0x002FCB90
		public string RoleHeadIconCircle
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA62 RID: 51810 RVA: 0x002FE9C8 File Offset: 0x002FCBC8
		public Span<byte> GetRoleHeadIconCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600CA63 RID: 51811 RVA: 0x002FE9D8 File Offset: 0x002FCBD8
		public byte[] GetRoleHeadIconCircleArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600CA64 RID: 51812 RVA: 0x002FE9F0 File Offset: 0x002FCBF0
		public string RoleHeadIconLarge
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x002FEA28 File Offset: 0x002FCC28
		public Span<byte> GetRoleHeadIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x002FEA38 File Offset: 0x002FCC38
		public byte[] GetRoleHeadIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600CA67 RID: 51815 RVA: 0x002FEA50 File Offset: 0x002FCC50
		public string RoleHeadIconBig
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x002FEA88 File Offset: 0x002FCC88
		public Span<byte> GetRoleHeadIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x002FEA98 File Offset: 0x002FCC98
		public byte[] GetRoleHeadIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600CA6A RID: 51818 RVA: 0x002FEAB0 File Offset: 0x002FCCB0
		public string Card
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x002FEAE8 File Offset: 0x002FCCE8
		public Span<byte> GetCardBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600CA6C RID: 51820 RVA: 0x002FEAF8 File Offset: 0x002FCCF8
		public byte[] GetCardArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600CA6D RID: 51821 RVA: 0x002FEB10 File Offset: 0x002FCD10
		public string RoleHeadIcon
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA6E RID: 51822 RVA: 0x002FEB48 File Offset: 0x002FCD48
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600CA6F RID: 51823 RVA: 0x002FEB58 File Offset: 0x002FCD58
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600CA70 RID: 51824 RVA: 0x002FEB70 File Offset: 0x002FCD70
		public string PreviewRoleCard
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA71 RID: 51825 RVA: 0x002FEBA8 File Offset: 0x002FCDA8
		public Span<byte> GetPreviewRoleCardBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600CA72 RID: 51826 RVA: 0x002FEBB8 File Offset: 0x002FCDB8
		public byte[] GetPreviewRoleCardArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600CA73 RID: 51827 RVA: 0x002FEBD0 File Offset: 0x002FCDD0
		public string BuyShopPreviewRoleCard
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA74 RID: 51828 RVA: 0x002FEC08 File Offset: 0x002FCE08
		public Span<byte> GetBuyShopPreviewRoleCardBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600CA75 RID: 51829 RVA: 0x002FEC18 File Offset: 0x002FCE18
		public byte[] GetBuyShopPreviewRoleCardArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600CA76 RID: 51830 RVA: 0x002FEC30 File Offset: 0x002FCE30
		public string FormationRoleCard
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA77 RID: 51831 RVA: 0x002FEC68 File Offset: 0x002FCE68
		public Span<byte> GetFormationRoleCardBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600CA78 RID: 51832 RVA: 0x002FEC78 File Offset: 0x002FCE78
		public byte[] GetFormationRoleCardArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600CA79 RID: 51833 RVA: 0x002FEC90 File Offset: 0x002FCE90
		public string RoleStand
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA7A RID: 51834 RVA: 0x002FECC8 File Offset: 0x002FCEC8
		public Span<byte> GetRoleStandBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x0600CA7B RID: 51835 RVA: 0x002FECD8 File Offset: 0x002FCED8
		public byte[] GetRoleStandArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600CA7C RID: 51836 RVA: 0x002FECF0 File Offset: 0x002FCEF0
		public string SuitWeaponSkinColor
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA7D RID: 51837 RVA: 0x002FED28 File Offset: 0x002FCF28
		public Span<byte> GetSuitWeaponSkinColorBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600CA7E RID: 51838 RVA: 0x002FED38 File Offset: 0x002FCF38
		public byte[] GetSuitWeaponSkinColorArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600CA7F RID: 51839 RVA: 0x002FED50 File Offset: 0x002FCF50
		public string RoleObtainColor1
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA80 RID: 51840 RVA: 0x002FED88 File Offset: 0x002FCF88
		public Span<byte> GetRoleObtainColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600CA81 RID: 51841 RVA: 0x002FED98 File Offset: 0x002FCF98
		public byte[] GetRoleObtainColor1Array()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600CA82 RID: 51842 RVA: 0x002FEDB0 File Offset: 0x002FCFB0
		public string RoleObtainColor2
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA83 RID: 51843 RVA: 0x002FEDE8 File Offset: 0x002FCFE8
		public Span<byte> GetRoleObtainColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600CA84 RID: 51844 RVA: 0x002FEDF8 File Offset: 0x002FCFF8
		public byte[] GetRoleObtainColor2Array()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600CA85 RID: 51845 RVA: 0x002FEE10 File Offset: 0x002FD010
		public string RolePortrait
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA86 RID: 51846 RVA: 0x002FEE48 File Offset: 0x002FD048
		public Span<byte> GetRolePortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600CA87 RID: 51847 RVA: 0x002FEE58 File Offset: 0x002FD058
		public byte[] GetRolePortraitArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600CA88 RID: 51848 RVA: 0x002FEE70 File Offset: 0x002FD070
		public int MeshId
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600CA89 RID: 51849 RVA: 0x002FEEB0 File Offset: 0x002FD0B0
		public int UiMeshId
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600CA8A RID: 51850 RVA: 0x002FEEF0 File Offset: 0x002FD0F0
		public string RoleBody
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x002FEF28 File Offset: 0x002FD128
		public Span<byte> GetRoleBodyBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0600CA8C RID: 51852 RVA: 0x002FEF38 File Offset: 0x002FD138
		public byte[] GetRoleBodyArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600CA8D RID: 51853 RVA: 0x002FEF50 File Offset: 0x002FD150
		public string UiScenePerformanceABP
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA8E RID: 51854 RVA: 0x002FEF88 File Offset: 0x002FD188
		public Span<byte> GetUiScenePerformanceABPBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0600CA8F RID: 51855 RVA: 0x002FEF98 File Offset: 0x002FD198
		public byte[] GetUiScenePerformanceABPArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600CA90 RID: 51856 RVA: 0x002FEFB0 File Offset: 0x002FD1B0
		public string UiTeamABP
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x002FEFE8 File Offset: 0x002FD1E8
		public Span<byte> GetUiTeamABPBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x002FEFF8 File Offset: 0x002FD1F8
		public byte[] GetUiTeamABPArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600CA93 RID: 51859 RVA: 0x002FF010 File Offset: 0x002FD210
		public string FootStepState
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA94 RID: 51860 RVA: 0x002FF048 File Offset: 0x002FD248
		public Span<byte> GetFootStepStateBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x002FF058 File Offset: 0x002FD258
		public byte[] GetFootStepStateArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600CA96 RID: 51862 RVA: 0x002FF070 File Offset: 0x002FD270
		public string PayShopPreviewRoleTexturePath
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA97 RID: 51863 RVA: 0x002FF0A8 File Offset: 0x002FD2A8
		public Span<byte> GetPayShopPreviewRoleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600CA98 RID: 51864 RVA: 0x002FF0B8 File Offset: 0x002FD2B8
		public byte[] GetPayShopPreviewRoleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600CA99 RID: 51865 RVA: 0x002FF0D0 File Offset: 0x002FD2D0
		public string PayShopPreviewRoleTextureBgPath
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA9A RID: 51866 RVA: 0x002FF108 File Offset: 0x002FD308
		public Span<byte> GetPayShopPreviewRoleTextureBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600CA9B RID: 51867 RVA: 0x002FF118 File Offset: 0x002FD318
		public byte[] GetPayShopPreviewRoleTextureBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600CA9C RID: 51868 RVA: 0x002FF130 File Offset: 0x002FD330
		public string PayShopPreviewWeaponTexturePath
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CA9D RID: 51869 RVA: 0x002FF168 File Offset: 0x002FD368
		public Span<byte> GetPayShopPreviewWeaponTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600CA9E RID: 51870 RVA: 0x002FF178 File Offset: 0x002FD378
		public byte[] GetPayShopPreviewWeaponTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600CA9F RID: 51871 RVA: 0x002FF190 File Offset: 0x002FD390
		public string PayShopPreviewBuyRoleTexturePath
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAA0 RID: 51872 RVA: 0x002FF1C8 File Offset: 0x002FD3C8
		public Span<byte> GetPayShopPreviewBuyRoleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600CAA1 RID: 51873 RVA: 0x002FF1D8 File Offset: 0x002FD3D8
		public byte[] GetPayShopPreviewBuyRoleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600CAA2 RID: 51874 RVA: 0x002FF1F0 File Offset: 0x002FD3F0
		public string PayShopPreviewBuyRoleSuitWeaponTexturePath
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAA3 RID: 51875 RVA: 0x002FF228 File Offset: 0x002FD428
		public Span<byte> GetPayShopPreviewBuyRoleSuitWeaponTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x002FF238 File Offset: 0x002FD438
		public byte[] GetPayShopPreviewBuyRoleSuitWeaponTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600CAA5 RID: 51877 RVA: 0x002FF250 File Offset: 0x002FD450
		public string ShareTexturePath
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAA6 RID: 51878 RVA: 0x002FF288 File Offset: 0x002FD488
		public Span<byte> GetShareTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600CAA7 RID: 51879 RVA: 0x002FF298 File Offset: 0x002FD498
		public byte[] GetShareTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600CAA8 RID: 51880 RVA: 0x002FF2B0 File Offset: 0x002FD4B0
		public string SpineSkeletonData
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAA9 RID: 51881 RVA: 0x002FF2E8 File Offset: 0x002FD4E8
		public Span<byte> GetSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600CAAA RID: 51882 RVA: 0x002FF2F8 File Offset: 0x002FD4F8
		public byte[] GetSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600CAAB RID: 51883 RVA: 0x002FF310 File Offset: 0x002FD510
		public string SmallSpineAtlas
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x002FF348 File Offset: 0x002FD548
		public Span<byte> GetSmallSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x002FF358 File Offset: 0x002FD558
		public byte[] GetSmallSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CAAE RID: 51886 RVA: 0x002FF370 File Offset: 0x002FD570
		public long SkinBuff(int j)
		{
			int num = this.__p.__offset(106);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600CAAF RID: 51887 RVA: 0x002FF3BC File Offset: 0x002FD5BC
		public int SkinBuffLength
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x002FF3E8 File Offset: 0x002FD5E8
		public Span<long> GetSkinBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(106, 8));
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x002FF3FD File Offset: 0x002FD5FD
		public long[] GetSkinBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(106) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600CAB2 RID: 51890 RVA: 0x002FF43C File Offset: 0x002FD63C
		public string FormationSpineSkeletonData
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAB3 RID: 51891 RVA: 0x002FF474 File Offset: 0x002FD674
		public Span<byte> GetFormationSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600CAB4 RID: 51892 RVA: 0x002FF484 File Offset: 0x002FD684
		public byte[] GetFormationSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600CAB5 RID: 51893 RVA: 0x002FF49C File Offset: 0x002FD69C
		public string FormationSpineAtlas
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x002FF4D4 File Offset: 0x002FD6D4
		public Span<byte> GetFormationSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x002FF4E4 File Offset: 0x002FD6E4
		public byte[] GetFormationSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CAB8 RID: 51896 RVA: 0x002FF4FC File Offset: 0x002FD6FC
		public float SpineParam(int j)
		{
			int num = this.__p.__offset(112);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600CAB9 RID: 51897 RVA: 0x002FF540 File Offset: 0x002FD740
		public int SpineParamLength
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CABA RID: 51898 RVA: 0x002FF56C File Offset: 0x002FD76C
		public Span<float> GetSpineParamBytes()
		{
			return this.__p.__vector_as_span<float>(112, 4);
		}

		// Token: 0x0600CABB RID: 51899 RVA: 0x002FF57C File Offset: 0x002FD77C
		public float[] GetSpineParamArray()
		{
			return this.__p.__vector_as_array<float>(112) ?? Array.Empty<float>();
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600CABC RID: 51900 RVA: 0x002FF594 File Offset: 0x002FD794
		public Vector? FormationOffset
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0600CABD RID: 51901 RVA: 0x002FF5F4 File Offset: 0x002FD7F4
		public DicStringString? UiCameraSettingOverrides(int j)
		{
			int num = this.__p.__offset(116);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600CABE RID: 51902 RVA: 0x002FF658 File Offset: 0x002FD858
		public int UiCameraSettingOverridesLength
		{
			get
			{
				int num = this.__p.__offset(116);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CABF RID: 51903 RVA: 0x002FF684 File Offset: 0x002FD884
		public string UiModelEquipTags(int j)
		{
			int num = this.__p.__offset(118);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600CAC0 RID: 51904 RVA: 0x002FF6C0 File Offset: 0x002FD8C0
		public int UiModelEquipTagsLength
		{
			get
			{
				int num = this.__p.__offset(118);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CAC1 RID: 51905 RVA: 0x002FF6EC File Offset: 0x002FD8EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			RoleSkin roleSkin = this;
			return roleSkin.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CAC2 RID: 51906 RVA: 0x002FF710 File Offset: 0x002FD910
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			RoleSkin.<ItemAccessIter>d__216 <ItemAccessIter>d__ = new RoleSkin.<ItemAccessIter>d__216(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600CAC3 RID: 51907 RVA: 0x002FF728 File Offset: 0x002FD928
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkinBuffIter()或GetSkinBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] SkinBuff()
		{
			RoleSkin roleSkin = this;
			return roleSkin.GetSkinBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600CAC4 RID: 51908 RVA: 0x002FF74C File Offset: 0x002FD94C
		[NullableContext(1)]
		public readonly IEnumerable<long> SkinBuffIter()
		{
			RoleSkin.<SkinBuffIter>d__218 <SkinBuffIter>d__ = new RoleSkin.<SkinBuffIter>d__218(-2);
			<SkinBuffIter>d__.<>3__<>4__this = this;
			return <SkinBuffIter>d__;
		}

		// Token: 0x0600CAC5 RID: 51909 RVA: 0x002FF764 File Offset: 0x002FD964
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineParamIter()或GetSpineParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] SpineParam()
		{
			RoleSkin roleSkin = this;
			return roleSkin.GetSpineParamArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x002FF788 File Offset: 0x002FD988
		[NullableContext(1)]
		public readonly IEnumerable<float> SpineParamIter()
		{
			RoleSkin.<SpineParamIter>d__220 <SpineParamIter>d__ = new RoleSkin.<SpineParamIter>d__220(-2);
			<SpineParamIter>d__.<>3__<>4__this = this;
			return <SpineParamIter>d__;
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x002FF7A0 File Offset: 0x002FD9A0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用UiCameraSettingOverridesFrozenDict()缓存字典，遍历请使用UiCameraSettingOverridesIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> UiCameraSettingOverrides()
		{
			return this.UiCameraSettingOverridesIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x002FF7F6 File Offset: 0x002FD9F6
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> UiCameraSettingOverridesIter()
		{
			RoleSkin.<UiCameraSettingOverridesIter>d__222 <UiCameraSettingOverridesIter>d__ = new RoleSkin.<UiCameraSettingOverridesIter>d__222(-2);
			<UiCameraSettingOverridesIter>d__.<>3__<>4__this = this;
			return <UiCameraSettingOverridesIter>d__;
		}

		// Token: 0x0600CAC9 RID: 51913 RVA: 0x002FF80B File Offset: 0x002FDA0B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UiModelEquipTagsIter()或GetUiModelEquipTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] UiModelEquipTags()
		{
			return this.UiModelEquipTagsIter().ToArray<string>();
		}

		// Token: 0x0600CACA RID: 51914 RVA: 0x002FF818 File Offset: 0x002FDA18
		[NullableContext(1)]
		public readonly IEnumerable<string> UiModelEquipTagsIter()
		{
			RoleSkin.<UiModelEquipTagsIter>d__224 <UiModelEquipTagsIter>d__ = new RoleSkin.<UiModelEquipTagsIter>d__224(-2);
			<UiModelEquipTagsIter>d__.<>3__<>4__this = this;
			return <UiModelEquipTagsIter>d__;
		}

		// Token: 0x0600CACB RID: 51915 RVA: 0x002FF830 File Offset: 0x002FDA30
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetUiCameraSettingOverrides(string key)
		{
			this.EnsureUiCameraSettingOverridesCacheIfNeeded();
			string result;
			if (!this.UiCameraSettingOverridesCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CACC RID: 51916 RVA: 0x002FF858 File Offset: 0x002FDA58
		private void EnsureUiCameraSettingOverridesCacheIfNeeded()
		{
			if (this.UiCameraSettingOverridesCache != null)
			{
				return;
			}
			this.UiCameraSettingOverridesCache = this.UiCameraSettingOverridesIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CACD RID: 51917 RVA: 0x002FF8BE File Offset: 0x002FDABE
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetUiCameraSettingOverridesFrozenDict(string key)
		{
			this.EnsureUiCameraSettingOverridesCacheIfNeeded();
			return this.UiCameraSettingOverridesCache;
		}

		// Token: 0x0400515D RID: 20829
		private Table __p;

		// Token: 0x0400515E RID: 20830
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> UiCameraSettingOverridesCache;
	}
}
