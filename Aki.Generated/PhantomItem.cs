using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FD2 RID: 4050
	public struct PhantomItem : IFlatbufferObject
	{
		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x002D12A5 File Offset: 0x002CF4A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AF35 RID: 44853 RVA: 0x002D12B2 File Offset: 0x002CF4B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AF36 RID: 44854 RVA: 0x002D12BC File Offset: 0x002CF4BC
		public static PhantomItem GetRootAsPhantomItem(ByteBuffer _bb)
		{
			return PhantomItem.GetRootAsPhantomItem(_bb, default(PhantomItem));
		}

		// Token: 0x0600AF37 RID: 44855 RVA: 0x002D12D8 File Offset: 0x002CF4D8
		public static PhantomItem GetRootAsPhantomItem(ByteBuffer _bb, PhantomItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AF38 RID: 44856 RVA: 0x002D12F5 File Offset: 0x002CF4F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AF39 RID: 44857 RVA: 0x002D1304 File Offset: 0x002CF504
		public PhantomItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x0600AF3A RID: 44858 RVA: 0x002D1314 File Offset: 0x002CF514
		public int ItemId
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

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x0600AF3B RID: 44859 RVA: 0x002D1350 File Offset: 0x002CF550
		public int MonsterId
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

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x002D138C File Offset: 0x002CF58C
		public int ParentMonsterId
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

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x0600AF3D RID: 44861 RVA: 0x002D13C8 File Offset: 0x002CF5C8
		public string MonsterName
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

		// Token: 0x0600AF3E RID: 44862 RVA: 0x002D1400 File Offset: 0x002CF600
		public Span<byte> GetMonsterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AF3F RID: 44863 RVA: 0x002D1410 File Offset: 0x002CF610
		public byte[] GetMonsterNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AF40 RID: 44864 RVA: 0x002D1428 File Offset: 0x002CF628
		public int ElementType(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x0600AF41 RID: 44865 RVA: 0x002D1468 File Offset: 0x002CF668
		public int ElementTypeLength
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

		// Token: 0x0600AF42 RID: 44866 RVA: 0x002D1494 File Offset: 0x002CF694
		public Span<int> GetElementTypeBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600AF43 RID: 44867 RVA: 0x002D14A4 File Offset: 0x002CF6A4
		public int[] GetElementTypeArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x0600AF44 RID: 44868 RVA: 0x002D14BC File Offset: 0x002CF6BC
		public PhantomPropRandom? MainProp
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new PhantomPropRandom?(default(PhantomPropRandom).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x0600AF45 RID: 44869 RVA: 0x002D151C File Offset: 0x002CF71C
		public int LevelUpGroupId
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

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x0600AF46 RID: 44870 RVA: 0x002D155C File Offset: 0x002CF75C
		public int SkillId
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

		// Token: 0x0600AF47 RID: 44871 RVA: 0x002D159C File Offset: 0x002CF79C
		public long CalabashBuffs(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x0600AF48 RID: 44872 RVA: 0x002D15E8 File Offset: 0x002CF7E8
		public int CalabashBuffsLength
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

		// Token: 0x0600AF49 RID: 44873 RVA: 0x002D1614 File Offset: 0x002CF814
		public Span<long> GetCalabashBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x0600AF4A RID: 44874 RVA: 0x002D1629 File Offset: 0x002CF829
		public long[] GetCalabashBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x0600AF4B RID: 44875 RVA: 0x002D1668 File Offset: 0x002CF868
		public int Rarity
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

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x002D16A8 File Offset: 0x002CF8A8
		public int MeshId
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

		// Token: 0x0600AF4D RID: 44877 RVA: 0x002D16E8 File Offset: 0x002CF8E8
		public float Zoom(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x002D172C File Offset: 0x002CF92C
		public int ZoomLength
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

		// Token: 0x0600AF4F RID: 44879 RVA: 0x002D1758 File Offset: 0x002CF958
		public Span<float> GetZoomBytes()
		{
			return this.__p.__vector_as_span<float>(26, 4);
		}

		// Token: 0x0600AF50 RID: 44880 RVA: 0x002D1768 File Offset: 0x002CF968
		public float[] GetZoomArray()
		{
			return this.__p.__vector_as_array<float>(26) ?? Array.Empty<float>();
		}

		// Token: 0x0600AF51 RID: 44881 RVA: 0x002D1780 File Offset: 0x002CF980
		public float Location(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x0600AF52 RID: 44882 RVA: 0x002D17C4 File Offset: 0x002CF9C4
		public int LocationLength
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

		// Token: 0x0600AF53 RID: 44883 RVA: 0x002D17F0 File Offset: 0x002CF9F0
		public Span<float> GetLocationBytes()
		{
			return this.__p.__vector_as_span<float>(28, 4);
		}

		// Token: 0x0600AF54 RID: 44884 RVA: 0x002D1800 File Offset: 0x002CFA00
		public float[] GetLocationArray()
		{
			return this.__p.__vector_as_array<float>(28) ?? Array.Empty<float>();
		}

		// Token: 0x0600AF55 RID: 44885 RVA: 0x002D1818 File Offset: 0x002CFA18
		public float Rotator(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x002D185C File Offset: 0x002CFA5C
		public int RotatorLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x002D1888 File Offset: 0x002CFA88
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(30, 4);
		}

		// Token: 0x0600AF58 RID: 44888 RVA: 0x002D1898 File Offset: 0x002CFA98
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(30) ?? Array.Empty<float>();
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x0600AF59 RID: 44889 RVA: 0x002D18B0 File Offset: 0x002CFAB0
		public string StandAnim
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF5A RID: 44890 RVA: 0x002D18E8 File Offset: 0x002CFAE8
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x002D18F8 File Offset: 0x002CFAF8
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x0600AF5C RID: 44892 RVA: 0x002D1910 File Offset: 0x002CFB10
		public string TypeDescription
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

		// Token: 0x0600AF5D RID: 44893 RVA: 0x002D1948 File Offset: 0x002CFB48
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600AF5E RID: 44894 RVA: 0x002D1958 File Offset: 0x002CFB58
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x0600AF5F RID: 44895 RVA: 0x002D1970 File Offset: 0x002CFB70
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF60 RID: 44896 RVA: 0x002D19A8 File Offset: 0x002CFBA8
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600AF61 RID: 44897 RVA: 0x002D19B8 File Offset: 0x002CFBB8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x0600AF62 RID: 44898 RVA: 0x002D19D0 File Offset: 0x002CFBD0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF63 RID: 44899 RVA: 0x002D1A08 File Offset: 0x002CFC08
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x002D1A18 File Offset: 0x002CFC18
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x0600AF65 RID: 44901 RVA: 0x002D1A30 File Offset: 0x002CFC30
		public string IconBig
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

		// Token: 0x0600AF66 RID: 44902 RVA: 0x002D1A68 File Offset: 0x002CFC68
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600AF67 RID: 44903 RVA: 0x002D1A78 File Offset: 0x002CFC78
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x0600AF68 RID: 44904 RVA: 0x002D1A90 File Offset: 0x002CFC90
		public string IconMiddle
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

		// Token: 0x0600AF69 RID: 44905 RVA: 0x002D1AC8 File Offset: 0x002CFCC8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600AF6A RID: 44906 RVA: 0x002D1AD8 File Offset: 0x002CFCD8
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x0600AF6B RID: 44907 RVA: 0x002D1AF0 File Offset: 0x002CFCF0
		public string IconSmall
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

		// Token: 0x0600AF6C RID: 44908 RVA: 0x002D1B28 File Offset: 0x002CFD28
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600AF6D RID: 44909 RVA: 0x002D1B38 File Offset: 0x002CFD38
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x0600AF6E RID: 44910 RVA: 0x002D1B50 File Offset: 0x002CFD50
		public string Mesh
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

		// Token: 0x0600AF6F RID: 44911 RVA: 0x002D1B88 File Offset: 0x002CFD88
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600AF70 RID: 44912 RVA: 0x002D1B98 File Offset: 0x002CFD98
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x0600AF71 RID: 44913 RVA: 0x002D1BB0 File Offset: 0x002CFDB0
		public int QualityId
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

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x0600AF72 RID: 44914 RVA: 0x002D1BF0 File Offset: 0x002CFDF0
		public int MaxCapcity
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 999999999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF73 RID: 44915 RVA: 0x002D1C34 File Offset: 0x002CFE34
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600AF74 RID: 44916 RVA: 0x002D1C74 File Offset: 0x002CFE74
		public int ItemAccessLength
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

		// Token: 0x0600AF75 RID: 44917 RVA: 0x002D1CA0 File Offset: 0x002CFEA0
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(52, 4);
		}

		// Token: 0x0600AF76 RID: 44918 RVA: 0x002D1CB0 File Offset: 0x002CFEB0
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(52) ?? Array.Empty<int>();
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x0600AF77 RID: 44919 RVA: 0x002D1CC8 File Offset: 0x002CFEC8
		public int ObtainedShow
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x0600AF78 RID: 44920 RVA: 0x002D1D08 File Offset: 0x002CFF08
		public string ObtainedShowDescription
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

		// Token: 0x0600AF79 RID: 44921 RVA: 0x002D1D40 File Offset: 0x002CFF40
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600AF7A RID: 44922 RVA: 0x002D1D50 File Offset: 0x002CFF50
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x0600AF7B RID: 44923 RVA: 0x002D1D68 File Offset: 0x002CFF68
		public int NumLimit
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

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x0600AF7C RID: 44924 RVA: 0x002D1DA8 File Offset: 0x002CFFA8
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(60);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x0600AF7D RID: 44925 RVA: 0x002D1DE8 File Offset: 0x002CFFE8
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x0600AF7E RID: 44926 RVA: 0x002D1E28 File Offset: 0x002D0028
		public string SkillIcon
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

		// Token: 0x0600AF7F RID: 44927 RVA: 0x002D1E60 File Offset: 0x002D0060
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x002D1E70 File Offset: 0x002D0070
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x0600AF81 RID: 44929 RVA: 0x002D1E88 File Offset: 0x002D0088
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(66);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x0600AF82 RID: 44930 RVA: 0x002D1EC8 File Offset: 0x002D00C8
		public int RedDotDisableRule
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

		// Token: 0x0600AF83 RID: 44931 RVA: 0x002D1F08 File Offset: 0x002D0108
		public int FetterGroup(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x0600AF84 RID: 44932 RVA: 0x002D1F48 File Offset: 0x002D0148
		public int FetterGroupLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AF85 RID: 44933 RVA: 0x002D1F74 File Offset: 0x002D0174
		public Span<int> GetFetterGroupBytes()
		{
			return this.__p.__vector_as_span<int>(70, 4);
		}

		// Token: 0x0600AF86 RID: 44934 RVA: 0x002D1F84 File Offset: 0x002D0184
		public int[] GetFetterGroupArray()
		{
			return this.__p.__vector_as_array<int>(70) ?? Array.Empty<int>();
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x0600AF87 RID: 44935 RVA: 0x002D1F9C File Offset: 0x002D019C
		public int PhantomType
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AF88 RID: 44936 RVA: 0x002D1FD9 File Offset: 0x002D01D9
		[NullableContext(1)]
		public long[] CalabashBuffs()
		{
			return this.GetCalabashBuffsArray();
		}

		// Token: 0x0600AF89 RID: 44937 RVA: 0x002D1FE1 File Offset: 0x002D01E1
		[NullableContext(1)]
		public IEnumerable<long> CalabashBuffsIter()
		{
			PhantomItem.<CalabashBuffsIter>d__122 <CalabashBuffsIter>d__ = new PhantomItem.<CalabashBuffsIter>d__122(-2);
			<CalabashBuffsIter>d__.<>3__<>4__this = this;
			return <CalabashBuffsIter>d__;
		}

		// Token: 0x0600AF8A RID: 44938 RVA: 0x002D1FF6 File Offset: 0x002D01F6
		[NullableContext(1)]
		public int[] ElementType()
		{
			return this.GetElementTypeArray();
		}

		// Token: 0x0600AF8B RID: 44939 RVA: 0x002D1FFE File Offset: 0x002D01FE
		[NullableContext(1)]
		public IEnumerable<int> ElementTypeIter()
		{
			PhantomItem.<ElementTypeIter>d__124 <ElementTypeIter>d__ = new PhantomItem.<ElementTypeIter>d__124(-2);
			<ElementTypeIter>d__.<>3__<>4__this = this;
			return <ElementTypeIter>d__;
		}

		// Token: 0x0600AF8C RID: 44940 RVA: 0x002D2013 File Offset: 0x002D0213
		[NullableContext(1)]
		public int[] FetterGroup()
		{
			return this.GetFetterGroupArray();
		}

		// Token: 0x0600AF8D RID: 44941 RVA: 0x002D201B File Offset: 0x002D021B
		[NullableContext(1)]
		public IEnumerable<int> FetterGroupIter()
		{
			PhantomItem.<FetterGroupIter>d__126 <FetterGroupIter>d__ = new PhantomItem.<FetterGroupIter>d__126(-2);
			<FetterGroupIter>d__.<>3__<>4__this = this;
			return <FetterGroupIter>d__;
		}

		// Token: 0x0600AF8E RID: 44942 RVA: 0x002D2030 File Offset: 0x002D0230
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600AF8F RID: 44943 RVA: 0x002D2038 File Offset: 0x002D0238
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			PhantomItem.<ItemAccessIter>d__128 <ItemAccessIter>d__ = new PhantomItem.<ItemAccessIter>d__128(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600AF90 RID: 44944 RVA: 0x002D204D File Offset: 0x002D024D
		[NullableContext(1)]
		public float[] Location()
		{
			return this.GetLocationArray();
		}

		// Token: 0x0600AF91 RID: 44945 RVA: 0x002D2055 File Offset: 0x002D0255
		[NullableContext(1)]
		public IEnumerable<float> LocationIter()
		{
			PhantomItem.<LocationIter>d__130 <LocationIter>d__ = new PhantomItem.<LocationIter>d__130(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x002D206A File Offset: 0x002D026A
		[NullableContext(1)]
		public float[] Rotator()
		{
			return this.GetRotatorArray();
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x002D2072 File Offset: 0x002D0272
		[NullableContext(1)]
		public IEnumerable<float> RotatorIter()
		{
			PhantomItem.<RotatorIter>d__132 <RotatorIter>d__ = new PhantomItem.<RotatorIter>d__132(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x002D2087 File Offset: 0x002D0287
		[NullableContext(1)]
		public float[] Zoom()
		{
			return this.GetZoomArray();
		}

		// Token: 0x0600AF95 RID: 44949 RVA: 0x002D208F File Offset: 0x002D028F
		[NullableContext(1)]
		public IEnumerable<float> ZoomIter()
		{
			PhantomItem.<ZoomIter>d__134 <ZoomIter>d__ = new PhantomItem.<ZoomIter>d__134(-2);
			<ZoomIter>d__.<>3__<>4__this = this;
			return <ZoomIter>d__;
		}

		// Token: 0x04005594 RID: 21908
		private Table __p;
	}
}
