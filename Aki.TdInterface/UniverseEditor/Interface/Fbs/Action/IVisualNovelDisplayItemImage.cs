using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D79 RID: 32121
	public struct IVisualNovelDisplayItemImage : IFlatbufferObject
	{
		// Token: 0x1700F051 RID: 61521
		// (get) Token: 0x06039FC0 RID: 237504 RVA: 0x007D1679 File Offset: 0x007CF879
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039FC1 RID: 237505 RVA: 0x007D1686 File Offset: 0x007CF886
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039FC2 RID: 237506 RVA: 0x007D1690 File Offset: 0x007CF890
		public static IVisualNovelDisplayItemImage GetRootAsIVisualNovelDisplayItemImage(ByteBuffer _bb)
		{
			return IVisualNovelDisplayItemImage.GetRootAsIVisualNovelDisplayItemImage(_bb, default(IVisualNovelDisplayItemImage));
		}

		// Token: 0x06039FC3 RID: 237507 RVA: 0x007D16AC File Offset: 0x007CF8AC
		public static IVisualNovelDisplayItemImage GetRootAsIVisualNovelDisplayItemImage(ByteBuffer _bb, IVisualNovelDisplayItemImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039FC4 RID: 237508 RVA: 0x007D16C9 File Offset: 0x007CF8C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039FC5 RID: 237509 RVA: 0x007D16D8 File Offset: 0x007CF8D8
		public IVisualNovelDisplayItemImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F052 RID: 61522
		// (get) Token: 0x06039FC6 RID: 237510 RVA: 0x007D16E8 File Offset: 0x007CF8E8
		public EVisualNovelDisplayItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisualNovelDisplayItemType.Image;
				}
				return (EVisualNovelDisplayItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F053 RID: 61523
		// (get) Token: 0x06039FC7 RID: 237511 RVA: 0x007D1724 File Offset: 0x007CF924
		public int DisplayImageId
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

		// Token: 0x06039FC8 RID: 237512 RVA: 0x007D1760 File Offset: 0x007CF960
		public static Offset<IVisualNovelDisplayItemImage> CreateIVisualNovelDisplayItemImage(FlatBufferBuilder builder, EVisualNovelDisplayItemType Type = EVisualNovelDisplayItemType.Image, int DisplayImageId = 0)
		{
			builder.StartTable(2);
			IVisualNovelDisplayItemImage.AddDisplayImageId(builder, DisplayImageId);
			IVisualNovelDisplayItemImage.AddType(builder, Type);
			return IVisualNovelDisplayItemImage.EndIVisualNovelDisplayItemImage(builder);
		}

		// Token: 0x06039FC9 RID: 237513 RVA: 0x007D177D File Offset: 0x007CF97D
		public static void StartIVisualNovelDisplayItemImage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039FCA RID: 237514 RVA: 0x007D1786 File Offset: 0x007CF986
		public static void AddType(FlatBufferBuilder builder, EVisualNovelDisplayItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039FCB RID: 237515 RVA: 0x007D1791 File Offset: 0x007CF991
		public static void AddDisplayImageId(FlatBufferBuilder builder, int displayImageId)
		{
			builder.AddInt(1, displayImageId, 0);
		}

		// Token: 0x06039FCC RID: 237516 RVA: 0x007D179C File Offset: 0x007CF99C
		public static Offset<IVisualNovelDisplayItemImage> EndIVisualNovelDisplayItemImage(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDisplayItemImage>(builder.EndTable());
		}

		// Token: 0x06039FCD RID: 237517 RVA: 0x007D17AC File Offset: 0x007CF9AC
		public IVisualNovelDisplayItemImageT UnPack()
		{
			IVisualNovelDisplayItemImageT visualNovelDisplayItemImageT = new IVisualNovelDisplayItemImageT();
			this.UnPackTo(visualNovelDisplayItemImageT);
			return visualNovelDisplayItemImageT;
		}

		// Token: 0x06039FCE RID: 237518 RVA: 0x007D17C7 File Offset: 0x007CF9C7
		public void UnPackTo(IVisualNovelDisplayItemImageT _o)
		{
			_o.Type = this.Type;
			_o.DisplayImageId = this.DisplayImageId;
		}

		// Token: 0x06039FCF RID: 237519 RVA: 0x007D17E4 File Offset: 0x007CF9E4
		public static Offset<IVisualNovelDisplayItemImage> Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDisplayItemImage>);
			}
			return IVisualNovelDisplayItemImage.CreateIVisualNovelDisplayItemImage(builder, _o.Type, _o.DisplayImageId);
		}

		// Token: 0x040134BE RID: 79038
		private Table __p;
	}
}
