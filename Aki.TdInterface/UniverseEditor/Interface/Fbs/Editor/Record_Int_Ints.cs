using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D3C RID: 19772
	public struct Record_Int_Ints : IFlatbufferObject
	{
		// Token: 0x17008DA7 RID: 36263
		// (get) Token: 0x0601EA7F RID: 125567 RVA: 0x0044A41A File Offset: 0x0044861A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EA80 RID: 125568 RVA: 0x0044A427 File Offset: 0x00448627
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EA81 RID: 125569 RVA: 0x0044A430 File Offset: 0x00448630
		public static Record_Int_Ints GetRootAsRecord_Int_Ints(ByteBuffer _bb)
		{
			return Record_Int_Ints.GetRootAsRecord_Int_Ints(_bb, default(Record_Int_Ints));
		}

		// Token: 0x0601EA82 RID: 125570 RVA: 0x0044A44C File Offset: 0x0044864C
		public static Record_Int_Ints GetRootAsRecord_Int_Ints(ByteBuffer _bb, Record_Int_Ints obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EA83 RID: 125571 RVA: 0x0044A469 File Offset: 0x00448669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EA84 RID: 125572 RVA: 0x0044A478 File Offset: 0x00448678
		public Record_Int_Ints __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DA8 RID: 36264
		// (get) Token: 0x0601EA85 RID: 125573 RVA: 0x0044A488 File Offset: 0x00448688
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

		// Token: 0x0601EA86 RID: 125574 RVA: 0x0044A4C4 File Offset: 0x004486C4
		public int Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17008DA9 RID: 36265
		// (get) Token: 0x0601EA87 RID: 125575 RVA: 0x0044A504 File Offset: 0x00448704
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

		// Token: 0x0601EA88 RID: 125576 RVA: 0x0044A52F File Offset: 0x0044872F
		public Span<int> GetValuesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601EA89 RID: 125577 RVA: 0x0044A53E File Offset: 0x0044873E
		public int[] GetValuesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601EA8A RID: 125578 RVA: 0x0044A54C File Offset: 0x0044874C
		public static Offset<Record_Int_Ints> CreateRecord_Int_Ints(FlatBufferBuilder builder, int Key = 0, VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_Int_Ints.AddValues(builder, ValuesOffset);
			Record_Int_Ints.AddKey(builder, Key);
			return Record_Int_Ints.EndRecord_Int_Ints(builder);
		}

		// Token: 0x0601EA8B RID: 125579 RVA: 0x0044A569 File Offset: 0x00448769
		public static void StartRecord_Int_Ints(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EA8C RID: 125580 RVA: 0x0044A572 File Offset: 0x00448772
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0601EA8D RID: 125581 RVA: 0x0044A57D File Offset: 0x0044877D
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x0601EA8E RID: 125582 RVA: 0x0044A590 File Offset: 0x00448790
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601EA8F RID: 125583 RVA: 0x0044A5C7 File Offset: 0x004487C7
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EA90 RID: 125584 RVA: 0x0044A5E1 File Offset: 0x004487E1
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601EA91 RID: 125585 RVA: 0x0044A5FF File Offset: 0x004487FF
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601EA92 RID: 125586 RVA: 0x0044A618 File Offset: 0x00448818
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601EA93 RID: 125587 RVA: 0x0044A623 File Offset: 0x00448823
		public static Offset<Record_Int_Ints> EndRecord_Int_Ints(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_Ints>(builder.EndTable());
		}

		// Token: 0x0601EA94 RID: 125588 RVA: 0x0044A630 File Offset: 0x00448830
		public Record_Int_IntsT UnPack()
		{
			Record_Int_IntsT record_Int_IntsT = new Record_Int_IntsT();
			this.UnPackTo(record_Int_IntsT);
			return record_Int_IntsT;
		}

		// Token: 0x0601EA95 RID: 125589 RVA: 0x0044A64C File Offset: 0x0044884C
		public void UnPackTo(Record_Int_IntsT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<int>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add(this.Values(i));
			}
		}

		// Token: 0x0601EA96 RID: 125590 RVA: 0x0044A694 File Offset: 0x00448894
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

		// Token: 0x0400D91A RID: 55578
		private Table __p;
	}
}
