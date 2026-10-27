using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB9 RID: 3513
	public struct KurotatoWeapon : IFlatbufferObject
	{
		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06008C24 RID: 35876 RVA: 0x00273881 File Offset: 0x00271A81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x0027388E File Offset: 0x00271A8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x00273898 File Offset: 0x00271A98
		public static KurotatoWeapon GetRootAsKurotatoWeapon(ByteBuffer _bb)
		{
			return KurotatoWeapon.GetRootAsKurotatoWeapon(_bb, default(KurotatoWeapon));
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x002738B4 File Offset: 0x00271AB4
		public static KurotatoWeapon GetRootAsKurotatoWeapon(ByteBuffer _bb, KurotatoWeapon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x002738D1 File Offset: 0x00271AD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x002738E0 File Offset: 0x00271AE0
		public KurotatoWeapon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06008C2A RID: 35882 RVA: 0x002738F0 File Offset: 0x00271AF0
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

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06008C2B RID: 35883 RVA: 0x0027392C File Offset: 0x00271B2C
		public int BasicProperty
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

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06008C2C RID: 35884 RVA: 0x00273968 File Offset: 0x00271B68
		public int GroupId
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

		// Token: 0x06008C2D RID: 35885 RVA: 0x002739A4 File Offset: 0x00271BA4
		public int ShowProperty(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06008C2E RID: 35886 RVA: 0x002739E4 File Offset: 0x00271BE4
		public int ShowPropertyLength
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

		// Token: 0x06008C2F RID: 35887 RVA: 0x00273A10 File Offset: 0x00271C10
		public Span<int> GetShowPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008C30 RID: 35888 RVA: 0x00273A20 File Offset: 0x00271C20
		public int[] GetShowPropertyArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06008C31 RID: 35889 RVA: 0x00273A38 File Offset: 0x00271C38
		public int Effect(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06008C32 RID: 35890 RVA: 0x00273A78 File Offset: 0x00271C78
		public int EffectLength
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

		// Token: 0x06008C33 RID: 35891 RVA: 0x00273AA4 File Offset: 0x00271CA4
		public Span<int> GetEffectBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008C34 RID: 35892 RVA: 0x00273AB4 File Offset: 0x00271CB4
		public int[] GetEffectArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06008C35 RID: 35893 RVA: 0x00273ACC File Offset: 0x00271CCC
		public int SimpleCombatSubtypeId
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

		// Token: 0x06008C36 RID: 35894 RVA: 0x00273B0C File Offset: 0x00271D0C
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06008C37 RID: 35895 RVA: 0x00273B4C File Offset: 0x00271D4C
		public int InitBuffsLength
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

		// Token: 0x06008C38 RID: 35896 RVA: 0x00273B78 File Offset: 0x00271D78
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x00273B88 File Offset: 0x00271D88
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06008C3A RID: 35898 RVA: 0x00273BA0 File Offset: 0x00271DA0
		public string Name
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

		// Token: 0x06008C3B RID: 35899 RVA: 0x00273BD8 File Offset: 0x00271DD8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008C3C RID: 35900 RVA: 0x00273BE8 File Offset: 0x00271DE8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06008C3D RID: 35901 RVA: 0x00273C00 File Offset: 0x00271E00
		public int SortId
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

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06008C3E RID: 35902 RVA: 0x00273C40 File Offset: 0x00271E40
		public string Desc
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

		// Token: 0x06008C3F RID: 35903 RVA: 0x00273C78 File Offset: 0x00271E78
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008C40 RID: 35904 RVA: 0x00273C88 File Offset: 0x00271E88
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x00273CA0 File Offset: 0x00271EA0
		public string DescParams(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06008C42 RID: 35906 RVA: 0x00273CDC File Offset: 0x00271EDC
		public int DescParamsLength
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

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06008C43 RID: 35907 RVA: 0x00273D08 File Offset: 0x00271F08
		public string BgDesc
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

		// Token: 0x06008C44 RID: 35908 RVA: 0x00273D40 File Offset: 0x00271F40
		public Span<byte> GetBgDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x00273D50 File Offset: 0x00271F50
		public byte[] GetBgDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06008C46 RID: 35910 RVA: 0x00273D68 File Offset: 0x00271F68
		public string Icon
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

		// Token: 0x06008C47 RID: 35911 RVA: 0x00273DA0 File Offset: 0x00271FA0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06008C48 RID: 35912 RVA: 0x00273DB0 File Offset: 0x00271FB0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06008C49 RID: 35913 RVA: 0x00273DC8 File Offset: 0x00271FC8
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06008C4A RID: 35914 RVA: 0x00273E08 File Offset: 0x00272008
		public int ShopBasicCost
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x00273E48 File Offset: 0x00272048
		public float ShopSellMutiply
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0.6f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x00273E8C File Offset: 0x0027208C
		public DicIntFloat? InheritScale(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntFloat?(default(DicIntFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06008C4D RID: 35917 RVA: 0x00273EF0 File Offset: 0x002720F0
		public int InheritScaleLength
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

		// Token: 0x06008C4E RID: 35918 RVA: 0x00273F1C File Offset: 0x0027211C
		public DicIntInt? InheritSource(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06008C4F RID: 35919 RVA: 0x00273F80 File Offset: 0x00272180
		public int InheritSourceLength
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

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06008C50 RID: 35920 RVA: 0x00273FAC File Offset: 0x002721AC
		public float AttackSpeedBasic
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06008C51 RID: 35921 RVA: 0x00273FF0 File Offset: 0x002721F0
		public int Attr136Basic
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

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06008C52 RID: 35922 RVA: 0x00274030 File Offset: 0x00272230
		public int Attr140Basic
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

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x06008C53 RID: 35923 RVA: 0x00274070 File Offset: 0x00272270
		public int Attr139Basic
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

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06008C54 RID: 35924 RVA: 0x002740B0 File Offset: 0x002722B0
		public int Attr151Basic
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06008C55 RID: 35925 RVA: 0x002740F0 File Offset: 0x002722F0
		public string AttackDes
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

		// Token: 0x06008C56 RID: 35926 RVA: 0x00274128 File Offset: 0x00272328
		public Span<byte> GetAttackDesBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x00274138 File Offset: 0x00272338
		public byte[] GetAttackDesArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x00274150 File Offset: 0x00272350
		public string AttackDesParam(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06008C59 RID: 35929 RVA: 0x0027418C File Offset: 0x0027238C
		public int AttackDesParamLength
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x002741B8 File Offset: 0x002723B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttackDesParamIter()或GetAttackDesParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AttackDesParam()
		{
			return this.AttackDesParamIter().ToArray<string>();
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x002741C5 File Offset: 0x002723C5
		[NullableContext(1)]
		public readonly IEnumerable<string> AttackDesParamIter()
		{
			KurotatoWeapon.<AttackDesParamIter>d__82 <AttackDesParamIter>d__ = new KurotatoWeapon.<AttackDesParamIter>d__82(-2);
			<AttackDesParamIter>d__.<>3__<>4__this = this;
			return <AttackDesParamIter>d__;
		}

		// Token: 0x06008C5C RID: 35932 RVA: 0x002741DA File Offset: 0x002723DA
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DescParamsIter()或GetDescParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x06008C5D RID: 35933 RVA: 0x002741E7 File Offset: 0x002723E7
		[NullableContext(1)]
		public readonly IEnumerable<string> DescParamsIter()
		{
			KurotatoWeapon.<DescParamsIter>d__84 <DescParamsIter>d__ = new KurotatoWeapon.<DescParamsIter>d__84(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x06008C5E RID: 35934 RVA: 0x002741FC File Offset: 0x002723FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectIter()或GetEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Effect()
		{
			KurotatoWeapon kurotatoWeapon = this;
			return kurotatoWeapon.GetEffectArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C5F RID: 35935 RVA: 0x00274220 File Offset: 0x00272420
		[NullableContext(1)]
		public readonly IEnumerable<int> EffectIter()
		{
			KurotatoWeapon.<EffectIter>d__86 <EffectIter>d__ = new KurotatoWeapon.<EffectIter>d__86(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x06008C60 RID: 35936 RVA: 0x00274238 File Offset: 0x00272438
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InheritScaleFrozenDict()缓存字典，遍历请使用InheritScaleIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, float> InheritScale()
		{
			return this.InheritScaleIter().ToDictionary((DicIntFloat element) => element.Key, (DicIntFloat element) => element.Value);
		}

		// Token: 0x06008C61 RID: 35937 RVA: 0x0027428E File Offset: 0x0027248E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntFloat> InheritScaleIter()
		{
			KurotatoWeapon.<InheritScaleIter>d__88 <InheritScaleIter>d__ = new KurotatoWeapon.<InheritScaleIter>d__88(-2);
			<InheritScaleIter>d__.<>3__<>4__this = this;
			return <InheritScaleIter>d__;
		}

		// Token: 0x06008C62 RID: 35938 RVA: 0x002742A4 File Offset: 0x002724A4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InheritSourceFrozenDict()缓存字典，遍历请使用InheritSourceIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> InheritSource()
		{
			return this.InheritSourceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008C63 RID: 35939 RVA: 0x002742FA File Offset: 0x002724FA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> InheritSourceIter()
		{
			KurotatoWeapon.<InheritSourceIter>d__90 <InheritSourceIter>d__ = new KurotatoWeapon.<InheritSourceIter>d__90(-2);
			<InheritSourceIter>d__.<>3__<>4__this = this;
			return <InheritSourceIter>d__;
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x00274310 File Offset: 0x00272510
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitBuffsIter()或GetInitBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitBuffs()
		{
			KurotatoWeapon kurotatoWeapon = this;
			return kurotatoWeapon.GetInitBuffsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x00274334 File Offset: 0x00272534
		[NullableContext(1)]
		public readonly IEnumerable<int> InitBuffsIter()
		{
			KurotatoWeapon.<InitBuffsIter>d__92 <InitBuffsIter>d__ = new KurotatoWeapon.<InitBuffsIter>d__92(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x06008C66 RID: 35942 RVA: 0x0027434C File Offset: 0x0027254C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowPropertyIter()或GetShowPropertyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowProperty()
		{
			KurotatoWeapon kurotatoWeapon = this;
			return kurotatoWeapon.GetShowPropertyArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x00274370 File Offset: 0x00272570
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowPropertyIter()
		{
			KurotatoWeapon.<ShowPropertyIter>d__94 <ShowPropertyIter>d__ = new KurotatoWeapon.<ShowPropertyIter>d__94(-2);
			<ShowPropertyIter>d__.<>3__<>4__this = this;
			return <ShowPropertyIter>d__;
		}

		// Token: 0x06008C68 RID: 35944 RVA: 0x00274388 File Offset: 0x00272588
		public float? GetInheritScale(int key)
		{
			this.EnsureInheritScaleCacheIfNeeded();
			float value;
			if (!this.InheritScaleCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x002743BC File Offset: 0x002725BC
		public int? GetInheritSource(int key)
		{
			this.EnsureInheritSourceCacheIfNeeded();
			int value;
			if (!this.InheritSourceCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x002743F0 File Offset: 0x002725F0
		private void EnsureInheritScaleCacheIfNeeded()
		{
			if (this.InheritScaleCache != null)
			{
				return;
			}
			this.InheritScaleCache = this.InheritScaleIter().ToFrozenDictionary((DicIntFloat kvp) => kvp.Key, (DicIntFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x00274458 File Offset: 0x00272658
		private void EnsureInheritSourceCacheIfNeeded()
		{
			if (this.InheritSourceCache != null)
			{
				return;
			}
			this.InheritSourceCache = this.InheritSourceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x002744BE File Offset: 0x002726BE
		[NullableContext(2)]
		public FrozenDictionary<int, float> GetInheritScaleFrozenDict(int key)
		{
			this.EnsureInheritScaleCacheIfNeeded();
			return this.InheritScaleCache;
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x002744CC File Offset: 0x002726CC
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetInheritSourceFrozenDict(int key)
		{
			this.EnsureInheritSourceCacheIfNeeded();
			return this.InheritSourceCache;
		}

		// Token: 0x04004E4D RID: 20045
		private Table __p;

		// Token: 0x04004E4E RID: 20046
		[Nullable(2)]
		private FrozenDictionary<int, float> InheritScaleCache;

		// Token: 0x04004E4F RID: 20047
		[Nullable(2)]
		private FrozenDictionary<int, int> InheritSourceCache;
	}
}
