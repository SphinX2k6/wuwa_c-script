using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BBD RID: 3005
	public struct DangoBrawlBuff : IFlatbufferObject
	{
		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06005CD6 RID: 23766 RVA: 0x0020785C File Offset: 0x00205A5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005CD7 RID: 23767 RVA: 0x00207869 File Offset: 0x00205A69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005CD8 RID: 23768 RVA: 0x00207870 File Offset: 0x00205A70
		public static DangoBrawlBuff GetRootAsDangoBrawlBuff(ByteBuffer _bb)
		{
			return DangoBrawlBuff.GetRootAsDangoBrawlBuff(_bb, default(DangoBrawlBuff));
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x0020788C File Offset: 0x00205A8C
		public static DangoBrawlBuff GetRootAsDangoBrawlBuff(ByteBuffer _bb, DangoBrawlBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x002078A9 File Offset: 0x00205AA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x002078B8 File Offset: 0x00205AB8
		public DangoBrawlBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06005CDC RID: 23772 RVA: 0x002078C8 File Offset: 0x00205AC8
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

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06005CDD RID: 23773 RVA: 0x00207904 File Offset: 0x00205B04
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

		// Token: 0x06005CDE RID: 23774 RVA: 0x0020793B File Offset: 0x00205B3B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x0020794A File Offset: 0x00205B4A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x00207964 File Offset: 0x00205B64
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

		// Token: 0x06005CE1 RID: 23777 RVA: 0x0020799B File Offset: 0x00205B9B
		public Span<byte> GetNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x002079AA File Offset: 0x00205BAA
		public byte[] GetNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06005CE3 RID: 23779 RVA: 0x002079C4 File Offset: 0x00205BC4
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

		// Token: 0x06005CE4 RID: 23780 RVA: 0x002079FC File Offset: 0x00205BFC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x00207A0C File Offset: 0x00205C0C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06005CE6 RID: 23782 RVA: 0x00207A24 File Offset: 0x00205C24
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

		// Token: 0x06005CE7 RID: 23783 RVA: 0x00207A5C File Offset: 0x00205C5C
		public Span<byte> GetHoldIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005CE8 RID: 23784 RVA: 0x00207A6C File Offset: 0x00205C6C
		public byte[] GetHoldIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x00207A84 File Offset: 0x00205C84
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

		// Token: 0x06005CEA RID: 23786 RVA: 0x00207ABC File Offset: 0x00205CBC
		public Span<byte> GetGrayIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005CEB RID: 23787 RVA: 0x00207ACC File Offset: 0x00205CCC
		public byte[] GetGrayIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06005CEC RID: 23788 RVA: 0x00207AE4 File Offset: 0x00205CE4
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

		// Token: 0x06005CED RID: 23789 RVA: 0x00207B1C File Offset: 0x00205D1C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x00207B2C File Offset: 0x00205D2C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x00207B44 File Offset: 0x00205D44
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

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x00207B84 File Offset: 0x00205D84
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

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06005CF1 RID: 23793 RVA: 0x00207BC4 File Offset: 0x00205DC4
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x00207C04 File Offset: 0x00205E04
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

		// Token: 0x06005CF3 RID: 23795 RVA: 0x00207C3C File Offset: 0x00205E3C
		public Span<byte> GetEffectDABytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x00207C4C File Offset: 0x00205E4C
		public byte[] GetEffectDAArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06005CF5 RID: 23797 RVA: 0x00207C64 File Offset: 0x00205E64
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

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x00207CA4 File Offset: 0x00205EA4
		public bool NeedBuffChangeUIEffect
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06005CF7 RID: 23799 RVA: 0x00207CE4 File Offset: 0x00205EE4
		public bool NeedBuffTickUIEffect
		{
			get
			{
				int num = this.__p.__offset(30);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x00207D24 File Offset: 0x00205F24
		public bool NeedBuffChangeUICD
		{
			get
			{
				int num = this.__p.__offset(32);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06005CF9 RID: 23801 RVA: 0x00207D64 File Offset: 0x00205F64
		public bool NeedBuffTickUICD
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004BE4 RID: 19428
		private Table __p;
	}
}
