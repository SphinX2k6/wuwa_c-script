using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010E5 RID: 4325
	public struct RogueResEnd : IFlatbufferObject
	{
		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0600C824 RID: 51236 RVA: 0x00307654 File Offset: 0x00305854
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C825 RID: 51237 RVA: 0x00307661 File Offset: 0x00305861
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C826 RID: 51238 RVA: 0x00307668 File Offset: 0x00305868
		public static RogueResEnd GetRootAsRogueResEnd(ByteBuffer _bb)
		{
			return RogueResEnd.GetRootAsRogueResEnd(_bb, default(RogueResEnd));
		}

		// Token: 0x0600C827 RID: 51239 RVA: 0x00307684 File Offset: 0x00305884
		public static RogueResEnd GetRootAsRogueResEnd(ByteBuffer _bb, RogueResEnd obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C828 RID: 51240 RVA: 0x003076A1 File Offset: 0x003058A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C829 RID: 51241 RVA: 0x003076B0 File Offset: 0x003058B0
		public RogueResEnd __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0600C82A RID: 51242 RVA: 0x003076C0 File Offset: 0x003058C0
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

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0600C82B RID: 51243 RVA: 0x003076FC File Offset: 0x003058FC
		public int SeasonId
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

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x0600C82C RID: 51244 RVA: 0x00307738 File Offset: 0x00305938
		public int InstId
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

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x0600C82D RID: 51245 RVA: 0x00307774 File Offset: 0x00305974
		public string CGF
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

		// Token: 0x0600C82E RID: 51246 RVA: 0x003077AC File Offset: 0x003059AC
		public Span<byte> GetCGFBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C82F RID: 51247 RVA: 0x003077BC File Offset: 0x003059BC
		public byte[] GetCGFArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0600C830 RID: 51248 RVA: 0x003077D4 File Offset: 0x003059D4
		public string CGM
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

		// Token: 0x0600C831 RID: 51249 RVA: 0x0030780C File Offset: 0x00305A0C
		public Span<byte> GetCGMBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C832 RID: 51250 RVA: 0x0030781C File Offset: 0x00305A1C
		public byte[] GetCGMArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0600C833 RID: 51251 RVA: 0x00307834 File Offset: 0x00305A34
		public string Title
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

		// Token: 0x0600C834 RID: 51252 RVA: 0x0030786C File Offset: 0x00305A6C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C835 RID: 51253 RVA: 0x0030787C File Offset: 0x00305A7C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0600C836 RID: 51254 RVA: 0x00307894 File Offset: 0x00305A94
		public string Desc
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

		// Token: 0x0600C837 RID: 51255 RVA: 0x003078CC File Offset: 0x00305ACC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C838 RID: 51256 RVA: 0x003078DC File Offset: 0x00305ADC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0600C839 RID: 51257 RVA: 0x003078F4 File Offset: 0x00305AF4
		public string WinTitle
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

		// Token: 0x0600C83A RID: 51258 RVA: 0x0030792C File Offset: 0x00305B2C
		public Span<byte> GetWinTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C83B RID: 51259 RVA: 0x0030793C File Offset: 0x00305B3C
		public byte[] GetWinTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0600C83C RID: 51260 RVA: 0x00307954 File Offset: 0x00305B54
		public string WinDesc
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C83D RID: 51261 RVA: 0x0030798C File Offset: 0x00305B8C
		public Span<byte> GetWinDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C83E RID: 51262 RVA: 0x0030799C File Offset: 0x00305B9C
		public byte[] GetWinDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x040056CD RID: 22221
		private Table __p;
	}
}
