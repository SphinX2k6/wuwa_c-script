using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE9 RID: 2793
	public struct AiBattleWander : IFlatbufferObject
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06004652 RID: 18002 RVA: 0x001D24C1 File Offset: 0x001D06C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x001D24CE File Offset: 0x001D06CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x001D24D8 File Offset: 0x001D06D8
		public static AiBattleWander GetRootAsAiBattleWander(ByteBuffer _bb)
		{
			return AiBattleWander.GetRootAsAiBattleWander(_bb, default(AiBattleWander));
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x001D24F4 File Offset: 0x001D06F4
		public static AiBattleWander GetRootAsAiBattleWander(ByteBuffer _bb, AiBattleWander obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x001D2511 File Offset: 0x001D0711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x001D2520 File Offset: 0x001D0720
		public AiBattleWander __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06004658 RID: 18008 RVA: 0x001D2530 File Offset: 0x001D0730
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

		// Token: 0x06004659 RID: 18009 RVA: 0x001D256C File Offset: 0x001D076C
		public int GroupIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600465A RID: 18010 RVA: 0x001D25AC File Offset: 0x001D07AC
		public int GroupIdsLength
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

		// Token: 0x0600465B RID: 18011 RVA: 0x001D25D7 File Offset: 0x001D07D7
		public Span<int> GetGroupIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x001D25E6 File Offset: 0x001D07E6
		public int[] GetGroupIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x001D2600 File Offset: 0x001D0800
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupIdsIter()或GetGroupIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupIds()
		{
			AiBattleWander aiBattleWander = this;
			return aiBattleWander.GetGroupIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x001D2624 File Offset: 0x001D0824
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupIdsIter()
		{
			AiBattleWander.<GroupIdsIter>d__16 <GroupIdsIter>d__ = new AiBattleWander.<GroupIdsIter>d__16(-2);
			<GroupIdsIter>d__.<>3__<>4__this = this;
			return <GroupIdsIter>d__;
		}

		// Token: 0x04004ACA RID: 19146
		private Table __p;
	}
}
