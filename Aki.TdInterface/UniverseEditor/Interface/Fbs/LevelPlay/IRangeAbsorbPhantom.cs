using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004539 RID: 17721
	public struct IRangeAbsorbPhantom : IFlatbufferObject
	{
		// Token: 0x17007DAC RID: 32172
		// (get) Token: 0x0601AA61 RID: 109153 RVA: 0x003CD715 File Offset: 0x003CB915
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA62 RID: 109154 RVA: 0x003CD722 File Offset: 0x003CB922
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA63 RID: 109155 RVA: 0x003CD72C File Offset: 0x003CB92C
		public static IRangeAbsorbPhantom GetRootAsIRangeAbsorbPhantom(ByteBuffer _bb)
		{
			return IRangeAbsorbPhantom.GetRootAsIRangeAbsorbPhantom(_bb, default(IRangeAbsorbPhantom));
		}

		// Token: 0x0601AA64 RID: 109156 RVA: 0x003CD748 File Offset: 0x003CB948
		public static IRangeAbsorbPhantom GetRootAsIRangeAbsorbPhantom(ByteBuffer _bb, IRangeAbsorbPhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA65 RID: 109157 RVA: 0x003CD765 File Offset: 0x003CB965
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA66 RID: 109158 RVA: 0x003CD774 File Offset: 0x003CB974
		public IRangeAbsorbPhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DAD RID: 32173
		// (get) Token: 0x0601AA67 RID: 109159 RVA: 0x003CD784 File Offset: 0x003CB984
		public int PlayerActiveFuncRangeEntity
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

		// Token: 0x17007DAE RID: 32174
		// (get) Token: 0x0601AA68 RID: 109160 RVA: 0x003CD7C0 File Offset: 0x003CB9C0
		public int AutoAbsorbRangeEntity
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

		// Token: 0x0601AA69 RID: 109161 RVA: 0x003CD7FC File Offset: 0x003CB9FC
		public int IntervalKillNumber(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007DAF RID: 32175
		// (get) Token: 0x0601AA6A RID: 109162 RVA: 0x003CD83C File Offset: 0x003CBA3C
		public int IntervalKillNumberLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601AA6B RID: 109163 RVA: 0x003CD867 File Offset: 0x003CBA67
		public Span<int> GetIntervalKillNumberBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601AA6C RID: 109164 RVA: 0x003CD876 File Offset: 0x003CBA76
		public int[] GetIntervalKillNumberArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007DB0 RID: 32176
		// (get) Token: 0x0601AA6D RID: 109165 RVA: 0x003CD884 File Offset: 0x003CBA84
		public float DelayTime
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

		// Token: 0x17007DB1 RID: 32177
		// (get) Token: 0x0601AA6E RID: 109166 RVA: 0x003CD8C8 File Offset: 0x003CBAC8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AA6F RID: 109167 RVA: 0x003CD905 File Offset: 0x003CBB05
		public static Offset<IRangeAbsorbPhantom> CreateIRangeAbsorbPhantom(FlatBufferBuilder builder, int PlayerActiveFuncRangeEntity = 0, int AutoAbsorbRangeEntity = 0, VectorOffset IntervalKillNumberOffset = default(VectorOffset), float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IRangeAbsorbPhantom.AddDelayTime(builder, DelayTime);
			IRangeAbsorbPhantom.AddIntervalKillNumber(builder, IntervalKillNumberOffset);
			IRangeAbsorbPhantom.AddAutoAbsorbRangeEntity(builder, AutoAbsorbRangeEntity);
			IRangeAbsorbPhantom.AddPlayerActiveFuncRangeEntity(builder, PlayerActiveFuncRangeEntity);
			IRangeAbsorbPhantom.AddNullMask(builder, NullMask);
			return IRangeAbsorbPhantom.EndIRangeAbsorbPhantom(builder);
		}

		// Token: 0x0601AA70 RID: 109168 RVA: 0x003CD939 File Offset: 0x003CBB39
		public static void StartIRangeAbsorbPhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601AA71 RID: 109169 RVA: 0x003CD942 File Offset: 0x003CBB42
		public static void AddPlayerActiveFuncRangeEntity(FlatBufferBuilder builder, int playerActiveFuncRangeEntity)
		{
			builder.AddInt(0, playerActiveFuncRangeEntity, 0);
		}

		// Token: 0x0601AA72 RID: 109170 RVA: 0x003CD94D File Offset: 0x003CBB4D
		public static void AddAutoAbsorbRangeEntity(FlatBufferBuilder builder, int autoAbsorbRangeEntity)
		{
			builder.AddInt(1, autoAbsorbRangeEntity, 0);
		}

		// Token: 0x0601AA73 RID: 109171 RVA: 0x003CD958 File Offset: 0x003CBB58
		public static void AddIntervalKillNumber(FlatBufferBuilder builder, VectorOffset intervalKillNumberOffset)
		{
			builder.AddOffset(2, intervalKillNumberOffset.Value, 0);
		}

		// Token: 0x0601AA74 RID: 109172 RVA: 0x003CD968 File Offset: 0x003CBB68
		public static VectorOffset CreateIntervalKillNumberVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601AA75 RID: 109173 RVA: 0x003CD99F File Offset: 0x003CBB9F
		public static VectorOffset CreateIntervalKillNumberVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AA76 RID: 109174 RVA: 0x003CD9B9 File Offset: 0x003CBBB9
		public static VectorOffset CreateIntervalKillNumberVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601AA77 RID: 109175 RVA: 0x003CD9D7 File Offset: 0x003CBBD7
		public static VectorOffset CreateIntervalKillNumberVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601AA78 RID: 109176 RVA: 0x003CD9F0 File Offset: 0x003CBBF0
		public static void StartIntervalKillNumberVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601AA79 RID: 109177 RVA: 0x003CD9FB File Offset: 0x003CBBFB
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0601AA7A RID: 109178 RVA: 0x003CDA0E File Offset: 0x003CBC0E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601AA7B RID: 109179 RVA: 0x003CDA19 File Offset: 0x003CBC19
		public static Offset<IRangeAbsorbPhantom> EndIRangeAbsorbPhantom(FlatBufferBuilder builder)
		{
			return new Offset<IRangeAbsorbPhantom>(builder.EndTable());
		}

		// Token: 0x0601AA7C RID: 109180 RVA: 0x003CDA28 File Offset: 0x003CBC28
		public IRangeAbsorbPhantomT UnPack()
		{
			IRangeAbsorbPhantomT rangeAbsorbPhantomT = new IRangeAbsorbPhantomT();
			this.UnPackTo(rangeAbsorbPhantomT);
			return rangeAbsorbPhantomT;
		}

		// Token: 0x0601AA7D RID: 109181 RVA: 0x003CDA44 File Offset: 0x003CBC44
		public void UnPackTo(IRangeAbsorbPhantomT _o)
		{
			_o.PlayerActiveFuncRangeEntity = this.PlayerActiveFuncRangeEntity;
			_o.AutoAbsorbRangeEntity = this.AutoAbsorbRangeEntity;
			_o.IntervalKillNumber = new List<int>();
			for (int i = 0; i < this.IntervalKillNumberLength; i++)
			{
				_o.IntervalKillNumber.Add(this.IntervalKillNumber(i));
			}
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601AA7E RID: 109182 RVA: 0x003CDAB0 File Offset: 0x003CBCB0
		public static Offset<IRangeAbsorbPhantom> Pack(FlatBufferBuilder builder, IRangeAbsorbPhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeAbsorbPhantom>);
			}
			VectorOffset intervalKillNumberOffset = default(VectorOffset);
			if (_o.IntervalKillNumber != null)
			{
				int[] data = _o.IntervalKillNumber.ToArray();
				intervalKillNumberOffset = IRangeAbsorbPhantom.CreateIntervalKillNumberVector(builder, data);
			}
			return IRangeAbsorbPhantom.CreateIRangeAbsorbPhantom(builder, _o.PlayerActiveFuncRangeEntity, _o.AutoAbsorbRangeEntity, intervalKillNumberOffset, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x0400C5BC RID: 50620
		private Table __p;
	}
}
