using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048D7 RID: 18647
	public struct Record_Int_Ints : IFlatbufferObject
	{
		// Token: 0x1700875F RID: 34655
		// (get) Token: 0x0601D292 RID: 119442 RVA: 0x0041DC7E File Offset: 0x0041BE7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D293 RID: 119443 RVA: 0x0041DC8B File Offset: 0x0041BE8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D294 RID: 119444 RVA: 0x0041DC94 File Offset: 0x0041BE94
		public static Record_Int_Ints GetRootAsRecord_Int_Ints(ByteBuffer _bb)
		{
			return Record_Int_Ints.GetRootAsRecord_Int_Ints(_bb, default(Record_Int_Ints));
		}

		// Token: 0x0601D295 RID: 119445 RVA: 0x0041DCB0 File Offset: 0x0041BEB0
		public static Record_Int_Ints GetRootAsRecord_Int_Ints(ByteBuffer _bb, Record_Int_Ints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D296 RID: 119446 RVA: 0x0041DCCD File Offset: 0x0041BECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D297 RID: 119447 RVA: 0x0041DCDC File Offset: 0x0041BEDC
		public Record_Int_Ints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008760 RID: 34656
		// (get) Token: 0x0601D298 RID: 119448 RVA: 0x0041DCEC File Offset: 0x0041BEEC
		public int Key
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

		// Token: 0x0601D299 RID: 119449 RVA: 0x0041DD28 File Offset: 0x0041BF28
		public int Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008761 RID: 34657
		// (get) Token: 0x0601D29A RID: 119450 RVA: 0x0041DD68 File Offset: 0x0041BF68
		public int ValuesLength
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

		// Token: 0x0601D29B RID: 119451 RVA: 0x0041DD93 File Offset: 0x0041BF93
		public Span<int> GetValuesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601D29C RID: 119452 RVA: 0x0041DDA2 File Offset: 0x0041BFA2
		public int[] GetValuesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601D29D RID: 119453 RVA: 0x0041DDB0 File Offset: 0x0041BFB0
		public static Offset<Record_Int_Ints> CreateRecord_Int_Ints(FlatBufferBuilder builder, int Key = 0, VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_Int_Ints.AddValues(builder, ValuesOffset);
			Record_Int_Ints.AddKey(builder, Key);
			return Record_Int_Ints.EndRecord_Int_Ints(builder);
		}

		// Token: 0x0601D29E RID: 119454 RVA: 0x0041DDCD File Offset: 0x0041BFCD
		public static void StartRecord_Int_Ints(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D29F RID: 119455 RVA: 0x0041DDD6 File Offset: 0x0041BFD6
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601D2A0 RID: 119456 RVA: 0x0041DDE1 File Offset: 0x0041BFE1
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x0601D2A1 RID: 119457 RVA: 0x0041DDF4 File Offset: 0x0041BFF4
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D2A2 RID: 119458 RVA: 0x0041DE2B File Offset: 0x0041C02B
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D2A3 RID: 119459 RVA: 0x0041DE45 File Offset: 0x0041C045
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D2A4 RID: 119460 RVA: 0x0041DE63 File Offset: 0x0041C063
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D2A5 RID: 119461 RVA: 0x0041DE7C File Offset: 0x0041C07C
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D2A6 RID: 119462 RVA: 0x0041DE87 File Offset: 0x0041C087
		public static Offset<Record_Int_Ints> EndRecord_Int_Ints(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_Ints>(builder.EndTable());
		}

		// Token: 0x0601D2A7 RID: 119463 RVA: 0x0041DE94 File Offset: 0x0041C094
		public Record_Int_IntsT UnPack()
		{
			Record_Int_IntsT record_Int_IntsT = new Record_Int_IntsT();
			this.UnPackTo(record_Int_IntsT);
			return record_Int_IntsT;
		}

		// Token: 0x0601D2A8 RID: 119464 RVA: 0x0041DEB0 File Offset: 0x0041C0B0
		public void UnPackTo(Record_Int_IntsT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<int>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add(this.Values(i));
			}
		}

		// Token: 0x0601D2A9 RID: 119465 RVA: 0x0041DEF8 File Offset: 0x0041C0F8
		public static Offset<Record_Int_Ints> Pack(FlatBufferBuilder builder, Record_Int_IntsT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_Ints>);
			}
			VectorOffset valuesOffset = default(VectorOffset);
			if (_o.Values != null)
			{
				int[] data = _o.Values.ToArray();
				valuesOffset = Record_Int_Ints.CreateValuesVector(builder, data);
			}
			return Record_Int_Ints.CreateRecord_Int_Ints(builder, _o.Key, valuesOffset);
		}

		// Token: 0x0400CEE1 RID: 52961
		private Table __p;
	}
}
