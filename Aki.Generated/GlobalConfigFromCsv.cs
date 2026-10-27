using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D04 RID: 3332
	public struct GlobalConfigFromCsv : IFlatbufferObject
	{
		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06007B0B RID: 31499 RVA: 0x0024C7DD File Offset: 0x0024A9DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x0024C7EA File Offset: 0x0024A9EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B0D RID: 31501 RVA: 0x0024C7F4 File Offset: 0x0024A9F4
		public static GlobalConfigFromCsv GetRootAsGlobalConfigFromCsv(ByteBuffer _bb)
		{
			return GlobalConfigFromCsv.GetRootAsGlobalConfigFromCsv(_bb, default(GlobalConfigFromCsv));
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x0024C810 File Offset: 0x0024AA10
		public static GlobalConfigFromCsv GetRootAsGlobalConfigFromCsv(ByteBuffer _bb, GlobalConfigFromCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x0024C82D File Offset: 0x0024AA2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x0024C83C File Offset: 0x0024AA3C
		public GlobalConfigFromCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06007B11 RID: 31505 RVA: 0x0024C84C File Offset: 0x0024AA4C
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

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06007B12 RID: 31506 RVA: 0x0024C888 File Offset: 0x0024AA88
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

		// Token: 0x06007B13 RID: 31507 RVA: 0x0024C8BF File Offset: 0x0024AABF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x0024C8CE File Offset: 0x0024AACE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06007B15 RID: 31509 RVA: 0x0024C8E8 File Offset: 0x0024AAE8
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

		// Token: 0x06007B16 RID: 31510 RVA: 0x0024C91F File Offset: 0x0024AB1F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x0024C92E File Offset: 0x0024AB2E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06007B18 RID: 31512 RVA: 0x0024C948 File Offset: 0x0024AB48
		public string Type
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

		// Token: 0x06007B19 RID: 31513 RVA: 0x0024C980 File Offset: 0x0024AB80
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007B1A RID: 31514 RVA: 0x0024C990 File Offset: 0x0024AB90
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06007B1B RID: 31515 RVA: 0x0024C9A8 File Offset: 0x0024ABA8
		public string Value
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

		// Token: 0x06007B1C RID: 31516 RVA: 0x0024C9E0 File Offset: 0x0024ABE0
		public Span<byte> GetValueBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x0024C9F0 File Offset: 0x0024ABF0
		public byte[] GetValueArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D7A RID: 19834
		private Table __p;
	}
}
