using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200129A RID: 4762
	public struct TrapDefenseItemShop : IFlatbufferObject
	{
		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x0600F12D RID: 61741 RVA: 0x0036405E File Offset: 0x0036225E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F12E RID: 61742 RVA: 0x0036406B File Offset: 0x0036226B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F12F RID: 61743 RVA: 0x00364074 File Offset: 0x00362274
		public static TrapDefenseItemShop GetRootAsTrapDefenseItemShop(ByteBuffer _bb)
		{
			return TrapDefenseItemShop.GetRootAsTrapDefenseItemShop(_bb, default(TrapDefenseItemShop));
		}

		// Token: 0x0600F130 RID: 61744 RVA: 0x00364090 File Offset: 0x00362290
		public static TrapDefenseItemShop GetRootAsTrapDefenseItemShop(ByteBuffer _bb, TrapDefenseItemShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F131 RID: 61745 RVA: 0x003640AD File Offset: 0x003622AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F132 RID: 61746 RVA: 0x003640BC File Offset: 0x003622BC
		public TrapDefenseItemShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x0600F133 RID: 61747 RVA: 0x003640CC File Offset: 0x003622CC
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

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x0600F134 RID: 61748 RVA: 0x00364108 File Offset: 0x00362308
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

		// Token: 0x0600F135 RID: 61749 RVA: 0x00364144 File Offset: 0x00362344
		public IntArray? BdDrawActionQuantities(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x0600F136 RID: 61750 RVA: 0x003641A4 File Offset: 0x003623A4
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

		// Token: 0x0600F137 RID: 61751 RVA: 0x003641D0 File Offset: 0x003623D0
		public IntArray? ItemInfos(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IntArray?(default(IntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x0600F138 RID: 61752 RVA: 0x00364234 File Offset: 0x00362434
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

		// Token: 0x0600F139 RID: 61753 RVA: 0x00364260 File Offset: 0x00362460
		public int TieredRefreshPrices(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x0600F13A RID: 61754 RVA: 0x003642A0 File Offset: 0x003624A0
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

		// Token: 0x0600F13B RID: 61755 RVA: 0x003642CC File Offset: 0x003624CC
		public Span<int> GetTieredRefreshPricesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600F13C RID: 61756 RVA: 0x003642DC File Offset: 0x003624DC
		public int[] GetTieredRefreshPricesArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600F13D RID: 61757 RVA: 0x003642F4 File Offset: 0x003624F4
		[NullableContext(1)]
		public IntArray[] BdDrawActionQuantities()
		{
			return this.BdDrawActionQuantitiesIter().ToArray<IntArray>();
		}

		// Token: 0x0600F13E RID: 61758 RVA: 0x00364301 File Offset: 0x00362501
		[NullableContext(1)]
		public IEnumerable<IntArray> BdDrawActionQuantitiesIter()
		{
			TrapDefenseItemShop.<BdDrawActionQuantitiesIter>d__24 <BdDrawActionQuantitiesIter>d__ = new TrapDefenseItemShop.<BdDrawActionQuantitiesIter>d__24(-2);
			<BdDrawActionQuantitiesIter>d__.<>3__<>4__this = this;
			return <BdDrawActionQuantitiesIter>d__;
		}

		// Token: 0x0600F13F RID: 61759 RVA: 0x00364316 File Offset: 0x00362516
		[NullableContext(1)]
		public IntArray[] ItemInfos()
		{
			return this.ItemInfosIter().ToArray<IntArray>();
		}

		// Token: 0x0600F140 RID: 61760 RVA: 0x00364323 File Offset: 0x00362523
		[NullableContext(1)]
		public IEnumerable<IntArray> ItemInfosIter()
		{
			TrapDefenseItemShop.<ItemInfosIter>d__26 <ItemInfosIter>d__ = new TrapDefenseItemShop.<ItemInfosIter>d__26(-2);
			<ItemInfosIter>d__.<>3__<>4__this = this;
			return <ItemInfosIter>d__;
		}

		// Token: 0x0600F141 RID: 61761 RVA: 0x00364338 File Offset: 0x00362538
		[NullableContext(1)]
		public int[] TieredRefreshPrices()
		{
			return this.GetTieredRefreshPricesArray();
		}

		// Token: 0x0600F142 RID: 61762 RVA: 0x00364340 File Offset: 0x00362540
		[NullableContext(1)]
		public IEnumerable<int> TieredRefreshPricesIter()
		{
			TrapDefenseItemShop.<TieredRefreshPricesIter>d__28 <TieredRefreshPricesIter>d__ = new TrapDefenseItemShop.<TieredRefreshPricesIter>d__28(-2);
			<TieredRefreshPricesIter>d__.<>3__<>4__this = this;
			return <TieredRefreshPricesIter>d__;
		}

		// Token: 0x040058ED RID: 22765
		private Table __p;
	}
}
