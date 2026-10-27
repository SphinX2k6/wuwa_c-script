using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB1 RID: 3505
	public struct KurotatoRewardTab : IFlatbufferObject
	{
		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x00272100 File Offset: 0x00270300
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B78 RID: 35704 RVA: 0x0027210D File Offset: 0x0027030D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x00272114 File Offset: 0x00270314
		public static KurotatoRewardTab GetRootAsKurotatoRewardTab(ByteBuffer _bb)
		{
			return KurotatoRewardTab.GetRootAsKurotatoRewardTab(_bb, default(KurotatoRewardTab));
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x00272130 File Offset: 0x00270330
		public static KurotatoRewardTab GetRootAsKurotatoRewardTab(ByteBuffer _bb, KurotatoRewardTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x0027214D File Offset: 0x0027034D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x0027215C File Offset: 0x0027035C
		public KurotatoRewardTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06008B7D RID: 35709 RVA: 0x0027216C File Offset: 0x0027036C
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

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x06008B7E RID: 35710 RVA: 0x002721A8 File Offset: 0x002703A8
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

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06008B7F RID: 35711 RVA: 0x002721E4 File Offset: 0x002703E4
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

		// Token: 0x06008B80 RID: 35712 RVA: 0x0027221B File Offset: 0x0027041B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x0027222A File Offset: 0x0027042A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E43 RID: 20035
		private Table __p;
	}
}
