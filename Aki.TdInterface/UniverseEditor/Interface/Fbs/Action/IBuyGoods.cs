using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A7 RID: 26791
	public struct IBuyGoods : IFlatbufferObject
	{
		// Token: 0x1700C4DF RID: 50399
		// (get) Token: 0x0602DCD1 RID: 187601 RVA: 0x006428D7 File Offset: 0x00640AD7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DCD2 RID: 187602 RVA: 0x006428E4 File Offset: 0x00640AE4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DCD3 RID: 187603 RVA: 0x006428EC File Offset: 0x00640AEC
		public static IBuyGoods GetRootAsIBuyGoods(ByteBuffer _bb)
		{
			return IBuyGoods.GetRootAsIBuyGoods(_bb, default(IBuyGoods));
		}

		// Token: 0x0602DCD4 RID: 187604 RVA: 0x00642908 File Offset: 0x00640B08
		public static IBuyGoods GetRootAsIBuyGoods(ByteBuffer _bb, IBuyGoods obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DCD5 RID: 187605 RVA: 0x00642925 File Offset: 0x00640B25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DCD6 RID: 187606 RVA: 0x00642934 File Offset: 0x00640B34
		public IBuyGoods __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4E0 RID: 50400
		// (get) Token: 0x0602DCD7 RID: 187607 RVA: 0x00642944 File Offset: 0x00640B44
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

		// Token: 0x1700C4E1 RID: 50401
		// (get) Token: 0x0602DCD8 RID: 187608 RVA: 0x00642980 File Offset: 0x00640B80
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

		// Token: 0x0602DCD9 RID: 187609 RVA: 0x006429BC File Offset: 0x00640BBC
		public static Offset<IBuyGoods> CreateIBuyGoods(FlatBufferBuilder builder, ESystemFunction Type = ESystemFunction.BuyGoods, int GoodsId = 0)
		{
			builder.StartTable(2);
			IBuyGoods.AddGoodsId(builder, GoodsId);
			IBuyGoods.AddType(builder, Type);
			return IBuyGoods.EndIBuyGoods(builder);
		}

		// Token: 0x0602DCDA RID: 187610 RVA: 0x006429D9 File Offset: 0x00640BD9
		public static void StartIBuyGoods(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DCDB RID: 187611 RVA: 0x006429E2 File Offset: 0x00640BE2
		public static void AddType(FlatBufferBuilder builder, ESystemFunction type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DCDC RID: 187612 RVA: 0x006429ED File Offset: 0x00640BED
		public static void AddGoodsId(FlatBufferBuilder builder, int goodsId)
		{
			builder.AddInt(1, goodsId, 0);
		}

		// Token: 0x0602DCDD RID: 187613 RVA: 0x006429F8 File Offset: 0x00640BF8
		public static Offset<IBuyGoods> EndIBuyGoods(FlatBufferBuilder builder)
		{
			return new Offset<IBuyGoods>(builder.EndTable());
		}

		// Token: 0x0602DCDE RID: 187614 RVA: 0x00642A08 File Offset: 0x00640C08
		public IBuyGoodsT UnPack()
		{
			IBuyGoodsT buyGoodsT = new IBuyGoodsT();
			this.UnPackTo(buyGoodsT);
			return buyGoodsT;
		}

		// Token: 0x0602DCDF RID: 187615 RVA: 0x00642A23 File Offset: 0x00640C23
		public void UnPackTo(IBuyGoodsT _o)
		{
			_o.Type = this.Type;
			_o.GoodsId = this.GoodsId;
		}

		// Token: 0x0602DCE0 RID: 187616 RVA: 0x00642A40 File Offset: 0x00640C40
		public static Offset<IBuyGoods> Pack(FlatBufferBuilder builder, IBuyGoodsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBuyGoods>);
			}
			return IBuyGoods.CreateIBuyGoods(builder, _o.Type, _o.GoodsId);
		}

		// Token: 0x04011590 RID: 71056
		private Table __p;
	}
}
