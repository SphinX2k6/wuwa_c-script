using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200658E RID: 25998
	public struct IDestroyFishingBoat : IFlatbufferObject
	{
		// Token: 0x1700C116 RID: 49430
		// (get) Token: 0x0602D189 RID: 184713 RVA: 0x0062FA00 File Offset: 0x0062DC00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D18A RID: 184714 RVA: 0x0062FA0D File Offset: 0x0062DC0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D18B RID: 184715 RVA: 0x0062FA14 File Offset: 0x0062DC14
		public static IDestroyFishingBoat GetRootAsIDestroyFishingBoat(ByteBuffer _bb)
		{
			return IDestroyFishingBoat.GetRootAsIDestroyFishingBoat(_bb, default(IDestroyFishingBoat));
		}

		// Token: 0x0602D18C RID: 184716 RVA: 0x0062FA30 File Offset: 0x0062DC30
		public static IDestroyFishingBoat GetRootAsIDestroyFishingBoat(ByteBuffer _bb, IDestroyFishingBoat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D18D RID: 184717 RVA: 0x0062FA4D File Offset: 0x0062DC4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D18E RID: 184718 RVA: 0x0062FA5C File Offset: 0x0062DC5C
		public IDestroyFishingBoat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602D18F RID: 184719 RVA: 0x0062FA6C File Offset: 0x0062DC6C
		public static void StartIDestroyFishingBoat(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602D190 RID: 184720 RVA: 0x0062FA75 File Offset: 0x0062DC75
		public static Offset<IDestroyFishingBoat> EndIDestroyFishingBoat(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyFishingBoat>(builder.EndTable());
		}

		// Token: 0x0602D191 RID: 184721 RVA: 0x0062FA84 File Offset: 0x0062DC84
		public IDestroyFishingBoatT UnPack()
		{
			IDestroyFishingBoatT destroyFishingBoatT = new IDestroyFishingBoatT();
			this.UnPackTo(destroyFishingBoatT);
			return destroyFishingBoatT;
		}

		// Token: 0x0602D192 RID: 184722 RVA: 0x0062FA9F File Offset: 0x0062DC9F
		public void UnPackTo(IDestroyFishingBoatT _o)
		{
		}

		// Token: 0x0602D193 RID: 184723 RVA: 0x0062FAA4 File Offset: 0x0062DCA4
		public static Offset<IDestroyFishingBoat> Pack(FlatBufferBuilder builder, IDestroyFishingBoatT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyFishingBoat>);
			}
			IDestroyFishingBoat.StartIDestroyFishingBoat(builder);
			return IDestroyFishingBoat.EndIDestroyFishingBoat(builder);
		}

		// Token: 0x04010BE8 RID: 68584
		private Table __p;
	}
}
