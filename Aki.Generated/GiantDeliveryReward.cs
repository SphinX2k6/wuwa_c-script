using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF9 RID: 3321
	public struct GiantDeliveryReward : IFlatbufferObject
	{
		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06007A37 RID: 31287 RVA: 0x0024A88D File Offset: 0x00248A8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x0024A89A File Offset: 0x00248A9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x0024A8A4 File Offset: 0x00248AA4
		public static GiantDeliveryReward GetRootAsGiantDeliveryReward(ByteBuffer _bb)
		{
			return GiantDeliveryReward.GetRootAsGiantDeliveryReward(_bb, default(GiantDeliveryReward));
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x0024A8C0 File Offset: 0x00248AC0
		public static GiantDeliveryReward GetRootAsGiantDeliveryReward(ByteBuffer _bb, GiantDeliveryReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x0024A8DD File Offset: 0x00248ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x0024A8EC File Offset: 0x00248AEC
		public GiantDeliveryReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06007A3D RID: 31293 RVA: 0x0024A8FC File Offset: 0x00248AFC
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

		// Token: 0x06007A3E RID: 31294 RVA: 0x0024A938 File Offset: 0x00248B38
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06007A3F RID: 31295 RVA: 0x0024A978 File Offset: 0x00248B78
		public int ItemIdsLength
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

		// Token: 0x06007A40 RID: 31296 RVA: 0x0024A9A3 File Offset: 0x00248BA3
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x0024A9B2 File Offset: 0x00248BB2
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x0024A9CC File Offset: 0x00248BCC
		public int Goal(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06007A43 RID: 31299 RVA: 0x0024AA0C File Offset: 0x00248C0C
		public int GoalLength
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

		// Token: 0x06007A44 RID: 31300 RVA: 0x0024AA37 File Offset: 0x00248C37
		public Span<int> GetGoalBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x0024AA46 File Offset: 0x00248C46
		public int[] GetGoalArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x0024AA60 File Offset: 0x00248C60
		public int DropIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06007A47 RID: 31303 RVA: 0x0024AAA0 File Offset: 0x00248CA0
		public int DropIdsLength
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

		// Token: 0x06007A48 RID: 31304 RVA: 0x0024AACC File Offset: 0x00248CCC
		public Span<int> GetDropIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x0024AADC File Offset: 0x00248CDC
		public int[] GetDropIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06007A4A RID: 31306 RVA: 0x0024AAF4 File Offset: 0x00248CF4
		public int UnlockCondition
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

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06007A4B RID: 31307 RVA: 0x0024AB34 File Offset: 0x00248D34
		public int MaxLevelCost
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

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06007A4C RID: 31308 RVA: 0x0024AB74 File Offset: 0x00248D74
		public int MaxLevelDropId
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

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06007A4D RID: 31309 RVA: 0x0024ABB4 File Offset: 0x00248DB4
		public int MaxStableValue
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

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06007A4E RID: 31310 RVA: 0x0024ABF4 File Offset: 0x00248DF4
		public int MaxDeliveryCount
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

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06007A4F RID: 31311 RVA: 0x0024AC34 File Offset: 0x00248E34
		public int AltarMarkId
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

		// Token: 0x06007A50 RID: 31312 RVA: 0x0024AC74 File Offset: 0x00248E74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DropIdsIter()或GetDropIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DropIds()
		{
			GiantDeliveryReward giantDeliveryReward = this;
			return giantDeliveryReward.GetDropIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x0024AC98 File Offset: 0x00248E98
		[NullableContext(1)]
		public readonly IEnumerable<int> DropIdsIter()
		{
			GiantDeliveryReward.<DropIdsIter>d__38 <DropIdsIter>d__ = new GiantDeliveryReward.<DropIdsIter>d__38(-2);
			<DropIdsIter>d__.<>3__<>4__this = this;
			return <DropIdsIter>d__;
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x0024ACB0 File Offset: 0x00248EB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GoalIter()或GetGoalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Goal()
		{
			GiantDeliveryReward giantDeliveryReward = this;
			return giantDeliveryReward.GetGoalArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x0024ACD4 File Offset: 0x00248ED4
		[NullableContext(1)]
		public readonly IEnumerable<int> GoalIter()
		{
			GiantDeliveryReward.<GoalIter>d__40 <GoalIter>d__ = new GiantDeliveryReward.<GoalIter>d__40(-2);
			<GoalIter>d__.<>3__<>4__this = this;
			return <GoalIter>d__;
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x0024ACEC File Offset: 0x00248EEC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemIdsIter()或GetItemIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemIds()
		{
			GiantDeliveryReward giantDeliveryReward = this;
			return giantDeliveryReward.GetItemIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x0024AD10 File Offset: 0x00248F10
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemIdsIter()
		{
			GiantDeliveryReward.<ItemIdsIter>d__42 <ItemIdsIter>d__ = new GiantDeliveryReward.<ItemIdsIter>d__42(-2);
			<ItemIdsIter>d__.<>3__<>4__this = this;
			return <ItemIdsIter>d__;
		}

		// Token: 0x04004D6C RID: 19820
		private Table __p;
	}
}
