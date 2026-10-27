using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728C RID: 29324
	public struct ITakePlotPhoto : IFlatbufferObject
	{
		// Token: 0x1700D98B RID: 55691
		// (get) Token: 0x06034079 RID: 213113 RVA: 0x006FEEDA File Offset: 0x006FD0DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603407A RID: 213114 RVA: 0x006FEEE7 File Offset: 0x006FD0E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603407B RID: 213115 RVA: 0x006FEEF0 File Offset: 0x006FD0F0
		public static ITakePlotPhoto GetRootAsITakePlotPhoto(ByteBuffer _bb)
		{
			return ITakePlotPhoto.GetRootAsITakePlotPhoto(_bb, default(ITakePlotPhoto));
		}

		// Token: 0x0603407C RID: 213116 RVA: 0x006FEF0C File Offset: 0x006FD10C
		public static ITakePlotPhoto GetRootAsITakePlotPhoto(ByteBuffer _bb, ITakePlotPhoto obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603407D RID: 213117 RVA: 0x006FEF29 File Offset: 0x006FD129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603407E RID: 213118 RVA: 0x006FEF38 File Offset: 0x006FD138
		public ITakePlotPhoto __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603407F RID: 213119 RVA: 0x006FEF48 File Offset: 0x006FD148
		public static void StartITakePlotPhoto(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06034080 RID: 213120 RVA: 0x006FEF51 File Offset: 0x006FD151
		public static Offset<ITakePlotPhoto> EndITakePlotPhoto(FlatBufferBuilder builder)
		{
			return new Offset<ITakePlotPhoto>(builder.EndTable());
		}

		// Token: 0x06034081 RID: 213121 RVA: 0x006FEF60 File Offset: 0x006FD160
		public ITakePlotPhotoT UnPack()
		{
			ITakePlotPhotoT takePlotPhotoT = new ITakePlotPhotoT();
			this.UnPackTo(takePlotPhotoT);
			return takePlotPhotoT;
		}

		// Token: 0x06034082 RID: 213122 RVA: 0x006FEF7B File Offset: 0x006FD17B
		public void UnPackTo(ITakePlotPhotoT _o)
		{
		}

		// Token: 0x06034083 RID: 213123 RVA: 0x006FEF80 File Offset: 0x006FD180
		public static Offset<ITakePlotPhoto> Pack(FlatBufferBuilder builder, ITakePlotPhotoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePlotPhoto>);
			}
			ITakePlotPhoto.StartITakePlotPhoto(builder);
			return ITakePlotPhoto.EndITakePlotPhoto(builder);
		}

		// Token: 0x04011D9C RID: 73116
		private Table __p;
	}
}
