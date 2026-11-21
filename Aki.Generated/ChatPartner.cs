using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4E RID: 3150
	public struct ChatPartner : IFlatbufferObject
	{
		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060059AA RID: 22954 RVA: 0x0021260D File Offset: 0x0021080D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x0021261A File Offset: 0x0021081A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00212624 File Offset: 0x00210824
		public static ChatPartner GetRootAsChatPartner(ByteBuffer _bb)
		{
			return ChatPartner.GetRootAsChatPartner(_bb, default(ChatPartner));
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x00212640 File Offset: 0x00210840
		public static ChatPartner GetRootAsChatPartner(ByteBuffer _bb, ChatPartner obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x0021265D File Offset: 0x0021085D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x0021266C File Offset: 0x0021086C
		public ChatPartner __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060059B0 RID: 22960 RVA: 0x0021267C File Offset: 0x0021087C
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

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060059B1 RID: 22961 RVA: 0x002126B8 File Offset: 0x002108B8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x002126EF File Offset: 0x002108EF
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x002126FE File Offset: 0x002108FE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060059B4 RID: 22964 RVA: 0x00212718 File Offset: 0x00210918
		public string IconMid
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

		// Token: 0x060059B5 RID: 22965 RVA: 0x0021274F File Offset: 0x0021094F
		public Span<byte> GetIconMidBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x0021275E File Offset: 0x0021095E
		public byte[] GetIconMidArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060059B7 RID: 22967 RVA: 0x00212778 File Offset: 0x00210978
		public string IconSmall
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

		// Token: 0x060059B8 RID: 22968 RVA: 0x002127B0 File Offset: 0x002109B0
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x002127C0 File Offset: 0x002109C0
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060059BA RID: 22970 RVA: 0x002127D8 File Offset: 0x002109D8
		public string Name
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

		// Token: 0x060059BB RID: 22971 RVA: 0x00212810 File Offset: 0x00210A10
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x00212820 File Offset: 0x00210A20
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060059BD RID: 22973 RVA: 0x00212838 File Offset: 0x00210A38
		public bool IsGroupChat
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060059BE RID: 22974 RVA: 0x00212878 File Offset: 0x00210A78
		public string Desc
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

		// Token: 0x060059BF RID: 22975 RVA: 0x002128B0 File Offset: 0x00210AB0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x002128C0 File Offset: 0x00210AC0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060059C1 RID: 22977 RVA: 0x002128D8 File Offset: 0x00210AD8
		public int PeopleNum
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

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060059C2 RID: 22978 RVA: 0x00212918 File Offset: 0x00210B18
		public int TypeFilter
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1001;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x0021295C File Offset: 0x00210B5C
		public int RegionFilterList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060059C4 RID: 22980 RVA: 0x0021299C File Offset: 0x00210B9C
		public int RegionFilterListLength
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

		// Token: 0x060059C5 RID: 22981 RVA: 0x002129C8 File Offset: 0x00210BC8
		public Span<int> GetRegionFilterListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x002129D8 File Offset: 0x00210BD8
		public int[] GetRegionFilterListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x002129F0 File Offset: 0x00210BF0
		[NullableContext(1)]
		public int[] RegionFilterList()
		{
			return this.GetRegionFilterListArray();
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x002129F8 File Offset: 0x00210BF8
		[NullableContext(1)]
		public IEnumerable<int> RegionFilterListIter()
		{
			ChatPartner.<RegionFilterListIter>d__42 <RegionFilterListIter>d__ = new ChatPartner.<RegionFilterListIter>d__42(-2);
			<RegionFilterListIter>d__.<>3__<>4__this = this;
			return <RegionFilterListIter>d__;
		}

		// Token: 0x04005150 RID: 20816
		private Table __p;
	}
}
