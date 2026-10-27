using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001080 RID: 4224
	public struct RoverRogueQuality : IFlatbufferObject
	{
		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600CE78 RID: 52856 RVA: 0x00307869 File Offset: 0x00305A69
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CE79 RID: 52857 RVA: 0x00307876 File Offset: 0x00305A76
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CE7A RID: 52858 RVA: 0x00307880 File Offset: 0x00305A80
		public static RoverRogueQuality GetRootAsRoverRogueQuality(ByteBuffer _bb)
		{
			return RoverRogueQuality.GetRootAsRoverRogueQuality(_bb, default(RoverRogueQuality));
		}

		// Token: 0x0600CE7B RID: 52859 RVA: 0x0030789C File Offset: 0x00305A9C
		public static RoverRogueQuality GetRootAsRoverRogueQuality(ByteBuffer _bb, RoverRogueQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CE7C RID: 52860 RVA: 0x003078B9 File Offset: 0x00305AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CE7D RID: 52861 RVA: 0x003078C8 File Offset: 0x00305AC8
		public RoverRogueQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600CE7E RID: 52862 RVA: 0x003078D8 File Offset: 0x00305AD8
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

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600CE7F RID: 52863 RVA: 0x00307914 File Offset: 0x00305B14
		public string Desc
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

		// Token: 0x0600CE80 RID: 52864 RVA: 0x0030794B File Offset: 0x00305B4B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CE81 RID: 52865 RVA: 0x0030795A File Offset: 0x00305B5A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600CE82 RID: 52866 RVA: 0x00307974 File Offset: 0x00305B74
		public string BlessCardTop
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

		// Token: 0x0600CE83 RID: 52867 RVA: 0x003079AB File Offset: 0x00305BAB
		public Span<byte> GetBlessCardTopBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CE84 RID: 52868 RVA: 0x003079BA File Offset: 0x00305BBA
		public byte[] GetBlessCardTopArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600CE85 RID: 52869 RVA: 0x003079D4 File Offset: 0x00305BD4
		public string BlessCardTheme
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

		// Token: 0x0600CE86 RID: 52870 RVA: 0x00307A0C File Offset: 0x00305C0C
		public Span<byte> GetBlessCardThemeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CE87 RID: 52871 RVA: 0x00307A1C File Offset: 0x00305C1C
		public byte[] GetBlessCardThemeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600CE88 RID: 52872 RVA: 0x00307A34 File Offset: 0x00305C34
		public string BlessSuitIcon
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

		// Token: 0x0600CE89 RID: 52873 RVA: 0x00307A6C File Offset: 0x00305C6C
		public Span<byte> GetBlessSuitIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CE8A RID: 52874 RVA: 0x00307A7C File Offset: 0x00305C7C
		public byte[] GetBlessSuitIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600CE8B RID: 52875 RVA: 0x00307A94 File Offset: 0x00305C94
		public string BlessSlotQuality
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

		// Token: 0x0600CE8C RID: 52876 RVA: 0x00307ACC File Offset: 0x00305CCC
		public Span<byte> GetBlessSlotQualityBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CE8D RID: 52877 RVA: 0x00307ADC File Offset: 0x00305CDC
		public byte[] GetBlessSlotQualityArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600CE8E RID: 52878 RVA: 0x00307AF4 File Offset: 0x00305CF4
		public string ItemCard
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CE8F RID: 52879 RVA: 0x00307B2C File Offset: 0x00305D2C
		public Span<byte> GetItemCardBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x00307B3C File Offset: 0x00305D3C
		public byte[] GetItemCardArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600CE91 RID: 52881 RVA: 0x00307B54 File Offset: 0x00305D54
		public string ItemGridSprite
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

		// Token: 0x0600CE92 RID: 52882 RVA: 0x00307B8C File Offset: 0x00305D8C
		public Span<byte> GetItemGridSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x00307B9C File Offset: 0x00305D9C
		public byte[] GetItemGridSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0400518A RID: 20874
		private Table __p;
	}
}
