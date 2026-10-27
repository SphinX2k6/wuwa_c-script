using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFA RID: 3322
	public struct GiantEntrust : IFlatbufferObject
	{
		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06007A56 RID: 31318 RVA: 0x0024AD25 File Offset: 0x00248F25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x0024AD32 File Offset: 0x00248F32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x0024AD3C File Offset: 0x00248F3C
		public static GiantEntrust GetRootAsGiantEntrust(ByteBuffer _bb)
		{
			return GiantEntrust.GetRootAsGiantEntrust(_bb, default(GiantEntrust));
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x0024AD58 File Offset: 0x00248F58
		public static GiantEntrust GetRootAsGiantEntrust(ByteBuffer _bb, GiantEntrust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x0024AD75 File Offset: 0x00248F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x0024AD84 File Offset: 0x00248F84
		public GiantEntrust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06007A5C RID: 31324 RVA: 0x0024AD94 File Offset: 0x00248F94
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

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06007A5D RID: 31325 RVA: 0x0024ADD0 File Offset: 0x00248FD0
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

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06007A5E RID: 31326 RVA: 0x0024AE0C File Offset: 0x0024900C
		public int QuestId
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

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06007A5F RID: 31327 RVA: 0x0024AE48 File Offset: 0x00249048
		public int UnlockCondition
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

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06007A60 RID: 31328 RVA: 0x0024AE88 File Offset: 0x00249088
		public int AddValue
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

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06007A61 RID: 31329 RVA: 0x0024AEC8 File Offset: 0x002490C8
		public int ItemId
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

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06007A62 RID: 31330 RVA: 0x0024AF08 File Offset: 0x00249108
		public int ItemId2
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

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06007A63 RID: 31331 RVA: 0x0024AF48 File Offset: 0x00249148
		public string EntrustDesc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x0024AF80 File Offset: 0x00249180
		public Span<byte> GetEntrustDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x0024AF90 File Offset: 0x00249190
		public byte[] GetEntrustDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D6D RID: 19821
		private Table __p;
	}
}
