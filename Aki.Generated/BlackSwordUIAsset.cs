using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C1B RID: 3099
	public struct BlackSwordUIAsset : IFlatbufferObject
	{
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06005399 RID: 21401 RVA: 0x002050BC File Offset: 0x002032BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x002050C9 File Offset: 0x002032C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x002050D0 File Offset: 0x002032D0
		public static BlackSwordUIAsset GetRootAsBlackSwordUIAsset(ByteBuffer _bb)
		{
			return BlackSwordUIAsset.GetRootAsBlackSwordUIAsset(_bb, default(BlackSwordUIAsset));
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x002050EC File Offset: 0x002032EC
		public static BlackSwordUIAsset GetRootAsBlackSwordUIAsset(ByteBuffer _bb, BlackSwordUIAsset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00205109 File Offset: 0x00203309
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00205118 File Offset: 0x00203318
		public BlackSwordUIAsset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600539F RID: 21407 RVA: 0x00205128 File Offset: 0x00203328
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

		// Token: 0x060053A0 RID: 21408 RVA: 0x00205164 File Offset: 0x00203364
		public string LevelColors(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060053A1 RID: 21409 RVA: 0x002051A0 File Offset: 0x002033A0
		public int LevelColorsLength
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

		// Token: 0x060053A2 RID: 21410 RVA: 0x002051CC File Offset: 0x002033CC
		public string PatternPaths(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060053A3 RID: 21411 RVA: 0x00205208 File Offset: 0x00203408
		public int PatternPathsLength
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

		// Token: 0x060053A4 RID: 21412 RVA: 0x00205234 File Offset: 0x00203434
		public string StarPaths(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060053A5 RID: 21413 RVA: 0x00205270 File Offset: 0x00203470
		public int StarPathsLength
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

		// Token: 0x060053A6 RID: 21414 RVA: 0x0020529C File Offset: 0x0020349C
		public string CountDownTextAsset(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060053A7 RID: 21415 RVA: 0x002052D8 File Offset: 0x002034D8
		public int CountDownTextAssetLength
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

		// Token: 0x060053A8 RID: 21416 RVA: 0x00205304 File Offset: 0x00203504
		[NullableContext(1)]
		public string[] CountDownTextAsset()
		{
			return this.CountDownTextAssetIter().ToArray<string>();
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x00205311 File Offset: 0x00203511
		[NullableContext(1)]
		public IEnumerable<string> CountDownTextAssetIter()
		{
			BlackSwordUIAsset.<CountDownTextAssetIter>d__23 <CountDownTextAssetIter>d__ = new BlackSwordUIAsset.<CountDownTextAssetIter>d__23(-2);
			<CountDownTextAssetIter>d__.<>3__<>4__this = this;
			return <CountDownTextAssetIter>d__;
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x00205326 File Offset: 0x00203526
		[NullableContext(1)]
		public string[] LevelColors()
		{
			return this.LevelColorsIter().ToArray<string>();
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00205333 File Offset: 0x00203533
		[NullableContext(1)]
		public IEnumerable<string> LevelColorsIter()
		{
			BlackSwordUIAsset.<LevelColorsIter>d__25 <LevelColorsIter>d__ = new BlackSwordUIAsset.<LevelColorsIter>d__25(-2);
			<LevelColorsIter>d__.<>3__<>4__this = this;
			return <LevelColorsIter>d__;
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x00205348 File Offset: 0x00203548
		[NullableContext(1)]
		public string[] PatternPaths()
		{
			return this.PatternPathsIter().ToArray<string>();
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x00205355 File Offset: 0x00203555
		[NullableContext(1)]
		public IEnumerable<string> PatternPathsIter()
		{
			BlackSwordUIAsset.<PatternPathsIter>d__27 <PatternPathsIter>d__ = new BlackSwordUIAsset.<PatternPathsIter>d__27(-2);
			<PatternPathsIter>d__.<>3__<>4__this = this;
			return <PatternPathsIter>d__;
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x0020536A File Offset: 0x0020356A
		[NullableContext(1)]
		public string[] StarPaths()
		{
			return this.StarPathsIter().ToArray<string>();
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00205377 File Offset: 0x00203577
		[NullableContext(1)]
		public IEnumerable<string> StarPathsIter()
		{
			BlackSwordUIAsset.<StarPathsIter>d__29 <StarPathsIter>d__ = new BlackSwordUIAsset.<StarPathsIter>d__29(-2);
			<StarPathsIter>d__.<>3__<>4__this = this;
			return <StarPathsIter>d__;
		}

		// Token: 0x04005116 RID: 20758
		private Table __p;
	}
}
