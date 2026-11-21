using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D64 RID: 32100
	public struct IVisualNovelCgLoadImage : IFlatbufferObject
	{
		// Token: 0x1700F025 RID: 61477
		// (get) Token: 0x06039F0C RID: 237324 RVA: 0x007D036D File Offset: 0x007CE56D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039F0D RID: 237325 RVA: 0x007D037A File Offset: 0x007CE57A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039F0E RID: 237326 RVA: 0x007D0384 File Offset: 0x007CE584
		public static IVisualNovelCgLoadImage GetRootAsIVisualNovelCgLoadImage(ByteBuffer _bb)
		{
			return IVisualNovelCgLoadImage.GetRootAsIVisualNovelCgLoadImage(_bb, default(IVisualNovelCgLoadImage));
		}

		// Token: 0x06039F0F RID: 237327 RVA: 0x007D03A0 File Offset: 0x007CE5A0
		public static IVisualNovelCgLoadImage GetRootAsIVisualNovelCgLoadImage(ByteBuffer _bb, IVisualNovelCgLoadImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039F10 RID: 237328 RVA: 0x007D03BD File Offset: 0x007CE5BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039F11 RID: 237329 RVA: 0x007D03CC File Offset: 0x007CE5CC
		public IVisualNovelCgLoadImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F026 RID: 61478
		// (get) Token: 0x06039F12 RID: 237330 RVA: 0x007D03DC File Offset: 0x007CE5DC
		public EVisualNovelCgType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelCgType.LoadPrefab;
				}
				return (EVisualNovelCgType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F027 RID: 61479
		// (get) Token: 0x06039F13 RID: 237331 RVA: 0x007D0418 File Offset: 0x007CE618
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

		// Token: 0x06039F14 RID: 237332 RVA: 0x007D0454 File Offset: 0x007CE654
		public static Offset<IVisualNovelCgLoadImage> CreateIVisualNovelCgLoadImage(FlatBufferBuilder builder, EVisualNovelCgType Type = EVisualNovelCgType.LoadPrefab, int ImageId = 0)
		{
			builder.StartTable(2);
			IVisualNovelCgLoadImage.AddImageId(builder, ImageId);
			IVisualNovelCgLoadImage.AddType(builder, Type);
			return IVisualNovelCgLoadImage.EndIVisualNovelCgLoadImage(builder);
		}

		// Token: 0x06039F15 RID: 237333 RVA: 0x007D0471 File Offset: 0x007CE671
		public static void StartIVisualNovelCgLoadImage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039F16 RID: 237334 RVA: 0x007D047A File Offset: 0x007CE67A
		public static void AddType(FlatBufferBuilder builder, EVisualNovelCgType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039F17 RID: 237335 RVA: 0x007D0485 File Offset: 0x007CE685
		public static void AddImageId(FlatBufferBuilder builder, int imageId)
		{
			builder.AddInt(1, imageId, 0);
		}

		// Token: 0x06039F18 RID: 237336 RVA: 0x007D0490 File Offset: 0x007CE690
		public static Offset<IVisualNovelCgLoadImage> EndIVisualNovelCgLoadImage(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelCgLoadImage>(builder.EndTable());
		}

		// Token: 0x06039F19 RID: 237337 RVA: 0x007D04A0 File Offset: 0x007CE6A0
		public IVisualNovelCgLoadImageT UnPack()
		{
			IVisualNovelCgLoadImageT visualNovelCgLoadImageT = new IVisualNovelCgLoadImageT();
			this.UnPackTo(visualNovelCgLoadImageT);
			return visualNovelCgLoadImageT;
		}

		// Token: 0x06039F1A RID: 237338 RVA: 0x007D04BB File Offset: 0x007CE6BB
		public void UnPackTo(IVisualNovelCgLoadImageT _o)
		{
			_o.Type = this.Type;
			_o.ImageId = this.ImageId;
		}

		// Token: 0x06039F1B RID: 237339 RVA: 0x007D04D8 File Offset: 0x007CE6D8
		public static Offset<IVisualNovelCgLoadImage> Pack(FlatBufferBuilder builder, IVisualNovelCgLoadImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelCgLoadImage>);
			}
			return IVisualNovelCgLoadImage.CreateIVisualNovelCgLoadImage(builder, _o.Type, _o.ImageId);
		}

		// Token: 0x0401349E RID: 79006
		private Table __p;
	}
}
