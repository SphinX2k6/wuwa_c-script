using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A6 RID: 28838
	public struct ILifePoint : IFlatbufferObject
	{
		// Token: 0x1700D33C RID: 54076
		// (get) Token: 0x0603210B RID: 205067 RVA: 0x006C6C88 File Offset: 0x006C4E88
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603210C RID: 205068 RVA: 0x006C6C95 File Offset: 0x006C4E95
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603210D RID: 205069 RVA: 0x006C6C9C File Offset: 0x006C4E9C
		public static ILifePoint GetRootAsILifePoint(ByteBuffer _bb)
		{
			return ILifePoint.GetRootAsILifePoint(_bb, default(ILifePoint));
		}

		// Token: 0x0603210E RID: 205070 RVA: 0x006C6CB8 File Offset: 0x006C4EB8
		public static ILifePoint GetRootAsILifePoint(ByteBuffer _bb, ILifePoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603210F RID: 205071 RVA: 0x006C6CD5 File Offset: 0x006C4ED5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032110 RID: 205072 RVA: 0x006C6CE4 File Offset: 0x006C4EE4
		public ILifePoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D33D RID: 54077
		// (get) Token: 0x06032111 RID: 205073 RVA: 0x006C6CF4 File Offset: 0x006C4EF4
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

		// Token: 0x1700D33E RID: 54078
		// (get) Token: 0x06032112 RID: 205074 RVA: 0x006C6D30 File Offset: 0x006C4F30
		public ILifePointColorBoard? ColorBoard
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ILifePointColorBoard?(default(ILifePointColorBoard).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700D33F RID: 54079
		// (get) Token: 0x06032113 RID: 205075 RVA: 0x006C6D90 File Offset: 0x006C4F90
		public int StepLimit
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D340 RID: 54080
		// (get) Token: 0x06032114 RID: 205076 RVA: 0x006C6DCC File Offset: 0x006C4FCC
		public string TidDesc
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032115 RID: 205077 RVA: 0x006C6E04 File Offset: 0x006C5004
		public Span<byte> GetTidDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06032116 RID: 205078 RVA: 0x006C6E14 File Offset: 0x006C5014
		public byte[] GetTidDescArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06032117 RID: 205079 RVA: 0x006C6E24 File Offset: 0x006C5024
		public ILifePointMaxStepRewardRuleItem? MaxStepRewardRule(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ILifePointMaxStepRewardRuleItem?(default(ILifePointMaxStepRewardRuleItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D341 RID: 54081
		// (get) Token: 0x06032118 RID: 205080 RVA: 0x006C6E88 File Offset: 0x006C5088
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

		// Token: 0x1700D342 RID: 54082
		// (get) Token: 0x06032119 RID: 205081 RVA: 0x006C6EB4 File Offset: 0x006C50B4
		public bool CloseUiAfterCompletion
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D343 RID: 54083
		// (get) Token: 0x0603211A RID: 205082 RVA: 0x006C6EF4 File Offset: 0x006C50F4
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

		// Token: 0x0603211B RID: 205083 RVA: 0x006C6F34 File Offset: 0x006C5134
		public static Offset<ILifePoint> CreateILifePoint(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, Offset<ILifePointColorBoard> ColorBoardOffset = default(Offset<ILifePointColorBoard>), int StepLimit = 0, StringOffset TidDescOffset = default(StringOffset), VectorOffset MaxStepRewardRuleOffset = default(VectorOffset), bool CloseUiAfterCompletion = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			ILifePoint.AddMaxStepRewardRule(builder, MaxStepRewardRuleOffset);
			ILifePoint.AddTidDesc(builder, TidDescOffset);
			ILifePoint.AddStepLimit(builder, StepLimit);
			ILifePoint.AddColorBoard(builder, ColorBoardOffset);
			ILifePoint.AddNullMask(builder, NullMask);
			ILifePoint.AddCloseUiAfterCompletion(builder, CloseUiAfterCompletion);
			ILifePoint.AddType(builder, Type);
			return ILifePoint.EndILifePoint(builder);
		}

		// Token: 0x0603211C RID: 205084 RVA: 0x006C6F83 File Offset: 0x006C5183
		public static void StartILifePoint(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0603211D RID: 205085 RVA: 0x006C6F8C File Offset: 0x006C518C
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603211E RID: 205086 RVA: 0x006C6F97 File Offset: 0x006C5197
		public static void AddColorBoard(FlatBufferBuilder builder, Offset<ILifePointColorBoard> colorBoardOffset)
		{
			builder.AddOffset(1, colorBoardOffset.Value, 0);
		}

		// Token: 0x0603211F RID: 205087 RVA: 0x006C6FA7 File Offset: 0x006C51A7
		public static void AddStepLimit(FlatBufferBuilder builder, int stepLimit)
		{
			builder.AddInt(2, stepLimit, 0);
		}

		// Token: 0x06032120 RID: 205088 RVA: 0x006C6FB2 File Offset: 0x006C51B2
		public static void AddTidDesc(FlatBufferBuilder builder, StringOffset tidDescOffset)
		{
			builder.AddOffset(3, tidDescOffset.Value, 0);
		}

		// Token: 0x06032121 RID: 205089 RVA: 0x006C6FC2 File Offset: 0x006C51C2
		public static void AddMaxStepRewardRule(FlatBufferBuilder builder, VectorOffset maxStepRewardRuleOffset)
		{
			builder.AddOffset(4, maxStepRewardRuleOffset.Value, 0);
		}

		// Token: 0x06032122 RID: 205090 RVA: 0x006C6FD4 File Offset: 0x006C51D4
		public static VectorOffset CreateMaxStepRewardRuleVector(FlatBufferBuilder builder, Offset<ILifePointMaxStepRewardRuleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06032123 RID: 205091 RVA: 0x006C7014 File Offset: 0x006C5214
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, Offset<ILifePointMaxStepRewardRuleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILifePointMaxStepRewardRuleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032124 RID: 205092 RVA: 0x006C702E File Offset: 0x006C522E
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILifePointMaxStepRewardRuleItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILifePointMaxStepRewardRuleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06032125 RID: 205093 RVA: 0x006C704C File Offset: 0x006C524C
		public static VectorOffset CreateMaxStepRewardRuleVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILifePointMaxStepRewardRuleItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06032126 RID: 205094 RVA: 0x006C7065 File Offset: 0x006C5265
		public static void StartMaxStepRewardRuleVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06032127 RID: 205095 RVA: 0x006C7070 File Offset: 0x006C5270
		public static void AddCloseUiAfterCompletion(FlatBufferBuilder builder, bool closeUiAfterCompletion)
		{
			builder.AddBool(5, closeUiAfterCompletion, false);
		}

		// Token: 0x06032128 RID: 205096 RVA: 0x006C707B File Offset: 0x006C527B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06032129 RID: 205097 RVA: 0x006C7086 File Offset: 0x006C5286
		public static Offset<ILifePoint> EndILifePoint(FlatBufferBuilder builder)
		{
			return new Offset<ILifePoint>(builder.EndTable());
		}

		// Token: 0x0603212A RID: 205098 RVA: 0x006C7094 File Offset: 0x006C5294
		public ILifePointT UnPack()
		{
			ILifePointT lifePointT = new ILifePointT();
			this.UnPackTo(lifePointT);
			return lifePointT;
		}

		// Token: 0x0603212B RID: 205099 RVA: 0x006C70B0 File Offset: 0x006C52B0
		public void UnPackTo(ILifePointT _o)
		{
			_o.Type = this.Type;
			_o.ColorBoard = ((this.ColorBoard != null) ? this.ColorBoard.Value.UnPack() : null);
			_o.StepLimit = this.StepLimit;
			_o.TidDesc = this.TidDesc;
			_o.MaxStepRewardRule = new List<ILifePointMaxStepRewardRuleItemT>();
			for (int i = 0; i < this.MaxStepRewardRuleLength; i++)
			{
				_o.MaxStepRewardRule.Add((this.MaxStepRewardRule(i) != null) ? this.MaxStepRewardRule(i).Value.UnPack() : null);
			}
			_o.CloseUiAfterCompletion = this.CloseUiAfterCompletion;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603212C RID: 205100 RVA: 0x006C717C File Offset: 0x006C537C
		public static Offset<ILifePoint> Pack(FlatBufferBuilder builder, ILifePointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILifePoint>);
			}
			Offset<ILifePointColorBoard> colorBoardOffset = (_o.ColorBoard == null) ? default(Offset<ILifePointColorBoard>) : ILifePointColorBoard.Pack(builder, _o.ColorBoard);
			StringOffset tidDescOffset = (_o.TidDesc == null) ? default(StringOffset) : builder.CreateString(_o.TidDesc);
			VectorOffset maxStepRewardRuleOffset = default(VectorOffset);
			if (_o.MaxStepRewardRule != null)
			{
				Offset<ILifePointMaxStepRewardRuleItem>[] array = new Offset<ILifePointMaxStepRewardRuleItem>[_o.MaxStepRewardRule.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILifePointMaxStepRewardRuleItem.Pack(builder, _o.MaxStepRewardRule[i]);
				}
				maxStepRewardRuleOffset = ILifePoint.CreateMaxStepRewardRuleVector(builder, array);
			}
			return ILifePoint.CreateILifePoint(builder, _o.Type, colorBoardOffset, _o.StepLimit, tidDescOffset, maxStepRewardRuleOffset, _o.CloseUiAfterCompletion, _o.NullMask);
		}

		// Token: 0x0401205B RID: 73819
		private Table __p;
	}
}
