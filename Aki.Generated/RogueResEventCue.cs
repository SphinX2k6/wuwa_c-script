using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001002 RID: 4098
	public struct RogueResEventCue : IFlatbufferObject
	{
		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x0600C24C RID: 49740 RVA: 0x002EC271 File Offset: 0x002EA471
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C24D RID: 49741 RVA: 0x002EC27E File Offset: 0x002EA47E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C24E RID: 49742 RVA: 0x002EC288 File Offset: 0x002EA488
		public static RogueResEventCue GetRootAsRogueResEventCue(ByteBuffer _bb)
		{
			return RogueResEventCue.GetRootAsRogueResEventCue(_bb, default(RogueResEventCue));
		}

		// Token: 0x0600C24F RID: 49743 RVA: 0x002EC2A4 File Offset: 0x002EA4A4
		public static RogueResEventCue GetRootAsRogueResEventCue(ByteBuffer _bb, RogueResEventCue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C250 RID: 49744 RVA: 0x002EC2C1 File Offset: 0x002EA4C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x002EC2D0 File Offset: 0x002EA4D0
		public RogueResEventCue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x0600C252 RID: 49746 RVA: 0x002EC2E0 File Offset: 0x002EA4E0
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

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x0600C253 RID: 49747 RVA: 0x002EC31C File Offset: 0x002EA51C
		public string Type
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

		// Token: 0x0600C254 RID: 49748 RVA: 0x002EC353 File Offset: 0x002EA553
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C255 RID: 49749 RVA: 0x002EC362 File Offset: 0x002EA562
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x0600C256 RID: 49750 RVA: 0x002EC37C File Offset: 0x002EA57C
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0600C257 RID: 49751 RVA: 0x002EC3BC File Offset: 0x002EA5BC
		public string FxColor
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C258 RID: 49752 RVA: 0x002EC3F4 File Offset: 0x002EA5F4
		public Span<byte> GetFxColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C259 RID: 49753 RVA: 0x002EC404 File Offset: 0x002EA604
		public byte[] GetFxColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x0600C25A RID: 49754 RVA: 0x002EC41C File Offset: 0x002EA61C
		public string SpriteColor
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

		// Token: 0x0600C25B RID: 49755 RVA: 0x002EC454 File Offset: 0x002EA654
		public Span<byte> GetSpriteColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C25C RID: 49756 RVA: 0x002EC464 File Offset: 0x002EA664
		public byte[] GetSpriteColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x0600C25D RID: 49757 RVA: 0x002EC47C File Offset: 0x002EA67C
		public string IconPath
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

		// Token: 0x0600C25E RID: 49758 RVA: 0x002EC4B4 File Offset: 0x002EA6B4
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C25F RID: 49759 RVA: 0x002EC4C4 File Offset: 0x002EA6C4
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040050EA RID: 20714
		private Table __p;
	}
}
