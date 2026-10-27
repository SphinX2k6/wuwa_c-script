using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F1F RID: 3871
	public struct PinballActivity : IFlatbufferObject
	{
		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x0600ADB2 RID: 44466 RVA: 0x002BEC31 File Offset: 0x002BCE31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ADB3 RID: 44467 RVA: 0x002BEC3E File Offset: 0x002BCE3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ADB4 RID: 44468 RVA: 0x002BEC48 File Offset: 0x002BCE48
		public static PinballActivity GetRootAsPinballActivity(ByteBuffer _bb)
		{
			return PinballActivity.GetRootAsPinballActivity(_bb, default(PinballActivity));
		}

		// Token: 0x0600ADB5 RID: 44469 RVA: 0x002BEC64 File Offset: 0x002BCE64
		public static PinballActivity GetRootAsPinballActivity(ByteBuffer _bb, PinballActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x002BEC81 File Offset: 0x002BCE81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ADB7 RID: 44471 RVA: 0x002BEC90 File Offset: 0x002BCE90
		public PinballActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x0600ADB8 RID: 44472 RVA: 0x002BECA0 File Offset: 0x002BCEA0
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

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x0600ADB9 RID: 44473 RVA: 0x002BECDC File Offset: 0x002BCEDC
		public int ActivityId
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

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x0600ADBA RID: 44474 RVA: 0x002BED18 File Offset: 0x002BCF18
		public int ShopId
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

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x0600ADBB RID: 44475 RVA: 0x002BED54 File Offset: 0x002BCF54
		public int TitleTipId
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

		// Token: 0x170028C0 RID: 10432
		// (get) Token: 0x0600ADBC RID: 44476 RVA: 0x002BED94 File Offset: 0x002BCF94
		public int RecommendTaskId
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

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x0600ADBD RID: 44477 RVA: 0x002BEDD4 File Offset: 0x002BCFD4
		public int DailyLevelFuncId
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

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x0600ADBE RID: 44478 RVA: 0x002BEE14 File Offset: 0x002BD014
		public int RoleFuncId
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

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x0600ADBF RID: 44479 RVA: 0x002BEE54 File Offset: 0x002BD054
		public int ShopFuncId
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

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x0600ADC0 RID: 44480 RVA: 0x002BEE94 File Offset: 0x002BD094
		public int DefaultDailyRandomId
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

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x0600ADC1 RID: 44481 RVA: 0x002BEED4 File Offset: 0x002BD0D4
		public int ExpItemId
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

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x002BEF14 File Offset: 0x002BD114
		public int WeaponFragmentId
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

		// Token: 0x0600ADC3 RID: 44483 RVA: 0x002BEF54 File Offset: 0x002BD154
		public int MainAttrShowList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x0600ADC4 RID: 44484 RVA: 0x002BEF94 File Offset: 0x002BD194
		public int MainAttrShowListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x002BEFC0 File Offset: 0x002BD1C0
		public Span<int> GetMainAttrShowListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x002BEFD0 File Offset: 0x002BD1D0
		public int[] GetMainAttrShowListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x0600ADC7 RID: 44487 RVA: 0x002BEFE8 File Offset: 0x002BD1E8
		public int AttrShowList(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x0600ADC8 RID: 44488 RVA: 0x002BF028 File Offset: 0x002BD228
		public int AttrShowListLength
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

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x002BF054 File Offset: 0x002BD254
		public Span<int> GetAttrShowListBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x002BF064 File Offset: 0x002BD264
		public int[] GetAttrShowListArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600ADCB RID: 44491 RVA: 0x002BF07C File Offset: 0x002BD27C
		public int BattleAttrShowList(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x0600ADCC RID: 44492 RVA: 0x002BF0BC File Offset: 0x002BD2BC
		public int BattleAttrShowListLength
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

		// Token: 0x0600ADCD RID: 44493 RVA: 0x002BF0E8 File Offset: 0x002BD2E8
		public Span<int> GetBattleAttrShowListBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600ADCE RID: 44494 RVA: 0x002BF0F8 File Offset: 0x002BD2F8
		public int[] GetBattleAttrShowListArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600ADCF RID: 44495 RVA: 0x002BF110 File Offset: 0x002BD310
		public int ForceKickBallTime
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ADD0 RID: 44496 RVA: 0x002BF150 File Offset: 0x002BD350
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttrShowListIter()或GetAttrShowListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttrShowList()
		{
			PinballActivity pinballActivity = this;
			return pinballActivity.GetAttrShowListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600ADD1 RID: 44497 RVA: 0x002BF174 File Offset: 0x002BD374
		[NullableContext(1)]
		public readonly IEnumerable<int> AttrShowListIter()
		{
			PinballActivity.<AttrShowListIter>d__48 <AttrShowListIter>d__ = new PinballActivity.<AttrShowListIter>d__48(-2);
			<AttrShowListIter>d__.<>3__<>4__this = this;
			return <AttrShowListIter>d__;
		}

		// Token: 0x0600ADD2 RID: 44498 RVA: 0x002BF18C File Offset: 0x002BD38C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BattleAttrShowListIter()或GetBattleAttrShowListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BattleAttrShowList()
		{
			PinballActivity pinballActivity = this;
			return pinballActivity.GetBattleAttrShowListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600ADD3 RID: 44499 RVA: 0x002BF1B0 File Offset: 0x002BD3B0
		[NullableContext(1)]
		public readonly IEnumerable<int> BattleAttrShowListIter()
		{
			PinballActivity.<BattleAttrShowListIter>d__50 <BattleAttrShowListIter>d__ = new PinballActivity.<BattleAttrShowListIter>d__50(-2);
			<BattleAttrShowListIter>d__.<>3__<>4__this = this;
			return <BattleAttrShowListIter>d__;
		}

		// Token: 0x0600ADD4 RID: 44500 RVA: 0x002BF1C8 File Offset: 0x002BD3C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainAttrShowListIter()或GetMainAttrShowListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MainAttrShowList()
		{
			PinballActivity pinballActivity = this;
			return pinballActivity.GetMainAttrShowListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600ADD5 RID: 44501 RVA: 0x002BF1EC File Offset: 0x002BD3EC
		[NullableContext(1)]
		public readonly IEnumerable<int> MainAttrShowListIter()
		{
			PinballActivity.<MainAttrShowListIter>d__52 <MainAttrShowListIter>d__ = new PinballActivity.<MainAttrShowListIter>d__52(-2);
			<MainAttrShowListIter>d__.<>3__<>4__this = this;
			return <MainAttrShowListIter>d__;
		}

		// Token: 0x04004FE8 RID: 20456
		private Table __p;
	}
}
