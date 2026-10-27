using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742A RID: 29738
	public struct ITraceTracing : IFlatbufferObject
	{
		// Token: 0x1700E1C5 RID: 57797
		// (get) Token: 0x06036046 RID: 221254 RVA: 0x00758F4E File Offset: 0x0075714E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036047 RID: 221255 RVA: 0x00758F5B File Offset: 0x0075715B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036048 RID: 221256 RVA: 0x00758F64 File Offset: 0x00757164
		public static ITraceTracing GetRootAsITraceTracing(ByteBuffer _bb)
		{
			return ITraceTracing.GetRootAsITraceTracing(_bb, default(ITraceTracing));
		}

		// Token: 0x06036049 RID: 221257 RVA: 0x00758F80 File Offset: 0x00757180
		public static ITraceTracing GetRootAsITraceTracing(ByteBuffer _bb, ITraceTracing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603604A RID: 221258 RVA: 0x00758F9D File Offset: 0x0075719D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603604B RID: 221259 RVA: 0x00758FAC File Offset: 0x007571AC
		public ITraceTracing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1C6 RID: 57798
		// (get) Token: 0x0603604C RID: 221260 RVA: 0x00758FBC File Offset: 0x007571BC
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1C7 RID: 57799
		// (get) Token: 0x0603604D RID: 221261 RVA: 0x00758FF8 File Offset: 0x007571F8
		public ETraceTracingImageType ImageResourceType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETraceTracingImageType.None;
				}
				return (ETraceTracingImageType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E1C8 RID: 57800
		// (get) Token: 0x0603604E RID: 221262 RVA: 0x00759034 File Offset: 0x00757234
		public ITraceTracingGridBoard? BoardConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ITraceTracingGridBoard?(default(ITraceTracingGridBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E1C9 RID: 57801
		// (get) Token: 0x0603604F RID: 221263 RVA: 0x00759094 File Offset: 0x00757294
		public int StepLimit
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036050 RID: 221264 RVA: 0x007590D4 File Offset: 0x007572D4
		public ITraceTracingMaxStepRewardRuleItem? MaxStepRewardRule(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ITraceTracingMaxStepRewardRuleItem?(default(ITraceTracingMaxStepRewardRuleItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E1CA RID: 57802
		// (get) Token: 0x06036051 RID: 221265 RVA: 0x00759138 File Offset: 0x00757338
		public int MaxStepRewardRuleLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700E1CB RID: 57803
		// (get) Token: 0x06036052 RID: 221266 RVA: 0x00759164 File Offset: 0x00757364
		public bool RemainUiAfterCompletion
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E1CC RID: 57804
		// (get) Token: 0x06036053 RID: 221267 RVA: 0x007591A4 File Offset: 0x007573A4
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

		// Token: 0x06036054 RID: 221268 RVA: 0x007591E4 File Offset: 0x007573E4
		public static Offset<ITraceTracing> CreateITraceTracing(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, ETraceTracingImageType ImageResourceType = ETraceTracingImageType.None, Offset<ITraceTracingGridBoard> BoardConfigOffset = default(Offset<ITraceTracingGridBoard>), int StepLimit = 0, VectorOffset MaxStepRewardRuleOffset = default(VectorOffset), bool RemainUiAfterCompletion = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			ITraceTracing.AddMaxStepRewardRule(builder, MaxStepRewardRuleOffset);
			ITraceTracing.AddStepLimit(builder, StepLimit);
			ITraceTracing.AddBoardConfig(builder, BoardConfigOffset);
			ITraceTracing.AddNullMask(builder, NullMask);
			ITraceTracing.AddRemainUiAfterCompletion(builder, RemainUiAfterCompletion);
			ITraceTracing.AddImageResourceType(builder, ImageResourceType);
			ITraceTracing.AddType(builder, Type);
			return ITraceTracing.EndITraceTracing(builder);
		}

		// Token: 0x06036055 RID: 221269 RVA: 0x00759233 File Offset: 0x00757433
		public static void StartITraceTracing(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06036056 RID: 221270 RVA: 0x0075923C File Offset: 0x0075743C
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036057 RID: 221271 RVA: 0x00759247 File Offset: 0x00757447
		public static void AddImageResourceType(FlatBufferBuilder builder, ETraceTracingImageType imageResourceType)
		{
			builder.AddByte(1, (byte)imageResourceType, 0);
		}

		// Token: 0x06036058 RID: 221272 RVA: 0x00759252 File Offset: 0x00757452
		public static void AddBoardConfig(FlatBufferBuilder builder, Offset<ITraceTracingGridBoard> boardConfigOffset)
		{
			builder.AddOffset(2, boardConfigOffset.Value, 0);
		}

		// Token: 0x06036059 RID: 221273 RVA: 0x00759262 File Offset: 0x00757462
		public static void AddStepLimit(FlatBufferBuilder builder, int stepLimit)
		{
			builder.AddInt(3, stepLimit, 0);
		}

		// Token: 0x0603605A RID: 221274 RVA: 0x0075926D File Offset: 0x0075746D
		public static void AddMaxStepRewardRule(FlatBufferBuilder builder, VectorOffset maxStepRewardRuleOffset)
		{
			builder.AddOffset(4, maxStepRewardRuleOffset.Value, 0);
		}

		// Token: 0x0603605B RID: 221275 RVA: 0x00759280 File Offset: 0x00757480
		public static VectorOffset CreateMaxStepRewardRuleVector(FlatBufferBuilder builder, Offset<ITraceTracingMaxStepRewardRuleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603605C RID: 221276 RVA: 0x007592C0 File Offset: 0x007574C0
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, Offset<ITraceTracingMaxStepRewardRuleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITraceTracingMaxStepRewardRuleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603605D RID: 221277 RVA: 0x007592DA File Offset: 0x007574DA
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITraceTracingMaxStepRewardRuleItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITraceTracingMaxStepRewardRuleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603605E RID: 221278 RVA: 0x007592F8 File Offset: 0x007574F8
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITraceTracingMaxStepRewardRuleItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603605F RID: 221279 RVA: 0x00759311 File Offset: 0x00757511
		public static void StartMaxStepRewardRuleVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036060 RID: 221280 RVA: 0x0075931C File Offset: 0x0075751C
		public static void AddRemainUiAfterCompletion(FlatBufferBuilder builder, bool remainUiAfterCompletion)
		{
			builder.AddBool(5, remainUiAfterCompletion, false);
		}

		// Token: 0x06036061 RID: 221281 RVA: 0x00759327 File Offset: 0x00757527
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06036062 RID: 221282 RVA: 0x00759332 File Offset: 0x00757532
		public static Offset<ITraceTracing> EndITraceTracing(FlatBufferBuilder builder)
		{
			return new Offset<ITraceTracing>(builder.EndTable());
		}

		// Token: 0x06036063 RID: 221283 RVA: 0x00759340 File Offset: 0x00757540
		public ITraceTracingT UnPack()
		{
			ITraceTracingT traceTracingT = new ITraceTracingT();
			this.UnPackTo(traceTracingT);
			return traceTracingT;
		}

		// Token: 0x06036064 RID: 221284 RVA: 0x0075935C File Offset: 0x0075755C
		public void UnPackTo(ITraceTracingT _o)
		{
			_o.Type = this.Type;
			_o.ImageResourceType = this.ImageResourceType;
			_o.BoardConfig = ((this.BoardConfig != null) ? this.BoardConfig.Value.UnPack() : null);
			_o.StepLimit = this.StepLimit;
			_o.MaxStepRewardRule = new List<ITraceTracingMaxStepRewardRuleItemT>();
			for (int i = 0; i < this.MaxStepRewardRuleLength; i++)
			{
				_o.MaxStepRewardRule.Add((this.MaxStepRewardRule(i) != null) ? this.MaxStepRewardRule(i).Value.UnPack() : null);
			}
			_o.RemainUiAfterCompletion = this.RemainUiAfterCompletion;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06036065 RID: 221285 RVA: 0x00759428 File Offset: 0x00757628
		public static Offset<ITraceTracing> Pack(FlatBufferBuilder builder, ITraceTracingT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITraceTracing>);
			}
			Offset<ITraceTracingGridBoard> boardConfigOffset = (_o.BoardConfig == null) ? default(Offset<ITraceTracingGridBoard>) : ITraceTracingGridBoard.Pack(builder, _o.BoardConfig);
			VectorOffset maxStepRewardRuleOffset = default(VectorOffset);
			if (_o.MaxStepRewardRule != null)
			{
				Offset<ITraceTracingMaxStepRewardRuleItem>[] array = new Offset<ITraceTracingMaxStepRewardRuleItem>[_o.MaxStepRewardRule.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITraceTracingMaxStepRewardRuleItem.Pack(builder, _o.MaxStepRewardRule[i]);
				}
				maxStepRewardRuleOffset = ITraceTracing.CreateMaxStepRewardRuleVector(builder, array);
			}
			return ITraceTracing.CreateITraceTracing(builder, _o.Type, _o.ImageResourceType, boardConfigOffset, _o.StepLimit, maxStepRewardRuleOffset, _o.RemainUiAfterCompletion, _o.NullMask);
		}

		// Token: 0x0401229E RID: 74398
		private Table __p;
	}
}
