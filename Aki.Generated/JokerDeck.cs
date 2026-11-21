using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E6B RID: 3691
	public struct JokerDeck : IFlatbufferObject
	{
		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x06008D22 RID: 36130 RVA: 0x00285A70 File Offset: 0x00283C70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x00285A7D File Offset: 0x00283C7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D24 RID: 36132 RVA: 0x00285A84 File Offset: 0x00283C84
		public static JokerDeck GetRootAsJokerDeck(ByteBuffer _bb)
		{
			return JokerDeck.GetRootAsJokerDeck(_bb, default(JokerDeck));
		}

		// Token: 0x06008D25 RID: 36133 RVA: 0x00285AA0 File Offset: 0x00283CA0
		public static JokerDeck GetRootAsJokerDeck(ByteBuffer _bb, JokerDeck obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D26 RID: 36134 RVA: 0x00285ABD File Offset: 0x00283CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D27 RID: 36135 RVA: 0x00285ACC File Offset: 0x00283CCC
		public JokerDeck __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06008D28 RID: 36136 RVA: 0x00285ADC File Offset: 0x00283CDC
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

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06008D29 RID: 36137 RVA: 0x00285B18 File Offset: 0x00283D18
		public int CardType
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

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06008D2A RID: 36138 RVA: 0x00285B54 File Offset: 0x00283D54
		public int CardNumber
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

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06008D2B RID: 36139 RVA: 0x00285B90 File Offset: 0x00283D90
		public string TexturePath
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

		// Token: 0x06008D2C RID: 36140 RVA: 0x00285BC8 File Offset: 0x00283DC8
		public Span<byte> GetTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008D2D RID: 36141 RVA: 0x00285BD8 File Offset: 0x00283DD8
		public byte[] GetTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040053F7 RID: 21495
		private Table __p;
	}
}
