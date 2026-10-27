using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D52 RID: 3410
	public struct HonamiStoryWeapon : IFlatbufferObject
	{
		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x060081A3 RID: 33187 RVA: 0x0025B271 File Offset: 0x00259471
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x0025B27E File Offset: 0x0025947E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x0025B288 File Offset: 0x00259488
		public static HonamiStoryWeapon GetRootAsHonamiStoryWeapon(ByteBuffer _bb)
		{
			return HonamiStoryWeapon.GetRootAsHonamiStoryWeapon(_bb, default(HonamiStoryWeapon));
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x0025B2A4 File Offset: 0x002594A4
		public static HonamiStoryWeapon GetRootAsHonamiStoryWeapon(ByteBuffer _bb, HonamiStoryWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x0025B2C1 File Offset: 0x002594C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x0025B2D0 File Offset: 0x002594D0
		public HonamiStoryWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x060081A9 RID: 33193 RVA: 0x0025B2E0 File Offset: 0x002594E0
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

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x060081AA RID: 33194 RVA: 0x0025B31C File Offset: 0x0025951C
		public int ActivityId
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

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x060081AB RID: 33195 RVA: 0x0025B358 File Offset: 0x00259558
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x060081AC RID: 33196 RVA: 0x0025B394 File Offset: 0x00259594
		public int PropLibraryId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x0025B3D4 File Offset: 0x002595D4
		public int BuffTempId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x060081AE RID: 33198 RVA: 0x0025B414 File Offset: 0x00259614
		public int BuffTempIdLength
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

		// Token: 0x060081AF RID: 33199 RVA: 0x0025B440 File Offset: 0x00259640
		public Span<int> GetBuffTempIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x0025B450 File Offset: 0x00259650
		public int[] GetBuffTempIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x0025B468 File Offset: 0x00259668
		public int SuitId(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x060081B2 RID: 33202 RVA: 0x0025B4A8 File Offset: 0x002596A8
		public int SuitIdLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060081B3 RID: 33203 RVA: 0x0025B4D4 File Offset: 0x002596D4
		public Span<int> GetSuitIdBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x0025B4E4 File Offset: 0x002596E4
		public int[] GetSuitIdArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x060081B5 RID: 33205 RVA: 0x0025B4FC File Offset: 0x002596FC
		public int PhantomItemId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x0025B53C File Offset: 0x0025973C
		public DicIntInt? ExtraSuitAddEnhanceLevel(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x060081B7 RID: 33207 RVA: 0x0025B5A0 File Offset: 0x002597A0
		public int ExtraSuitAddEnhanceLevelLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x0025B5CC File Offset: 0x002597CC
		public int PluginTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x060081B9 RID: 33209 RVA: 0x0025B60C File Offset: 0x0025980C
		public int PluginTagsLength
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

		// Token: 0x060081BA RID: 33210 RVA: 0x0025B638 File Offset: 0x00259838
		public Span<int> GetPluginTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x0025B648 File Offset: 0x00259848
		public int[] GetPluginTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x060081BC RID: 33212 RVA: 0x0025B660 File Offset: 0x00259860
		public string AttributesDescription
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

		// Token: 0x060081BD RID: 33213 RVA: 0x0025B698 File Offset: 0x00259898
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x0025B6A8 File Offset: 0x002598A8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x0025B6C0 File Offset: 0x002598C0
		public string AttributesDescriptionArgs(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x060081C0 RID: 33216 RVA: 0x0025B6FC File Offset: 0x002598FC
		public int AttributesDescriptionArgsLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x060081C1 RID: 33217 RVA: 0x0025B728 File Offset: 0x00259928
		public string AttributesDescriptionSimple
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

		// Token: 0x060081C2 RID: 33218 RVA: 0x0025B760 File Offset: 0x00259960
		public Span<byte> GetAttributesDescriptionSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x0025B770 File Offset: 0x00259970
		public byte[] GetAttributesDescriptionSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x0025B788 File Offset: 0x00259988
		public string AttributesDescriptionSimpleArgs(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x060081C5 RID: 33221 RVA: 0x0025B7C4 File Offset: 0x002599C4
		public int AttributesDescriptionSimpleArgsLength
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

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x060081C6 RID: 33222 RVA: 0x0025B7F0 File Offset: 0x002599F0
		public string Icon
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

		// Token: 0x060081C7 RID: 33223 RVA: 0x0025B828 File Offset: 0x00259A28
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x0025B838 File Offset: 0x00259A38
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x060081C9 RID: 33225 RVA: 0x0025B850 File Offset: 0x00259A50
		public string IconToggle
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

		// Token: 0x060081CA RID: 33226 RVA: 0x0025B888 File Offset: 0x00259A88
		public Span<byte> GetIconToggleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x0025B898 File Offset: 0x00259A98
		public byte[] GetIconToggleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x060081CC RID: 33228 RVA: 0x0025B8B0 File Offset: 0x00259AB0
		public int Type
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x060081CD RID: 33229 RVA: 0x0025B8F0 File Offset: 0x00259AF0
		public string Name
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

		// Token: 0x060081CE RID: 33230 RVA: 0x0025B928 File Offset: 0x00259B28
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x0025B938 File Offset: 0x00259B38
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x060081D0 RID: 33232 RVA: 0x0025B950 File Offset: 0x00259B50
		public string GetWayDes
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

		// Token: 0x060081D1 RID: 33233 RVA: 0x0025B988 File Offset: 0x00259B88
		public Span<byte> GetGetWayDesBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x0025B998 File Offset: 0x00259B98
		public byte[] GetGetWayDesArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x060081D3 RID: 33235 RVA: 0x0025B9B0 File Offset: 0x00259BB0
		public string LockDescription
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

		// Token: 0x060081D4 RID: 33236 RVA: 0x0025B9E8 File Offset: 0x00259BE8
		public Span<byte> GetLockDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x0025B9F8 File Offset: 0x00259BF8
		public byte[] GetLockDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x060081D6 RID: 33238 RVA: 0x0025BA10 File Offset: 0x00259C10
		public bool IsShowReward
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x060081D7 RID: 33239 RVA: 0x0025BA50 File Offset: 0x00259C50
		public string TypeDescription
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

		// Token: 0x060081D8 RID: 33240 RVA: 0x0025BA88 File Offset: 0x00259C88
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x0025BA98 File Offset: 0x00259C98
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x060081DA RID: 33242 RVA: 0x0025BAB0 File Offset: 0x00259CB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributesDescriptionArgsIter()或GetAttributesDescriptionArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AttributesDescriptionArgs()
		{
			return this.AttributesDescriptionArgsIter().ToArray<string>();
		}

		// Token: 0x060081DB RID: 33243 RVA: 0x0025BABD File Offset: 0x00259CBD
		[NullableContext(1)]
		public readonly IEnumerable<string> AttributesDescriptionArgsIter()
		{
			HonamiStoryWeapon.<AttributesDescriptionArgsIter>d__79 <AttributesDescriptionArgsIter>d__ = new HonamiStoryWeapon.<AttributesDescriptionArgsIter>d__79(-2);
			<AttributesDescriptionArgsIter>d__.<>3__<>4__this = this;
			return <AttributesDescriptionArgsIter>d__;
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x0025BAD2 File Offset: 0x00259CD2
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributesDescriptionSimpleArgsIter()或GetAttributesDescriptionSimpleArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AttributesDescriptionSimpleArgs()
		{
			return this.AttributesDescriptionSimpleArgsIter().ToArray<string>();
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x0025BADF File Offset: 0x00259CDF
		[NullableContext(1)]
		public readonly IEnumerable<string> AttributesDescriptionSimpleArgsIter()
		{
			HonamiStoryWeapon.<AttributesDescriptionSimpleArgsIter>d__81 <AttributesDescriptionSimpleArgsIter>d__ = new HonamiStoryWeapon.<AttributesDescriptionSimpleArgsIter>d__81(-2);
			<AttributesDescriptionSimpleArgsIter>d__.<>3__<>4__this = this;
			return <AttributesDescriptionSimpleArgsIter>d__;
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x0025BAF4 File Offset: 0x00259CF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffTempIdIter()或GetBuffTempIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BuffTempId()
		{
			HonamiStoryWeapon honamiStoryWeapon = this;
			return honamiStoryWeapon.GetBuffTempIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x0025BB18 File Offset: 0x00259D18
		[NullableContext(1)]
		public readonly IEnumerable<int> BuffTempIdIter()
		{
			HonamiStoryWeapon.<BuffTempIdIter>d__83 <BuffTempIdIter>d__ = new HonamiStoryWeapon.<BuffTempIdIter>d__83(-2);
			<BuffTempIdIter>d__.<>3__<>4__this = this;
			return <BuffTempIdIter>d__;
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x0025BB30 File Offset: 0x00259D30
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ExtraSuitAddEnhanceLevelFrozenDict()缓存字典，遍历请使用ExtraSuitAddEnhanceLevelIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ExtraSuitAddEnhanceLevel()
		{
			return this.ExtraSuitAddEnhanceLevelIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x0025BB86 File Offset: 0x00259D86
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ExtraSuitAddEnhanceLevelIter()
		{
			HonamiStoryWeapon.<ExtraSuitAddEnhanceLevelIter>d__85 <ExtraSuitAddEnhanceLevelIter>d__ = new HonamiStoryWeapon.<ExtraSuitAddEnhanceLevelIter>d__85(-2);
			<ExtraSuitAddEnhanceLevelIter>d__.<>3__<>4__this = this;
			return <ExtraSuitAddEnhanceLevelIter>d__;
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x0025BB9C File Offset: 0x00259D9C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PluginTagsIter()或GetPluginTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PluginTags()
		{
			HonamiStoryWeapon honamiStoryWeapon = this;
			return honamiStoryWeapon.GetPluginTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x0025BBC0 File Offset: 0x00259DC0
		[NullableContext(1)]
		public readonly IEnumerable<int> PluginTagsIter()
		{
			HonamiStoryWeapon.<PluginTagsIter>d__87 <PluginTagsIter>d__ = new HonamiStoryWeapon.<PluginTagsIter>d__87(-2);
			<PluginTagsIter>d__.<>3__<>4__this = this;
			return <PluginTagsIter>d__;
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x0025BBD8 File Offset: 0x00259DD8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SuitIdIter()或GetSuitIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SuitId()
		{
			HonamiStoryWeapon honamiStoryWeapon = this;
			return honamiStoryWeapon.GetSuitIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x0025BBFC File Offset: 0x00259DFC
		[NullableContext(1)]
		public readonly IEnumerable<int> SuitIdIter()
		{
			HonamiStoryWeapon.<SuitIdIter>d__89 <SuitIdIter>d__ = new HonamiStoryWeapon.<SuitIdIter>d__89(-2);
			<SuitIdIter>d__.<>3__<>4__this = this;
			return <SuitIdIter>d__;
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x0025BC14 File Offset: 0x00259E14
		public int? GetExtraSuitAddEnhanceLevel(int key)
		{
			this.EnsureExtraSuitAddEnhanceLevelCacheIfNeeded();
			int value;
			if (!this.ExtraSuitAddEnhanceLevelCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060081E7 RID: 33255 RVA: 0x0025BC48 File Offset: 0x00259E48
		private void EnsureExtraSuitAddEnhanceLevelCacheIfNeeded()
		{
			if (this.ExtraSuitAddEnhanceLevelCache != null)
			{
				return;
			}
			this.ExtraSuitAddEnhanceLevelCache = this.ExtraSuitAddEnhanceLevelIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x0025BCAE File Offset: 0x00259EAE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetExtraSuitAddEnhanceLevelFrozenDict(int key)
		{
			this.EnsureExtraSuitAddEnhanceLevelCacheIfNeeded();
			return this.ExtraSuitAddEnhanceLevelCache;
		}

		// Token: 0x04004DD0 RID: 19920
		private Table __p;

		// Token: 0x04004DD1 RID: 19921
		[Nullable(2)]
		private FrozenDictionary<int, int> ExtraSuitAddEnhanceLevelCache;
	}
}
