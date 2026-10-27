using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B44 RID: 15172
	public struct Record_ESystemModuleName_ISystemVarDefines : IFlatbufferObject
	{
		// Token: 0x17006813 RID: 26643
		// (get) Token: 0x06014BC9 RID: 84937 RVA: 0x00303B55 File Offset: 0x00301D55
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014BCA RID: 84938 RVA: 0x00303B62 File Offset: 0x00301D62
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014BCB RID: 84939 RVA: 0x00303B6C File Offset: 0x00301D6C
		public static Record_ESystemModuleName_ISystemVarDefines GetRootAsRecord_ESystemModuleName_ISystemVarDefines(ByteBuffer _bb)
		{
			return Record_ESystemModuleName_ISystemVarDefines.GetRootAsRecord_ESystemModuleName_ISystemVarDefines(_bb, default(Record_ESystemModuleName_ISystemVarDefines));
		}

		// Token: 0x06014BCC RID: 84940 RVA: 0x00303B88 File Offset: 0x00301D88
		public static Record_ESystemModuleName_ISystemVarDefines GetRootAsRecord_ESystemModuleName_ISystemVarDefines(ByteBuffer _bb, Record_ESystemModuleName_ISystemVarDefines obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014BCD RID: 84941 RVA: 0x00303BA5 File Offset: 0x00301DA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014BCE RID: 84942 RVA: 0x00303BB4 File Offset: 0x00301DB4
		public Record_ESystemModuleName_ISystemVarDefines __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006814 RID: 26644
		// (get) Token: 0x06014BCF RID: 84943 RVA: 0x00303BC4 File Offset: 0x00301DC4
		public ESystemModuleName Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemModuleName.Common;
				}
				return (ESystemModuleName)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014BD0 RID: 84944 RVA: 0x00303C00 File Offset: 0x00301E00
		public ISystemVarDefine? Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemVarDefine?(default(ISystemVarDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006815 RID: 26645
		// (get) Token: 0x06014BD1 RID: 84945 RVA: 0x00303C60 File Offset: 0x00301E60
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

		// Token: 0x06014BD2 RID: 84946 RVA: 0x00303C8B File Offset: 0x00301E8B
		public static Offset<Record_ESystemModuleName_ISystemVarDefines> CreateRecord_ESystemModuleName_ISystemVarDefines(FlatBufferBuilder builder, ESystemModuleName Key = ESystemModuleName.Common, VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_ESystemModuleName_ISystemVarDefines.AddValues(builder, ValuesOffset);
			Record_ESystemModuleName_ISystemVarDefines.AddKey(builder, Key);
			return Record_ESystemModuleName_ISystemVarDefines.EndRecord_ESystemModuleName_ISystemVarDefines(builder);
		}

		// Token: 0x06014BD3 RID: 84947 RVA: 0x00303CA8 File Offset: 0x00301EA8
		public static void StartRecord_ESystemModuleName_ISystemVarDefines(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014BD4 RID: 84948 RVA: 0x00303CB1 File Offset: 0x00301EB1
		public static void AddKey(FlatBufferBuilder builder, ESystemModuleName key)
		{
			builder.AddByte(0, (byte)key, 0);
		}

		// Token: 0x06014BD5 RID: 84949 RVA: 0x00303CBC File Offset: 0x00301EBC
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x06014BD6 RID: 84950 RVA: 0x00303CCC File Offset: 0x00301ECC
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, Offset<ISystemVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06014BD7 RID: 84951 RVA: 0x00303D0C File Offset: 0x00301F0C
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, Offset<ISystemVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014BD8 RID: 84952 RVA: 0x00303D26 File Offset: 0x00301F26
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemVarDefine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06014BD9 RID: 84953 RVA: 0x00303D44 File Offset: 0x00301F44
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemVarDefine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06014BDA RID: 84954 RVA: 0x00303D5D File Offset: 0x00301F5D
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06014BDB RID: 84955 RVA: 0x00303D68 File Offset: 0x00301F68
		public static Offset<Record_ESystemModuleName_ISystemVarDefines> EndRecord_ESystemModuleName_ISystemVarDefines(FlatBufferBuilder builder)
		{
			return new Offset<Record_ESystemModuleName_ISystemVarDefines>(builder.EndTable());
		}

		// Token: 0x06014BDC RID: 84956 RVA: 0x00303D78 File Offset: 0x00301F78
		public Record_ESystemModuleName_ISystemVarDefinesT UnPack()
		{
			Record_ESystemModuleName_ISystemVarDefinesT record_ESystemModuleName_ISystemVarDefinesT = new Record_ESystemModuleName_ISystemVarDefinesT();
			this.UnPackTo(record_ESystemModuleName_ISystemVarDefinesT);
			return record_ESystemModuleName_ISystemVarDefinesT;
		}

		// Token: 0x06014BDD RID: 84957 RVA: 0x00303D94 File Offset: 0x00301F94
		public void UnPackTo(Record_ESystemModuleName_ISystemVarDefinesT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<ISystemVarDefineT>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add((this.Values(i) != null) ? this.Values(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06014BDE RID: 84958 RVA: 0x00303E00 File Offset: 0x00302000
		public static Offset<Record_ESystemModuleName_ISystemVarDefines> Pack(FlatBufferBuilder builder, Record_ESystemModuleName_ISystemVarDefinesT _o)
		{
			if (_o == null)
			{
				return default(Offset<Record_ESystemModuleName_ISystemVarDefines>);
			}
			VectorOffset valuesOffset = default(VectorOffset);
			if (_o.Values != null)
			{
				Offset<ISystemVarDefine>[] array = new Offset<ISystemVarDefine>[_o.Values.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISystemVarDefine.Pack(builder, _o.Values[i]);
				}
				valuesOffset = Record_ESystemModuleName_ISystemVarDefines.CreateValuesVector(builder, array);
			}
			return Record_ESystemModuleName_ISystemVarDefines.CreateRecord_ESystemModuleName_ISystemVarDefines(builder, _o.Key, valuesOffset);
		}

		// Token: 0x0400B025 RID: 45093
		private Table __p;
	}
}
