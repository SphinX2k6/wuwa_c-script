using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048DA RID: 18650
	public struct Record_Int_Strings : IFlatbufferObject
	{
		// Token: 0x17008764 RID: 34660
		// (get) Token: 0x0601D2B0 RID: 119472 RVA: 0x0041DFAB File Offset: 0x0041C1AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D2B1 RID: 119473 RVA: 0x0041DFB8 File Offset: 0x0041C1B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D2B2 RID: 119474 RVA: 0x0041DFC0 File Offset: 0x0041C1C0
		public static Record_Int_Strings GetRootAsRecord_Int_Strings(ByteBuffer _bb)
		{
			return Record_Int_Strings.GetRootAsRecord_Int_Strings(_bb, default(Record_Int_Strings));
		}

		// Token: 0x0601D2B3 RID: 119475 RVA: 0x0041DFDC File Offset: 0x0041C1DC
		public static Record_Int_Strings GetRootAsRecord_Int_Strings(ByteBuffer _bb, Record_Int_Strings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D2B4 RID: 119476 RVA: 0x0041DFF9 File Offset: 0x0041C1F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D2B5 RID: 119477 RVA: 0x0041E008 File Offset: 0x0041C208
		public Record_Int_Strings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008765 RID: 34661
		// (get) Token: 0x0601D2B6 RID: 119478 RVA: 0x0041E018 File Offset: 0x0041C218
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

		// Token: 0x0601D2B7 RID: 119479 RVA: 0x0041E054 File Offset: 0x0041C254
		public string Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008766 RID: 34662
		// (get) Token: 0x0601D2B8 RID: 119480 RVA: 0x0041E090 File Offset: 0x0041C290
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

		// Token: 0x0601D2B9 RID: 119481 RVA: 0x0041E0BB File Offset: 0x0041C2BB
		public static Offset<Record_Int_Strings> CreateRecord_Int_Strings(FlatBufferBuilder builder, int Key = 0, VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_Int_Strings.AddValues(builder, ValuesOffset);
			Record_Int_Strings.AddKey(builder, Key);
			return Record_Int_Strings.EndRecord_Int_Strings(builder);
		}

		// Token: 0x0601D2BA RID: 119482 RVA: 0x0041E0D8 File Offset: 0x0041C2D8
		public static void StartRecord_Int_Strings(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D2BB RID: 119483 RVA: 0x0041E0E1 File Offset: 0x0041C2E1
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601D2BC RID: 119484 RVA: 0x0041E0EC File Offset: 0x0041C2EC
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x0601D2BD RID: 119485 RVA: 0x0041E0FC File Offset: 0x0041C2FC
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D2BE RID: 119486 RVA: 0x0041E13C File Offset: 0x0041C33C
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D2BF RID: 119487 RVA: 0x0041E156 File Offset: 0x0041C356
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D2C0 RID: 119488 RVA: 0x0041E174 File Offset: 0x0041C374
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D2C1 RID: 119489 RVA: 0x0041E18D File Offset: 0x0041C38D
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D2C2 RID: 119490 RVA: 0x0041E198 File Offset: 0x0041C398
		public static Offset<Record_Int_Strings> EndRecord_Int_Strings(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_Strings>(builder.EndTable());
		}

		// Token: 0x0601D2C3 RID: 119491 RVA: 0x0041E1A8 File Offset: 0x0041C3A8
		public Record_Int_StringsT UnPack()
		{
			Record_Int_StringsT record_Int_StringsT = new Record_Int_StringsT();
			this.UnPackTo(record_Int_StringsT);
			return record_Int_StringsT;
		}

		// Token: 0x0601D2C4 RID: 119492 RVA: 0x0041E1C4 File Offset: 0x0041C3C4
		public void UnPackTo(Record_Int_StringsT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<string>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add(this.Values(i));
			}
		}

		// Token: 0x0601D2C5 RID: 119493 RVA: 0x0041E20C File Offset: 0x0041C40C
		public static Offset<Record_Int_Strings> Pack(FlatBufferBuilder builder, Record_Int_StringsT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_Strings>);
			}
			VectorOffset valuesOffset = default(VectorOffset);
			if (_o.Values != null)
			{
				StringOffset[] array = new StringOffset[_o.Values.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Values[i]);
				}
				valuesOffset = Record_Int_Strings.CreateValuesVector(builder, array);
			}
			return Record_Int_Strings.CreateRecord_Int_Strings(builder, _o.Key, valuesOffset);
		}

		// Token: 0x0400CEE4 RID: 52964
		private Table __p;
	}
}
