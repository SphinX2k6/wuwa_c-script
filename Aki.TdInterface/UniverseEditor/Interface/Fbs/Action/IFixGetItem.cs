using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E57 RID: 28247
	public struct IFixGetItem : IFlatbufferObject
	{
		// Token: 0x1700CF0A RID: 53002
		// (get) Token: 0x06030CB0 RID: 199856 RVA: 0x0069F1A6 File Offset: 0x0069D3A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030CB1 RID: 199857 RVA: 0x0069F1B3 File Offset: 0x0069D3B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030CB2 RID: 199858 RVA: 0x0069F1BC File Offset: 0x0069D3BC
		public static IFixGetItem GetRootAsIFixGetItem(ByteBuffer _bb)
		{
			return IFixGetItem.GetRootAsIFixGetItem(_bb, default(IFixGetItem));
		}

		// Token: 0x06030CB3 RID: 199859 RVA: 0x0069F1D8 File Offset: 0x0069D3D8
		public static IFixGetItem GetRootAsIFixGetItem(ByteBuffer _bb, IFixGetItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030CB4 RID: 199860 RVA: 0x0069F1F5 File Offset: 0x0069D3F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030CB5 RID: 199861 RVA: 0x0069F204 File Offset: 0x0069D404
		public IFixGetItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06030CB6 RID: 199862 RVA: 0x0069F214 File Offset: 0x0069D414
		public IItemData? Items(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IItemData?(default(IItemData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CF0B RID: 53003
		// (get) Token: 0x06030CB7 RID: 199863 RVA: 0x0069F274 File Offset: 0x0069D474
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

		// Token: 0x06030CB8 RID: 199864 RVA: 0x0069F29F File Offset: 0x0069D49F
		public static Offset<IFixGetItem> CreateIFixGetItem(FlatBufferBuilder builder, VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IFixGetItem.AddItems(builder, ItemsOffset);
			return IFixGetItem.EndIFixGetItem(builder);
		}

		// Token: 0x06030CB9 RID: 199865 RVA: 0x0069F2B5 File Offset: 0x0069D4B5
		public static void StartIFixGetItem(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030CBA RID: 199866 RVA: 0x0069F2BE File Offset: 0x0069D4BE
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(0, itemsOffset.Value, 0);
		}

		// Token: 0x06030CBB RID: 199867 RVA: 0x0069F2D0 File Offset: 0x0069D4D0
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030CBC RID: 199868 RVA: 0x0069F310 File Offset: 0x0069D510
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030CBD RID: 199869 RVA: 0x0069F32A File Offset: 0x0069D52A
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030CBE RID: 199870 RVA: 0x0069F348 File Offset: 0x0069D548
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030CBF RID: 199871 RVA: 0x0069F361 File Offset: 0x0069D561
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030CC0 RID: 199872 RVA: 0x0069F36C File Offset: 0x0069D56C
		public static Offset<IFixGetItem> EndIFixGetItem(FlatBufferBuilder builder)
		{
			return new Offset<IFixGetItem>(builder.EndTable());
		}

		// Token: 0x06030CC1 RID: 199873 RVA: 0x0069F37C File Offset: 0x0069D57C
		public IFixGetItemT UnPack()
		{
			IFixGetItemT fixGetItemT = new IFixGetItemT();
			this.UnPackTo(fixGetItemT);
			return fixGetItemT;
		}

		// Token: 0x06030CC2 RID: 199874 RVA: 0x0069F398 File Offset: 0x0069D598
		public void UnPackTo(IFixGetItemT _o)
		{
			_o.Items = new List<IItemDataT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06030CC3 RID: 199875 RVA: 0x0069F3F8 File Offset: 0x0069D5F8
		public static Offset<IFixGetItem> Pack(FlatBufferBuilder builder, IFixGetItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixGetItem>);
			}
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<IItemData>[] array = new Offset<IItemData>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IItemData.Pack(builder, _o.Items[i]);
				}
				itemsOffset = IFixGetItem.CreateItemsVector(builder, array);
			}
			return IFixGetItem.CreateIFixGetItem(builder, itemsOffset);
		}

		// Token: 0x04011D25 RID: 72997
		private Table __p;
	}
}
