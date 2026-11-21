using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4A RID: 3402
	public struct FeiXuePreheat : IFlatbufferObject
	{
		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x0600737F RID: 29567 RVA: 0x0024BEBE File Offset: 0x0024A0BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x0024BECB File Offset: 0x0024A0CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x0024BED4 File Offset: 0x0024A0D4
		public static FeiXuePreheat GetRootAsFeiXuePreheat(ByteBuffer _bb)
		{
			return FeiXuePreheat.GetRootAsFeiXuePreheat(_bb, default(FeiXuePreheat));
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x0024BEF0 File Offset: 0x0024A0F0
		public static FeiXuePreheat GetRootAsFeiXuePreheat(ByteBuffer _bb, FeiXuePreheat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x0024BF0D File Offset: 0x0024A10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x0024BF1C File Offset: 0x0024A11C
		public FeiXuePreheat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06007385 RID: 29573 RVA: 0x0024BF2C File Offset: 0x0024A12C
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

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06007386 RID: 29574 RVA: 0x0024BF68 File Offset: 0x0024A168
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

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06007387 RID: 29575 RVA: 0x0024BFA4 File Offset: 0x0024A1A4
		public int DropId
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

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06007388 RID: 29576 RVA: 0x0024BFE0 File Offset: 0x0024A1E0
		public int QuestId
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

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06007389 RID: 29577 RVA: 0x0024C020 File Offset: 0x0024A220
		public string QuestName
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

		// Token: 0x0600738A RID: 29578 RVA: 0x0024C058 File Offset: 0x0024A258
		public Span<byte> GetQuestNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x0024C068 File Offset: 0x0024A268
		public byte[] GetQuestNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x0600738C RID: 29580 RVA: 0x0024C080 File Offset: 0x0024A280
		public string QuestDesc
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

		// Token: 0x0600738D RID: 29581 RVA: 0x0024C0B8 File Offset: 0x0024A2B8
		public Span<byte> GetQuestDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x0024C0C8 File Offset: 0x0024A2C8
		public byte[] GetQuestDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005295 RID: 21141
		private Table __p;
	}
}
