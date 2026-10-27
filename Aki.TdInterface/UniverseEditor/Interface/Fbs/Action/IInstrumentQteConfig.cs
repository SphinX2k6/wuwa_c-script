using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006972 RID: 26994
	public struct IInstrumentQteConfig : IFlatbufferObject
	{
		// Token: 0x1700C830 RID: 51248
		// (get) Token: 0x0602F220 RID: 193056 RVA: 0x0066BE47 File Offset: 0x0066A047
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F221 RID: 193057 RVA: 0x0066BE54 File Offset: 0x0066A054
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F222 RID: 193058 RVA: 0x0066BE5C File Offset: 0x0066A05C
		public static IInstrumentQteConfig GetRootAsIInstrumentQteConfig(ByteBuffer _bb)
		{
			return IInstrumentQteConfig.GetRootAsIInstrumentQteConfig(_bb, default(IInstrumentQteConfig));
		}

		// Token: 0x0602F223 RID: 193059 RVA: 0x0066BE78 File Offset: 0x0066A078
		public static IInstrumentQteConfig GetRootAsIInstrumentQteConfig(ByteBuffer _bb, IInstrumentQteConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F224 RID: 193060 RVA: 0x0066BE95 File Offset: 0x0066A095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F225 RID: 193061 RVA: 0x0066BEA4 File Offset: 0x0066A0A4
		public IInstrumentQteConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C831 RID: 51249
		// (get) Token: 0x0602F226 RID: 193062 RVA: 0x0066BEB4 File Offset: 0x0066A0B4
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

		// Token: 0x1700C832 RID: 51250
		// (get) Token: 0x0602F227 RID: 193063 RVA: 0x0066BEF0 File Offset: 0x0066A0F0
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

		// Token: 0x1700C833 RID: 51251
		// (get) Token: 0x0602F228 RID: 193064 RVA: 0x0066BF2C File Offset: 0x0066A12C
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

		// Token: 0x0602F229 RID: 193065 RVA: 0x0066BF63 File Offset: 0x0066A163
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602F22A RID: 193066 RVA: 0x0066BF72 File Offset: 0x0066A172
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0602F22B RID: 193067 RVA: 0x0066BF80 File Offset: 0x0066A180
		public IInstrumentQteConfig_QteSequenceRow? QteSequence(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IInstrumentQteConfig_QteSequenceRow?(default(IInstrumentQteConfig_QteSequenceRow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C834 RID: 51252
		// (get) Token: 0x0602F22C RID: 193068 RVA: 0x0066BFE4 File Offset: 0x0066A1E4
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

		// Token: 0x1700C835 RID: 51253
		// (get) Token: 0x0602F22D RID: 193069 RVA: 0x0066C010 File Offset: 0x0066A210
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

		// Token: 0x0602F22E RID: 193070 RVA: 0x0066C048 File Offset: 0x0066A248
		public Span<byte> GetPreludeAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0602F22F RID: 193071 RVA: 0x0066C058 File Offset: 0x0066A258
		public byte[] GetPreludeAssetArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x0602F230 RID: 193072 RVA: 0x0066C067 File Offset: 0x0066A267
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

		// Token: 0x0602F231 RID: 193073 RVA: 0x0066C09B File Offset: 0x0066A29B
		public static void StartIInstrumentQteConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F232 RID: 193074 RVA: 0x0066C0A4 File Offset: 0x0066A2A4
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602F233 RID: 193075 RVA: 0x0066C0AF File Offset: 0x0066A2AF
		public static void AddInstrumentType(FlatBufferBuilder builder, EInstrumentType instrumentType)
		{
			builder.AddByte(1, (byte)instrumentType, 0);
		}

		// Token: 0x0602F234 RID: 193076 RVA: 0x0066C0BA File Offset: 0x0066A2BA
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
			builder.AddOffset(2, descriptionOffset.Value, 0);
		}

		// Token: 0x0602F235 RID: 193077 RVA: 0x0066C0CA File Offset: 0x0066A2CA
		public static void AddQteSequence(FlatBufferBuilder builder, VectorOffset qteSequenceOffset)
		{
			builder.AddOffset(3, qteSequenceOffset.Value, 0);
		}

		// Token: 0x0602F236 RID: 193078 RVA: 0x0066C0DC File Offset: 0x0066A2DC
		public static VectorOffset CreateQteSequenceVector(FlatBufferBuilder builder, Offset<IInstrumentQteConfig_QteSequenceRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F237 RID: 193079 RVA: 0x0066C11C File Offset: 0x0066A31C
		public static VectorOffset CreateQteSequenceVectorBlock(FlatBufferBuilder builder, Offset<IInstrumentQteConfig_QteSequenceRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInstrumentQteConfig_QteSequenceRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F238 RID: 193080 RVA: 0x0066C136 File Offset: 0x0066A336
		public static VectorOffset CreateQteSequenceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInstrumentQteConfig_QteSequenceRow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInstrumentQteConfig_QteSequenceRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F239 RID: 193081 RVA: 0x0066C154 File Offset: 0x0066A354
		public static VectorOffset CreateQteSequenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInstrumentQteConfig_QteSequenceRow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F23A RID: 193082 RVA: 0x0066C16D File Offset: 0x0066A36D
		public static void StartQteSequenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F23B RID: 193083 RVA: 0x0066C178 File Offset: 0x0066A378
		public static void AddPreludeAsset(FlatBufferBuilder builder, StringOffset preludeAssetOffset)
		{
			builder.AddOffset(4, preludeAssetOffset.Value, 0);
		}

		// Token: 0x0602F23C RID: 193084 RVA: 0x0066C188 File Offset: 0x0066A388
		public static Offset<IInstrumentQteConfig> EndIInstrumentQteConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInstrumentQteConfig>(builder.EndTable());
		}

		// Token: 0x0602F23D RID: 193085 RVA: 0x0066C198 File Offset: 0x0066A398
		public IInstrumentQteConfigT UnPack()
		{
			IInstrumentQteConfigT instrumentQteConfigT = new IInstrumentQteConfigT();
			this.UnPackTo(instrumentQteConfigT);
			return instrumentQteConfigT;
		}

		// Token: 0x0602F23E RID: 193086 RVA: 0x0066C1B4 File Offset: 0x0066A3B4
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

		// Token: 0x0602F23F RID: 193087 RVA: 0x0066C244 File Offset: 0x0066A444
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

		// Token: 0x040110F6 RID: 69878
		private Table __p;
	}
}
