using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B0C RID: 2828
	public struct ArtemisChat : IFlatbufferObject
	{
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06004939 RID: 18745 RVA: 0x001D928D File Offset: 0x001D748D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x001D929A File Offset: 0x001D749A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x001D92A4 File Offset: 0x001D74A4
		public static ArtemisChat GetRootAsArtemisChat(ByteBuffer _bb)
		{
			return ArtemisChat.GetRootAsArtemisChat(_bb, default(ArtemisChat));
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x001D92C0 File Offset: 0x001D74C0
		public static ArtemisChat GetRootAsArtemisChat(ByteBuffer _bb, ArtemisChat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x001D92DD File Offset: 0x001D74DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x001D92EC File Offset: 0x001D74EC
		public ArtemisChat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600493F RID: 18751 RVA: 0x001D92FC File Offset: 0x001D74FC
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

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x001D9338 File Offset: 0x001D7538
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

		// Token: 0x06004941 RID: 18753 RVA: 0x001D936F File Offset: 0x001D756F
		public Span<byte> GetLockChatContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x001D937E File Offset: 0x001D757E
		public byte[] GetLockChatContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06004943 RID: 18755 RVA: 0x001D9398 File Offset: 0x001D7598
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

		// Token: 0x06004944 RID: 18756 RVA: 0x001D93CF File Offset: 0x001D75CF
		public Span<byte> GetLockChatTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x001D93DE File Offset: 0x001D75DE
		public byte[] GetLockChatTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06004946 RID: 18758 RVA: 0x001D93F8 File Offset: 0x001D75F8
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

		// Token: 0x06004947 RID: 18759 RVA: 0x001D9430 File Offset: 0x001D7630
		public Span<byte> GetChatContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x001D9440 File Offset: 0x001D7640
		public byte[] GetChatContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06004949 RID: 18761 RVA: 0x001D9458 File Offset: 0x001D7658
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

		// Token: 0x0600494A RID: 18762 RVA: 0x001D9490 File Offset: 0x001D7690
		public Span<byte> GetChatTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x001D94A0 File Offset: 0x001D76A0
		public byte[] GetChatTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600494C RID: 18764 RVA: 0x001D94B8 File Offset: 0x001D76B8
		public bool IsLeft
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004AF1 RID: 19185
		private Table __p;
	}
}
