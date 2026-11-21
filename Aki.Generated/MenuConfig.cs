using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EEC RID: 3820
	public struct MenuConfig : IFlatbufferObject
	{
		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600998F RID: 39311 RVA: 0x002A1BB5 File Offset: 0x0029FDB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009990 RID: 39312 RVA: 0x002A1BC2 File Offset: 0x0029FDC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009991 RID: 39313 RVA: 0x002A1BCC File Offset: 0x0029FDCC
		public static MenuConfig GetRootAsMenuConfig(ByteBuffer _bb)
		{
			return MenuConfig.GetRootAsMenuConfig(_bb, default(MenuConfig));
		}

		// Token: 0x06009992 RID: 39314 RVA: 0x002A1BE8 File Offset: 0x0029FDE8
		public static MenuConfig GetRootAsMenuConfig(ByteBuffer _bb, MenuConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009993 RID: 39315 RVA: 0x002A1C05 File Offset: 0x0029FE05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009994 RID: 39316 RVA: 0x002A1C14 File Offset: 0x0029FE14
		public MenuConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06009995 RID: 39317 RVA: 0x002A1C24 File Offset: 0x0029FE24
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

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06009996 RID: 39318 RVA: 0x002A1C60 File Offset: 0x0029FE60
		public int FunctionId
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

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06009997 RID: 39319 RVA: 0x002A1C9C File Offset: 0x0029FE9C
		public float SliderDefault
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x002A1CDC File Offset: 0x0029FEDC
		public int OptionsDefault
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

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06009999 RID: 39321 RVA: 0x002A1D1C File Offset: 0x0029FF1C
		public int MainType
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

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x002A1D5C File Offset: 0x0029FF5C
		public string SubName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600999B RID: 39323 RVA: 0x002A1D94 File Offset: 0x0029FF94
		public Span<byte> GetSubNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600999C RID: 39324 RVA: 0x002A1DA4 File Offset: 0x0029FFA4
		public byte[] GetSubNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x0600999D RID: 39325 RVA: 0x002A1DBC File Offset: 0x0029FFBC
		public int SubType
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

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x0600999E RID: 39326 RVA: 0x002A1DFC File Offset: 0x0029FFFC
		public bool NeedScale
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x0600999F RID: 39327 RVA: 0x002A1E3C File Offset: 0x002A003C
		public int SubSort
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

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x060099A0 RID: 39328 RVA: 0x002A1E7C File Offset: 0x002A007C
		public string SubImage
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x002A1EB4 File Offset: 0x002A00B4
		public Span<byte> GetSubImageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x002A1EC4 File Offset: 0x002A00C4
		public byte[] GetSubImageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x060099A3 RID: 39331 RVA: 0x002A1EDC File Offset: 0x002A00DC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x002A1F14 File Offset: 0x002A0114
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x002A1F24 File Offset: 0x002A0124
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x060099A6 RID: 39334 RVA: 0x002A1F3C File Offset: 0x002A013C
		public int Platform
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x060099A7 RID: 39335 RVA: 0x002A1F7C File Offset: 0x002A017C
		public string Device
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x002A1FB4 File Offset: 0x002A01B4
		public Span<byte> GetDeviceBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060099A9 RID: 39337 RVA: 0x002A1FC4 File Offset: 0x002A01C4
		public byte[] GetDeviceArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x060099AA RID: 39338 RVA: 0x002A1FDC File Offset: 0x002A01DC
		public int FunctionSort
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x060099AB RID: 39339 RVA: 0x002A201C File Offset: 0x002A021C
		public string FunctionImage
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099AC RID: 39340 RVA: 0x002A2054 File Offset: 0x002A0254
		public Span<byte> GetFunctionImageBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x002A2064 File Offset: 0x002A0264
		public byte[] GetFunctionImageArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x060099AE RID: 39342 RVA: 0x002A207C File Offset: 0x002A027C
		public int SetType
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x060099AF RID: 39343 RVA: 0x002A20BC File Offset: 0x002A02BC
		public bool IsDataCache
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060099B0 RID: 39344 RVA: 0x002A20FC File Offset: 0x002A02FC
		public float SliderRange(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x060099B1 RID: 39345 RVA: 0x002A2140 File Offset: 0x002A0340
		public int SliderRangeLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099B2 RID: 39346 RVA: 0x002A216C File Offset: 0x002A036C
		public Span<float> GetSliderRangeBytes()
		{
			return this.__p.__vector_as_span<float>(38, 4);
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x002A217C File Offset: 0x002A037C
		public float[] GetSliderRangeArray()
		{
			return this.__p.__vector_as_array<float>(38) ?? Array.Empty<float>();
		}

		// Token: 0x060099B4 RID: 39348 RVA: 0x002A2194 File Offset: 0x002A0394
		public float SliderRangeDisplay(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x060099B5 RID: 39349 RVA: 0x002A21D8 File Offset: 0x002A03D8
		public int SliderRangeDisplayLength
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

		// Token: 0x060099B6 RID: 39350 RVA: 0x002A2204 File Offset: 0x002A0404
		public Span<float> GetSliderRangeDisplayBytes()
		{
			return this.__p.__vector_as_span<float>(40, 4);
		}

		// Token: 0x060099B7 RID: 39351 RVA: 0x002A2214 File Offset: 0x002A0414
		public float[] GetSliderRangeDisplayArray()
		{
			return this.__p.__vector_as_array<float>(40) ?? Array.Empty<float>();
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x060099B8 RID: 39352 RVA: 0x002A222C File Offset: 0x002A042C
		public int Digits
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099B9 RID: 39353 RVA: 0x002A226C File Offset: 0x002A046C
		public string OptionsName(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x002A22A8 File Offset: 0x002A04A8
		public int OptionsNameLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099BB RID: 39355 RVA: 0x002A22D4 File Offset: 0x002A04D4
		public int OptionsValue(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x060099BC RID: 39356 RVA: 0x002A2314 File Offset: 0x002A0514
		public int OptionsValueLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099BD RID: 39357 RVA: 0x002A2340 File Offset: 0x002A0540
		public Span<int> GetOptionsValueBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x060099BE RID: 39358 RVA: 0x002A2350 File Offset: 0x002A0550
		public int[] GetOptionsValueArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x060099BF RID: 39359 RVA: 0x002A2368 File Offset: 0x002A0568
		public string KeyMap
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099C0 RID: 39360 RVA: 0x002A23A0 File Offset: 0x002A05A0
		public Span<byte> GetKeyMapBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x002A23B0 File Offset: 0x002A05B0
		public byte[] GetKeyMapArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x002A23C8 File Offset: 0x002A05C8
		public string ButtonText
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099C3 RID: 39363 RVA: 0x002A2400 File Offset: 0x002A0600
		public Span<byte> GetButtonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x002A2410 File Offset: 0x002A0610
		public byte[] GetButtonTextArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x060099C5 RID: 39365 RVA: 0x002A2428 File Offset: 0x002A0628
		public string BtnDisableTips
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x002A2460 File Offset: 0x002A0660
		public Span<byte> GetBtnDisableTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x060099C7 RID: 39367 RVA: 0x002A2470 File Offset: 0x002A0670
		public byte[] GetBtnDisableTipsArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x060099C8 RID: 39368 RVA: 0x002A2488 File Offset: 0x002A0688
		public bool BtnDisableTipsEnable
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x060099C9 RID: 39369 RVA: 0x002A24C8 File Offset: 0x002A06C8
		public string OpenView
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x002A2500 File Offset: 0x002A0700
		public Span<byte> GetOpenViewBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x002A2510 File Offset: 0x002A0710
		public byte[] GetOpenViewArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x060099CC RID: 39372 RVA: 0x002A2528 File Offset: 0x002A0728
		public int RelationFunction(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x060099CD RID: 39373 RVA: 0x002A2568 File Offset: 0x002A0768
		public int RelationFunctionLength
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x002A2594 File Offset: 0x002A0794
		public Span<int> GetRelationFunctionBytes()
		{
			return this.__p.__vector_as_span<int>(58, 4);
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x002A25A4 File Offset: 0x002A07A4
		public int[] GetRelationFunctionArray()
		{
			return this.__p.__vector_as_array<int>(58) ?? Array.Empty<int>();
		}

		// Token: 0x060099D0 RID: 39376 RVA: 0x002A25BC File Offset: 0x002A07BC
		public int DisableValue(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x060099D1 RID: 39377 RVA: 0x002A25FC File Offset: 0x002A07FC
		public int DisableValueLength
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x002A2628 File Offset: 0x002A0828
		public Span<int> GetDisableValueBytes()
		{
			return this.__p.__vector_as_span<int>(60, 4);
		}

		// Token: 0x060099D3 RID: 39379 RVA: 0x002A2638 File Offset: 0x002A0838
		public int[] GetDisableValueArray()
		{
			return this.__p.__vector_as_array<int>(60) ?? Array.Empty<int>();
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x002A2650 File Offset: 0x002A0850
		public int DisableFunction(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x060099D5 RID: 39381 RVA: 0x002A2690 File Offset: 0x002A0890
		public int DisableFunctionLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099D6 RID: 39382 RVA: 0x002A26BC File Offset: 0x002A08BC
		public Span<int> GetDisableFunctionBytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x060099D7 RID: 39383 RVA: 0x002A26CC File Offset: 0x002A08CC
		public int[] GetDisableFunctionArray()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x060099D8 RID: 39384 RVA: 0x002A26E4 File Offset: 0x002A08E4
		public DicIntString? DisableOverrideText(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x060099D9 RID: 39385 RVA: 0x002A2748 File Offset: 0x002A0948
		public int DisableOverrideTextLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x002A2774 File Offset: 0x002A0974
		public int AffectedValue(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x060099DB RID: 39387 RVA: 0x002A27B4 File Offset: 0x002A09B4
		public int AffectedValueLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x002A27E0 File Offset: 0x002A09E0
		public Span<int> GetAffectedValueBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x060099DD RID: 39389 RVA: 0x002A27F0 File Offset: 0x002A09F0
		public int[] GetAffectedValueArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x060099DE RID: 39390 RVA: 0x002A2808 File Offset: 0x002A0A08
		public DicIntInt? AffectedFunction(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x060099DF RID: 39391 RVA: 0x002A286C File Offset: 0x002A0A6C
		public int AffectedFunctionLength
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099E0 RID: 39392 RVA: 0x002A2898 File Offset: 0x002A0A98
		public DicIntString? ValueTipsMap(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x060099E1 RID: 39393 RVA: 0x002A28FC File Offset: 0x002A0AFC
		public int ValueTipsMapLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099E2 RID: 39394 RVA: 0x002A2928 File Offset: 0x002A0B28
		public DicIntInt? ClickedTipsMap(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x060099E3 RID: 39395 RVA: 0x002A298C File Offset: 0x002A0B8C
		public int ClickedTipsMapLength
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x060099E4 RID: 39396 RVA: 0x002A29B8 File Offset: 0x002A0BB8
		public string ClickedTips
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099E5 RID: 39397 RVA: 0x002A29F0 File Offset: 0x002A0BF0
		public Span<byte> GetClickedTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x060099E6 RID: 39398 RVA: 0x002A2A00 File Offset: 0x002A0C00
		public byte[] GetClickedTipsArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x060099E7 RID: 39399 RVA: 0x002A2A18 File Offset: 0x002A0C18
		public bool BlockOnIosCheckServer
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x002A2A58 File Offset: 0x002A0C58
		public string DetailText
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099E9 RID: 39401 RVA: 0x002A2A90 File Offset: 0x002A0C90
		public Span<byte> GetDetailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x002A2AA0 File Offset: 0x002A0CA0
		public byte[] GetDetailTextArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x060099EB RID: 39403 RVA: 0x002A2AB8 File Offset: 0x002A0CB8
		public int DetailPop
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x060099EC RID: 39404 RVA: 0x002A2AF8 File Offset: 0x002A0CF8
		public bool CanDisableDetailShow
		{
			get
			{
				int num = this.__p.__offset(82);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x060099ED RID: 39405 RVA: 0x002A2B38 File Offset: 0x002A0D38
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x060099EE RID: 39406 RVA: 0x002A2B78 File Offset: 0x002A0D78
		public int Ps5Hide
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x060099EF RID: 39407 RVA: 0x002A2BB8 File Offset: 0x002A0DB8
		public bool CanShowInLogin
		{
			get
			{
				int num = this.__p.__offset(88);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x060099F0 RID: 39408 RVA: 0x002A2BF8 File Offset: 0x002A0DF8
		public int XboxHide
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x060099F1 RID: 39409 RVA: 0x002A2C38 File Offset: 0x002A0E38
		public int WinGDKHide
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099F2 RID: 39410 RVA: 0x002A2C78 File Offset: 0x002A0E78
		public string SpecifyHideConsoles(int j)
		{
			int num = this.__p.__offset(94);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x060099F3 RID: 39411 RVA: 0x002A2CB4 File Offset: 0x002A0EB4
		public int SpecifyHideConsolesLength
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060099F4 RID: 39412 RVA: 0x002A2CE0 File Offset: 0x002A0EE0
		[NullableContext(1)]
		public Dictionary<int, int> AffectedFunction()
		{
			return this.AffectedFunctionIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060099F5 RID: 39413 RVA: 0x002A2D36 File Offset: 0x002A0F36
		[NullableContext(1)]
		public IEnumerable<DicIntInt> AffectedFunctionIter()
		{
			MenuConfig.<AffectedFunctionIter>d__150 <AffectedFunctionIter>d__ = new MenuConfig.<AffectedFunctionIter>d__150(-2);
			<AffectedFunctionIter>d__.<>3__<>4__this = this;
			return <AffectedFunctionIter>d__;
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x002A2D4B File Offset: 0x002A0F4B
		[NullableContext(1)]
		public int[] AffectedValue()
		{
			return this.GetAffectedValueArray();
		}

		// Token: 0x060099F7 RID: 39415 RVA: 0x002A2D53 File Offset: 0x002A0F53
		[NullableContext(1)]
		public IEnumerable<int> AffectedValueIter()
		{
			MenuConfig.<AffectedValueIter>d__152 <AffectedValueIter>d__ = new MenuConfig.<AffectedValueIter>d__152(-2);
			<AffectedValueIter>d__.<>3__<>4__this = this;
			return <AffectedValueIter>d__;
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x002A2D68 File Offset: 0x002A0F68
		[NullableContext(1)]
		public Dictionary<int, int> ClickedTipsMap()
		{
			return this.ClickedTipsMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x002A2DBE File Offset: 0x002A0FBE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ClickedTipsMapIter()
		{
			MenuConfig.<ClickedTipsMapIter>d__154 <ClickedTipsMapIter>d__ = new MenuConfig.<ClickedTipsMapIter>d__154(-2);
			<ClickedTipsMapIter>d__.<>3__<>4__this = this;
			return <ClickedTipsMapIter>d__;
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x002A2DD3 File Offset: 0x002A0FD3
		[NullableContext(1)]
		public int[] DisableFunction()
		{
			return this.GetDisableFunctionArray();
		}

		// Token: 0x060099FB RID: 39419 RVA: 0x002A2DDB File Offset: 0x002A0FDB
		[NullableContext(1)]
		public IEnumerable<int> DisableFunctionIter()
		{
			MenuConfig.<DisableFunctionIter>d__156 <DisableFunctionIter>d__ = new MenuConfig.<DisableFunctionIter>d__156(-2);
			<DisableFunctionIter>d__.<>3__<>4__this = this;
			return <DisableFunctionIter>d__;
		}

		// Token: 0x060099FC RID: 39420 RVA: 0x002A2DF0 File Offset: 0x002A0FF0
		[NullableContext(1)]
		public Dictionary<int, string> DisableOverrideText()
		{
			return this.DisableOverrideTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060099FD RID: 39421 RVA: 0x002A2E46 File Offset: 0x002A1046
		[NullableContext(1)]
		public IEnumerable<DicIntString> DisableOverrideTextIter()
		{
			MenuConfig.<DisableOverrideTextIter>d__158 <DisableOverrideTextIter>d__ = new MenuConfig.<DisableOverrideTextIter>d__158(-2);
			<DisableOverrideTextIter>d__.<>3__<>4__this = this;
			return <DisableOverrideTextIter>d__;
		}

		// Token: 0x060099FE RID: 39422 RVA: 0x002A2E5B File Offset: 0x002A105B
		[NullableContext(1)]
		public int[] DisableValue()
		{
			return this.GetDisableValueArray();
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x002A2E63 File Offset: 0x002A1063
		[NullableContext(1)]
		public IEnumerable<int> DisableValueIter()
		{
			MenuConfig.<DisableValueIter>d__160 <DisableValueIter>d__ = new MenuConfig.<DisableValueIter>d__160(-2);
			<DisableValueIter>d__.<>3__<>4__this = this;
			return <DisableValueIter>d__;
		}

		// Token: 0x06009A00 RID: 39424 RVA: 0x002A2E78 File Offset: 0x002A1078
		[NullableContext(1)]
		public string[] OptionsName()
		{
			return this.OptionsNameIter().ToArray<string>();
		}

		// Token: 0x06009A01 RID: 39425 RVA: 0x002A2E85 File Offset: 0x002A1085
		[NullableContext(1)]
		public IEnumerable<string> OptionsNameIter()
		{
			MenuConfig.<OptionsNameIter>d__162 <OptionsNameIter>d__ = new MenuConfig.<OptionsNameIter>d__162(-2);
			<OptionsNameIter>d__.<>3__<>4__this = this;
			return <OptionsNameIter>d__;
		}

		// Token: 0x06009A02 RID: 39426 RVA: 0x002A2E9A File Offset: 0x002A109A
		[NullableContext(1)]
		public int[] OptionsValue()
		{
			return this.GetOptionsValueArray();
		}

		// Token: 0x06009A03 RID: 39427 RVA: 0x002A2EA2 File Offset: 0x002A10A2
		[NullableContext(1)]
		public IEnumerable<int> OptionsValueIter()
		{
			MenuConfig.<OptionsValueIter>d__164 <OptionsValueIter>d__ = new MenuConfig.<OptionsValueIter>d__164(-2);
			<OptionsValueIter>d__.<>3__<>4__this = this;
			return <OptionsValueIter>d__;
		}

		// Token: 0x06009A04 RID: 39428 RVA: 0x002A2EB7 File Offset: 0x002A10B7
		[NullableContext(1)]
		public int[] RelationFunction()
		{
			return this.GetRelationFunctionArray();
		}

		// Token: 0x06009A05 RID: 39429 RVA: 0x002A2EBF File Offset: 0x002A10BF
		[NullableContext(1)]
		public IEnumerable<int> RelationFunctionIter()
		{
			MenuConfig.<RelationFunctionIter>d__166 <RelationFunctionIter>d__ = new MenuConfig.<RelationFunctionIter>d__166(-2);
			<RelationFunctionIter>d__.<>3__<>4__this = this;
			return <RelationFunctionIter>d__;
		}

		// Token: 0x06009A06 RID: 39430 RVA: 0x002A2ED4 File Offset: 0x002A10D4
		[NullableContext(1)]
		public float[] SliderRange()
		{
			return this.GetSliderRangeArray();
		}

		// Token: 0x06009A07 RID: 39431 RVA: 0x002A2EDC File Offset: 0x002A10DC
		[NullableContext(1)]
		public IEnumerable<float> SliderRangeIter()
		{
			MenuConfig.<SliderRangeIter>d__168 <SliderRangeIter>d__ = new MenuConfig.<SliderRangeIter>d__168(-2);
			<SliderRangeIter>d__.<>3__<>4__this = this;
			return <SliderRangeIter>d__;
		}

		// Token: 0x06009A08 RID: 39432 RVA: 0x002A2EF1 File Offset: 0x002A10F1
		[NullableContext(1)]
		public float[] SliderRangeDisplay()
		{
			return this.GetSliderRangeDisplayArray();
		}

		// Token: 0x06009A09 RID: 39433 RVA: 0x002A2EF9 File Offset: 0x002A10F9
		[NullableContext(1)]
		public IEnumerable<float> SliderRangeDisplayIter()
		{
			MenuConfig.<SliderRangeDisplayIter>d__170 <SliderRangeDisplayIter>d__ = new MenuConfig.<SliderRangeDisplayIter>d__170(-2);
			<SliderRangeDisplayIter>d__.<>3__<>4__this = this;
			return <SliderRangeDisplayIter>d__;
		}

		// Token: 0x06009A0A RID: 39434 RVA: 0x002A2F0E File Offset: 0x002A110E
		[NullableContext(1)]
		public string[] SpecifyHideConsoles()
		{
			return this.SpecifyHideConsolesIter().ToArray<string>();
		}

		// Token: 0x06009A0B RID: 39435 RVA: 0x002A2F1B File Offset: 0x002A111B
		[NullableContext(1)]
		public IEnumerable<string> SpecifyHideConsolesIter()
		{
			MenuConfig.<SpecifyHideConsolesIter>d__172 <SpecifyHideConsolesIter>d__ = new MenuConfig.<SpecifyHideConsolesIter>d__172(-2);
			<SpecifyHideConsolesIter>d__.<>3__<>4__this = this;
			return <SpecifyHideConsolesIter>d__;
		}

		// Token: 0x06009A0C RID: 39436 RVA: 0x002A2F30 File Offset: 0x002A1130
		[NullableContext(1)]
		public Dictionary<int, string> ValueTipsMap()
		{
			return this.ValueTipsMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06009A0D RID: 39437 RVA: 0x002A2F86 File Offset: 0x002A1186
		[NullableContext(1)]
		public IEnumerable<DicIntString> ValueTipsMapIter()
		{
			MenuConfig.<ValueTipsMapIter>d__174 <ValueTipsMapIter>d__ = new MenuConfig.<ValueTipsMapIter>d__174(-2);
			<ValueTipsMapIter>d__.<>3__<>4__this = this;
			return <ValueTipsMapIter>d__;
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x002A2F9C File Offset: 0x002A119C
		public int? GetAffectedFunction(int key)
		{
			this.EnsureAffectedFunctionCacheIfNeeded();
			int value;
			if (!this.AffectedFunctionCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x002A2FD0 File Offset: 0x002A11D0
		public int? GetClickedTipsMap(int key)
		{
			this.EnsureClickedTipsMapCacheIfNeeded();
			int value;
			if (!this.ClickedTipsMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x002A3004 File Offset: 0x002A1204
		[NullableContext(2)]
		public string GetDisableOverrideText(int key)
		{
			this.EnsureDisableOverrideTextCacheIfNeeded();
			string result;
			if (!this.DisableOverrideTextCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x002A302C File Offset: 0x002A122C
		[NullableContext(2)]
		public string GetValueTipsMap(int key)
		{
			this.EnsureValueTipsMapCacheIfNeeded();
			string result;
			if (!this.ValueTipsMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x002A3054 File Offset: 0x002A1254
		private void EnsureAffectedFunctionCacheIfNeeded()
		{
			if (this.AffectedFunctionCache != null)
			{
				return;
			}
			this.AffectedFunctionCache = this.AffectedFunctionIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x002A30BC File Offset: 0x002A12BC
		private void EnsureClickedTipsMapCacheIfNeeded()
		{
			if (this.ClickedTipsMapCache != null)
			{
				return;
			}
			this.ClickedTipsMapCache = this.ClickedTipsMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x002A3124 File Offset: 0x002A1324
		private void EnsureDisableOverrideTextCacheIfNeeded()
		{
			if (this.DisableOverrideTextCache != null)
			{
				return;
			}
			this.DisableOverrideTextCache = this.DisableOverrideTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x002A318C File Offset: 0x002A138C
		private void EnsureValueTipsMapCacheIfNeeded()
		{
			if (this.ValueTipsMapCache != null)
			{
				return;
			}
			this.ValueTipsMapCache = this.ValueTipsMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x002A31F2 File Offset: 0x002A13F2
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetAffectedFunctionFrozenDict()
		{
			this.EnsureAffectedFunctionCacheIfNeeded();
			return this.AffectedFunctionCache;
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x002A3200 File Offset: 0x002A1400
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetClickedTipsMapFrozenDict()
		{
			this.EnsureClickedTipsMapCacheIfNeeded();
			return this.ClickedTipsMapCache;
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x002A320E File Offset: 0x002A140E
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetDisableOverrideTextFrozenDict()
		{
			this.EnsureDisableOverrideTextCacheIfNeeded();
			return this.DisableOverrideTextCache;
		}

		// Token: 0x06009A19 RID: 39449 RVA: 0x002A321C File Offset: 0x002A141C
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetValueTipsMapFrozenDict()
		{
			this.EnsureValueTipsMapCacheIfNeeded();
			return this.ValueTipsMapCache;
		}

		// Token: 0x0400548D RID: 21645
		private Table __p;

		// Token: 0x0400548E RID: 21646
		[Nullable(2)]
		private FrozenDictionary<int, int> AffectedFunctionCache;

		// Token: 0x0400548F RID: 21647
		[Nullable(2)]
		private FrozenDictionary<int, int> ClickedTipsMapCache;

		// Token: 0x04005490 RID: 21648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> DisableOverrideTextCache;

		// Token: 0x04005491 RID: 21649
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> ValueTipsMapCache;
	}
}
