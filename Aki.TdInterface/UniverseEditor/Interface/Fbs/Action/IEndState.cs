using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1F RID: 27935
	public struct IEndState : IFlatbufferObject
	{
		// Token: 0x1700CCF0 RID: 52464
		// (get) Token: 0x060302D4 RID: 197332 RVA: 0x0068CF9D File Offset: 0x0068B19D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060302D5 RID: 197333 RVA: 0x0068CFAA File Offset: 0x0068B1AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060302D6 RID: 197334 RVA: 0x0068CFB4 File Offset: 0x0068B1B4
		public static IEndState GetRootAsIEndState(ByteBuffer _bb)
		{
			return IEndState.GetRootAsIEndState(_bb, default(IEndState));
		}

		// Token: 0x060302D7 RID: 197335 RVA: 0x0068CFD0 File Offset: 0x0068B1D0
		public static IEndState GetRootAsIEndState(ByteBuffer _bb, IEndState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060302D8 RID: 197336 RVA: 0x0068CFED File Offset: 0x0068B1ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060302D9 RID: 197337 RVA: 0x0068CFFC File Offset: 0x0068B1FC
		public IEndState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060302DA RID: 197338 RVA: 0x0068D00C File Offset: 0x0068B20C
		public int StayFlowMontageActors(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CCF1 RID: 52465
		// (get) Token: 0x060302DB RID: 197339 RVA: 0x0068D04C File Offset: 0x0068B24C
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

		// Token: 0x060302DC RID: 197340 RVA: 0x0068D077 File Offset: 0x0068B277
		public Span<int> GetStayFlowMontageActorsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x060302DD RID: 197341 RVA: 0x0068D086 File Offset: 0x0068B286
		public int[] GetStayFlowMontageActorsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700CCF2 RID: 52466
		// (get) Token: 0x060302DE RID: 197342 RVA: 0x0068D094 File Offset: 0x0068B294
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

		// Token: 0x060302DF RID: 197343 RVA: 0x0068D0D0 File Offset: 0x0068B2D0
		public static Offset<IEndState> CreateIEndState(FlatBufferBuilder builder, VectorOffset StayFlowMontageActorsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IEndState.AddStayFlowMontageActors(builder, StayFlowMontageActorsOffset);
			IEndState.AddNullMask(builder, NullMask);
			return IEndState.EndIEndState(builder);
		}

		// Token: 0x060302E0 RID: 197344 RVA: 0x0068D0ED File Offset: 0x0068B2ED
		public static void StartIEndState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060302E1 RID: 197345 RVA: 0x0068D0F6 File Offset: 0x0068B2F6
		public static void AddStayFlowMontageActors(FlatBufferBuilder builder, VectorOffset stayFlowMontageActorsOffset)
		{
			builder.AddOffset(0, stayFlowMontageActorsOffset.Value, 0);
		}

		// Token: 0x060302E2 RID: 197346 RVA: 0x0068D108 File Offset: 0x0068B308
		public static VectorOffset CreateStayFlowMontageActorsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060302E3 RID: 197347 RVA: 0x0068D13F File Offset: 0x0068B33F
		public static VectorOffset CreateStayFlowMontageActorsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060302E4 RID: 197348 RVA: 0x0068D159 File Offset: 0x0068B359
		public static VectorOffset CreateStayFlowMontageActorsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060302E5 RID: 197349 RVA: 0x0068D177 File Offset: 0x0068B377
		public static VectorOffset CreateStayFlowMontageActorsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060302E6 RID: 197350 RVA: 0x0068D190 File Offset: 0x0068B390
		public static void StartStayFlowMontageActorsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060302E7 RID: 197351 RVA: 0x0068D19B File Offset: 0x0068B39B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060302E8 RID: 197352 RVA: 0x0068D1A6 File Offset: 0x0068B3A6
		public static Offset<IEndState> EndIEndState(FlatBufferBuilder builder)
		{
			return new Offset<IEndState>(builder.EndTable());
		}

		// Token: 0x060302E9 RID: 197353 RVA: 0x0068D1B4 File Offset: 0x0068B3B4
		public IEndStateT UnPack()
		{
			IEndStateT endStateT = new IEndStateT();
			this.UnPackTo(endStateT);
			return endStateT;
		}

		// Token: 0x060302EA RID: 197354 RVA: 0x0068D1D0 File Offset: 0x0068B3D0
		public void UnPackTo(IEndStateT _o)
		{
			_o.StayFlowMontageActors = new List<int>();
			for (int i = 0; i < this.StayFlowMontageActorsLength; i++)
			{
				_o.StayFlowMontageActors.Add(this.StayFlowMontageActors(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060302EB RID: 197355 RVA: 0x0068D218 File Offset: 0x0068B418
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

		// Token: 0x04011B83 RID: 72579
		private Table __p;
	}
}
