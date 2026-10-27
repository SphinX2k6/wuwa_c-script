using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D1 RID: 30161
	public struct IVisualNovelPortraitTransform : IFlatbufferObject
	{
		// Token: 0x1700E51F RID: 58655
		// (get) Token: 0x06036F02 RID: 225026 RVA: 0x00774DAE File Offset: 0x00772FAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F03 RID: 225027 RVA: 0x00774DBB File Offset: 0x00772FBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F04 RID: 225028 RVA: 0x00774DC4 File Offset: 0x00772FC4
		public static IVisualNovelPortraitTransform GetRootAsIVisualNovelPortraitTransform(ByteBuffer _bb)
		{
			return IVisualNovelPortraitTransform.GetRootAsIVisualNovelPortraitTransform(_bb, default(IVisualNovelPortraitTransform));
		}

		// Token: 0x06036F05 RID: 225029 RVA: 0x00774DE0 File Offset: 0x00772FE0
		public static IVisualNovelPortraitTransform GetRootAsIVisualNovelPortraitTransform(ByteBuffer _bb, IVisualNovelPortraitTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F06 RID: 225030 RVA: 0x00774DFD File Offset: 0x00772FFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F07 RID: 225031 RVA: 0x00774E0C File Offset: 0x0077300C
		public IVisualNovelPortraitTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E520 RID: 58656
		// (get) Token: 0x06036F08 RID: 225032 RVA: 0x00774E1C File Offset: 0x0077301C
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

		// Token: 0x1700E521 RID: 58657
		// (get) Token: 0x06036F09 RID: 225033 RVA: 0x00774E58 File Offset: 0x00773058
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

		// Token: 0x1700E522 RID: 58658
		// (get) Token: 0x06036F0A RID: 225034 RVA: 0x00774E94 File Offset: 0x00773094
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

		// Token: 0x1700E523 RID: 58659
		// (get) Token: 0x06036F0B RID: 225035 RVA: 0x00774ED4 File Offset: 0x007730D4
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

		// Token: 0x06036F0C RID: 225036 RVA: 0x00774F11 File Offset: 0x00773111
		public static Offset<IVisualNovelPortraitTransform> CreateIVisualNovelPortraitTransform(FlatBufferBuilder builder, int PosX = 0, int PosY = 0, float Scale = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVisualNovelPortraitTransform.AddScale(builder, Scale);
			IVisualNovelPortraitTransform.AddPosY(builder, PosY);
			IVisualNovelPortraitTransform.AddPosX(builder, PosX);
			IVisualNovelPortraitTransform.AddNullMask(builder, NullMask);
			return IVisualNovelPortraitTransform.EndIVisualNovelPortraitTransform(builder);
		}

		// Token: 0x06036F0D RID: 225037 RVA: 0x00774F3D File Offset: 0x0077313D
		public static void StartIVisualNovelPortraitTransform(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036F0E RID: 225038 RVA: 0x00774F46 File Offset: 0x00773146
		public static void AddPosX(FlatBufferBuilder builder, int posX)
		{
			builder.AddInt(0, posX, 0);
		}

		// Token: 0x06036F0F RID: 225039 RVA: 0x00774F51 File Offset: 0x00773151
		public static void AddPosY(FlatBufferBuilder builder, int posY)
		{
			builder.AddInt(1, posY, 0);
		}

		// Token: 0x06036F10 RID: 225040 RVA: 0x00774F5C File Offset: 0x0077315C
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(2, scale, 0.0);
		}

		// Token: 0x06036F11 RID: 225041 RVA: 0x00774F6F File Offset: 0x0077316F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036F12 RID: 225042 RVA: 0x00774F7A File Offset: 0x0077317A
		public static Offset<IVisualNovelPortraitTransform> EndIVisualNovelPortraitTransform(FlatBufferBuilder builder)
		{
			return new Offset<IVisualNovelPortraitTransform>(builder.EndTable());
		}

		// Token: 0x06036F13 RID: 225043 RVA: 0x00774F88 File Offset: 0x00773188
		public IVisualNovelPortraitTransformT UnPack()
		{
			IVisualNovelPortraitTransformT visualNovelPortraitTransformT = new IVisualNovelPortraitTransformT();
			this.UnPackTo(visualNovelPortraitTransformT);
			return visualNovelPortraitTransformT;
		}

		// Token: 0x06036F14 RID: 225044 RVA: 0x00774FA3 File Offset: 0x007731A3
		public void UnPackTo(IVisualNovelPortraitTransformT _o)
		{
			_o.PosX = this.PosX;
			_o.PosY = this.PosY;
			_o.Scale = this.Scale;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036F15 RID: 225045 RVA: 0x00774FD8 File Offset: 0x007731D8
		public static Offset<IVisualNovelPortraitTransform> Pack(FlatBufferBuilder builder, IVisualNovelPortraitTransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVisualNovelPortraitTransform>);
			}
			return IVisualNovelPortraitTransform.CreateIVisualNovelPortraitTransform(builder, _o.PosX, _o.PosY, _o.Scale, _o.NullMask);
		}

		// Token: 0x0401252F RID: 75055
		private Table __p;
	}
}
