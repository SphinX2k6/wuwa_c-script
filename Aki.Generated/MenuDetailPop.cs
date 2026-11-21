using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EED RID: 3821
	public struct MenuDetailPop : IFlatbufferObject
	{
		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06009A1A RID: 39450 RVA: 0x002A322A File Offset: 0x002A142A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x002A3237 File Offset: 0x002A1437
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A1C RID: 39452 RVA: 0x002A3240 File Offset: 0x002A1440
		public static MenuDetailPop GetRootAsMenuDetailPop(ByteBuffer _bb)
		{
			return MenuDetailPop.GetRootAsMenuDetailPop(_bb, default(MenuDetailPop));
		}

		// Token: 0x06009A1D RID: 39453 RVA: 0x002A325C File Offset: 0x002A145C
		public static MenuDetailPop GetRootAsMenuDetailPop(ByteBuffer _bb, MenuDetailPop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A1E RID: 39454 RVA: 0x002A3279 File Offset: 0x002A1479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A1F RID: 39455 RVA: 0x002A3288 File Offset: 0x002A1488
		public MenuDetailPop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06009A20 RID: 39456 RVA: 0x002A3298 File Offset: 0x002A1498
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

		// Token: 0x06009A21 RID: 39457 RVA: 0x002A32D4 File Offset: 0x002A14D4
		public int ItemList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06009A22 RID: 39458 RVA: 0x002A3314 File Offset: 0x002A1514
		public int ItemListLength
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

		// Token: 0x06009A23 RID: 39459 RVA: 0x002A333F File Offset: 0x002A153F
		public Span<int> GetItemListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009A24 RID: 39460 RVA: 0x002A334E File Offset: 0x002A154E
		public int[] GetItemListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06009A25 RID: 39461 RVA: 0x002A3368 File Offset: 0x002A1568
		public string Title
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x002A339F File Offset: 0x002A159F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x002A33AE File Offset: 0x002A15AE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06009A28 RID: 39464 RVA: 0x002A33C8 File Offset: 0x002A15C8
		public string Description
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009A29 RID: 39465 RVA: 0x002A3400 File Offset: 0x002A1600
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009A2A RID: 39466 RVA: 0x002A3410 File Offset: 0x002A1610
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A2B RID: 39467 RVA: 0x002A3428 File Offset: 0x002A1628
		[NullableContext(1)]
		public int[] ItemList()
		{
			return this.GetItemListArray();
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x002A3430 File Offset: 0x002A1630
		[NullableContext(1)]
		public IEnumerable<int> ItemListIter()
		{
			MenuDetailPop.<ItemListIter>d__24 <ItemListIter>d__ = new MenuDetailPop.<ItemListIter>d__24(-2);
			<ItemListIter>d__.<>3__<>4__this = this;
			return <ItemListIter>d__;
		}

		// Token: 0x04005492 RID: 21650
		private Table __p;
	}
}
