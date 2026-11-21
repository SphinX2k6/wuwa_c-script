using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE8 RID: 3304
	[NullableContext(1)]
	[Nullable(0)]
	public struct DrinksParam : IFlatbufferObject
	{
		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06006A26 RID: 27174 RVA: 0x002378E8 File Offset: 0x00235AE8
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x002378F5 File Offset: 0x00235AF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x002378FC File Offset: 0x00235AFC
		[NullableContext(0)]
		public static DrinksParam GetRootAsDrinksParam(ByteBuffer _bb)
		{
			return DrinksParam.GetRootAsDrinksParam(_bb, default(DrinksParam));
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x00237918 File Offset: 0x00235B18
		[NullableContext(0)]
		public static DrinksParam GetRootAsDrinksParam(ByteBuffer _bb, DrinksParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x00237935 File Offset: 0x00235B35
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x00237944 File Offset: 0x00235B44
		[NullableContext(0)]
		public DrinksParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06006A2C RID: 27180 RVA: 0x00237954 File Offset: 0x00235B54
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

		// Token: 0x06006A2D RID: 27181 RVA: 0x00237990 File Offset: 0x00235B90
		public int MainColorPalette(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06006A2E RID: 27182 RVA: 0x002379D0 File Offset: 0x00235BD0
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

		// Token: 0x06006A2F RID: 27183 RVA: 0x002379FB File Offset: 0x00235BFB
		[NullableContext(0)]
		public Span<int> GetMainColorPaletteBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x00237A0A File Offset: 0x00235C0A
		[NullableContext(0)]
		public int[] GetMainColorPaletteArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x00237A24 File Offset: 0x00235C24
		public DicIntInt? WaterHighProcessMap(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06006A32 RID: 27186 RVA: 0x00237A84 File Offset: 0x00235C84
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

		// Token: 0x06006A33 RID: 27187 RVA: 0x00237AB0 File Offset: 0x00235CB0
		public DicIntInt? WaterMaskCenterOffsetMap(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06006A34 RID: 27188 RVA: 0x00237B14 File Offset: 0x00235D14
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

		// Token: 0x06006A35 RID: 27189 RVA: 0x00237B40 File Offset: 0x00235D40
		public DicIntInt? WaterMaskWidthMap(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06006A36 RID: 27190 RVA: 0x00237BA4 File Offset: 0x00235DA4
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

		// Token: 0x06006A37 RID: 27191 RVA: 0x00237BD0 File Offset: 0x00235DD0
		public int WaterLineColor(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06006A38 RID: 27192 RVA: 0x00237C10 File Offset: 0x00235E10
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

		// Token: 0x06006A39 RID: 27193 RVA: 0x00237C3C File Offset: 0x00235E3C
		[NullableContext(0)]
		public Span<int> GetWaterLineColorBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x00237C4C File Offset: 0x00235E4C
		[NullableContext(0)]
		public int[] GetWaterLineColorArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x00237C64 File Offset: 0x00235E64
		public int WaterColorHigh(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06006A3C RID: 27196 RVA: 0x00237CA4 File Offset: 0x00235EA4
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

		// Token: 0x06006A3D RID: 27197 RVA: 0x00237CD0 File Offset: 0x00235ED0
		[NullableContext(0)]
		public Span<int> GetWaterColorHighBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x00237CE0 File Offset: 0x00235EE0
		[NullableContext(0)]
		public int[] GetWaterColorHighArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x00237CF8 File Offset: 0x00235EF8
		public int WaterColorMiddle(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06006A40 RID: 27200 RVA: 0x00237D38 File Offset: 0x00235F38
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

		// Token: 0x06006A41 RID: 27201 RVA: 0x00237D64 File Offset: 0x00235F64
		[NullableContext(0)]
		public Span<int> GetWaterColorMiddleBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x00237D74 File Offset: 0x00235F74
		[NullableContext(0)]
		public int[] GetWaterColorMiddleArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x00237D8C File Offset: 0x00235F8C
		public int WaterColorDown(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06006A44 RID: 27204 RVA: 0x00237DCC File Offset: 0x00235FCC
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

		// Token: 0x06006A45 RID: 27205 RVA: 0x00237DF8 File Offset: 0x00235FF8
		[NullableContext(0)]
		public Span<int> GetWaterColorDownBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x00237E08 File Offset: 0x00236008
		[NullableContext(0)]
		public int[] GetWaterColorDownArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x00237E20 File Offset: 0x00236020
		public int UpColorAdd(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06006A48 RID: 27208 RVA: 0x00237E60 File Offset: 0x00236060
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

		// Token: 0x06006A49 RID: 27209 RVA: 0x00237E8C File Offset: 0x0023608C
		[NullableContext(0)]
		public Span<int> GetUpColorAddBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x00237E9C File Offset: 0x0023609C
		[NullableContext(0)]
		public int[] GetUpColorAddArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00237EB4 File Offset: 0x002360B4
		public int UpLightColor(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06006A4C RID: 27212 RVA: 0x00237EF4 File Offset: 0x002360F4
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

		// Token: 0x06006A4D RID: 27213 RVA: 0x00237F20 File Offset: 0x00236120
		[NullableContext(0)]
		public Span<int> GetUpLightColorBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x00237F30 File Offset: 0x00236130
		[NullableContext(0)]
		public int[] GetUpLightColorArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06006A4F RID: 27215 RVA: 0x00237F48 File Offset: 0x00236148
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

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06006A50 RID: 27216 RVA: 0x00237F8C File Offset: 0x0023618C
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

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x00237FD0 File Offset: 0x002361D0
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

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06006A52 RID: 27218 RVA: 0x00238014 File Offset: 0x00236214
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

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x00238058 File Offset: 0x00236258
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

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06006A54 RID: 27220 RVA: 0x0023809C File Offset: 0x0023629C
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

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06006A55 RID: 27221 RVA: 0x002380E0 File Offset: 0x002362E0
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

		// Token: 0x06006A56 RID: 27222 RVA: 0x00238120 File Offset: 0x00236320
		public int FresnelColorAdd(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06006A57 RID: 27223 RVA: 0x00238160 File Offset: 0x00236360
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

		// Token: 0x06006A58 RID: 27224 RVA: 0x0023818C File Offset: 0x0023638C
		[NullableContext(0)]
		public Span<int> GetFresnelColorAddBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x0023819C File Offset: 0x0023639C
		[NullableContext(0)]
		public int[] GetFresnelColorAddArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06006A5A RID: 27226 RVA: 0x002381B4 File Offset: 0x002363B4
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

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06006A5B RID: 27227 RVA: 0x002381F8 File Offset: 0x002363F8
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

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06006A5C RID: 27228 RVA: 0x0023823C File Offset: 0x0023643C
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

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06006A5D RID: 27229 RVA: 0x0023827C File Offset: 0x0023647C
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

		// Token: 0x06006A5E RID: 27230 RVA: 0x002382BD File Offset: 0x002364BD
		public int[] FresnelColorAdd()
		{
			return this.GetFresnelColorAddArray();
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x002382C5 File Offset: 0x002364C5
		public IEnumerable<int> FresnelColorAddIter()
		{
			DrinksParam.<FresnelColorAddIter>d__82 <FresnelColorAddIter>d__ = new DrinksParam.<FresnelColorAddIter>d__82(-2);
			<FresnelColorAddIter>d__.<>3__<>4__this = this;
			return <FresnelColorAddIter>d__;
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x002382DA File Offset: 0x002364DA
		public int[] MainColorPalette()
		{
			return this.GetMainColorPaletteArray();
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x002382E2 File Offset: 0x002364E2
		public IEnumerable<int> MainColorPaletteIter()
		{
			DrinksParam.<MainColorPaletteIter>d__84 <MainColorPaletteIter>d__ = new DrinksParam.<MainColorPaletteIter>d__84(-2);
			<MainColorPaletteIter>d__.<>3__<>4__this = this;
			return <MainColorPaletteIter>d__;
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x002382F7 File Offset: 0x002364F7
		public int[] UpColorAdd()
		{
			return this.GetUpColorAddArray();
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x002382FF File Offset: 0x002364FF
		public IEnumerable<int> UpColorAddIter()
		{
			DrinksParam.<UpColorAddIter>d__86 <UpColorAddIter>d__ = new DrinksParam.<UpColorAddIter>d__86(-2);
			<UpColorAddIter>d__.<>3__<>4__this = this;
			return <UpColorAddIter>d__;
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x00238314 File Offset: 0x00236514
		public int[] UpLightColor()
		{
			return this.GetUpLightColorArray();
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x0023831C File Offset: 0x0023651C
		public IEnumerable<int> UpLightColorIter()
		{
			DrinksParam.<UpLightColorIter>d__88 <UpLightColorIter>d__ = new DrinksParam.<UpLightColorIter>d__88(-2);
			<UpLightColorIter>d__.<>3__<>4__this = this;
			return <UpLightColorIter>d__;
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x00238331 File Offset: 0x00236531
		public int[] WaterColorDown()
		{
			return this.GetWaterColorDownArray();
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x00238339 File Offset: 0x00236539
		public IEnumerable<int> WaterColorDownIter()
		{
			DrinksParam.<WaterColorDownIter>d__90 <WaterColorDownIter>d__ = new DrinksParam.<WaterColorDownIter>d__90(-2);
			<WaterColorDownIter>d__.<>3__<>4__this = this;
			return <WaterColorDownIter>d__;
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x0023834E File Offset: 0x0023654E
		public int[] WaterColorHigh()
		{
			return this.GetWaterColorHighArray();
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x00238356 File Offset: 0x00236556
		public IEnumerable<int> WaterColorHighIter()
		{
			DrinksParam.<WaterColorHighIter>d__92 <WaterColorHighIter>d__ = new DrinksParam.<WaterColorHighIter>d__92(-2);
			<WaterColorHighIter>d__.<>3__<>4__this = this;
			return <WaterColorHighIter>d__;
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x0023836B File Offset: 0x0023656B
		public int[] WaterColorMiddle()
		{
			return this.GetWaterColorMiddleArray();
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x00238373 File Offset: 0x00236573
		public IEnumerable<int> WaterColorMiddleIter()
		{
			DrinksParam.<WaterColorMiddleIter>d__94 <WaterColorMiddleIter>d__ = new DrinksParam.<WaterColorMiddleIter>d__94(-2);
			<WaterColorMiddleIter>d__.<>3__<>4__this = this;
			return <WaterColorMiddleIter>d__;
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x00238388 File Offset: 0x00236588
		public Dictionary<int, int> WaterHighProcessMap()
		{
			return this.WaterHighProcessMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x002383DE File Offset: 0x002365DE
		public IEnumerable<DicIntInt> WaterHighProcessMapIter()
		{
			DrinksParam.<WaterHighProcessMapIter>d__96 <WaterHighProcessMapIter>d__ = new DrinksParam.<WaterHighProcessMapIter>d__96(-2);
			<WaterHighProcessMapIter>d__.<>3__<>4__this = this;
			return <WaterHighProcessMapIter>d__;
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x002383F3 File Offset: 0x002365F3
		public int[] WaterLineColor()
		{
			return this.GetWaterLineColorArray();
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x002383FB File Offset: 0x002365FB
		public IEnumerable<int> WaterLineColorIter()
		{
			DrinksParam.<WaterLineColorIter>d__98 <WaterLineColorIter>d__ = new DrinksParam.<WaterLineColorIter>d__98(-2);
			<WaterLineColorIter>d__.<>3__<>4__this = this;
			return <WaterLineColorIter>d__;
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x00238410 File Offset: 0x00236610
		public Dictionary<int, int> WaterMaskCenterOffsetMap()
		{
			return this.WaterMaskCenterOffsetMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x00238466 File Offset: 0x00236666
		public IEnumerable<DicIntInt> WaterMaskCenterOffsetMapIter()
		{
			DrinksParam.<WaterMaskCenterOffsetMapIter>d__100 <WaterMaskCenterOffsetMapIter>d__ = new DrinksParam.<WaterMaskCenterOffsetMapIter>d__100(-2);
			<WaterMaskCenterOffsetMapIter>d__.<>3__<>4__this = this;
			return <WaterMaskCenterOffsetMapIter>d__;
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x0023847C File Offset: 0x0023667C
		public Dictionary<int, int> WaterMaskWidthMap()
		{
			return this.WaterMaskWidthMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x002384D2 File Offset: 0x002366D2
		public IEnumerable<DicIntInt> WaterMaskWidthMapIter()
		{
			DrinksParam.<WaterMaskWidthMapIter>d__102 <WaterMaskWidthMapIter>d__ = new DrinksParam.<WaterMaskWidthMapIter>d__102(-2);
			<WaterMaskWidthMapIter>d__.<>3__<>4__this = this;
			return <WaterMaskWidthMapIter>d__;
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x002384E8 File Offset: 0x002366E8
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

		// Token: 0x06006A75 RID: 27253 RVA: 0x0023851C File Offset: 0x0023671C
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

		// Token: 0x06006A76 RID: 27254 RVA: 0x00238550 File Offset: 0x00236750
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

		// Token: 0x06006A77 RID: 27255 RVA: 0x00238584 File Offset: 0x00236784
		private void EnsureWaterHighProcessMapCacheIfNeeded()
		{
			if (this.WaterHighProcessMapCache != null)
			{
				return;
			}
			this.WaterHighProcessMapCache = this.WaterHighProcessMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x002385EC File Offset: 0x002367EC
		private void EnsureWaterMaskCenterOffsetMapCacheIfNeeded()
		{
			if (this.WaterMaskCenterOffsetMapCache != null)
			{
				return;
			}
			this.WaterMaskCenterOffsetMapCache = this.WaterMaskCenterOffsetMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x00238654 File Offset: 0x00236854
		private void EnsureWaterMaskWidthMapCacheIfNeeded()
		{
			if (this.WaterMaskWidthMapCache != null)
			{
				return;
			}
			this.WaterMaskWidthMapCache = this.WaterMaskWidthMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x002386BA File Offset: 0x002368BA
		public FrozenDictionary<int, int> GetWaterHighProcessMapFrozenDict()
		{
			this.EnsureWaterHighProcessMapCacheIfNeeded();
			return this.WaterHighProcessMapCache;
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x002386C8 File Offset: 0x002368C8
		public FrozenDictionary<int, int> GetWaterMaskCenterOffsetMapFrozenDict()
		{
			this.EnsureWaterMaskCenterOffsetMapCacheIfNeeded();
			return this.WaterMaskCenterOffsetMapCache;
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x002386D6 File Offset: 0x002368D6
		public FrozenDictionary<int, int> GetWaterMaskWidthMapFrozenDict()
		{
			this.EnsureWaterMaskWidthMapCacheIfNeeded();
			return this.WaterMaskWidthMapCache;
		}

		// Token: 0x04005221 RID: 21025
		private Table __p;

		// Token: 0x04005222 RID: 21026
		[Nullable(2)]
		private FrozenDictionary<int, int> WaterHighProcessMapCache;

		// Token: 0x04005223 RID: 21027
		[Nullable(2)]
		private FrozenDictionary<int, int> WaterMaskCenterOffsetMapCache;

		// Token: 0x04005224 RID: 21028
		[Nullable(2)]
		private FrozenDictionary<int, int> WaterMaskWidthMapCache;
	}
}
