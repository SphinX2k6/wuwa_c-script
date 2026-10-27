using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE5 RID: 3301
	public struct GachaViewInfo : IFlatbufferObject
	{
		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06007869 RID: 30825 RVA: 0x002467DD File Offset: 0x002449DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x002467EA File Offset: 0x002449EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x002467F4 File Offset: 0x002449F4
		public static GachaViewInfo GetRootAsGachaViewInfo(ByteBuffer _bb)
		{
			return GachaViewInfo.GetRootAsGachaViewInfo(_bb, default(GachaViewInfo));
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x00246810 File Offset: 0x00244A10
		public static GachaViewInfo GetRootAsGachaViewInfo(ByteBuffer _bb, GachaViewInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x0024682D File Offset: 0x00244A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x0024683C File Offset: 0x00244A3C
		public GachaViewInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x0600786F RID: 30831 RVA: 0x0024684C File Offset: 0x00244A4C
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

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06007870 RID: 30832 RVA: 0x00246888 File Offset: 0x00244A88
		public int Type
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

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06007871 RID: 30833 RVA: 0x002468C4 File Offset: 0x00244AC4
		public string SummaryTitle
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

		// Token: 0x06007872 RID: 30834 RVA: 0x002468FB File Offset: 0x00244AFB
		public Span<byte> GetSummaryTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x0024690A File Offset: 0x00244B0A
		public byte[] GetSummaryTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06007874 RID: 30836 RVA: 0x00246924 File Offset: 0x00244B24
		public string SummaryDescribe
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

		// Token: 0x06007875 RID: 30837 RVA: 0x0024695C File Offset: 0x00244B5C
		public Span<byte> GetSummaryDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007876 RID: 30838 RVA: 0x0024696C File Offset: 0x00244B6C
		public byte[] GetSummaryDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06007877 RID: 30839 RVA: 0x00246984 File Offset: 0x00244B84
		public string ThemeColor
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

		// Token: 0x06007878 RID: 30840 RVA: 0x002469BC File Offset: 0x00244BBC
		public Span<byte> GetThemeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x002469CC File Offset: 0x00244BCC
		public byte[] GetThemeColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600787A RID: 30842 RVA: 0x002469E4 File Offset: 0x00244BE4
		public Vector? EffectLocation
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x0600787B RID: 30843 RVA: 0x00246A44 File Offset: 0x00244C44
		public string EffectPath
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

		// Token: 0x0600787C RID: 30844 RVA: 0x00246A7C File Offset: 0x00244C7C
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x00246A8C File Offset: 0x00244C8C
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x0600787E RID: 30846 RVA: 0x00246AA4 File Offset: 0x00244CA4
		public string TextTexture
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

		// Token: 0x0600787F RID: 30847 RVA: 0x00246ADC File Offset: 0x00244CDC
		public Span<byte> GetTextTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x00246AEC File Offset: 0x00244CEC
		public byte[] GetTextTextureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06007881 RID: 30849 RVA: 0x00246B04 File Offset: 0x00244D04
		public string ContentTexturePath
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

		// Token: 0x06007882 RID: 30850 RVA: 0x00246B3C File Offset: 0x00244D3C
		public Span<byte> GetContentTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x00246B4C File Offset: 0x00244D4C
		public byte[] GetContentTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x00246B64 File Offset: 0x00244D64
		public string ContentTextureBgPath
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

		// Token: 0x06007885 RID: 30853 RVA: 0x00246B9C File Offset: 0x00244D9C
		public Span<byte> GetContentTextureBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x00246BAC File Offset: 0x00244DAC
		public byte[] GetContentTextureBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06007887 RID: 30855 RVA: 0x00246BC4 File Offset: 0x00244DC4
		public string UnderBgTexturePath
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

		// Token: 0x06007888 RID: 30856 RVA: 0x00246BFC File Offset: 0x00244DFC
		public Span<byte> GetUnderBgTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00246C0C File Offset: 0x00244E0C
		public byte[] GetUnderBgTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x00246C24 File Offset: 0x00244E24
		public string TagNotSelectedSpritePath
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

		// Token: 0x0600788B RID: 30859 RVA: 0x00246C5C File Offset: 0x00244E5C
		public Span<byte> GetTagNotSelectedSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600788C RID: 30860 RVA: 0x00246C6C File Offset: 0x00244E6C
		public byte[] GetTagNotSelectedSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600788D RID: 30861 RVA: 0x00246C84 File Offset: 0x00244E84
		public string TagSelectedSpritePath
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

		// Token: 0x0600788E RID: 30862 RVA: 0x00246CBC File Offset: 0x00244EBC
		public Span<byte> GetTagSelectedSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00246CCC File Offset: 0x00244ECC
		public byte[] GetTagSelectedSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x06007890 RID: 30864 RVA: 0x00246CE4 File Offset: 0x00244EE4
		public string WeaponPrefabPath
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

		// Token: 0x06007891 RID: 30865 RVA: 0x00246D1C File Offset: 0x00244F1C
		public Span<byte> GetWeaponPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00246D2C File Offset: 0x00244F2C
		public byte[] GetWeaponPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x06007893 RID: 30867 RVA: 0x00246D44 File Offset: 0x00244F44
		public string SpinePrefabResource
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

		// Token: 0x06007894 RID: 30868 RVA: 0x00246D7C File Offset: 0x00244F7C
		public Span<byte> GetSpinePrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00246D8C File Offset: 0x00244F8C
		public byte[] GetSpinePrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00246DA4 File Offset: 0x00244FA4
		public int UpList(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06007897 RID: 30871 RVA: 0x00246DE4 File Offset: 0x00244FE4
		public int UpListLength
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

		// Token: 0x06007898 RID: 30872 RVA: 0x00246E10 File Offset: 0x00245010
		public Span<int> GetUpListBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x00246E20 File Offset: 0x00245020
		public int[] GetUpListArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x00246E38 File Offset: 0x00245038
		public int ShowIdList(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x0600789B RID: 30875 RVA: 0x00246E78 File Offset: 0x00245078
		public int ShowIdListLength
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

		// Token: 0x0600789C RID: 30876 RVA: 0x00246EA4 File Offset: 0x002450A4
		public Span<int> GetShowIdListBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x00246EB4 File Offset: 0x002450B4
		public int[] GetShowIdListArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x00246ECC File Offset: 0x002450CC
		public int PreviewIdList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600789F RID: 30879 RVA: 0x00246F0C File Offset: 0x0024510C
		public int PreviewIdListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x00246F38 File Offset: 0x00245138
		public Span<int> GetPreviewIdListBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x00246F48 File Offset: 0x00245148
		public int[] GetPreviewIdListArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x00246F60 File Offset: 0x00245160
		public int TrialActivityId
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

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x060078A3 RID: 30883 RVA: 0x00246FA0 File Offset: 0x002451A0
		public int TrialRoleId
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x060078A4 RID: 30884 RVA: 0x00246FE0 File Offset: 0x002451E0
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x00247020 File Offset: 0x00245220
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreviewIdListIter()或GetPreviewIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreviewIdList()
		{
			GachaViewInfo gachaViewInfo = this;
			return gachaViewInfo.GetPreviewIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x00247044 File Offset: 0x00245244
		[NullableContext(1)]
		public readonly IEnumerable<int> PreviewIdListIter()
		{
			GachaViewInfo.<PreviewIdListIter>d__84 <PreviewIdListIter>d__ = new GachaViewInfo.<PreviewIdListIter>d__84(-2);
			<PreviewIdListIter>d__.<>3__<>4__this = this;
			return <PreviewIdListIter>d__;
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x0024705C File Offset: 0x0024525C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowIdListIter()或GetShowIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowIdList()
		{
			GachaViewInfo gachaViewInfo = this;
			return gachaViewInfo.GetShowIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x00247080 File Offset: 0x00245280
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowIdListIter()
		{
			GachaViewInfo.<ShowIdListIter>d__86 <ShowIdListIter>d__ = new GachaViewInfo.<ShowIdListIter>d__86(-2);
			<ShowIdListIter>d__.<>3__<>4__this = this;
			return <ShowIdListIter>d__;
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x00247098 File Offset: 0x00245298
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UpListIter()或GetUpListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UpList()
		{
			GachaViewInfo gachaViewInfo = this;
			return gachaViewInfo.GetUpListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x002470BC File Offset: 0x002452BC
		[NullableContext(1)]
		public readonly IEnumerable<int> UpListIter()
		{
			GachaViewInfo.<UpListIter>d__88 <UpListIter>d__ = new GachaViewInfo.<UpListIter>d__88(-2);
			<UpListIter>d__.<>3__<>4__this = this;
			return <UpListIter>d__;
		}

		// Token: 0x04004D56 RID: 19798
		private Table __p;
	}
}
