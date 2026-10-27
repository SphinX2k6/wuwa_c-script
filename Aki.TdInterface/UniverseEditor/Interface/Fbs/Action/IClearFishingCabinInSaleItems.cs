using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006385 RID: 25477
	public struct IClearFishingCabinInSaleItems : IFlatbufferObject
	{
		// Token: 0x1700BDF3 RID: 48627
		// (get) Token: 0x0602C10D RID: 180493 RVA: 0x0060D8AE File Offset: 0x0060BAAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C10E RID: 180494 RVA: 0x0060D8BB File Offset: 0x0060BABB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C10F RID: 180495 RVA: 0x0060D8C4 File Offset: 0x0060BAC4
		public static IClearFishingCabinInSaleItems GetRootAsIClearFishingCabinInSaleItems(ByteBuffer _bb)
		{
			return IClearFishingCabinInSaleItems.GetRootAsIClearFishingCabinInSaleItems(_bb, default(IClearFishingCabinInSaleItems));
		}

		// Token: 0x0602C110 RID: 180496 RVA: 0x0060D8E0 File Offset: 0x0060BAE0
		public static IClearFishingCabinInSaleItems GetRootAsIClearFishingCabinInSaleItems(ByteBuffer _bb, IClearFishingCabinInSaleItems obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C111 RID: 180497 RVA: 0x0060D8FD File Offset: 0x0060BAFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C112 RID: 180498 RVA: 0x0060D90C File Offset: 0x0060BB0C
		public IClearFishingCabinInSaleItems __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C113 RID: 180499 RVA: 0x0060D91C File Offset: 0x0060BB1C
		public static void StartIClearFishingCabinInSaleItems(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602C114 RID: 180500 RVA: 0x0060D925 File Offset: 0x0060BB25
		public static Offset<IClearFishingCabinInSaleItems> EndIClearFishingCabinInSaleItems(FlatBufferBuilder builder)
		{
			return new Offset<IClearFishingCabinInSaleItems>(builder.EndTable());
		}

		// Token: 0x0602C115 RID: 180501 RVA: 0x0060D934 File Offset: 0x0060BB34
		public IClearFishingCabinInSaleItemsT UnPack()
		{
			IClearFishingCabinInSaleItemsT clearFishingCabinInSaleItemsT = new IClearFishingCabinInSaleItemsT();
			this.UnPackTo(clearFishingCabinInSaleItemsT);
			return clearFishingCabinInSaleItemsT;
		}

		// Token: 0x0602C116 RID: 180502 RVA: 0x0060D94F File Offset: 0x0060BB4F
		public void UnPackTo(IClearFishingCabinInSaleItemsT _o)
		{
		}

		// Token: 0x0602C117 RID: 180503 RVA: 0x0060D954 File Offset: 0x0060BB54
		public static Offset<IClearFishingCabinInSaleItems> Pack(FlatBufferBuilder builder, IClearFishingCabinInSaleItemsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClearFishingCabinInSaleItems>);
			}
			IClearFishingCabinInSaleItems.StartIClearFishingCabinInSaleItems(builder);
			return IClearFishingCabinInSaleItems.EndIClearFishingCabinInSaleItems(builder);
		}

		// Token: 0x04010950 RID: 67920
		private Table __p;
	}
}
