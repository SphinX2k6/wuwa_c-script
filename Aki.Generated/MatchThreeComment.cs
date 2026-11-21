using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EDE RID: 3806
	public struct MatchThreeComment : IFlatbufferObject
	{
		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x06009870 RID: 39024 RVA: 0x0029F650 File Offset: 0x0029D850
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009871 RID: 39025 RVA: 0x0029F65D File Offset: 0x0029D85D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009872 RID: 39026 RVA: 0x0029F664 File Offset: 0x0029D864
		public static MatchThreeComment GetRootAsMatchThreeComment(ByteBuffer _bb)
		{
			return MatchThreeComment.GetRootAsMatchThreeComment(_bb, default(MatchThreeComment));
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x0029F680 File Offset: 0x0029D880
		public static MatchThreeComment GetRootAsMatchThreeComment(ByteBuffer _bb, MatchThreeComment obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x0029F69D File Offset: 0x0029D89D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x0029F6AC File Offset: 0x0029D8AC
		public MatchThreeComment __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x06009876 RID: 39030 RVA: 0x0029F6BC File Offset: 0x0029D8BC
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

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06009877 RID: 39031 RVA: 0x0029F6F8 File Offset: 0x0029D8F8
		public int Count
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

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06009878 RID: 39032 RVA: 0x0029F734 File Offset: 0x0029D934
		public string Color1
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

		// Token: 0x06009879 RID: 39033 RVA: 0x0029F76B File Offset: 0x0029D96B
		public Span<byte> GetColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x0029F77A File Offset: 0x0029D97A
		public byte[] GetColor1Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x0600987B RID: 39035 RVA: 0x0029F794 File Offset: 0x0029D994
		public string Color2
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

		// Token: 0x0600987C RID: 39036 RVA: 0x0029F7CC File Offset: 0x0029D9CC
		public Span<byte> GetColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x0029F7DC File Offset: 0x0029D9DC
		public byte[] GetColor2Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x0600987E RID: 39038 RVA: 0x0029F7F4 File Offset: 0x0029D9F4
		public string Icon
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

		// Token: 0x0600987F RID: 39039 RVA: 0x0029F82C File Offset: 0x0029DA2C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009880 RID: 39040 RVA: 0x0029F83C File Offset: 0x0029DA3C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400547E RID: 21630
		private Table __p;
	}
}
