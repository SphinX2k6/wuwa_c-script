using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA8 RID: 3240
	public struct DangoBrawlLevel : IFlatbufferObject
	{
		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06006402 RID: 25602 RVA: 0x0022A235 File Offset: 0x00228435
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x0022A242 File Offset: 0x00228442
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x0022A24C File Offset: 0x0022844C
		public static DangoBrawlLevel GetRootAsDangoBrawlLevel(ByteBuffer _bb)
		{
			return DangoBrawlLevel.GetRootAsDangoBrawlLevel(_bb, default(DangoBrawlLevel));
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x0022A268 File Offset: 0x00228468
		public static DangoBrawlLevel GetRootAsDangoBrawlLevel(ByteBuffer _bb, DangoBrawlLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x0022A285 File Offset: 0x00228485
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x0022A294 File Offset: 0x00228494
		public DangoBrawlLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06006408 RID: 25608 RVA: 0x0022A2A4 File Offset: 0x002284A4
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

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06006409 RID: 25609 RVA: 0x0022A2E0 File Offset: 0x002284E0
		public string ItemList
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

		// Token: 0x0600640A RID: 25610 RVA: 0x0022A317 File Offset: 0x00228517
		public Span<byte> GetItemListBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x0022A326 File Offset: 0x00228526
		public byte[] GetItemListArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040051D1 RID: 20945
		private Table __p;
	}
}
