using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BFC RID: 3068
	public struct DragonPool : IFlatbufferObject
	{
		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06006333 RID: 25395 RVA: 0x002156A4 File Offset: 0x002138A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x002156B1 File Offset: 0x002138B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x002156B8 File Offset: 0x002138B8
		public static DragonPool GetRootAsDragonPool(ByteBuffer _bb)
		{
			return DragonPool.GetRootAsDragonPool(_bb, default(DragonPool));
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x002156D4 File Offset: 0x002138D4
		public static DragonPool GetRootAsDragonPool(ByteBuffer _bb, DragonPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x002156F1 File Offset: 0x002138F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006338 RID: 25400 RVA: 0x00215700 File Offset: 0x00213900
		public DragonPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06006339 RID: 25401 RVA: 0x00215710 File Offset: 0x00213910
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

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x0600633A RID: 25402 RVA: 0x0021574C File Offset: 0x0021394C
		public int CoreId
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

		// Token: 0x0600633B RID: 25403 RVA: 0x00215788 File Offset: 0x00213988
		public int Goal(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x0600633C RID: 25404 RVA: 0x002157C8 File Offset: 0x002139C8
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

		// Token: 0x0600633D RID: 25405 RVA: 0x002157F3 File Offset: 0x002139F3
		public Span<int> GetGoalBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x00215802 File Offset: 0x00213A02
		public int[] GetGoalArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x0021581C File Offset: 0x00213A1C
		public int DropIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06006340 RID: 25408 RVA: 0x0021585C File Offset: 0x00213A5C
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

		// Token: 0x06006341 RID: 25409 RVA: 0x00215888 File Offset: 0x00213A88
		public Span<int> GetDropIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x00215898 File Offset: 0x00213A98
		public int[] GetDropIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x002158B0 File Offset: 0x00213AB0
		public int DarkCoastDeliveryList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x002158F0 File Offset: 0x00213AF0
		public int DarkCoastDeliveryListLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x0021591C File Offset: 0x00213B1C
		public Span<int> GetDarkCoastDeliveryListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006346 RID: 25414 RVA: 0x0021592C File Offset: 0x00213B2C
		public int[] GetDarkCoastDeliveryListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06006347 RID: 25415 RVA: 0x00215944 File Offset: 0x00213B44
		public bool AutoTake
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x00215984 File Offset: 0x00213B84
		public string CanLevelUpTips(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06006349 RID: 25417 RVA: 0x002159C0 File Offset: 0x00213BC0
		public int CanLevelUpTipsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x0600634A RID: 25418 RVA: 0x002159EC File Offset: 0x00213BEC
		public int QuestId
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

		// Token: 0x0600634B RID: 25419 RVA: 0x00215A2C File Offset: 0x00213C2C
		public int PlotStateList(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x0600634C RID: 25420 RVA: 0x00215A6C File Offset: 0x00213C6C
		public int PlotStateListLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x00215A98 File Offset: 0x00213C98
		public Span<int> GetPlotStateListBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x00215AA8 File Offset: 0x00213CA8
		public int[] GetPlotStateListArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x00215AC0 File Offset: 0x00213CC0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CanLevelUpTipsIter()或GetCanLevelUpTipsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CanLevelUpTips()
		{
			return this.CanLevelUpTipsIter().ToArray<string>();
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x00215ACD File Offset: 0x00213CCD
		[NullableContext(1)]
		public readonly IEnumerable<string> CanLevelUpTipsIter()
		{
			DragonPool.<CanLevelUpTipsIter>d__40 <CanLevelUpTipsIter>d__ = new DragonPool.<CanLevelUpTipsIter>d__40(-2);
			<CanLevelUpTipsIter>d__.<>3__<>4__this = this;
			return <CanLevelUpTipsIter>d__;
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x00215AE4 File Offset: 0x00213CE4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DarkCoastDeliveryListIter()或GetDarkCoastDeliveryListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DarkCoastDeliveryList()
		{
			DragonPool dragonPool = this;
			return dragonPool.GetDarkCoastDeliveryListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x00215B08 File Offset: 0x00213D08
		[NullableContext(1)]
		public readonly IEnumerable<int> DarkCoastDeliveryListIter()
		{
			DragonPool.<DarkCoastDeliveryListIter>d__42 <DarkCoastDeliveryListIter>d__ = new DragonPool.<DarkCoastDeliveryListIter>d__42(-2);
			<DarkCoastDeliveryListIter>d__.<>3__<>4__this = this;
			return <DarkCoastDeliveryListIter>d__;
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x00215B20 File Offset: 0x00213D20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DropIdsIter()或GetDropIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DropIds()
		{
			DragonPool dragonPool = this;
			return dragonPool.GetDropIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x00215B44 File Offset: 0x00213D44
		[NullableContext(1)]
		public readonly IEnumerable<int> DropIdsIter()
		{
			DragonPool.<DropIdsIter>d__44 <DropIdsIter>d__ = new DragonPool.<DropIdsIter>d__44(-2);
			<DropIdsIter>d__.<>3__<>4__this = this;
			return <DropIdsIter>d__;
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x00215B5C File Offset: 0x00213D5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GoalIter()或GetGoalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Goal()
		{
			DragonPool dragonPool = this;
			return dragonPool.GetGoalArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x00215B80 File Offset: 0x00213D80
		[NullableContext(1)]
		public readonly IEnumerable<int> GoalIter()
		{
			DragonPool.<GoalIter>d__46 <GoalIter>d__ = new DragonPool.<GoalIter>d__46(-2);
			<GoalIter>d__.<>3__<>4__this = this;
			return <GoalIter>d__;
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x00215B98 File Offset: 0x00213D98
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlotStateListIter()或GetPlotStateListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PlotStateList()
		{
			DragonPool dragonPool = this;
			return dragonPool.GetPlotStateListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006358 RID: 25432 RVA: 0x00215BBC File Offset: 0x00213DBC
		[NullableContext(1)]
		public readonly IEnumerable<int> PlotStateListIter()
		{
			DragonPool.<PlotStateListIter>d__48 <PlotStateListIter>d__ = new DragonPool.<PlotStateListIter>d__48(-2);
			<PlotStateListIter>d__.<>3__<>4__this = this;
			return <PlotStateListIter>d__;
		}

		// Token: 0x04004C29 RID: 19497
		private Table __p;
	}
}
