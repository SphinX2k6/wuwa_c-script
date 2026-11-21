using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2D RID: 3373
	public struct ExploreActivity : IFlatbufferObject
	{
		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x060070FE RID: 28926 RVA: 0x00246634 File Offset: 0x00244834
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00246641 File Offset: 0x00244841
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x00246648 File Offset: 0x00244848
		public static ExploreActivity GetRootAsExploreActivity(ByteBuffer _bb)
		{
			return ExploreActivity.GetRootAsExploreActivity(_bb, default(ExploreActivity));
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x00246664 File Offset: 0x00244864
		public static ExploreActivity GetRootAsExploreActivity(ByteBuffer _bb, ExploreActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x00246681 File Offset: 0x00244881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x00246690 File Offset: 0x00244890
		public ExploreActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06007104 RID: 28932 RVA: 0x002466A0 File Offset: 0x002448A0
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

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06007105 RID: 28933 RVA: 0x002466DC File Offset: 0x002448DC
		public string Bg
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

		// Token: 0x06007106 RID: 28934 RVA: 0x00246713 File Offset: 0x00244913
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x00246722 File Offset: 0x00244922
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06007108 RID: 28936 RVA: 0x0024673C File Offset: 0x0024493C
		public string ExploreTitle
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

		// Token: 0x06007109 RID: 28937 RVA: 0x00246773 File Offset: 0x00244973
		public Span<byte> GetExploreTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x00246782 File Offset: 0x00244982
		public byte[] GetExploreTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x0600710B RID: 28939 RVA: 0x0024679C File Offset: 0x0024499C
		public string PercentDesc
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

		// Token: 0x0600710C RID: 28940 RVA: 0x002467D4 File Offset: 0x002449D4
		public Span<byte> GetPercentDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x002467E4 File Offset: 0x002449E4
		public byte[] GetPercentDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x0600710E RID: 28942 RVA: 0x002467FC File Offset: 0x002449FC
		public string AreaTitle
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

		// Token: 0x0600710F RID: 28943 RVA: 0x00246834 File Offset: 0x00244A34
		public Span<byte> GetAreaTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x00246844 File Offset: 0x00244A44
		public byte[] GetAreaTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06007111 RID: 28945 RVA: 0x0024685C File Offset: 0x00244A5C
		public string MainTitle
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

		// Token: 0x06007112 RID: 28946 RVA: 0x00246894 File Offset: 0x00244A94
		public Span<byte> GetMainTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x002468A4 File Offset: 0x00244AA4
		public byte[] GetMainTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06007114 RID: 28948 RVA: 0x002468BC File Offset: 0x00244ABC
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

		// Token: 0x06007115 RID: 28949 RVA: 0x002468F4 File Offset: 0x00244AF4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x00246904 File Offset: 0x00244B04
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06007117 RID: 28951 RVA: 0x0024691C File Offset: 0x00244B1C
		public string SumRewardDesc
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

		// Token: 0x06007118 RID: 28952 RVA: 0x00246954 File Offset: 0x00244B54
		public Span<byte> GetSumRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x00246964 File Offset: 0x00244B64
		public byte[] GetSumRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x0600711A RID: 28954 RVA: 0x0024697C File Offset: 0x00244B7C
		public int SumRewardNum
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

		// Token: 0x0600711B RID: 28955 RVA: 0x002469BC File Offset: 0x00244BBC
		public int RecommendAreaList(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x0600711C RID: 28956 RVA: 0x002469FC File Offset: 0x00244BFC
		public int RecommendAreaListLength
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

		// Token: 0x0600711D RID: 28957 RVA: 0x00246A28 File Offset: 0x00244C28
		public Span<int> GetRecommendAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x00246A38 File Offset: 0x00244C38
		public int[] GetRecommendAreaListArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x00246A50 File Offset: 0x00244C50
		public int SourceList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06007120 RID: 28960 RVA: 0x00246A90 File Offset: 0x00244C90
		public int SourceListLength
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

		// Token: 0x06007121 RID: 28961 RVA: 0x00246ABC File Offset: 0x00244CBC
		public Span<int> GetSourceListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x00246ACC File Offset: 0x00244CCC
		public int[] GetSourceListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06007123 RID: 28963 RVA: 0x00246AE4 File Offset: 0x00244CE4
		public int IsNewPrefab
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x00246B21 File Offset: 0x00244D21
		[NullableContext(1)]
		public int[] RecommendAreaList()
		{
			return this.GetRecommendAreaListArray();
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x00246B29 File Offset: 0x00244D29
		[NullableContext(1)]
		public IEnumerable<int> RecommendAreaListIter()
		{
			ExploreActivity.<RecommendAreaListIter>d__53 <RecommendAreaListIter>d__ = new ExploreActivity.<RecommendAreaListIter>d__53(-2);
			<RecommendAreaListIter>d__.<>3__<>4__this = this;
			return <RecommendAreaListIter>d__;
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x00246B3E File Offset: 0x00244D3E
		[NullableContext(1)]
		public int[] SourceList()
		{
			return this.GetSourceListArray();
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x00246B46 File Offset: 0x00244D46
		[NullableContext(1)]
		public IEnumerable<int> SourceListIter()
		{
			ExploreActivity.<SourceListIter>d__55 <SourceListIter>d__ = new ExploreActivity.<SourceListIter>d__55(-2);
			<SourceListIter>d__.<>3__<>4__this = this;
			return <SourceListIter>d__;
		}

		// Token: 0x04005272 RID: 21106
		private Table __p;
	}
}
