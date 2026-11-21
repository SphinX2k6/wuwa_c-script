using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B84 RID: 2948
	public struct AbyssLittleRole : IFlatbufferObject
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x001E60DE File Offset: 0x001E42DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x001E60EB File Offset: 0x001E42EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x001E60F4 File Offset: 0x001E42F4
		public static AbyssLittleRole GetRootAsAbyssLittleRole(ByteBuffer _bb)
		{
			return AbyssLittleRole.GetRootAsAbyssLittleRole(_bb, default(AbyssLittleRole));
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x001E6110 File Offset: 0x001E4310
		public static AbyssLittleRole GetRootAsAbyssLittleRole(ByteBuffer _bb, AbyssLittleRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x001E612D File Offset: 0x001E432D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x001E613C File Offset: 0x001E433C
		public AbyssLittleRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x001E614C File Offset: 0x001E434C
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x001E6188 File Offset: 0x001E4388
		public int ActivityId
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x001E61C4 File Offset: 0x001E43C4
		public int CastType
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

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06004616 RID: 17942 RVA: 0x001E6200 File Offset: 0x001E4400
		public int LevelGroupId
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

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x001E6240 File Offset: 0x001E4440
		public string SkillDesc
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

		// Token: 0x06004618 RID: 17944 RVA: 0x001E6278 File Offset: 0x001E4478
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x001E6288 File Offset: 0x001E4488
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x001E62A0 File Offset: 0x001E44A0
		public long AbyssRoleBuff(int j)
		{
			int num = this.__p.__offset(14);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x001E62EC File Offset: 0x001E44EC
		public int AbyssRoleBuffLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x001E6318 File Offset: 0x001E4518
		public Span<long> GetAbyssRoleBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(14, 8));
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x001E632D File Offset: 0x001E452D
		public long[] GetAbyssRoleBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(14) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x001E636C File Offset: 0x001E456C
		public long AbyssRolePhantomBuff(int j)
		{
			int num = this.__p.__offset(16);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x001E63B8 File Offset: 0x001E45B8
		public int AbyssRolePhantomBuffLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x001E63E4 File Offset: 0x001E45E4
		public Span<long> GetAbyssRolePhantomBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(16, 8));
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x001E63F9 File Offset: 0x001E45F9
		public long[] GetAbyssRolePhantomBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(16) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x001E6438 File Offset: 0x001E4638
		public int TagList(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x001E6478 File Offset: 0x001E4678
		public int TagListLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x001E64A4 File Offset: 0x001E46A4
		public Span<int> GetTagListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x001E64B4 File Offset: 0x001E46B4
		public int[] GetTagListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x001E64CC File Offset: 0x001E46CC
		public string FormationIcon
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

		// Token: 0x06004627 RID: 17959 RVA: 0x001E6504 File Offset: 0x001E4704
		public Span<byte> GetFormationIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x001E6514 File Offset: 0x001E4714
		public byte[] GetFormationIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x001E652C File Offset: 0x001E472C
		public string Icon
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

		// Token: 0x0600462A RID: 17962 RVA: 0x001E6564 File Offset: 0x001E4764
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x001E6574 File Offset: 0x001E4774
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x001E658C File Offset: 0x001E478C
		public string UnlockDesc
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

		// Token: 0x0600462D RID: 17965 RVA: 0x001E65C4 File Offset: 0x001E47C4
		public Span<byte> GetUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x001E65D4 File Offset: 0x001E47D4
		public byte[] GetUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600462F RID: 17967 RVA: 0x001E65EC File Offset: 0x001E47EC
		public string Name
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

		// Token: 0x06004630 RID: 17968 RVA: 0x001E6624 File Offset: 0x001E4824
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x001E6634 File Offset: 0x001E4834
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x001E664C File Offset: 0x001E484C
		public int Quality
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06004633 RID: 17971 RVA: 0x001E668C File Offset: 0x001E488C
		public int PhantomItemId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x001E66C9 File Offset: 0x001E48C9
		[NullableContext(1)]
		public long[] AbyssRoleBuff()
		{
			return this.GetAbyssRoleBuffArray();
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x001E66D1 File Offset: 0x001E48D1
		[NullableContext(1)]
		public IEnumerable<long> AbyssRoleBuffIter()
		{
			AbyssLittleRole.<AbyssRoleBuffIter>d__56 <AbyssRoleBuffIter>d__ = new AbyssLittleRole.<AbyssRoleBuffIter>d__56(-2);
			<AbyssRoleBuffIter>d__.<>3__<>4__this = this;
			return <AbyssRoleBuffIter>d__;
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x001E66E6 File Offset: 0x001E48E6
		[NullableContext(1)]
		public long[] AbyssRolePhantomBuff()
		{
			return this.GetAbyssRolePhantomBuffArray();
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x001E66EE File Offset: 0x001E48EE
		[NullableContext(1)]
		public IEnumerable<long> AbyssRolePhantomBuffIter()
		{
			AbyssLittleRole.<AbyssRolePhantomBuffIter>d__58 <AbyssRolePhantomBuffIter>d__ = new AbyssLittleRole.<AbyssRolePhantomBuffIter>d__58(-2);
			<AbyssRolePhantomBuffIter>d__.<>3__<>4__this = this;
			return <AbyssRolePhantomBuffIter>d__;
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x001E6703 File Offset: 0x001E4903
		[NullableContext(1)]
		public int[] TagList()
		{
			return this.GetTagListArray();
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x001E670B File Offset: 0x001E490B
		[NullableContext(1)]
		public IEnumerable<int> TagListIter()
		{
			AbyssLittleRole.<TagListIter>d__60 <TagListIter>d__ = new AbyssLittleRole.<TagListIter>d__60(-2);
			<TagListIter>d__.<>3__<>4__this = this;
			return <TagListIter>d__;
		}

		// Token: 0x04005058 RID: 20568
		private Table __p;
	}
}
