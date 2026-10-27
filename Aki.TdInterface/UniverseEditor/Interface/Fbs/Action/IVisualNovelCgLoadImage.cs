using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756E RID: 30062
	public struct IVisualNovelCgLoadImage : IFlatbufferObject
	{
		// Token: 0x1700E3FB RID: 58363
		// (get) Token: 0x06036AF6 RID: 223990 RVA: 0x0076D0C5 File Offset: 0x0076B2C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036AF7 RID: 223991 RVA: 0x0076D0D2 File Offset: 0x0076B2D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036AF8 RID: 223992 RVA: 0x0076D0DC File Offset: 0x0076B2DC
		public static IVisualNovelCgLoadImage GetRootAsIVisualNovelCgLoadImage(ByteBuffer _bb)
		{
			return IVisualNovelCgLoadImage.GetRootAsIVisualNovelCgLoadImage(_bb, default(IVisualNovelCgLoadImage));
		}

		// Token: 0x06036AF9 RID: 223993 RVA: 0x0076D0F8 File Offset: 0x0076B2F8
		public static IVisualNovelCgLoadImage GetRootAsIVisualNovelCgLoadImage(ByteBuffer _bb, IVisualNovelCgLoadImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036AFA RID: 223994 RVA: 0x0076D115 File Offset: 0x0076B315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036AFB RID: 223995 RVA: 0x0076D124 File Offset: 0x0076B324
		public IVisualNovelCgLoadImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3FC RID: 58364
		// (get) Token: 0x06036AFC RID: 223996 RVA: 0x0076D134 File Offset: 0x0076B334
		public EVisualNovelCgType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelCgType.LoadSpine;
				}
				return (EVisualNovelCgType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E3FD RID: 58365
		// (get) Token: 0x06036AFD RID: 223997 RVA: 0x0076D170 File Offset: 0x0076B370
		public int ImageId
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

		// Token: 0x06036AFE RID: 223998 RVA: 0x0076D1AC File Offset: 0x0076B3AC
		public static Offset<IVisualNovelCgLoadImage> CreateIVisualNovelCgLoadImage(FlatBufferBuilder builder, EVisualNovelCgType Type = EVisualNovelCgType.LoadSpine, int ImageId = 0)
		{
			builder.StartTable(2);
			IVisualNovelCgLoadImage.AddImageId(builder, ImageId);
			IVisualNovelCgLoadImage.AddType(builder, Type);
			return IVisualNovelCgLoadImage.EndIVisualNovelCgLoadImage(builder);
		}

		// Token: 0x06036AFF RID: 223999 RVA: 0x0076D1C9 File Offset: 0x0076B3C9
		public static void StartIVisualNovelCgLoadImage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036B00 RID: 224000 RVA: 0x0076D1D2 File Offset: 0x0076B3D2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelCgType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036B01 RID: 224001 RVA: 0x0076D1DD File Offset: 0x0076B3DD
		public static void AddImageId(FlatBufferBuilder builder, int imageId)
		{
			builder.AddInt(1, imageId, 0);
		}

		// Token: 0x06036B02 RID: 224002 RVA: 0x0076D1E8 File Offset: 0x0076B3E8
		public static Offset<IVisualNovelCgLoadImage> EndIVisualNovelCgLoadImage(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelCgLoadImage>(builder.EndTable());
		}

		// Token: 0x06036B03 RID: 224003 RVA: 0x0076D1F8 File Offset: 0x0076B3F8
		public IVisualNovelCgLoadImageT UnPack()
		{
			IVisualNovelCgLoadImageT visualNovelCgLoadImageT = new IVisualNovelCgLoadImageT();
			this.UnPackTo(visualNovelCgLoadImageT);
			return visualNovelCgLoadImageT;
		}

		// Token: 0x06036B04 RID: 224004 RVA: 0x0076D213 File Offset: 0x0076B413
		public void UnPackTo(IVisualNovelCgLoadImageT _o)
		{
			_o.Type = this.Type;
			_o.ImageId = this.ImageId;
		}

		// Token: 0x06036B05 RID: 224005 RVA: 0x0076D230 File Offset: 0x0076B430
		public static Offset<IVisualNovelCgLoadImage> Pack(FlatBufferBuilder builder, IVisualNovelCgLoadImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelCgLoadImage>);
			}
			return IVisualNovelCgLoadImage.CreateIVisualNovelCgLoadImage(builder, _o.Type, _o.ImageId);
		}

		// Token: 0x0401246D RID: 74861
		private Table __p;
	}
}
