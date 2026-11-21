using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D87 RID: 3463
	public struct FloroRanchCard : IFlatbufferObject
	{
		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x060078AA RID: 30890 RVA: 0x002585EC File Offset: 0x002567EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060078AB RID: 30891 RVA: 0x002585F9 File Offset: 0x002567F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x00258600 File Offset: 0x00256800
		public static FloroRanchCard GetRootAsFloroRanchCard(ByteBuffer _bb)
		{
			return FloroRanchCard.GetRootAsFloroRanchCard(_bb, default(FloroRanchCard));
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x0025861C File Offset: 0x0025681C
		public static FloroRanchCard GetRootAsFloroRanchCard(ByteBuffer _bb, FloroRanchCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x00258639 File Offset: 0x00256839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00258648 File Offset: 0x00256848
		public FloroRanchCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x060078B0 RID: 30896 RVA: 0x00258658 File Offset: 0x00256858
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

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x060078B1 RID: 30897 RVA: 0x00258694 File Offset: 0x00256894
		public string Name
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

		// Token: 0x060078B2 RID: 30898 RVA: 0x002586CB File Offset: 0x002568CB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060078B3 RID: 30899 RVA: 0x002586DA File Offset: 0x002568DA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x060078B4 RID: 30900 RVA: 0x002586F4 File Offset: 0x002568F4
		public int Race
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

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x060078B5 RID: 30901 RVA: 0x00258730 File Offset: 0x00256930
		public int RarityId
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

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x060078B6 RID: 30902 RVA: 0x00258770 File Offset: 0x00256970
		public int Salary
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

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x060078B7 RID: 30903 RVA: 0x002587B0 File Offset: 0x002569B0
		public int Price
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

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x060078B8 RID: 30904 RVA: 0x002587F0 File Offset: 0x002569F0
		public int Tag
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

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x060078B9 RID: 30905 RVA: 0x00258830 File Offset: 0x00256A30
		public bool EnableEvolve
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x060078BA RID: 30906 RVA: 0x00258870 File Offset: 0x00256A70
		public int EvolveExp
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x060078BB RID: 30907 RVA: 0x002588B0 File Offset: 0x00256AB0
		public int MaxEvolveLv
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x002588F4 File Offset: 0x00256AF4
		public int Label(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x060078BD RID: 30909 RVA: 0x00258934 File Offset: 0x00256B34
		public int LabelLength
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

		// Token: 0x060078BE RID: 30910 RVA: 0x00258960 File Offset: 0x00256B60
		public Span<int> GetLabelBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x060078BF RID: 30911 RVA: 0x00258970 File Offset: 0x00256B70
		public int[] GetLabelArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x00258988 File Offset: 0x00256B88
		public int BornBuffList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x060078C1 RID: 30913 RVA: 0x002589C8 File Offset: 0x00256BC8
		public int BornBuffListLength
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

		// Token: 0x060078C2 RID: 30914 RVA: 0x002589F4 File Offset: 0x00256BF4
		public Span<int> GetBornBuffListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x00258A04 File Offset: 0x00256C04
		public int[] GetBornBuffListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x060078C4 RID: 30916 RVA: 0x00258A1C File Offset: 0x00256C1C
		public int EvolveItemOffsetY
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 200;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x060078C5 RID: 30917 RVA: 0x00258A60 File Offset: 0x00256C60
		public string Spine
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060078C6 RID: 30918 RVA: 0x00258A98 File Offset: 0x00256C98
		public Span<byte> GetSpineBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060078C7 RID: 30919 RVA: 0x00258AA8 File Offset: 0x00256CA8
		public byte[] GetSpineArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x060078C8 RID: 30920 RVA: 0x00258AC0 File Offset: 0x00256CC0
		public string SpineSkeletonData
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

		// Token: 0x060078C9 RID: 30921 RVA: 0x00258AF8 File Offset: 0x00256CF8
		public Span<byte> GetSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x00258B08 File Offset: 0x00256D08
		public byte[] GetSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x060078CB RID: 30923 RVA: 0x00258B20 File Offset: 0x00256D20
		public string Icon
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

		// Token: 0x060078CC RID: 30924 RVA: 0x00258B58 File Offset: 0x00256D58
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x00258B68 File Offset: 0x00256D68
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x060078CE RID: 30926 RVA: 0x00258B80 File Offset: 0x00256D80
		public int Cost
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

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x060078CF RID: 30927 RVA: 0x00258BC0 File Offset: 0x00256DC0
		public bool EnableGacha
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x060078D0 RID: 30928 RVA: 0x00258C00 File Offset: 0x00256E00
		public bool Illustration
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x060078D1 RID: 30929 RVA: 0x00258C40 File Offset: 0x00256E40
		public string Video
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

		// Token: 0x060078D2 RID: 30930 RVA: 0x00258C78 File Offset: 0x00256E78
		public Span<byte> GetVideoBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x00258C88 File Offset: 0x00256E88
		public byte[] GetVideoArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x060078D4 RID: 30932 RVA: 0x00258CA0 File Offset: 0x00256EA0
		public int Towards
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

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x060078D5 RID: 30933 RVA: 0x00258CE0 File Offset: 0x00256EE0
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x060078D6 RID: 30934 RVA: 0x00258D20 File Offset: 0x00256F20
		public int SpeicalEffectshow
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

		// Token: 0x060078D7 RID: 30935 RVA: 0x00258D5D File Offset: 0x00256F5D
		[NullableContext(1)]
		public int[] BornBuffList()
		{
			return this.GetBornBuffListArray();
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x00258D65 File Offset: 0x00256F65
		[NullableContext(1)]
		public IEnumerable<int> BornBuffListIter()
		{
			FloroRanchCard.<BornBuffListIter>d__71 <BornBuffListIter>d__ = new FloroRanchCard.<BornBuffListIter>d__71(-2);
			<BornBuffListIter>d__.<>3__<>4__this = this;
			return <BornBuffListIter>d__;
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00258D7A File Offset: 0x00256F7A
		[NullableContext(1)]
		public int[] Label()
		{
			return this.GetLabelArray();
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00258D82 File Offset: 0x00256F82
		[NullableContext(1)]
		public IEnumerable<int> LabelIter()
		{
			FloroRanchCard.<LabelIter>d__73 <LabelIter>d__ = new FloroRanchCard.<LabelIter>d__73(-2);
			<LabelIter>d__.<>3__<>4__this = this;
			return <LabelIter>d__;
		}

		// Token: 0x040052E8 RID: 21224
		private Table __p;
	}
}
