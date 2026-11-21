using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006065 RID: 24677
	public struct ITemplateMatrixRow : IFlatbufferObject
	{
		// Token: 0x1700B746 RID: 46918
		// (get) Token: 0x06029B08 RID: 170760 RVA: 0x005B1396 File Offset: 0x005AF596
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B09 RID: 170761 RVA: 0x005B13A3 File Offset: 0x005AF5A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B0A RID: 170762 RVA: 0x005B13AC File Offset: 0x005AF5AC
		public static ITemplateMatrixRow GetRootAsITemplateMatrixRow(ByteBuffer _bb)
		{
			return ITemplateMatrixRow.GetRootAsITemplateMatrixRow(_bb, default(ITemplateMatrixRow));
		}

		// Token: 0x06029B0B RID: 170763 RVA: 0x005B13C8 File Offset: 0x005AF5C8
		public static ITemplateMatrixRow GetRootAsITemplateMatrixRow(ByteBuffer _bb, ITemplateMatrixRow obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B0C RID: 170764 RVA: 0x005B13E5 File Offset: 0x005AF5E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B0D RID: 170765 RVA: 0x005B13F4 File Offset: 0x005AF5F4
		public ITemplateMatrixRow __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06029B0E RID: 170766 RVA: 0x005B1404 File Offset: 0x005AF604
		public ISpawnTemplateEntityConfig? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ISpawnTemplateEntityConfig?(default(ISpawnTemplateEntityConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B747 RID: 46919
		// (get) Token: 0x06029B0F RID: 170767 RVA: 0x005B1464 File Offset: 0x005AF664
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

		// Token: 0x06029B10 RID: 170768 RVA: 0x005B148F File Offset: 0x005AF68F
		public static Offset<ITemplateMatrixRow> CreateITemplateMatrixRow(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITemplateMatrixRow.AddItems(builder, ItemsOffset);
			return ITemplateMatrixRow.EndITemplateMatrixRow(builder);
		}

		// Token: 0x06029B11 RID: 170769 RVA: 0x005B14A5 File Offset: 0x005AF6A5
		public static void StartITemplateMatrixRow(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029B12 RID: 170770 RVA: 0x005B14AE File Offset: 0x005AF6AE
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x06029B13 RID: 170771 RVA: 0x005B14C0 File Offset: 0x005AF6C0
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<ISpawnTemplateEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06029B14 RID: 170772 RVA: 0x005B1500 File Offset: 0x005AF700
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<ISpawnTemplateEntityConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISpawnTemplateEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B15 RID: 170773 RVA: 0x005B151A File Offset: 0x005AF71A
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISpawnTemplateEntityConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISpawnTemplateEntityConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06029B16 RID: 170774 RVA: 0x005B1538 File Offset: 0x005AF738
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISpawnTemplateEntityConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029B17 RID: 170775 RVA: 0x005B1551 File Offset: 0x005AF751
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029B18 RID: 170776 RVA: 0x005B155C File Offset: 0x005AF75C
		public static Offset<ITemplateMatrixRow> EndITemplateMatrixRow(FlatBufferBuilder builder)
		{
			return new Offset<ITemplateMatrixRow>(builder.EndTable());
		}

		// Token: 0x06029B19 RID: 170777 RVA: 0x005B156C File Offset: 0x005AF76C
		public ITemplateMatrixRowT UnPack()
		{
			ITemplateMatrixRowT templateMatrixRowT = new ITemplateMatrixRowT();
			this.UnPackTo(templateMatrixRowT);
			return templateMatrixRowT;
		}

		// Token: 0x06029B1A RID: 170778 RVA: 0x005B1588 File Offset: 0x005AF788
		public void UnPackTo(ITemplateMatrixRowT _o)
		{
			_o.Items = new List<ISpawnTemplateEntityConfigT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029B1B RID: 170779 RVA: 0x005B15E8 File Offset: 0x005AF7E8
		public static Offset<ITemplateMatrixRow> Pack(FlatBufferBuilder builder, ITemplateMatrixRowT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITemplateMatrixRow>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<ISpawnTemplateEntityConfig>[] array = new Offset<ISpawnTemplateEntityConfig>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISpawnTemplateEntityConfig.Pack(builder, _o.Items[i]);
				}
				itemsOffset = ITemplateMatrixRow.CreateItemsVector(builder, array);
			}
			return ITemplateMatrixRow.CreateITemplateMatrixRow(builder, itemsOffset);
		}

		// Token: 0x0400FDE0 RID: 64992
		private Table __p;
	}
}
