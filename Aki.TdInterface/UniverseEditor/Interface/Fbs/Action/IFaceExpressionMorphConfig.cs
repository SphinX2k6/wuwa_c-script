using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD0 RID: 28112
	public struct IFaceExpressionMorphConfig : IFlatbufferObject
	{
		// Token: 0x1700CE0E RID: 52750
		// (get) Token: 0x0603085F RID: 198751 RVA: 0x006971BC File Offset: 0x006953BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030860 RID: 198752 RVA: 0x006971C9 File Offset: 0x006953C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030861 RID: 198753 RVA: 0x006971D0 File Offset: 0x006953D0
		public static IFaceExpressionMorphConfig GetRootAsIFaceExpressionMorphConfig(ByteBuffer _bb)
		{
			return IFaceExpressionMorphConfig.GetRootAsIFaceExpressionMorphConfig(_bb, default(IFaceExpressionMorphConfig));
		}

		// Token: 0x06030862 RID: 198754 RVA: 0x006971EC File Offset: 0x006953EC
		public static IFaceExpressionMorphConfig GetRootAsIFaceExpressionMorphConfig(ByteBuffer _bb, IFaceExpressionMorphConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030863 RID: 198755 RVA: 0x00697209 File Offset: 0x00695409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030864 RID: 198756 RVA: 0x00697218 File Offset: 0x00695418
		public IFaceExpressionMorphConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE0F RID: 52751
		// (get) Token: 0x06030865 RID: 198757 RVA: 0x00697228 File Offset: 0x00695428
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

		// Token: 0x1700CE10 RID: 52752
		// (get) Token: 0x06030866 RID: 198758 RVA: 0x00697264 File Offset: 0x00695464
		public string MorphData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030867 RID: 198759 RVA: 0x0069729B File Offset: 0x0069549B
		public Span<byte> GetMorphDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06030868 RID: 198760 RVA: 0x006972AA File Offset: 0x006954AA
		public byte[] GetMorphDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06030869 RID: 198761 RVA: 0x006972B8 File Offset: 0x006954B8
		public static Offset<IFaceExpressionMorphConfig> CreateIFaceExpressionMorphConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph, StringOffset MorphDataOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFaceExpressionMorphConfig.AddMorphData(builder, MorphDataOffset);
			IFaceExpressionMorphConfig.AddType(builder, Type);
			return IFaceExpressionMorphConfig.EndIFaceExpressionMorphConfig(builder);
		}

		// Token: 0x0603086A RID: 198762 RVA: 0x006972D5 File Offset: 0x006954D5
		public static void StartIFaceExpressionMorphConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603086B RID: 198763 RVA: 0x006972DE File Offset: 0x006954DE
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603086C RID: 198764 RVA: 0x006972E9 File Offset: 0x006954E9
		public static void AddMorphData(FlatBufferBuilder builder, StringOffset morphDataOffset)
		{
			builder.AddOffset(1, morphDataOffset.Value, 0);
		}

		// Token: 0x0603086D RID: 198765 RVA: 0x006972F9 File Offset: 0x006954F9
		public static Offset<IFaceExpressionMorphConfig> EndIFaceExpressionMorphConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionMorphConfig>(builder.EndTable());
		}

		// Token: 0x0603086E RID: 198766 RVA: 0x00697308 File Offset: 0x00695508
		public IFaceExpressionMorphConfigT UnPack()
		{
			IFaceExpressionMorphConfigT faceExpressionMorphConfigT = new IFaceExpressionMorphConfigT();
			this.UnPackTo(faceExpressionMorphConfigT);
			return faceExpressionMorphConfigT;
		}

		// Token: 0x0603086F RID: 198767 RVA: 0x00697323 File Offset: 0x00695523
		public void UnPackTo(IFaceExpressionMorphConfigT _o)
		{
			_o.Type = this.Type;
			_o.MorphData = this.MorphData;
		}

		// Token: 0x06030870 RID: 198768 RVA: 0x00697340 File Offset: 0x00695540
		public static Offset<IFaceExpressionMorphConfig> Pack(FlatBufferBuilder builder, IFaceExpressionMorphConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionMorphConfig>);
			}
			StringOffset morphDataOffset = (_o.MorphData == null) ? default(StringOffset) : builder.CreateString(_o.MorphData);
			return IFaceExpressionMorphConfig.CreateIFaceExpressionMorphConfig(builder, _o.Type, morphDataOffset);
		}

		// Token: 0x04011C74 RID: 72820
		private Table __p;
	}
}
