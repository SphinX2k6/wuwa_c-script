using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAF RID: 2735
	public struct AbyssLittleRole : IFlatbufferObject
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600410F RID: 16655 RVA: 0x001C6E1E File Offset: 0x001C501E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x001C6E2B File Offset: 0x001C502B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x001C6E34 File Offset: 0x001C5034
		public static AbyssLittleRole GetRootAsAbyssLittleRole(ByteBuffer _bb)
		{
			return AbyssLittleRole.GetRootAsAbyssLittleRole(_bb, default(AbyssLittleRole));
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x001C6E50 File Offset: 0x001C5050
		public static AbyssLittleRole GetRootAsAbyssLittleRole(ByteBuffer _bb, AbyssLittleRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x001C6E6D File Offset: 0x001C506D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x001C6E7C File Offset: 0x001C507C
		public AbyssLittleRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x001C6E8C File Offset: 0x001C508C
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
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x001C6EC8 File Offset: 0x001C50C8
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
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x001C6F04 File Offset: 0x001C5104
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
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x001C6F40 File Offset: 0x001C5140
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
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x001C6F80 File Offset: 0x001C5180
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

		// Token: 0x0600411A RID: 16666 RVA: 0x001C6FB8 File Offset: 0x001C51B8
		public Span<byte> GetSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x001C6FC8 File Offset: 0x001C51C8
		public byte[] GetSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x001C6FE0 File Offset: 0x001C51E0
		public long AbyssRoleBuff(int j)
		{
			int num = this.__p.__offset(14);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x001C702C File Offset: 0x001C522C
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

		// Token: 0x0600411E RID: 16670 RVA: 0x001C7058 File Offset: 0x001C5258
		public Span<long> GetAbyssRoleBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(14, 8));
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x001C706D File Offset: 0x001C526D
		public long[] GetAbyssRoleBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(14) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x001C70AC File Offset: 0x001C52AC
		public long AbyssRolePhantomBuff(int j)
		{
			int num = this.__p.__offset(16);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06004121 RID: 16673 RVA: 0x001C70F8 File Offset: 0x001C52F8
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

		// Token: 0x06004122 RID: 16674 RVA: 0x001C7124 File Offset: 0x001C5324
		public Span<long> GetAbyssRolePhantomBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(16, 8));
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x001C7139 File Offset: 0x001C5339
		public long[] GetAbyssRolePhantomBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(16) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x001C7178 File Offset: 0x001C5378
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
		// (get) Token: 0x06004125 RID: 16677 RVA: 0x001C71B8 File Offset: 0x001C53B8
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

		// Token: 0x06004126 RID: 16678 RVA: 0x001C71E4 File Offset: 0x001C53E4
		public Span<int> GetTagListBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x001C71F4 File Offset: 0x001C53F4
		public int[] GetTagListArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06004128 RID: 16680 RVA: 0x001C720C File Offset: 0x001C540C
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

		// Token: 0x06004129 RID: 16681 RVA: 0x001C7244 File Offset: 0x001C5444
		public Span<byte> GetFormationIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x001C7254 File Offset: 0x001C5454
		public byte[] GetFormationIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x001C726C File Offset: 0x001C546C
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

		// Token: 0x0600412C RID: 16684 RVA: 0x001C72A4 File Offset: 0x001C54A4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x001C72B4 File Offset: 0x001C54B4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x001C72CC File Offset: 0x001C54CC
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

		// Token: 0x0600412F RID: 16687 RVA: 0x001C7304 File Offset: 0x001C5504
		public Span<byte> GetUnlockDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x001C7314 File Offset: 0x001C5514
		public byte[] GetUnlockDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06004131 RID: 16689 RVA: 0x001C732C File Offset: 0x001C552C
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

		// Token: 0x06004132 RID: 16690 RVA: 0x001C7364 File Offset: 0x001C5564
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x001C7374 File Offset: 0x001C5574
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x001C738C File Offset: 0x001C558C
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
		// (get) Token: 0x06004135 RID: 16693 RVA: 0x001C73CC File Offset: 0x001C55CC
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

		// Token: 0x06004136 RID: 16694 RVA: 0x001C740C File Offset: 0x001C560C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AbyssRoleBuffIter()或GetAbyssRoleBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] AbyssRoleBuff()
		{
			AbyssLittleRole abyssLittleRole = this;
			return abyssLittleRole.GetAbyssRoleBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x001C7430 File Offset: 0x001C5630
		[NullableContext(1)]
		public readonly IEnumerable<long> AbyssRoleBuffIter()
		{
			AbyssLittleRole.<AbyssRoleBuffIter>d__56 <AbyssRoleBuffIter>d__ = new AbyssLittleRole.<AbyssRoleBuffIter>d__56(-2);
			<AbyssRoleBuffIter>d__.<>3__<>4__this = this;
			return <AbyssRoleBuffIter>d__;
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x001C7448 File Offset: 0x001C5648
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AbyssRolePhantomBuffIter()或GetAbyssRolePhantomBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] AbyssRolePhantomBuff()
		{
			AbyssLittleRole abyssLittleRole = this;
			return abyssLittleRole.GetAbyssRolePhantomBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x001C746C File Offset: 0x001C566C
		[NullableContext(1)]
		public readonly IEnumerable<long> AbyssRolePhantomBuffIter()
		{
			AbyssLittleRole.<AbyssRolePhantomBuffIter>d__58 <AbyssRolePhantomBuffIter>d__ = new AbyssLittleRole.<AbyssRolePhantomBuffIter>d__58(-2);
			<AbyssRolePhantomBuffIter>d__.<>3__<>4__this = this;
			return <AbyssRolePhantomBuffIter>d__;
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x001C7484 File Offset: 0x001C5684
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagListIter()或GetTagListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TagList()
		{
			AbyssLittleRole abyssLittleRole = this;
			return abyssLittleRole.GetTagListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x001C74A8 File Offset: 0x001C56A8
		[NullableContext(1)]
		public readonly IEnumerable<int> TagListIter()
		{
			AbyssLittleRole.<TagListIter>d__60 <TagListIter>d__ = new AbyssLittleRole.<TagListIter>d__60(-2);
			<TagListIter>d__.<>3__<>4__this = this;
			return <TagListIter>d__;
		}

		// Token: 0x04004A85 RID: 19077
		private Table __p;
	}
}
