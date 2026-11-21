using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7A RID: 3962
	public struct NewTowerTag : IFlatbufferObject
	{
		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x0600A644 RID: 42564 RVA: 0x002BD674 File Offset: 0x002BB874
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x002BD681 File Offset: 0x002BB881
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x002BD688 File Offset: 0x002BB888
		public static NewTowerTag GetRootAsNewTowerTag(ByteBuffer _bb)
		{
			return NewTowerTag.GetRootAsNewTowerTag(_bb, default(NewTowerTag));
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x002BD6A4 File Offset: 0x002BB8A4
		public static NewTowerTag GetRootAsNewTowerTag(ByteBuffer _bb, NewTowerTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x002BD6C1 File Offset: 0x002BB8C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x002BD6D0 File Offset: 0x002BB8D0
		public NewTowerTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002405 RID: 9221
		// (get) Token: 0x0600A64A RID: 42570 RVA: 0x002BD6E0 File Offset: 0x002BB8E0
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

		// Token: 0x17002406 RID: 9222
		// (get) Token: 0x0600A64B RID: 42571 RVA: 0x002BD71C File Offset: 0x002BB91C
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

		// Token: 0x0600A64C RID: 42572 RVA: 0x002BD753 File Offset: 0x002BB953
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A64D RID: 42573 RVA: 0x002BD762 File Offset: 0x002BB962
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x0600A64E RID: 42574 RVA: 0x002BD77C File Offset: 0x002BB97C
		public string Desc
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

		// Token: 0x0600A64F RID: 42575 RVA: 0x002BD7B3 File Offset: 0x002BB9B3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A650 RID: 42576 RVA: 0x002BD7C2 File Offset: 0x002BB9C2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x0600A651 RID: 42577 RVA: 0x002BD7DC File Offset: 0x002BB9DC
		public string Path
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

		// Token: 0x0600A652 RID: 42578 RVA: 0x002BD814 File Offset: 0x002BBA14
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x002BD824 File Offset: 0x002BBA24
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x0600A654 RID: 42580 RVA: 0x002BD83C File Offset: 0x002BBA3C
		public string Color
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A655 RID: 42581 RVA: 0x002BD874 File Offset: 0x002BBA74
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x002BD884 File Offset: 0x002BBA84
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400552D RID: 21805
		private Table __p;
	}
}
