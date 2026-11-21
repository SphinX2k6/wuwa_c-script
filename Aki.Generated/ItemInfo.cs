using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E66 RID: 3686
	public struct ItemInfo : IFlatbufferObject
	{
		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06008C94 RID: 35988 RVA: 0x002843A9 File Offset: 0x002825A9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x002843B6 File Offset: 0x002825B6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x002843C0 File Offset: 0x002825C0
		public static ItemInfo GetRootAsItemInfo(ByteBuffer _bb)
		{
			return ItemInfo.GetRootAsItemInfo(_bb, default(ItemInfo));
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x002843DC File Offset: 0x002825DC
		public static ItemInfo GetRootAsItemInfo(ByteBuffer _bb, ItemInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x002843F9 File Offset: 0x002825F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x00284408 File Offset: 0x00282608
		public ItemInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06008C9A RID: 35994 RVA: 0x00284418 File Offset: 0x00282618
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

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06008C9B RID: 35995 RVA: 0x00284454 File Offset: 0x00282654
		public int ItemType
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

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06008C9C RID: 35996 RVA: 0x00284490 File Offset: 0x00282690
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

		// Token: 0x06008C9D RID: 35997 RVA: 0x002844C7 File Offset: 0x002826C7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008C9E RID: 35998 RVA: 0x002844D6 File Offset: 0x002826D6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x002844F0 File Offset: 0x002826F0
		public int ShowTypes(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06008CA0 RID: 36000 RVA: 0x00284530 File Offset: 0x00282730
		public int ShowTypesLength
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

		// Token: 0x06008CA1 RID: 36001 RVA: 0x0028455C File Offset: 0x0028275C
		public Span<int> GetShowTypesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008CA2 RID: 36002 RVA: 0x0028456C File Offset: 0x0028276C
		public int[] GetShowTypesArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06008CA3 RID: 36003 RVA: 0x00284584 File Offset: 0x00282784
		public string AttributesDescription
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

		// Token: 0x06008CA4 RID: 36004 RVA: 0x002845BC File Offset: 0x002827BC
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x002845CC File Offset: 0x002827CC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06008CA6 RID: 36006 RVA: 0x002845E4 File Offset: 0x002827E4
		public string BgDescription
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

		// Token: 0x06008CA7 RID: 36007 RVA: 0x0028461C File Offset: 0x0028281C
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008CA8 RID: 36008 RVA: 0x0028462C File Offset: 0x0028282C
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06008CA9 RID: 36009 RVA: 0x00284644 File Offset: 0x00282844
		public string ObtainedShowDescription
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

		// Token: 0x06008CAA RID: 36010 RVA: 0x0028467C File Offset: 0x0028287C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x0028468C File Offset: 0x0028288C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06008CAC RID: 36012 RVA: 0x002846A4 File Offset: 0x002828A4
		public int ObtainedShow
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

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06008CAD RID: 36013 RVA: 0x002846E4 File Offset: 0x002828E4
		public string Icon
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

		// Token: 0x06008CAE RID: 36014 RVA: 0x0028471C File Offset: 0x0028291C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x0028472C File Offset: 0x0028292C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06008CB0 RID: 36016 RVA: 0x00284744 File Offset: 0x00282944
		public string IconMiddle
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

		// Token: 0x06008CB1 RID: 36017 RVA: 0x0028477C File Offset: 0x0028297C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008CB2 RID: 36018 RVA: 0x0028478C File Offset: 0x0028298C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06008CB3 RID: 36019 RVA: 0x002847A4 File Offset: 0x002829A4
		public string IconSmall
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

		// Token: 0x06008CB4 RID: 36020 RVA: 0x002847DC File Offset: 0x002829DC
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x002847EC File Offset: 0x002829EC
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06008CB6 RID: 36022 RVA: 0x00284804 File Offset: 0x00282A04
		public string Mesh
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

		// Token: 0x06008CB7 RID: 36023 RVA: 0x0028483C File Offset: 0x00282A3C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x0028484C File Offset: 0x00282A4C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06008CB9 RID: 36025 RVA: 0x00284864 File Offset: 0x00282A64
		public int QualityId
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

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06008CBA RID: 36026 RVA: 0x002848A4 File Offset: 0x00282AA4
		public int MainTypeId
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

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06008CBB RID: 36027 RVA: 0x002848E4 File Offset: 0x00282AE4
		public int RedDotDisableRule
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

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06008CBC RID: 36028 RVA: 0x00284924 File Offset: 0x00282B24
		public int UseCountLimit
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

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06008CBD RID: 36029 RVA: 0x00284964 File Offset: 0x00282B64
		public int SortIndex
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

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06008CBE RID: 36030 RVA: 0x002849A4 File Offset: 0x00282BA4
		public int MaxCapcity
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 999999999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06008CBF RID: 36031 RVA: 0x002849E8 File Offset: 0x00282BE8
		public int MaxStackableNum
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 99999999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008CC0 RID: 36032 RVA: 0x00284A2C File Offset: 0x00282C2C
		public DicIntInt? DecomposeInfo(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x00284A90 File Offset: 0x00282C90
		public int DecomposeInfoLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06008CC2 RID: 36034 RVA: 0x00284ABC File Offset: 0x00282CBC
		public int UseLevel
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06008CC3 RID: 36035 RVA: 0x00284AFC File Offset: 0x00282CFC
		public int BeginTimeStamp
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06008CC4 RID: 36036 RVA: 0x00284B3C File Offset: 0x00282D3C
		public int DurationStamp
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

		// Token: 0x06008CC5 RID: 36037 RVA: 0x00284B7C File Offset: 0x00282D7C
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06008CC6 RID: 36038 RVA: 0x00284BBC File Offset: 0x00282DBC
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x00284BE8 File Offset: 0x00282DE8
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x00284BF8 File Offset: 0x00282DF8
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x00284C10 File Offset: 0x00282E10
		public DicIntInt? Parameters(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06008CCA RID: 36042 RVA: 0x00284C74 File Offset: 0x00282E74
		public int ParametersLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06008CCB RID: 36043 RVA: 0x00284CA0 File Offset: 0x00282EA0
		public bool ShowUseButton
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x00284CE0 File Offset: 0x00282EE0
		public int CompositeItem(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06008CCD RID: 36045 RVA: 0x00284D20 File Offset: 0x00282F20
		public int CompositeItemLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008CCE RID: 36046 RVA: 0x00284D4C File Offset: 0x00282F4C
		public Span<int> GetCompositeItemBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x06008CCF RID: 36047 RVA: 0x00284D5C File Offset: 0x00282F5C
		public int[] GetCompositeItemArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06008CD0 RID: 36048 RVA: 0x00284D74 File Offset: 0x00282F74
		public int EntityConfig
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06008CD1 RID: 36049 RVA: 0x00284DB4 File Offset: 0x00282FB4
		public int NumLimit
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06008CD2 RID: 36050 RVA: 0x00284DF4 File Offset: 0x00282FF4
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(62);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06008CD3 RID: 36051 RVA: 0x00284E34 File Offset: 0x00283034
		public DicIntInt? ConvertItems(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06008CD4 RID: 36052 RVA: 0x00284E98 File Offset: 0x00283098
		public int ConvertItemsLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06008CD5 RID: 36053 RVA: 0x00284EC4 File Offset: 0x002830C4
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06008CD6 RID: 36054 RVA: 0x00284F04 File Offset: 0x00283104
		public int ItemBuffType
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06008CD7 RID: 36055 RVA: 0x00284F44 File Offset: 0x00283144
		public bool SpecialItem
		{
			get
			{
				int num = this.__p.__offset(70);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06008CD8 RID: 36056 RVA: 0x00284F84 File Offset: 0x00283184
		public bool UiPlayItem
		{
			get
			{
				int num = this.__p.__offset(72);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06008CD9 RID: 36057 RVA: 0x00284FC4 File Offset: 0x002831C4
		public bool IsBuffItem
		{
			get
			{
				int num = this.__p.__offset(74);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06008CDA RID: 36058 RVA: 0x00285004 File Offset: 0x00283204
		public int RestrictConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008CDB RID: 36059 RVA: 0x00285041 File Offset: 0x00283241
		[NullableContext(1)]
		public int[] CompositeItem()
		{
			return this.GetCompositeItemArray();
		}

		// Token: 0x06008CDC RID: 36060 RVA: 0x00285049 File Offset: 0x00283249
		[NullableContext(1)]
		public IEnumerable<int> CompositeItemIter()
		{
			ItemInfo.<CompositeItemIter>d__111 <CompositeItemIter>d__ = new ItemInfo.<CompositeItemIter>d__111(-2);
			<CompositeItemIter>d__.<>3__<>4__this = this;
			return <CompositeItemIter>d__;
		}

		// Token: 0x06008CDD RID: 36061 RVA: 0x00285060 File Offset: 0x00283260
		[NullableContext(1)]
		public Dictionary<int, int> ConvertItems()
		{
			return this.ConvertItemsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008CDE RID: 36062 RVA: 0x002850B6 File Offset: 0x002832B6
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConvertItemsIter()
		{
			ItemInfo.<ConvertItemsIter>d__113 <ConvertItemsIter>d__ = new ItemInfo.<ConvertItemsIter>d__113(-2);
			<ConvertItemsIter>d__.<>3__<>4__this = this;
			return <ConvertItemsIter>d__;
		}

		// Token: 0x06008CDF RID: 36063 RVA: 0x002850CC File Offset: 0x002832CC
		[NullableContext(1)]
		public Dictionary<int, int> DecomposeInfo()
		{
			return this.DecomposeInfoIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008CE0 RID: 36064 RVA: 0x00285122 File Offset: 0x00283322
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DecomposeInfoIter()
		{
			ItemInfo.<DecomposeInfoIter>d__115 <DecomposeInfoIter>d__ = new ItemInfo.<DecomposeInfoIter>d__115(-2);
			<DecomposeInfoIter>d__.<>3__<>4__this = this;
			return <DecomposeInfoIter>d__;
		}

		// Token: 0x06008CE1 RID: 36065 RVA: 0x00285137 File Offset: 0x00283337
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x06008CE2 RID: 36066 RVA: 0x0028513F File Offset: 0x0028333F
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			ItemInfo.<ItemAccessIter>d__117 <ItemAccessIter>d__ = new ItemInfo.<ItemAccessIter>d__117(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x06008CE3 RID: 36067 RVA: 0x00285154 File Offset: 0x00283354
		[NullableContext(1)]
		public Dictionary<int, int> Parameters()
		{
			return this.ParametersIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008CE4 RID: 36068 RVA: 0x002851AA File Offset: 0x002833AA
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ParametersIter()
		{
			ItemInfo.<ParametersIter>d__119 <ParametersIter>d__ = new ItemInfo.<ParametersIter>d__119(-2);
			<ParametersIter>d__.<>3__<>4__this = this;
			return <ParametersIter>d__;
		}

		// Token: 0x06008CE5 RID: 36069 RVA: 0x002851BF File Offset: 0x002833BF
		[NullableContext(1)]
		public int[] ShowTypes()
		{
			return this.GetShowTypesArray();
		}

		// Token: 0x06008CE6 RID: 36070 RVA: 0x002851C7 File Offset: 0x002833C7
		[NullableContext(1)]
		public IEnumerable<int> ShowTypesIter()
		{
			ItemInfo.<ShowTypesIter>d__121 <ShowTypesIter>d__ = new ItemInfo.<ShowTypesIter>d__121(-2);
			<ShowTypesIter>d__.<>3__<>4__this = this;
			return <ShowTypesIter>d__;
		}

		// Token: 0x06008CE7 RID: 36071 RVA: 0x002851DC File Offset: 0x002833DC
		public int? GetConvertItems(int key)
		{
			this.EnsureConvertItemsCacheIfNeeded();
			int value;
			if (!this.ConvertItemsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008CE8 RID: 36072 RVA: 0x00285210 File Offset: 0x00283410
		public int? GetDecomposeInfo(int key)
		{
			this.EnsureDecomposeInfoCacheIfNeeded();
			int value;
			if (!this.DecomposeInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008CE9 RID: 36073 RVA: 0x00285244 File Offset: 0x00283444
		public int? GetParameters(int key)
		{
			this.EnsureParametersCacheIfNeeded();
			int value;
			if (!this.ParametersCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008CEA RID: 36074 RVA: 0x00285278 File Offset: 0x00283478
		private void EnsureConvertItemsCacheIfNeeded()
		{
			if (this.ConvertItemsCache != null)
			{
				return;
			}
			this.ConvertItemsCache = this.ConvertItemsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008CEB RID: 36075 RVA: 0x002852E0 File Offset: 0x002834E0
		private void EnsureDecomposeInfoCacheIfNeeded()
		{
			if (this.DecomposeInfoCache != null)
			{
				return;
			}
			this.DecomposeInfoCache = this.DecomposeInfoIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x00285348 File Offset: 0x00283548
		private void EnsureParametersCacheIfNeeded()
		{
			if (this.ParametersCache != null)
			{
				return;
			}
			this.ParametersCache = this.ParametersIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x002853AE File Offset: 0x002835AE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConvertItemsFrozenDict()
		{
			this.EnsureConvertItemsCacheIfNeeded();
			return this.ConvertItemsCache;
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x002853BC File Offset: 0x002835BC
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDecomposeInfoFrozenDict()
		{
			this.EnsureDecomposeInfoCacheIfNeeded();
			return this.DecomposeInfoCache;
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x002853CA File Offset: 0x002835CA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetParametersFrozenDict()
		{
			this.EnsureParametersCacheIfNeeded();
			return this.ParametersCache;
		}

		// Token: 0x040053EF RID: 21487
		private Table __p;

		// Token: 0x040053F0 RID: 21488
		[Nullable(2)]
		private FrozenDictionary<int, int> ConvertItemsCache;

		// Token: 0x040053F1 RID: 21489
		[Nullable(2)]
		private FrozenDictionary<int, int> DecomposeInfoCache;

		// Token: 0x040053F2 RID: 21490
		[Nullable(2)]
		private FrozenDictionary<int, int> ParametersCache;
	}
}
