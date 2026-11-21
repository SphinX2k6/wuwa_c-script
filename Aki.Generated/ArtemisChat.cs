using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE6 RID: 3046
	public struct ArtemisChat : IFlatbufferObject
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06004E80 RID: 20096 RVA: 0x001F8A3A File Offset: 0x001F6C3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x001F8A47 File Offset: 0x001F6C47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x001F8A50 File Offset: 0x001F6C50
		public static ArtemisChat GetRootAsArtemisChat(ByteBuffer _bb)
		{
			return ArtemisChat.GetRootAsArtemisChat(_bb, default(ArtemisChat));
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x001F8A6C File Offset: 0x001F6C6C
		public static ArtemisChat GetRootAsArtemisChat(ByteBuffer _bb, ArtemisChat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x001F8A89 File Offset: 0x001F6C89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x001F8A98 File Offset: 0x001F6C98
		public ArtemisChat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06004E86 RID: 20102 RVA: 0x001F8AA8 File Offset: 0x001F6CA8
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

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06004E87 RID: 20103 RVA: 0x001F8AE4 File Offset: 0x001F6CE4
		public string LockChatContent
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

		// Token: 0x06004E88 RID: 20104 RVA: 0x001F8B1B File Offset: 0x001F6D1B
		public Span<byte> GetLockChatContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x001F8B2A File Offset: 0x001F6D2A
		public byte[] GetLockChatContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x001F8B44 File Offset: 0x001F6D44
		public string LockChatTexture
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

		// Token: 0x06004E8B RID: 20107 RVA: 0x001F8B7B File Offset: 0x001F6D7B
		public Span<byte> GetLockChatTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x001F8B8A File Offset: 0x001F6D8A
		public byte[] GetLockChatTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06004E8D RID: 20109 RVA: 0x001F8BA4 File Offset: 0x001F6DA4
		public string ChatContent
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

		// Token: 0x06004E8E RID: 20110 RVA: 0x001F8BDC File Offset: 0x001F6DDC
		public Span<byte> GetChatContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x001F8BEC File Offset: 0x001F6DEC
		public byte[] GetChatContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06004E90 RID: 20112 RVA: 0x001F8C04 File Offset: 0x001F6E04
		public string ChatTexture
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

		// Token: 0x06004E91 RID: 20113 RVA: 0x001F8C3C File Offset: 0x001F6E3C
		public Span<byte> GetChatTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x001F8C4C File Offset: 0x001F6E4C
		public byte[] GetChatTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06004E93 RID: 20115 RVA: 0x001F8C64 File Offset: 0x001F6E64
		public bool IsLeft
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040050CB RID: 20683
		private Table __p;
	}
}
