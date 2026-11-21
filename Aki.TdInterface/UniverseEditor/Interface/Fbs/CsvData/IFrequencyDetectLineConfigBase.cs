using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D8E RID: 19854
	public struct IFrequencyDetectLineConfigBase : IFlatbufferObject
	{
		// Token: 0x17008E0B RID: 36363
		// (get) Token: 0x0601EC91 RID: 126097 RVA: 0x0044DEEC File Offset: 0x0044C0EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC92 RID: 126098 RVA: 0x0044DEF9 File Offset: 0x0044C0F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC93 RID: 126099 RVA: 0x0044DF00 File Offset: 0x0044C100
		public static IFrequencyDetectLineConfigBase GetRootAsIFrequencyDetectLineConfigBase(ByteBuffer _bb)
		{
			return IFrequencyDetectLineConfigBase.GetRootAsIFrequencyDetectLineConfigBase(_bb, default(IFrequencyDetectLineConfigBase));
		}

		// Token: 0x0601EC94 RID: 126100 RVA: 0x0044DF1C File Offset: 0x0044C11C
		public static IFrequencyDetectLineConfigBase GetRootAsIFrequencyDetectLineConfigBase(ByteBuffer _bb, IFrequencyDetectLineConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC95 RID: 126101 RVA: 0x0044DF39 File Offset: 0x0044C139
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC96 RID: 126102 RVA: 0x0044DF48 File Offset: 0x0044C148
		public IFrequencyDetectLineConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E0C RID: 36364
		// (get) Token: 0x0601EC97 RID: 126103 RVA: 0x0044DF58 File Offset: 0x0044C158
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

		// Token: 0x17008E0D RID: 36365
		// (get) Token: 0x0601EC98 RID: 126104 RVA: 0x0044DF94 File Offset: 0x0044C194
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

		// Token: 0x17008E0E RID: 36366
		// (get) Token: 0x0601EC99 RID: 126105 RVA: 0x0044DFD0 File Offset: 0x0044C1D0
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

		// Token: 0x0601EC9A RID: 126106 RVA: 0x0044E007 File Offset: 0x0044C207
		public Span<byte> GetLineIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601EC9B RID: 126107 RVA: 0x0044E016 File Offset: 0x0044C216
		public byte[] GetLineIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008E0F RID: 36367
		// (get) Token: 0x0601EC9C RID: 126108 RVA: 0x0044E024 File Offset: 0x0044C224
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

		// Token: 0x0601EC9D RID: 126109 RVA: 0x0044E065 File Offset: 0x0044C265
		public static Offset<IFrequencyDetectLineConfigBase> CreateIFrequencyDetectLineConfigBase(FlatBufferBuilder builder, EFrequencyDetectLineOwner Type = EFrequencyDetectLineOwner.AI, int Batch = 0, StringOffset LineIdOffset = default(StringOffset), float TrackStayDuration = 0f)
		{
			builder.StartTable(4);
			IFrequencyDetectLineConfigBase.AddTrackStayDuration(builder, TrackStayDuration);
			IFrequencyDetectLineConfigBase.AddLineId(builder, LineIdOffset);
			IFrequencyDetectLineConfigBase.AddBatch(builder, Batch);
			IFrequencyDetectLineConfigBase.AddType(builder, Type);
			return IFrequencyDetectLineConfigBase.EndIFrequencyDetectLineConfigBase(builder);
		}

		// Token: 0x0601EC9E RID: 126110 RVA: 0x0044E091 File Offset: 0x0044C291
		public static void StartIFrequencyDetectLineConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601EC9F RID: 126111 RVA: 0x0044E09A File Offset: 0x0044C29A
		public static void AddType(FlatBufferBuilder builder, EFrequencyDetectLineOwner type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601ECA0 RID: 126112 RVA: 0x0044E0A5 File Offset: 0x0044C2A5
		public static void AddBatch(FlatBufferBuilder builder, int batch)
		{
			builder.AddInt(1, batch, 0);
		}

		// Token: 0x0601ECA1 RID: 126113 RVA: 0x0044E0B0 File Offset: 0x0044C2B0
		public static void AddLineId(FlatBufferBuilder builder, StringOffset lineIdOffset)
		{
			builder.AddOffset(2, lineIdOffset.Value, 0);
		}

		// Token: 0x0601ECA2 RID: 126114 RVA: 0x0044E0C0 File Offset: 0x0044C2C0
		public static void AddTrackStayDuration(FlatBufferBuilder builder, float trackStayDuration)
		{
			builder.AddFloat(3, trackStayDuration, 0.0);
		}

		// Token: 0x0601ECA3 RID: 126115 RVA: 0x0044E0D3 File Offset: 0x0044C2D3
		public static Offset<IFrequencyDetectLineConfigBase> EndIFrequencyDetectLineConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectLineConfigBase>(builder.EndTable());
		}

		// Token: 0x0601ECA4 RID: 126116 RVA: 0x0044E0E0 File Offset: 0x0044C2E0
		public IFrequencyDetectLineConfigBaseT UnPack()
		{
			IFrequencyDetectLineConfigBaseT frequencyDetectLineConfigBaseT = new IFrequencyDetectLineConfigBaseT();
			this.UnPackTo(frequencyDetectLineConfigBaseT);
			return frequencyDetectLineConfigBaseT;
		}

		// Token: 0x0601ECA5 RID: 126117 RVA: 0x0044E0FB File Offset: 0x0044C2FB
		public void UnPackTo(IFrequencyDetectLineConfigBaseT _o)
		{
			_o.Type = this.Type;
			_o.Batch = this.Batch;
			_o.LineId = this.LineId;
			_o.TrackStayDuration = this.TrackStayDuration;
		}

		// Token: 0x0601ECA6 RID: 126118 RVA: 0x0044E130 File Offset: 0x0044C330
		public static Offset<IFrequencyDetectLineConfigBase> Pack(FlatBufferBuilder builder, IFrequencyDetectLineConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectLineConfigBase>);
			}
			StringOffset lineIdOffset = (_o.LineId == null) ? default(StringOffset) : builder.CreateString(_o.LineId);
			return IFrequencyDetectLineConfigBase.CreateIFrequencyDetectLineConfigBase(builder, _o.Type, _o.Batch, lineIdOffset, _o.TrackStayDuration);
		}

		// Token: 0x0400D9E2 RID: 55778
		private Table __p;
	}
}
