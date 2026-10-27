using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D05 RID: 3333
	public struct GmAccount : IFlatbufferObject
	{
		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06007B1E RID: 31518 RVA: 0x0024CA08 File Offset: 0x0024AC08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x0024CA15 File Offset: 0x0024AC15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x0024CA1C File Offset: 0x0024AC1C
		public static GmAccount GetRootAsGmAccount(ByteBuffer _bb)
		{
			return GmAccount.GetRootAsGmAccount(_bb, default(GmAccount));
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x0024CA38 File Offset: 0x0024AC38
		public static GmAccount GetRootAsGmAccount(ByteBuffer _bb, GmAccount obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B22 RID: 31522 RVA: 0x0024CA55 File Offset: 0x0024AC55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x0024CA64 File Offset: 0x0024AC64
		public GmAccount __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06007B24 RID: 31524 RVA: 0x0024CA74 File Offset: 0x0024AC74
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

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06007B25 RID: 31525 RVA: 0x0024CAB0 File Offset: 0x0024ACB0
		public string GmName
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

		// Token: 0x06007B26 RID: 31526 RVA: 0x0024CAE7 File Offset: 0x0024ACE7
		public Span<byte> GetGmNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x0024CAF6 File Offset: 0x0024ACF6
		public byte[] GetGmNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06007B28 RID: 31528 RVA: 0x0024CB10 File Offset: 0x0024AD10
		public string FirstName
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

		// Token: 0x06007B29 RID: 31529 RVA: 0x0024CB47 File Offset: 0x0024AD47
		public Span<byte> GetFirstNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x0024CB56 File Offset: 0x0024AD56
		public byte[] GetFirstNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06007B2B RID: 31531 RVA: 0x0024CB70 File Offset: 0x0024AD70
		public int GmOrderListId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D7B RID: 19835
		private Table __p;
	}
}
