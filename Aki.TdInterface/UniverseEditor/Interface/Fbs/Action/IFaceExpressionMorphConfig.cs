using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006750 RID: 26448
	public struct IFaceExpressionMorphConfig : IFlatbufferObject
	{
		// Token: 0x1700C458 RID: 50264
		// (get) Token: 0x0602E019 RID: 188441 RVA: 0x00649A78 File Offset: 0x00647C78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E01A RID: 188442 RVA: 0x00649A85 File Offset: 0x00647C85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E01B RID: 188443 RVA: 0x00649A8C File Offset: 0x00647C8C
		public static IFaceExpressionMorphConfig GetRootAsIFaceExpressionMorphConfig(ByteBuffer _bb)
		{
			return IFaceExpressionMorphConfig.GetRootAsIFaceExpressionMorphConfig(_bb, default(IFaceExpressionMorphConfig));
		}

		// Token: 0x0602E01C RID: 188444 RVA: 0x00649AA8 File Offset: 0x00647CA8
		public static IFaceExpressionMorphConfig GetRootAsIFaceExpressionMorphConfig(ByteBuffer _bb, IFaceExpressionMorphConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E01D RID: 188445 RVA: 0x00649AC5 File Offset: 0x00647CC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E01E RID: 188446 RVA: 0x00649AD4 File Offset: 0x00647CD4
		public IFaceExpressionMorphConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C459 RID: 50265
		// (get) Token: 0x0602E01F RID: 188447 RVA: 0x00649AE4 File Offset: 0x00647CE4
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

		// Token: 0x1700C45A RID: 50266
		// (get) Token: 0x0602E020 RID: 188448 RVA: 0x00649B20 File Offset: 0x00647D20
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

		// Token: 0x0602E021 RID: 188449 RVA: 0x00649B57 File Offset: 0x00647D57
		public Span<byte> GetMorphDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E022 RID: 188450 RVA: 0x00649B66 File Offset: 0x00647D66
		public byte[] GetMorphDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E023 RID: 188451 RVA: 0x00649B74 File Offset: 0x00647D74
		public static Offset<IFaceExpressionMorphConfig> CreateIFaceExpressionMorphConfig(FlatBufferBuilder builder, EFaceExpressionConfigType Type = EFaceExpressionConfigType.Morph, StringOffset MorphDataOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IFaceExpressionMorphConfig.AddMorphData(builder, MorphDataOffset);
			IFaceExpressionMorphConfig.AddType(builder, Type);
			return IFaceExpressionMorphConfig.EndIFaceExpressionMorphConfig(builder);
		}

		// Token: 0x0602E024 RID: 188452 RVA: 0x00649B91 File Offset: 0x00647D91
		public static void StartIFaceExpressionMorphConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E025 RID: 188453 RVA: 0x00649B9A File Offset: 0x00647D9A
		public static void AddType(FlatBufferBuilder builder, EFaceExpressionConfigType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E026 RID: 188454 RVA: 0x00649BA5 File Offset: 0x00647DA5
		public static void AddMorphData(FlatBufferBuilder builder, StringOffset morphDataOffset)
		{
			builder.AddOffset(1, morphDataOffset.Value, 0);
		}

		// Token: 0x0602E027 RID: 188455 RVA: 0x00649BB5 File Offset: 0x00647DB5
		public static Offset<IFaceExpressionMorphConfig> EndIFaceExpressionMorphConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFaceExpressionMorphConfig>(builder.EndTable());
		}

		// Token: 0x0602E028 RID: 188456 RVA: 0x00649BC4 File Offset: 0x00647DC4
		public IFaceExpressionMorphConfigT UnPack()
		{
			IFaceExpressionMorphConfigT faceExpressionMorphConfigT = new IFaceExpressionMorphConfigT();
			this.UnPackTo(faceExpressionMorphConfigT);
			return faceExpressionMorphConfigT;
		}

		// Token: 0x0602E029 RID: 188457 RVA: 0x00649BDF File Offset: 0x00647DDF
		public void UnPackTo(IFaceExpressionMorphConfigT _o)
		{
			_o.Type = this.Type;
			_o.MorphData = this.MorphData;
		}

		// Token: 0x0602E02A RID: 188458 RVA: 0x00649BFC File Offset: 0x00647DFC
		public static Offset<IFaceExpressionMorphConfig> Pack(FlatBufferBuilder builder, IFaceExpressionMorphConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceExpressionMorphConfig>);
			}
			StringOffset morphDataOffset = (_o.MorphData == null) ? default(StringOffset) : builder.CreateString(_o.MorphData);
			return IFaceExpressionMorphConfig.CreateIFaceExpressionMorphConfig(builder, _o.Type, morphDataOffset);
		}

		// Token: 0x04010E42 RID: 69186
		private Table __p;
	}
}
