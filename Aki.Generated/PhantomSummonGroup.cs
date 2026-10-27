using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFB RID: 3835
	public struct PhantomSummonGroup : IFlatbufferObject
	{
		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x0600AA7C RID: 43644 RVA: 0x002B7955 File Offset: 0x002B5B55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x002B7962 File Offset: 0x002B5B62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x002B796C File Offset: 0x002B5B6C
		public static PhantomSummonGroup GetRootAsPhantomSummonGroup(ByteBuffer _bb)
		{
			return PhantomSummonGroup.GetRootAsPhantomSummonGroup(_bb, default(PhantomSummonGroup));
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x002B7988 File Offset: 0x002B5B88
		public static PhantomSummonGroup GetRootAsPhantomSummonGroup(ByteBuffer _bb, PhantomSummonGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x002B79A5 File Offset: 0x002B5BA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA81 RID: 43649 RVA: 0x002B79B4 File Offset: 0x002B5BB4
		public PhantomSummonGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600AA82 RID: 43650 RVA: 0x002B79C4 File Offset: 0x002B5BC4
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

		// Token: 0x0600AA83 RID: 43651 RVA: 0x002B7A00 File Offset: 0x002B5C00
		public int GroupMonsterIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x0600AA84 RID: 43652 RVA: 0x002B7A40 File Offset: 0x002B5C40
		public int GroupMonsterIdsLength
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

		// Token: 0x0600AA85 RID: 43653 RVA: 0x002B7A6B File Offset: 0x002B5C6B
		public Span<int> GetGroupMonsterIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AA86 RID: 43654 RVA: 0x002B7A7A File Offset: 0x002B5C7A
		public int[] GetGroupMonsterIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600AA87 RID: 43655 RVA: 0x002B7A94 File Offset: 0x002B5C94
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupMonsterIdsIter()或GetGroupMonsterIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupMonsterIds()
		{
			PhantomSummonGroup phantomSummonGroup = this;
			return phantomSummonGroup.GetGroupMonsterIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x002B7AB8 File Offset: 0x002B5CB8
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupMonsterIdsIter()
		{
			PhantomSummonGroup.<GroupMonsterIdsIter>d__16 <GroupMonsterIdsIter>d__ = new PhantomSummonGroup.<GroupMonsterIdsIter>d__16(-2);
			<GroupMonsterIdsIter>d__.<>3__<>4__this = this;
			return <GroupMonsterIdsIter>d__;
		}

		// Token: 0x04004FC2 RID: 20418
		private Table __p;
	}
}
