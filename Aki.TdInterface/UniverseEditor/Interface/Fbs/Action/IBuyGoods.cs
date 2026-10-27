using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006236 RID: 25142
	public struct IBuyGoods : IFlatbufferObject
	{
		// Token: 0x1700BB57 RID: 47959
		// (get) Token: 0x0602B570 RID: 177520 RVA: 0x005F7ACF File Offset: 0x005F5CCF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B571 RID: 177521 RVA: 0x005F7ADC File Offset: 0x005F5CDC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B572 RID: 177522 RVA: 0x005F7AE4 File Offset: 0x005F5CE4
		public static IBuyGoods GetRootAsIBuyGoods(ByteBuffer _bb)
		{
			return IBuyGoods.GetRootAsIBuyGoods(_bb, default(IBuyGoods));
		}

		// Token: 0x0602B573 RID: 177523 RVA: 0x005F7B00 File Offset: 0x005F5D00
		public static IBuyGoods GetRootAsIBuyGoods(ByteBuffer _bb, IBuyGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B574 RID: 177524 RVA: 0x005F7B1D File Offset: 0x005F5D1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B575 RID: 177525 RVA: 0x005F7B2C File Offset: 0x005F5D2C
		public IBuyGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB58 RID: 47960
		// (get) Token: 0x0602B576 RID: 177526 RVA: 0x005F7B3C File Offset: 0x005F5D3C
		public ESystemFunction Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemFunction.BuyGoods;
				}
				return (ESystemFunction)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BB59 RID: 47961
		// (get) Token: 0x0602B577 RID: 177527 RVA: 0x005F7B78 File Offset: 0x005F5D78
		public int GoodsId
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

		// Token: 0x0602B578 RID: 177528 RVA: 0x005F7BB4 File Offset: 0x005F5DB4
		public static Offset<IBuyGoods> CreateIBuyGoods(FlatBufferBuilder builder, ESystemFunction Type = ESystemFunction.BuyGoods, int GoodsId = 0)
		{
			builder.StartTable(2);
			IBuyGoods.AddGoodsId(builder, GoodsId);
			IBuyGoods.AddType(builder, Type);
			return IBuyGoods.EndIBuyGoods(builder);
		}

		// Token: 0x0602B579 RID: 177529 RVA: 0x005F7BD1 File Offset: 0x005F5DD1
		public static void StartIBuyGoods(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B57A RID: 177530 RVA: 0x005F7BDA File Offset: 0x005F5DDA
		public static void AddType(FlatBufferBuilder builder, ESystemFunction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B57B RID: 177531 RVA: 0x005F7BE5 File Offset: 0x005F5DE5
		public static void AddGoodsId(FlatBufferBuilder builder, int goodsId)
		{
			builder.AddInt(1, goodsId, 0);
		}

		// Token: 0x0602B57C RID: 177532 RVA: 0x005F7BF0 File Offset: 0x005F5DF0
		public static Offset<IBuyGoods> EndIBuyGoods(FlatBufferBuilder builder)
		{
			return new Offset<IBuyGoods>(builder.EndTable());
		}

		// Token: 0x0602B57D RID: 177533 RVA: 0x005F7C00 File Offset: 0x005F5E00
		public IBuyGoodsT UnPack()
		{
			IBuyGoodsT buyGoodsT = new IBuyGoodsT();
			this.UnPackTo(buyGoodsT);
			return buyGoodsT;
		}

		// Token: 0x0602B57E RID: 177534 RVA: 0x005F7C1B File Offset: 0x005F5E1B
		public void UnPackTo(IBuyGoodsT _o)
		{
			_o.Type = this.Type;
			_o.GoodsId = this.GoodsId;
		}

		// Token: 0x0602B57F RID: 177535 RVA: 0x005F7C38 File Offset: 0x005F5E38
		public static Offset<IBuyGoods> Pack(FlatBufferBuilder builder, IBuyGoodsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuyGoods>);
			}
			return IBuyGoods.CreateIBuyGoods(builder, _o.Type, _o.GoodsId);
		}

		// Token: 0x0401077B RID: 67451
		private Table __p;
	}
}
