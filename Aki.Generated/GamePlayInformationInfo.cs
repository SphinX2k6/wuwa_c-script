using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD0 RID: 3536
	public struct GamePlayInformationInfo : IFlatbufferObject
	{
		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06007F54 RID: 32596 RVA: 0x0026736A File Offset: 0x0026556A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F55 RID: 32597 RVA: 0x00267377 File Offset: 0x00265577
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x00267380 File Offset: 0x00265580
		public static GamePlayInformationInfo GetRootAsGamePlayInformationInfo(ByteBuffer _bb)
		{
			return GamePlayInformationInfo.GetRootAsGamePlayInformationInfo(_bb, default(GamePlayInformationInfo));
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x0026739C File Offset: 0x0026559C
		public static GamePlayInformationInfo GetRootAsGamePlayInformationInfo(ByteBuffer _bb, GamePlayInformationInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x002673B9 File Offset: 0x002655B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x002673C8 File Offset: 0x002655C8
		public GamePlayInformationInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06007F5A RID: 32602 RVA: 0x002673D8 File Offset: 0x002655D8
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

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06007F5B RID: 32603 RVA: 0x00267414 File Offset: 0x00265614
		public int Type
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

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06007F5C RID: 32604 RVA: 0x00267450 File Offset: 0x00265650
		public string Info
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

		// Token: 0x06007F5D RID: 32605 RVA: 0x00267487 File Offset: 0x00265687
		public Span<byte> GetInfoBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x00267496 File Offset: 0x00265696
		public byte[] GetInfoArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005341 RID: 21313
		private Table __p;
	}
}
