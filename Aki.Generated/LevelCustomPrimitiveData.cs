using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EA4 RID: 3748
	public struct LevelCustomPrimitiveData : IFlatbufferObject
	{
		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x0600933C RID: 37692 RVA: 0x00294261 File Offset: 0x00292461
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x0029426E File Offset: 0x0029246E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x00294278 File Offset: 0x00292478
		public static LevelCustomPrimitiveData GetRootAsLevelCustomPrimitiveData(ByteBuffer _bb)
		{
			return LevelCustomPrimitiveData.GetRootAsLevelCustomPrimitiveData(_bb, default(LevelCustomPrimitiveData));
		}

		// Token: 0x0600933F RID: 37695 RVA: 0x00294294 File Offset: 0x00292494
		public static LevelCustomPrimitiveData GetRootAsLevelCustomPrimitiveData(ByteBuffer _bb, LevelCustomPrimitiveData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009340 RID: 37696 RVA: 0x002942B1 File Offset: 0x002924B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009341 RID: 37697 RVA: 0x002942C0 File Offset: 0x002924C0
		public LevelCustomPrimitiveData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06009342 RID: 37698 RVA: 0x002942D0 File Offset: 0x002924D0
		public int PbDataId
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

		// Token: 0x06009343 RID: 37699 RVA: 0x0029430C File Offset: 0x0029250C
		public float CustomPrimitiveDataIndex0(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06009344 RID: 37700 RVA: 0x00294350 File Offset: 0x00292550
		public int CustomPrimitiveDataIndex0Length
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

		// Token: 0x06009345 RID: 37701 RVA: 0x0029437B File Offset: 0x0029257B
		public Span<float> GetCustomPrimitiveDataIndex0Bytes()
		{
			return this.__p.__vector_as_span<float>(6, 4);
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x0029438A File Offset: 0x0029258A
		public float[] GetCustomPrimitiveDataIndex0Array()
		{
			return this.__p.__vector_as_array<float>(6) ?? Array.Empty<float>();
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x002943A4 File Offset: 0x002925A4
		public float CustomPrimitiveDataIndex1(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06009348 RID: 37704 RVA: 0x002943E8 File Offset: 0x002925E8
		public int CustomPrimitiveDataIndex1Length
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

		// Token: 0x06009349 RID: 37705 RVA: 0x00294413 File Offset: 0x00292613
		public Span<float> GetCustomPrimitiveDataIndex1Bytes()
		{
			return this.__p.__vector_as_span<float>(8, 4);
		}

		// Token: 0x0600934A RID: 37706 RVA: 0x00294422 File Offset: 0x00292622
		public float[] GetCustomPrimitiveDataIndex1Array()
		{
			return this.__p.__vector_as_array<float>(8) ?? Array.Empty<float>();
		}

		// Token: 0x0600934B RID: 37707 RVA: 0x0029443C File Offset: 0x0029263C
		public float CustomPrimitiveDataIndex2(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x0600934C RID: 37708 RVA: 0x00294480 File Offset: 0x00292680
		public int CustomPrimitiveDataIndex2Length
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

		// Token: 0x0600934D RID: 37709 RVA: 0x002944AC File Offset: 0x002926AC
		public Span<float> GetCustomPrimitiveDataIndex2Bytes()
		{
			return this.__p.__vector_as_span<float>(10, 4);
		}

		// Token: 0x0600934E RID: 37710 RVA: 0x002944BC File Offset: 0x002926BC
		public float[] GetCustomPrimitiveDataIndex2Array()
		{
			return this.__p.__vector_as_array<float>(10) ?? Array.Empty<float>();
		}

		// Token: 0x0600934F RID: 37711 RVA: 0x002944D4 File Offset: 0x002926D4
		public float CustomPrimitiveDataIndex3(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x06009350 RID: 37712 RVA: 0x00294518 File Offset: 0x00292718
		public int CustomPrimitiveDataIndex3Length
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

		// Token: 0x06009351 RID: 37713 RVA: 0x00294544 File Offset: 0x00292744
		public Span<float> GetCustomPrimitiveDataIndex3Bytes()
		{
			return this.__p.__vector_as_span<float>(12, 4);
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x00294554 File Offset: 0x00292754
		public float[] GetCustomPrimitiveDataIndex3Array()
		{
			return this.__p.__vector_as_array<float>(12) ?? Array.Empty<float>();
		}

		// Token: 0x06009353 RID: 37715 RVA: 0x0029456C File Offset: 0x0029276C
		public float CustomPrimitiveDataIndex4(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x06009354 RID: 37716 RVA: 0x002945B0 File Offset: 0x002927B0
		public int CustomPrimitiveDataIndex4Length
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

		// Token: 0x06009355 RID: 37717 RVA: 0x002945DC File Offset: 0x002927DC
		public Span<float> GetCustomPrimitiveDataIndex4Bytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06009356 RID: 37718 RVA: 0x002945EC File Offset: 0x002927EC
		public float[] GetCustomPrimitiveDataIndex4Array()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x06009357 RID: 37719 RVA: 0x00294604 File Offset: 0x00292804
		public float CustomPrimitiveDataIndex5(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06009358 RID: 37720 RVA: 0x00294648 File Offset: 0x00292848
		public int CustomPrimitiveDataIndex5Length
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

		// Token: 0x06009359 RID: 37721 RVA: 0x00294674 File Offset: 0x00292874
		public Span<float> GetCustomPrimitiveDataIndex5Bytes()
		{
			return this.__p.__vector_as_span<float>(16, 4);
		}

		// Token: 0x0600935A RID: 37722 RVA: 0x00294684 File Offset: 0x00292884
		public float[] GetCustomPrimitiveDataIndex5Array()
		{
			return this.__p.__vector_as_array<float>(16) ?? Array.Empty<float>();
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x0029469C File Offset: 0x0029289C
		public float CustomPrimitiveDataIndex6(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600935C RID: 37724 RVA: 0x002946E0 File Offset: 0x002928E0
		public int CustomPrimitiveDataIndex6Length
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

		// Token: 0x0600935D RID: 37725 RVA: 0x0029470C File Offset: 0x0029290C
		public Span<float> GetCustomPrimitiveDataIndex6Bytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x0029471C File Offset: 0x0029291C
		public float[] GetCustomPrimitiveDataIndex6Array()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x0600935F RID: 37727 RVA: 0x00294734 File Offset: 0x00292934
		public float CustomPrimitiveDataIndex7(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x06009360 RID: 37728 RVA: 0x00294778 File Offset: 0x00292978
		public int CustomPrimitiveDataIndex7Length
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

		// Token: 0x06009361 RID: 37729 RVA: 0x002947A4 File Offset: 0x002929A4
		public Span<float> GetCustomPrimitiveDataIndex7Bytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x06009362 RID: 37730 RVA: 0x002947B4 File Offset: 0x002929B4
		public float[] GetCustomPrimitiveDataIndex7Array()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x06009363 RID: 37731 RVA: 0x002947CC File Offset: 0x002929CC
		public float CustomPrimitiveDataIndex8(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D0D RID: 7437
		// (get) Token: 0x06009364 RID: 37732 RVA: 0x00294810 File Offset: 0x00292A10
		public int CustomPrimitiveDataIndex8Length
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

		// Token: 0x06009365 RID: 37733 RVA: 0x0029483C File Offset: 0x00292A3C
		public Span<float> GetCustomPrimitiveDataIndex8Bytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x06009366 RID: 37734 RVA: 0x0029484C File Offset: 0x00292A4C
		public float[] GetCustomPrimitiveDataIndex8Array()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x06009367 RID: 37735 RVA: 0x00294864 File Offset: 0x00292A64
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex0()
		{
			return this.GetCustomPrimitiveDataIndex0Array();
		}

		// Token: 0x06009368 RID: 37736 RVA: 0x0029486C File Offset: 0x00292A6C
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex0Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex0Iter>d__56 <CustomPrimitiveDataIndex0Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex0Iter>d__56(-2);
			<CustomPrimitiveDataIndex0Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex0Iter>d__;
		}

		// Token: 0x06009369 RID: 37737 RVA: 0x00294881 File Offset: 0x00292A81
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex1()
		{
			return this.GetCustomPrimitiveDataIndex1Array();
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x00294889 File Offset: 0x00292A89
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex1Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex1Iter>d__58 <CustomPrimitiveDataIndex1Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex1Iter>d__58(-2);
			<CustomPrimitiveDataIndex1Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex1Iter>d__;
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x0029489E File Offset: 0x00292A9E
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex2()
		{
			return this.GetCustomPrimitiveDataIndex2Array();
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x002948A6 File Offset: 0x00292AA6
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex2Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex2Iter>d__60 <CustomPrimitiveDataIndex2Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex2Iter>d__60(-2);
			<CustomPrimitiveDataIndex2Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex2Iter>d__;
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x002948BB File Offset: 0x00292ABB
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex3()
		{
			return this.GetCustomPrimitiveDataIndex3Array();
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x002948C3 File Offset: 0x00292AC3
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex3Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex3Iter>d__62 <CustomPrimitiveDataIndex3Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex3Iter>d__62(-2);
			<CustomPrimitiveDataIndex3Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex3Iter>d__;
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x002948D8 File Offset: 0x00292AD8
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex4()
		{
			return this.GetCustomPrimitiveDataIndex4Array();
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x002948E0 File Offset: 0x00292AE0
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex4Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex4Iter>d__64 <CustomPrimitiveDataIndex4Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex4Iter>d__64(-2);
			<CustomPrimitiveDataIndex4Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex4Iter>d__;
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x002948F5 File Offset: 0x00292AF5
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex5()
		{
			return this.GetCustomPrimitiveDataIndex5Array();
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x002948FD File Offset: 0x00292AFD
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex5Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex5Iter>d__66 <CustomPrimitiveDataIndex5Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex5Iter>d__66(-2);
			<CustomPrimitiveDataIndex5Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex5Iter>d__;
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x00294912 File Offset: 0x00292B12
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex6()
		{
			return this.GetCustomPrimitiveDataIndex6Array();
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x0029491A File Offset: 0x00292B1A
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex6Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex6Iter>d__68 <CustomPrimitiveDataIndex6Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex6Iter>d__68(-2);
			<CustomPrimitiveDataIndex6Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex6Iter>d__;
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x0029492F File Offset: 0x00292B2F
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex7()
		{
			return this.GetCustomPrimitiveDataIndex7Array();
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x00294937 File Offset: 0x00292B37
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex7Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex7Iter>d__70 <CustomPrimitiveDataIndex7Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex7Iter>d__70(-2);
			<CustomPrimitiveDataIndex7Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex7Iter>d__;
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x0029494C File Offset: 0x00292B4C
		[NullableContext(1)]
		public float[] CustomPrimitiveDataIndex8()
		{
			return this.GetCustomPrimitiveDataIndex8Array();
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x00294954 File Offset: 0x00292B54
		[NullableContext(1)]
		public IEnumerable<float> CustomPrimitiveDataIndex8Iter()
		{
			LevelCustomPrimitiveData.<CustomPrimitiveDataIndex8Iter>d__72 <CustomPrimitiveDataIndex8Iter>d__ = new LevelCustomPrimitiveData.<CustomPrimitiveDataIndex8Iter>d__72(-2);
			<CustomPrimitiveDataIndex8Iter>d__.<>3__<>4__this = this;
			return <CustomPrimitiveDataIndex8Iter>d__;
		}

		// Token: 0x0400543A RID: 21562
		private Table __p;
	}
}
