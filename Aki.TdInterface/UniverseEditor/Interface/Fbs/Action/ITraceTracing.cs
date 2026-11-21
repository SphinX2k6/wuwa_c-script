using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C1D RID: 31773
	public struct ITraceTracing : IFlatbufferObject
	{
		// Token: 0x1700EDE2 RID: 60898
		// (get) Token: 0x0603942F RID: 234543 RVA: 0x007BBC7A File Offset: 0x007B9E7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039430 RID: 234544 RVA: 0x007BBC87 File Offset: 0x007B9E87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039431 RID: 234545 RVA: 0x007BBC90 File Offset: 0x007B9E90
		public static ITraceTracing GetRootAsITraceTracing(ByteBuffer _bb)
		{
			return ITraceTracing.GetRootAsITraceTracing(_bb, default(ITraceTracing));
		}

		// Token: 0x06039432 RID: 234546 RVA: 0x007BBCAC File Offset: 0x007B9EAC
		public static ITraceTracing GetRootAsITraceTracing(ByteBuffer _bb, ITraceTracing obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039433 RID: 234547 RVA: 0x007BBCC9 File Offset: 0x007B9EC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039434 RID: 234548 RVA: 0x007BBCD8 File Offset: 0x007B9ED8
		public ITraceTracing __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EDE3 RID: 60899
		// (get) Token: 0x06039435 RID: 234549 RVA: 0x007BBCE8 File Offset: 0x007B9EE8
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

		// Token: 0x1700EDE4 RID: 60900
		// (get) Token: 0x06039436 RID: 234550 RVA: 0x007BBD24 File Offset: 0x007B9F24
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

		// Token: 0x1700EDE5 RID: 60901
		// (get) Token: 0x06039437 RID: 234551 RVA: 0x007BBD60 File Offset: 0x007B9F60
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

		// Token: 0x1700EDE6 RID: 60902
		// (get) Token: 0x06039438 RID: 234552 RVA: 0x007BBDC0 File Offset: 0x007B9FC0
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

		// Token: 0x06039439 RID: 234553 RVA: 0x007BBE00 File Offset: 0x007BA000
		public ITraceTracingMaxStepRewardRuleItem? MaxStepRewardRule(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ITraceTracingMaxStepRewardRuleItem?(default(ITraceTracingMaxStepRewardRuleItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EDE7 RID: 60903
		// (get) Token: 0x0603943A RID: 234554 RVA: 0x007BBE64 File Offset: 0x007BA064
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

		// Token: 0x1700EDE8 RID: 60904
		// (get) Token: 0x0603943B RID: 234555 RVA: 0x007BBE90 File Offset: 0x007BA090
		public bool RemainUiAfterCompletion
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EDE9 RID: 60905
		// (get) Token: 0x0603943C RID: 234556 RVA: 0x007BBED0 File Offset: 0x007BA0D0
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

		// Token: 0x0603943D RID: 234557 RVA: 0x007BBF10 File Offset: 0x007BA110
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

		// Token: 0x0603943E RID: 234558 RVA: 0x007BBF5F File Offset: 0x007BA15F
		public static void StartITraceTracing(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603943F RID: 234559 RVA: 0x007BBF68 File Offset: 0x007BA168
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039440 RID: 234560 RVA: 0x007BBF73 File Offset: 0x007BA173
		public static void AddImageResourceType(FlatBufferBuilder builder, ETraceTracingImageType imageResourceType)
		{
			builder.AddByte(1, (byte)imageResourceType, 0);
		}

		// Token: 0x06039441 RID: 234561 RVA: 0x007BBF7E File Offset: 0x007BA17E
		public static void AddBoardConfig(FlatBufferBuilder builder, Offset<ITraceTracingGridBoard> boardConfigOffset)
		{
			builder.AddOffset(2, boardConfigOffset.Value, 0);
		}

		// Token: 0x06039442 RID: 234562 RVA: 0x007BBF8E File Offset: 0x007BA18E
		public static void AddStepLimit(FlatBufferBuilder builder, int stepLimit)
		{
			builder.AddInt(3, stepLimit, 0);
		}

		// Token: 0x06039443 RID: 234563 RVA: 0x007BBF99 File Offset: 0x007BA199
		public static void AddMaxStepRewardRule(FlatBufferBuilder builder, VectorOffset maxStepRewardRuleOffset)
		{
			builder.AddOffset(4, maxStepRewardRuleOffset.Value, 0);
		}

		// Token: 0x06039444 RID: 234564 RVA: 0x007BBFAC File Offset: 0x007BA1AC
		public static VectorOffset CreateMaxStepRewardRuleVector(FlatBufferBuilder builder, Offset<ITraceTracingMaxStepRewardRuleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06039445 RID: 234565 RVA: 0x007BBFEC File Offset: 0x007BA1EC
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, Offset<ITraceTracingMaxStepRewardRuleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITraceTracingMaxStepRewardRuleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06039446 RID: 234566 RVA: 0x007BC006 File Offset: 0x007BA206
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITraceTracingMaxStepRewardRuleItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITraceTracingMaxStepRewardRuleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06039447 RID: 234567 RVA: 0x007BC024 File Offset: 0x007BA224
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITraceTracingMaxStepRewardRuleItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06039448 RID: 234568 RVA: 0x007BC03D File Offset: 0x007BA23D
		public static void StartMaxStepRewardRuleVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06039449 RID: 234569 RVA: 0x007BC048 File Offset: 0x007BA248
		public static void AddRemainUiAfterCompletion(FlatBufferBuilder builder, bool remainUiAfterCompletion)
		{
			builder.AddBool(5, remainUiAfterCompletion, false);
		}

		// Token: 0x0603944A RID: 234570 RVA: 0x007BC053 File Offset: 0x007BA253
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0603944B RID: 234571 RVA: 0x007BC05E File Offset: 0x007BA25E
		public static Offset<ITraceTracing> EndITraceTracing(FlatBufferBuilder builder)
		{
			return new Offset<ITraceTracing>(builder.EndTable());
		}

		// Token: 0x0603944C RID: 234572 RVA: 0x007BC06C File Offset: 0x007BA26C
		public ITraceTracingT UnPack()
		{
			ITraceTracingT traceTracingT = new ITraceTracingT();
			this.UnPackTo(traceTracingT);
			return traceTracingT;
		}

		// Token: 0x0603944D RID: 234573 RVA: 0x007BC088 File Offset: 0x007BA288
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

		// Token: 0x0603944E RID: 234574 RVA: 0x007BC154 File Offset: 0x007BA354
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

		// Token: 0x040132C5 RID: 78533
		private Table __p;
	}
}
