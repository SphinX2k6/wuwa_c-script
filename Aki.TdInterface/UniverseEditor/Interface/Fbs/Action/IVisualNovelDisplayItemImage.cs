using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007583 RID: 30083
	public struct IVisualNovelDisplayItemImage : IFlatbufferObject
	{
		// Token: 0x1700E421 RID: 58401
		// (get) Token: 0x06036B98 RID: 224152 RVA: 0x0076E0D5 File Offset: 0x0076C2D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036B99 RID: 224153 RVA: 0x0076E0E2 File Offset: 0x0076C2E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036B9A RID: 224154 RVA: 0x0076E0EC File Offset: 0x0076C2EC
		public static IVisualNovelDisplayItemImage GetRootAsIVisualNovelDisplayItemImage(ByteBuffer _bb)
		{
			return IVisualNovelDisplayItemImage.GetRootAsIVisualNovelDisplayItemImage(_bb, default(IVisualNovelDisplayItemImage));
		}

		// Token: 0x06036B9B RID: 224155 RVA: 0x0076E108 File Offset: 0x0076C308
		public static IVisualNovelDisplayItemImage GetRootAsIVisualNovelDisplayItemImage(ByteBuffer _bb, IVisualNovelDisplayItemImage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036B9C RID: 224156 RVA: 0x0076E125 File Offset: 0x0076C325
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036B9D RID: 224157 RVA: 0x0076E134 File Offset: 0x0076C334
		public IVisualNovelDisplayItemImage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E422 RID: 58402
		// (get) Token: 0x06036B9E RID: 224158 RVA: 0x0076E144 File Offset: 0x0076C344
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

		// Token: 0x1700E423 RID: 58403
		// (get) Token: 0x06036B9F RID: 224159 RVA: 0x0076E180 File Offset: 0x0076C380
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

		// Token: 0x06036BA0 RID: 224160 RVA: 0x0076E1BC File Offset: 0x0076C3BC
		public static Offset<IVisualNovelDisplayItemImage> CreateIVisualNovelDisplayItemImage(FlatBufferBuilder builder, EVisualNovelDisplayItemType Type = EVisualNovelDisplayItemType.Image, int DisplayImageId = 0)
		{
			builder.StartTable(2);
			IVisualNovelDisplayItemImage.AddDisplayImageId(builder, DisplayImageId);
			IVisualNovelDisplayItemImage.AddType(builder, Type);
			return IVisualNovelDisplayItemImage.EndIVisualNovelDisplayItemImage(builder);
		}

		// Token: 0x06036BA1 RID: 224161 RVA: 0x0076E1D9 File Offset: 0x0076C3D9
		public static void StartIVisualNovelDisplayItemImage(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036BA2 RID: 224162 RVA: 0x0076E1E2 File Offset: 0x0076C3E2
		public static void AddType(FlatBufferBuilder builder, EVisualNovelDisplayItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036BA3 RID: 224163 RVA: 0x0076E1ED File Offset: 0x0076C3ED
		public static void AddDisplayImageId(FlatBufferBuilder builder, int displayImageId)
		{
			builder.AddInt(1, displayImageId, 0);
		}

		// Token: 0x06036BA4 RID: 224164 RVA: 0x0076E1F8 File Offset: 0x0076C3F8
		public static Offset<IVisualNovelDisplayItemImage> EndIVisualNovelDisplayItemImage(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelDisplayItemImage>(builder.EndTable());
		}

		// Token: 0x06036BA5 RID: 224165 RVA: 0x0076E208 File Offset: 0x0076C408
		public IVisualNovelDisplayItemImageT UnPack()
		{
			IVisualNovelDisplayItemImageT visualNovelDisplayItemImageT = new IVisualNovelDisplayItemImageT();
			this.UnPackTo(visualNovelDisplayItemImageT);
			return visualNovelDisplayItemImageT;
		}

		// Token: 0x06036BA6 RID: 224166 RVA: 0x0076E223 File Offset: 0x0076C423
		public void UnPackTo(IVisualNovelDisplayItemImageT _o)
		{
			_o.Type = this.Type;
			_o.DisplayImageId = this.DisplayImageId;
		}

		// Token: 0x06036BA7 RID: 224167 RVA: 0x0076E240 File Offset: 0x0076C440
		public static Offset<IVisualNovelDisplayItemImage> Pack(FlatBufferBuilder builder, IVisualNovelDisplayItemImageT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelDisplayItemImage>);
			}
			return IVisualNovelDisplayItemImage.CreateIVisualNovelDisplayItemImage(builder, _o.Type, _o.DisplayImageId);
		}

		// Token: 0x0401248A RID: 74890
		private Table __p;
	}
}
