using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ACF RID: 2767
	public struct ActivityTimeShow : IFlatbufferObject
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x001CDA29 File Offset: 0x001CBC29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x001CDA36 File Offset: 0x001CBC36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x001CDA40 File Offset: 0x001CBC40
		public static ActivityTimeShow GetRootAsActivityTimeShow(ByteBuffer _bb)
		{
			return ActivityTimeShow.GetRootAsActivityTimeShow(_bb, default(ActivityTimeShow));
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x001CDA5C File Offset: 0x001CBC5C
		public static ActivityTimeShow GetRootAsActivityTimeShow(ByteBuffer _bb, ActivityTimeShow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x001CDA79 File Offset: 0x001CBC79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x001CDA88 File Offset: 0x001CBC88
		public ActivityTimeShow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06004417 RID: 17431 RVA: 0x001CDA98 File Offset: 0x001CBC98
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

		// Token: 0x06004418 RID: 17432 RVA: 0x001CDAD4 File Offset: 0x001CBCD4
		public int RedInterval(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06004419 RID: 17433 RVA: 0x001CDB14 File Offset: 0x001CBD14
		public int RedIntervalLength
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

		// Token: 0x0600441A RID: 17434 RVA: 0x001CDB3F File Offset: 0x001CBD3F
		public Span<int> GetRedIntervalBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600441B RID: 17435 RVA: 0x001CDB4E File Offset: 0x001CBD4E
		public int[] GetRedIntervalArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600441C RID: 17436 RVA: 0x001CDB68 File Offset: 0x001CBD68
		public int YellowInterval(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600441D RID: 17437 RVA: 0x001CDBA8 File Offset: 0x001CBDA8
		public int YellowIntervalLength
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

		// Token: 0x0600441E RID: 17438 RVA: 0x001CDBD3 File Offset: 0x001CBDD3
		public Span<int> GetYellowIntervalBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x001CDBE2 File Offset: 0x001CBDE2
		public int[] GetYellowIntervalArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x001CDBFC File Offset: 0x001CBDFC
		public int WhiteInterval(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06004421 RID: 17441 RVA: 0x001CDC3C File Offset: 0x001CBE3C
		public int WhiteIntervalLength
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

		// Token: 0x06004422 RID: 17442 RVA: 0x001CDC68 File Offset: 0x001CBE68
		public Span<int> GetWhiteIntervalBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06004423 RID: 17443 RVA: 0x001CDC78 File Offset: 0x001CBE78
		public int[] GetWhiteIntervalArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x001CDC90 File Offset: 0x001CBE90
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RedIntervalIter()或GetRedIntervalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RedInterval()
		{
			ActivityTimeShow activityTimeShow = this;
			return activityTimeShow.GetRedIntervalArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x001CDCB4 File Offset: 0x001CBEB4
		[NullableContext(1)]
		public readonly IEnumerable<int> RedIntervalIter()
		{
			ActivityTimeShow.<RedIntervalIter>d__26 <RedIntervalIter>d__ = new ActivityTimeShow.<RedIntervalIter>d__26(-2);
			<RedIntervalIter>d__.<>3__<>4__this = this;
			return <RedIntervalIter>d__;
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x001CDCCC File Offset: 0x001CBECC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WhiteIntervalIter()或GetWhiteIntervalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WhiteInterval()
		{
			ActivityTimeShow activityTimeShow = this;
			return activityTimeShow.GetWhiteIntervalArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004427 RID: 17447 RVA: 0x001CDCF0 File Offset: 0x001CBEF0
		[NullableContext(1)]
		public readonly IEnumerable<int> WhiteIntervalIter()
		{
			ActivityTimeShow.<WhiteIntervalIter>d__28 <WhiteIntervalIter>d__ = new ActivityTimeShow.<WhiteIntervalIter>d__28(-2);
			<WhiteIntervalIter>d__.<>3__<>4__this = this;
			return <WhiteIntervalIter>d__;
		}

		// Token: 0x06004428 RID: 17448 RVA: 0x001CDD08 File Offset: 0x001CBF08
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用YellowIntervalIter()或GetYellowIntervalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] YellowInterval()
		{
			ActivityTimeShow activityTimeShow = this;
			return activityTimeShow.GetYellowIntervalArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x001CDD2C File Offset: 0x001CBF2C
		[NullableContext(1)]
		public readonly IEnumerable<int> YellowIntervalIter()
		{
			ActivityTimeShow.<YellowIntervalIter>d__30 <YellowIntervalIter>d__ = new ActivityTimeShow.<YellowIntervalIter>d__30(-2);
			<YellowIntervalIter>d__.<>3__<>4__this = this;
			return <YellowIntervalIter>d__;
		}

		// Token: 0x04004AAC RID: 19116
		private Table __p;
	}
}
