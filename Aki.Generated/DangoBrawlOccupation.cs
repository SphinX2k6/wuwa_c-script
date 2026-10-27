using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC8 RID: 3016
	public struct DangoBrawlOccupation : IFlatbufferObject
	{
		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06005E47 RID: 24135 RVA: 0x0020ADF0 File Offset: 0x00208FF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x0020ADFD File Offset: 0x00208FFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x0020AE04 File Offset: 0x00209004
		public static DangoBrawlOccupation GetRootAsDangoBrawlOccupation(ByteBuffer _bb)
		{
			return DangoBrawlOccupation.GetRootAsDangoBrawlOccupation(_bb, default(DangoBrawlOccupation));
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x0020AE20 File Offset: 0x00209020
		public static DangoBrawlOccupation GetRootAsDangoBrawlOccupation(ByteBuffer _bb, DangoBrawlOccupation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x0020AE3D File Offset: 0x0020903D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x0020AE4C File Offset: 0x0020904C
		public DangoBrawlOccupation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06005E4D RID: 24141 RVA: 0x0020AE5C File Offset: 0x0020905C
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

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06005E4E RID: 24142 RVA: 0x0020AE98 File Offset: 0x00209098
		public int WobblePlateId
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

		// Token: 0x06005E4F RID: 24143 RVA: 0x0020AED4 File Offset: 0x002090D4
		public DicIntInt? AccumulatePro(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06005E50 RID: 24144 RVA: 0x0020AF34 File Offset: 0x00209134
		public int AccumulateProLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x0020AF60 File Offset: 0x00209160
		public int CoreItemAttr(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06005E52 RID: 24146 RVA: 0x0020AFA0 File Offset: 0x002091A0
		public int CoreItemAttrLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x0020AFCC File Offset: 0x002091CC
		public Span<int> GetCoreItemAttrBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x0020AFDC File Offset: 0x002091DC
		public int[] GetCoreItemAttrArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06005E55 RID: 24149 RVA: 0x0020AFF4 File Offset: 0x002091F4
		public string Name
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

		// Token: 0x06005E56 RID: 24150 RVA: 0x0020B02C File Offset: 0x0020922C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x0020B03C File Offset: 0x0020923C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06005E58 RID: 24152 RVA: 0x0020B054 File Offset: 0x00209254
		public string RoleName
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

		// Token: 0x06005E59 RID: 24153 RVA: 0x0020B08C File Offset: 0x0020928C
		public Span<byte> GetRoleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x0020B09C File Offset: 0x0020929C
		public byte[] GetRoleNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06005E5B RID: 24155 RVA: 0x0020B0B4 File Offset: 0x002092B4
		public string Color
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

		// Token: 0x06005E5C RID: 24156 RVA: 0x0020B0EC File Offset: 0x002092EC
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x0020B0FC File Offset: 0x002092FC
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06005E5E RID: 24158 RVA: 0x0020B114 File Offset: 0x00209314
		public string ColorBackpack
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

		// Token: 0x06005E5F RID: 24159 RVA: 0x0020B14C File Offset: 0x0020934C
		public Span<byte> GetColorBackpackBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x0020B15C File Offset: 0x0020935C
		public byte[] GetColorBackpackArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x0020B174 File Offset: 0x00209374
		public string SpineAtlasPaths(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06005E62 RID: 24162 RVA: 0x0020B1B0 File Offset: 0x002093B0
		public int SpineAtlasPathsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x0020B1DC File Offset: 0x002093DC
		public string SpineSkeletonDataPaths(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06005E64 RID: 24164 RVA: 0x0020B218 File Offset: 0x00209418
		public int SpineSkeletonDataPathsLength
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

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06005E65 RID: 24165 RVA: 0x0020B244 File Offset: 0x00209444
		public string SpineAnim
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

		// Token: 0x06005E66 RID: 24166 RVA: 0x0020B27C File Offset: 0x0020947C
		public Span<byte> GetSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x0020B28C File Offset: 0x0020948C
		public byte[] GetSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06005E68 RID: 24168 RVA: 0x0020B2A4 File Offset: 0x002094A4
		public string Icon
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

		// Token: 0x06005E69 RID: 24169 RVA: 0x0020B2DC File Offset: 0x002094DC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x0020B2EC File Offset: 0x002094EC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x0020B304 File Offset: 0x00209504
		public string IconTitle(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06005E6C RID: 24172 RVA: 0x0020B340 File Offset: 0x00209540
		public int IconTitleLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06005E6D RID: 24173 RVA: 0x0020B36C File Offset: 0x0020956C
		public string IconSmall
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

		// Token: 0x06005E6E RID: 24174 RVA: 0x0020B3A4 File Offset: 0x002095A4
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x0020B3B4 File Offset: 0x002095B4
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06005E70 RID: 24176 RVA: 0x0020B3CC File Offset: 0x002095CC
		public string IconTransparent
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

		// Token: 0x06005E71 RID: 24177 RVA: 0x0020B404 File Offset: 0x00209604
		public Span<byte> GetIconTransparentBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x0020B414 File Offset: 0x00209614
		public byte[] GetIconTransparentArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x0020B42C File Offset: 0x0020962C
		public string IconRound
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

		// Token: 0x06005E74 RID: 24180 RVA: 0x0020B464 File Offset: 0x00209664
		public Span<byte> GetIconRoundBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x0020B474 File Offset: 0x00209674
		public byte[] GetIconRoundArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06005E76 RID: 24182 RVA: 0x0020B48C File Offset: 0x0020968C
		public string Desc
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

		// Token: 0x06005E77 RID: 24183 RVA: 0x0020B4C4 File Offset: 0x002096C4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x0020B4D4 File Offset: 0x002096D4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x0020B4EC File Offset: 0x002096EC
		public string RoleDesc
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

		// Token: 0x06005E7A RID: 24186 RVA: 0x0020B524 File Offset: 0x00209724
		public Span<byte> GetRoleDescBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x0020B534 File Offset: 0x00209734
		public byte[] GetRoleDescArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x0020B54C File Offset: 0x0020974C
		public int TagIdList(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x0020B58C File Offset: 0x0020978C
		public int TagIdListLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x0020B5B8 File Offset: 0x002097B8
		public Span<int> GetTagIdListBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06005E7F RID: 24191 RVA: 0x0020B5C8 File Offset: 0x002097C8
		public int[] GetTagIdListArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x0020B5E0 File Offset: 0x002097E0
		public string IconSubTitle(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x0020B61C File Offset: 0x0020981C
		public int IconSubTitleLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06005E82 RID: 24194 RVA: 0x0020B648 File Offset: 0x00209848
		public string SpeIcon
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

		// Token: 0x06005E83 RID: 24195 RVA: 0x0020B680 File Offset: 0x00209880
		public Span<byte> GetSpeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x0020B690 File Offset: 0x00209890
		public byte[] GetSpeIconArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x0020B6A8 File Offset: 0x002098A8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AccumulateProFrozenDict()缓存字典，遍历请使用AccumulateProIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> AccumulatePro()
		{
			return this.AccumulateProIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x0020B6FE File Offset: 0x002098FE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> AccumulateProIter()
		{
			DangoBrawlOccupation.<AccumulateProIter>d__86 <AccumulateProIter>d__ = new DangoBrawlOccupation.<AccumulateProIter>d__86(-2);
			<AccumulateProIter>d__.<>3__<>4__this = this;
			return <AccumulateProIter>d__;
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x0020B714 File Offset: 0x00209914
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CoreItemAttrIter()或GetCoreItemAttrBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CoreItemAttr()
		{
			DangoBrawlOccupation dangoBrawlOccupation = this;
			return dangoBrawlOccupation.GetCoreItemAttrArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x0020B738 File Offset: 0x00209938
		[NullableContext(1)]
		public readonly IEnumerable<int> CoreItemAttrIter()
		{
			DangoBrawlOccupation.<CoreItemAttrIter>d__88 <CoreItemAttrIter>d__ = new DangoBrawlOccupation.<CoreItemAttrIter>d__88(-2);
			<CoreItemAttrIter>d__.<>3__<>4__this = this;
			return <CoreItemAttrIter>d__;
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x0020B74D File Offset: 0x0020994D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IconSubTitleIter()或GetIconSubTitleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IconSubTitle()
		{
			return this.IconSubTitleIter().ToArray<string>();
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x0020B75A File Offset: 0x0020995A
		[NullableContext(1)]
		public readonly IEnumerable<string> IconSubTitleIter()
		{
			DangoBrawlOccupation.<IconSubTitleIter>d__90 <IconSubTitleIter>d__ = new DangoBrawlOccupation.<IconSubTitleIter>d__90(-2);
			<IconSubTitleIter>d__.<>3__<>4__this = this;
			return <IconSubTitleIter>d__;
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x0020B76F File Offset: 0x0020996F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IconTitleIter()或GetIconTitleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IconTitle()
		{
			return this.IconTitleIter().ToArray<string>();
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x0020B77C File Offset: 0x0020997C
		[NullableContext(1)]
		public readonly IEnumerable<string> IconTitleIter()
		{
			DangoBrawlOccupation.<IconTitleIter>d__92 <IconTitleIter>d__ = new DangoBrawlOccupation.<IconTitleIter>d__92(-2);
			<IconTitleIter>d__.<>3__<>4__this = this;
			return <IconTitleIter>d__;
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x0020B791 File Offset: 0x00209991
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineAtlasPathsIter()或GetSpineAtlasPathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineAtlasPaths()
		{
			return this.SpineAtlasPathsIter().ToArray<string>();
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x0020B79E File Offset: 0x0020999E
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineAtlasPathsIter()
		{
			DangoBrawlOccupation.<SpineAtlasPathsIter>d__94 <SpineAtlasPathsIter>d__ = new DangoBrawlOccupation.<SpineAtlasPathsIter>d__94(-2);
			<SpineAtlasPathsIter>d__.<>3__<>4__this = this;
			return <SpineAtlasPathsIter>d__;
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x0020B7B3 File Offset: 0x002099B3
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineSkeletonDataPathsIter()或GetSpineSkeletonDataPathsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SpineSkeletonDataPaths()
		{
			return this.SpineSkeletonDataPathsIter().ToArray<string>();
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x0020B7C0 File Offset: 0x002099C0
		[NullableContext(1)]
		public readonly IEnumerable<string> SpineSkeletonDataPathsIter()
		{
			DangoBrawlOccupation.<SpineSkeletonDataPathsIter>d__96 <SpineSkeletonDataPathsIter>d__ = new DangoBrawlOccupation.<SpineSkeletonDataPathsIter>d__96(-2);
			<SpineSkeletonDataPathsIter>d__.<>3__<>4__this = this;
			return <SpineSkeletonDataPathsIter>d__;
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x0020B7D8 File Offset: 0x002099D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIdListIter()或GetTagIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TagIdList()
		{
			DangoBrawlOccupation dangoBrawlOccupation = this;
			return dangoBrawlOccupation.GetTagIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x0020B7FC File Offset: 0x002099FC
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIdListIter()
		{
			DangoBrawlOccupation.<TagIdListIter>d__98 <TagIdListIter>d__ = new DangoBrawlOccupation.<TagIdListIter>d__98(-2);
			<TagIdListIter>d__.<>3__<>4__this = this;
			return <TagIdListIter>d__;
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x0020B814 File Offset: 0x00209A14
		public int? GetAccumulatePro(int key)
		{
			this.EnsureAccumulateProCacheIfNeeded();
			int value;
			if (!this.AccumulateProCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x0020B848 File Offset: 0x00209A48
		private void EnsureAccumulateProCacheIfNeeded()
		{
			if (this.AccumulateProCache != null)
			{
				return;
			}
			this.AccumulateProCache = this.AccumulateProIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x0020B8AE File Offset: 0x00209AAE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetAccumulateProFrozenDict(int key)
		{
			this.EnsureAccumulateProCacheIfNeeded();
			return this.AccumulateProCache;
		}

		// Token: 0x04004BF1 RID: 19441
		private Table __p;

		// Token: 0x04004BF2 RID: 19442
		[Nullable(2)]
		private FrozenDictionary<int, int> AccumulateProCache;
	}
}
