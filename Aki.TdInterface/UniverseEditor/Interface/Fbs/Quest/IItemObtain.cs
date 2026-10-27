using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EBA RID: 16058
	public struct IItemObtain : IFlatbufferObject
	{
		// Token: 0x17006F74 RID: 28532
		// (get) Token: 0x06016AF2 RID: 92914 RVA: 0x003467BC File Offset: 0x003449BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016AF3 RID: 92915 RVA: 0x003467C9 File Offset: 0x003449C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016AF4 RID: 92916 RVA: 0x003467D0 File Offset: 0x003449D0
		public static IItemObtain GetRootAsIItemObtain(ByteBuffer _bb)
		{
			return IItemObtain.GetRootAsIItemObtain(_bb, default(IItemObtain));
		}

		// Token: 0x06016AF5 RID: 92917 RVA: 0x003467EC File Offset: 0x003449EC
		public static IItemObtain GetRootAsIItemObtain(ByteBuffer _bb, IItemObtain obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016AF6 RID: 92918 RVA: 0x00346809 File Offset: 0x00344A09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016AF7 RID: 92919 RVA: 0x00346818 File Offset: 0x00344A18
		public IItemObtain __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F75 RID: 28533
		// (get) Token: 0x06016AF8 RID: 92920 RVA: 0x00346828 File Offset: 0x00344A28
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

		// Token: 0x06016AF9 RID: 92921 RVA: 0x00346864 File Offset: 0x00344A64
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17006F76 RID: 28534
		// (get) Token: 0x06016AFA RID: 92922 RVA: 0x003468A4 File Offset: 0x00344AA4
		public int ItemIdsLength
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

		// Token: 0x06016AFB RID: 92923 RVA: 0x003468CF File Offset: 0x00344ACF
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06016AFC RID: 92924 RVA: 0x003468DE File Offset: 0x00344ADE
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17006F77 RID: 28535
		// (get) Token: 0x06016AFD RID: 92925 RVA: 0x003468EC File Offset: 0x00344AEC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016AFE RID: 92926 RVA: 0x00346928 File Offset: 0x00344B28
		public static Offset<IItemObtain> CreateIItemObtain(FlatBufferBuilder builder, EShowUiType Type = EShowUiType.All, VectorOffset ItemIdsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IItemObtain.AddItemIds(builder, ItemIdsOffset);
			IItemObtain.AddNullMask(builder, NullMask);
			IItemObtain.AddType(builder, Type);
			return IItemObtain.EndIItemObtain(builder);
		}

		// Token: 0x06016AFF RID: 92927 RVA: 0x0034694C File Offset: 0x00344B4C
		public static void StartIItemObtain(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016B00 RID: 92928 RVA: 0x00346955 File Offset: 0x00344B55
		public static void AddType(FlatBufferBuilder builder, EShowUiType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016B01 RID: 92929 RVA: 0x00346960 File Offset: 0x00344B60
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
			builder.AddOffset(1, itemIdsOffset.Value, 0);
		}

		// Token: 0x06016B02 RID: 92930 RVA: 0x00346970 File Offset: 0x00344B70
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06016B03 RID: 92931 RVA: 0x003469A7 File Offset: 0x00344BA7
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016B04 RID: 92932 RVA: 0x003469C1 File Offset: 0x00344BC1
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06016B05 RID: 92933 RVA: 0x003469DF File Offset: 0x00344BDF
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016B06 RID: 92934 RVA: 0x003469F8 File Offset: 0x00344BF8
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016B07 RID: 92935 RVA: 0x00346A03 File Offset: 0x00344C03
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06016B08 RID: 92936 RVA: 0x00346A0E File Offset: 0x00344C0E
		public static Offset<IItemObtain> EndIItemObtain(FlatBufferBuilder builder)
		{
			return new Offset<IItemObtain>(builder.EndTable());
		}

		// Token: 0x06016B09 RID: 92937 RVA: 0x00346A1C File Offset: 0x00344C1C
		public IItemObtainT UnPack()
		{
			IItemObtainT itemObtainT = new IItemObtainT();
			this.UnPackTo(itemObtainT);
			return itemObtainT;
		}

		// Token: 0x06016B0A RID: 92938 RVA: 0x00346A38 File Offset: 0x00344C38
		public void UnPackTo(IItemObtainT _o)
		{
			_o.Type = this.Type;
			_o.ItemIds = new List<int>();
			for (int i = 0; i < this.ItemIdsLength; i++)
			{
				_o.ItemIds.Add(this.ItemIds(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016B0B RID: 92939 RVA: 0x00346A8C File Offset: 0x00344C8C
		public static Offset<IItemObtain> Pack(FlatBufferBuilder builder, IItemObtainT _o)
		{
			if (_o == null)
			{
				return default(Offset<IItemObtain>);
			}
			VectorOffset itemIdsOffset = default(VectorOffset);
			if (_o.ItemIds != null)
			{
				int[] data = _o.ItemIds.ToArray();
				itemIdsOffset = IItemObtain.CreateItemIdsVector(builder, data);
			}
			return IItemObtain.CreateIItemObtain(builder, _o.Type, itemIdsOffset, _o.NullMask);
		}

		// Token: 0x0400B88B RID: 47243
		private Table __p;
	}
}
