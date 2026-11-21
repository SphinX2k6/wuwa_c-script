using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D3F RID: 19775
	public struct Record_Int_Strings : IFlatbufferObject
	{
		// Token: 0x17008DAC RID: 36268
		// (get) Token: 0x0601EA9D RID: 125597 RVA: 0x0044A747 File Offset: 0x00448947
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA9E RID: 125598 RVA: 0x0044A754 File Offset: 0x00448954
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA9F RID: 125599 RVA: 0x0044A75C File Offset: 0x0044895C
		public static Record_Int_Strings GetRootAsRecord_Int_Strings(ByteBuffer _bb)
		{
			return Record_Int_Strings.GetRootAsRecord_Int_Strings(_bb, default(Record_Int_Strings));
		}

		// Token: 0x0601EAA0 RID: 125600 RVA: 0x0044A778 File Offset: 0x00448978
		public static Record_Int_Strings GetRootAsRecord_Int_Strings(ByteBuffer _bb, Record_Int_Strings obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EAA1 RID: 125601 RVA: 0x0044A795 File Offset: 0x00448995
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EAA2 RID: 125602 RVA: 0x0044A7A4 File Offset: 0x004489A4
		public Record_Int_Strings __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DAD RID: 36269
		// (get) Token: 0x0601EAA3 RID: 125603 RVA: 0x0044A7B4 File Offset: 0x004489B4
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

		// Token: 0x0601EAA4 RID: 125604 RVA: 0x0044A7F0 File Offset: 0x004489F0
		public string Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008DAE RID: 36270
		// (get) Token: 0x0601EAA5 RID: 125605 RVA: 0x0044A82C File Offset: 0x00448A2C
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

		// Token: 0x0601EAA6 RID: 125606 RVA: 0x0044A857 File Offset: 0x00448A57
		public static Offset<Record_Int_Strings> CreateRecord_Int_Strings(FlatBufferBuilder builder, int Key = 0, VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_Int_Strings.AddValues(builder, ValuesOffset);
			Record_Int_Strings.AddKey(builder, Key);
			return Record_Int_Strings.EndRecord_Int_Strings(builder);
		}

		// Token: 0x0601EAA7 RID: 125607 RVA: 0x0044A874 File Offset: 0x00448A74
		public static void StartRecord_Int_Strings(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EAA8 RID: 125608 RVA: 0x0044A87D File Offset: 0x00448A7D
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601EAA9 RID: 125609 RVA: 0x0044A888 File Offset: 0x00448A88
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x0601EAAA RID: 125610 RVA: 0x0044A898 File Offset: 0x00448A98
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EAAB RID: 125611 RVA: 0x0044A8D8 File Offset: 0x00448AD8
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EAAC RID: 125612 RVA: 0x0044A8F2 File Offset: 0x00448AF2
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EAAD RID: 125613 RVA: 0x0044A910 File Offset: 0x00448B10
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EAAE RID: 125614 RVA: 0x0044A929 File Offset: 0x00448B29
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EAAF RID: 125615 RVA: 0x0044A934 File Offset: 0x00448B34
		public static Offset<Record_Int_Strings> EndRecord_Int_Strings(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_Strings>(builder.EndTable());
		}

		// Token: 0x0601EAB0 RID: 125616 RVA: 0x0044A944 File Offset: 0x00448B44
		public Record_Int_StringsT UnPack()
		{
			Record_Int_StringsT record_Int_StringsT = new Record_Int_StringsT();
			this.UnPackTo(record_Int_StringsT);
			return record_Int_StringsT;
		}

		// Token: 0x0601EAB1 RID: 125617 RVA: 0x0044A960 File Offset: 0x00448B60
		public void UnPackTo(Record_Int_StringsT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<string>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add(this.Values(i));
			}
		}

		// Token: 0x0601EAB2 RID: 125618 RVA: 0x0044A9A8 File Offset: 0x00448BA8
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

		// Token: 0x0400D91D RID: 55581
		private Table __p;
	}
}
