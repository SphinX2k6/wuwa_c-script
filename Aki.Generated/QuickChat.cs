using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F80 RID: 3968
	public struct QuickChat : IFlatbufferObject
	{
		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x0600B74E RID: 46926 RVA: 0x002D3699 File Offset: 0x002D1899
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x002D36A6 File Offset: 0x002D18A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B750 RID: 46928 RVA: 0x002D36B0 File Offset: 0x002D18B0
		public static QuickChat GetRootAsQuickChat(ByteBuffer _bb)
		{
			return QuickChat.GetRootAsQuickChat(_bb, default(QuickChat));
		}

		// Token: 0x0600B751 RID: 46929 RVA: 0x002D36CC File Offset: 0x002D18CC
		public static QuickChat GetRootAsQuickChat(ByteBuffer _bb, QuickChat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B752 RID: 46930 RVA: 0x002D36E9 File Offset: 0x002D18E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x002D36F8 File Offset: 0x002D18F8
		public QuickChat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x0600B754 RID: 46932 RVA: 0x002D3708 File Offset: 0x002D1908
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

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x0600B755 RID: 46933 RVA: 0x002D3744 File Offset: 0x002D1944
		public string QuickChatContent
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

		// Token: 0x0600B756 RID: 46934 RVA: 0x002D377B File Offset: 0x002D197B
		public Span<byte> GetQuickChatContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x002D378A File Offset: 0x002D198A
		public byte[] GetQuickChatContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400504E RID: 20558
		private Table __p;
	}
}
