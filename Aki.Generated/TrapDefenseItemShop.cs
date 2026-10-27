using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001164 RID: 4452
	public struct TrapDefenseItemShop : IFlatbufferObject
	{
		// Token: 0x17003C3A RID: 15418
		// (get) Token: 0x0600E3BF RID: 58303 RVA: 0x0033907A File Offset: 0x0033727A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E3C0 RID: 58304 RVA: 0x00339087 File Offset: 0x00337287
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E3C1 RID: 58305 RVA: 0x00339090 File Offset: 0x00337290
		public static TrapDefenseItemShop GetRootAsTrapDefenseItemShop(ByteBuffer _bb)
		{
			return TrapDefenseItemShop.GetRootAsTrapDefenseItemShop(_bb, default(TrapDefenseItemShop));
		}

		// Token: 0x0600E3C2 RID: 58306 RVA: 0x003390AC File Offset: 0x003372AC
		public static TrapDefenseItemShop GetRootAsTrapDefenseItemShop(ByteBuffer _bb, TrapDefenseItemShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E3C3 RID: 58307 RVA: 0x003390C9 File Offset: 0x003372C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E3C4 RID: 58308 RVA: 0x003390D8 File Offset: 0x003372D8
		public TrapDefenseItemShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C3B RID: 15419
		// (get) Token: 0x0600E3C5 RID: 58309 RVA: 0x003390E8 File Offset: 0x003372E8
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

		// Token: 0x17003C3C RID: 15420
		// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x00339124 File Offset: 0x00337324
		public int RefreshCount
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

		// Token: 0x0600E3C7 RID: 58311 RVA: 0x00339160 File Offset: 0x00337360
		public IntArray? BdDrawActionQuantities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003C3D RID: 15421
		// (get) Token: 0x0600E3C8 RID: 58312 RVA: 0x003391C0 File Offset: 0x003373C0
		public int BdDrawActionQuantitiesLength
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

		// Token: 0x0600E3C9 RID: 58313 RVA: 0x003391EC File Offset: 0x003373EC
		public IntArray? ItemInfos(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003C3E RID: 15422
		// (get) Token: 0x0600E3CA RID: 58314 RVA: 0x00339250 File Offset: 0x00337450
		public int ItemInfosLength
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

		// Token: 0x0600E3CB RID: 58315 RVA: 0x0033927C File Offset: 0x0033747C
		public int TieredRefreshPrices(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x0600E3CC RID: 58316 RVA: 0x003392BC File Offset: 0x003374BC
		public int TieredRefreshPricesLength
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

		// Token: 0x0600E3CD RID: 58317 RVA: 0x003392E8 File Offset: 0x003374E8
		public Span<int> GetTieredRefreshPricesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E3CE RID: 58318 RVA: 0x003392F8 File Offset: 0x003374F8
		public int[] GetTieredRefreshPricesArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600E3CF RID: 58319 RVA: 0x00339310 File Offset: 0x00337510
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BdDrawActionQuantitiesIter()或GetBdDrawActionQuantitiesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] BdDrawActionQuantities()
		{
			return this.BdDrawActionQuantitiesIter().ToArray<IntArray>();
		}

		// Token: 0x0600E3D0 RID: 58320 RVA: 0x0033931D File Offset: 0x0033751D
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> BdDrawActionQuantitiesIter()
		{
			TrapDefenseItemShop.<BdDrawActionQuantitiesIter>d__24 <BdDrawActionQuantitiesIter>d__ = new TrapDefenseItemShop.<BdDrawActionQuantitiesIter>d__24(-2);
			<BdDrawActionQuantitiesIter>d__.<>3__<>4__this = this;
			return <BdDrawActionQuantitiesIter>d__;
		}

		// Token: 0x0600E3D1 RID: 58321 RVA: 0x00339332 File Offset: 0x00337532
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemInfosIter()或GetItemInfosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntArray[] ItemInfos()
		{
			return this.ItemInfosIter().ToArray<IntArray>();
		}

		// Token: 0x0600E3D2 RID: 58322 RVA: 0x0033933F File Offset: 0x0033753F
		[NullableContext(1)]
		public readonly IEnumerable<IntArray> ItemInfosIter()
		{
			TrapDefenseItemShop.<ItemInfosIter>d__26 <ItemInfosIter>d__ = new TrapDefenseItemShop.<ItemInfosIter>d__26(-2);
			<ItemInfosIter>d__.<>3__<>4__this = this;
			return <ItemInfosIter>d__;
		}

		// Token: 0x0600E3D3 RID: 58323 RVA: 0x00339354 File Offset: 0x00337554
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TieredRefreshPricesIter()或GetTieredRefreshPricesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TieredRefreshPrices()
		{
			TrapDefenseItemShop trapDefenseItemShop = this;
			return trapDefenseItemShop.GetTieredRefreshPricesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E3D4 RID: 58324 RVA: 0x00339378 File Offset: 0x00337578
		[NullableContext(1)]
		public readonly IEnumerable<int> TieredRefreshPricesIter()
		{
			TrapDefenseItemShop.<TieredRefreshPricesIter>d__28 <TieredRefreshPricesIter>d__ = new TrapDefenseItemShop.<TieredRefreshPricesIter>d__28(-2);
			<TieredRefreshPricesIter>d__.<>3__<>4__this = this;
			return <TieredRefreshPricesIter>d__;
		}

		// Token: 0x040052AA RID: 21162
		private Table __p;
	}
}
