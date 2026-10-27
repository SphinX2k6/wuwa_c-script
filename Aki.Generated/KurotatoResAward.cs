using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB0 RID: 3504
	public struct KurotatoResAward : IFlatbufferObject
	{
		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06008B69 RID: 35689 RVA: 0x00271F00 File Offset: 0x00270100
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x00271F0D File Offset: 0x0027010D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x00271F14 File Offset: 0x00270114
		public static KurotatoResAward GetRootAsKurotatoResAward(ByteBuffer _bb)
		{
			return KurotatoResAward.GetRootAsKurotatoResAward(_bb, default(KurotatoResAward));
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x00271F30 File Offset: 0x00270130
		public static KurotatoResAward GetRootAsKurotatoResAward(ByteBuffer _bb, KurotatoResAward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x00271F4D File Offset: 0x0027014D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x00271F5C File Offset: 0x0027015C
		public KurotatoResAward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06008B6F RID: 35695 RVA: 0x00271F6C File Offset: 0x0027016C
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

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06008B70 RID: 35696 RVA: 0x00271FA8 File Offset: 0x002701A8
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

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06008B71 RID: 35697 RVA: 0x00271FE4 File Offset: 0x002701E4
		public int AwardType
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

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06008B72 RID: 35698 RVA: 0x00272020 File Offset: 0x00270220
		public int DropId
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

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06008B73 RID: 35699 RVA: 0x00272060 File Offset: 0x00270260
		public int TabId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06008B74 RID: 35700 RVA: 0x002720A0 File Offset: 0x002702A0
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008B75 RID: 35701 RVA: 0x002720D8 File Offset: 0x002702D8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x002720E8 File Offset: 0x002702E8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E42 RID: 20034
		private Table __p;
	}
}
