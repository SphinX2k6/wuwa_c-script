using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001127 RID: 4391
	public struct RoleDevCulProjectConfig : IFlatbufferObject
	{
		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600CDE4 RID: 52708 RVA: 0x00314380 File Offset: 0x00312580
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CDE5 RID: 52709 RVA: 0x0031438D File Offset: 0x0031258D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CDE6 RID: 52710 RVA: 0x00314394 File Offset: 0x00312594
		public static RoleDevCulProjectConfig GetRootAsRoleDevCulProjectConfig(ByteBuffer _bb)
		{
			return RoleDevCulProjectConfig.GetRootAsRoleDevCulProjectConfig(_bb, default(RoleDevCulProjectConfig));
		}

		// Token: 0x0600CDE7 RID: 52711 RVA: 0x003143B0 File Offset: 0x003125B0
		public static RoleDevCulProjectConfig GetRootAsRoleDevCulProjectConfig(ByteBuffer _bb, RoleDevCulProjectConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CDE8 RID: 52712 RVA: 0x003143CD File Offset: 0x003125CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CDE9 RID: 52713 RVA: 0x003143DC File Offset: 0x003125DC
		public RoleDevCulProjectConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x003143EC File Offset: 0x003125EC
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

		// Token: 0x0600CDEB RID: 52715 RVA: 0x00314428 File Offset: 0x00312628
		public int RoleLvUp(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600CDEC RID: 52716 RVA: 0x00314468 File Offset: 0x00312668
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

		// Token: 0x0600CDED RID: 52717 RVA: 0x00314493 File Offset: 0x00312693
		public Span<int> GetRoleLvUpBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CDEE RID: 52718 RVA: 0x003144A2 File Offset: 0x003126A2
		public int[] GetRoleLvUpArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600CDEF RID: 52719 RVA: 0x003144BC File Offset: 0x003126BC
		public int WeaponLvUp(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600CDF0 RID: 52720 RVA: 0x003144FC File Offset: 0x003126FC
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

		// Token: 0x0600CDF1 RID: 52721 RVA: 0x00314527 File Offset: 0x00312727
		public Span<int> GetWeaponLvUpBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600CDF2 RID: 52722 RVA: 0x00314536 File Offset: 0x00312736
		public int[] GetWeaponLvUpArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600CDF3 RID: 52723 RVA: 0x00314550 File Offset: 0x00312750
		public int SkillLvUp(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x00314590 File Offset: 0x00312790
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

		// Token: 0x0600CDF5 RID: 52725 RVA: 0x003145BC File Offset: 0x003127BC
		public Span<int> GetSkillLvUpBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600CDF6 RID: 52726 RVA: 0x003145CC File Offset: 0x003127CC
		public int[] GetSkillLvUpArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600CDF7 RID: 52727 RVA: 0x003145E4 File Offset: 0x003127E4
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

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600CDF8 RID: 52728 RVA: 0x00314624 File Offset: 0x00312824
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

		// Token: 0x0600CDF9 RID: 52729 RVA: 0x0031465C File Offset: 0x0031285C
		public Span<byte> GetUnknownItemIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CDFA RID: 52730 RVA: 0x0031466C File Offset: 0x0031286C
		public byte[] GetUnknownItemIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600CDFB RID: 52731 RVA: 0x00314684 File Offset: 0x00312884
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

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600CDFC RID: 52732 RVA: 0x003146C4 File Offset: 0x003128C4
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

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600CDFD RID: 52733 RVA: 0x00314704 File Offset: 0x00312904
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

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600CDFE RID: 52734 RVA: 0x00314744 File Offset: 0x00312944
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

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600CDFF RID: 52735 RVA: 0x00314784 File Offset: 0x00312984
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

		// Token: 0x0600CE00 RID: 52736 RVA: 0x003147C4 File Offset: 0x003129C4
		public int PhantomSpecialGroupList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600CE01 RID: 52737 RVA: 0x00314804 File Offset: 0x00312A04
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

		// Token: 0x0600CE02 RID: 52738 RVA: 0x00314830 File Offset: 0x00312A30
		public Span<int> GetPhantomSpecialGroupListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600CE03 RID: 52739 RVA: 0x00314840 File Offset: 0x00312A40
		public int[] GetPhantomSpecialGroupListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600CE04 RID: 52740 RVA: 0x00314858 File Offset: 0x00312A58
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

		// Token: 0x0600CE05 RID: 52741 RVA: 0x00314895 File Offset: 0x00312A95
		[NullableContext(1)]
		public int[] PhantomSpecialGroupList()
		{
			return this.GetPhantomSpecialGroupListArray();
		}

		// Token: 0x0600CE06 RID: 52742 RVA: 0x0031489D File Offset: 0x00312A9D
		[NullableContext(1)]
		public IEnumerable<int> PhantomSpecialGroupListIter()
		{
			RoleDevCulProjectConfig.<PhantomSpecialGroupListIter>d__49 <PhantomSpecialGroupListIter>d__ = new RoleDevCulProjectConfig.<PhantomSpecialGroupListIter>d__49(-2);
			<PhantomSpecialGroupListIter>d__.<>3__<>4__this = this;
			return <PhantomSpecialGroupListIter>d__;
		}

		// Token: 0x0600CE07 RID: 52743 RVA: 0x003148B2 File Offset: 0x00312AB2
		[NullableContext(1)]
		public int[] RoleLvUp()
		{
			return this.GetRoleLvUpArray();
		}

		// Token: 0x0600CE08 RID: 52744 RVA: 0x003148BA File Offset: 0x00312ABA
		[NullableContext(1)]
		public IEnumerable<int> RoleLvUpIter()
		{
			RoleDevCulProjectConfig.<RoleLvUpIter>d__51 <RoleLvUpIter>d__ = new RoleDevCulProjectConfig.<RoleLvUpIter>d__51(-2);
			<RoleLvUpIter>d__.<>3__<>4__this = this;
			return <RoleLvUpIter>d__;
		}

		// Token: 0x0600CE09 RID: 52745 RVA: 0x003148CF File Offset: 0x00312ACF
		[NullableContext(1)]
		public int[] SkillLvUp()
		{
			return this.GetSkillLvUpArray();
		}

		// Token: 0x0600CE0A RID: 52746 RVA: 0x003148D7 File Offset: 0x00312AD7
		[NullableContext(1)]
		public IEnumerable<int> SkillLvUpIter()
		{
			RoleDevCulProjectConfig.<SkillLvUpIter>d__53 <SkillLvUpIter>d__ = new RoleDevCulProjectConfig.<SkillLvUpIter>d__53(-2);
			<SkillLvUpIter>d__.<>3__<>4__this = this;
			return <SkillLvUpIter>d__;
		}

		// Token: 0x0600CE0B RID: 52747 RVA: 0x003148EC File Offset: 0x00312AEC
		[NullableContext(1)]
		public int[] WeaponLvUp()
		{
			return this.GetWeaponLvUpArray();
		}

		// Token: 0x0600CE0C RID: 52748 RVA: 0x003148F4 File Offset: 0x00312AF4
		[NullableContext(1)]
		public IEnumerable<int> WeaponLvUpIter()
		{
			RoleDevCulProjectConfig.<WeaponLvUpIter>d__55 <WeaponLvUpIter>d__ = new RoleDevCulProjectConfig.<WeaponLvUpIter>d__55(-2);
			<WeaponLvUpIter>d__.<>3__<>4__this = this;
			return <WeaponLvUpIter>d__;
		}

		// Token: 0x04005725 RID: 22309
		private Table __p;
	}
}
