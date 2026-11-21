using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E30 RID: 32304
	public struct Record_Int_ITalkSequenceTransitions : IFlatbufferObject
	{
		// Token: 0x1700F1E3 RID: 61923
		// (get) Token: 0x0603A5F5 RID: 239093 RVA: 0x007DC8AC File Offset: 0x007DAAAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A5F6 RID: 239094 RVA: 0x007DC8B9 File Offset: 0x007DAAB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A5F7 RID: 239095 RVA: 0x007DC8C0 File Offset: 0x007DAAC0
		public static Record_Int_ITalkSequenceTransitions GetRootAsRecord_Int_ITalkSequenceTransitions(ByteBuffer _bb)
		{
			return Record_Int_ITalkSequenceTransitions.GetRootAsRecord_Int_ITalkSequenceTransitions(_bb, default(Record_Int_ITalkSequenceTransitions));
		}

		// Token: 0x0603A5F8 RID: 239096 RVA: 0x007DC8DC File Offset: 0x007DAADC
		public static Record_Int_ITalkSequenceTransitions GetRootAsRecord_Int_ITalkSequenceTransitions(ByteBuffer _bb, Record_Int_ITalkSequenceTransitions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A5F9 RID: 239097 RVA: 0x007DC8F9 File Offset: 0x007DAAF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A5FA RID: 239098 RVA: 0x007DC908 File Offset: 0x007DAB08
		public Record_Int_ITalkSequenceTransitions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1E4 RID: 61924
		// (get) Token: 0x0603A5FB RID: 239099 RVA: 0x007DC918 File Offset: 0x007DAB18
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

		// Token: 0x0603A5FC RID: 239100 RVA: 0x007DC954 File Offset: 0x007DAB54
		public ITalkSequenceTransition? Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ITalkSequenceTransition?(default(ITalkSequenceTransition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700F1E5 RID: 61925
		// (get) Token: 0x0603A5FD RID: 239101 RVA: 0x007DC9B4 File Offset: 0x007DABB4
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

		// Token: 0x0603A5FE RID: 239102 RVA: 0x007DC9DF File Offset: 0x007DABDF
		public static Offset<Record_Int_ITalkSequenceTransitions> CreateRecord_Int_ITalkSequenceTransitions(FlatBufferBuilder builder, int Key = 0, VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_Int_ITalkSequenceTransitions.AddValues(builder, ValuesOffset);
			Record_Int_ITalkSequenceTransitions.AddKey(builder, Key);
			return Record_Int_ITalkSequenceTransitions.EndRecord_Int_ITalkSequenceTransitions(builder);
		}

		// Token: 0x0603A5FF RID: 239103 RVA: 0x007DC9FC File Offset: 0x007DABFC
		public static void StartRecord_Int_ITalkSequenceTransitions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603A600 RID: 239104 RVA: 0x007DCA05 File Offset: 0x007DAC05
		public static void AddKey(FlatBufferBuilder builder, int key)
		{
			builder.AddInt(0, key, 0);
		}

		// Token: 0x0603A601 RID: 239105 RVA: 0x007DCA10 File Offset: 0x007DAC10
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x0603A602 RID: 239106 RVA: 0x007DCA20 File Offset: 0x007DAC20
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, Offset<ITalkSequenceTransition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603A603 RID: 239107 RVA: 0x007DCA60 File Offset: 0x007DAC60
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, Offset<ITalkSequenceTransition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ITalkSequenceTransition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603A604 RID: 239108 RVA: 0x007DCA7A File Offset: 0x007DAC7A
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ITalkSequenceTransition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ITalkSequenceTransition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603A605 RID: 239109 RVA: 0x007DCA98 File Offset: 0x007DAC98
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ITalkSequenceTransition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603A606 RID: 239110 RVA: 0x007DCAB1 File Offset: 0x007DACB1
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603A607 RID: 239111 RVA: 0x007DCABC File Offset: 0x007DACBC
		public static Offset<Record_Int_ITalkSequenceTransitions> EndRecord_Int_ITalkSequenceTransitions(FlatBufferBuilder builder)
		{
			return new Offset<Record_Int_ITalkSequenceTransitions>(builder.EndTable());
		}

		// Token: 0x0603A608 RID: 239112 RVA: 0x007DCACC File Offset: 0x007DACCC
		public Record_Int_ITalkSequenceTransitionsT UnPack()
		{
			Record_Int_ITalkSequenceTransitionsT record_Int_ITalkSequenceTransitionsT = new Record_Int_ITalkSequenceTransitionsT();
			this.UnPackTo(record_Int_ITalkSequenceTransitionsT);
			return record_Int_ITalkSequenceTransitionsT;
		}

		// Token: 0x0603A609 RID: 239113 RVA: 0x007DCAE8 File Offset: 0x007DACE8
		public void UnPackTo(Record_Int_ITalkSequenceTransitionsT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<ITalkSequenceTransitionT>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add((this.Values(i) != null) ? this.Values(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603A60A RID: 239114 RVA: 0x007DCB54 File Offset: 0x007DAD54
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

		// Token: 0x040135D8 RID: 79320
		private Table __p;
	}
}
