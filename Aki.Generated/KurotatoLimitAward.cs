using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8C RID: 3724
	public struct KurotatoLimitAward : IFlatbufferObject
	{
		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x060090A9 RID: 37033 RVA: 0x0028EC95 File Offset: 0x0028CE95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090AA RID: 37034 RVA: 0x0028ECA2 File Offset: 0x0028CEA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x0028ECAC File Offset: 0x0028CEAC
		public static KurotatoLimitAward GetRootAsKurotatoLimitAward(ByteBuffer _bb)
		{
			return KurotatoLimitAward.GetRootAsKurotatoLimitAward(_bb, default(KurotatoLimitAward));
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x0028ECC8 File Offset: 0x0028CEC8
		public static KurotatoLimitAward GetRootAsKurotatoLimitAward(ByteBuffer _bb, KurotatoLimitAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090AD RID: 37037 RVA: 0x0028ECE5 File Offset: 0x0028CEE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x0028ECF4 File Offset: 0x0028CEF4
		public KurotatoLimitAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x060090AF RID: 37039 RVA: 0x0028ED04 File Offset: 0x0028CF04
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

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x060090B0 RID: 37040 RVA: 0x0028ED40 File Offset: 0x0028CF40
		public int ActivityId
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

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x060090B1 RID: 37041 RVA: 0x0028ED7C File Offset: 0x0028CF7C
		public int DropId
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

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x060090B2 RID: 37042 RVA: 0x0028EDB8 File Offset: 0x0028CFB8
		public int TabId
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

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x060090B3 RID: 37043 RVA: 0x0028EDF8 File Offset: 0x0028CFF8
		public string Desc
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

		// Token: 0x060090B4 RID: 37044 RVA: 0x0028EE30 File Offset: 0x0028D030
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060090B5 RID: 37045 RVA: 0x0028EE40 File Offset: 0x0028D040
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400541E RID: 21534
		private Table __p;
	}
}
