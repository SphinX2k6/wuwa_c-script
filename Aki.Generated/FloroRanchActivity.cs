using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D83 RID: 3459
	public struct FloroRanchActivity : IFlatbufferObject
	{
		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06007845 RID: 30789 RVA: 0x002574D4 File Offset: 0x002556D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x002574E1 File Offset: 0x002556E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x002574E8 File Offset: 0x002556E8
		public static FloroRanchActivity GetRootAsFloroRanchActivity(ByteBuffer _bb)
		{
			return FloroRanchActivity.GetRootAsFloroRanchActivity(_bb, default(FloroRanchActivity));
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00257504 File Offset: 0x00255704
		public static FloroRanchActivity GetRootAsFloroRanchActivity(ByteBuffer _bb, FloroRanchActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x00257521 File Offset: 0x00255721
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00257530 File Offset: 0x00255730
		public FloroRanchActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x0600784B RID: 30795 RVA: 0x00257540 File Offset: 0x00255740
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

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x0600784C RID: 30796 RVA: 0x0025757C File Offset: 0x0025577C
		public int ActivityType
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x0600784D RID: 30797 RVA: 0x002575B8 File Offset: 0x002557B8
		public int TechTreeCoinId
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

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x0600784E RID: 30798 RVA: 0x002575F4 File Offset: 0x002557F4
		public int ResetGachaBaseCost
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

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x0600784F RID: 30799 RVA: 0x00257634 File Offset: 0x00255834
		public int ResetGachaRiseCost
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

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06007850 RID: 30800 RVA: 0x00257674 File Offset: 0x00255874
		public int ResetShopBaseCost
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

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x06007851 RID: 30801 RVA: 0x002576B4 File Offset: 0x002558B4
		public int ResetShopRiseCost
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

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x06007852 RID: 30802 RVA: 0x002576F4 File Offset: 0x002558F4
		public int UnlimitedParamBase
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

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06007853 RID: 30803 RVA: 0x00257734 File Offset: 0x00255934
		public int UnlimitedParamRise
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

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x06007854 RID: 30804 RVA: 0x00257774 File Offset: 0x00255974
		public int EventCD
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

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x06007855 RID: 30805 RVA: 0x002577B4 File Offset: 0x002559B4
		public int Speed
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

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06007856 RID: 30806 RVA: 0x002577F4 File Offset: 0x002559F4
		public int MilestoneItemId
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

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06007857 RID: 30807 RVA: 0x00257834 File Offset: 0x00255A34
		public int CardItemId
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

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06007858 RID: 30808 RVA: 0x00257874 File Offset: 0x00255A74
		public int MaxToyNum
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

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06007859 RID: 30809 RVA: 0x002578B4 File Offset: 0x00255AB4
		public int TechPointItem
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

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x0600785A RID: 30810 RVA: 0x002578F4 File Offset: 0x00255AF4
		public int AnimalNumLimit
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

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x0600785B RID: 30811 RVA: 0x00257934 File Offset: 0x00255B34
		public int ComicIntervalTime
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

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x0600785C RID: 30812 RVA: 0x00257974 File Offset: 0x00255B74
		public int RecommendQuestId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x002579B4 File Offset: 0x00255BB4
		public int RecommendQuestLinkList(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x0600785E RID: 30814 RVA: 0x002579F4 File Offset: 0x00255BF4
		public int RecommendQuestLinkListLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x00257A20 File Offset: 0x00255C20
		public Span<int> GetRecommendQuestLinkListBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x00257A30 File Offset: 0x00255C30
		public int[] GetRecommendQuestLinkListArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06007861 RID: 30817 RVA: 0x00257A48 File Offset: 0x00255C48
		public string RecommendQuestLabel
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

		// Token: 0x06007862 RID: 30818 RVA: 0x00257A80 File Offset: 0x00255C80
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x00257A90 File Offset: 0x00255C90
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x00257AA8 File Offset: 0x00255CA8
		public string Spine(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06007865 RID: 30821 RVA: 0x00257AE4 File Offset: 0x00255CE4
		public int SpineLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x00257B10 File Offset: 0x00255D10
		public string SpineSkeletonData(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06007867 RID: 30823 RVA: 0x00257B4C File Offset: 0x00255D4C
		public int SpineSkeletonDataLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x00257B78 File Offset: 0x00255D78
		[NullableContext(1)]
		public int[] RecommendQuestLinkList()
		{
			return this.GetRecommendQuestLinkListArray();
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00257B80 File Offset: 0x00255D80
		[NullableContext(1)]
		public IEnumerable<int> RecommendQuestLinkListIter()
		{
			FloroRanchActivity.<RecommendQuestLinkListIter>d__60 <RecommendQuestLinkListIter>d__ = new FloroRanchActivity.<RecommendQuestLinkListIter>d__60(-2);
			<RecommendQuestLinkListIter>d__.<>3__<>4__this = this;
			return <RecommendQuestLinkListIter>d__;
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00257B95 File Offset: 0x00255D95
		[NullableContext(1)]
		public string[] Spine()
		{
			return this.SpineIter().ToArray<string>();
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x00257BA2 File Offset: 0x00255DA2
		[NullableContext(1)]
		public IEnumerable<string> SpineIter()
		{
			FloroRanchActivity.<SpineIter>d__62 <SpineIter>d__ = new FloroRanchActivity.<SpineIter>d__62(-2);
			<SpineIter>d__.<>3__<>4__this = this;
			return <SpineIter>d__;
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x00257BB7 File Offset: 0x00255DB7
		[NullableContext(1)]
		public string[] SpineSkeletonData()
		{
			return this.SpineSkeletonDataIter().ToArray<string>();
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00257BC4 File Offset: 0x00255DC4
		[NullableContext(1)]
		public IEnumerable<string> SpineSkeletonDataIter()
		{
			FloroRanchActivity.<SpineSkeletonDataIter>d__64 <SpineSkeletonDataIter>d__ = new FloroRanchActivity.<SpineSkeletonDataIter>d__64(-2);
			<SpineSkeletonDataIter>d__.<>3__<>4__this = this;
			return <SpineSkeletonDataIter>d__;
		}

		// Token: 0x040052E1 RID: 21217
		private Table __p;
	}
}
