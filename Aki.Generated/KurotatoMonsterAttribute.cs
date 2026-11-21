using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8E RID: 3726
	public struct KurotatoMonsterAttribute : IFlatbufferObject
	{
		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x060090E3 RID: 37091 RVA: 0x0028F40A File Offset: 0x0028D60A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090E4 RID: 37092 RVA: 0x0028F417 File Offset: 0x0028D617
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x0028F420 File Offset: 0x0028D620
		public static KurotatoMonsterAttribute GetRootAsKurotatoMonsterAttribute(ByteBuffer _bb)
		{
			return KurotatoMonsterAttribute.GetRootAsKurotatoMonsterAttribute(_bb, default(KurotatoMonsterAttribute));
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x0028F43C File Offset: 0x0028D63C
		public static KurotatoMonsterAttribute GetRootAsKurotatoMonsterAttribute(ByteBuffer _bb, KurotatoMonsterAttribute obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x0028F459 File Offset: 0x0028D659
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090E8 RID: 37096 RVA: 0x0028F468 File Offset: 0x0028D668
		public KurotatoMonsterAttribute __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x060090E9 RID: 37097 RVA: 0x0028F478 File Offset: 0x0028D678
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

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x060090EA RID: 37098 RVA: 0x0028F4B4 File Offset: 0x0028D6B4
		public string Key
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

		// Token: 0x060090EB RID: 37099 RVA: 0x0028F4EB File Offset: 0x0028D6EB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060090EC RID: 37100 RVA: 0x0028F4FA File Offset: 0x0028D6FA
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x060090ED RID: 37101 RVA: 0x0028F514 File Offset: 0x0028D714
		public string Name
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

		// Token: 0x060090EE RID: 37102 RVA: 0x0028F54B File Offset: 0x0028D74B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060090EF RID: 37103 RVA: 0x0028F55A File Offset: 0x0028D75A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x060090F0 RID: 37104 RVA: 0x0028F574 File Offset: 0x0028D774
		public string Icon
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

		// Token: 0x060090F1 RID: 37105 RVA: 0x0028F5AC File Offset: 0x0028D7AC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x0028F5BC File Offset: 0x0028D7BC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005420 RID: 21536
		private Table __p;
	}
}
