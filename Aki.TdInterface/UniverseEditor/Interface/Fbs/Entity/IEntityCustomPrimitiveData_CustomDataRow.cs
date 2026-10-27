using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200479F RID: 18335
	public struct IEntityCustomPrimitiveData_CustomDataRow : IFlatbufferObject
	{
		// Token: 0x1700838E RID: 33678
		// (get) Token: 0x0601C429 RID: 115753 RVA: 0x00400370 File Offset: 0x003FE570
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C42A RID: 115754 RVA: 0x0040037D File Offset: 0x003FE57D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C42B RID: 115755 RVA: 0x00400384 File Offset: 0x003FE584
		public static IEntityCustomPrimitiveData_CustomDataRow GetRootAsIEntityCustomPrimitiveData_CustomDataRow(ByteBuffer _bb)
		{
			return IEntityCustomPrimitiveData_CustomDataRow.GetRootAsIEntityCustomPrimitiveData_CustomDataRow(_bb, default(IEntityCustomPrimitiveData_CustomDataRow));
		}

		// Token: 0x0601C42C RID: 115756 RVA: 0x004003A0 File Offset: 0x003FE5A0
		public static IEntityCustomPrimitiveData_CustomDataRow GetRootAsIEntityCustomPrimitiveData_CustomDataRow(ByteBuffer _bb, IEntityCustomPrimitiveData_CustomDataRow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C42D RID: 115757 RVA: 0x004003BD File Offset: 0x003FE5BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C42E RID: 115758 RVA: 0x004003CC File Offset: 0x003FE5CC
		public IEntityCustomPrimitiveData_CustomDataRow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C42F RID: 115759 RVA: 0x004003DC File Offset: 0x003FE5DC
		public float Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700838F RID: 33679
		// (get) Token: 0x0601C430 RID: 115760 RVA: 0x00400420 File Offset: 0x003FE620
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

		// Token: 0x0601C431 RID: 115761 RVA: 0x0040044B File Offset: 0x003FE64B
		public Span<float> GetItemsBytes()
		{
			return this.__p.__vector_as_span<float>(4, 4);
		}

		// Token: 0x0601C432 RID: 115762 RVA: 0x0040045A File Offset: 0x003FE65A
		public float[] GetItemsArray()
		{
			return this.__p.__vector_as_array<float>(4);
		}

		// Token: 0x0601C433 RID: 115763 RVA: 0x00400468 File Offset: 0x003FE668
		public static Offset<IEntityCustomPrimitiveData_CustomDataRow> CreateIEntityCustomPrimitiveData_CustomDataRow(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEntityCustomPrimitiveData_CustomDataRow.AddItems(builder, ItemsOffset);
			return IEntityCustomPrimitiveData_CustomDataRow.EndIEntityCustomPrimitiveData_CustomDataRow(builder);
		}

		// Token: 0x0601C434 RID: 115764 RVA: 0x0040047E File Offset: 0x003FE67E
		public static void StartIEntityCustomPrimitiveData_CustomDataRow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C435 RID: 115765 RVA: 0x00400487 File Offset: 0x003FE687
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x0601C436 RID: 115766 RVA: 0x00400498 File Offset: 0x003FE698
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddFloat(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C437 RID: 115767 RVA: 0x004004CF File Offset: 0x003FE6CF
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C438 RID: 115768 RVA: 0x004004E9 File Offset: 0x003FE6E9
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<float> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<float>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C439 RID: 115769 RVA: 0x00400507 File Offset: 0x003FE707
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<float>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C43A RID: 115770 RVA: 0x00400520 File Offset: 0x003FE720
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C43B RID: 115771 RVA: 0x0040052B File Offset: 0x003FE72B
		public static Offset<IEntityCustomPrimitiveData_CustomDataRow> EndIEntityCustomPrimitiveData_CustomDataRow(FlatBufferBuilder builder)
		{
			return new Offset<IEntityCustomPrimitiveData_CustomDataRow>(builder.EndTable());
		}

		// Token: 0x0601C43C RID: 115772 RVA: 0x00400538 File Offset: 0x003FE738
		public IEntityCustomPrimitiveData_CustomDataRowT UnPack()
		{
			IEntityCustomPrimitiveData_CustomDataRowT entityCustomPrimitiveData_CustomDataRowT = new IEntityCustomPrimitiveData_CustomDataRowT();
			this.UnPackTo(entityCustomPrimitiveData_CustomDataRowT);
			return entityCustomPrimitiveData_CustomDataRowT;
		}

		// Token: 0x0601C43D RID: 115773 RVA: 0x00400554 File Offset: 0x003FE754
		public void UnPackTo(IEntityCustomPrimitiveData_CustomDataRowT _o)
		{
			_o.Items = new List<float>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add(this.Items(i));
			}
		}

		// Token: 0x0601C43E RID: 115774 RVA: 0x00400590 File Offset: 0x003FE790
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

		// Token: 0x0400CC0E RID: 52238
		private Table __p;
	}
}
