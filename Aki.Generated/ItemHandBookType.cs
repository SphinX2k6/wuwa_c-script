using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D7F RID: 3455
	public struct ItemHandBookType : IFlatbufferObject
	{
		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x06008660 RID: 34400 RVA: 0x00265E85 File Offset: 0x00264085
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x00265E92 File Offset: 0x00264092
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008662 RID: 34402 RVA: 0x00265E9C File Offset: 0x0026409C
		public static ItemHandBookType GetRootAsItemHandBookType(ByteBuffer _bb)
		{
			return ItemHandBookType.GetRootAsItemHandBookType(_bb, default(ItemHandBookType));
		}

		// Token: 0x06008663 RID: 34403 RVA: 0x00265EB8 File Offset: 0x002640B8
		public static ItemHandBookType GetRootAsItemHandBookType(ByteBuffer _bb, ItemHandBookType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008664 RID: 34404 RVA: 0x00265ED5 File Offset: 0x002640D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008665 RID: 34405 RVA: 0x00265EE4 File Offset: 0x002640E4
		public ItemHandBookType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x06008666 RID: 34406 RVA: 0x00265EF4 File Offset: 0x002640F4
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

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x00265F30 File Offset: 0x00264130
		public string Descrtption
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

		// Token: 0x06008668 RID: 34408 RVA: 0x00265F67 File Offset: 0x00264167
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008669 RID: 34409 RVA: 0x00265F76 File Offset: 0x00264176
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x0600866A RID: 34410 RVA: 0x00265F90 File Offset: 0x00264190
		public string Icon
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

		// Token: 0x0600866B RID: 34411 RVA: 0x00265FC7 File Offset: 0x002641C7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x00265FD6 File Offset: 0x002641D6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E08 RID: 19976
		private Table __p;
	}
}
