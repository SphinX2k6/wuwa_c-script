using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001205 RID: 4613
	public struct SolarSchoolShopGoods : IFlatbufferObject
	{
		// Token: 0x17003AAC RID: 15020
		// (get) Token: 0x0600E400 RID: 58368 RVA: 0x00346C05 File Offset: 0x00344E05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E401 RID: 58369 RVA: 0x00346C12 File Offset: 0x00344E12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E402 RID: 58370 RVA: 0x00346C1C File Offset: 0x00344E1C
		public static SolarSchoolShopGoods GetRootAsSolarSchoolShopGoods(ByteBuffer _bb)
		{
			return SolarSchoolShopGoods.GetRootAsSolarSchoolShopGoods(_bb, default(SolarSchoolShopGoods));
		}

		// Token: 0x0600E403 RID: 58371 RVA: 0x00346C38 File Offset: 0x00344E38
		public static SolarSchoolShopGoods GetRootAsSolarSchoolShopGoods(ByteBuffer _bb, SolarSchoolShopGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E404 RID: 58372 RVA: 0x00346C55 File Offset: 0x00344E55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E405 RID: 58373 RVA: 0x00346C64 File Offset: 0x00344E64
		public SolarSchoolShopGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AAD RID: 15021
		// (get) Token: 0x0600E406 RID: 58374 RVA: 0x00346C74 File Offset: 0x00344E74
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

		// Token: 0x17003AAE RID: 15022
		// (get) Token: 0x0600E407 RID: 58375 RVA: 0x00346CB0 File Offset: 0x00344EB0
		public int GroupId
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

		// Token: 0x17003AAF RID: 15023
		// (get) Token: 0x0600E408 RID: 58376 RVA: 0x00346CEC File Offset: 0x00344EEC
		public int ItemId
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

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x0600E409 RID: 58377 RVA: 0x00346D28 File Offset: 0x00344F28
		public int Price
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

		// Token: 0x17003AB1 RID: 15025
		// (get) Token: 0x0600E40A RID: 58378 RVA: 0x00346D68 File Offset: 0x00344F68
		public int Discount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x0600E40B RID: 58379 RVA: 0x00346DAC File Offset: 0x00344FAC
		public int BuyLimit
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

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x0600E40C RID: 58380 RVA: 0x00346DEC File Offset: 0x00344FEC
		public int ShowConditionId
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

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x0600E40D RID: 58381 RVA: 0x00346E2C File Offset: 0x0034502C
		public int IsSpecial
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

		// Token: 0x04005843 RID: 22595
		private Table __p;
	}
}
