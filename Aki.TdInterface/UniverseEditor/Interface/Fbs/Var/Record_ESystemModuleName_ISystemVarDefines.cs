using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F46 RID: 16198
	public struct Record_ESystemModuleName_ISystemVarDefines : IFlatbufferObject
	{
		// Token: 0x17006DAE RID: 28078
		// (get) Token: 0x06016073 RID: 90227 RVA: 0x00329DE5 File Offset: 0x00327FE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016074 RID: 90228 RVA: 0x00329DF2 File Offset: 0x00327FF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016075 RID: 90229 RVA: 0x00329DFC File Offset: 0x00327FFC
		public static Record_ESystemModuleName_ISystemVarDefines GetRootAsRecord_ESystemModuleName_ISystemVarDefines(ByteBuffer _bb)
		{
			return Record_ESystemModuleName_ISystemVarDefines.GetRootAsRecord_ESystemModuleName_ISystemVarDefines(_bb, default(Record_ESystemModuleName_ISystemVarDefines));
		}

		// Token: 0x06016076 RID: 90230 RVA: 0x00329E18 File Offset: 0x00328018
		public static Record_ESystemModuleName_ISystemVarDefines GetRootAsRecord_ESystemModuleName_ISystemVarDefines(ByteBuffer _bb, Record_ESystemModuleName_ISystemVarDefines obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016077 RID: 90231 RVA: 0x00329E35 File Offset: 0x00328035
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016078 RID: 90232 RVA: 0x00329E44 File Offset: 0x00328044
		public Record_ESystemModuleName_ISystemVarDefines __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DAF RID: 28079
		// (get) Token: 0x06016079 RID: 90233 RVA: 0x00329E54 File Offset: 0x00328054
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

		// Token: 0x0601607A RID: 90234 RVA: 0x00329E90 File Offset: 0x00328090
		public ISystemVarDefine? Values(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemVarDefine?(default(ISystemVarDefine).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006DB0 RID: 28080
		// (get) Token: 0x0601607B RID: 90235 RVA: 0x00329EF0 File Offset: 0x003280F0
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

		// Token: 0x0601607C RID: 90236 RVA: 0x00329F1B File Offset: 0x0032811B
		public static Offset<Record_ESystemModuleName_ISystemVarDefines> CreateRecord_ESystemModuleName_ISystemVarDefines(FlatBufferBuilder builder, ESystemModuleName Key = ESystemModuleName.Common, VectorOffset ValuesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			Record_ESystemModuleName_ISystemVarDefines.AddValues(builder, ValuesOffset);
			Record_ESystemModuleName_ISystemVarDefines.AddKey(builder, Key);
			return Record_ESystemModuleName_ISystemVarDefines.EndRecord_ESystemModuleName_ISystemVarDefines(builder);
		}

		// Token: 0x0601607D RID: 90237 RVA: 0x00329F38 File Offset: 0x00328138
		public static void StartRecord_ESystemModuleName_ISystemVarDefines(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601607E RID: 90238 RVA: 0x00329F41 File Offset: 0x00328141
		public static void AddKey(FlatBufferBuilder builder, ESystemModuleName key)
		{
			builder.AddByte(0, (byte)key, 0);
		}

		// Token: 0x0601607F RID: 90239 RVA: 0x00329F4C File Offset: 0x0032814C
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
			builder.AddOffset(1, valuesOffset.Value, 0);
		}

		// Token: 0x06016080 RID: 90240 RVA: 0x00329F5C File Offset: 0x0032815C
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, Offset<ISystemVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016081 RID: 90241 RVA: 0x00329F9C File Offset: 0x0032819C
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, Offset<ISystemVarDefine>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016082 RID: 90242 RVA: 0x00329FB6 File Offset: 0x003281B6
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemVarDefine>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemVarDefine>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016083 RID: 90243 RVA: 0x00329FD4 File Offset: 0x003281D4
		public static VectorOffset CreateValuesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemVarDefine>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016084 RID: 90244 RVA: 0x00329FED File Offset: 0x003281ED
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016085 RID: 90245 RVA: 0x00329FF8 File Offset: 0x003281F8
		public static Offset<Record_ESystemModuleName_ISystemVarDefines> EndRecord_ESystemModuleName_ISystemVarDefines(FlatBufferBuilder builder)
		{
			return new Offset<Record_ESystemModuleName_ISystemVarDefines>(builder.EndTable());
		}

		// Token: 0x06016086 RID: 90246 RVA: 0x0032A008 File Offset: 0x00328208
		public Record_ESystemModuleName_ISystemVarDefinesT UnPack()
		{
			Record_ESystemModuleName_ISystemVarDefinesT record_ESystemModuleName_ISystemVarDefinesT = new Record_ESystemModuleName_ISystemVarDefinesT();
			this.UnPackTo(record_ESystemModuleName_ISystemVarDefinesT);
			return record_ESystemModuleName_ISystemVarDefinesT;
		}

		// Token: 0x06016087 RID: 90247 RVA: 0x0032A024 File Offset: 0x00328224
		public void UnPackTo(Record_ESystemModuleName_ISystemVarDefinesT _o)
		{
			_o.Key = this.Key;
			_o.Values = new List<ISystemVarDefineT>();
			for (int i = 0; i < this.ValuesLength; i++)
			{
				_o.Values.Add((this.Values(i) != null) ? this.Values(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016088 RID: 90248 RVA: 0x0032A090 File Offset: 0x00328290
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

		// Token: 0x0400B992 RID: 47506
		private Table __p;
	}
}
