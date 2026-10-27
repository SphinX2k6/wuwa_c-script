using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D1D RID: 3357
	public struct GuideTutorial : IFlatbufferObject
	{
		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06007D51 RID: 32081 RVA: 0x0025189F File Offset: 0x0024FA9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007D52 RID: 32082 RVA: 0x002518AC File Offset: 0x0024FAAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x002518B4 File Offset: 0x0024FAB4
		public static GuideTutorial GetRootAsGuideTutorial(ByteBuffer _bb)
		{
			return GuideTutorial.GetRootAsGuideTutorial(_bb, default(GuideTutorial));
		}

		// Token: 0x06007D54 RID: 32084 RVA: 0x002518D0 File Offset: 0x0024FAD0
		public static GuideTutorial GetRootAsGuideTutorial(ByteBuffer _bb, GuideTutorial obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007D55 RID: 32085 RVA: 0x002518ED File Offset: 0x0024FAED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007D56 RID: 32086 RVA: 0x002518FC File Offset: 0x0024FAFC
		public GuideTutorial __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06007D57 RID: 32087 RVA: 0x0025190C File Offset: 0x0024FB0C
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

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06007D58 RID: 32088 RVA: 0x00251948 File Offset: 0x0024FB48
		public int TutorialType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 11;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06007D59 RID: 32089 RVA: 0x00251988 File Offset: 0x0024FB88
		public int TutorialOrder
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

		// Token: 0x06007D5A RID: 32090 RVA: 0x002519C4 File Offset: 0x0024FBC4
		public int PageId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x06007D5B RID: 32091 RVA: 0x00251A04 File Offset: 0x0024FC04
		public int PageIdLength
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

		// Token: 0x06007D5C RID: 32092 RVA: 0x00251A30 File Offset: 0x0024FC30
		public Span<int> GetPageIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x00251A40 File Offset: 0x0024FC40
		public int[] GetPageIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x06007D5E RID: 32094 RVA: 0x00251A58 File Offset: 0x0024FC58
		public int PageReplaceConditionGroupId
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

		// Token: 0x06007D5F RID: 32095 RVA: 0x00251A98 File Offset: 0x0024FC98
		public int ReplacePageId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x00251AD8 File Offset: 0x0024FCD8
		public int ReplacePageIdLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007D61 RID: 32097 RVA: 0x00251B04 File Offset: 0x0024FD04
		public Span<int> GetReplacePageIdBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x00251B14 File Offset: 0x0024FD14
		public int[] GetReplacePageIdArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06007D63 RID: 32099 RVA: 0x00251B2C File Offset: 0x0024FD2C
		public string GroupName
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

		// Token: 0x06007D64 RID: 32100 RVA: 0x00251B64 File Offset: 0x0024FD64
		public Span<byte> GetGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007D65 RID: 32101 RVA: 0x00251B74 File Offset: 0x0024FD74
		public byte[] GetGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06007D66 RID: 32102 RVA: 0x00251B8C File Offset: 0x0024FD8C
		public int ExclusiveType
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

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06007D67 RID: 32103 RVA: 0x00251BCC File Offset: 0x0024FDCC
		public bool TutorialTip
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06007D68 RID: 32104 RVA: 0x00251C0C File Offset: 0x0024FE0C
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 100001;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06007D69 RID: 32105 RVA: 0x00251C50 File Offset: 0x0024FE50
		public bool DisableDropReward
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x00251C90 File Offset: 0x0024FE90
		public bool RequireReadAll
		{
			get
			{
				int num = this.__p.__offset(26);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06007D6B RID: 32107 RVA: 0x00251CD0 File Offset: 0x0024FED0
		public bool ExcludeFromWiki
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06007D6C RID: 32108 RVA: 0x00251D10 File Offset: 0x0024FF10
		public int CopiedFrom
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

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06007D6D RID: 32109 RVA: 0x00251D50 File Offset: 0x0024FF50
		public bool DefaultUnlock
		{
			get
			{
				int num = this.__p.__offset(32);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06007D6E RID: 32110 RVA: 0x00251D90 File Offset: 0x0024FF90
		public bool SilentUnlock
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06007D6F RID: 32111 RVA: 0x00251DD0 File Offset: 0x0024FFD0
		public int ShowLayer
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

		// Token: 0x06007D70 RID: 32112 RVA: 0x00251E10 File Offset: 0x00250010
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PageIdIter()或GetPageIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PageId()
		{
			GuideTutorial guideTutorial = this;
			return guideTutorial.GetPageIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x00251E34 File Offset: 0x00250034
		[NullableContext(1)]
		public readonly IEnumerable<int> PageIdIter()
		{
			GuideTutorial.<PageIdIter>d__51 <PageIdIter>d__ = new GuideTutorial.<PageIdIter>d__51(-2);
			<PageIdIter>d__.<>3__<>4__this = this;
			return <PageIdIter>d__;
		}

		// Token: 0x06007D72 RID: 32114 RVA: 0x00251E4C File Offset: 0x0025004C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReplacePageIdIter()或GetReplacePageIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ReplacePageId()
		{
			GuideTutorial guideTutorial = this;
			return guideTutorial.GetReplacePageIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x00251E70 File Offset: 0x00250070
		[NullableContext(1)]
		public readonly IEnumerable<int> ReplacePageIdIter()
		{
			GuideTutorial.<ReplacePageIdIter>d__53 <ReplacePageIdIter>d__ = new GuideTutorial.<ReplacePageIdIter>d__53(-2);
			<ReplacePageIdIter>d__.<>3__<>4__this = this;
			return <ReplacePageIdIter>d__;
		}

		// Token: 0x04004D95 RID: 19861
		private Table __p;
	}
}
