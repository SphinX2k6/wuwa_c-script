using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCA RID: 28106
	public struct IFaceExpressionConfigData : IFlatbufferObject
	{
		// Token: 0x1700CE01 RID: 52737
		// (get) Token: 0x0603081D RID: 198685 RVA: 0x00696701 File Offset: 0x00694901
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603081E RID: 198686 RVA: 0x0069670E File Offset: 0x0069490E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603081F RID: 198687 RVA: 0x00696718 File Offset: 0x00694918
		public static IFaceExpressionConfigData GetRootAsIFaceExpressionConfigData(ByteBuffer _bb)
		{
			return IFaceExpressionConfigData.GetRootAsIFaceExpressionConfigData(_bb, default(IFaceExpressionConfigData));
		}

		// Token: 0x06030820 RID: 198688 RVA: 0x00696734 File Offset: 0x00694934
		public static IFaceExpressionConfigData GetRootAsIFaceExpressionConfigData(ByteBuffer _bb, IFaceExpressionConfigData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030821 RID: 198689 RVA: 0x00696751 File Offset: 0x00694951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030822 RID: 198690 RVA: 0x00696760 File Offset: 0x00694960
		public IFaceExpressionConfigData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE02 RID: 52738
		// (get) Token: 0x06030823 RID: 198691 RVA: 0x00696770 File Offset: 0x00694970
		public int Id
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

		// Token: 0x1700CE03 RID: 52739
		// (get) Token: 0x06030824 RID: 198692 RVA: 0x006967AC File Offset: 0x006949AC
		public IFaceExpressionConfig_Union FaceExpressionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return IFaceExpressionConfig_Union.NONE;
				}
				return (IFaceExpressionConfig_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030825 RID: 198693 RVA: 0x006967E8 File Offset: 0x006949E8
		public TTable? FaceExpression<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030826 RID: 198694 RVA: 0x0069682C File Offset: 0x00694A2C
		public IFaceExpressionConfig FaceExpressionAsIFaceExpressionConfig()
		{
			return this.FaceExpression<IFaceExpressionConfig>().Value;
		}

		// Token: 0x06030827 RID: 198695 RVA: 0x00696848 File Offset: 0x00694A48
		public IFaceExpressionMorphConfig FaceExpressionAsIFaceExpressionMorphConfig()
		{
			return this.FaceExpression<IFaceExpressionMorphConfig>().Value;
		}

		// Token: 0x06030828 RID: 198696 RVA: 0x00696864 File Offset: 0x00694A64
		public IFaceExpressionTextureConfig FaceExpressionAsIFaceExpressionTextureConfig()
		{
			return this.FaceExpression<IFaceExpressionTextureConfig>().Value;
		}

		// Token: 0x06030829 RID: 198697 RVA: 0x00696880 File Offset: 0x00694A80
		public IFaceExpressionAnimSequenceConfig FaceExpressionAsIFaceExpressionAnimSequenceConfig()
		{
			return this.FaceExpression<IFaceExpressionAnimSequenceConfig>().Value;
		}

		// Token: 0x0603082A RID: 198698 RVA: 0x0069689C File Offset: 0x00694A9C
		public IFaceExpressionTextureMultiSlotConfig FaceExpressionAsIFaceExpressionTextureMultiSlotConfig()
		{
			return this.FaceExpression<IFaceExpressionTextureMultiSlotConfig>().Value;
		}

		// Token: 0x1700CE04 RID: 52740
		// (get) Token: 0x0603082B RID: 198699 RVA: 0x006968B8 File Offset: 0x00694AB8
		public IFaceExpressionConfig_Union MaleVariantType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return IFaceExpressionConfig_Union.NONE;
				}
				return (IFaceExpressionConfig_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603082C RID: 198700 RVA: 0x006968F8 File Offset: 0x00694AF8
		public TTable? MaleVariant<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603082D RID: 198701 RVA: 0x00696940 File Offset: 0x00694B40
		public IFaceExpressionConfig MaleVariantAsIFaceExpressionConfig()
		{
			return this.MaleVariant<IFaceExpressionConfig>().Value;
		}

		// Token: 0x0603082E RID: 198702 RVA: 0x0069695C File Offset: 0x00694B5C
		public IFaceExpressionMorphConfig MaleVariantAsIFaceExpressionMorphConfig()
		{
			return this.MaleVariant<IFaceExpressionMorphConfig>().Value;
		}

		// Token: 0x0603082F RID: 198703 RVA: 0x00696978 File Offset: 0x00694B78
		public IFaceExpressionTextureConfig MaleVariantAsIFaceExpressionTextureConfig()
		{
			return this.MaleVariant<IFaceExpressionTextureConfig>().Value;
		}

		// Token: 0x06030830 RID: 198704 RVA: 0x00696994 File Offset: 0x00694B94
		public IFaceExpressionAnimSequenceConfig MaleVariantAsIFaceExpressionAnimSequenceConfig()
		{
			return this.MaleVariant<IFaceExpressionAnimSequenceConfig>().Value;
		}

		// Token: 0x06030831 RID: 198705 RVA: 0x006969B0 File Offset: 0x00694BB0
		public IFaceExpressionTextureMultiSlotConfig MaleVariantAsIFaceExpressionTextureMultiSlotConfig()
		{
			return this.MaleVariant<IFaceExpressionTextureMultiSlotConfig>().Value;
		}

		// Token: 0x1700CE05 RID: 52741
		// (get) Token: 0x06030832 RID: 198706 RVA: 0x006969CC File Offset: 0x00694BCC
		public bool CloseAutoBlink
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CE06 RID: 52742
		// (get) Token: 0x06030833 RID: 198707 RVA: 0x00696A0C File Offset: 0x00694C0C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030834 RID: 198708 RVA: 0x00696A4C File Offset: 0x00694C4C
		public static Offset<IFaceExpressionConfigData> CreateIFaceExpressionConfigData(FlatBufferBuilder builder, int Id = 0, IFaceExpressionConfig_Union FaceExpression_type = IFaceExpressionConfig_Union.NONE, int FaceExpressionOffset = 0, IFaceExpressionConfig_Union MaleVariant_type = IFaceExpressionConfig_Union.NONE, int MaleVariantOffset = 0, bool CloseAutoBlink = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IFaceExpressionConfigData.AddMaleVariant(builder, MaleVariantOffset);
			IFaceExpressionConfigData.AddFaceExpression(builder, FaceExpressionOffset);
			IFaceExpressionConfigData.AddId(builder, Id);
			IFaceExpressionConfigData.AddNullMask(builder, NullMask);
			IFaceExpressionConfigData.AddCloseAutoBlink(builder, CloseAutoBlink);
			IFaceExpressionConfigData.AddMaleVariantType(builder, MaleVariant_type);
			IFaceExpressionConfigData.AddFaceExpressionType(builder, FaceExpression_type);
			return IFaceExpressionConfigData.EndIFaceExpressionConfigData(builder);
		}

		// Token: 0x06030835 RID: 198709 RVA: 0x00696A9B File Offset: 0x00694C9B
		public static void StartIFaceExpressionConfigData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06030836 RID: 198710 RVA: 0x00696AA4 File Offset: 0x00694CA4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06030837 RID: 198711 RVA: 0x00696AAF File Offset: 0x00694CAF
		public static void AddFaceExpressionType(FlatBufferBuilder builder, IFaceExpressionConfig_Union faceExpressionType)
		{
			builder.AddByte(1, (byte)faceExpressionType, 0);
		}

		// Token: 0x06030838 RID: 198712 RVA: 0x00696ABA File Offset: 0x00694CBA
		public static void AddFaceExpression(FlatBufferBuilder builder, int faceExpressionOffset)
		{
			builder.AddOffset(2, faceExpressionOffset, 0);
		}

		// Token: 0x06030839 RID: 198713 RVA: 0x00696AC5 File Offset: 0x00694CC5
		public static void AddMaleVariantType(FlatBufferBuilder builder, IFaceExpressionConfig_Union maleVariantType)
		{
			builder.AddByte(3, (byte)maleVariantType, 0);
		}

		// Token: 0x0603083A RID: 198714 RVA: 0x00696AD0 File Offset: 0x00694CD0
		public static void AddMaleVariant(FlatBufferBuilder builder, int maleVariantOffset)
		{
			builder.AddOffset(4, maleVariantOffset, 0);
		}

		// Token: 0x0603083B RID: 198715 RVA: 0x00696ADB File Offset: 0x00694CDB
		public static void AddCloseAutoBlink(FlatBufferBuilder builder, bool closeAutoBlink)
		{
			builder.AddBool(5, closeAutoBlink, false);
		}

		// Token: 0x0603083C RID: 198716 RVA: 0x00696AE6 File Offset: 0x00694CE6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603083D RID: 198717 RVA: 0x00696AF1 File Offset: 0x00694CF1
		public static Offset<IFaceExpressionConfigData> EndIFaceExpressionConfigData(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionConfigData>(builder.EndTable());
		}

		// Token: 0x0603083E RID: 198718 RVA: 0x00696B00 File Offset: 0x00694D00
		public IFaceExpressionConfigDataT UnPack()
		{
			IFaceExpressionConfigDataT faceExpressionConfigDataT = new IFaceExpressionConfigDataT();
			this.UnPackTo(faceExpressionConfigDataT);
			return faceExpressionConfigDataT;
		}

		// Token: 0x0603083F RID: 198719 RVA: 0x00696B1C File Offset: 0x00694D1C
		public void UnPackTo(IFaceExpressionConfigDataT _o)
		{
			_o.Id = this.Id;
			_o.FaceExpression = new IFaceExpressionConfig_UnionUnion();
			_o.FaceExpression.Type = this.FaceExpressionType;
			switch (this.FaceExpressionType)
			{
			case IFaceExpressionConfig_Union.IFaceExpressionConfig:
				_o.FaceExpression.Value = ((this.FaceExpression<IFaceExpressionConfig>() != null) ? this.FaceExpression<IFaceExpressionConfig>().Value.UnPack() : null);
				break;
			case IFaceExpressionConfig_Union.IFaceExpressionMorphConfig:
				_o.FaceExpression.Value = ((this.FaceExpression<IFaceExpressionMorphConfig>() != null) ? this.FaceExpression<IFaceExpressionMorphConfig>().Value.UnPack() : null);
				break;
			case IFaceExpressionConfig_Union.IFaceExpressionTextureConfig:
				_o.FaceExpression.Value = ((this.FaceExpression<IFaceExpressionTextureConfig>() != null) ? this.FaceExpression<IFaceExpressionTextureConfig>().Value.UnPack() : null);
				break;
			case IFaceExpressionConfig_Union.IFaceExpressionAnimSequenceConfig:
				_o.FaceExpression.Value = ((this.FaceExpression<IFaceExpressionAnimSequenceConfig>() != null) ? this.FaceExpression<IFaceExpressionAnimSequenceConfig>().Value.UnPack() : null);
				break;
			case IFaceExpressionConfig_Union.IFaceExpressionTextureMultiSlotConfig:
				_o.FaceExpression.Value = ((this.FaceExpression<IFaceExpressionTextureMultiSlotConfig>() != null) ? this.FaceExpression<IFaceExpressionTextureMultiSlotConfig>().Value.UnPack() : null);
				break;
			}
			_o.MaleVariant = new IFaceExpressionConfig_UnionUnion();
			_o.MaleVariant.Type = this.MaleVariantType;
			switch (this.MaleVariantType)
			{
			case IFaceExpressionConfig_Union.IFaceExpressionConfig:
				_o.MaleVariant.Value = ((this.MaleVariant<IFaceExpressionConfig>() != null) ? this.MaleVariant<IFaceExpressionConfig>().Value.UnPack() : null);
				break;
			case IFaceExpressionConfig_Union.IFaceExpressionMorphConfig:
				_o.MaleVariant.Value = ((this.MaleVariant<IFaceExpressionMorphConfig>() != null) ? this.MaleVariant<IFaceExpressionMorphConfig>().Value.UnPack() : null);
				break;
			case IFaceExpressionConfig_Union.IFaceExpressionTextureConfig:
				_o.MaleVariant.Value = ((this.MaleVariant<IFaceExpressionTextureConfig>() != null) ? this.MaleVariant<IFaceExpressionTextureConfig>().Value.UnPack() : null);
				break;
			case IFaceExpressionConfig_Union.IFaceExpressionAnimSequenceConfig:
				_o.MaleVariant.Value = ((this.MaleVariant<IFaceExpressionAnimSequenceConfig>() != null) ? this.MaleVariant<IFaceExpressionAnimSequenceConfig>().Value.UnPack() : null);
				break;
			case IFaceExpressionConfig_Union.IFaceExpressionTextureMultiSlotConfig:
				_o.MaleVariant.Value = ((this.MaleVariant<IFaceExpressionTextureMultiSlotConfig>() != null) ? this.MaleVariant<IFaceExpressionTextureMultiSlotConfig>().Value.UnPack() : null);
				break;
			}
			_o.CloseAutoBlink = this.CloseAutoBlink;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030840 RID: 198720 RVA: 0x00696E10 File Offset: 0x00695010
		public static Offset<IFaceExpressionConfigData> Pack(FlatBufferBuilder builder, IFaceExpressionConfigDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionConfigData>);
			}
			IFaceExpressionConfig_Union faceExpression_type = (_o.FaceExpression == null) ? IFaceExpressionConfig_Union.NONE : _o.FaceExpression.Type;
			int faceExpressionOffset = (_o.FaceExpression == null) ? 0 : IFaceExpressionConfig_UnionUnion.Pack(builder, _o.FaceExpression);
			IFaceExpressionConfig_Union maleVariant_type = (_o.MaleVariant == null) ? IFaceExpressionConfig_Union.NONE : _o.MaleVariant.Type;
			int maleVariantOffset = (_o.MaleVariant == null) ? 0 : IFaceExpressionConfig_UnionUnion.Pack(builder, _o.MaleVariant);
			return IFaceExpressionConfigData.CreateIFaceExpressionConfigData(builder, _o.Id, faceExpression_type, faceExpressionOffset, maleVariant_type, maleVariantOffset, _o.CloseAutoBlink, _o.NullMask);
		}

		// Token: 0x04011C65 RID: 72805
		private Table __p;
	}
}
