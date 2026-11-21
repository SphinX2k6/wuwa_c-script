using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DD6 RID: 32214
	public struct IVisualNovelPortraitTransform : IFlatbufferObject
	{
		// Token: 0x1700F151 RID: 61777
		// (get) Token: 0x0603A36D RID: 238445 RVA: 0x007D896A File Offset: 0x007D6B6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A36E RID: 238446 RVA: 0x007D8977 File Offset: 0x007D6B77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A36F RID: 238447 RVA: 0x007D8980 File Offset: 0x007D6B80
		public static IVisualNovelPortraitTransform GetRootAsIVisualNovelPortraitTransform(ByteBuffer _bb)
		{
			return IVisualNovelPortraitTransform.GetRootAsIVisualNovelPortraitTransform(_bb, default(IVisualNovelPortraitTransform));
		}

		// Token: 0x0603A370 RID: 238448 RVA: 0x007D899C File Offset: 0x007D6B9C
		public static IVisualNovelPortraitTransform GetRootAsIVisualNovelPortraitTransform(ByteBuffer _bb, IVisualNovelPortraitTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A371 RID: 238449 RVA: 0x007D89B9 File Offset: 0x007D6BB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A372 RID: 238450 RVA: 0x007D89C8 File Offset: 0x007D6BC8
		public IVisualNovelPortraitTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F152 RID: 61778
		// (get) Token: 0x0603A373 RID: 238451 RVA: 0x007D89D8 File Offset: 0x007D6BD8
		public int PosX
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F153 RID: 61779
		// (get) Token: 0x0603A374 RID: 238452 RVA: 0x007D8A14 File Offset: 0x007D6C14
		public int PosY
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

		// Token: 0x1700F154 RID: 61780
		// (get) Token: 0x0603A375 RID: 238453 RVA: 0x007D8A50 File Offset: 0x007D6C50
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F155 RID: 61781
		// (get) Token: 0x0603A376 RID: 238454 RVA: 0x007D8A90 File Offset: 0x007D6C90
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603A377 RID: 238455 RVA: 0x007D8ACD File Offset: 0x007D6CCD
		public static Offset<IVisualNovelPortraitTransform> CreateIVisualNovelPortraitTransform(FlatBufferBuilder builder, int PosX = 0, int PosY = 0, float Scale = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPortraitTransform.AddScale(builder, Scale);
			IVisualNovelPortraitTransform.AddPosY(builder, PosY);
			IVisualNovelPortraitTransform.AddPosX(builder, PosX);
			IVisualNovelPortraitTransform.AddNullMask(builder, NullMask);
			return IVisualNovelPortraitTransform.EndIVisualNovelPortraitTransform(builder);
		}

		// Token: 0x0603A378 RID: 238456 RVA: 0x007D8AF9 File Offset: 0x007D6CF9
		public static void StartIVisualNovelPortraitTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0603A379 RID: 238457 RVA: 0x007D8B02 File Offset: 0x007D6D02
		public static void AddPosX(FlatBufferBuilder builder, int posX)
		{
			builder.AddInt(0, posX, 0);
		}

		// Token: 0x0603A37A RID: 238458 RVA: 0x007D8B0D File Offset: 0x007D6D0D
		public static void AddPosY(FlatBufferBuilder builder, int posY)
		{
			builder.AddInt(1, posY, 0);
		}

		// Token: 0x0603A37B RID: 238459 RVA: 0x007D8B18 File Offset: 0x007D6D18
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(2, scale, 0.0);
		}

		// Token: 0x0603A37C RID: 238460 RVA: 0x007D8B2B File Offset: 0x007D6D2B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0603A37D RID: 238461 RVA: 0x007D8B36 File Offset: 0x007D6D36
		public static Offset<IVisualNovelPortraitTransform> EndIVisualNovelPortraitTransform(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPortraitTransform>(builder.EndTable());
		}

		// Token: 0x0603A37E RID: 238462 RVA: 0x007D8B44 File Offset: 0x007D6D44
		public IVisualNovelPortraitTransformT UnPack()
		{
			IVisualNovelPortraitTransformT visualNovelPortraitTransformT = new IVisualNovelPortraitTransformT();
			this.UnPackTo(visualNovelPortraitTransformT);
			return visualNovelPortraitTransformT;
		}

		// Token: 0x0603A37F RID: 238463 RVA: 0x007D8B5F File Offset: 0x007D6D5F
		public void UnPackTo(IVisualNovelPortraitTransformT _o)
		{
			_o.PosX = this.PosX;
			_o.PosY = this.PosY;
			_o.Scale = this.Scale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A380 RID: 238464 RVA: 0x007D8B94 File Offset: 0x007D6D94
		public static Offset<IVisualNovelPortraitTransform> Pack(FlatBufferBuilder builder, IVisualNovelPortraitTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPortraitTransform>);
			}
			return IVisualNovelPortraitTransform.CreateIVisualNovelPortraitTransform(builder, _o.PosX, _o.PosY, _o.Scale, _o.NullMask);
		}

		// Token: 0x0401356D RID: 79213
		private Table __p;
	}
}
