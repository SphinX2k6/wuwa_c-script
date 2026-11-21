using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD2 RID: 3282
	public struct DigitalScreenText : IFlatbufferObject
	{
		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060067FA RID: 26618 RVA: 0x002329A5 File Offset: 0x00230BA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x002329B2 File Offset: 0x00230BB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x002329BC File Offset: 0x00230BBC
		public static DigitalScreenText GetRootAsDigitalScreenText(ByteBuffer _bb)
		{
			return DigitalScreenText.GetRootAsDigitalScreenText(_bb, default(DigitalScreenText));
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x002329D8 File Offset: 0x00230BD8
		public static DigitalScreenText GetRootAsDigitalScreenText(ByteBuffer _bb, DigitalScreenText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x002329F5 File Offset: 0x00230BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x00232A04 File Offset: 0x00230C04
		public DigitalScreenText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06006800 RID: 26624 RVA: 0x00232A14 File Offset: 0x00230C14
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

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06006801 RID: 26625 RVA: 0x00232A50 File Offset: 0x00230C50
		public string TextContentId
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

		// Token: 0x06006802 RID: 26626 RVA: 0x00232A87 File Offset: 0x00230C87
		public Span<byte> GetTextContentIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x00232A96 File Offset: 0x00230C96
		public byte[] GetTextContentIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06006804 RID: 26628 RVA: 0x00232AB0 File Offset: 0x00230CB0
		public int Alignment
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06006805 RID: 26629 RVA: 0x00232AEC File Offset: 0x00230CEC
		public int FontSize
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

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06006806 RID: 26630 RVA: 0x00232B2C File Offset: 0x00230D2C
		public float ShowStartFrame
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

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06006807 RID: 26631 RVA: 0x00232B70 File Offset: 0x00230D70
		public float ShowEndFrame
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06006808 RID: 26632 RVA: 0x00232BB4 File Offset: 0x00230DB4
		public float HideFrame
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06006809 RID: 26633 RVA: 0x00232BF8 File Offset: 0x00230DF8
		public int Effect
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040051FF RID: 20991
		private Table __p;
	}
}
