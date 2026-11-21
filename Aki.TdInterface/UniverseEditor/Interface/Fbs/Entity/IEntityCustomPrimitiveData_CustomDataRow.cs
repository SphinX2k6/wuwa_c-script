using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C07 RID: 19463
	public struct IEntityCustomPrimitiveData_CustomDataRow : IFlatbufferObject
	{
		// Token: 0x170089CF RID: 35279
		// (get) Token: 0x0601DBFE RID: 121854 RVA: 0x0042C60C File Offset: 0x0042A80C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DBFF RID: 121855 RVA: 0x0042C619 File Offset: 0x0042A819
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC00 RID: 121856 RVA: 0x0042C620 File Offset: 0x0042A820
		public static IEntityCustomPrimitiveData_CustomDataRow GetRootAsIEntityCustomPrimitiveData_CustomDataRow(ByteBuffer _bb)
		{
			return IEntityCustomPrimitiveData_CustomDataRow.GetRootAsIEntityCustomPrimitiveData_CustomDataRow(_bb, default(IEntityCustomPrimitiveData_CustomDataRow));
		}

		// Token: 0x0601DC01 RID: 121857 RVA: 0x0042C63C File Offset: 0x0042A83C
		public static IEntityCustomPrimitiveData_CustomDataRow GetRootAsIEntityCustomPrimitiveData_CustomDataRow(ByteBuffer _bb, IEntityCustomPrimitiveData_CustomDataRow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC02 RID: 121858 RVA: 0x0042C659 File Offset: 0x0042A859
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC03 RID: 121859 RVA: 0x0042C668 File Offset: 0x0042A868
		public IEntityCustomPrimitiveData_CustomDataRow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601DC04 RID: 121860 RVA: 0x0042C678 File Offset: 0x0042A878
		public float Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170089D0 RID: 35280
		// (get) Token: 0x0601DC05 RID: 121861 RVA: 0x0042C6BC File Offset: 0x0042A8BC
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601DC06 RID: 121862 RVA: 0x0042C6E7 File Offset: 0x0042A8E7
		public Span<float> GetItemsBytes()
		{
			return this.__p.__vector_as_span<float>(4, 4);
		}

		// Token: 0x0601DC07 RID: 121863 RVA: 0x0042C6F6 File Offset: 0x0042A8F6
		public float[] GetItemsArray()
		{
			return this.__p.__vector_as_array<float>(4);
		}

		// Token: 0x0601DC08 RID: 121864 RVA: 0x0042C704 File Offset: 0x0042A904
		public static Offset<IEntityCustomPrimitiveData_CustomDataRow> CreateIEntityCustomPrimitiveData_CustomDataRow(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityCustomPrimitiveData_CustomDataRow.AddItems(builder, ItemsOffset);
			return IEntityCustomPrimitiveData_CustomDataRow.EndIEntityCustomPrimitiveData_CustomDataRow(builder);
		}

		// Token: 0x0601DC09 RID: 121865 RVA: 0x0042C71A File Offset: 0x0042A91A
		public static void StartIEntityCustomPrimitiveData_CustomDataRow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DC0A RID: 121866 RVA: 0x0042C723 File Offset: 0x0042A923
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0601DC0B RID: 121867 RVA: 0x0042C734 File Offset: 0x0042A934
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601DC0C RID: 121868 RVA: 0x0042C76B File Offset: 0x0042A96B
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC0D RID: 121869 RVA: 0x0042C785 File Offset: 0x0042A985
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0601DC0E RID: 121870 RVA: 0x0042C7A3 File Offset: 0x0042A9A3
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601DC0F RID: 121871 RVA: 0x0042C7BC File Offset: 0x0042A9BC
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601DC10 RID: 121872 RVA: 0x0042C7C7 File Offset: 0x0042A9C7
		public static Offset<IEntityCustomPrimitiveData_CustomDataRow> EndIEntityCustomPrimitiveData_CustomDataRow(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCustomPrimitiveData_CustomDataRow>(builder.EndTable());
		}

		// Token: 0x0601DC11 RID: 121873 RVA: 0x0042C7D4 File Offset: 0x0042A9D4
		public IEntityCustomPrimitiveData_CustomDataRowT UnPack()
		{
			IEntityCustomPrimitiveData_CustomDataRowT entityCustomPrimitiveData_CustomDataRowT = new IEntityCustomPrimitiveData_CustomDataRowT();
			this.UnPackTo(entityCustomPrimitiveData_CustomDataRowT);
			return entityCustomPrimitiveData_CustomDataRowT;
		}

		// Token: 0x0601DC12 RID: 121874 RVA: 0x0042C7F0 File Offset: 0x0042A9F0
		public void UnPackTo(IEntityCustomPrimitiveData_CustomDataRowT _o)
		{
			_o.Items = new List<float>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add(this.Items(i));
			}
		}

		// Token: 0x0601DC13 RID: 121875 RVA: 0x0042C82C File Offset: 0x0042AA2C
		public static Offset<IEntityCustomPrimitiveData_CustomDataRow> Pack(FlatBufferBuilder builder, IEntityCustomPrimitiveData_CustomDataRowT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityCustomPrimitiveData_CustomDataRow>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				float[] data = _o.Items.ToArray();
				itemsOffset = IEntityCustomPrimitiveData_CustomDataRow.CreateItemsVector(builder, data);
			}
			return IEntityCustomPrimitiveData_CustomDataRow.CreateIEntityCustomPrimitiveData_CustomDataRow(builder, itemsOffset);
		}

		// Token: 0x0400D644 RID: 54852
		private Table __p;
	}
}
