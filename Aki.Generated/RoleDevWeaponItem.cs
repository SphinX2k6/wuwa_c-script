using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001131 RID: 4401
	public struct RoleDevWeaponItem : IFlatbufferObject
	{
		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600CEAA RID: 52906 RVA: 0x00315C9D File Offset: 0x00313E9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CEAB RID: 52907 RVA: 0x00315CAA File Offset: 0x00313EAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CEAC RID: 52908 RVA: 0x00315CB4 File Offset: 0x00313EB4
		public static RoleDevWeaponItem GetRootAsRoleDevWeaponItem(ByteBuffer _bb)
		{
			return RoleDevWeaponItem.GetRootAsRoleDevWeaponItem(_bb, default(RoleDevWeaponItem));
		}

		// Token: 0x0600CEAD RID: 52909 RVA: 0x00315CD0 File Offset: 0x00313ED0
		public static RoleDevWeaponItem GetRootAsRoleDevWeaponItem(ByteBuffer _bb, RoleDevWeaponItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CEAE RID: 52910 RVA: 0x00315CED File Offset: 0x00313EED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CEAF RID: 52911 RVA: 0x00315CFC File Offset: 0x00313EFC
		public RoleDevWeaponItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032D3 RID: 13011
		// (get) Token: 0x0600CEB0 RID: 52912 RVA: 0x00315D0C File Offset: 0x00313F0C
		public int WeaponType
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

		// Token: 0x170032D4 RID: 13012
		// (get) Token: 0x0600CEB1 RID: 52913 RVA: 0x00315D48 File Offset: 0x00313F48
		public int WeaponItemGroup
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

		// Token: 0x0600CEB2 RID: 52914 RVA: 0x00315D84 File Offset: 0x00313F84
		public int WeaponTypeExperience(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600CEB3 RID: 52915 RVA: 0x00315DC4 File Offset: 0x00313FC4
		public int WeaponTypeExperienceLength
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

		// Token: 0x0600CEB4 RID: 52916 RVA: 0x00315DEF File Offset: 0x00313FEF
		public Span<int> GetWeaponTypeExperienceBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600CEB5 RID: 52917 RVA: 0x00315DFE File Offset: 0x00313FFE
		public int[] GetWeaponTypeExperienceArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600CEB6 RID: 52918 RVA: 0x00315E18 File Offset: 0x00314018
		public string WeaponTypeIcon
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

		// Token: 0x0600CEB7 RID: 52919 RVA: 0x00315E50 File Offset: 0x00314050
		public Span<byte> GetWeaponTypeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CEB8 RID: 52920 RVA: 0x00315E60 File Offset: 0x00314060
		public byte[] GetWeaponTypeIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600CEB9 RID: 52921 RVA: 0x00315E78 File Offset: 0x00314078
		public string WeaponTypeDescribe
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

		// Token: 0x0600CEBA RID: 52922 RVA: 0x00315EB0 File Offset: 0x003140B0
		public Span<byte> GetWeaponTypeDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CEBB RID: 52923 RVA: 0x00315EC0 File Offset: 0x003140C0
		public byte[] GetWeaponTypeDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CEBC RID: 52924 RVA: 0x00315ED8 File Offset: 0x003140D8
		[NullableContext(1)]
		public int[] WeaponTypeExperience()
		{
			return this.GetWeaponTypeExperienceArray();
		}

		// Token: 0x0600CEBD RID: 52925 RVA: 0x00315EE0 File Offset: 0x003140E0
		[NullableContext(1)]
		public IEnumerable<int> WeaponTypeExperienceIter()
		{
			RoleDevWeaponItem.<WeaponTypeExperienceIter>d__26 <WeaponTypeExperienceIter>d__ = new RoleDevWeaponItem.<WeaponTypeExperienceIter>d__26(-2);
			<WeaponTypeExperienceIter>d__.<>3__<>4__this = this;
			return <WeaponTypeExperienceIter>d__;
		}

		// Token: 0x0400572F RID: 22319
		private Table __p;
	}
}
