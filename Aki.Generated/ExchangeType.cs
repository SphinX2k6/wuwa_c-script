using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D28 RID: 3368
	public struct ExchangeType : IFlatbufferObject
	{
		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060070AE RID: 28846 RVA: 0x00245B0C File Offset: 0x00243D0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x00245B19 File Offset: 0x00243D19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060070B0 RID: 28848 RVA: 0x00245B20 File Offset: 0x00243D20
		public static ExchangeType GetRootAsExchangeType(ByteBuffer _bb)
		{
			return ExchangeType.GetRootAsExchangeType(_bb, default(ExchangeType));
		}

		// Token: 0x060070B1 RID: 28849 RVA: 0x00245B3C File Offset: 0x00243D3C
		public static ExchangeType GetRootAsExchangeType(ByteBuffer _bb, ExchangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060070B2 RID: 28850 RVA: 0x00245B59 File Offset: 0x00243D59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x00245B68 File Offset: 0x00243D68
		public ExchangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060070B4 RID: 28852 RVA: 0x00245B78 File Offset: 0x00243D78
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

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060070B5 RID: 28853 RVA: 0x00245BB4 File Offset: 0x00243DB4
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

		// Token: 0x060070B6 RID: 28854 RVA: 0x00245BEB File Offset: 0x00243DEB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x00245BFA File Offset: 0x00243DFA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400526D RID: 21101
		private Table __p;
	}
}
