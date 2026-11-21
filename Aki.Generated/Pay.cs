using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F92 RID: 3986
	public struct Pay : IFlatbufferObject
	{
		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x0600A8EE RID: 43246 RVA: 0x002C3371 File Offset: 0x002C1571
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A8EF RID: 43247 RVA: 0x002C337E File Offset: 0x002C157E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A8F0 RID: 43248 RVA: 0x002C3388 File Offset: 0x002C1588
		public static Pay GetRootAsPay(ByteBuffer _bb)
		{
			return Pay.GetRootAsPay(_bb, default(Pay));
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x002C33A4 File Offset: 0x002C15A4
		public static Pay GetRootAsPay(ByteBuffer _bb, Pay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x002C33C1 File Offset: 0x002C15C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x002C33D0 File Offset: 0x002C15D0
		public Pay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x0600A8F4 RID: 43252 RVA: 0x002C33E0 File Offset: 0x002C15E0
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

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x0600A8F5 RID: 43253 RVA: 0x002C341C File Offset: 0x002C161C
		public int PayId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x0600A8F6 RID: 43254 RVA: 0x002C3458 File Offset: 0x002C1658
		public string Region
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

		// Token: 0x0600A8F7 RID: 43255 RVA: 0x002C348F File Offset: 0x002C168F
		public Span<byte> GetRegionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A8F8 RID: 43256 RVA: 0x002C349E File Offset: 0x002C169E
		public byte[] GetRegionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x0600A8F9 RID: 43257 RVA: 0x002C34B8 File Offset: 0x002C16B8
		public float Amount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x0600A8FA RID: 43258 RVA: 0x002C34FC File Offset: 0x002C16FC
		public float GlobalAmount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x0600A8FB RID: 43259 RVA: 0x002C3540 File Offset: 0x002C1740
		public string ProductId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x002C3578 File Offset: 0x002C1778
		public Span<byte> GetProductIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x002C3588 File Offset: 0x002C1788
		public byte[] GetProductIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x0600A8FE RID: 43262 RVA: 0x002C35A0 File Offset: 0x002C17A0
		public string CurrencyType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x002C35D8 File Offset: 0x002C17D8
		public Span<byte> GetCurrencyTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x002C35E8 File Offset: 0x002C17E8
		public byte[] GetCurrencyTypeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04005548 RID: 21832
		private Table __p;
	}
}
