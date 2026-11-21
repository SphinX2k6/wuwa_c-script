using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9F RID: 3231
	public struct DangoBrawlBuff : IFlatbufferObject
	{
		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060062AF RID: 25263 RVA: 0x00227100 File Offset: 0x00225300
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x0022710D File Offset: 0x0022530D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x00227114 File Offset: 0x00225314
		public static DangoBrawlBuff GetRootAsDangoBrawlBuff(ByteBuffer _bb)
		{
			return DangoBrawlBuff.GetRootAsDangoBrawlBuff(_bb, default(DangoBrawlBuff));
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x00227130 File Offset: 0x00225330
		public static DangoBrawlBuff GetRootAsDangoBrawlBuff(ByteBuffer _bb, DangoBrawlBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x0022714D File Offset: 0x0022534D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x0022715C File Offset: 0x0022535C
		public DangoBrawlBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060062B5 RID: 25269 RVA: 0x0022716C File Offset: 0x0022536C
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

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060062B6 RID: 25270 RVA: 0x002271A8 File Offset: 0x002253A8
		public string Name
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

		// Token: 0x060062B7 RID: 25271 RVA: 0x002271DF File Offset: 0x002253DF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x002271EE File Offset: 0x002253EE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060062B9 RID: 25273 RVA: 0x00227208 File Offset: 0x00225408
		public string NameColor
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

		// Token: 0x060062BA RID: 25274 RVA: 0x0022723F File Offset: 0x0022543F
		public Span<byte> GetNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x0022724E File Offset: 0x0022544E
		public byte[] GetNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060062BC RID: 25276 RVA: 0x00227268 File Offset: 0x00225468
		public string Icon
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

		// Token: 0x060062BD RID: 25277 RVA: 0x002272A0 File Offset: 0x002254A0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x002272B0 File Offset: 0x002254B0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060062BF RID: 25279 RVA: 0x002272C8 File Offset: 0x002254C8
		public string HoldIcon
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

		// Token: 0x060062C0 RID: 25280 RVA: 0x00227300 File Offset: 0x00225500
		public Span<byte> GetHoldIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x00227310 File Offset: 0x00225510
		public byte[] GetHoldIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060062C2 RID: 25282 RVA: 0x00227328 File Offset: 0x00225528
		public string GrayIcon
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

		// Token: 0x060062C3 RID: 25283 RVA: 0x00227360 File Offset: 0x00225560
		public Span<byte> GetGrayIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x00227370 File Offset: 0x00225570
		public byte[] GetGrayIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060062C5 RID: 25285 RVA: 0x00227388 File Offset: 0x00225588
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

		// Token: 0x060062C6 RID: 25286 RVA: 0x002273C0 File Offset: 0x002255C0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x002273D0 File Offset: 0x002255D0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060062C8 RID: 25288 RVA: 0x002273E8 File Offset: 0x002255E8
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060062C9 RID: 25289 RVA: 0x00227428 File Offset: 0x00225628
		public int BuffType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060062CA RID: 25290 RVA: 0x00227468 File Offset: 0x00225668
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060062CB RID: 25291 RVA: 0x002274A8 File Offset: 0x002256A8
		public string EffectDA
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x002274E0 File Offset: 0x002256E0
		public Span<byte> GetEffectDABytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x002274F0 File Offset: 0x002256F0
		public byte[] GetEffectDAArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060062CE RID: 25294 RVA: 0x00227508 File Offset: 0x00225708
		public int DamageTxtBuffId
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x060062CF RID: 25295 RVA: 0x00227548 File Offset: 0x00225748
		public bool NeedBuffChangeUIEffect
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x060062D0 RID: 25296 RVA: 0x00227588 File Offset: 0x00225788
		public bool NeedBuffTickUIEffect
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060062D1 RID: 25297 RVA: 0x002275C8 File Offset: 0x002257C8
		public bool NeedBuffChangeUICD
		{
			get
			{
				int num = this.__p.__offset(32);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060062D2 RID: 25298 RVA: 0x00227608 File Offset: 0x00225808
		public bool NeedBuffTickUICD
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040051C6 RID: 20934
		private Table __p;
	}
}
