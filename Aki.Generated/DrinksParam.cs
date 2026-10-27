using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C06 RID: 3078
	public struct DrinksParam : IFlatbufferObject
	{
		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06006447 RID: 25671 RVA: 0x002182E4 File Offset: 0x002164E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x002182F1 File Offset: 0x002164F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x002182F8 File Offset: 0x002164F8
		public static DrinksParam GetRootAsDrinksParam(ByteBuffer _bb)
		{
			return DrinksParam.GetRootAsDrinksParam(_bb, default(DrinksParam));
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x00218314 File Offset: 0x00216514
		public static DrinksParam GetRootAsDrinksParam(ByteBuffer _bb, DrinksParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x00218331 File Offset: 0x00216531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x00218340 File Offset: 0x00216540
		public DrinksParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x0600644D RID: 25677 RVA: 0x00218350 File Offset: 0x00216550
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

		// Token: 0x0600644E RID: 25678 RVA: 0x0021838C File Offset: 0x0021658C
		public int MainColorPalette(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x0600644F RID: 25679 RVA: 0x002183CC File Offset: 0x002165CC
		public int MainColorPaletteLength
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

		// Token: 0x06006450 RID: 25680 RVA: 0x002183F7 File Offset: 0x002165F7
		public Span<int> GetMainColorPaletteBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x00218406 File Offset: 0x00216606
		public int[] GetMainColorPaletteArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x00218420 File Offset: 0x00216620
		public DicIntInt? WaterHighProcessMap(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06006453 RID: 25683 RVA: 0x00218480 File Offset: 0x00216680
		public int WaterHighProcessMapLength
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

		// Token: 0x06006454 RID: 25684 RVA: 0x002184AC File Offset: 0x002166AC
		public DicIntInt? WaterMaskCenterOffsetMap(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x06006455 RID: 25685 RVA: 0x00218510 File Offset: 0x00216710
		public int WaterMaskCenterOffsetMapLength
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

		// Token: 0x06006456 RID: 25686 RVA: 0x0021853C File Offset: 0x0021673C
		public DicIntInt? WaterMaskWidthMap(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x002185A0 File Offset: 0x002167A0
		public int WaterMaskWidthMapLength
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

		// Token: 0x06006458 RID: 25688 RVA: 0x002185CC File Offset: 0x002167CC
		public int WaterLineColor(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x0021860C File Offset: 0x0021680C
		public int WaterLineColorLength
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

		// Token: 0x0600645A RID: 25690 RVA: 0x00218638 File Offset: 0x00216838
		public Span<int> GetWaterLineColorBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x00218648 File Offset: 0x00216848
		public int[] GetWaterLineColorArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x00218660 File Offset: 0x00216860
		public int WaterColorHigh(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600645D RID: 25693 RVA: 0x002186A0 File Offset: 0x002168A0
		public int WaterColorHighLength
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

		// Token: 0x0600645E RID: 25694 RVA: 0x002186CC File Offset: 0x002168CC
		public Span<int> GetWaterColorHighBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x002186DC File Offset: 0x002168DC
		public int[] GetWaterColorHighArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x002186F4 File Offset: 0x002168F4
		public int WaterColorMiddle(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06006461 RID: 25697 RVA: 0x00218734 File Offset: 0x00216934
		public int WaterColorMiddleLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x00218760 File Offset: 0x00216960
		public Span<int> GetWaterColorMiddleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x00218770 File Offset: 0x00216970
		public int[] GetWaterColorMiddleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x00218788 File Offset: 0x00216988
		public int WaterColorDown(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06006465 RID: 25701 RVA: 0x002187C8 File Offset: 0x002169C8
		public int WaterColorDownLength
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

		// Token: 0x06006466 RID: 25702 RVA: 0x002187F4 File Offset: 0x002169F4
		public Span<int> GetWaterColorDownBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06006467 RID: 25703 RVA: 0x00218804 File Offset: 0x00216A04
		public int[] GetWaterColorDownArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06006468 RID: 25704 RVA: 0x0021881C File Offset: 0x00216A1C
		public int UpColorAdd(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06006469 RID: 25705 RVA: 0x0021885C File Offset: 0x00216A5C
		public int UpColorAddLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600646A RID: 25706 RVA: 0x00218888 File Offset: 0x00216A88
		public Span<int> GetUpColorAddBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600646B RID: 25707 RVA: 0x00218898 File Offset: 0x00216A98
		public int[] GetUpColorAddArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600646C RID: 25708 RVA: 0x002188B0 File Offset: 0x00216AB0
		public int UpLightColor(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600646D RID: 25709 RVA: 0x002188F0 File Offset: 0x00216AF0
		public int UpLightColorLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600646E RID: 25710 RVA: 0x0021891C File Offset: 0x00216B1C
		public Span<int> GetUpLightColorBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600646F RID: 25711 RVA: 0x0021892C File Offset: 0x00216B2C
		public int[] GetUpLightColorArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06006470 RID: 25712 RVA: 0x00218944 File Offset: 0x00216B44
		public int ColorMidHighProcess
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 1100000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06006471 RID: 25713 RVA: 0x00218988 File Offset: 0x00216B88
		public int ColorMidHighWidth
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1000000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06006472 RID: 25714 RVA: 0x002189CC File Offset: 0x00216BCC
		public int ColorDownMidProcess
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1100000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06006473 RID: 25715 RVA: 0x00218A10 File Offset: 0x00216C10
		public int ColorDownMidWidth
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1000000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06006474 RID: 25716 RVA: 0x00218A54 File Offset: 0x00216C54
		public int UpLightMaskProcess
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return -150000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06006475 RID: 25717 RVA: 0x00218A98 File Offset: 0x00216C98
		public int WaterRoughness
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 500000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06006476 RID: 25718 RVA: 0x00218ADC File Offset: 0x00216CDC
		public int WaterMetallic
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006477 RID: 25719 RVA: 0x00218B1C File Offset: 0x00216D1C
		public int FresnelColorAdd(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06006478 RID: 25720 RVA: 0x00218B5C File Offset: 0x00216D5C
		public int FresnelColorAddLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006479 RID: 25721 RVA: 0x00218B88 File Offset: 0x00216D88
		public Span<int> GetFresnelColorAddBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600647A RID: 25722 RVA: 0x00218B98 File Offset: 0x00216D98
		public int[] GetFresnelColorAddArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x0600647B RID: 25723 RVA: 0x00218BB0 File Offset: 0x00216DB0
		public int FresnelRangeWater
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 2200000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600647C RID: 25724 RVA: 0x00218BF4 File Offset: 0x00216DF4
		public int RefractIntensity
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 1000000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x0600647D RID: 25725 RVA: 0x00218C38 File Offset: 0x00216E38
		public int BubbleIntensity
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x0600647E RID: 25726 RVA: 0x00218C78 File Offset: 0x00216E78
		public int BubbleSpeed
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return -150000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600647F RID: 25727 RVA: 0x00218CBC File Offset: 0x00216EBC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FresnelColorAddIter()或GetFresnelColorAddBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FresnelColorAdd()
		{
			DrinksParam drinksParam = this;
			return drinksParam.GetFresnelColorAddArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x00218CE0 File Offset: 0x00216EE0
		[NullableContext(1)]
		public readonly IEnumerable<int> FresnelColorAddIter()
		{
			DrinksParam.<FresnelColorAddIter>d__82 <FresnelColorAddIter>d__ = new DrinksParam.<FresnelColorAddIter>d__82(-2);
			<FresnelColorAddIter>d__.<>3__<>4__this = this;
			return <FresnelColorAddIter>d__;
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x00218CF8 File Offset: 0x00216EF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainColorPaletteIter()或GetMainColorPaletteBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MainColorPalette()
		{
			DrinksParam drinksParam = this;
			return drinksParam.GetMainColorPaletteArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x00218D1C File Offset: 0x00216F1C
		[NullableContext(1)]
		public readonly IEnumerable<int> MainColorPaletteIter()
		{
			DrinksParam.<MainColorPaletteIter>d__84 <MainColorPaletteIter>d__ = new DrinksParam.<MainColorPaletteIter>d__84(-2);
			<MainColorPaletteIter>d__.<>3__<>4__this = this;
			return <MainColorPaletteIter>d__;
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x00218D34 File Offset: 0x00216F34
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UpColorAddIter()或GetUpColorAddBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UpColorAdd()
		{
			DrinksParam drinksParam = this;
			return drinksParam.GetUpColorAddArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x00218D58 File Offset: 0x00216F58
		[NullableContext(1)]
		public readonly IEnumerable<int> UpColorAddIter()
		{
			DrinksParam.<UpColorAddIter>d__86 <UpColorAddIter>d__ = new DrinksParam.<UpColorAddIter>d__86(-2);
			<UpColorAddIter>d__.<>3__<>4__this = this;
			return <UpColorAddIter>d__;
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x00218D70 File Offset: 0x00216F70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UpLightColorIter()或GetUpLightColorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UpLightColor()
		{
			DrinksParam drinksParam = this;
			return drinksParam.GetUpLightColorArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x00218D94 File Offset: 0x00216F94
		[NullableContext(1)]
		public readonly IEnumerable<int> UpLightColorIter()
		{
			DrinksParam.<UpLightColorIter>d__88 <UpLightColorIter>d__ = new DrinksParam.<UpLightColorIter>d__88(-2);
			<UpLightColorIter>d__.<>3__<>4__this = this;
			return <UpLightColorIter>d__;
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x00218DAC File Offset: 0x00216FAC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaterColorDownIter()或GetWaterColorDownBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaterColorDown()
		{
			DrinksParam drinksParam = this;
			return drinksParam.GetWaterColorDownArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x00218DD0 File Offset: 0x00216FD0
		[NullableContext(1)]
		public readonly IEnumerable<int> WaterColorDownIter()
		{
			DrinksParam.<WaterColorDownIter>d__90 <WaterColorDownIter>d__ = new DrinksParam.<WaterColorDownIter>d__90(-2);
			<WaterColorDownIter>d__.<>3__<>4__this = this;
			return <WaterColorDownIter>d__;
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x00218DE8 File Offset: 0x00216FE8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaterColorHighIter()或GetWaterColorHighBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaterColorHigh()
		{
			DrinksParam drinksParam = this;
			return drinksParam.GetWaterColorHighArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x00218E0C File Offset: 0x0021700C
		[NullableContext(1)]
		public readonly IEnumerable<int> WaterColorHighIter()
		{
			DrinksParam.<WaterColorHighIter>d__92 <WaterColorHighIter>d__ = new DrinksParam.<WaterColorHighIter>d__92(-2);
			<WaterColorHighIter>d__.<>3__<>4__this = this;
			return <WaterColorHighIter>d__;
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x00218E24 File Offset: 0x00217024
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaterColorMiddleIter()或GetWaterColorMiddleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaterColorMiddle()
		{
			DrinksParam drinksParam = this;
			return drinksParam.GetWaterColorMiddleArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x00218E48 File Offset: 0x00217048
		[NullableContext(1)]
		public readonly IEnumerable<int> WaterColorMiddleIter()
		{
			DrinksParam.<WaterColorMiddleIter>d__94 <WaterColorMiddleIter>d__ = new DrinksParam.<WaterColorMiddleIter>d__94(-2);
			<WaterColorMiddleIter>d__.<>3__<>4__this = this;
			return <WaterColorMiddleIter>d__;
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x00218E60 File Offset: 0x00217060
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WaterHighProcessMapFrozenDict()缓存字典，遍历请使用WaterHighProcessMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WaterHighProcessMap()
		{
			return this.WaterHighProcessMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x00218EB6 File Offset: 0x002170B6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WaterHighProcessMapIter()
		{
			DrinksParam.<WaterHighProcessMapIter>d__96 <WaterHighProcessMapIter>d__ = new DrinksParam.<WaterHighProcessMapIter>d__96(-2);
			<WaterHighProcessMapIter>d__.<>3__<>4__this = this;
			return <WaterHighProcessMapIter>d__;
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x00218ECC File Offset: 0x002170CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaterLineColorIter()或GetWaterLineColorBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaterLineColor()
		{
			DrinksParam drinksParam = this;
			return drinksParam.GetWaterLineColorArray() ?? Array.Empty<int>();
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x00218EF0 File Offset: 0x002170F0
		[NullableContext(1)]
		public readonly IEnumerable<int> WaterLineColorIter()
		{
			DrinksParam.<WaterLineColorIter>d__98 <WaterLineColorIter>d__ = new DrinksParam.<WaterLineColorIter>d__98(-2);
			<WaterLineColorIter>d__.<>3__<>4__this = this;
			return <WaterLineColorIter>d__;
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x00218F08 File Offset: 0x00217108
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WaterMaskCenterOffsetMapFrozenDict()缓存字典，遍历请使用WaterMaskCenterOffsetMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WaterMaskCenterOffsetMap()
		{
			return this.WaterMaskCenterOffsetMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x00218F5E File Offset: 0x0021715E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WaterMaskCenterOffsetMapIter()
		{
			DrinksParam.<WaterMaskCenterOffsetMapIter>d__100 <WaterMaskCenterOffsetMapIter>d__ = new DrinksParam.<WaterMaskCenterOffsetMapIter>d__100(-2);
			<WaterMaskCenterOffsetMapIter>d__.<>3__<>4__this = this;
			return <WaterMaskCenterOffsetMapIter>d__;
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x00218F74 File Offset: 0x00217174
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WaterMaskWidthMapFrozenDict()缓存字典，遍历请使用WaterMaskWidthMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WaterMaskWidthMap()
		{
			return this.WaterMaskWidthMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x00218FCA File Offset: 0x002171CA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WaterMaskWidthMapIter()
		{
			DrinksParam.<WaterMaskWidthMapIter>d__102 <WaterMaskWidthMapIter>d__ = new DrinksParam.<WaterMaskWidthMapIter>d__102(-2);
			<WaterMaskWidthMapIter>d__.<>3__<>4__this = this;
			return <WaterMaskWidthMapIter>d__;
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x00218FE0 File Offset: 0x002171E0
		public int? GetWaterHighProcessMap(int key)
		{
			this.EnsureWaterHighProcessMapCacheIfNeeded();
			int value;
			if (!this.WaterHighProcessMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x00219014 File Offset: 0x00217214
		public int? GetWaterMaskCenterOffsetMap(int key)
		{
			this.EnsureWaterMaskCenterOffsetMapCacheIfNeeded();
			int value;
			if (!this.WaterMaskCenterOffsetMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x00219048 File Offset: 0x00217248
		public int? GetWaterMaskWidthMap(int key)
		{
			this.EnsureWaterMaskWidthMapCacheIfNeeded();
			int value;
			if (!this.WaterMaskWidthMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x0021907C File Offset: 0x0021727C
		private void EnsureWaterHighProcessMapCacheIfNeeded()
		{
			if (this.WaterHighProcessMapCache != null)
			{
				return;
			}
			this.WaterHighProcessMapCache = this.WaterHighProcessMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x002190E4 File Offset: 0x002172E4
		private void EnsureWaterMaskCenterOffsetMapCacheIfNeeded()
		{
			if (this.WaterMaskCenterOffsetMapCache != null)
			{
				return;
			}
			this.WaterMaskCenterOffsetMapCache = this.WaterMaskCenterOffsetMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x0021914C File Offset: 0x0021734C
		private void EnsureWaterMaskWidthMapCacheIfNeeded()
		{
			if (this.WaterMaskWidthMapCache != null)
			{
				return;
			}
			this.WaterMaskWidthMapCache = this.WaterMaskWidthMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x002191B2 File Offset: 0x002173B2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWaterHighProcessMapFrozenDict(int key)
		{
			this.EnsureWaterHighProcessMapCacheIfNeeded();
			return this.WaterHighProcessMapCache;
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x002191C0 File Offset: 0x002173C0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWaterMaskCenterOffsetMapFrozenDict(int key)
		{
			this.EnsureWaterMaskCenterOffsetMapCacheIfNeeded();
			return this.WaterMaskCenterOffsetMapCache;
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x002191CE File Offset: 0x002173CE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWaterMaskWidthMapFrozenDict(int key)
		{
			this.EnsureWaterMaskWidthMapCacheIfNeeded();
			return this.WaterMaskWidthMapCache;
		}

		// Token: 0x04004C3F RID: 19519
		private Table __p;

		// Token: 0x04004C40 RID: 19520
		[Nullable(2)]
		private FrozenDictionary<int, int> WaterHighProcessMapCache;

		// Token: 0x04004C41 RID: 19521
		[Nullable(2)]
		private FrozenDictionary<int, int> WaterMaskCenterOffsetMapCache;

		// Token: 0x04004C42 RID: 19522
		[Nullable(2)]
		private FrozenDictionary<int, int> WaterMaskWidthMapCache;
	}
}
