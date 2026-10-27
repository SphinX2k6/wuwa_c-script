using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE4 RID: 3556
	public struct MailFilter : IFlatbufferObject
	{
		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06009053 RID: 36947 RVA: 0x0027CC3C File Offset: 0x0027AE3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x0027CC49 File Offset: 0x0027AE49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009055 RID: 36949 RVA: 0x0027CC50 File Offset: 0x0027AE50
		public static MailFilter GetRootAsMailFilter(ByteBuffer _bb)
		{
			return MailFilter.GetRootAsMailFilter(_bb, default(MailFilter));
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x0027CC6C File Offset: 0x0027AE6C
		public static MailFilter GetRootAsMailFilter(ByteBuffer _bb, MailFilter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009057 RID: 36951 RVA: 0x0027CC89 File Offset: 0x0027AE89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x0027CC98 File Offset: 0x0027AE98
		public MailFilter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06009059 RID: 36953 RVA: 0x0027CCA8 File Offset: 0x0027AEA8
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

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x0600905A RID: 36954 RVA: 0x0027CCE4 File Offset: 0x0027AEE4
		public string IconPath
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

		// Token: 0x0600905B RID: 36955 RVA: 0x0027CD1B File Offset: 0x0027AF1B
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x0027CD2A File Offset: 0x0027AF2A
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x0600905D RID: 36957 RVA: 0x0027CD44 File Offset: 0x0027AF44
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

		// Token: 0x0600905E RID: 36958 RVA: 0x0027CD7B File Offset: 0x0027AF7B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x0027CD8A File Offset: 0x0027AF8A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E80 RID: 20096
		private Table __p;
	}
}
