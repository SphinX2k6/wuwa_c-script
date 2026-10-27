using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006753 RID: 26451
	public struct IFaceExpressionTextureConfig : IFlatbufferObject
	{
		// Token: 0x1700C45D RID: 50269
		// (get) Token: 0x0602E031 RID: 188465 RVA: 0x00649CA9 File Offset: 0x00647EA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E032 RID: 188466 RVA: 0x00649CB6 File Offset: 0x00647EB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E033 RID: 188467 RVA: 0x00649CC0 File Offset: 0x00647EC0
		public static IFaceExpressionTextureConfig GetRootAsIFaceExpressionTextureConfig(ByteBuffer _bb)
		{
			return IFaceExpressionTextureConfig.GetRootAsIFaceExpressionTextureConfig(_bb, default(IFaceExpressionTextureConfig));
		}

		// Token: 0x0602E034 RID: 188468 RVA: 0x00649CDC File Offset: 0x00647EDC
		public static IFaceExpressionTextureConfig GetRootAsIFaceExpressionTextureConfig(ByteBuffer _bb, IFaceExpressionTextureConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E035 RID: 188469 RVA: 0x00649CF9 File Offset: 0x00647EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E036 RID: 188470 RVA: 0x00649D08 File Offset: 0x00647F08
		public IFaceExpressionTextureConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C45E RID: 50270
		// (get) Token: 0x0602E037 RID: 188471 RVA: 0x00649D18 File Offset: 0x00647F18
		public EFaceExpressionConfigType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFaceExpressionConfigType.Morph;
				}
				return (EFaceExpressionConfigType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C45F RID: 50271
		// (get) Token: 0x0602E038 RID: 188472 RVA: 0x00649D54 File Offset: 0x00647F54
		public int FaceIndex
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

		// Token: 0x0602E039 RID: 188473 RVA: 0x00649D90 File Offset: 0x00647F90
		public static Offset<IFaceExpressionTextureConfig> CreateIFaceExpressionTextureConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph, int FaceIndex = 0)
		{
			builder.StartTable(2);
			IFaceExpressionTextureConfig.AddFaceIndex(builder, FaceIndex);
			IFaceExpressionTextureConfig.AddType(builder, Type);
			return IFaceExpressionTextureConfig.EndIFaceExpressionTextureConfig(builder);
		}

		// Token: 0x0602E03A RID: 188474 RVA: 0x00649DAD File Offset: 0x00647FAD
		public static void StartIFaceExpressionTextureConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E03B RID: 188475 RVA: 0x00649DB6 File Offset: 0x00647FB6
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E03C RID: 188476 RVA: 0x00649DC1 File Offset: 0x00647FC1
		public static void AddFaceIndex(FlatBufferBuilder builder, int faceIndex)
		{
			builder.AddInt(1, faceIndex, 0);
		}

		// Token: 0x0602E03D RID: 188477 RVA: 0x00649DCC File Offset: 0x00647FCC
		public static Offset<IFaceExpressionTextureConfig> EndIFaceExpressionTextureConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionTextureConfig>(builder.EndTable());
		}

		// Token: 0x0602E03E RID: 188478 RVA: 0x00649DDC File Offset: 0x00647FDC
		public IFaceExpressionTextureConfigT UnPack()
		{
			IFaceExpressionTextureConfigT faceExpressionTextureConfigT = new IFaceExpressionTextureConfigT();
			this.UnPackTo(faceExpressionTextureConfigT);
			return faceExpressionTextureConfigT;
		}

		// Token: 0x0602E03F RID: 188479 RVA: 0x00649DF7 File Offset: 0x00647FF7
		public void UnPackTo(IFaceExpressionTextureConfigT _o)
		{
			_o.Type = this.Type;
			_o.FaceIndex = this.FaceIndex;
		}

		// Token: 0x0602E040 RID: 188480 RVA: 0x00649E14 File Offset: 0x00648014
		public static Offset<IFaceExpressionTextureConfig> Pack(FlatBufferBuilder builder, IFaceExpressionTextureConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionTextureConfig>);
			}
			return IFaceExpressionTextureConfig.CreateIFaceExpressionTextureConfig(builder, _o.Type, _o.FaceIndex);
		}

		// Token: 0x04010E45 RID: 69189
		private Table __p;
	}
}
