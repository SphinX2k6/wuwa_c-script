using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C4A RID: 3146
	public struct ChatDialog : IFlatbufferObject
	{
		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600594F RID: 22863 RVA: 0x00211B3D File Offset: 0x0020FD3D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00211B4A File Offset: 0x0020FD4A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x00211B54 File Offset: 0x0020FD54
		public static ChatDialog GetRootAsChatDialog(ByteBuffer _bb)
		{
			return ChatDialog.GetRootAsChatDialog(_bb, default(ChatDialog));
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00211B70 File Offset: 0x0020FD70
		public static ChatDialog GetRootAsChatDialog(ByteBuffer _bb, ChatDialog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00211B8D File Offset: 0x0020FD8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x00211B9C File Offset: 0x0020FD9C
		public ChatDialog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06005955 RID: 22869 RVA: 0x00211BAC File Offset: 0x0020FDAC
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

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x00211BE8 File Offset: 0x0020FDE8
		public string BgPath
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

		// Token: 0x06005957 RID: 22871 RVA: 0x00211C1F File Offset: 0x0020FE1F
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x00211C2E File Offset: 0x0020FE2E
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06005959 RID: 22873 RVA: 0x00211C48 File Offset: 0x0020FE48
		public string SpineItemPath
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

		// Token: 0x0600595A RID: 22874 RVA: 0x00211C7F File Offset: 0x0020FE7F
		public Span<byte> GetSpineItemPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x00211C8E File Offset: 0x0020FE8E
		public byte[] GetSpineItemPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x00211CA8 File Offset: 0x0020FEA8
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

		// Token: 0x0600595D RID: 22877 RVA: 0x00211CE0 File Offset: 0x0020FEE0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600595E RID: 22878 RVA: 0x00211CF0 File Offset: 0x0020FEF0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600595F RID: 22879 RVA: 0x00211D08 File Offset: 0x0020FF08
		public string Desc
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

		// Token: 0x06005960 RID: 22880 RVA: 0x00211D40 File Offset: 0x0020FF40
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x00211D50 File Offset: 0x0020FF50
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06005962 RID: 22882 RVA: 0x00211D68 File Offset: 0x0020FF68
		public string GetWay
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

		// Token: 0x06005963 RID: 22883 RVA: 0x00211DA0 File Offset: 0x0020FFA0
		public Span<byte> GetGetWayBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00211DB0 File Offset: 0x0020FFB0
		public byte[] GetGetWayArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x00211DC8 File Offset: 0x0020FFC8
		public string Icon
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

		// Token: 0x06005966 RID: 22886 RVA: 0x00211E00 File Offset: 0x00210000
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x00211E10 File Offset: 0x00210010
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06005968 RID: 22888 RVA: 0x00211E28 File Offset: 0x00210028
		public string IconMiddle
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

		// Token: 0x06005969 RID: 22889 RVA: 0x00211E60 File Offset: 0x00210060
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x00211E70 File Offset: 0x00210070
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600596B RID: 22891 RVA: 0x00211E88 File Offset: 0x00210088
		public string IconSmall
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

		// Token: 0x0600596C RID: 22892 RVA: 0x00211EC0 File Offset: 0x002100C0
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00211ED0 File Offset: 0x002100D0
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600596E RID: 22894 RVA: 0x00211EE8 File Offset: 0x002100E8
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

		// Token: 0x0600596F RID: 22895 RVA: 0x00211F20 File Offset: 0x00210120
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00211F30 File Offset: 0x00210130
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06005971 RID: 22897 RVA: 0x00211F48 File Offset: 0x00210148
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

		// Token: 0x06005972 RID: 22898 RVA: 0x00211F80 File Offset: 0x00210180
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005973 RID: 22899 RVA: 0x00211F90 File Offset: 0x00210190
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06005974 RID: 22900 RVA: 0x00211FA8 File Offset: 0x002101A8
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

		// Token: 0x06005975 RID: 22901 RVA: 0x00211FE0 File Offset: 0x002101E0
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00211FF0 File Offset: 0x002101F0
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00212008 File Offset: 0x00210208
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06005978 RID: 22904 RVA: 0x00212048 File Offset: 0x00210248
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x00212074 File Offset: 0x00210274
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x00212084 File Offset: 0x00210284
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x0600597B RID: 22907 RVA: 0x0021209C File Offset: 0x0021029C
		public int QualityId
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

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x0600597C RID: 22908 RVA: 0x002120DC File Offset: 0x002102DC
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600597D RID: 22909 RVA: 0x0021211C File Offset: 0x0021031C
		public string TextColor
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00212154 File Offset: 0x00210354
		public Span<byte> GetTextColorBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00212164 File Offset: 0x00210364
		public byte[] GetTextColorArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x0021217C File Offset: 0x0021037C
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00212184 File Offset: 0x00210384
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			ChatDialog.<ItemAccessIter>d__68 <ItemAccessIter>d__ = new ChatDialog.<ItemAccessIter>d__68(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0400514C RID: 20812
		private Table __p;
	}
}
