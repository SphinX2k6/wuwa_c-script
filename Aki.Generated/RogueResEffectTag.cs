using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E4 RID: 4324
	public struct RogueResEffectTag : IFlatbufferObject
	{
		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0600C813 RID: 51219 RVA: 0x0030744C File Offset: 0x0030564C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C814 RID: 51220 RVA: 0x00307459 File Offset: 0x00305659
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C815 RID: 51221 RVA: 0x00307460 File Offset: 0x00305660
		public static RogueResEffectTag GetRootAsRogueResEffectTag(ByteBuffer _bb)
		{
			return RogueResEffectTag.GetRootAsRogueResEffectTag(_bb, default(RogueResEffectTag));
		}

		// Token: 0x0600C816 RID: 51222 RVA: 0x0030747C File Offset: 0x0030567C
		public static RogueResEffectTag GetRootAsRogueResEffectTag(ByteBuffer _bb, RogueResEffectTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C817 RID: 51223 RVA: 0x00307499 File Offset: 0x00305699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C818 RID: 51224 RVA: 0x003074A8 File Offset: 0x003056A8
		public RogueResEffectTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x0600C819 RID: 51225 RVA: 0x003074B8 File Offset: 0x003056B8
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

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x0600C81A RID: 51226 RVA: 0x003074F4 File Offset: 0x003056F4
		public string Tag
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

		// Token: 0x0600C81B RID: 51227 RVA: 0x0030752B File Offset: 0x0030572B
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C81C RID: 51228 RVA: 0x0030753A File Offset: 0x0030573A
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x0600C81D RID: 51229 RVA: 0x00307554 File Offset: 0x00305754
		public string Text
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

		// Token: 0x0600C81E RID: 51230 RVA: 0x0030758B File Offset: 0x0030578B
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C81F RID: 51231 RVA: 0x0030759A File Offset: 0x0030579A
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0600C820 RID: 51232 RVA: 0x003075B4 File Offset: 0x003057B4
		public bool IsRatio
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0600C821 RID: 51233 RVA: 0x003075F4 File Offset: 0x003057F4
		public string Icon
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

		// Token: 0x0600C822 RID: 51234 RVA: 0x0030762C File Offset: 0x0030582C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C823 RID: 51235 RVA: 0x0030763C File Offset: 0x0030583C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040056CC RID: 22220
		private Table __p;
	}
}
