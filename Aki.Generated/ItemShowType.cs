using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D84 RID: 3460
	public struct ItemShowType : IFlatbufferObject
	{
		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x060086F5 RID: 34549 RVA: 0x00267654 File Offset: 0x00265854
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x00267661 File Offset: 0x00265861
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x00267668 File Offset: 0x00265868
		public static ItemShowType GetRootAsItemShowType(ByteBuffer _bb)
		{
			return ItemShowType.GetRootAsItemShowType(_bb, default(ItemShowType));
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x00267684 File Offset: 0x00265884
		public static ItemShowType GetRootAsItemShowType(ByteBuffer _bb, ItemShowType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086F9 RID: 34553 RVA: 0x002676A1 File Offset: 0x002658A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086FA RID: 34554 RVA: 0x002676B0 File Offset: 0x002658B0
		public ItemShowType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x060086FB RID: 34555 RVA: 0x002676C0 File Offset: 0x002658C0
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

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x060086FC RID: 34556 RVA: 0x002676FC File Offset: 0x002658FC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060086FD RID: 34557 RVA: 0x00267733 File Offset: 0x00265933
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060086FE RID: 34558 RVA: 0x00267742 File Offset: 0x00265942
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x060086FF RID: 34559 RVA: 0x0026775C File Offset: 0x0026595C
		public int ItemSort
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

		// Token: 0x04004E10 RID: 19984
		private Table __p;
	}
}
