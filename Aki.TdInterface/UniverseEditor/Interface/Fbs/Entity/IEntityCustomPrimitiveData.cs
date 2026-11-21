using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C04 RID: 19460
	public struct IEntityCustomPrimitiveData : IFlatbufferObject
	{
		// Token: 0x170089CA RID: 35274
		// (get) Token: 0x0601DBE2 RID: 121826 RVA: 0x0042C260 File Offset: 0x0042A460
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DBE3 RID: 121827 RVA: 0x0042C26D File Offset: 0x0042A46D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DBE4 RID: 121828 RVA: 0x0042C274 File Offset: 0x0042A474
		public static IEntityCustomPrimitiveData GetRootAsIEntityCustomPrimitiveData(ByteBuffer _bb)
		{
			return IEntityCustomPrimitiveData.GetRootAsIEntityCustomPrimitiveData(_bb, default(IEntityCustomPrimitiveData));
		}

		// Token: 0x0601DBE5 RID: 121829 RVA: 0x0042C290 File Offset: 0x0042A490
		public static IEntityCustomPrimitiveData GetRootAsIEntityCustomPrimitiveData(ByteBuffer _bb, IEntityCustomPrimitiveData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DBE6 RID: 121830 RVA: 0x0042C2AD File Offset: 0x0042A4AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DBE7 RID: 121831 RVA: 0x0042C2BC File Offset: 0x0042A4BC
		public IEntityCustomPrimitiveData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170089CB RID: 35275
		// (get) Token: 0x0601DBE8 RID: 121832 RVA: 0x0042C2CC File Offset: 0x0042A4CC
		public int Id
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

		// Token: 0x0601DBE9 RID: 121833 RVA: 0x0042C308 File Offset: 0x0042A508
		public IEntityCustomPrimitiveData_CustomDataRow? CustomData(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCustomPrimitiveData_CustomDataRow?(default(IEntityCustomPrimitiveData_CustomDataRow).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170089CC RID: 35276
		// (get) Token: 0x0601DBEA RID: 121834 RVA: 0x0042C368 File Offset: 0x0042A568
		public int CustomDataLength
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

		// Token: 0x0601DBEB RID: 121835 RVA: 0x0042C393 File Offset: 0x0042A593
		public static Offset<IEntityCustomPrimitiveData> CreateIEntityCustomPrimitiveData(FlatBufferBuilder builder, int Id = 0, VectorOffset CustomDataOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEntityCustomPrimitiveData.AddCustomData(builder, CustomDataOffset);
			IEntityCustomPrimitiveData.AddId(builder, Id);
			return IEntityCustomPrimitiveData.EndIEntityCustomPrimitiveData(builder);
		}

		// Token: 0x0601DBEC RID: 121836 RVA: 0x0042C3B0 File Offset: 0x0042A5B0
		public static void StartIEntityCustomPrimitiveData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DBED RID: 121837 RVA: 0x0042C3B9 File Offset: 0x0042A5B9
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601DBEE RID: 121838 RVA: 0x0042C3C4 File Offset: 0x0042A5C4
		public static void AddCustomData(FlatBufferBuilder builder, VectorOffset customDataOffset)
		{
			builder.AddOffset(1, customDataOffset.Value, 0);
		}

		// Token: 0x0601DBEF RID: 121839 RVA: 0x0042C3D4 File Offset: 0x0042A5D4
		public static VectorOffset CreateCustomDataVector(FlatBufferBuilder builder, Offset<IEntityCustomPrimitiveData_CustomDataRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DBF0 RID: 121840 RVA: 0x0042C414 File Offset: 0x0042A614
		public static VectorOffset CreateCustomDataVectorBlock(FlatBufferBuilder builder, Offset<IEntityCustomPrimitiveData_CustomDataRow>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCustomPrimitiveData_CustomDataRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DBF1 RID: 121841 RVA: 0x0042C42E File Offset: 0x0042A62E
		public static VectorOffset CreateCustomDataVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCustomPrimitiveData_CustomDataRow>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCustomPrimitiveData_CustomDataRow>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DBF2 RID: 121842 RVA: 0x0042C44C File Offset: 0x0042A64C
		public static VectorOffset CreateCustomDataVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCustomPrimitiveData_CustomDataRow>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DBF3 RID: 121843 RVA: 0x0042C465 File Offset: 0x0042A665
		public static void StartCustomDataVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DBF4 RID: 121844 RVA: 0x0042C470 File Offset: 0x0042A670
		public static Offset<IEntityCustomPrimitiveData> EndIEntityCustomPrimitiveData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCustomPrimitiveData>(builder.EndTable());
		}

		// Token: 0x0601DBF5 RID: 121845 RVA: 0x0042C480 File Offset: 0x0042A680
		public IEntityCustomPrimitiveDataT UnPack()
		{
			IEntityCustomPrimitiveDataT entityCustomPrimitiveDataT = new IEntityCustomPrimitiveDataT();
			this.UnPackTo(entityCustomPrimitiveDataT);
			return entityCustomPrimitiveDataT;
		}

		// Token: 0x0601DBF6 RID: 121846 RVA: 0x0042C49C File Offset: 0x0042A69C
		public void UnPackTo(IEntityCustomPrimitiveDataT _o)
		{
			_o.Id = this.Id;
			_o.CustomData = new List<IEntityCustomPrimitiveData_CustomDataRowT>();
			for (int i = 0; i < this.CustomDataLength; i++)
			{
				_o.CustomData.Add((this.CustomData(i) != null) ? this.CustomData(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601DBF7 RID: 121847 RVA: 0x0042C508 File Offset: 0x0042A708
		public static Offset<IEntityCustomPrimitiveData> Pack(FlatBufferBuilder builder, IEntityCustomPrimitiveDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityCustomPrimitiveData>);
			}
			VectorOffset customDataOffset = default(VectorOffset);
			if (_o.CustomData != null)
			{
				Offset<IEntityCustomPrimitiveData_CustomDataRow>[] array = new Offset<IEntityCustomPrimitiveData_CustomDataRow>[_o.CustomData.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityCustomPrimitiveData_CustomDataRow.Pack(builder, _o.CustomData[i]);
				}
				customDataOffset = IEntityCustomPrimitiveData.CreateCustomDataVector(builder, array);
			}
			return IEntityCustomPrimitiveData.CreateIEntityCustomPrimitiveData(builder, _o.Id, customDataOffset);
		}

		// Token: 0x0400D641 RID: 54849
		private Table __p;
	}
}
