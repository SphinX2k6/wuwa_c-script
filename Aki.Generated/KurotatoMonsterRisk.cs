using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAB RID: 3499
	public struct KurotatoMonsterRisk : IFlatbufferObject
	{
		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06008AE1 RID: 35553 RVA: 0x00270D7D File Offset: 0x0026EF7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x00270D8A File Offset: 0x0026EF8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x00270D94 File Offset: 0x0026EF94
		public static KurotatoMonsterRisk GetRootAsKurotatoMonsterRisk(ByteBuffer _bb)
		{
			return KurotatoMonsterRisk.GetRootAsKurotatoMonsterRisk(_bb, default(KurotatoMonsterRisk));
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x00270DB0 File Offset: 0x0026EFB0
		public static KurotatoMonsterRisk GetRootAsKurotatoMonsterRisk(ByteBuffer _bb, KurotatoMonsterRisk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x00270DCD File Offset: 0x0026EFCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x00270DDC File Offset: 0x0026EFDC
		public KurotatoMonsterRisk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06008AE7 RID: 35559 RVA: 0x00270DEC File Offset: 0x0026EFEC
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

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06008AE8 RID: 35560 RVA: 0x00270E28 File Offset: 0x0026F028
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

		// Token: 0x06008AE9 RID: 35561 RVA: 0x00270E5F File Offset: 0x0026F05F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x00270E6E File Offset: 0x0026F06E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x06008AEB RID: 35563 RVA: 0x00270E88 File Offset: 0x0026F088
		public string GridQualityPath
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

		// Token: 0x06008AEC RID: 35564 RVA: 0x00270EBF File Offset: 0x0026F0BF
		public Span<byte> GetGridQualityPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008AED RID: 35565 RVA: 0x00270ECE File Offset: 0x0026F0CE
		public byte[] GetGridQualityPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x06008AEE RID: 35566 RVA: 0x00270EE8 File Offset: 0x0026F0E8
		public string DescQualityPath
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

		// Token: 0x06008AEF RID: 35567 RVA: 0x00270F20 File Offset: 0x0026F120
		public Span<byte> GetDescQualityPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x00270F30 File Offset: 0x0026F130
		public byte[] GetDescQualityPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x06008AF1 RID: 35569 RVA: 0x00270F48 File Offset: 0x0026F148
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

		// Token: 0x06008AF2 RID: 35570 RVA: 0x00270F80 File Offset: 0x0026F180
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008AF3 RID: 35571 RVA: 0x00270F90 File Offset: 0x0026F190
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E3D RID: 20029
		private Table __p;
	}
}
