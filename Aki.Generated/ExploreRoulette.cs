using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C51 RID: 3153
	public struct ExploreRoulette : IFlatbufferObject
	{
		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06006BAE RID: 27566 RVA: 0x00228D6C File Offset: 0x00226F6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x00228D79 File Offset: 0x00226F79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x00228D80 File Offset: 0x00226F80
		public static ExploreRoulette GetRootAsExploreRoulette(ByteBuffer _bb)
		{
			return ExploreRoulette.GetRootAsExploreRoulette(_bb, default(ExploreRoulette));
		}

		// Token: 0x06006BB1 RID: 27569 RVA: 0x00228D9C File Offset: 0x00226F9C
		public static ExploreRoulette GetRootAsExploreRoulette(ByteBuffer _bb, ExploreRoulette obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BB2 RID: 27570 RVA: 0x00228DB9 File Offset: 0x00226FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BB3 RID: 27571 RVA: 0x00228DC8 File Offset: 0x00226FC8
		public ExploreRoulette __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x00228DD8 File Offset: 0x00226FD8
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

		// Token: 0x06006BB5 RID: 27573 RVA: 0x00228E14 File Offset: 0x00227014
		public string BanTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06006BB6 RID: 27574 RVA: 0x00228E50 File Offset: 0x00227050
		public int BanTagsLength
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

		// Token: 0x06006BB7 RID: 27575 RVA: 0x00228E7B File Offset: 0x0022707B
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BanTagsIter()或GetBanTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BanTags()
		{
			return this.BanTagsIter().ToArray<string>();
		}

		// Token: 0x06006BB8 RID: 27576 RVA: 0x00228E88 File Offset: 0x00227088
		[NullableContext(1)]
		public readonly IEnumerable<string> BanTagsIter()
		{
			ExploreRoulette.<BanTagsIter>d__14 <BanTagsIter>d__ = new ExploreRoulette.<BanTagsIter>d__14(-2);
			<BanTagsIter>d__.<>3__<>4__this = this;
			return <BanTagsIter>d__;
		}

		// Token: 0x04004C98 RID: 19608
		private Table __p;
	}
}
