using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D25 RID: 3365
	public struct ExchangeParam : IFlatbufferObject
	{
		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x0600706F RID: 28783 RVA: 0x00244F0C File Offset: 0x0024310C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x00244F19 File Offset: 0x00243119
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x00244F20 File Offset: 0x00243120
		public static ExchangeParam GetRootAsExchangeParam(ByteBuffer _bb)
		{
			return ExchangeParam.GetRootAsExchangeParam(_bb, default(ExchangeParam));
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x00244F3C File Offset: 0x0024313C
		public static ExchangeParam GetRootAsExchangeParam(ByteBuffer _bb, ExchangeParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x00244F59 File Offset: 0x00243159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x00244F68 File Offset: 0x00243168
		public ExchangeParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06007075 RID: 28789 RVA: 0x00244F78 File Offset: 0x00243178
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

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06007076 RID: 28790 RVA: 0x00244FB4 File Offset: 0x002431B4
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

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x00244FF0 File Offset: 0x002431F0
		public bool IsSingleDirection
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06007078 RID: 28792 RVA: 0x00245030 File Offset: 0x00243230
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

		// Token: 0x04005265 RID: 21093
		private Table __p;
	}
}
