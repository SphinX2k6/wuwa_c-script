using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CF RID: 4559
	public struct Soar : IFlatbufferObject
	{
		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600DEEA RID: 57066 RVA: 0x0033B1EC File Offset: 0x003393EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DEEB RID: 57067 RVA: 0x0033B1F9 File Offset: 0x003393F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DEEC RID: 57068 RVA: 0x0033B200 File Offset: 0x00339400
		public static Soar GetRootAsSoar(ByteBuffer _bb)
		{
			return Soar.GetRootAsSoar(_bb, default(Soar));
		}

		// Token: 0x0600DEED RID: 57069 RVA: 0x0033B21C File Offset: 0x0033941C
		public static Soar GetRootAsSoar(ByteBuffer _bb, Soar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DEEE RID: 57070 RVA: 0x0033B239 File Offset: 0x00339439
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DEEF RID: 57071 RVA: 0x0033B248 File Offset: 0x00339448
		public Soar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600DEF0 RID: 57072 RVA: 0x0033B258 File Offset: 0x00339458
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DEF1 RID: 57073 RVA: 0x0033B28F File Offset: 0x0033948F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600DEF2 RID: 57074 RVA: 0x0033B29E File Offset: 0x0033949E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600DEF3 RID: 57075 RVA: 0x0033B2B8 File Offset: 0x003394B8
		public string HangSocket
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

		// Token: 0x0600DEF4 RID: 57076 RVA: 0x0033B2EF File Offset: 0x003394EF
		public Span<byte> GetHangSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DEF5 RID: 57077 RVA: 0x0033B2FE File Offset: 0x003394FE
		public byte[] GetHangSocketArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600DEF6 RID: 57078 RVA: 0x0033B318 File Offset: 0x00339518
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005806 RID: 22534
		private Table __p;
	}
}
