using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B67 RID: 2919
	public struct Chat : IFlatbufferObject
	{
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06005300 RID: 21248 RVA: 0x001F0B84 File Offset: 0x001EED84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x001F0B91 File Offset: 0x001EED91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x001F0B98 File Offset: 0x001EED98
		public static Chat GetRootAsChat(ByteBuffer _bb)
		{
			return Chat.GetRootAsChat(_bb, default(Chat));
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x001F0BB4 File Offset: 0x001EEDB4
		public static Chat GetRootAsChat(ByteBuffer _bb, Chat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x001F0BD1 File Offset: 0x001EEDD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x001F0BE0 File Offset: 0x001EEDE0
		public Chat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06005306 RID: 21254 RVA: 0x001F0BF0 File Offset: 0x001EEDF0
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

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06005307 RID: 21255 RVA: 0x001F0C2C File Offset: 0x001EEE2C
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

		// Token: 0x06005308 RID: 21256 RVA: 0x001F0C63 File Offset: 0x001EEE63
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x001F0C72 File Offset: 0x001EEE72
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600530A RID: 21258 RVA: 0x001F0C8C File Offset: 0x001EEE8C
		public int BuildLimit
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

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600530B RID: 21259 RVA: 0x001F0CC8 File Offset: 0x001EEEC8
		public int SaveMsgLimit
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

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600530C RID: 21260 RVA: 0x001F0D08 File Offset: 0x001EEF08
		public int LocalSaveMsgLimit
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

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600530D RID: 21261 RVA: 0x001F0D48 File Offset: 0x001EEF48
		public int SaveMsgTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600530E RID: 21262 RVA: 0x001F0D88 File Offset: 0x001EEF88
		public int ChatCd
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004B69 RID: 19305
		private Table __p;
	}
}
