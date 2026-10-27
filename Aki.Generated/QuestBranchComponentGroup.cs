using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F65 RID: 3941
	public struct QuestBranchComponentGroup : IFlatbufferObject
	{
		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x0600B4DC RID: 46300 RVA: 0x002CE648 File Offset: 0x002CC848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x002CE655 File Offset: 0x002CC855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x002CE65C File Offset: 0x002CC85C
		public static QuestBranchComponentGroup GetRootAsQuestBranchComponentGroup(ByteBuffer _bb)
		{
			return QuestBranchComponentGroup.GetRootAsQuestBranchComponentGroup(_bb, default(QuestBranchComponentGroup));
		}

		// Token: 0x0600B4DF RID: 46303 RVA: 0x002CE678 File Offset: 0x002CC878
		public static QuestBranchComponentGroup GetRootAsQuestBranchComponentGroup(ByteBuffer _bb, QuestBranchComponentGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x002CE695 File Offset: 0x002CC895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x002CE6A4 File Offset: 0x002CC8A4
		public QuestBranchComponentGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x0600B4E2 RID: 46306 RVA: 0x002CE6B4 File Offset: 0x002CC8B4
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

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x002CE6F0 File Offset: 0x002CC8F0
		public int BranchComponents(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x0600B4E4 RID: 46308 RVA: 0x002CE730 File Offset: 0x002CC930
		public int BranchComponentsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B4E5 RID: 46309 RVA: 0x002CE75B File Offset: 0x002CC95B
		public Span<int> GetBranchComponentsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B4E6 RID: 46310 RVA: 0x002CE76A File Offset: 0x002CC96A
		public int[] GetBranchComponentsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600B4E7 RID: 46311 RVA: 0x002CE784 File Offset: 0x002CC984
		public int ShownArea(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x0600B4E8 RID: 46312 RVA: 0x002CE7C4 File Offset: 0x002CC9C4
		public int ShownAreaLength
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

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x002CE7EF File Offset: 0x002CC9EF
		public Span<int> GetShownAreaBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600B4EA RID: 46314 RVA: 0x002CE7FE File Offset: 0x002CC9FE
		public int[] GetShownAreaArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x0600B4EB RID: 46315 RVA: 0x002CE818 File Offset: 0x002CCA18
		public int UnlockCondition
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

		// Token: 0x0600B4EC RID: 46316 RVA: 0x002CE858 File Offset: 0x002CCA58
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BranchComponentsIter()或GetBranchComponentsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BranchComponents()
		{
			QuestBranchComponentGroup questBranchComponentGroup = this;
			return questBranchComponentGroup.GetBranchComponentsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x002CE87C File Offset: 0x002CCA7C
		[NullableContext(1)]
		public readonly IEnumerable<int> BranchComponentsIter()
		{
			QuestBranchComponentGroup.<BranchComponentsIter>d__23 <BranchComponentsIter>d__ = new QuestBranchComponentGroup.<BranchComponentsIter>d__23(-2);
			<BranchComponentsIter>d__.<>3__<>4__this = this;
			return <BranchComponentsIter>d__;
		}

		// Token: 0x0600B4EE RID: 46318 RVA: 0x002CE894 File Offset: 0x002CCA94
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShownAreaIter()或GetShownAreaBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShownArea()
		{
			QuestBranchComponentGroup questBranchComponentGroup = this;
			return questBranchComponentGroup.GetShownAreaArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B4EF RID: 46319 RVA: 0x002CE8B8 File Offset: 0x002CCAB8
		[NullableContext(1)]
		public readonly IEnumerable<int> ShownAreaIter()
		{
			QuestBranchComponentGroup.<ShownAreaIter>d__25 <ShownAreaIter>d__ = new QuestBranchComponentGroup.<ShownAreaIter>d__25(-2);
			<ShownAreaIter>d__.<>3__<>4__this = this;
			return <ShownAreaIter>d__;
		}

		// Token: 0x04005033 RID: 20531
		private Table __p;
	}
}
