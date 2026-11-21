using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAA RID: 3498
	public struct FlySkinConfig : IFlatbufferObject
	{
		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06007BAB RID: 31659 RVA: 0x0025F250 File Offset: 0x0025D450
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x0025F25D File Offset: 0x0025D45D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x0025F264 File Offset: 0x0025D464
		public static FlySkinConfig GetRootAsFlySkinConfig(ByteBuffer _bb)
		{
			return FlySkinConfig.GetRootAsFlySkinConfig(_bb, default(FlySkinConfig));
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x0025F280 File Offset: 0x0025D480
		public static FlySkinConfig GetRootAsFlySkinConfig(ByteBuffer _bb, FlySkinConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x0025F29D File Offset: 0x0025D49D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x0025F2AC File Offset: 0x0025D4AC
		public FlySkinConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06007BB1 RID: 31665 RVA: 0x0025F2BC File Offset: 0x0025D4BC
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

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06007BB2 RID: 31666 RVA: 0x0025F2F8 File Offset: 0x0025D4F8
		public int SkinType
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

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06007BB3 RID: 31667 RVA: 0x0025F334 File Offset: 0x0025D534
		public int ModelId
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

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06007BB4 RID: 31668 RVA: 0x0025F370 File Offset: 0x0025D570
		public string StandAnim
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

		// Token: 0x06007BB5 RID: 31669 RVA: 0x0025F3A8 File Offset: 0x0025D5A8
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x0025F3B8 File Offset: 0x0025D5B8
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06007BB7 RID: 31671 RVA: 0x0025F3D0 File Offset: 0x0025D5D0
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x0025F410 File Offset: 0x0025D610
		public int SkinGrade
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06007BB9 RID: 31673 RVA: 0x0025F450 File Offset: 0x0025D650
		public string Name
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

		// Token: 0x06007BBA RID: 31674 RVA: 0x0025F488 File Offset: 0x0025D688
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x0025F498 File Offset: 0x0025D698
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06007BBC RID: 31676 RVA: 0x0025F4B0 File Offset: 0x0025D6B0
		public string TypeDescription
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

		// Token: 0x06007BBD RID: 31677 RVA: 0x0025F4E8 File Offset: 0x0025D6E8
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x0025F4F8 File Offset: 0x0025D6F8
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06007BBF RID: 31679 RVA: 0x0025F510 File Offset: 0x0025D710
		public string AttributesDescription
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

		// Token: 0x06007BC0 RID: 31680 RVA: 0x0025F548 File Offset: 0x0025D748
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x0025F558 File Offset: 0x0025D758
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x0025F570 File Offset: 0x0025D770
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x0025F5A8 File Offset: 0x0025D7A8
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x0025F5B8 File Offset: 0x0025D7B8
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06007BC5 RID: 31685 RVA: 0x0025F5D0 File Offset: 0x0025D7D0
		public string Icon
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

		// Token: 0x06007BC6 RID: 31686 RVA: 0x0025F608 File Offset: 0x0025D808
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x0025F618 File Offset: 0x0025D818
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06007BC8 RID: 31688 RVA: 0x0025F630 File Offset: 0x0025D830
		public string IconMiddle
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

		// Token: 0x06007BC9 RID: 31689 RVA: 0x0025F668 File Offset: 0x0025D868
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x0025F678 File Offset: 0x0025D878
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06007BCB RID: 31691 RVA: 0x0025F690 File Offset: 0x0025D890
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x0025F6C8 File Offset: 0x0025D8C8
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x0025F6D8 File Offset: 0x0025D8D8
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06007BCE RID: 31694 RVA: 0x0025F6F0 File Offset: 0x0025D8F0
		public string Mesh
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

		// Token: 0x06007BCF RID: 31695 RVA: 0x0025F728 File Offset: 0x0025D928
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x0025F738 File Offset: 0x0025D938
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06007BD1 RID: 31697 RVA: 0x0025F750 File Offset: 0x0025D950
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x0025F788 File Offset: 0x0025D988
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x0025F798 File Offset: 0x0025D998
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06007BD4 RID: 31700 RVA: 0x0025F7B0 File Offset: 0x0025D9B0
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x0025F7F0 File Offset: 0x0025D9F0
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06007BD6 RID: 31702 RVA: 0x0025F830 File Offset: 0x0025DA30
		public int ItemAccessLength
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

		// Token: 0x06007BD7 RID: 31703 RVA: 0x0025F85C File Offset: 0x0025DA5C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x0025F86C File Offset: 0x0025DA6C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06007BD9 RID: 31705 RVA: 0x0025F884 File Offset: 0x0025DA84
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06007BDA RID: 31706 RVA: 0x0025F8C4 File Offset: 0x0025DAC4
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06007BDB RID: 31707 RVA: 0x0025F904 File Offset: 0x0025DB04
		public string PreviewTextureInBuyView
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x0025F93C File Offset: 0x0025DB3C
		public Span<byte> GetPreviewTextureInBuyViewBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x0025F94C File Offset: 0x0025DB4C
		public byte[] GetPreviewTextureInBuyViewArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06007BDE RID: 31710 RVA: 0x0025F964 File Offset: 0x0025DB64
		public string PreviewTextureInPayShop
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x0025F99C File Offset: 0x0025DB9C
		public Span<byte> GetPreviewTextureInPayShopBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06007BE0 RID: 31712 RVA: 0x0025F9AC File Offset: 0x0025DBAC
		public byte[] GetPreviewTextureInPayShopArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x0025F9C4 File Offset: 0x0025DBC4
		public string PreviewTextureInPop
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x0025F9FC File Offset: 0x0025DBFC
		public Span<byte> GetPreviewTextureInPopBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x0025FA0C File Offset: 0x0025DC0C
		public byte[] GetPreviewTextureInPopArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06007BE4 RID: 31716 RVA: 0x0025FA24 File Offset: 0x0025DC24
		public string SkinObtainColor1
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x0025FA5C File Offset: 0x0025DC5C
		public Span<byte> GetSkinObtainColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x0025FA6C File Offset: 0x0025DC6C
		public byte[] GetSkinObtainColor1Array()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06007BE7 RID: 31719 RVA: 0x0025FA84 File Offset: 0x0025DC84
		public string SkinObtainColor2
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x0025FABC File Offset: 0x0025DCBC
		public Span<byte> GetSkinObtainColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x0025FACC File Offset: 0x0025DCCC
		public byte[] GetSkinObtainColor2Array()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06007BEA RID: 31722 RVA: 0x0025FAE4 File Offset: 0x0025DCE4
		public string SkinObtainImage
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x0025FB1C File Offset: 0x0025DD1C
		public Span<byte> GetSkinObtainImageBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x0025FB2C File Offset: 0x0025DD2C
		public byte[] GetSkinObtainImageArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06007BED RID: 31725 RVA: 0x0025FB44 File Offset: 0x0025DD44
		public bool IsSpecialViewAfterObtain
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x0025FB84 File Offset: 0x0025DD84
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x06007BEF RID: 31727 RVA: 0x0025FB8C File Offset: 0x0025DD8C
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			FlySkinConfig.<ItemAccessIter>d__96 <ItemAccessIter>d__ = new FlySkinConfig.<ItemAccessIter>d__96(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0400531A RID: 21274
		private Table __p;
	}
}
