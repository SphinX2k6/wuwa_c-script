using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D7F RID: 19839
	public struct IFrequencyDetectAiLineConfig : IFlatbufferObject
	{
		// Token: 0x17008DEA RID: 36330
		// (get) Token: 0x0601EBFD RID: 125949 RVA: 0x0044CCBD File Offset: 0x0044AEBD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EBFE RID: 125950 RVA: 0x0044CCCA File Offset: 0x0044AECA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EBFF RID: 125951 RVA: 0x0044CCD4 File Offset: 0x0044AED4
		public static IFrequencyDetectAiLineConfig GetRootAsIFrequencyDetectAiLineConfig(ByteBuffer _bb)
		{
			return IFrequencyDetectAiLineConfig.GetRootAsIFrequencyDetectAiLineConfig(_bb, default(IFrequencyDetectAiLineConfig));
		}

		// Token: 0x0601EC00 RID: 125952 RVA: 0x0044CCF0 File Offset: 0x0044AEF0
		public static IFrequencyDetectAiLineConfig GetRootAsIFrequencyDetectAiLineConfig(ByteBuffer _bb, IFrequencyDetectAiLineConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC01 RID: 125953 RVA: 0x0044CD0D File Offset: 0x0044AF0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC02 RID: 125954 RVA: 0x0044CD1C File Offset: 0x0044AF1C
		public IFrequencyDetectAiLineConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DEB RID: 36331
		// (get) Token: 0x0601EC03 RID: 125955 RVA: 0x0044CD2C File Offset: 0x0044AF2C
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

		// Token: 0x17008DEC RID: 36332
		// (get) Token: 0x0601EC04 RID: 125956 RVA: 0x0044CD68 File Offset: 0x0044AF68
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

		// Token: 0x17008DED RID: 36333
		// (get) Token: 0x0601EC05 RID: 125957 RVA: 0x0044CDA4 File Offset: 0x0044AFA4
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

		// Token: 0x0601EC06 RID: 125958 RVA: 0x0044CDDB File Offset: 0x0044AFDB
		public Span<byte> GetLineIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601EC07 RID: 125959 RVA: 0x0044CDEA File Offset: 0x0044AFEA
		public byte[] GetLineIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008DEE RID: 36334
		// (get) Token: 0x0601EC08 RID: 125960 RVA: 0x0044CDF8 File Offset: 0x0044AFF8
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

		// Token: 0x17008DEF RID: 36335
		// (get) Token: 0x0601EC09 RID: 125961 RVA: 0x0044CE3C File Offset: 0x0044B03C
		public float StartDelay
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008DF0 RID: 36336
		// (get) Token: 0x0601EC0A RID: 125962 RVA: 0x0044CE80 File Offset: 0x0044B080
		public float PaintSpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EC0B RID: 125963 RVA: 0x0044CEC1 File Offset: 0x0044B0C1
		public static Offset<IFrequencyDetectAiLineConfig> CreateIFrequencyDetectAiLineConfig(FlatBufferBuilder builder, EFrequencyDetectLineOwner Type = EFrequencyDetectLineOwner.AI, int Batch = 0, StringOffset LineIdOffset = default(StringOffset), float TrackStayDuration = 0f, float StartDelay = 0f, float PaintSpeed = 0f)
		{
			builder.StartTable(6);
			IFrequencyDetectAiLineConfig.AddPaintSpeed(builder, PaintSpeed);
			IFrequencyDetectAiLineConfig.AddStartDelay(builder, StartDelay);
			IFrequencyDetectAiLineConfig.AddTrackStayDuration(builder, TrackStayDuration);
			IFrequencyDetectAiLineConfig.AddLineId(builder, LineIdOffset);
			IFrequencyDetectAiLineConfig.AddBatch(builder, Batch);
			IFrequencyDetectAiLineConfig.AddType(builder, Type);
			return IFrequencyDetectAiLineConfig.EndIFrequencyDetectAiLineConfig(builder);
		}

		// Token: 0x0601EC0C RID: 125964 RVA: 0x0044CEFD File Offset: 0x0044B0FD
		public static void StartIFrequencyDetectAiLineConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601EC0D RID: 125965 RVA: 0x0044CF06 File Offset: 0x0044B106
		public static void AddType(FlatBufferBuilder builder, EFrequencyDetectLineOwner type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EC0E RID: 125966 RVA: 0x0044CF11 File Offset: 0x0044B111
		public static void AddBatch(FlatBufferBuilder builder, int batch)
		{
			builder.AddInt(1, batch, 0);
		}

		// Token: 0x0601EC0F RID: 125967 RVA: 0x0044CF1C File Offset: 0x0044B11C
		public static void AddLineId(FlatBufferBuilder builder, StringOffset lineIdOffset)
		{
			builder.AddOffset(2, lineIdOffset.Value, 0);
		}

		// Token: 0x0601EC10 RID: 125968 RVA: 0x0044CF2C File Offset: 0x0044B12C
		public static void AddTrackStayDuration(FlatBufferBuilder builder, float trackStayDuration)
		{
			builder.AddFloat(3, trackStayDuration, 0.0);
		}

		// Token: 0x0601EC11 RID: 125969 RVA: 0x0044CF3F File Offset: 0x0044B13F
		public static void AddStartDelay(FlatBufferBuilder builder, float startDelay)
		{
			builder.AddFloat(4, startDelay, 0.0);
		}

		// Token: 0x0601EC12 RID: 125970 RVA: 0x0044CF52 File Offset: 0x0044B152
		public static void AddPaintSpeed(FlatBufferBuilder builder, float paintSpeed)
		{
			builder.AddFloat(5, paintSpeed, 0.0);
		}

		// Token: 0x0601EC13 RID: 125971 RVA: 0x0044CF65 File Offset: 0x0044B165
		public static Offset<IFrequencyDetectAiLineConfig> EndIFrequencyDetectAiLineConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectAiLineConfig>(builder.EndTable());
		}

		// Token: 0x0601EC14 RID: 125972 RVA: 0x0044CF74 File Offset: 0x0044B174
		public IFrequencyDetectAiLineConfigT UnPack()
		{
			IFrequencyDetectAiLineConfigT frequencyDetectAiLineConfigT = new IFrequencyDetectAiLineConfigT();
			this.UnPackTo(frequencyDetectAiLineConfigT);
			return frequencyDetectAiLineConfigT;
		}

		// Token: 0x0601EC15 RID: 125973 RVA: 0x0044CF90 File Offset: 0x0044B190
		public void UnPackTo(IFrequencyDetectAiLineConfigT _o)
		{
			_o.Type = this.Type;
			_o.Batch = this.Batch;
			_o.LineId = this.LineId;
			_o.TrackStayDuration = this.TrackStayDuration;
			_o.StartDelay = this.StartDelay;
			_o.PaintSpeed = this.PaintSpeed;
		}

		// Token: 0x0601EC16 RID: 125974 RVA: 0x0044CFE8 File Offset: 0x0044B1E8
		public static Offset<IFrequencyDetectAiLineConfig> Pack(FlatBufferBuilder builder, IFrequencyDetectAiLineConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectAiLineConfig>);
			}
			StringOffset lineIdOffset = (_o.LineId == null) ? default(StringOffset) : builder.CreateString(_o.LineId);
			return IFrequencyDetectAiLineConfig.CreateIFrequencyDetectAiLineConfig(builder, _o.Type, _o.Batch, lineIdOffset, _o.TrackStayDuration, _o.StartDelay, _o.PaintSpeed);
		}

		// Token: 0x0400D9CF RID: 55759
		private Table __p;
	}
}
