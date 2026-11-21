using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BAF RID: 2991
	public struct AdventureTaskChapterV2 : IFlatbufferObject
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060049C6 RID: 18886 RVA: 0x001EE3D1 File Offset: 0x001EC5D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x001EE3DE File Offset: 0x001EC5DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x001EE3E8 File Offset: 0x001EC5E8
		public static AdventureTaskChapterV2 GetRootAsAdventureTaskChapterV2(ByteBuffer _bb)
		{
			return AdventureTaskChapterV2.GetRootAsAdventureTaskChapterV2(_bb, default(AdventureTaskChapterV2));
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x001EE404 File Offset: 0x001EC604
		public static AdventureTaskChapterV2 GetRootAsAdventureTaskChapterV2(ByteBuffer _bb, AdventureTaskChapterV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x001EE421 File Offset: 0x001EC621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x001EE430 File Offset: 0x001EC630
		public AdventureTaskChapterV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060049CC RID: 18892 RVA: 0x001EE440 File Offset: 0x001EC640
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060049CD RID: 18893 RVA: 0x001EE47C File Offset: 0x001EC67C
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060049CE RID: 18894 RVA: 0x001EE4B8 File Offset: 0x001EC6B8
		public int Sort
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060049CF RID: 18895 RVA: 0x001EE4F4 File Offset: 0x001EC6F4
		public string Name
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

		// Token: 0x060049D0 RID: 18896 RVA: 0x001EE52C File Offset: 0x001EC72C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060049D1 RID: 18897 RVA: 0x001EE53C File Offset: 0x001EC73C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x001EE554 File Offset: 0x001EC754
		public int DropId
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

		// Token: 0x060049D3 RID: 18899 RVA: 0x001EE594 File Offset: 0x001EC794
		public int Roles(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x001EE5D4 File Offset: 0x001EC7D4
		public int RolesLength
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

		// Token: 0x060049D5 RID: 18901 RVA: 0x001EE600 File Offset: 0x001EC800
		public Span<int> GetRolesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060049D6 RID: 18902 RVA: 0x001EE610 File Offset: 0x001EC810
		public int[] GetRolesArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060049D7 RID: 18903 RVA: 0x001EE628 File Offset: 0x001EC828
		public int LevelUnlockCount
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

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060049D8 RID: 18904 RVA: 0x001EE668 File Offset: 0x001EC868
		public int RewardUnlockCount
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

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060049D9 RID: 18905 RVA: 0x001EE6A8 File Offset: 0x001EC8A8
		public string LockedDesc
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

		// Token: 0x060049DA RID: 18906 RVA: 0x001EE6E0 File Offset: 0x001EC8E0
		public Span<byte> GetLockedDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x001EE6F0 File Offset: 0x001EC8F0
		public byte[] GetLockedDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060049DC RID: 18908 RVA: 0x001EE708 File Offset: 0x001EC908
		public string ChapterTitle
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

		// Token: 0x060049DD RID: 18909 RVA: 0x001EE740 File Offset: 0x001EC940
		public Span<byte> GetChapterTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x001EE750 File Offset: 0x001EC950
		public byte[] GetChapterTitleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x001EE768 File Offset: 0x001EC968
		[NullableContext(1)]
		public int[] Roles()
		{
			return this.GetRolesArray();
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x001EE770 File Offset: 0x001EC970
		[NullableContext(1)]
		public IEnumerable<int> RolesIter()
		{
			AdventureTaskChapterV2.<RolesIter>d__38 <RolesIter>d__ = new AdventureTaskChapterV2.<RolesIter>d__38(-2);
			<RolesIter>d__.<>3__<>4__this = this;
			return <RolesIter>d__;
		}

		// Token: 0x0400508D RID: 20621
		private Table __p;
	}
}
