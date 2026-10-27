using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066A5 RID: 26277
	public struct IEndState : IFlatbufferObject
	{
		// Token: 0x1700C33F RID: 49983
		// (get) Token: 0x0602DAB7 RID: 187063 RVA: 0x0063FCE9 File Offset: 0x0063DEE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DAB8 RID: 187064 RVA: 0x0063FCF6 File Offset: 0x0063DEF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DAB9 RID: 187065 RVA: 0x0063FD00 File Offset: 0x0063DF00
		public static IEndState GetRootAsIEndState(ByteBuffer _bb)
		{
			return IEndState.GetRootAsIEndState(_bb, default(IEndState));
		}

		// Token: 0x0602DABA RID: 187066 RVA: 0x0063FD1C File Offset: 0x0063DF1C
		public static IEndState GetRootAsIEndState(ByteBuffer _bb, IEndState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DABB RID: 187067 RVA: 0x0063FD39 File Offset: 0x0063DF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DABC RID: 187068 RVA: 0x0063FD48 File Offset: 0x0063DF48
		public IEndState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602DABD RID: 187069 RVA: 0x0063FD58 File Offset: 0x0063DF58
		public int StayFlowMontageActors(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C340 RID: 49984
		// (get) Token: 0x0602DABE RID: 187070 RVA: 0x0063FD98 File Offset: 0x0063DF98
		public int StayFlowMontageActorsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602DABF RID: 187071 RVA: 0x0063FDC3 File Offset: 0x0063DFC3
		public Span<int> GetStayFlowMontageActorsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602DAC0 RID: 187072 RVA: 0x0063FDD2 File Offset: 0x0063DFD2
		public int[] GetStayFlowMontageActorsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700C341 RID: 49985
		// (get) Token: 0x0602DAC1 RID: 187073 RVA: 0x0063FDE0 File Offset: 0x0063DFE0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DAC2 RID: 187074 RVA: 0x0063FE1C File Offset: 0x0063E01C
		public static Offset<IEndState> CreateIEndState(FlatBufferBuilder builder, VectorOffset StayFlowMontageActorsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IEndState.AddStayFlowMontageActors(builder, StayFlowMontageActorsOffset);
			IEndState.AddNullMask(builder, NullMask);
			return IEndState.EndIEndState(builder);
		}

		// Token: 0x0602DAC3 RID: 187075 RVA: 0x0063FE39 File Offset: 0x0063E039
		public static void StartIEndState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DAC4 RID: 187076 RVA: 0x0063FE42 File Offset: 0x0063E042
		public static void AddStayFlowMontageActors(FlatBufferBuilder builder, VectorOffset stayFlowMontageActorsOffset)
		{
			builder.AddOffset(0, stayFlowMontageActorsOffset.Value, 0);
		}

		// Token: 0x0602DAC5 RID: 187077 RVA: 0x0063FE54 File Offset: 0x0063E054
		public static VectorOffset CreateStayFlowMontageActorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DAC6 RID: 187078 RVA: 0x0063FE8B File Offset: 0x0063E08B
		public static VectorOffset CreateStayFlowMontageActorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DAC7 RID: 187079 RVA: 0x0063FEA5 File Offset: 0x0063E0A5
		public static VectorOffset CreateStayFlowMontageActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DAC8 RID: 187080 RVA: 0x0063FEC3 File Offset: 0x0063E0C3
		public static VectorOffset CreateStayFlowMontageActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DAC9 RID: 187081 RVA: 0x0063FEDC File Offset: 0x0063E0DC
		public static void StartStayFlowMontageActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DACA RID: 187082 RVA: 0x0063FEE7 File Offset: 0x0063E0E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602DACB RID: 187083 RVA: 0x0063FEF2 File Offset: 0x0063E0F2
		public static Offset<IEndState> EndIEndState(FlatBufferBuilder builder)
		{
			return new Offset<IEndState>(builder.EndTable());
		}

		// Token: 0x0602DACC RID: 187084 RVA: 0x0063FF00 File Offset: 0x0063E100
		public IEndStateT UnPack()
		{
			IEndStateT endStateT = new IEndStateT();
			this.UnPackTo(endStateT);
			return endStateT;
		}

		// Token: 0x0602DACD RID: 187085 RVA: 0x0063FF1C File Offset: 0x0063E11C
		public void UnPackTo(IEndStateT _o)
		{
			_o.StayFlowMontageActors = new List<int>();
			for (int i = 0; i < this.StayFlowMontageActorsLength; i++)
			{
				_o.StayFlowMontageActors.Add(this.StayFlowMontageActors(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602DACE RID: 187086 RVA: 0x0063FF64 File Offset: 0x0063E164
		public static Offset<IEndState> Pack(FlatBufferBuilder builder, IEndStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEndState>);
			}
			VectorOffset stayFlowMontageActorsOffset = default(VectorOffset);
			if (_o.StayFlowMontageActors != null)
			{
				int[] data = _o.StayFlowMontageActors.ToArray();
				stayFlowMontageActorsOffset = IEndState.CreateStayFlowMontageActorsVector(builder, data);
			}
			return IEndState.CreateIEndState(builder, stayFlowMontageActorsOffset, _o.NullMask);
		}

		// Token: 0x04010D5D RID: 68957
		private Table __p;
	}
}
