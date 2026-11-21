using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD3 RID: 28115
	public struct IFaceExpressionTextureConfig : IFlatbufferObject
	{
		// Token: 0x1700CE13 RID: 52755
		// (get) Token: 0x06030877 RID: 198775 RVA: 0x006973ED File Offset: 0x006955ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030878 RID: 198776 RVA: 0x006973FA File Offset: 0x006955FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030879 RID: 198777 RVA: 0x00697404 File Offset: 0x00695604
		public static IFaceExpressionTextureConfig GetRootAsIFaceExpressionTextureConfig(ByteBuffer _bb)
		{
			return IFaceExpressionTextureConfig.GetRootAsIFaceExpressionTextureConfig(_bb, default(IFaceExpressionTextureConfig));
		}

		// Token: 0x0603087A RID: 198778 RVA: 0x00697420 File Offset: 0x00695620
		public static IFaceExpressionTextureConfig GetRootAsIFaceExpressionTextureConfig(ByteBuffer _bb, IFaceExpressionTextureConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603087B RID: 198779 RVA: 0x0069743D File Offset: 0x0069563D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603087C RID: 198780 RVA: 0x0069744C File Offset: 0x0069564C
		public IFaceExpressionTextureConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE14 RID: 52756
		// (get) Token: 0x0603087D RID: 198781 RVA: 0x0069745C File Offset: 0x0069565C
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

		// Token: 0x1700CE15 RID: 52757
		// (get) Token: 0x0603087E RID: 198782 RVA: 0x00697498 File Offset: 0x00695698
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

		// Token: 0x0603087F RID: 198783 RVA: 0x006974D4 File Offset: 0x006956D4
		public static Offset<IFaceExpressionTextureConfig> CreateIFaceExpressionTextureConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph, int FaceIndex = 0)
		{
			builder.StartTable(2);
			IFaceExpressionTextureConfig.AddFaceIndex(builder, FaceIndex);
			IFaceExpressionTextureConfig.AddType(builder, Type);
			return IFaceExpressionTextureConfig.EndIFaceExpressionTextureConfig(builder);
		}

		// Token: 0x06030880 RID: 198784 RVA: 0x006974F1 File Offset: 0x006956F1
		public static void StartIFaceExpressionTextureConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030881 RID: 198785 RVA: 0x006974FA File Offset: 0x006956FA
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030882 RID: 198786 RVA: 0x00697505 File Offset: 0x00695705
		public static void AddFaceIndex(FlatBufferBuilder builder, int faceIndex)
		{
			builder.AddInt(1, faceIndex, 0);
		}

		// Token: 0x06030883 RID: 198787 RVA: 0x00697510 File Offset: 0x00695710
		public static Offset<IFaceExpressionTextureConfig> EndIFaceExpressionTextureConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionTextureConfig>(builder.EndTable());
		}

		// Token: 0x06030884 RID: 198788 RVA: 0x00697520 File Offset: 0x00695720
		public IFaceExpressionTextureConfigT UnPack()
		{
			IFaceExpressionTextureConfigT faceExpressionTextureConfigT = new IFaceExpressionTextureConfigT();
			this.UnPackTo(faceExpressionTextureConfigT);
			return faceExpressionTextureConfigT;
		}

		// Token: 0x06030885 RID: 198789 RVA: 0x0069753B File Offset: 0x0069573B
		public void UnPackTo(IFaceExpressionTextureConfigT _o)
		{
			_o.Type = this.Type;
			_o.FaceIndex = this.FaceIndex;
		}

		// Token: 0x06030886 RID: 198790 RVA: 0x00697558 File Offset: 0x00695758
		public static Offset<IFaceExpressionTextureConfig> Pack(FlatBufferBuilder builder, IFaceExpressionTextureConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionTextureConfig>);
			}
			return IFaceExpressionTextureConfig.CreateIFaceExpressionTextureConfig(builder, _o.Type, _o.FaceIndex);
		}

		// Token: 0x04011C77 RID: 72823
		private Table __p;
	}
}
