using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D94 RID: 19860
	public struct IFrequencyDetectPlayerLineConfig : IFlatbufferObject
	{
		// Token: 0x17008E16 RID: 36374
		// (get) Token: 0x0601ECBF RID: 126143 RVA: 0x0044E394 File Offset: 0x0044C594
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601ECC0 RID: 126144 RVA: 0x0044E3A1 File Offset: 0x0044C5A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601ECC1 RID: 126145 RVA: 0x0044E3A8 File Offset: 0x0044C5A8
		public static IFrequencyDetectPlayerLineConfig GetRootAsIFrequencyDetectPlayerLineConfig(ByteBuffer _bb)
		{
			return IFrequencyDetectPlayerLineConfig.GetRootAsIFrequencyDetectPlayerLineConfig(_bb, default(IFrequencyDetectPlayerLineConfig));
		}

		// Token: 0x0601ECC2 RID: 126146 RVA: 0x0044E3C4 File Offset: 0x0044C5C4
		public static IFrequencyDetectPlayerLineConfig GetRootAsIFrequencyDetectPlayerLineConfig(ByteBuffer _bb, IFrequencyDetectPlayerLineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601ECC3 RID: 126147 RVA: 0x0044E3E1 File Offset: 0x0044C5E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601ECC4 RID: 126148 RVA: 0x0044E3F0 File Offset: 0x0044C5F0
		public IFrequencyDetectPlayerLineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E17 RID: 36375
		// (get) Token: 0x0601ECC5 RID: 126149 RVA: 0x0044E400 File Offset: 0x0044C600
		public EFrequencyDetectLineOwner Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFrequencyDetectLineOwner.AI;
				}
				return (EFrequencyDetectLineOwner)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E18 RID: 36376
		// (get) Token: 0x0601ECC6 RID: 126150 RVA: 0x0044E43C File Offset: 0x0044C63C
		public int Batch
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

		// Token: 0x17008E19 RID: 36377
		// (get) Token: 0x0601ECC7 RID: 126151 RVA: 0x0044E478 File Offset: 0x0044C678
		public string LineId
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

		// Token: 0x0601ECC8 RID: 126152 RVA: 0x0044E4AF File Offset: 0x0044C6AF
		public Span<byte> GetLineIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601ECC9 RID: 126153 RVA: 0x0044E4BE File Offset: 0x0044C6BE
		public byte[] GetLineIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008E1A RID: 36378
		// (get) Token: 0x0601ECCA RID: 126154 RVA: 0x0044E4CC File Offset: 0x0044C6CC
		public float TrackStayDuration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601ECCB RID: 126155 RVA: 0x0044E50D File Offset: 0x0044C70D
		public static Offset<IFrequencyDetectPlayerLineConfig> CreateIFrequencyDetectPlayerLineConfig(FlatBufferBuilder builder, EFrequencyDetectLineOwner Type = EFrequencyDetectLineOwner.AI, int Batch = 0, StringOffset LineIdOffset = default(StringOffset), float TrackStayDuration = 0f)
		{
			builder.StartTable(4);
			IFrequencyDetectPlayerLineConfig.AddTrackStayDuration(builder, TrackStayDuration);
			IFrequencyDetectPlayerLineConfig.AddLineId(builder, LineIdOffset);
			IFrequencyDetectPlayerLineConfig.AddBatch(builder, Batch);
			IFrequencyDetectPlayerLineConfig.AddType(builder, Type);
			return IFrequencyDetectPlayerLineConfig.EndIFrequencyDetectPlayerLineConfig(builder);
		}

		// Token: 0x0601ECCC RID: 126156 RVA: 0x0044E539 File Offset: 0x0044C739
		public static void StartIFrequencyDetectPlayerLineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601ECCD RID: 126157 RVA: 0x0044E542 File Offset: 0x0044C742
		public static void AddType(FlatBufferBuilder builder, EFrequencyDetectLineOwner type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ECCE RID: 126158 RVA: 0x0044E54D File Offset: 0x0044C74D
		public static void AddBatch(FlatBufferBuilder builder, int batch)
		{
			builder.AddInt(1, batch, 0);
		}

		// Token: 0x0601ECCF RID: 126159 RVA: 0x0044E558 File Offset: 0x0044C758
		public static void AddLineId(FlatBufferBuilder builder, StringOffset lineIdOffset)
		{
			builder.AddOffset(2, lineIdOffset.Value, 0);
		}

		// Token: 0x0601ECD0 RID: 126160 RVA: 0x0044E568 File Offset: 0x0044C768
		public static void AddTrackStayDuration(FlatBufferBuilder builder, float trackStayDuration)
		{
			builder.AddFloat(3, trackStayDuration, 0.0);
		}

		// Token: 0x0601ECD1 RID: 126161 RVA: 0x0044E57B File Offset: 0x0044C77B
		public static Offset<IFrequencyDetectPlayerLineConfig> EndIFrequencyDetectPlayerLineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectPlayerLineConfig>(builder.EndTable());
		}

		// Token: 0x0601ECD2 RID: 126162 RVA: 0x0044E588 File Offset: 0x0044C788
		public IFrequencyDetectPlayerLineConfigT UnPack()
		{
			IFrequencyDetectPlayerLineConfigT frequencyDetectPlayerLineConfigT = new IFrequencyDetectPlayerLineConfigT();
			this.UnPackTo(frequencyDetectPlayerLineConfigT);
			return frequencyDetectPlayerLineConfigT;
		}

		// Token: 0x0601ECD3 RID: 126163 RVA: 0x0044E5A3 File Offset: 0x0044C7A3
		public void UnPackTo(IFrequencyDetectPlayerLineConfigT _o)
		{
			_o.Type = this.Type;
			_o.Batch = this.Batch;
			_o.LineId = this.LineId;
			_o.TrackStayDuration = this.TrackStayDuration;
		}

		// Token: 0x0601ECD4 RID: 126164 RVA: 0x0044E5D8 File Offset: 0x0044C7D8
		public static Offset<IFrequencyDetectPlayerLineConfig> Pack(FlatBufferBuilder builder, IFrequencyDetectPlayerLineConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectPlayerLineConfig>);
			}
			StringOffset lineIdOffset = (_o.LineId == null) ? default(StringOffset) : builder.CreateString(_o.LineId);
			return IFrequencyDetectPlayerLineConfig.CreateIFrequencyDetectPlayerLineConfig(builder, _o.Type, _o.Batch, lineIdOffset, _o.TrackStayDuration);
		}

		// Token: 0x0400D9EE RID: 55790
		private Table __p;
	}
}
