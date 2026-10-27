using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C42 RID: 3138
	public struct ExchangeParam : IFlatbufferObject
	{
		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06006A6D RID: 27245 RVA: 0x00225BC4 File Offset: 0x00223DC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x00225BD1 File Offset: 0x00223DD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x00225BD8 File Offset: 0x00223DD8
		public static ExchangeParam GetRootAsExchangeParam(ByteBuffer _bb)
		{
			return ExchangeParam.GetRootAsExchangeParam(_bb, default(ExchangeParam));
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x00225BF4 File Offset: 0x00223DF4
		public static ExchangeParam GetRootAsExchangeParam(ByteBuffer _bb, ExchangeParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x00225C11 File Offset: 0x00223E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00225C20 File Offset: 0x00223E20
		public ExchangeParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06006A73 RID: 27251 RVA: 0x00225C30 File Offset: 0x00223E30
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

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06006A74 RID: 27252 RVA: 0x00225C6C File Offset: 0x00223E6C
		public int ExchangeType
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

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06006A75 RID: 27253 RVA: 0x00225CA8 File Offset: 0x00223EA8
		public bool IsSingleDirection
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06006A76 RID: 27254 RVA: 0x00225CE8 File Offset: 0x00223EE8
		public IntPair? Target
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IntPair?(default(IntPair).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04004C82 RID: 19586
		private Table __p;
	}
}
