using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD6 RID: 28118
	public struct IFaceExpressionTextureMultiSlotConfig : IFlatbufferObject
	{
		// Token: 0x1700CE18 RID: 52760
		// (get) Token: 0x0603088D RID: 198797 RVA: 0x006975EE File Offset: 0x006957EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603088E RID: 198798 RVA: 0x006975FB File Offset: 0x006957FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603088F RID: 198799 RVA: 0x00697604 File Offset: 0x00695804
		public static IFaceExpressionTextureMultiSlotConfig GetRootAsIFaceExpressionTextureMultiSlotConfig(ByteBuffer _bb)
		{
			return IFaceExpressionTextureMultiSlotConfig.GetRootAsIFaceExpressionTextureMultiSlotConfig(_bb, default(IFaceExpressionTextureMultiSlotConfig));
		}

		// Token: 0x06030890 RID: 198800 RVA: 0x00697620 File Offset: 0x00695820
		public static IFaceExpressionTextureMultiSlotConfig GetRootAsIFaceExpressionTextureMultiSlotConfig(ByteBuffer _bb, IFaceExpressionTextureMultiSlotConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030891 RID: 198801 RVA: 0x0069763D File Offset: 0x0069583D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030892 RID: 198802 RVA: 0x0069764C File Offset: 0x0069584C
		public IFaceExpressionTextureMultiSlotConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE19 RID: 52761
		// (get) Token: 0x06030893 RID: 198803 RVA: 0x0069765C File Offset: 0x0069585C
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

		// Token: 0x1700CE1A RID: 52762
		// (get) Token: 0x06030894 RID: 198804 RVA: 0x00697698 File Offset: 0x00695898
		public int SlotIndex
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

		// Token: 0x1700CE1B RID: 52763
		// (get) Token: 0x06030895 RID: 198805 RVA: 0x006976D4 File Offset: 0x006958D4
		public int FaceIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030896 RID: 198806 RVA: 0x00697710 File Offset: 0x00695910
		public static Offset<IFaceExpressionTextureMultiSlotConfig> CreateIFaceExpressionTextureMultiSlotConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph, int SlotIndex = 0, int FaceIndex = 0)
		{
			builder.StartTable(3);
			IFaceExpressionTextureMultiSlotConfig.AddFaceIndex(builder, FaceIndex);
			IFaceExpressionTextureMultiSlotConfig.AddSlotIndex(builder, SlotIndex);
			IFaceExpressionTextureMultiSlotConfig.AddType(builder, Type);
			return IFaceExpressionTextureMultiSlotConfig.EndIFaceExpressionTextureMultiSlotConfig(builder);
		}

		// Token: 0x06030897 RID: 198807 RVA: 0x00697734 File Offset: 0x00695934
		public static void StartIFaceExpressionTextureMultiSlotConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030898 RID: 198808 RVA: 0x0069773D File Offset: 0x0069593D
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030899 RID: 198809 RVA: 0x00697748 File Offset: 0x00695948
		public static void AddSlotIndex(FlatBufferBuilder builder, int slotIndex)
		{
			builder.AddInt(1, slotIndex, 0);
		}

		// Token: 0x0603089A RID: 198810 RVA: 0x00697753 File Offset: 0x00695953
		public static void AddFaceIndex(FlatBufferBuilder builder, int faceIndex)
		{
			builder.AddInt(2, faceIndex, 0);
		}

		// Token: 0x0603089B RID: 198811 RVA: 0x0069775E File Offset: 0x0069595E
		public static Offset<IFaceExpressionTextureMultiSlotConfig> EndIFaceExpressionTextureMultiSlotConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionTextureMultiSlotConfig>(builder.EndTable());
		}

		// Token: 0x0603089C RID: 198812 RVA: 0x0069776C File Offset: 0x0069596C
		public IFaceExpressionTextureMultiSlotConfigT UnPack()
		{
			IFaceExpressionTextureMultiSlotConfigT faceExpressionTextureMultiSlotConfigT = new IFaceExpressionTextureMultiSlotConfigT();
			this.UnPackTo(faceExpressionTextureMultiSlotConfigT);
			return faceExpressionTextureMultiSlotConfigT;
		}

		// Token: 0x0603089D RID: 198813 RVA: 0x00697787 File Offset: 0x00695987
		public void UnPackTo(IFaceExpressionTextureMultiSlotConfigT _o)
		{
			_o.Type = this.Type;
			_o.SlotIndex = this.SlotIndex;
			_o.FaceIndex = this.FaceIndex;
		}

		// Token: 0x0603089E RID: 198814 RVA: 0x006977B0 File Offset: 0x006959B0
		public static Offset<IFaceExpressionTextureMultiSlotConfig> Pack(FlatBufferBuilder builder, IFaceExpressionTextureMultiSlotConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionTextureMultiSlotConfig>);
			}
			return IFaceExpressionTextureMultiSlotConfig.CreateIFaceExpressionTextureMultiSlotConfig(builder, _o.Type, _o.SlotIndex, _o.FaceIndex);
		}

		// Token: 0x04011C7A RID: 72826
		private Table __p;
	}
}
