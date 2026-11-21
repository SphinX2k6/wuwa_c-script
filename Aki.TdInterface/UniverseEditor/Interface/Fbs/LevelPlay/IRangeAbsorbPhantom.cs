using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049A1 RID: 18849
	public struct IRangeAbsorbPhantom : IFlatbufferObject
	{
		// Token: 0x170083ED RID: 33773
		// (get) Token: 0x0601C236 RID: 115254 RVA: 0x003F99B1 File Offset: 0x003F7BB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C237 RID: 115255 RVA: 0x003F99BE File Offset: 0x003F7BBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C238 RID: 115256 RVA: 0x003F99C8 File Offset: 0x003F7BC8
		public static IRangeAbsorbPhantom GetRootAsIRangeAbsorbPhantom(ByteBuffer _bb)
		{
			return IRangeAbsorbPhantom.GetRootAsIRangeAbsorbPhantom(_bb, default(IRangeAbsorbPhantom));
		}

		// Token: 0x0601C239 RID: 115257 RVA: 0x003F99E4 File Offset: 0x003F7BE4
		public static IRangeAbsorbPhantom GetRootAsIRangeAbsorbPhantom(ByteBuffer _bb, IRangeAbsorbPhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C23A RID: 115258 RVA: 0x003F9A01 File Offset: 0x003F7C01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C23B RID: 115259 RVA: 0x003F9A10 File Offset: 0x003F7C10
		public IRangeAbsorbPhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083EE RID: 33774
		// (get) Token: 0x0601C23C RID: 115260 RVA: 0x003F9A20 File Offset: 0x003F7C20
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

		// Token: 0x170083EF RID: 33775
		// (get) Token: 0x0601C23D RID: 115261 RVA: 0x003F9A5C File Offset: 0x003F7C5C
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

		// Token: 0x0601C23E RID: 115262 RVA: 0x003F9A98 File Offset: 0x003F7C98
		public int IntervalKillNumber(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170083F0 RID: 33776
		// (get) Token: 0x0601C23F RID: 115263 RVA: 0x003F9AD8 File Offset: 0x003F7CD8
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

		// Token: 0x0601C240 RID: 115264 RVA: 0x003F9B03 File Offset: 0x003F7D03
		public Span<int> GetIntervalKillNumberBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0601C241 RID: 115265 RVA: 0x003F9B12 File Offset: 0x003F7D12
		public int[] GetIntervalKillNumberArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x170083F1 RID: 33777
		// (get) Token: 0x0601C242 RID: 115266 RVA: 0x003F9B20 File Offset: 0x003F7D20
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

		// Token: 0x170083F2 RID: 33778
		// (get) Token: 0x0601C243 RID: 115267 RVA: 0x003F9B64 File Offset: 0x003F7D64
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

		// Token: 0x0601C244 RID: 115268 RVA: 0x003F9BA1 File Offset: 0x003F7DA1
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

		// Token: 0x0601C245 RID: 115269 RVA: 0x003F9BD5 File Offset: 0x003F7DD5
		public static void StartIRangeAbsorbPhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601C246 RID: 115270 RVA: 0x003F9BDE File Offset: 0x003F7DDE
		public static void AddPlayerActiveFuncRangeEntity(FlatBufferBuilder builder, int playerActiveFuncRangeEntity)
		{
			builder.AddInt(0, playerActiveFuncRangeEntity, 0);
		}

		// Token: 0x0601C247 RID: 115271 RVA: 0x003F9BE9 File Offset: 0x003F7DE9
		public static void AddAutoAbsorbRangeEntity(FlatBufferBuilder builder, int autoAbsorbRangeEntity)
		{
			builder.AddInt(1, autoAbsorbRangeEntity, 0);
		}

		// Token: 0x0601C248 RID: 115272 RVA: 0x003F9BF4 File Offset: 0x003F7DF4
		public static void AddIntervalKillNumber(FlatBufferBuilder builder, VectorOffset intervalKillNumberOffset)
		{
			builder.AddOffset(2, intervalKillNumberOffset.Value, 0);
		}

		// Token: 0x0601C249 RID: 115273 RVA: 0x003F9C04 File Offset: 0x003F7E04
		public static VectorOffset CreateIntervalKillNumberVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C24A RID: 115274 RVA: 0x003F9C3B File Offset: 0x003F7E3B
		public static VectorOffset CreateIntervalKillNumberVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C24B RID: 115275 RVA: 0x003F9C55 File Offset: 0x003F7E55
		public static VectorOffset CreateIntervalKillNumberVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C24C RID: 115276 RVA: 0x003F9C73 File Offset: 0x003F7E73
		public static VectorOffset CreateIntervalKillNumberVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C24D RID: 115277 RVA: 0x003F9C8C File Offset: 0x003F7E8C
		public static void StartIntervalKillNumberVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C24E RID: 115278 RVA: 0x003F9C97 File Offset: 0x003F7E97
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0601C24F RID: 115279 RVA: 0x003F9CAA File Offset: 0x003F7EAA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601C250 RID: 115280 RVA: 0x003F9CB5 File Offset: 0x003F7EB5
		public static Offset<IRangeAbsorbPhantom> EndIRangeAbsorbPhantom(FlatBufferBuilder builder)
		{
			return new Offset<IRangeAbsorbPhantom>(builder.EndTable());
		}

		// Token: 0x0601C251 RID: 115281 RVA: 0x003F9CC4 File Offset: 0x003F7EC4
		public IRangeAbsorbPhantomT UnPack()
		{
			IRangeAbsorbPhantomT rangeAbsorbPhantomT = new IRangeAbsorbPhantomT();
			this.UnPackTo(rangeAbsorbPhantomT);
			return rangeAbsorbPhantomT;
		}

		// Token: 0x0601C252 RID: 115282 RVA: 0x003F9CE0 File Offset: 0x003F7EE0
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

		// Token: 0x0601C253 RID: 115283 RVA: 0x003F9D4C File Offset: 0x003F7F4C
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

		// Token: 0x0400CFEB RID: 53227
		private Table __p;
	}
}
