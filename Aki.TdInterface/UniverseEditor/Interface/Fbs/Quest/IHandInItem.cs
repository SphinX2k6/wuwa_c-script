using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C5 RID: 17093
	public struct IHandInItem : IFlatbufferObject
	{
		// Token: 0x170074FD RID: 29949
		// (get) Token: 0x06017F71 RID: 98161 RVA: 0x0036BE81 File Offset: 0x0036A081
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017F72 RID: 98162 RVA: 0x0036BE8E File Offset: 0x0036A08E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017F73 RID: 98163 RVA: 0x0036BE98 File Offset: 0x0036A098
		public static IHandInItem GetRootAsIHandInItem(ByteBuffer _bb)
		{
			return IHandInItem.GetRootAsIHandInItem(_bb, default(IHandInItem));
		}

		// Token: 0x06017F74 RID: 98164 RVA: 0x0036BEB4 File Offset: 0x0036A0B4
		public static IHandInItem GetRootAsIHandInItem(ByteBuffer _bb, IHandInItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017F75 RID: 98165 RVA: 0x0036BED1 File Offset: 0x0036A0D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017F76 RID: 98166 RVA: 0x0036BEE0 File Offset: 0x0036A0E0
		public IHandInItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074FE RID: 29950
		// (get) Token: 0x06017F77 RID: 98167 RVA: 0x0036BEF0 File Offset: 0x0036A0F0
		public EHandInItemType HandInType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandInItemType.ItemIds;
				}
				return (EHandInItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017F78 RID: 98168 RVA: 0x0036BF2C File Offset: 0x0036A12C
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170074FF RID: 29951
		// (get) Token: 0x06017F79 RID: 98169 RVA: 0x0036BF6C File Offset: 0x0036A16C
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

		// Token: 0x06017F7A RID: 98170 RVA: 0x0036BF97 File Offset: 0x0036A197
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06017F7B RID: 98171 RVA: 0x0036BFA6 File Offset: 0x0036A1A6
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17007500 RID: 29952
		// (get) Token: 0x06017F7C RID: 98172 RVA: 0x0036BFB4 File Offset: 0x0036A1B4
		public int Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017F7D RID: 98173 RVA: 0x0036BFF0 File Offset: 0x0036A1F0
		public static Offset<IHandInItem> CreateIHandInItem(FlatBufferBuilder builder, EHandInItemType HandInType = EHandInItemType.ItemIds, VectorOffset ItemIdsOffset = default(VectorOffset), int Count = 0)
		{
			builder.StartTable(3);
			IHandInItem.AddCount(builder, Count);
			IHandInItem.AddItemIds(builder, ItemIdsOffset);
			IHandInItem.AddHandInType(builder, HandInType);
			return IHandInItem.EndIHandInItem(builder);
		}

		// Token: 0x06017F7E RID: 98174 RVA: 0x0036C014 File Offset: 0x0036A214
		public static void StartIHandInItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017F7F RID: 98175 RVA: 0x0036C01D File Offset: 0x0036A21D
		public static void AddHandInType(FlatBufferBuilder builder, EHandInItemType handInType)
		{
			builder.AddByte(0, (byte)handInType, 0);
		}

		// Token: 0x06017F80 RID: 98176 RVA: 0x0036C028 File Offset: 0x0036A228
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
			builder.AddOffset(1, itemIdsOffset.Value, 0);
		}

		// Token: 0x06017F81 RID: 98177 RVA: 0x0036C038 File Offset: 0x0036A238
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017F82 RID: 98178 RVA: 0x0036C06F File Offset: 0x0036A26F
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F83 RID: 98179 RVA: 0x0036C089 File Offset: 0x0036A289
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06017F84 RID: 98180 RVA: 0x0036C0A7 File Offset: 0x0036A2A7
		public static VectorOffset CreateItemIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017F85 RID: 98181 RVA: 0x0036C0C0 File Offset: 0x0036A2C0
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017F86 RID: 98182 RVA: 0x0036C0CB File Offset: 0x0036A2CB
		public static void AddCount(FlatBufferBuilder builder, int count)
		{
			builder.AddInt(2, count, 0);
		}

		// Token: 0x06017F87 RID: 98183 RVA: 0x0036C0D6 File Offset: 0x0036A2D6
		public static Offset<IHandInItem> EndIHandInItem(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItem>(builder.EndTable());
		}

		// Token: 0x06017F88 RID: 98184 RVA: 0x0036C0E4 File Offset: 0x0036A2E4
		public IHandInItemT UnPack()
		{
			IHandInItemT handInItemT = new IHandInItemT();
			this.UnPackTo(handInItemT);
			return handInItemT;
		}

		// Token: 0x06017F89 RID: 98185 RVA: 0x0036C100 File Offset: 0x0036A300
		public void UnPackTo(IHandInItemT _o)
		{
			_o.HandInType = this.HandInType;
			_o.ItemIds = new List<int>();
			for (int i = 0; i < this.ItemIdsLength; i++)
			{
				_o.ItemIds.Add(this.ItemIds(i));
			}
			_o.Count = this.Count;
		}

		// Token: 0x06017F8A RID: 98186 RVA: 0x0036C154 File Offset: 0x0036A354
		public static Offset<IHandInItem> Pack(FlatBufferBuilder builder, IHandInItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInItem>);
			}
			VectorOffset itemIdsOffset = default(VectorOffset);
			if (_o.ItemIds != null)
			{
				int[] data = _o.ItemIds.ToArray();
				itemIdsOffset = IHandInItem.CreateItemIdsVector(builder, data);
			}
			return IHandInItem.CreateIHandInItem(builder, _o.HandInType, itemIdsOffset, _o.Count);
		}

		// Token: 0x0400C222 RID: 49698
		private Table __p;
	}
}
