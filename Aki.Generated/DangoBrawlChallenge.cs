using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBE RID: 3006
	public struct DangoBrawlChallenge : IFlatbufferObject
	{
		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06005CFA RID: 23802 RVA: 0x00207DA4 File Offset: 0x00205FA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x00207DB1 File Offset: 0x00205FB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x00207DB8 File Offset: 0x00205FB8
		public static DangoBrawlChallenge GetRootAsDangoBrawlChallenge(ByteBuffer _bb)
		{
			return DangoBrawlChallenge.GetRootAsDangoBrawlChallenge(_bb, default(DangoBrawlChallenge));
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x00207DD4 File Offset: 0x00205FD4
		public static DangoBrawlChallenge GetRootAsDangoBrawlChallenge(ByteBuffer _bb, DangoBrawlChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x00207DF1 File Offset: 0x00205FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x00207E00 File Offset: 0x00206000
		public DangoBrawlChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06005D00 RID: 23808 RVA: 0x00207E10 File Offset: 0x00206010
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

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06005D01 RID: 23809 RVA: 0x00207E4C File Offset: 0x0020604C
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

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06005D02 RID: 23810 RVA: 0x00207E88 File Offset: 0x00206088
		public int PreChallenge
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

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06005D03 RID: 23811 RVA: 0x00207EC4 File Offset: 0x002060C4
		public string SimpleName
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

		// Token: 0x06005D04 RID: 23812 RVA: 0x00207EFC File Offset: 0x002060FC
		public Span<byte> GetSimpleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x00207F0C File Offset: 0x0020610C
		public byte[] GetSimpleNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06005D06 RID: 23814 RVA: 0x00207F24 File Offset: 0x00206124
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

		// Token: 0x06005D07 RID: 23815 RVA: 0x00207F5C File Offset: 0x0020615C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x00207F6C File Offset: 0x0020616C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06005D09 RID: 23817 RVA: 0x00207F84 File Offset: 0x00206184
		public string Icon
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

		// Token: 0x06005D0A RID: 23818 RVA: 0x00207FBC File Offset: 0x002061BC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x00207FCC File Offset: 0x002061CC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06005D0C RID: 23820 RVA: 0x00207FE4 File Offset: 0x002061E4
		public string SelIcon
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

		// Token: 0x06005D0D RID: 23821 RVA: 0x0020801C File Offset: 0x0020621C
		public Span<byte> GetSelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x0020802C File Offset: 0x0020622C
		public byte[] GetSelIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06005D0F RID: 23823 RVA: 0x00208044 File Offset: 0x00206244
		public string BgNumIcon
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

		// Token: 0x06005D10 RID: 23824 RVA: 0x0020807C File Offset: 0x0020627C
		public Span<byte> GetBgNumIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x0020808C File Offset: 0x0020628C
		public byte[] GetBgNumIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x002080A4 File Offset: 0x002062A4
		public string Desc
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

		// Token: 0x06005D13 RID: 23827 RVA: 0x002080DC File Offset: 0x002062DC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x002080EC File Offset: 0x002062EC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06005D15 RID: 23829 RVA: 0x00208104 File Offset: 0x00206304
		public int FirstClearDropId
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

		// Token: 0x06005D16 RID: 23830 RVA: 0x00208144 File Offset: 0x00206344
		public int UnlockRoleId(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06005D17 RID: 23831 RVA: 0x00208184 File Offset: 0x00206384
		public int UnlockRoleIdLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x002081B0 File Offset: 0x002063B0
		public Span<int> GetUnlockRoleIdBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x002081C0 File Offset: 0x002063C0
		public int[] GetUnlockRoleIdArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x002081D8 File Offset: 0x002063D8
		public int RecommendRoleId(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06005D1B RID: 23835 RVA: 0x00208218 File Offset: 0x00206418
		public int RecommendRoleIdLength
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

		// Token: 0x06005D1C RID: 23836 RVA: 0x00208244 File Offset: 0x00206444
		public Span<int> GetRecommendRoleIdBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x00208254 File Offset: 0x00206454
		public int[] GetRecommendRoleIdArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06005D1E RID: 23838 RVA: 0x0020826C File Offset: 0x0020646C
		public int BgStyle
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

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06005D1F RID: 23839 RVA: 0x002082AC File Offset: 0x002064AC
		public int Mode
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

		// Token: 0x06005D20 RID: 23840 RVA: 0x002082EC File Offset: 0x002064EC
		public string SpineAtlasPaths(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06005D21 RID: 23841 RVA: 0x00208328 File Offset: 0x00206528
		public int SpineAtlasPathsLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x00208354 File Offset: 0x00206554
		public string SpineSkeletonDataPaths(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06005D23 RID: 23843 RVA: 0x00208390 File Offset: 0x00206590
		public int SpineSkeletonDataPathsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x002083BC File Offset: 0x002065BC
		public string SpineNormalAnims(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06005D25 RID: 23845 RVA: 0x002083F8 File Offset: 0x002065F8
		public int SpineNormalAnimsLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x00208424 File Offset: 0x00206624
		public string SpineLoopAnims(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06005D27 RID: 23847 RVA: 0x00208460 File Offset: 0x00206660
		public int SpineLoopAnimsLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06005D28 RID: 23848 RVA: 0x0020848C File Offset: 0x0020668C
		public string AdventureRoleIcon1
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

		// Token: 0x06005D29 RID: 23849 RVA: 0x002084C4 File Offset: 0x002066C4
		public Span<byte> GetAdventureRoleIcon1Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x002084D4 File Offset: 0x002066D4
		public byte[] GetAdventureRoleIcon1Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06005D2B RID: 23851 RVA: 0x002084EC File Offset: 0x002066EC
		public string AdventureRoleIcon2
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

		// Token: 0x06005D2C RID: 23852 RVA: 0x00208524 File Offset: 0x00206724
		public Span<byte> GetAdventureRoleIcon2Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x00208534 File Offset: 0x00206734
		public byte[] GetAdventureRoleIcon2Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06005D2E RID: 23854 RVA: 0x0020854C File Offset: 0x0020674C
		public string EnvirDesc
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

		// Token: 0x06005D2F RID: 23855 RVA: 0x00208584 File Offset: 0x00206784
		public Span<byte> GetEnvirDescBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x00208594 File Offset: 0x00206794
		public byte[] GetEnvirDescArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06005D31 RID: 23857 RVA: 0x002085AC File Offset: 0x002067AC
		public string PassCondDesc
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

		// Token: 0x06005D32 RID: 23858 RVA: 0x002085E4 File Offset: 0x002067E4
		public Span<byte> GetPassCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x002085F4 File Offset: 0x002067F4
		public byte[] GetPassCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06005D34 RID: 23860 RVA: 0x0020860C File Offset: 0x0020680C
		public string UnlockCondDesc
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x00208644 File Offset: 0x00206844
		public Span<byte> GetUnlockCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x00208654 File Offset: 0x00206854
		public byte[] GetUnlockCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06005D37 RID: 23863 RVA: 0x0020866C File Offset: 0x0020686C
		public int InstanceId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06005D38 RID: 23864 RVA: 0x002086AC File Offset: 0x002068AC
		public int WinCount
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06005D39 RID: 23865 RVA: 0x002086EC File Offset: 0x002068EC
		public int HpCount
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x0020872C File Offset: 0x0020692C
		public int RoundList(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06005D3B RID: 23867 RVA: 0x0020876C File Offset: 0x0020696C
		public int RoundListLength
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

		// Token: 0x06005D3C RID: 23868 RVA: 0x00208798 File Offset: 0x00206998
		public Span<int> GetRoundListBytes()
		{
			return this.__p.__vector_as_span<int>(56, 4);
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x002087A8 File Offset: 0x002069A8
		public int[] GetRoundListArray()
		{
			return this.__p.__vector_as_array<int>(56) ?? Array.Empty<int>();
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06005D3E RID: 23870 RVA: 0x002087C0 File Offset: 0x002069C0
		public int DefaultRoleId
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

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06005D3F RID: 23871 RVA: 0x00208800 File Offset: 0x00206A00
		public int ShopRefreshCostId
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

		// Token: 0x06005D40 RID: 23872 RVA: 0x00208840 File Offset: 0x00206A40
		public int FatigueConfig(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x00208880 File Offset: 0x00206A80
		public int FatigueConfigLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x002088AC File Offset: 0x00206AAC
		public Span<int> GetFatigueConfigBytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x06005D43 RID: 23875 RVA: 0x002088BC File Offset: 0x00206ABC
		public int[] GetFatigueConfigArray()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06005D44 RID: 23876 RVA: 0x002088D4 File Offset: 0x00206AD4
		public int AdditionRound
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x00208914 File Offset: 0x00206B14
		public DicIntInt? ShopDiscount(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06005D46 RID: 23878 RVA: 0x00208978 File Offset: 0x00206B78
		public int ShopDiscountLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x002089A4 File Offset: 0x00206BA4
		public DicIntInt? RecommendQuality(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06005D48 RID: 23880 RVA: 0x00208A08 File Offset: 0x00206C08
		public int RecommendQualityLength
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x00208A34 File Offset: 0x00206C34
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FatigueConfigIter()或GetFatigueConfigBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FatigueConfig()
		{
			DangoBrawlChallenge dangoBrawlChallenge = this;
			return dangoBrawlChallenge.GetFatigueConfigArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x00208A58 File Offset: 0x00206C58
		[NullableContext(1)]
		public readonly IEnumerable<int> FatigueConfigIter()
		{
			DangoBrawlChallenge.<FatigueConfigIter>d__115 <FatigueConfigIter>d__ = new DangoBrawlChallenge.<FatigueConfigIter>d__115(-2);
			<FatigueConfigIter>d__.<>3__<>4__this = this;
			return <FatigueConfigIter>d__;
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x00208A70 File Offset: 0x00206C70
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RecommendQualityFrozenDict()缓存字典，遍历请使用RecommendQualityIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> RecommendQuality()
		{
			return this.RecommendQualityIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x00208AC6 File Offset: 0x00206CC6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RecommendQualityIter()
		{
			DangoBrawlChallenge.<RecommendQualityIter>d__117 <RecommendQualityIter>d__ = new DangoBrawlChallenge.<RecommendQualityIter>d__117(-2);
			<RecommendQualityIter>d__.<>3__<>4__this = this;
			return <RecommendQualityIter>d__;
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x00208ADC File Offset: 0x00206CDC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendRoleIdIter()或GetRecommendRoleIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendRoleId()
		{
			DangoBrawlChallenge dangoBrawlChallenge = this;
			return dangoBrawlChallenge.GetRecommendRoleIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005D4E RID: 23886 RVA: 0x00208B00 File Offset: 0x00206D00
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendRoleIdIter()
		{
			DangoBrawlChallenge.<RecommendRoleIdIter>d__119 <RecommendRoleIdIter>d__ = new DangoBrawlChallenge.<RecommendRoleIdIter>d__119(-2);
			<RecommendRoleIdIter>d__.<>3__<>4__this = this;
			return <RecommendRoleIdIter>d__;
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x00208B18 File Offset: 0x00206D18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoundListIter()或GetRoundListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoundList()
		{
			DangoBrawlChallenge dangoBrawlChallenge = this;
			return dangoBrawlChallenge.GetRoundListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x00208B3C File Offset: 0x00206D3C
		[NullableContext(1)]
		public readonly IEnumerable<int> RoundListIter()
		{
			DangoBrawlChallenge.<RoundListIter>d__121 <RoundListIter>d__ = new DangoBrawlChallenge.<RoundListIter>d__121(-2);
			<RoundListIter>d__.<>3__<>4__this = this;
			return <RoundListIter>d__;
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x00208B54 File Offset: 0x00206D54
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ShopDiscountFrozenDict()缓存字典，遍历请使用ShopDiscountIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ShopDiscount()
		{
			return this.ShopDiscountIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x00208BAA File Offset: 0x00206DAA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ShopDiscountIter()
		{
			DangoBrawlChallenge.<ShopDiscountIter>d__123 <ShopDiscountIter>d__ = new DangoBrawlChallenge.<ShopDiscountIter>d__123(-2);
			<ShopDiscountIter>d__.<>3__<>4__this = this;
			return <ShopDiscountIter>d__;
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x00208BBF File Offset: 0x00206DBF
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineAtlasPathsIter()或GetSpineAtlasPathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineAtlasPaths()
		{
			return this.SpineAtlasPathsIter().ToArray<string>();
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x00208BCC File Offset: 0x00206DCC
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineAtlasPathsIter()
		{
			DangoBrawlChallenge.<SpineAtlasPathsIter>d__125 <SpineAtlasPathsIter>d__ = new DangoBrawlChallenge.<SpineAtlasPathsIter>d__125(-2);
			<SpineAtlasPathsIter>d__.<>3__<>4__this = this;
			return <SpineAtlasPathsIter>d__;
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x00208BE1 File Offset: 0x00206DE1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineLoopAnimsIter()或GetSpineLoopAnimsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineLoopAnims()
		{
			return this.SpineLoopAnimsIter().ToArray<string>();
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x00208BEE File Offset: 0x00206DEE
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineLoopAnimsIter()
		{
			DangoBrawlChallenge.<SpineLoopAnimsIter>d__127 <SpineLoopAnimsIter>d__ = new DangoBrawlChallenge.<SpineLoopAnimsIter>d__127(-2);
			<SpineLoopAnimsIter>d__.<>3__<>4__this = this;
			return <SpineLoopAnimsIter>d__;
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x00208C03 File Offset: 0x00206E03
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineNormalAnimsIter()或GetSpineNormalAnimsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineNormalAnims()
		{
			return this.SpineNormalAnimsIter().ToArray<string>();
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x00208C10 File Offset: 0x00206E10
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineNormalAnimsIter()
		{
			DangoBrawlChallenge.<SpineNormalAnimsIter>d__129 <SpineNormalAnimsIter>d__ = new DangoBrawlChallenge.<SpineNormalAnimsIter>d__129(-2);
			<SpineNormalAnimsIter>d__.<>3__<>4__this = this;
			return <SpineNormalAnimsIter>d__;
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x00208C25 File Offset: 0x00206E25
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineSkeletonDataPathsIter()或GetSpineSkeletonDataPathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineSkeletonDataPaths()
		{
			return this.SpineSkeletonDataPathsIter().ToArray<string>();
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x00208C32 File Offset: 0x00206E32
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineSkeletonDataPathsIter()
		{
			DangoBrawlChallenge.<SpineSkeletonDataPathsIter>d__131 <SpineSkeletonDataPathsIter>d__ = new DangoBrawlChallenge.<SpineSkeletonDataPathsIter>d__131(-2);
			<SpineSkeletonDataPathsIter>d__.<>3__<>4__this = this;
			return <SpineSkeletonDataPathsIter>d__;
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x00208C48 File Offset: 0x00206E48
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockRoleIdIter()或GetUnlockRoleIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockRoleId()
		{
			DangoBrawlChallenge dangoBrawlChallenge = this;
			return dangoBrawlChallenge.GetUnlockRoleIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x00208C6C File Offset: 0x00206E6C
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockRoleIdIter()
		{
			DangoBrawlChallenge.<UnlockRoleIdIter>d__133 <UnlockRoleIdIter>d__ = new DangoBrawlChallenge.<UnlockRoleIdIter>d__133(-2);
			<UnlockRoleIdIter>d__.<>3__<>4__this = this;
			return <UnlockRoleIdIter>d__;
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x00208C84 File Offset: 0x00206E84
		public int? GetRecommendQuality(int key)
		{
			this.EnsureRecommendQualityCacheIfNeeded();
			int value;
			if (!this.RecommendQualityCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005D5E RID: 23902 RVA: 0x00208CB8 File Offset: 0x00206EB8
		public int? GetShopDiscount(int key)
		{
			this.EnsureShopDiscountCacheIfNeeded();
			int value;
			if (!this.ShopDiscountCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x00208CEC File Offset: 0x00206EEC
		private void EnsureRecommendQualityCacheIfNeeded()
		{
			if (this.RecommendQualityCache != null)
			{
				return;
			}
			this.RecommendQualityCache = this.RecommendQualityIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x00208D54 File Offset: 0x00206F54
		private void EnsureShopDiscountCacheIfNeeded()
		{
			if (this.ShopDiscountCache != null)
			{
				return;
			}
			this.ShopDiscountCache = this.ShopDiscountIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x00208DBA File Offset: 0x00206FBA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRecommendQualityFrozenDict(int key)
		{
			this.EnsureRecommendQualityCacheIfNeeded();
			return this.RecommendQualityCache;
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x00208DC8 File Offset: 0x00206FC8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetShopDiscountFrozenDict(int key)
		{
			this.EnsureShopDiscountCacheIfNeeded();
			return this.ShopDiscountCache;
		}

		// Token: 0x04004BE5 RID: 19429
		private Table __p;

		// Token: 0x04004BE6 RID: 19430
		[Nullable(2)]
		private FrozenDictionary<int, int> RecommendQualityCache;

		// Token: 0x04004BE7 RID: 19431
		[Nullable(2)]
		private FrozenDictionary<int, int> ShopDiscountCache;
	}
}
