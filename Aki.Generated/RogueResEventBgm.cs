using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001001 RID: 4097
	public struct RogueResEventBgm : IFlatbufferObject
	{
		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x0600C23F RID: 49727 RVA: 0x002EC10C File Offset: 0x002EA30C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C240 RID: 49728 RVA: 0x002EC119 File Offset: 0x002EA319
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C241 RID: 49729 RVA: 0x002EC120 File Offset: 0x002EA320
		public static RogueResEventBgm GetRootAsRogueResEventBgm(ByteBuffer _bb)
		{
			return RogueResEventBgm.GetRootAsRogueResEventBgm(_bb, default(RogueResEventBgm));
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x002EC13C File Offset: 0x002EA33C
		public static RogueResEventBgm GetRootAsRogueResEventBgm(ByteBuffer _bb, RogueResEventBgm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C243 RID: 49731 RVA: 0x002EC159 File Offset: 0x002EA359
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C244 RID: 49732 RVA: 0x002EC168 File Offset: 0x002EA368
		public RogueResEventBgm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x0600C245 RID: 49733 RVA: 0x002EC178 File Offset: 0x002EA378
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

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x0600C246 RID: 49734 RVA: 0x002EC1B4 File Offset: 0x002EA3B4
		public string BgmName
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

		// Token: 0x0600C247 RID: 49735 RVA: 0x002EC1EB File Offset: 0x002EA3EB
		public Span<byte> GetBgmNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C248 RID: 49736 RVA: 0x002EC1FA File Offset: 0x002EA3FA
		public byte[] GetBgmNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x0600C249 RID: 49737 RVA: 0x002EC214 File Offset: 0x002EA414
		public string BgmPath
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

		// Token: 0x0600C24A RID: 49738 RVA: 0x002EC24B File Offset: 0x002EA44B
		public Span<byte> GetBgmPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C24B RID: 49739 RVA: 0x002EC25A File Offset: 0x002EA45A
		public byte[] GetBgmPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040050E9 RID: 20713
		private Table __p;
	}
}
