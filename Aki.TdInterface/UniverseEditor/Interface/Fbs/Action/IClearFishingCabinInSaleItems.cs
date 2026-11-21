using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F6 RID: 27126
	public struct IClearFishingCabinInSaleItems : IFlatbufferObject
	{
		// Token: 0x1700C77B RID: 51067
		// (get) Token: 0x0602E877 RID: 190583 RVA: 0x00658A02 File Offset: 0x00656C02
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E878 RID: 190584 RVA: 0x00658A0F File Offset: 0x00656C0F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E879 RID: 190585 RVA: 0x00658A18 File Offset: 0x00656C18
		public static IClearFishingCabinInSaleItems GetRootAsIClearFishingCabinInSaleItems(ByteBuffer _bb)
		{
			return IClearFishingCabinInSaleItems.GetRootAsIClearFishingCabinInSaleItems(_bb, default(IClearFishingCabinInSaleItems));
		}

		// Token: 0x0602E87A RID: 190586 RVA: 0x00658A34 File Offset: 0x00656C34
		public static IClearFishingCabinInSaleItems GetRootAsIClearFishingCabinInSaleItems(ByteBuffer _bb, IClearFishingCabinInSaleItems obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E87B RID: 190587 RVA: 0x00658A51 File Offset: 0x00656C51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E87C RID: 190588 RVA: 0x00658A60 File Offset: 0x00656C60
		public IClearFishingCabinInSaleItems __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E87D RID: 190589 RVA: 0x00658A70 File Offset: 0x00656C70
		public static void StartIClearFishingCabinInSaleItems(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E87E RID: 190590 RVA: 0x00658A79 File Offset: 0x00656C79
		public static Offset<IClearFishingCabinInSaleItems> EndIClearFishingCabinInSaleItems(FlatBufferBuilder builder)
		{
			return new Offset<IClearFishingCabinInSaleItems>(builder.EndTable());
		}

		// Token: 0x0602E87F RID: 190591 RVA: 0x00658A88 File Offset: 0x00656C88
		public IClearFishingCabinInSaleItemsT UnPack()
		{
			IClearFishingCabinInSaleItemsT clearFishingCabinInSaleItemsT = new IClearFishingCabinInSaleItemsT();
			this.UnPackTo(clearFishingCabinInSaleItemsT);
			return clearFishingCabinInSaleItemsT;
		}

		// Token: 0x0602E880 RID: 190592 RVA: 0x00658AA3 File Offset: 0x00656CA3
		public void UnPackTo(IClearFishingCabinInSaleItemsT _o)
		{
		}

		// Token: 0x0602E881 RID: 190593 RVA: 0x00658AA8 File Offset: 0x00656CA8
		public static Offset<IClearFishingCabinInSaleItems> Pack(FlatBufferBuilder builder, IClearFishingCabinInSaleItemsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClearFishingCabinInSaleItems>);
			}
			IClearFishingCabinInSaleItems.StartIClearFishingCabinInSaleItems(builder);
			return IClearFishingCabinInSaleItems.EndIClearFishingCabinInSaleItems(builder);
		}

		// Token: 0x04011765 RID: 71525
		private Table __p;
	}
}
