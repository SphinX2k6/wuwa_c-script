using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007625 RID: 30245
	public struct Record_String_Strings : IFlatbufferObject
	{
		// Token: 0x1700E5AA RID: 58794
		// (get) Token: 0x0603716C RID: 225644 RVA: 0x00778B5C File Offset: 0x00776D5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603716D RID: 225645 RVA: 0x00778B69 File Offset: 0x00776D69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603716E RID: 225646 RVA: 0x00778B70 File Offset: 0x00776D70
		public static Record_String_Strings GetRootAsRecord_String_Strings(ByteBuffer _bb)
		{
			return Record_String_Strings.GetRootAsRecord_String_Strings(_bb, default(Record_String_Strings));
		}

		// Token: 0x0603716F RID: 225647 RVA: 0x00778B8C File Offset: 0x00776D8C
		public static Record_String_Strings GetRootAsRecord_String_Strings(ByteBuffer _bb, Record_String_Strings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037170 RID: 225648 RVA: 0x00778BA9 File Offset: 0x00776DA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037171 RID: 225649 RVA: 0x00778BB8 File Offset: 0x00776DB8
		public Record_String_Strings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5AB RID: 58795
		// (get) Token: 0x06037172 RID: 225650 RVA: 0x00778BC8 File Offset: 0x00776DC8
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037173 RID: 225651 RVA: 0x00778BFF File Offset: 0x00776DFF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06037174 RID: 225652 RVA: 0x00778C0E File Offset: 0x00776E0E
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06037175 RID: 225653 RVA: 0x00778C1C File Offset: 0x00776E1C
		public string Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E5AC RID: 58796
		// (get) Token: 0x06037176 RID: 225654 RVA: 0x00778C58 File Offset: 0x00776E58
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

		// Token: 0x06037177 RID: 225655 RVA: 0x00778C83 File Offset: 0x00776E83
		public static Offset<Record_String_Strings> CreateRecord_String_Strings(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_String_Strings.AddValues(builder, ValuesOffset);
			Record_String_Strings.AddKey(builder, KeyOffset);
			return Record_String_Strings.EndRecord_String_Strings(builder);
		}

		// Token: 0x06037178 RID: 225656 RVA: 0x00778CA0 File Offset: 0x00776EA0
		public static void StartRecord_String_Strings(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037179 RID: 225657 RVA: 0x00778CA9 File Offset: 0x00776EA9
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0603717A RID: 225658 RVA: 0x00778CB9 File Offset: 0x00776EB9
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x0603717B RID: 225659 RVA: 0x00778CCC File Offset: 0x00776ECC
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603717C RID: 225660 RVA: 0x00778D0C File Offset: 0x00776F0C
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603717D RID: 225661 RVA: 0x00778D26 File Offset: 0x00776F26
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603717E RID: 225662 RVA: 0x00778D44 File Offset: 0x00776F44
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603717F RID: 225663 RVA: 0x00778D5D File Offset: 0x00776F5D
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06037180 RID: 225664 RVA: 0x00778D68 File Offset: 0x00776F68
		public static Offset<Record_String_Strings> EndRecord_String_Strings(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_Strings>(builder.EndTable());
		}

		// Token: 0x06037181 RID: 225665 RVA: 0x00778D78 File Offset: 0x00776F78
		public Record_String_StringsT UnPack()
		{
			Record_String_StringsT record_String_StringsT = new Record_String_StringsT();
			this.UnPackTo(record_String_StringsT);
			return record_String_StringsT;
		}

		// Token: 0x06037182 RID: 225666 RVA: 0x00778D94 File Offset: 0x00776F94
		public void UnPackTo(Record_String_StringsT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<string>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add(this.Values(i));
			}
		}

		// Token: 0x06037183 RID: 225667 RVA: 0x00778DDC File Offset: 0x00776FDC
		public static Offset<Record_String_Strings> Pack(FlatBufferBuilder builder, Record_String_StringsT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_String_Strings>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			VectorOffset valuesOffset = default(VectorOffset);
			if (_o.Values != null)
			{
				StringOffset[] array = new StringOffset[_o.Values.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Values[i]);
				}
				valuesOffset = Record_String_Strings.CreateValuesVector(builder, array);
			}
			return Record_String_Strings.CreateRecord_String_Strings(builder, keyOffset, valuesOffset);
		}

		// Token: 0x04012591 RID: 75153
		private Table __p;
	}
}
