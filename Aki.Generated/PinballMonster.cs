using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F2F RID: 3887
	public struct PinballMonster : IFlatbufferObject
	{
		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x0600AF3F RID: 44863 RVA: 0x002C27A1 File Offset: 0x002C09A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AF40 RID: 44864 RVA: 0x002C27AE File Offset: 0x002C09AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AF41 RID: 44865 RVA: 0x002C27B8 File Offset: 0x002C09B8
		public static PinballMonster GetRootAsPinballMonster(ByteBuffer _bb)
		{
			return PinballMonster.GetRootAsPinballMonster(_bb, default(PinballMonster));
		}

		// Token: 0x0600AF42 RID: 44866 RVA: 0x002C27D4 File Offset: 0x002C09D4
		public static PinballMonster GetRootAsPinballMonster(ByteBuffer _bb, PinballMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x002C27F1 File Offset: 0x002C09F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AF44 RID: 44868 RVA: 0x002C2800 File Offset: 0x002C0A00
		public PinballMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600AF45 RID: 44869 RVA: 0x002C2810 File Offset: 0x002C0A10
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

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600AF46 RID: 44870 RVA: 0x002C284C File Offset: 0x002C0A4C
		public int SimpleCombatSubtypeId
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

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600AF47 RID: 44871 RVA: 0x002C2888 File Offset: 0x002C0A88
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF48 RID: 44872 RVA: 0x002C28BF File Offset: 0x002C0ABF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AF49 RID: 44873 RVA: 0x002C28CE File Offset: 0x002C0ACE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x002C28E8 File Offset: 0x002C0AE8
		public string Desc
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

		// Token: 0x0600AF4B RID: 44875 RVA: 0x002C2920 File Offset: 0x002C0B20
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AF4C RID: 44876 RVA: 0x002C2930 File Offset: 0x002C0B30
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AF4D RID: 44877 RVA: 0x002C2948 File Offset: 0x002C0B48
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x002C2984 File Offset: 0x002C0B84
		public int DescArgsLength
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

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x0600AF4F RID: 44879 RVA: 0x002C29B0 File Offset: 0x002C0BB0
		public int MonsterType
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

		// Token: 0x0600AF50 RID: 44880 RVA: 0x002C29F0 File Offset: 0x002C0BF0
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x0600AF51 RID: 44881 RVA: 0x002C2A30 File Offset: 0x002C0C30
		public int InitBuffsLength
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

		// Token: 0x0600AF52 RID: 44882 RVA: 0x002C2A5C File Offset: 0x002C0C5C
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600AF53 RID: 44883 RVA: 0x002C2A6C File Offset: 0x002C0C6C
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x002C2A84 File Offset: 0x002C0C84
		public int Deathrattle
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

		// Token: 0x0600AF55 RID: 44885 RVA: 0x002C2AC4 File Offset: 0x002C0CC4
		public int Tag(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x002C2B04 File Offset: 0x002C0D04
		public int TagLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x002C2B30 File Offset: 0x002C0D30
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600AF58 RID: 44888 RVA: 0x002C2B40 File Offset: 0x002C0D40
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600AF59 RID: 44889 RVA: 0x002C2B58 File Offset: 0x002C0D58
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x0600AF5A RID: 44890 RVA: 0x002C2B98 File Offset: 0x002C0D98
		public int AttrShowLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x002C2BC4 File Offset: 0x002C0DC4
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x002C2BD4 File Offset: 0x002C0DD4
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x0600AF5D RID: 44893 RVA: 0x002C2BEC File Offset: 0x002C0DEC
		public int Prop
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

		// Token: 0x0600AF5E RID: 44894 RVA: 0x002C2C2C File Offset: 0x002C0E2C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttrShowIter()或GetAttrShowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttrShow()
		{
			PinballMonster pinballMonster = this;
			return pinballMonster.GetAttrShowArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AF5F RID: 44895 RVA: 0x002C2C50 File Offset: 0x002C0E50
		[NullableContext(1)]
		public readonly IEnumerable<int> AttrShowIter()
		{
			PinballMonster.<AttrShowIter>d__45 <AttrShowIter>d__ = new PinballMonster.<AttrShowIter>d__45(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x0600AF60 RID: 44896 RVA: 0x002C2C65 File Offset: 0x002C0E65
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescArgsIter()或GetDescArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x0600AF61 RID: 44897 RVA: 0x002C2C72 File Offset: 0x002C0E72
		[NullableContext(1)]
		public readonly IEnumerable<string> DescArgsIter()
		{
			PinballMonster.<DescArgsIter>d__47 <DescArgsIter>d__ = new PinballMonster.<DescArgsIter>d__47(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x0600AF62 RID: 44898 RVA: 0x002C2C88 File Offset: 0x002C0E88
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			PinballMonster pinballMonster = this;
			return pinballMonster.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AF63 RID: 44899 RVA: 0x002C2CAC File Offset: 0x002C0EAC
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			PinballMonster.<InitBuffsIter>d__49 <InitBuffsIter>d__ = new PinballMonster.<InitBuffsIter>d__49(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x002C2CC4 File Offset: 0x002C0EC4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIter()或GetTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Tag()
		{
			PinballMonster pinballMonster = this;
			return pinballMonster.GetTagArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AF65 RID: 44901 RVA: 0x002C2CE8 File Offset: 0x002C0EE8
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIter()
		{
			PinballMonster.<TagIter>d__51 <TagIter>d__ = new PinballMonster.<TagIter>d__51(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x04004FF9 RID: 20473
		private Table __p;
	}
}
