using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E68 RID: 3688
	public struct MotorSkin : IFlatbufferObject
	{
		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x06009BB7 RID: 39863 RVA: 0x002965D4 File Offset: 0x002947D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009BB8 RID: 39864 RVA: 0x002965E1 File Offset: 0x002947E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009BB9 RID: 39865 RVA: 0x002965E8 File Offset: 0x002947E8
		public static MotorSkin GetRootAsMotorSkin(ByteBuffer _bb)
		{
			return MotorSkin.GetRootAsMotorSkin(_bb, default(MotorSkin));
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x00296604 File Offset: 0x00294804
		public static MotorSkin GetRootAsMotorSkin(ByteBuffer _bb, MotorSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009BBB RID: 39867 RVA: 0x00296621 File Offset: 0x00294821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009BBC RID: 39868 RVA: 0x00296630 File Offset: 0x00294830
		public MotorSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x06009BBD RID: 39869 RVA: 0x00296640 File Offset: 0x00294840
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

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x06009BBE RID: 39870 RVA: 0x0029667C File Offset: 0x0029487C
		public bool DefaultFlag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06009BBF RID: 39871 RVA: 0x002966BC File Offset: 0x002948BC
		public int SortIndex
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

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06009BC0 RID: 39872 RVA: 0x002966F8 File Offset: 0x002948F8
		public bool Editable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009BC1 RID: 39873 RVA: 0x00296738 File Offset: 0x00294938
		public int BindSticker(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x06009BC2 RID: 39874 RVA: 0x00296778 File Offset: 0x00294978
		public int BindStickerLength
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

		// Token: 0x06009BC3 RID: 39875 RVA: 0x002967A4 File Offset: 0x002949A4
		public Span<int> GetBindStickerBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06009BC4 RID: 39876 RVA: 0x002967B4 File Offset: 0x002949B4
		public int[] GetBindStickerArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x06009BC5 RID: 39877 RVA: 0x002967CC File Offset: 0x002949CC
		public int BindFrame
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

		// Token: 0x06009BC6 RID: 39878 RVA: 0x0029680C File Offset: 0x00294A0C
		public int BindDecorations(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x06009BC7 RID: 39879 RVA: 0x0029684C File Offset: 0x00294A4C
		public int BindDecorationsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009BC8 RID: 39880 RVA: 0x00296878 File Offset: 0x00294A78
		public Span<int> GetBindDecorationsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009BC9 RID: 39881 RVA: 0x00296888 File Offset: 0x00294A88
		public int[] GetBindDecorationsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06009BCA RID: 39882 RVA: 0x002968A0 File Offset: 0x00294AA0
		public int ModelId
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

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x06009BCB RID: 39883 RVA: 0x002968E0 File Offset: 0x00294AE0
		public string StandAnim
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

		// Token: 0x06009BCC RID: 39884 RVA: 0x00296918 File Offset: 0x00294B18
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x00296928 File Offset: 0x00294B28
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x06009BCE RID: 39886 RVA: 0x00296940 File Offset: 0x00294B40
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002215 RID: 8725
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x00296980 File Offset: 0x00294B80
		public string Name
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

		// Token: 0x06009BD0 RID: 39888 RVA: 0x002969B8 File Offset: 0x00294BB8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009BD1 RID: 39889 RVA: 0x002969C8 File Offset: 0x00294BC8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x06009BD2 RID: 39890 RVA: 0x002969E0 File Offset: 0x00294BE0
		public string TypeDescription
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

		// Token: 0x06009BD3 RID: 39891 RVA: 0x00296A18 File Offset: 0x00294C18
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x00296A28 File Offset: 0x00294C28
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002217 RID: 8727
		// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x00296A40 File Offset: 0x00294C40
		public string AttributesDescription
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

		// Token: 0x06009BD6 RID: 39894 RVA: 0x00296A78 File Offset: 0x00294C78
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x00296A88 File Offset: 0x00294C88
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002218 RID: 8728
		// (get) Token: 0x06009BD8 RID: 39896 RVA: 0x00296AA0 File Offset: 0x00294CA0
		public string BgDescription
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

		// Token: 0x06009BD9 RID: 39897 RVA: 0x00296AD8 File Offset: 0x00294CD8
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x00296AE8 File Offset: 0x00294CE8
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x06009BDB RID: 39899 RVA: 0x00296B00 File Offset: 0x00294D00
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x06009BDC RID: 39900 RVA: 0x00296B40 File Offset: 0x00294D40
		public int ItemAccessLength
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

		// Token: 0x06009BDD RID: 39901 RVA: 0x00296B6C File Offset: 0x00294D6C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x06009BDE RID: 39902 RVA: 0x00296B7C File Offset: 0x00294D7C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x06009BDF RID: 39903 RVA: 0x00296B94 File Offset: 0x00294D94
		public string SkinIcon
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x00296BCC File Offset: 0x00294DCC
		public Span<byte> GetSkinIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x00296BDC File Offset: 0x00294DDC
		public byte[] GetSkinIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x06009BE2 RID: 39906 RVA: 0x00296BF4 File Offset: 0x00294DF4
		public string MainIcon
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x00296C2C File Offset: 0x00294E2C
		public Span<byte> GetMainIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x00296C3C File Offset: 0x00294E3C
		public byte[] GetMainIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x06009BE5 RID: 39909 RVA: 0x00296C54 File Offset: 0x00294E54
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x00296C8C File Offset: 0x00294E8C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x00296C9C File Offset: 0x00294E9C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06009BE8 RID: 39912 RVA: 0x00296CB4 File Offset: 0x00294EB4
		public string IconBig
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009BE9 RID: 39913 RVA: 0x00296CEC File Offset: 0x00294EEC
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06009BEA RID: 39914 RVA: 0x00296CFC File Offset: 0x00294EFC
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06009BEB RID: 39915 RVA: 0x00296D14 File Offset: 0x00294F14
		public string IconMiddle
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

		// Token: 0x06009BEC RID: 39916 RVA: 0x00296D4C File Offset: 0x00294F4C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06009BED RID: 39917 RVA: 0x00296D5C File Offset: 0x00294F5C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x06009BEE RID: 39918 RVA: 0x00296D74 File Offset: 0x00294F74
		public string IconSmall
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

		// Token: 0x06009BEF RID: 39919 RVA: 0x00296DAC File Offset: 0x00294FAC
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06009BF0 RID: 39920 RVA: 0x00296DBC File Offset: 0x00294FBC
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x06009BF1 RID: 39921 RVA: 0x00296DD4 File Offset: 0x00294FD4
		public string Mesh
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

		// Token: 0x06009BF2 RID: 39922 RVA: 0x00296E0C File Offset: 0x0029500C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06009BF3 RID: 39923 RVA: 0x00296E1C File Offset: 0x0029501C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x06009BF4 RID: 39924 RVA: 0x00296E34 File Offset: 0x00295034
		public string ObtainedShowDescription
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

		// Token: 0x06009BF5 RID: 39925 RVA: 0x00296E6C File Offset: 0x0029506C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06009BF6 RID: 39926 RVA: 0x00296E7C File Offset: 0x0029507C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x06009BF7 RID: 39927 RVA: 0x00296E94 File Offset: 0x00295094
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(50);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009BF8 RID: 39928 RVA: 0x00296ED4 File Offset: 0x002950D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BindDecorationsIter()或GetBindDecorationsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BindDecorations()
		{
			MotorSkin motorSkin = this;
			return motorSkin.GetBindDecorationsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009BF9 RID: 39929 RVA: 0x00296EF8 File Offset: 0x002950F8
		[NullableContext(1)]
		public readonly IEnumerable<int> BindDecorationsIter()
		{
			MotorSkin.<BindDecorationsIter>d__92 <BindDecorationsIter>d__ = new MotorSkin.<BindDecorationsIter>d__92(-2);
			<BindDecorationsIter>d__.<>3__<>4__this = this;
			return <BindDecorationsIter>d__;
		}

		// Token: 0x06009BFA RID: 39930 RVA: 0x00296F10 File Offset: 0x00295110
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BindStickerIter()或GetBindStickerBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BindSticker()
		{
			MotorSkin motorSkin = this;
			return motorSkin.GetBindStickerArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009BFB RID: 39931 RVA: 0x00296F34 File Offset: 0x00295134
		[NullableContext(1)]
		public readonly IEnumerable<int> BindStickerIter()
		{
			MotorSkin.<BindStickerIter>d__94 <BindStickerIter>d__ = new MotorSkin.<BindStickerIter>d__94(-2);
			<BindStickerIter>d__.<>3__<>4__this = this;
			return <BindStickerIter>d__;
		}

		// Token: 0x06009BFC RID: 39932 RVA: 0x00296F4C File Offset: 0x0029514C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			MotorSkin motorSkin = this;
			return motorSkin.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009BFD RID: 39933 RVA: 0x00296F70 File Offset: 0x00295170
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			MotorSkin.<ItemAccessIter>d__96 <ItemAccessIter>d__ = new MotorSkin.<ItemAccessIter>d__96(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04004F14 RID: 20244
		private Table __p;
	}
}
