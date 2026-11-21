using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004568 RID: 17768
	public struct IShowUiCrafting : IFlatbufferObject
	{
		// Token: 0x17007C27 RID: 31783
		// (get) Token: 0x06019D9F RID: 105887 RVA: 0x003B0430 File Offset: 0x003AE630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019DA0 RID: 105888 RVA: 0x003B043D File Offset: 0x003AE63D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019DA1 RID: 105889 RVA: 0x003B0444 File Offset: 0x003AE644
		public static IShowUiCrafting GetRootAsIShowUiCrafting(ByteBuffer _bb)
		{
			return IShowUiCrafting.GetRootAsIShowUiCrafting(_bb, default(IShowUiCrafting));
		}

		// Token: 0x06019DA2 RID: 105890 RVA: 0x003B0460 File Offset: 0x003AE660
		public static IShowUiCrafting GetRootAsIShowUiCrafting(ByteBuffer _bb, IShowUiCrafting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019DA3 RID: 105891 RVA: 0x003B047D File Offset: 0x003AE67D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019DA4 RID: 105892 RVA: 0x003B048C File Offset: 0x003AE68C
		public IShowUiCrafting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C28 RID: 31784
		// (get) Token: 0x06019DA5 RID: 105893 RVA: 0x003B049C File Offset: 0x003AE69C
		public EShowUiType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowUiType.All;
				}
				return (EShowUiType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019DA6 RID: 105894 RVA: 0x003B04D8 File Offset: 0x003AE6D8
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C29 RID: 31785
		// (get) Token: 0x06019DA7 RID: 105895 RVA: 0x003B0518 File Offset: 0x003AE718
		public int EntityIdsLength
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

		// Token: 0x06019DA8 RID: 105896 RVA: 0x003B0543 File Offset: 0x003AE743
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06019DA9 RID: 105897 RVA: 0x003B0552 File Offset: 0x003AE752
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06019DAA RID: 105898 RVA: 0x003B0560 File Offset: 0x003AE760
		public int ProductIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17007C2A RID: 31786
		// (get) Token: 0x06019DAB RID: 105899 RVA: 0x003B05A0 File Offset: 0x003AE7A0
		public int ProductIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06019DAC RID: 105900 RVA: 0x003B05CB File Offset: 0x003AE7CB
		public Span<int> GetProductIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06019DAD RID: 105901 RVA: 0x003B05DA File Offset: 0x003AE7DA
		public int[] GetProductIdsArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x17007C2B RID: 31787
		// (get) Token: 0x06019DAE RID: 105902 RVA: 0x003B05E8 File Offset: 0x003AE7E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06019DAF RID: 105903 RVA: 0x003B0625 File Offset: 0x003AE825
		public static Offset<IShowUiCrafting> CreateIShowUiCrafting(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset EntityIdsOffset = default(VectorOffset), VectorOffset ProductIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowUiCrafting.AddProductIds(builder, ProductIdsOffset);
			IShowUiCrafting.AddEntityIds(builder, EntityIdsOffset);
			IShowUiCrafting.AddNullMask(builder, NullMask);
			IShowUiCrafting.AddType(builder, Type);
			return IShowUiCrafting.EndIShowUiCrafting(builder);
		}

		// Token: 0x06019DB0 RID: 105904 RVA: 0x003B0651 File Offset: 0x003AE851
		public static void StartIShowUiCrafting(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019DB1 RID: 105905 RVA: 0x003B065A File Offset: 0x003AE85A
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019DB2 RID: 105906 RVA: 0x003B0665 File Offset: 0x003AE865
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06019DB3 RID: 105907 RVA: 0x003B0678 File Offset: 0x003AE878
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019DB4 RID: 105908 RVA: 0x003B06AF File Offset: 0x003AE8AF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DB5 RID: 105909 RVA: 0x003B06C9 File Offset: 0x003AE8C9
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DB6 RID: 105910 RVA: 0x003B06E7 File Offset: 0x003AE8E7
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019DB7 RID: 105911 RVA: 0x003B0700 File Offset: 0x003AE900
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019DB8 RID: 105912 RVA: 0x003B070B File Offset: 0x003AE90B
		public static void AddProductIds(FlatBufferBuilder builder, VectorOffset productIdsOffset)
		{
			builder.AddOffset(2, productIdsOffset.Value, 0);
		}

		// Token: 0x06019DB9 RID: 105913 RVA: 0x003B071C File Offset: 0x003AE91C
		public static VectorOffset CreateProductIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019DBA RID: 105914 RVA: 0x003B0753 File Offset: 0x003AE953
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DBB RID: 105915 RVA: 0x003B076D File Offset: 0x003AE96D
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019DBC RID: 105916 RVA: 0x003B078B File Offset: 0x003AE98B
		public static VectorOffset CreateProductIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019DBD RID: 105917 RVA: 0x003B07A4 File Offset: 0x003AE9A4
		public static void StartProductIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019DBE RID: 105918 RVA: 0x003B07AF File Offset: 0x003AE9AF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06019DBF RID: 105919 RVA: 0x003B07BA File Offset: 0x003AE9BA
		public static Offset<IShowUiCrafting> EndIShowUiCrafting(FlatBufferBuilder builder)
		{
			return new Offset<IShowUiCrafting>(builder.EndTable());
		}

		// Token: 0x06019DC0 RID: 105920 RVA: 0x003B07C8 File Offset: 0x003AE9C8
		public IShowUiCraftingT UnPack()
		{
			IShowUiCraftingT showUiCraftingT = new IShowUiCraftingT();
			this.UnPackTo(showUiCraftingT);
			return showUiCraftingT;
		}

		// Token: 0x06019DC1 RID: 105921 RVA: 0x003B07E4 File Offset: 0x003AE9E4
		public void UnPackTo(IShowUiCraftingT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.ProductIds = new List<int>();
			for (int j = 0; j < this.ProductIdsLength; j++)
			{
				_o.ProductIds.Add(this.ProductIds(j));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06019DC2 RID: 105922 RVA: 0x003B0868 File Offset: 0x003AEA68
		public static Offset<IShowUiCrafting> Pack(FlatBufferBuilder builder, IShowUiCraftingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowUiCrafting>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IShowUiCrafting.CreateEntityIdsVector(builder, data);
			}
			VectorOffset productIdsOffset = default(VectorOffset);
			if (_o.ProductIds != null)
			{
				int[] data2 = _o.ProductIds.ToArray();
				productIdsOffset = IShowUiCrafting.CreateProductIdsVector(builder, data2);
			}
			return IShowUiCrafting.CreateIShowUiCrafting(builder, _o.Type, entityIdsOffset, productIdsOffset, _o.NullMask);
		}

		// Token: 0x0400C6FE RID: 50942
		private Table __p;
	}
}
