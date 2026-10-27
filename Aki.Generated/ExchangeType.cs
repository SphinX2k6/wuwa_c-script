using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C45 RID: 3141
	public struct ExchangeType : IFlatbufferObject
	{
		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06006AAC RID: 27308 RVA: 0x002267C4 File Offset: 0x002249C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x002267D1 File Offset: 0x002249D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x002267D8 File Offset: 0x002249D8
		public static ExchangeType GetRootAsExchangeType(ByteBuffer _bb)
		{
			return ExchangeType.GetRootAsExchangeType(_bb, default(ExchangeType));
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x002267F4 File Offset: 0x002249F4
		public static ExchangeType GetRootAsExchangeType(ByteBuffer _bb, ExchangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x00226811 File Offset: 0x00224A11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x00226820 File Offset: 0x00224A20
		public ExchangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06006AB2 RID: 27314 RVA: 0x00226830 File Offset: 0x00224A30
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

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x0022686C File Offset: 0x00224A6C
		public string Desc
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

		// Token: 0x06006AB4 RID: 27316 RVA: 0x002268A3 File Offset: 0x00224AA3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x002268B2 File Offset: 0x00224AB2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C8A RID: 19594
		private Table __p;
	}
}
