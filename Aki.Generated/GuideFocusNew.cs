using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D18 RID: 3352
	public struct GuideFocusNew : IFlatbufferObject
	{
		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06007C97 RID: 31895 RVA: 0x0024FD08 File Offset: 0x0024DF08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x0024FD15 File Offset: 0x0024DF15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x0024FD1C File Offset: 0x0024DF1C
		public static GuideFocusNew GetRootAsGuideFocusNew(ByteBuffer _bb)
		{
			return GuideFocusNew.GetRootAsGuideFocusNew(_bb, default(GuideFocusNew));
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x0024FD38 File Offset: 0x0024DF38
		public static GuideFocusNew GetRootAsGuideFocusNew(ByteBuffer _bb, GuideFocusNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C9B RID: 31899 RVA: 0x0024FD55 File Offset: 0x0024DF55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x0024FD64 File Offset: 0x0024DF64
		public GuideFocusNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06007C9D RID: 31901 RVA: 0x0024FD74 File Offset: 0x0024DF74
		public int GuideId
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

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06007C9E RID: 31902 RVA: 0x0024FDB0 File Offset: 0x0024DFB0
		public string ViewName
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

		// Token: 0x06007C9F RID: 31903 RVA: 0x0024FDE7 File Offset: 0x0024DFE7
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x0024FDF6 File Offset: 0x0024DFF6
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06007CA1 RID: 31905 RVA: 0x0024FE10 File Offset: 0x0024E010
		public string DynamicTabName
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

		// Token: 0x06007CA2 RID: 31906 RVA: 0x0024FE47 File Offset: 0x0024E047
		public Span<byte> GetDynamicTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x0024FE56 File Offset: 0x0024E056
		public byte[] GetDynamicTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06007CA4 RID: 31908 RVA: 0x0024FE70 File Offset: 0x0024E070
		public string Platform
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

		// Token: 0x06007CA5 RID: 31909 RVA: 0x0024FEA8 File Offset: 0x0024E0A8
		public Span<byte> GetPlatformBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x0024FEB8 File Offset: 0x0024E0B8
		public byte[] GetPlatformArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x0024FED0 File Offset: 0x0024E0D0
		public string MultiGuideBox(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06007CA8 RID: 31912 RVA: 0x0024FF0C File Offset: 0x0024E10C
		public int MultiGuideBoxLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06007CA9 RID: 31913 RVA: 0x0024FF38 File Offset: 0x0024E138
		public string GuideMarkName
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

		// Token: 0x06007CAA RID: 31914 RVA: 0x0024FF70 File Offset: 0x0024E170
		public Span<byte> GetGuideMarkNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007CAB RID: 31915 RVA: 0x0024FF80 File Offset: 0x0024E180
		public byte[] GetGuideMarkNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06007CAC RID: 31916 RVA: 0x0024FF98 File Offset: 0x0024E198
		public string GuideMarkNameForShow
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

		// Token: 0x06007CAD RID: 31917 RVA: 0x0024FFD0 File Offset: 0x0024E1D0
		public Span<byte> GetGuideMarkNameForShowBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007CAE RID: 31918 RVA: 0x0024FFE0 File Offset: 0x0024E1E0
		public byte[] GetGuideMarkNameForShowArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06007CAF RID: 31919 RVA: 0x0024FFF8 File Offset: 0x0024E1F8
		public string HookName
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

		// Token: 0x06007CB0 RID: 31920 RVA: 0x00250030 File Offset: 0x0024E230
		public Span<byte> GetHookNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x00250040 File Offset: 0x0024E240
		public byte[] GetHookNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06007CB2 RID: 31922 RVA: 0x00250058 File Offset: 0x0024E258
		public string HookNameForShow
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

		// Token: 0x06007CB3 RID: 31923 RVA: 0x00250090 File Offset: 0x0024E290
		public Span<byte> GetHookNameForShowBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x002500A0 File Offset: 0x0024E2A0
		public byte[] GetHookNameForShowArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x002500B8 File Offset: 0x0024E2B8
		public string ExtraParam(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x002500F4 File Offset: 0x0024E2F4
		public int ExtraParamLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06007CB7 RID: 31927 RVA: 0x00250120 File Offset: 0x0024E320
		public string ExtraParamDesc
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

		// Token: 0x06007CB8 RID: 31928 RVA: 0x00250158 File Offset: 0x0024E358
		public Span<byte> GetExtraParamDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x00250168 File Offset: 0x0024E368
		public byte[] GetExtraParamDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06007CBA RID: 31930 RVA: 0x00250180 File Offset: 0x0024E380
		public string ContentDirection
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x002501B8 File Offset: 0x0024E3B8
		public Span<byte> GetContentDirectionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x002501C8 File Offset: 0x0024E3C8
		public byte[] GetContentDirectionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06007CBD RID: 31933 RVA: 0x002501E0 File Offset: 0x0024E3E0
		public bool ShowArrow
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06007CBE RID: 31934 RVA: 0x00250220 File Offset: 0x0024E420
		public string Content
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x00250258 File Offset: 0x0024E458
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007CC0 RID: 31936 RVA: 0x00250268 File Offset: 0x0024E468
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x06007CC1 RID: 31937 RVA: 0x00250280 File Offset: 0x0024E480
		public string Button(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x002502BC File Offset: 0x0024E4BC
		public int ButtonLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007CC3 RID: 31939 RVA: 0x002502E8 File Offset: 0x0024E4E8
		public string InputEnums(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06007CC4 RID: 31940 RVA: 0x00250324 File Offset: 0x0024E524
		public int InputEnumsLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007CC5 RID: 31941 RVA: 0x00250350 File Offset: 0x0024E550
		public string LimitInputEnums(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06007CC6 RID: 31942 RVA: 0x0025038C File Offset: 0x0024E58C
		public int LimitInputEnumsLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x002503B8 File Offset: 0x0024E5B8
		public bool ShowMouse
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06007CC8 RID: 31944 RVA: 0x002503F8 File Offset: 0x0024E5F8
		public bool UseMask
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x00250438 File Offset: 0x0024E638
		public bool UseClick
		{
			get
			{
				int num = this.__p.__offset(42);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06007CCA RID: 31946 RVA: 0x00250478 File Offset: 0x0024E678
		public bool ClickAnywhere
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06007CCB RID: 31947 RVA: 0x002504B8 File Offset: 0x0024E6B8
		public int ClickAnywhereShowTime
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06007CCC RID: 31948 RVA: 0x002504F8 File Offset: 0x0024E6F8
		public bool EnableHover
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06007CCD RID: 31949 RVA: 0x00250538 File Offset: 0x0024E738
		public bool EnableAllToggleState
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06007CCE RID: 31950 RVA: 0x00250578 File Offset: 0x0024E778
		public bool ExpandClickArea
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06007CCF RID: 31951 RVA: 0x002505B8 File Offset: 0x0024E7B8
		public bool OnlyFrame
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06007CD0 RID: 31952 RVA: 0x002505F8 File Offset: 0x0024E7F8
		public bool OnlyText
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06007CD1 RID: 31953 RVA: 0x00250638 File Offset: 0x0024E838
		public int RoleHeadId
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06007CD2 RID: 31954 RVA: 0x00250678 File Offset: 0x0024E878
		public string HeadImgPath
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x002506B0 File Offset: 0x0024E8B0
		public Span<byte> GetHeadImgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x002506C0 File Offset: 0x0024E8C0
		public byte[] GetHeadImgPathArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x002506D8 File Offset: 0x0024E8D8
		public float TextOffset(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06007CD6 RID: 31958 RVA: 0x0025071C File Offset: 0x0024E91C
		public int TextOffsetLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x00250748 File Offset: 0x0024E948
		public Span<float> GetTextOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(62, 4);
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x00250758 File Offset: 0x0024E958
		public float[] GetTextOffsetArray()
		{
			return this.__p.__vector_as_array<float>(62) ?? Array.Empty<float>();
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06007CD9 RID: 31961 RVA: 0x00250770 File Offset: 0x0024E970
		public bool TextInScreen
		{
			get
			{
				int num = this.__p.__offset(64);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06007CDA RID: 31962 RVA: 0x002507B0 File Offset: 0x0024E9B0
		public bool HideWhenOtherPopViewOccur
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06007CDB RID: 31963 RVA: 0x002507F0 File Offset: 0x0024E9F0
		public bool CheckShowByIsShowOrShowing
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x00250830 File Offset: 0x0024EA30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ButtonIter()或GetButtonBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Button()
		{
			return this.ButtonIter().ToArray<string>();
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x0025083D File Offset: 0x0024EA3D
		[NullableContext(1)]
		public readonly IEnumerable<string> ButtonIter()
		{
			GuideFocusNew.<ButtonIter>d__105 <ButtonIter>d__ = new GuideFocusNew.<ButtonIter>d__105(-2);
			<ButtonIter>d__.<>3__<>4__this = this;
			return <ButtonIter>d__;
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x00250852 File Offset: 0x0024EA52
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraParamIter()或GetExtraParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraParam()
		{
			return this.ExtraParamIter().ToArray<string>();
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x0025085F File Offset: 0x0024EA5F
		[NullableContext(1)]
		public readonly IEnumerable<string> ExtraParamIter()
		{
			GuideFocusNew.<ExtraParamIter>d__107 <ExtraParamIter>d__ = new GuideFocusNew.<ExtraParamIter>d__107(-2);
			<ExtraParamIter>d__.<>3__<>4__this = this;
			return <ExtraParamIter>d__;
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x00250874 File Offset: 0x0024EA74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InputEnumsIter()或GetInputEnumsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] InputEnums()
		{
			return this.InputEnumsIter().ToArray<string>();
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x00250881 File Offset: 0x0024EA81
		[NullableContext(1)]
		public readonly IEnumerable<string> InputEnumsIter()
		{
			GuideFocusNew.<InputEnumsIter>d__109 <InputEnumsIter>d__ = new GuideFocusNew.<InputEnumsIter>d__109(-2);
			<InputEnumsIter>d__.<>3__<>4__this = this;
			return <InputEnumsIter>d__;
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x00250896 File Offset: 0x0024EA96
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LimitInputEnumsIter()或GetLimitInputEnumsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] LimitInputEnums()
		{
			return this.LimitInputEnumsIter().ToArray<string>();
		}

		// Token: 0x06007CE3 RID: 31971 RVA: 0x002508A3 File Offset: 0x0024EAA3
		[NullableContext(1)]
		public readonly IEnumerable<string> LimitInputEnumsIter()
		{
			GuideFocusNew.<LimitInputEnumsIter>d__111 <LimitInputEnumsIter>d__ = new GuideFocusNew.<LimitInputEnumsIter>d__111(-2);
			<LimitInputEnumsIter>d__.<>3__<>4__this = this;
			return <LimitInputEnumsIter>d__;
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x002508B8 File Offset: 0x0024EAB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MultiGuideBoxIter()或GetMultiGuideBoxBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MultiGuideBox()
		{
			return this.MultiGuideBoxIter().ToArray<string>();
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x002508C5 File Offset: 0x0024EAC5
		[NullableContext(1)]
		public readonly IEnumerable<string> MultiGuideBoxIter()
		{
			GuideFocusNew.<MultiGuideBoxIter>d__113 <MultiGuideBoxIter>d__ = new GuideFocusNew.<MultiGuideBoxIter>d__113(-2);
			<MultiGuideBoxIter>d__.<>3__<>4__this = this;
			return <MultiGuideBoxIter>d__;
		}

		// Token: 0x06007CE6 RID: 31974 RVA: 0x002508DC File Offset: 0x0024EADC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TextOffsetIter()或GetTextOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] TextOffset()
		{
			GuideFocusNew guideFocusNew = this;
			return guideFocusNew.GetTextOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x00250900 File Offset: 0x0024EB00
		[NullableContext(1)]
		public readonly IEnumerable<float> TextOffsetIter()
		{
			GuideFocusNew.<TextOffsetIter>d__115 <TextOffsetIter>d__ = new GuideFocusNew.<TextOffsetIter>d__115(-2);
			<TextOffsetIter>d__.<>3__<>4__this = this;
			return <TextOffsetIter>d__;
		}

		// Token: 0x04004D90 RID: 19856
		private Table __p;
	}
}
