using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D15 RID: 3349
	public struct GuideDownLoadQuest : IFlatbufferObject
	{
		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x0024F6F8 File Offset: 0x0024D8F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x0024F705 File Offset: 0x0024D905
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x0024F70C File Offset: 0x0024D90C
		public static GuideDownLoadQuest GetRootAsGuideDownLoadQuest(ByteBuffer _bb)
		{
			return GuideDownLoadQuest.GetRootAsGuideDownLoadQuest(_bb, default(GuideDownLoadQuest));
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x0024F728 File Offset: 0x0024D928
		public static GuideDownLoadQuest GetRootAsGuideDownLoadQuest(ByteBuffer _bb, GuideDownLoadQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x0024F745 File Offset: 0x0024D945
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x0024F754 File Offset: 0x0024D954
		public GuideDownLoadQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06007C6B RID: 31851 RVA: 0x0024F764 File Offset: 0x0024D964
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

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06007C6C RID: 31852 RVA: 0x0024F7A0 File Offset: 0x0024D9A0
		public int QuestId
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

		// Token: 0x06007C6D RID: 31853 RVA: 0x0024F7DC File Offset: 0x0024D9DC
		public int SubPackageList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06007C6E RID: 31854 RVA: 0x0024F81C File Offset: 0x0024DA1C
		public int SubPackageListLength
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

		// Token: 0x06007C6F RID: 31855 RVA: 0x0024F847 File Offset: 0x0024DA47
		public Span<int> GetSubPackageListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x0024F856 File Offset: 0x0024DA56
		public int[] GetSubPackageListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007C71 RID: 31857 RVA: 0x0024F870 File Offset: 0x0024DA70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SubPackageListIter()或GetSubPackageListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SubPackageList()
		{
			GuideDownLoadQuest guideDownLoadQuest = this;
			return guideDownLoadQuest.GetSubPackageListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007C72 RID: 31858 RVA: 0x0024F894 File Offset: 0x0024DA94
		[NullableContext(1)]
		public readonly IEnumerable<int> SubPackageListIter()
		{
			GuideDownLoadQuest.<SubPackageListIter>d__18 <SubPackageListIter>d__ = new GuideDownLoadQuest.<SubPackageListIter>d__18(-2);
			<SubPackageListIter>d__.<>3__<>4__this = this;
			return <SubPackageListIter>d__;
		}

		// Token: 0x04004D8D RID: 19853
		private Table __p;
	}
}
