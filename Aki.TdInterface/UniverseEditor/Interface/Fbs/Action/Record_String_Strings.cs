using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E33 RID: 32307
	public struct Record_String_Strings : IFlatbufferObject
	{
		// Token: 0x1700F1E8 RID: 61928
		// (get) Token: 0x0603A611 RID: 239121 RVA: 0x007DCC58 File Offset: 0x007DAE58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A612 RID: 239122 RVA: 0x007DCC65 File Offset: 0x007DAE65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A613 RID: 239123 RVA: 0x007DCC6C File Offset: 0x007DAE6C
		public static Record_String_Strings GetRootAsRecord_String_Strings(ByteBuffer _bb)
		{
			return Record_String_Strings.GetRootAsRecord_String_Strings(_bb, default(Record_String_Strings));
		}

		// Token: 0x0603A614 RID: 239124 RVA: 0x007DCC88 File Offset: 0x007DAE88
		public static Record_String_Strings GetRootAsRecord_String_Strings(ByteBuffer _bb, Record_String_Strings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A615 RID: 239125 RVA: 0x007DCCA5 File Offset: 0x007DAEA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A616 RID: 239126 RVA: 0x007DCCB4 File Offset: 0x007DAEB4
		public Record_String_Strings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1E9 RID: 61929
		// (get) Token: 0x0603A617 RID: 239127 RVA: 0x007DCCC4 File Offset: 0x007DAEC4
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

		// Token: 0x0603A618 RID: 239128 RVA: 0x007DCCFB File Offset: 0x007DAEFB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603A619 RID: 239129 RVA: 0x007DCD0A File Offset: 0x007DAF0A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0603A61A RID: 239130 RVA: 0x007DCD18 File Offset: 0x007DAF18
		public string Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700F1EA RID: 61930
		// (get) Token: 0x0603A61B RID: 239131 RVA: 0x007DCD54 File Offset: 0x007DAF54
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

		// Token: 0x0603A61C RID: 239132 RVA: 0x007DCD7F File Offset: 0x007DAF7F
		public static Offset<Record_String_Strings> CreateRecord_String_Strings(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_String_Strings.AddValues(builder, ValuesOffset);
			Record_String_Strings.AddKey(builder, KeyOffset);
			return Record_String_Strings.EndRecord_String_Strings(builder);
		}

		// Token: 0x0603A61D RID: 239133 RVA: 0x007DCD9C File Offset: 0x007DAF9C
		public static void StartRecord_String_Strings(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A61E RID: 239134 RVA: 0x007DCDA5 File Offset: 0x007DAFA5
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0603A61F RID: 239135 RVA: 0x007DCDB5 File Offset: 0x007DAFB5
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x0603A620 RID: 239136 RVA: 0x007DCDC8 File Offset: 0x007DAFC8
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603A621 RID: 239137 RVA: 0x007DCE08 File Offset: 0x007DB008
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603A622 RID: 239138 RVA: 0x007DCE22 File Offset: 0x007DB022
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603A623 RID: 239139 RVA: 0x007DCE40 File Offset: 0x007DB040
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603A624 RID: 239140 RVA: 0x007DCE59 File Offset: 0x007DB059
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603A625 RID: 239141 RVA: 0x007DCE64 File Offset: 0x007DB064
		public static Offset<Record_String_Strings> EndRecord_String_Strings(FlatBufferBuilder builder)
		{
			return new Offset<Record_String_Strings>(builder.EndTable());
		}

		// Token: 0x0603A626 RID: 239142 RVA: 0x007DCE74 File Offset: 0x007DB074
		public Record_String_StringsT UnPack()
		{
			Record_String_StringsT record_String_StringsT = new Record_String_StringsT();
			this.UnPackTo(record_String_StringsT);
			return record_String_StringsT;
		}

		// Token: 0x0603A627 RID: 239143 RVA: 0x007DCE90 File Offset: 0x007DB090
		public void UnPackTo(Record_String_StringsT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<string>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add(this.Values(i));
			}
		}

		// Token: 0x0603A628 RID: 239144 RVA: 0x007DCED8 File Offset: 0x007DB0D8
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

		// Token: 0x040135DB RID: 79323
		private Table __p;
	}
}
