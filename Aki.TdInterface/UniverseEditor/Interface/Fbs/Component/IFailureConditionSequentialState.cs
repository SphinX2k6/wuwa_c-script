using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200578D RID: 22413
	public struct IFailureConditionSequentialState : IFlatbufferObject
	{
		// Token: 0x1700A1FF RID: 41471
		// (get) Token: 0x06024275 RID: 148085 RVA: 0x004F8873 File Offset: 0x004F6A73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024276 RID: 148086 RVA: 0x004F8880 File Offset: 0x004F6A80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024277 RID: 148087 RVA: 0x004F8888 File Offset: 0x004F6A88
		public static IFailureConditionSequentialState GetRootAsIFailureConditionSequentialState(ByteBuffer _bb)
		{
			return IFailureConditionSequentialState.GetRootAsIFailureConditionSequentialState(_bb, default(IFailureConditionSequentialState));
		}

		// Token: 0x06024278 RID: 148088 RVA: 0x004F88A4 File Offset: 0x004F6AA4
		public static IFailureConditionSequentialState GetRootAsIFailureConditionSequentialState(ByteBuffer _bb, IFailureConditionSequentialState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024279 RID: 148089 RVA: 0x004F88C1 File Offset: 0x004F6AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602427A RID: 148090 RVA: 0x004F88D0 File Offset: 0x004F6AD0
		public IFailureConditionSequentialState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A200 RID: 41472
		// (get) Token: 0x0602427B RID: 148091 RVA: 0x004F88E0 File Offset: 0x004F6AE0
		public ETargetGearGroupFailureCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetGearGroupFailureCondition.ArbitraryState;
				}
				return (ETargetGearGroupFailureCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602427C RID: 148092 RVA: 0x004F891C File Offset: 0x004F6B1C
		public int Order(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A201 RID: 41473
		// (get) Token: 0x0602427D RID: 148093 RVA: 0x004F895C File Offset: 0x004F6B5C
		public int OrderLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602427E RID: 148094 RVA: 0x004F8987 File Offset: 0x004F6B87
		public Span<int> GetOrderBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602427F RID: 148095 RVA: 0x004F8996 File Offset: 0x004F6B96
		public int[] GetOrderArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06024280 RID: 148096 RVA: 0x004F89A4 File Offset: 0x004F6BA4
		public static Offset<IFailureConditionSequentialState> CreateIFailureConditionSequentialState(FlatBufferBuilder builder, ETargetGearGroupFailureCondition Type = ETargetGearGroupFailureCondition.ArbitraryState, VectorOffset OrderOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFailureConditionSequentialState.AddOrder(builder, OrderOffset);
			IFailureConditionSequentialState.AddType(builder, Type);
			return IFailureConditionSequentialState.EndIFailureConditionSequentialState(builder);
		}

		// Token: 0x06024281 RID: 148097 RVA: 0x004F89C1 File Offset: 0x004F6BC1
		public static void StartIFailureConditionSequentialState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024282 RID: 148098 RVA: 0x004F89CA File Offset: 0x004F6BCA
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024283 RID: 148099 RVA: 0x004F89D5 File Offset: 0x004F6BD5
		public static void AddOrder(FlatBufferBuilder builder, VectorOffset orderOffset)
		{
			builder.AddOffset(1, orderOffset.Value, 0);
		}

		// Token: 0x06024284 RID: 148100 RVA: 0x004F89E8 File Offset: 0x004F6BE8
		public static VectorOffset CreateOrderVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06024285 RID: 148101 RVA: 0x004F8A1F File Offset: 0x004F6C1F
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024286 RID: 148102 RVA: 0x004F8A39 File Offset: 0x004F6C39
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06024287 RID: 148103 RVA: 0x004F8A57 File Offset: 0x004F6C57
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024288 RID: 148104 RVA: 0x004F8A70 File Offset: 0x004F6C70
		public static void StartOrderVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024289 RID: 148105 RVA: 0x004F8A7B File Offset: 0x004F6C7B
		public static Offset<IFailureConditionSequentialState> EndIFailureConditionSequentialState(FlatBufferBuilder builder)
		{
			return new Offset<IFailureConditionSequentialState>(builder.EndTable());
		}

		// Token: 0x0602428A RID: 148106 RVA: 0x004F8A88 File Offset: 0x004F6C88
		public IFailureConditionSequentialStateT UnPack()
		{
			IFailureConditionSequentialStateT failureConditionSequentialStateT = new IFailureConditionSequentialStateT();
			this.UnPackTo(failureConditionSequentialStateT);
			return failureConditionSequentialStateT;
		}

		// Token: 0x0602428B RID: 148107 RVA: 0x004F8AA4 File Offset: 0x004F6CA4
		public void UnPackTo(IFailureConditionSequentialStateT _o)
		{
			_o.Type = this.Type;
			_o.Order = new List<int>();
			for (int i = 0; i < this.OrderLength; i++)
			{
				_o.Order.Add(this.Order(i));
			}
		}

		// Token: 0x0602428C RID: 148108 RVA: 0x004F8AEC File Offset: 0x004F6CEC
		public static Offset<IFailureConditionSequentialState> Pack(FlatBufferBuilder builder, IFailureConditionSequentialStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailureConditionSequentialState>);
			}
			VectorOffset orderOffset = default(VectorOffset);
			if (_o.Order != null)
			{
				int[] data = _o.Order.ToArray();
				orderOffset = IFailureConditionSequentialState.CreateOrderVector(builder, data);
			}
			return IFailureConditionSequentialState.CreateIFailureConditionSequentialState(builder, _o.Type, orderOffset);
		}

		// Token: 0x0400EF66 RID: 61286
		private Table __p;
	}
}
