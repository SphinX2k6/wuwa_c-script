using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200674A RID: 26442
	public struct IFaceExpressionConfigData : IFlatbufferObject
	{
		// Token: 0x1700C44B RID: 50251
		// (get) Token: 0x0602DFD7 RID: 188375 RVA: 0x00648FBD File Offset: 0x006471BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DFD8 RID: 188376 RVA: 0x00648FCA File Offset: 0x006471CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DFD9 RID: 188377 RVA: 0x00648FD4 File Offset: 0x006471D4
		public static IFaceExpressionConfigData GetRootAsIFaceExpressionConfigData(ByteBuffer _bb)
		{
			return IFaceExpressionConfigData.GetRootAsIFaceExpressionConfigData(_bb, default(IFaceExpressionConfigData));
		}

		// Token: 0x0602DFDA RID: 188378 RVA: 0x00648FF0 File Offset: 0x006471F0
		public static IFaceExpressionConfigData GetRootAsIFaceExpressionConfigData(ByteBuffer _bb, IFaceExpressionConfigData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DFDB RID: 188379 RVA: 0x0064900D File Offset: 0x0064720D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DFDC RID: 188380 RVA: 0x0064901C File Offset: 0x0064721C
		public IFaceExpressionConfigData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C44C RID: 50252
		// (get) Token: 0x0602DFDD RID: 188381 RVA: 0x0064902C File Offset: 0x0064722C
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

		// Token: 0x1700C44D RID: 50253
		// (get) Token: 0x0602DFDE RID: 188382 RVA: 0x00649068 File Offset: 0x00647268
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

		// Token: 0x0602DFDF RID: 188383 RVA: 0x006490A4 File Offset: 0x006472A4
		public TTable? FaceExpression<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DFE0 RID: 188384 RVA: 0x006490E8 File Offset: 0x006472E8
		public IFaceExpressionConfig FaceExpressionAsIFaceExpressionConfig()
		{
			return this.FaceExpression<IFaceExpressionConfig>().Value;
		}

		// Token: 0x0602DFE1 RID: 188385 RVA: 0x00649104 File Offset: 0x00647304
		public IFaceExpressionMorphConfig FaceExpressionAsIFaceExpressionMorphConfig()
		{
			return this.FaceExpression<IFaceExpressionMorphConfig>().Value;
		}

		// Token: 0x0602DFE2 RID: 188386 RVA: 0x00649120 File Offset: 0x00647320
		public IFaceExpressionTextureConfig FaceExpressionAsIFaceExpressionTextureConfig()
		{
			return this.FaceExpression<IFaceExpressionTextureConfig>().Value;
		}

		// Token: 0x0602DFE3 RID: 188387 RVA: 0x0064913C File Offset: 0x0064733C
		public IFaceExpressionAnimSequenceConfig FaceExpressionAsIFaceExpressionAnimSequenceConfig()
		{
			return this.FaceExpression<IFaceExpressionAnimSequenceConfig>().Value;
		}

		// Token: 0x0602DFE4 RID: 188388 RVA: 0x00649158 File Offset: 0x00647358
		public IFaceExpressionTextureMultiSlotConfig FaceExpressionAsIFaceExpressionTextureMultiSlotConfig()
		{
			return this.FaceExpression<IFaceExpressionTextureMultiSlotConfig>().Value;
		}

		// Token: 0x1700C44E RID: 50254
		// (get) Token: 0x0602DFE5 RID: 188389 RVA: 0x00649174 File Offset: 0x00647374
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

		// Token: 0x0602DFE6 RID: 188390 RVA: 0x006491B4 File Offset: 0x006473B4
		public TTable? MaleVariant<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DFE7 RID: 188391 RVA: 0x006491FC File Offset: 0x006473FC
		public IFaceExpressionConfig MaleVariantAsIFaceExpressionConfig()
		{
			return this.MaleVariant<IFaceExpressionConfig>().Value;
		}

		// Token: 0x0602DFE8 RID: 188392 RVA: 0x00649218 File Offset: 0x00647418
		public IFaceExpressionMorphConfig MaleVariantAsIFaceExpressionMorphConfig()
		{
			return this.MaleVariant<IFaceExpressionMorphConfig>().Value;
		}

		// Token: 0x0602DFE9 RID: 188393 RVA: 0x00649234 File Offset: 0x00647434
		public IFaceExpressionTextureConfig MaleVariantAsIFaceExpressionTextureConfig()
		{
			return this.MaleVariant<IFaceExpressionTextureConfig>().Value;
		}

		// Token: 0x0602DFEA RID: 188394 RVA: 0x00649250 File Offset: 0x00647450
		public IFaceExpressionAnimSequenceConfig MaleVariantAsIFaceExpressionAnimSequenceConfig()
		{
			return this.MaleVariant<IFaceExpressionAnimSequenceConfig>().Value;
		}

		// Token: 0x0602DFEB RID: 188395 RVA: 0x0064926C File Offset: 0x0064746C
		public IFaceExpressionTextureMultiSlotConfig MaleVariantAsIFaceExpressionTextureMultiSlotConfig()
		{
			return this.MaleVariant<IFaceExpressionTextureMultiSlotConfig>().Value;
		}

		// Token: 0x1700C44F RID: 50255
		// (get) Token: 0x0602DFEC RID: 188396 RVA: 0x00649288 File Offset: 0x00647488
		public bool CloseAutoBlink
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C450 RID: 50256
		// (get) Token: 0x0602DFED RID: 188397 RVA: 0x006492C8 File Offset: 0x006474C8
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

		// Token: 0x0602DFEE RID: 188398 RVA: 0x00649308 File Offset: 0x00647508
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

		// Token: 0x0602DFEF RID: 188399 RVA: 0x00649357 File Offset: 0x00647557
		public static void StartIFaceExpressionConfigData(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602DFF0 RID: 188400 RVA: 0x00649360 File Offset: 0x00647560
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602DFF1 RID: 188401 RVA: 0x0064936B File Offset: 0x0064756B
		public static void AddFaceExpressionType(FlatBufferBuilder builder, IFaceExpressionConfig_Union faceExpressionType)
		{
			builder.AddByte(1, (byte)faceExpressionType, 0);
		}

		// Token: 0x0602DFF2 RID: 188402 RVA: 0x00649376 File Offset: 0x00647576
		public static void AddFaceExpression(FlatBufferBuilder builder, int faceExpressionOffset)
		{
			builder.AddOffset(2, faceExpressionOffset, 0);
		}

		// Token: 0x0602DFF3 RID: 188403 RVA: 0x00649381 File Offset: 0x00647581
		public static void AddMaleVariantType(FlatBufferBuilder builder, IFaceExpressionConfig_Union maleVariantType)
		{
			builder.AddByte(3, (byte)maleVariantType, 0);
		}

		// Token: 0x0602DFF4 RID: 188404 RVA: 0x0064938C File Offset: 0x0064758C
		public static void AddMaleVariant(FlatBufferBuilder builder, int maleVariantOffset)
		{
			builder.AddOffset(4, maleVariantOffset, 0);
		}

		// Token: 0x0602DFF5 RID: 188405 RVA: 0x00649397 File Offset: 0x00647597
		public static void AddCloseAutoBlink(FlatBufferBuilder builder, bool closeAutoBlink)
		{
			builder.AddBool(5, closeAutoBlink, false);
		}

		// Token: 0x0602DFF6 RID: 188406 RVA: 0x006493A2 File Offset: 0x006475A2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602DFF7 RID: 188407 RVA: 0x006493AD File Offset: 0x006475AD
		public static Offset<IFaceExpressionConfigData> EndIFaceExpressionConfigData(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionConfigData>(builder.EndTable());
		}

		// Token: 0x0602DFF8 RID: 188408 RVA: 0x006493BC File Offset: 0x006475BC
		public IFaceExpressionConfigDataT UnPack()
		{
			IFaceExpressionConfigDataT faceExpressionConfigDataT = new IFaceExpressionConfigDataT();
			this.UnPackTo(faceExpressionConfigDataT);
			return faceExpressionConfigDataT;
		}

		// Token: 0x0602DFF9 RID: 188409 RVA: 0x006493D8 File Offset: 0x006475D8
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

		// Token: 0x0602DFFA RID: 188410 RVA: 0x006496CC File Offset: 0x006478CC
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

		// Token: 0x04010E33 RID: 69171
		private Table __p;
	}
}
