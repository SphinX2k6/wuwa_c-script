using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7D RID: 3965
	public struct QuestTreeNode : IFlatbufferObject
	{
		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x0600B6DD RID: 46813 RVA: 0x002D26B0 File Offset: 0x002D08B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x002D26BD File Offset: 0x002D08BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x002D26C4 File Offset: 0x002D08C4
		public static QuestTreeNode GetRootAsQuestTreeNode(ByteBuffer _bb)
		{
			return QuestTreeNode.GetRootAsQuestTreeNode(_bb, default(QuestTreeNode));
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x002D26E0 File Offset: 0x002D08E0
		public static QuestTreeNode GetRootAsQuestTreeNode(ByteBuffer _bb, QuestTreeNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x002D26FD File Offset: 0x002D08FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x002D270C File Offset: 0x002D090C
		public QuestTreeNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x0600B6E3 RID: 46819 RVA: 0x002D271C File Offset: 0x002D091C
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

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x0600B6E4 RID: 46820 RVA: 0x002D2758 File Offset: 0x002D0958
		public int ChapterId
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

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x002D2794 File Offset: 0x002D0994
		public int QuestArray(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x0600B6E6 RID: 46822 RVA: 0x002D27D4 File Offset: 0x002D09D4
		public int QuestArrayLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B6E7 RID: 46823 RVA: 0x002D27FF File Offset: 0x002D09FF
		public Span<int> GetQuestArrayBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x002D280E File Offset: 0x002D0A0E
		public int[] GetQuestArrayArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x002D2828 File Offset: 0x002D0A28
		public int CompleteQuestID(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x0600B6EA RID: 46826 RVA: 0x002D2868 File Offset: 0x002D0A68
		public int CompleteQuestIDLength
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

		// Token: 0x0600B6EB RID: 46827 RVA: 0x002D2894 File Offset: 0x002D0A94
		public Span<int> GetCompleteQuestIDBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x002D28A4 File Offset: 0x002D0AA4
		public int[] GetCompleteQuestIDArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x0600B6ED RID: 46829 RVA: 0x002D28BC File Offset: 0x002D0ABC
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

		// Token: 0x0600B6EE RID: 46830 RVA: 0x002D28F4 File Offset: 0x002D0AF4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x002D2904 File Offset: 0x002D0B04
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x0600B6F0 RID: 46832 RVA: 0x002D291C File Offset: 0x002D0B1C
		public string QuestChapterName
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

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x002D2954 File Offset: 0x002D0B54
		public Span<byte> GetQuestChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x002D2964 File Offset: 0x002D0B64
		public byte[] GetQuestChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x0600B6F3 RID: 46835 RVA: 0x002D297C File Offset: 0x002D0B7C
		public int QuestType
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

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x0600B6F4 RID: 46836 RVA: 0x002D29BC File Offset: 0x002D0BBC
		public int NodeType
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

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x0600B6F5 RID: 46837 RVA: 0x002D29FC File Offset: 0x002D0BFC
		public int MainQuestNode
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

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x002D2A3C File Offset: 0x002D0C3C
		public int PreNode(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0600B6F7 RID: 46839 RVA: 0x002D2A7C File Offset: 0x002D0C7C
		public int PreNodeLength
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

		// Token: 0x0600B6F8 RID: 46840 RVA: 0x002D2AA8 File Offset: 0x002D0CA8
		public Span<int> GetPreNodeBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x002D2AB8 File Offset: 0x002D0CB8
		public int[] GetPreNodeArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0600B6FA RID: 46842 RVA: 0x002D2AD0 File Offset: 0x002D0CD0
		public int NextNode
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

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x0600B6FB RID: 46843 RVA: 0x002D2B10 File Offset: 0x002D0D10
		public bool IsChapterEnding
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x002D2B50 File Offset: 0x002D0D50
		public int IncludeNodes(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x0600B6FD RID: 46845 RVA: 0x002D2B90 File Offset: 0x002D0D90
		public int IncludeNodesLength
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

		// Token: 0x0600B6FE RID: 46846 RVA: 0x002D2BBC File Offset: 0x002D0DBC
		public Span<int> GetIncludeNodesBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x002D2BCC File Offset: 0x002D0DCC
		public int[] GetIncludeNodesArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x002D2BE4 File Offset: 0x002D0DE4
		public int UnlockConditions(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x0600B701 RID: 46849 RVA: 0x002D2C24 File Offset: 0x002D0E24
		public int UnlockConditionsLength
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

		// Token: 0x0600B702 RID: 46850 RVA: 0x002D2C50 File Offset: 0x002D0E50
		public Span<int> GetUnlockConditionsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x002D2C60 File Offset: 0x002D0E60
		public int[] GetUnlockConditionsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x0600B704 RID: 46852 RVA: 0x002D2C78 File Offset: 0x002D0E78
		public string ChapterName
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

		// Token: 0x0600B705 RID: 46853 RVA: 0x002D2CB0 File Offset: 0x002D0EB0
		public Span<byte> GetChapterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x002D2CC0 File Offset: 0x002D0EC0
		public byte[] GetChapterNameArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x0600B707 RID: 46855 RVA: 0x002D2CD8 File Offset: 0x002D0ED8
		public int AccessPath
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

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x0600B708 RID: 46856 RVA: 0x002D2D18 File Offset: 0x002D0F18
		public string AccessDesc
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

		// Token: 0x0600B709 RID: 46857 RVA: 0x002D2D50 File Offset: 0x002D0F50
		public Span<byte> GetAccessDescBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x002D2D60 File Offset: 0x002D0F60
		public byte[] GetAccessDescArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x0600B70B RID: 46859 RVA: 0x002D2D78 File Offset: 0x002D0F78
		public bool ShowQuestReward
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x0600B70C RID: 46860 RVA: 0x002D2DB8 File Offset: 0x002D0FB8
		public int SortOrder
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x0600B70D RID: 46861 RVA: 0x002D2DF8 File Offset: 0x002D0FF8
		public string Summary
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

		// Token: 0x0600B70E RID: 46862 RVA: 0x002D2E30 File Offset: 0x002D1030
		public Span<byte> GetSummaryBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x002D2E40 File Offset: 0x002D1040
		public byte[] GetSummaryArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x0600B710 RID: 46864 RVA: 0x002D2E58 File Offset: 0x002D1058
		public string ImageSmall
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

		// Token: 0x0600B711 RID: 46865 RVA: 0x002D2E90 File Offset: 0x002D1090
		public Span<byte> GetImageSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600B712 RID: 46866 RVA: 0x002D2EA0 File Offset: 0x002D10A0
		public byte[] GetImageSmallArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x0600B713 RID: 46867 RVA: 0x002D2EB8 File Offset: 0x002D10B8
		public string ImageSmallFemale
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

		// Token: 0x0600B714 RID: 46868 RVA: 0x002D2EF0 File Offset: 0x002D10F0
		public Span<byte> GetImageSmallFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600B715 RID: 46869 RVA: 0x002D2F00 File Offset: 0x002D1100
		public byte[] GetImageSmallFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x0600B716 RID: 46870 RVA: 0x002D2F18 File Offset: 0x002D1118
		public string ImageLarge
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

		// Token: 0x0600B717 RID: 46871 RVA: 0x002D2F50 File Offset: 0x002D1150
		public Span<byte> GetImageLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x002D2F60 File Offset: 0x002D1160
		public byte[] GetImageLargeArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x0600B719 RID: 46873 RVA: 0x002D2F78 File Offset: 0x002D1178
		public string ImageLargeFemale
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x002D2FB0 File Offset: 0x002D11B0
		public Span<byte> GetImageLargeFemaleBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x002D2FC0 File Offset: 0x002D11C0
		public byte[] GetImageLargeFemaleArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x0600B71C RID: 46876 RVA: 0x002D2FD8 File Offset: 0x002D11D8
		public int RecallId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x002D3018 File Offset: 0x002D1218
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CompleteQuestIDIter()或GetCompleteQuestIDBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CompleteQuestID()
		{
			QuestTreeNode questTreeNode = this;
			return questTreeNode.GetCompleteQuestIDArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x002D303C File Offset: 0x002D123C
		[NullableContext(1)]
		public readonly IEnumerable<int> CompleteQuestIDIter()
		{
			QuestTreeNode.<CompleteQuestIDIter>d__92 <CompleteQuestIDIter>d__ = new QuestTreeNode.<CompleteQuestIDIter>d__92(-2);
			<CompleteQuestIDIter>d__.<>3__<>4__this = this;
			return <CompleteQuestIDIter>d__;
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x002D3054 File Offset: 0x002D1254
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IncludeNodesIter()或GetIncludeNodesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] IncludeNodes()
		{
			QuestTreeNode questTreeNode = this;
			return questTreeNode.GetIncludeNodesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x002D3078 File Offset: 0x002D1278
		[NullableContext(1)]
		public readonly IEnumerable<int> IncludeNodesIter()
		{
			QuestTreeNode.<IncludeNodesIter>d__94 <IncludeNodesIter>d__ = new QuestTreeNode.<IncludeNodesIter>d__94(-2);
			<IncludeNodesIter>d__.<>3__<>4__this = this;
			return <IncludeNodesIter>d__;
		}

		// Token: 0x0600B721 RID: 46881 RVA: 0x002D3090 File Offset: 0x002D1290
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreNodeIter()或GetPreNodeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreNode()
		{
			QuestTreeNode questTreeNode = this;
			return questTreeNode.GetPreNodeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B722 RID: 46882 RVA: 0x002D30B4 File Offset: 0x002D12B4
		[NullableContext(1)]
		public readonly IEnumerable<int> PreNodeIter()
		{
			QuestTreeNode.<PreNodeIter>d__96 <PreNodeIter>d__ = new QuestTreeNode.<PreNodeIter>d__96(-2);
			<PreNodeIter>d__.<>3__<>4__this = this;
			return <PreNodeIter>d__;
		}

		// Token: 0x0600B723 RID: 46883 RVA: 0x002D30CC File Offset: 0x002D12CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestArrayIter()或GetQuestArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuestArray()
		{
			QuestTreeNode questTreeNode = this;
			return questTreeNode.GetQuestArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x002D30F0 File Offset: 0x002D12F0
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestArrayIter()
		{
			QuestTreeNode.<QuestArrayIter>d__98 <QuestArrayIter>d__ = new QuestTreeNode.<QuestArrayIter>d__98(-2);
			<QuestArrayIter>d__.<>3__<>4__this = this;
			return <QuestArrayIter>d__;
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x002D3108 File Offset: 0x002D1308
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockConditionsIter()或GetUnlockConditionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnlockConditions()
		{
			QuestTreeNode questTreeNode = this;
			return questTreeNode.GetUnlockConditionsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x002D312C File Offset: 0x002D132C
		[NullableContext(1)]
		public readonly IEnumerable<int> UnlockConditionsIter()
		{
			QuestTreeNode.<UnlockConditionsIter>d__100 <UnlockConditionsIter>d__ = new QuestTreeNode.<UnlockConditionsIter>d__100(-2);
			<UnlockConditionsIter>d__.<>3__<>4__this = this;
			return <UnlockConditionsIter>d__;
		}

		// Token: 0x0400504B RID: 20555
		private Table __p;
	}
}
