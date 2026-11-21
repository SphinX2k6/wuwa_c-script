using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFD RID: 3581
	public struct GuideFocusNew : IFlatbufferObject
	{
		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x060082AF RID: 33455 RVA: 0x0026E6AC File Offset: 0x0026C8AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x0026E6B9 File Offset: 0x0026C8B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x0026E6C0 File Offset: 0x0026C8C0
		public static GuideFocusNew GetRootAsGuideFocusNew(ByteBuffer _bb)
		{
			return GuideFocusNew.GetRootAsGuideFocusNew(_bb, default(GuideFocusNew));
		}

		// Token: 0x060082B2 RID: 33458 RVA: 0x0026E6DC File Offset: 0x0026C8DC
		public static GuideFocusNew GetRootAsGuideFocusNew(ByteBuffer _bb, GuideFocusNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060082B3 RID: 33459 RVA: 0x0026E6F9 File Offset: 0x0026C8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060082B4 RID: 33460 RVA: 0x0026E708 File Offset: 0x0026C908
		public GuideFocusNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x060082B5 RID: 33461 RVA: 0x0026E718 File Offset: 0x0026C918
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

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x0026E754 File Offset: 0x0026C954
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

		// Token: 0x060082B7 RID: 33463 RVA: 0x0026E78B File Offset: 0x0026C98B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060082B8 RID: 33464 RVA: 0x0026E79A File Offset: 0x0026C99A
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x060082B9 RID: 33465 RVA: 0x0026E7B4 File Offset: 0x0026C9B4
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

		// Token: 0x060082BA RID: 33466 RVA: 0x0026E7EB File Offset: 0x0026C9EB
		public Span<byte> GetDynamicTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060082BB RID: 33467 RVA: 0x0026E7FA File Offset: 0x0026C9FA
		public byte[] GetDynamicTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x060082BC RID: 33468 RVA: 0x0026E814 File Offset: 0x0026CA14
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

		// Token: 0x060082BD RID: 33469 RVA: 0x0026E84C File Offset: 0x0026CA4C
		public Span<byte> GetPlatformBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x0026E85C File Offset: 0x0026CA5C
		public byte[] GetPlatformArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x0026E874 File Offset: 0x0026CA74
		public string MultiGuideBox(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x060082C0 RID: 33472 RVA: 0x0026E8B0 File Offset: 0x0026CAB0
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

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x060082C1 RID: 33473 RVA: 0x0026E8DC File Offset: 0x0026CADC
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

		// Token: 0x060082C2 RID: 33474 RVA: 0x0026E914 File Offset: 0x0026CB14
		public Span<byte> GetGuideMarkNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060082C3 RID: 33475 RVA: 0x0026E924 File Offset: 0x0026CB24
		public byte[] GetGuideMarkNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x060082C4 RID: 33476 RVA: 0x0026E93C File Offset: 0x0026CB3C
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

		// Token: 0x060082C5 RID: 33477 RVA: 0x0026E974 File Offset: 0x0026CB74
		public Span<byte> GetGuideMarkNameForShowBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x0026E984 File Offset: 0x0026CB84
		public byte[] GetGuideMarkNameForShowArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x060082C7 RID: 33479 RVA: 0x0026E99C File Offset: 0x0026CB9C
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

		// Token: 0x060082C8 RID: 33480 RVA: 0x0026E9D4 File Offset: 0x0026CBD4
		public Span<byte> GetHookNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060082C9 RID: 33481 RVA: 0x0026E9E4 File Offset: 0x0026CBE4
		public byte[] GetHookNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x060082CA RID: 33482 RVA: 0x0026E9FC File Offset: 0x0026CBFC
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

		// Token: 0x060082CB RID: 33483 RVA: 0x0026EA34 File Offset: 0x0026CC34
		public Span<byte> GetHookNameForShowBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x060082CC RID: 33484 RVA: 0x0026EA44 File Offset: 0x0026CC44
		public byte[] GetHookNameForShowArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x060082CD RID: 33485 RVA: 0x0026EA5C File Offset: 0x0026CC5C
		public string ExtraParam(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x060082CE RID: 33486 RVA: 0x0026EA98 File Offset: 0x0026CC98
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

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x060082CF RID: 33487 RVA: 0x0026EAC4 File Offset: 0x0026CCC4
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

		// Token: 0x060082D0 RID: 33488 RVA: 0x0026EAFC File Offset: 0x0026CCFC
		public Span<byte> GetExtraParamDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060082D1 RID: 33489 RVA: 0x0026EB0C File Offset: 0x0026CD0C
		public byte[] GetExtraParamDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x060082D2 RID: 33490 RVA: 0x0026EB24 File Offset: 0x0026CD24
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

		// Token: 0x060082D3 RID: 33491 RVA: 0x0026EB5C File Offset: 0x0026CD5C
		public Span<byte> GetContentDirectionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060082D4 RID: 33492 RVA: 0x0026EB6C File Offset: 0x0026CD6C
		public byte[] GetContentDirectionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x060082D5 RID: 33493 RVA: 0x0026EB84 File Offset: 0x0026CD84
		public bool ShowArrow
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x060082D6 RID: 33494 RVA: 0x0026EBC4 File Offset: 0x0026CDC4
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

		// Token: 0x060082D7 RID: 33495 RVA: 0x0026EBFC File Offset: 0x0026CDFC
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060082D8 RID: 33496 RVA: 0x0026EC0C File Offset: 0x0026CE0C
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x060082D9 RID: 33497 RVA: 0x0026EC24 File Offset: 0x0026CE24
		public string Button(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x060082DA RID: 33498 RVA: 0x0026EC60 File Offset: 0x0026CE60
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

		// Token: 0x060082DB RID: 33499 RVA: 0x0026EC8C File Offset: 0x0026CE8C
		public string InputEnums(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x060082DC RID: 33500 RVA: 0x0026ECC8 File Offset: 0x0026CEC8
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

		// Token: 0x060082DD RID: 33501 RVA: 0x0026ECF4 File Offset: 0x0026CEF4
		public string LimitInputEnums(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x060082DE RID: 33502 RVA: 0x0026ED30 File Offset: 0x0026CF30
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

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x060082DF RID: 33503 RVA: 0x0026ED5C File Offset: 0x0026CF5C
		public bool ShowMouse
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x060082E0 RID: 33504 RVA: 0x0026ED9C File Offset: 0x0026CF9C
		public bool UseMask
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x060082E1 RID: 33505 RVA: 0x0026EDDC File Offset: 0x0026CFDC
		public bool UseClick
		{
			get
			{
				int num = this.__p.__offset(42);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x060082E2 RID: 33506 RVA: 0x0026EE1C File Offset: 0x0026D01C
		public bool ClickAnywhere
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x060082E3 RID: 33507 RVA: 0x0026EE5C File Offset: 0x0026D05C
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

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x060082E4 RID: 33508 RVA: 0x0026EE9C File Offset: 0x0026D09C
		public bool EnableHover
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016CE RID: 5838
		// (get) Token: 0x060082E5 RID: 33509 RVA: 0x0026EEDC File Offset: 0x0026D0DC
		public bool EnableAllToggleState
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x060082E6 RID: 33510 RVA: 0x0026EF1C File Offset: 0x0026D11C
		public bool ExpandClickArea
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x060082E7 RID: 33511 RVA: 0x0026EF5C File Offset: 0x0026D15C
		public bool OnlyFrame
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x060082E8 RID: 33512 RVA: 0x0026EF9C File Offset: 0x0026D19C
		public bool OnlyText
		{
			get
			{
				int num = this.__p.__offset(56);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x060082E9 RID: 33513 RVA: 0x0026EFDC File Offset: 0x0026D1DC
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

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x060082EA RID: 33514 RVA: 0x0026F01C File Offset: 0x0026D21C
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

		// Token: 0x060082EB RID: 33515 RVA: 0x0026F054 File Offset: 0x0026D254
		public Span<byte> GetHeadImgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x0026F064 File Offset: 0x0026D264
		public byte[] GetHeadImgPathArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x060082ED RID: 33517 RVA: 0x0026F07C File Offset: 0x0026D27C
		public float TextOffset(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x060082EE RID: 33518 RVA: 0x0026F0C0 File Offset: 0x0026D2C0
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

		// Token: 0x060082EF RID: 33519 RVA: 0x0026F0EC File Offset: 0x0026D2EC
		public Span<float> GetTextOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(62, 4);
		}

		// Token: 0x060082F0 RID: 33520 RVA: 0x0026F0FC File Offset: 0x0026D2FC
		public float[] GetTextOffsetArray()
		{
			return this.__p.__vector_as_array<float>(62) ?? Array.Empty<float>();
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x060082F1 RID: 33521 RVA: 0x0026F114 File Offset: 0x0026D314
		public bool TextInScreen
		{
			get
			{
				int num = this.__p.__offset(64);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x060082F2 RID: 33522 RVA: 0x0026F154 File Offset: 0x0026D354
		public bool HideWhenOtherPopViewOccur
		{
			get
			{
				int num = this.__p.__offset(66);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x060082F3 RID: 33523 RVA: 0x0026F194 File Offset: 0x0026D394
		public bool CheckShowByIsShowOrShowing
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x0026F1D4 File Offset: 0x0026D3D4
		[NullableContext(1)]
		public string[] Button()
		{
			return this.ButtonIter().ToArray<string>();
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x0026F1E1 File Offset: 0x0026D3E1
		[NullableContext(1)]
		public IEnumerable<string> ButtonIter()
		{
			GuideFocusNew.<ButtonIter>d__105 <ButtonIter>d__ = new GuideFocusNew.<ButtonIter>d__105(-2);
			<ButtonIter>d__.<>3__<>4__this = this;
			return <ButtonIter>d__;
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x0026F1F6 File Offset: 0x0026D3F6
		[NullableContext(1)]
		public string[] ExtraParam()
		{
			return this.ExtraParamIter().ToArray<string>();
		}

		// Token: 0x060082F7 RID: 33527 RVA: 0x0026F203 File Offset: 0x0026D403
		[NullableContext(1)]
		public IEnumerable<string> ExtraParamIter()
		{
			GuideFocusNew.<ExtraParamIter>d__107 <ExtraParamIter>d__ = new GuideFocusNew.<ExtraParamIter>d__107(-2);
			<ExtraParamIter>d__.<>3__<>4__this = this;
			return <ExtraParamIter>d__;
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x0026F218 File Offset: 0x0026D418
		[NullableContext(1)]
		public string[] InputEnums()
		{
			return this.InputEnumsIter().ToArray<string>();
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x0026F225 File Offset: 0x0026D425
		[NullableContext(1)]
		public IEnumerable<string> InputEnumsIter()
		{
			GuideFocusNew.<InputEnumsIter>d__109 <InputEnumsIter>d__ = new GuideFocusNew.<InputEnumsIter>d__109(-2);
			<InputEnumsIter>d__.<>3__<>4__this = this;
			return <InputEnumsIter>d__;
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x0026F23A File Offset: 0x0026D43A
		[NullableContext(1)]
		public string[] LimitInputEnums()
		{
			return this.LimitInputEnumsIter().ToArray<string>();
		}

		// Token: 0x060082FB RID: 33531 RVA: 0x0026F247 File Offset: 0x0026D447
		[NullableContext(1)]
		public IEnumerable<string> LimitInputEnumsIter()
		{
			GuideFocusNew.<LimitInputEnumsIter>d__111 <LimitInputEnumsIter>d__ = new GuideFocusNew.<LimitInputEnumsIter>d__111(-2);
			<LimitInputEnumsIter>d__.<>3__<>4__this = this;
			return <LimitInputEnumsIter>d__;
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x0026F25C File Offset: 0x0026D45C
		[NullableContext(1)]
		public string[] MultiGuideBox()
		{
			return this.MultiGuideBoxIter().ToArray<string>();
		}

		// Token: 0x060082FD RID: 33533 RVA: 0x0026F269 File Offset: 0x0026D469
		[NullableContext(1)]
		public IEnumerable<string> MultiGuideBoxIter()
		{
			GuideFocusNew.<MultiGuideBoxIter>d__113 <MultiGuideBoxIter>d__ = new GuideFocusNew.<MultiGuideBoxIter>d__113(-2);
			<MultiGuideBoxIter>d__.<>3__<>4__this = this;
			return <MultiGuideBoxIter>d__;
		}

		// Token: 0x060082FE RID: 33534 RVA: 0x0026F27E File Offset: 0x0026D47E
		[NullableContext(1)]
		public float[] TextOffset()
		{
			return this.GetTextOffsetArray();
		}

		// Token: 0x060082FF RID: 33535 RVA: 0x0026F286 File Offset: 0x0026D486
		[NullableContext(1)]
		public IEnumerable<float> TextOffsetIter()
		{
			GuideFocusNew.<TextOffsetIter>d__115 <TextOffsetIter>d__ = new GuideFocusNew.<TextOffsetIter>d__115(-2);
			<TextOffsetIter>d__.<>3__<>4__this = this;
			return <TextOffsetIter>d__;
		}

		// Token: 0x04005375 RID: 21365
		private Table __p;
	}
}
