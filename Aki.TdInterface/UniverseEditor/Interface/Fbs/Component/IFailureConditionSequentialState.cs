using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005225 RID: 21029
	public struct IFailureConditionSequentialState : IFlatbufferObject
	{
		// Token: 0x17009A03 RID: 39427
		// (get) Token: 0x060222DF RID: 139999 RVA: 0x004BDDAF File Offset: 0x004BBFAF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060222E0 RID: 140000 RVA: 0x004BDDBC File Offset: 0x004BBFBC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060222E1 RID: 140001 RVA: 0x004BDDC4 File Offset: 0x004BBFC4
		public static IFailureConditionSequentialState GetRootAsIFailureConditionSequentialState(ByteBuffer _bb)
		{
			return IFailureConditionSequentialState.GetRootAsIFailureConditionSequentialState(_bb, default(IFailureConditionSequentialState));
		}

		// Token: 0x060222E2 RID: 140002 RVA: 0x004BDDE0 File Offset: 0x004BBFE0
		public static IFailureConditionSequentialState GetRootAsIFailureConditionSequentialState(ByteBuffer _bb, IFailureConditionSequentialState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060222E3 RID: 140003 RVA: 0x004BDDFD File Offset: 0x004BBFFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060222E4 RID: 140004 RVA: 0x004BDE0C File Offset: 0x004BC00C
		public IFailureConditionSequentialState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A04 RID: 39428
		// (get) Token: 0x060222E5 RID: 140005 RVA: 0x004BDE1C File Offset: 0x004BC01C
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

		// Token: 0x060222E6 RID: 140006 RVA: 0x004BDE58 File Offset: 0x004BC058
		public int Order(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009A05 RID: 39429
		// (get) Token: 0x060222E7 RID: 140007 RVA: 0x004BDE98 File Offset: 0x004BC098
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

		// Token: 0x060222E8 RID: 140008 RVA: 0x004BDEC3 File Offset: 0x004BC0C3
		public Span<int> GetOrderBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060222E9 RID: 140009 RVA: 0x004BDED2 File Offset: 0x004BC0D2
		public int[] GetOrderArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060222EA RID: 140010 RVA: 0x004BDEE0 File Offset: 0x004BC0E0
		public static Offset<IFailureConditionSequentialState> CreateIFailureConditionSequentialState(FlatBufferBuilder builder, ETargetGearGroupFailureCondition Type = ETargetGearGroupFailureCondition.ArbitraryState, VectorOffset OrderOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFailureConditionSequentialState.AddOrder(builder, OrderOffset);
			IFailureConditionSequentialState.AddType(builder, Type);
			return IFailureConditionSequentialState.EndIFailureConditionSequentialState(builder);
		}

		// Token: 0x060222EB RID: 140011 RVA: 0x004BDEFD File Offset: 0x004BC0FD
		public static void StartIFailureConditionSequentialState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060222EC RID: 140012 RVA: 0x004BDF06 File Offset: 0x004BC106
		public static void AddType(FlatBufferBuilder builder, ETargetGearGroupFailureCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060222ED RID: 140013 RVA: 0x004BDF11 File Offset: 0x004BC111
		public static void AddOrder(FlatBufferBuilder builder, VectorOffset orderOffset)
		{
			builder.AddOffset(1, orderOffset.Value, 0);
		}

		// Token: 0x060222EE RID: 140014 RVA: 0x004BDF24 File Offset: 0x004BC124
		public static VectorOffset CreateOrderVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060222EF RID: 140015 RVA: 0x004BDF5B File Offset: 0x004BC15B
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060222F0 RID: 140016 RVA: 0x004BDF75 File Offset: 0x004BC175
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060222F1 RID: 140017 RVA: 0x004BDF93 File Offset: 0x004BC193
		public static VectorOffset CreateOrderVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060222F2 RID: 140018 RVA: 0x004BDFAC File Offset: 0x004BC1AC
		public static void StartOrderVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060222F3 RID: 140019 RVA: 0x004BDFB7 File Offset: 0x004BC1B7
		public static Offset<IFailureConditionSequentialState> EndIFailureConditionSequentialState(FlatBufferBuilder builder)
		{
			return new Offset<IFailureConditionSequentialState>(builder.EndTable());
		}

		// Token: 0x060222F4 RID: 140020 RVA: 0x004BDFC4 File Offset: 0x004BC1C4
		public IFailureConditionSequentialStateT UnPack()
		{
			IFailureConditionSequentialStateT failureConditionSequentialStateT = new IFailureConditionSequentialStateT();
			this.UnPackTo(failureConditionSequentialStateT);
			return failureConditionSequentialStateT;
		}

		// Token: 0x060222F5 RID: 140021 RVA: 0x004BDFE0 File Offset: 0x004BC1E0
		public void UnPackTo(IFailureConditionSequentialStateT _o)
		{
			_o.Type = this.Type;
			_o.Order = new List<int>();
			for (int i = 0; i < this.OrderLength; i++)
			{
				_o.Order.Add(this.Order(i));
			}
		}

		// Token: 0x060222F6 RID: 140022 RVA: 0x004BE028 File Offset: 0x004BC228
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

		// Token: 0x0400E360 RID: 58208
		private Table __p;
	}
}
