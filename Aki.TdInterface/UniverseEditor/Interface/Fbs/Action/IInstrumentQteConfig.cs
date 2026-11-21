using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007025 RID: 28709
	public struct IInstrumentQteConfig : IFlatbufferObject
	{
		// Token: 0x1700D233 RID: 53811
		// (get) Token: 0x06031BF0 RID: 203760 RVA: 0x006BC32F File Offset: 0x006BA52F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031BF1 RID: 203761 RVA: 0x006BC33C File Offset: 0x006BA53C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031BF2 RID: 203762 RVA: 0x006BC344 File Offset: 0x006BA544
		public static IInstrumentQteConfig GetRootAsIInstrumentQteConfig(ByteBuffer _bb)
		{
			return IInstrumentQteConfig.GetRootAsIInstrumentQteConfig(_bb, default(IInstrumentQteConfig));
		}

		// Token: 0x06031BF3 RID: 203763 RVA: 0x006BC360 File Offset: 0x006BA560
		public static IInstrumentQteConfig GetRootAsIInstrumentQteConfig(ByteBuffer _bb, IInstrumentQteConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031BF4 RID: 203764 RVA: 0x006BC37D File Offset: 0x006BA57D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031BF5 RID: 203765 RVA: 0x006BC38C File Offset: 0x006BA58C
		public IInstrumentQteConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D234 RID: 53812
		// (get) Token: 0x06031BF6 RID: 203766 RVA: 0x006BC39C File Offset: 0x006BA59C
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

		// Token: 0x1700D235 RID: 53813
		// (get) Token: 0x06031BF7 RID: 203767 RVA: 0x006BC3D8 File Offset: 0x006BA5D8
		public EInstrumentType InstrumentType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EInstrumentType.ChineseZither;
				}
				return (EInstrumentType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D236 RID: 53814
		// (get) Token: 0x06031BF8 RID: 203768 RVA: 0x006BC414 File Offset: 0x006BA614
		public string Description
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031BF9 RID: 203769 RVA: 0x006BC44B File Offset: 0x006BA64B
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06031BFA RID: 203770 RVA: 0x006BC45A File Offset: 0x006BA65A
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06031BFB RID: 203771 RVA: 0x006BC468 File Offset: 0x006BA668
		public IInstrumentQteConfig_QteSequenceRow? QteSequence(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IInstrumentQteConfig_QteSequenceRow?(default(IInstrumentQteConfig_QteSequenceRow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D237 RID: 53815
		// (get) Token: 0x06031BFC RID: 203772 RVA: 0x006BC4CC File Offset: 0x006BA6CC
		public int QteSequenceLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700D238 RID: 53816
		// (get) Token: 0x06031BFD RID: 203773 RVA: 0x006BC4F8 File Offset: 0x006BA6F8
		public string PreludeAsset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031BFE RID: 203774 RVA: 0x006BC530 File Offset: 0x006BA730
		public Span<byte> GetPreludeAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06031BFF RID: 203775 RVA: 0x006BC540 File Offset: 0x006BA740
		public byte[] GetPreludeAssetArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06031C00 RID: 203776 RVA: 0x006BC54F File Offset: 0x006BA74F
		public static Offset<IInstrumentQteConfig> CreateIInstrumentQteConfig(FlatBufferBuilder builder, int Id = 0, EInstrumentType InstrumentType = EInstrumentType.ChineseZither, StringOffset DescriptionOffset = default(StringOffset), VectorOffset QteSequenceOffset = default(VectorOffset), StringOffset PreludeAssetOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IInstrumentQteConfig.AddPreludeAsset(builder, PreludeAssetOffset);
			IInstrumentQteConfig.AddQteSequence(builder, QteSequenceOffset);
			IInstrumentQteConfig.AddDescription(builder, DescriptionOffset);
			IInstrumentQteConfig.AddId(builder, Id);
			IInstrumentQteConfig.AddInstrumentType(builder, InstrumentType);
			return IInstrumentQteConfig.EndIInstrumentQteConfig(builder);
		}

		// Token: 0x06031C01 RID: 203777 RVA: 0x006BC583 File Offset: 0x006BA783
		public static void StartIInstrumentQteConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06031C02 RID: 203778 RVA: 0x006BC58C File Offset: 0x006BA78C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06031C03 RID: 203779 RVA: 0x006BC597 File Offset: 0x006BA797
		public static void AddInstrumentType(FlatBufferBuilder builder, EInstrumentType instrumentType)
		{
			builder.AddByte(1, (byte)instrumentType, 0);
		}

		// Token: 0x06031C04 RID: 203780 RVA: 0x006BC5A2 File Offset: 0x006BA7A2
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
			builder.AddOffset(2, descriptionOffset.Value, 0);
		}

		// Token: 0x06031C05 RID: 203781 RVA: 0x006BC5B2 File Offset: 0x006BA7B2
		public static void AddQteSequence(FlatBufferBuilder builder, VectorOffset qteSequenceOffset)
		{
			builder.AddOffset(3, qteSequenceOffset.Value, 0);
		}

		// Token: 0x06031C06 RID: 203782 RVA: 0x006BC5C4 File Offset: 0x006BA7C4
		public static VectorOffset CreateQteSequenceVector(FlatBufferBuilder builder, Offset<IInstrumentQteConfig_QteSequenceRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031C07 RID: 203783 RVA: 0x006BC604 File Offset: 0x006BA804
		public static VectorOffset CreateQteSequenceVectorBlock(FlatBufferBuilder builder, Offset<IInstrumentQteConfig_QteSequenceRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInstrumentQteConfig_QteSequenceRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031C08 RID: 203784 RVA: 0x006BC61E File Offset: 0x006BA81E
		public static VectorOffset CreateQteSequenceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInstrumentQteConfig_QteSequenceRow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInstrumentQteConfig_QteSequenceRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x06031C09 RID: 203785 RVA: 0x006BC63C File Offset: 0x006BA83C
		public static VectorOffset CreateQteSequenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInstrumentQteConfig_QteSequenceRow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031C0A RID: 203786 RVA: 0x006BC655 File Offset: 0x006BA855
		public static void StartQteSequenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031C0B RID: 203787 RVA: 0x006BC660 File Offset: 0x006BA860
		public static void AddPreludeAsset(FlatBufferBuilder builder, StringOffset preludeAssetOffset)
		{
			builder.AddOffset(4, preludeAssetOffset.Value, 0);
		}

		// Token: 0x06031C0C RID: 203788 RVA: 0x006BC670 File Offset: 0x006BA870
		public static Offset<IInstrumentQteConfig> EndIInstrumentQteConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentQteConfig>(builder.EndTable());
		}

		// Token: 0x06031C0D RID: 203789 RVA: 0x006BC680 File Offset: 0x006BA880
		public IInstrumentQteConfigT UnPack()
		{
			IInstrumentQteConfigT instrumentQteConfigT = new IInstrumentQteConfigT();
			this.UnPackTo(instrumentQteConfigT);
			return instrumentQteConfigT;
		}

		// Token: 0x06031C0E RID: 203790 RVA: 0x006BC69C File Offset: 0x006BA89C
		public void UnPackTo(IInstrumentQteConfigT _o)
		{
			_o.Id = this.Id;
			_o.InstrumentType = this.InstrumentType;
			_o.Description = this.Description;
			_o.QteSequence = new List<IInstrumentQteConfig_QteSequenceRowT>();
			for (int i = 0; i < this.QteSequenceLength; i++)
			{
				_o.QteSequence.Add((this.QteSequence(i) != null) ? this.QteSequence(i).Value.UnPack() : null);
			}
			_o.PreludeAsset = this.PreludeAsset;
		}

		// Token: 0x06031C0F RID: 203791 RVA: 0x006BC72C File Offset: 0x006BA92C
		public static Offset<IInstrumentQteConfig> Pack(FlatBufferBuilder builder, IInstrumentQteConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInstrumentQteConfig>);
			}
			StringOffset descriptionOffset = (_o.Description == null) ? default(StringOffset) : builder.CreateString(_o.Description);
			VectorOffset qteSequenceOffset = default(VectorOffset);
			if (_o.QteSequence != null)
			{
				Offset<IInstrumentQteConfig_QteSequenceRow>[] array = new Offset<IInstrumentQteConfig_QteSequenceRow>[_o.QteSequence.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IInstrumentQteConfig_QteSequenceRow.Pack(builder, _o.QteSequence[i]);
				}
				qteSequenceOffset = IInstrumentQteConfig.CreateQteSequenceVector(builder, array);
			}
			StringOffset preludeAssetOffset = (_o.PreludeAsset == null) ? default(StringOffset) : builder.CreateString(_o.PreludeAsset);
			return IInstrumentQteConfig.CreateIInstrumentQteConfig(builder, _o.Id, _o.InstrumentType, descriptionOffset, qteSequenceOffset, preludeAssetOffset);
		}

		// Token: 0x04011F62 RID: 73570
		private Table __p;
	}
}
