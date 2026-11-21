using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001067 RID: 4199
	public struct QuickChat : IFlatbufferObject
	{
		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x0600BD8B RID: 48523 RVA: 0x002F00FE File Offset: 0x002EE2FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x002F010B File Offset: 0x002EE30B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD8D RID: 48525 RVA: 0x002F0114 File Offset: 0x002EE314
		public static QuickChat GetRootAsQuickChat(ByteBuffer _bb)
		{
			return QuickChat.GetRootAsQuickChat(_bb, default(QuickChat));
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x002F0130 File Offset: 0x002EE330
		public static QuickChat GetRootAsQuickChat(ByteBuffer _bb, QuickChat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD8F RID: 48527 RVA: 0x002F014D File Offset: 0x002EE34D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD90 RID: 48528 RVA: 0x002F015C File Offset: 0x002EE35C
		public QuickChat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x0600BD91 RID: 48529 RVA: 0x002F016C File Offset: 0x002EE36C
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

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x0600BD92 RID: 48530 RVA: 0x002F01A8 File Offset: 0x002EE3A8
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

		// Token: 0x0600BD93 RID: 48531 RVA: 0x002F01DF File Offset: 0x002EE3DF
		public Span<byte> GetQuickChatContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x002F01EE File Offset: 0x002EE3EE
		public byte[] GetQuickChatContentArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005635 RID: 22069
		private Table __p;
	}
}
