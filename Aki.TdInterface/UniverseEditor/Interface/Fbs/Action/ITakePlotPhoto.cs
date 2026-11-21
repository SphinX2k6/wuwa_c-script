using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A61 RID: 31329
	public struct ITakePlotPhoto : IFlatbufferObject
	{
		// Token: 0x1700E584 RID: 58756
		// (get) Token: 0x0603737D RID: 226173 RVA: 0x00760278 File Offset: 0x0075E478
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603737E RID: 226174 RVA: 0x00760285 File Offset: 0x0075E485
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603737F RID: 226175 RVA: 0x0076028C File Offset: 0x0075E48C
		public static ITakePlotPhoto GetRootAsITakePlotPhoto(ByteBuffer _bb)
		{
			return ITakePlotPhoto.GetRootAsITakePlotPhoto(_bb, default(ITakePlotPhoto));
		}

		// Token: 0x06037380 RID: 226176 RVA: 0x007602A8 File Offset: 0x0075E4A8
		public static ITakePlotPhoto GetRootAsITakePlotPhoto(ByteBuffer _bb, ITakePlotPhoto obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037381 RID: 226177 RVA: 0x007602C5 File Offset: 0x0075E4C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037382 RID: 226178 RVA: 0x007602D4 File Offset: 0x0075E4D4
		public ITakePlotPhoto __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06037383 RID: 226179 RVA: 0x007602E4 File Offset: 0x0075E4E4
		public static void StartITakePlotPhoto(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06037384 RID: 226180 RVA: 0x007602ED File Offset: 0x0075E4ED
		public static Offset<ITakePlotPhoto> EndITakePlotPhoto(FlatBufferBuilder builder)
		{
			return new Offset<ITakePlotPhoto>(builder.EndTable());
		}

		// Token: 0x06037385 RID: 226181 RVA: 0x007602FC File Offset: 0x0075E4FC
		public ITakePlotPhotoT UnPack()
		{
			ITakePlotPhotoT takePlotPhotoT = new ITakePlotPhotoT();
			this.UnPackTo(takePlotPhotoT);
			return takePlotPhotoT;
		}

		// Token: 0x06037386 RID: 226182 RVA: 0x00760317 File Offset: 0x0075E517
		public void UnPackTo(ITakePlotPhotoT _o)
		{
		}

		// Token: 0x06037387 RID: 226183 RVA: 0x0076031C File Offset: 0x0075E51C
		public static Offset<ITakePlotPhoto> Pack(FlatBufferBuilder builder, ITakePlotPhotoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePlotPhoto>);
			}
			ITakePlotPhoto.StartITakePlotPhoto(builder);
			return ITakePlotPhoto.EndITakePlotPhoto(builder);
		}

		// Token: 0x04012D9F RID: 77215
		private Table __p;
	}
}
