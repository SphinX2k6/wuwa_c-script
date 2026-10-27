using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001017 RID: 4119
	public struct RogueResTask : IFlatbufferObject
	{
		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x0600C42C RID: 50220 RVA: 0x002F037E File Offset: 0x002EE57E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C42D RID: 50221 RVA: 0x002F038B File Offset: 0x002EE58B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C42E RID: 50222 RVA: 0x002F0394 File Offset: 0x002EE594
		public static RogueResTask GetRootAsRogueResTask(ByteBuffer _bb)
		{
			return RogueResTask.GetRootAsRogueResTask(_bb, default(RogueResTask));
		}

		// Token: 0x0600C42F RID: 50223 RVA: 0x002F03B0 File Offset: 0x002EE5B0
		public static RogueResTask GetRootAsRogueResTask(ByteBuffer _bb, RogueResTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C430 RID: 50224 RVA: 0x002F03CD File Offset: 0x002EE5CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x002F03DC File Offset: 0x002EE5DC
		public RogueResTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x0600C432 RID: 50226 RVA: 0x002F03EC File Offset: 0x002EE5EC
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

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x0600C433 RID: 50227 RVA: 0x002F0428 File Offset: 0x002EE628
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

		// Token: 0x0600C434 RID: 50228 RVA: 0x002F045F File Offset: 0x002EE65F
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C435 RID: 50229 RVA: 0x002F046E File Offset: 0x002EE66E
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x0600C436 RID: 50230 RVA: 0x002F0488 File Offset: 0x002EE688
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

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0600C437 RID: 50231 RVA: 0x002F04C4 File Offset: 0x002EE6C4
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

		// Token: 0x04005105 RID: 20741
		private Table __p;
	}
}
