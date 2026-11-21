using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010FF RID: 4351
	public struct RogueResTask : IFlatbufferObject
	{
		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600CA76 RID: 51830 RVA: 0x0030C41E File Offset: 0x0030A61E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA77 RID: 51831 RVA: 0x0030C42B File Offset: 0x0030A62B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA78 RID: 51832 RVA: 0x0030C434 File Offset: 0x0030A634
		public static RogueResTask GetRootAsRogueResTask(ByteBuffer _bb)
		{
			return RogueResTask.GetRootAsRogueResTask(_bb, default(RogueResTask));
		}

		// Token: 0x0600CA79 RID: 51833 RVA: 0x0030C450 File Offset: 0x0030A650
		public static RogueResTask GetRootAsRogueResTask(ByteBuffer _bb, RogueResTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA7A RID: 51834 RVA: 0x0030C46D File Offset: 0x0030A66D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA7B RID: 51835 RVA: 0x0030C47C File Offset: 0x0030A67C
		public RogueResTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600CA7C RID: 51836 RVA: 0x0030C48C File Offset: 0x0030A68C
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

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600CA7D RID: 51837 RVA: 0x0030C4C8 File Offset: 0x0030A6C8
		public string Text
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

		// Token: 0x0600CA7E RID: 51838 RVA: 0x0030C4FF File Offset: 0x0030A6FF
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CA7F RID: 51839 RVA: 0x0030C50E File Offset: 0x0030A70E
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600CA80 RID: 51840 RVA: 0x0030C528 File Offset: 0x0030A728
		public int Type
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

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600CA81 RID: 51841 RVA: 0x0030C564 File Offset: 0x0030A764
		public int Award
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

		// Token: 0x040056ED RID: 22253
		private Table __p;
	}
}
