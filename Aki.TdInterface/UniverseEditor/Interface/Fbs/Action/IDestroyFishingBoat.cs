using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF6 RID: 27638
	public struct IDestroyFishingBoat : IFlatbufferObject
	{
		// Token: 0x1700CAA5 RID: 51877
		// (get) Token: 0x0602F90D RID: 194829 RVA: 0x0067BBC4 File Offset: 0x00679DC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F90E RID: 194830 RVA: 0x0067BBD1 File Offset: 0x00679DD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F90F RID: 194831 RVA: 0x0067BBD8 File Offset: 0x00679DD8
		public static IDestroyFishingBoat GetRootAsIDestroyFishingBoat(ByteBuffer _bb)
		{
			return IDestroyFishingBoat.GetRootAsIDestroyFishingBoat(_bb, default(IDestroyFishingBoat));
		}

		// Token: 0x0602F910 RID: 194832 RVA: 0x0067BBF4 File Offset: 0x00679DF4
		public static IDestroyFishingBoat GetRootAsIDestroyFishingBoat(ByteBuffer _bb, IDestroyFishingBoat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F911 RID: 194833 RVA: 0x0067BC11 File Offset: 0x00679E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F912 RID: 194834 RVA: 0x0067BC20 File Offset: 0x00679E20
		public IDestroyFishingBoat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F913 RID: 194835 RVA: 0x0067BC30 File Offset: 0x00679E30
		public static void StartIDestroyFishingBoat(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602F914 RID: 194836 RVA: 0x0067BC39 File Offset: 0x00679E39
		public static Offset<IDestroyFishingBoat> EndIDestroyFishingBoat(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyFishingBoat>(builder.EndTable());
		}

		// Token: 0x0602F915 RID: 194837 RVA: 0x0067BC48 File Offset: 0x00679E48
		public IDestroyFishingBoatT UnPack()
		{
			IDestroyFishingBoatT destroyFishingBoatT = new IDestroyFishingBoatT();
			this.UnPackTo(destroyFishingBoatT);
			return destroyFishingBoatT;
		}

		// Token: 0x0602F916 RID: 194838 RVA: 0x0067BC63 File Offset: 0x00679E63
		public void UnPackTo(IDestroyFishingBoatT _o)
		{
		}

		// Token: 0x0602F917 RID: 194839 RVA: 0x0067BC68 File Offset: 0x00679E68
		public static Offset<IDestroyFishingBoat> Pack(FlatBufferBuilder builder, IDestroyFishingBoatT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyFishingBoat>);
			}
			IDestroyFishingBoat.StartIDestroyFishingBoat(builder);
			return IDestroyFishingBoat.EndIDestroyFishingBoat(builder);
		}

		// Token: 0x040119FA RID: 72186
		private Table __p;
	}
}
