using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007622 RID: 30242
	public struct Record_Int_ITalkSequenceTransitions : IFlatbufferObject
	{
		// Token: 0x1700E5A5 RID: 58789
		// (get) Token: 0x06037150 RID: 225616 RVA: 0x007787B0 File Offset: 0x007769B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037151 RID: 225617 RVA: 0x007787BD File Offset: 0x007769BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037152 RID: 225618 RVA: 0x007787C4 File Offset: 0x007769C4
		public static Record_Int_ITalkSequenceTransitions GetRootAsRecord_Int_ITalkSequenceTransitions(ByteBuffer _bb)
		{
			return Record_Int_ITalkSequenceTransitions.GetRootAsRecord_Int_ITalkSequenceTransitions(_bb, default(Record_Int_ITalkSequenceTransitions));
		}

		// Token: 0x06037153 RID: 225619 RVA: 0x007787E0 File Offset: 0x007769E0
		public static Record_Int_ITalkSequenceTransitions GetRootAsRecord_Int_ITalkSequenceTransitions(ByteBuffer _bb, Record_Int_ITalkSequenceTransitions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037154 RID: 225620 RVA: 0x007787FD File Offset: 0x007769FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037155 RID: 225621 RVA: 0x0077880C File Offset: 0x00776A0C
		public Record_Int_ITalkSequenceTransitions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E5A6 RID: 58790
		// (get) Token: 0x06037156 RID: 225622 RVA: 0x0077881C File Offset: 0x00776A1C
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

		// Token: 0x06037157 RID: 225623 RVA: 0x00778858 File Offset: 0x00776A58
		public ITalkSequenceTransition? Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITalkSequenceTransition?(default(ITalkSequenceTransition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E5A7 RID: 58791
		// (get) Token: 0x06037158 RID: 225624 RVA: 0x007788B8 File Offset: 0x00776AB8
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

		// Token: 0x06037159 RID: 225625 RVA: 0x007788E3 File Offset: 0x00776AE3
		public static Offset<Record_Int_ITalkSequenceTransitions> CreateRecord_Int_ITalkSequenceTransitions(FlatBufferBuilder builder, int Key = 0, VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_Int_ITalkSequenceTransitions.AddValues(builder, ValuesOffset);
			Record_Int_ITalkSequenceTransitions.AddKey(builder, Key);
			return Record_Int_ITalkSequenceTransitions.EndRecord_Int_ITalkSequenceTransitions(builder);
		}

		// Token: 0x0603715A RID: 225626 RVA: 0x00778900 File Offset: 0x00776B00
		public static void StartRecord_Int_ITalkSequenceTransitions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603715B RID: 225627 RVA: 0x00778909 File Offset: 0x00776B09
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0603715C RID: 225628 RVA: 0x00778914 File Offset: 0x00776B14
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x0603715D RID: 225629 RVA: 0x00778924 File Offset: 0x00776B24
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, Offset<ITalkSequenceTransition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603715E RID: 225630 RVA: 0x00778964 File Offset: 0x00776B64
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, Offset<ITalkSequenceTransition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkSequenceTransition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603715F RID: 225631 RVA: 0x0077897E File Offset: 0x00776B7E
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkSequenceTransition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkSequenceTransition>>(data);
			return builder.EndVector();
		}

		// Token: 0x06037160 RID: 225632 RVA: 0x0077899C File Offset: 0x00776B9C
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkSequenceTransition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06037161 RID: 225633 RVA: 0x007789B5 File Offset: 0x00776BB5
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06037162 RID: 225634 RVA: 0x007789C0 File Offset: 0x00776BC0
		public static Offset<Record_Int_ITalkSequenceTransitions> EndRecord_Int_ITalkSequenceTransitions(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_ITalkSequenceTransitions>(builder.EndTable());
		}

		// Token: 0x06037163 RID: 225635 RVA: 0x007789D0 File Offset: 0x00776BD0
		public Record_Int_ITalkSequenceTransitionsT UnPack()
		{
			Record_Int_ITalkSequenceTransitionsT record_Int_ITalkSequenceTransitionsT = new Record_Int_ITalkSequenceTransitionsT();
			this.UnPackTo(record_Int_ITalkSequenceTransitionsT);
			return record_Int_ITalkSequenceTransitionsT;
		}

		// Token: 0x06037164 RID: 225636 RVA: 0x007789EC File Offset: 0x00776BEC
		public void UnPackTo(Record_Int_ITalkSequenceTransitionsT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<ITalkSequenceTransitionT>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add((this.Values(i) != null) ? this.Values(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06037165 RID: 225637 RVA: 0x00778A58 File Offset: 0x00776C58
		public static Offset<Record_Int_ITalkSequenceTransitions> Pack(FlatBufferBuilder builder, Record_Int_ITalkSequenceTransitionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_Int_ITalkSequenceTransitions>);
			}
			VectorOffset valuesOffset = default(VectorOffset);
			if (_o.Values != null)
			{
				Offset<ITalkSequenceTransition>[] array = new Offset<ITalkSequenceTransition>[_o.Values.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ITalkSequenceTransition.Pack(builder, _o.Values[i]);
				}
				valuesOffset = Record_Int_ITalkSequenceTransitions.CreateValuesVector(builder, array);
			}
			return Record_Int_ITalkSequenceTransitions.CreateRecord_Int_ITalkSequenceTransitions(builder, _o.Key, valuesOffset);
		}

		// Token: 0x0401258E RID: 75150
		private Table __p;
	}
}
