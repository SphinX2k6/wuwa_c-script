using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB4 RID: 3508
	public struct KurotatoStructure : IFlatbufferObject
	{
		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06008BA5 RID: 35749 RVA: 0x002726BD File Offset: 0x002708BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x002726CA File Offset: 0x002708CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x002726D4 File Offset: 0x002708D4
		public static KurotatoStructure GetRootAsKurotatoStructure(ByteBuffer _bb)
		{
			return KurotatoStructure.GetRootAsKurotatoStructure(_bb, default(KurotatoStructure));
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x002726F0 File Offset: 0x002708F0
		public static KurotatoStructure GetRootAsKurotatoStructure(ByteBuffer _bb, KurotatoStructure obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BA9 RID: 35753 RVA: 0x0027270D File Offset: 0x0027090D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x0027271C File Offset: 0x0027091C
		public KurotatoStructure __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06008BAB RID: 35755 RVA: 0x0027272C File Offset: 0x0027092C
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

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06008BAC RID: 35756 RVA: 0x00272768 File Offset: 0x00270968
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

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x002727A4 File Offset: 0x002709A4
		public int TemplateId
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

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06008BAE RID: 35758 RVA: 0x002727E0 File Offset: 0x002709E0
		public int SimpleCombatSubtypeId
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

		// Token: 0x06008BAF RID: 35759 RVA: 0x00272820 File Offset: 0x00270A20
		public int Deathrattles(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06008BB0 RID: 35760 RVA: 0x00272860 File Offset: 0x00270A60
		public int DeathrattlesLength
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

		// Token: 0x06008BB1 RID: 35761 RVA: 0x0027288C File Offset: 0x00270A8C
		public Span<int> GetDeathrattlesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x0027289C File Offset: 0x00270A9C
		public int[] GetDeathrattlesArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06008BB3 RID: 35763 RVA: 0x002728B4 File Offset: 0x00270AB4
		public string Type
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

		// Token: 0x06008BB4 RID: 35764 RVA: 0x002728EC File Offset: 0x00270AEC
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008BB5 RID: 35765 RVA: 0x002728FC File Offset: 0x00270AFC
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06008BB6 RID: 35766 RVA: 0x00272914 File Offset: 0x00270B14
		public string Param1
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

		// Token: 0x06008BB7 RID: 35767 RVA: 0x0027294C File Offset: 0x00270B4C
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x0027295C File Offset: 0x00270B5C
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06008BB9 RID: 35769 RVA: 0x00272974 File Offset: 0x00270B74
		public string Param2
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

		// Token: 0x06008BBA RID: 35770 RVA: 0x002729AC File Offset: 0x00270BAC
		public Span<byte> GetParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008BBB RID: 35771 RVA: 0x002729BC File Offset: 0x00270BBC
		public byte[] GetParam2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06008BBC RID: 35772 RVA: 0x002729D4 File Offset: 0x00270BD4
		public string Param3
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

		// Token: 0x06008BBD RID: 35773 RVA: 0x00272A0C File Offset: 0x00270C0C
		public Span<byte> GetParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x00272A1C File Offset: 0x00270C1C
		public byte[] GetParam3Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06008BBF RID: 35775 RVA: 0x00272A34 File Offset: 0x00270C34
		public string Param4
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

		// Token: 0x06008BC0 RID: 35776 RVA: 0x00272A6C File Offset: 0x00270C6C
		public Span<byte> GetParam4Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x00272A7C File Offset: 0x00270C7C
		public byte[] GetParam4Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06008BC2 RID: 35778 RVA: 0x00272A94 File Offset: 0x00270C94
		public string Param5
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

		// Token: 0x06008BC3 RID: 35779 RVA: 0x00272ACC File Offset: 0x00270CCC
		public Span<byte> GetParam5Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x00272ADC File Offset: 0x00270CDC
		public byte[] GetParam5Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06008BC5 RID: 35781 RVA: 0x00272AF4 File Offset: 0x00270CF4
		public string Param6
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

		// Token: 0x06008BC6 RID: 35782 RVA: 0x00272B2C File Offset: 0x00270D2C
		public Span<byte> GetParam6Bytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008BC7 RID: 35783 RVA: 0x00272B3C File Offset: 0x00270D3C
		public byte[] GetParam6Array()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06008BC8 RID: 35784 RVA: 0x00272B54 File Offset: 0x00270D54
		public DicIntFloat? InheritScale(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntFloat?(default(DicIntFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06008BC9 RID: 35785 RVA: 0x00272BB8 File Offset: 0x00270DB8
		public int InheritScaleLength
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

		// Token: 0x06008BCA RID: 35786 RVA: 0x00272BE4 File Offset: 0x00270DE4
		public DicIntInt? InheritSource(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06008BCB RID: 35787 RVA: 0x00272C48 File Offset: 0x00270E48
		public int InheritSourceLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x00272C74 File Offset: 0x00270E74
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DeathrattlesIter()或GetDeathrattlesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Deathrattles()
		{
			KurotatoStructure kurotatoStructure = this;
			return kurotatoStructure.GetDeathrattlesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x00272C98 File Offset: 0x00270E98
		[NullableContext(1)]
		public readonly IEnumerable<int> DeathrattlesIter()
		{
			KurotatoStructure.<DeathrattlesIter>d__56 <DeathrattlesIter>d__ = new KurotatoStructure.<DeathrattlesIter>d__56(-2);
			<DeathrattlesIter>d__.<>3__<>4__this = this;
			return <DeathrattlesIter>d__;
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x00272CB0 File Offset: 0x00270EB0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InheritScaleFrozenDict()缓存字典，遍历请使用InheritScaleIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, float> InheritScale()
		{
			return this.InheritScaleIter().ToDictionary((DicIntFloat element) => element.Key, (DicIntFloat element) => element.Value);
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x00272D06 File Offset: 0x00270F06
		[NullableContext(1)]
		public readonly IEnumerable<DicIntFloat> InheritScaleIter()
		{
			KurotatoStructure.<InheritScaleIter>d__58 <InheritScaleIter>d__ = new KurotatoStructure.<InheritScaleIter>d__58(-2);
			<InheritScaleIter>d__.<>3__<>4__this = this;
			return <InheritScaleIter>d__;
		}

		// Token: 0x06008BD0 RID: 35792 RVA: 0x00272D1C File Offset: 0x00270F1C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InheritSourceFrozenDict()缓存字典，遍历请使用InheritSourceIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> InheritSource()
		{
			return this.InheritSourceIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008BD1 RID: 35793 RVA: 0x00272D72 File Offset: 0x00270F72
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> InheritSourceIter()
		{
			KurotatoStructure.<InheritSourceIter>d__60 <InheritSourceIter>d__ = new KurotatoStructure.<InheritSourceIter>d__60(-2);
			<InheritSourceIter>d__.<>3__<>4__this = this;
			return <InheritSourceIter>d__;
		}

		// Token: 0x06008BD2 RID: 35794 RVA: 0x00272D88 File Offset: 0x00270F88
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

		// Token: 0x06008BD3 RID: 35795 RVA: 0x00272DBC File Offset: 0x00270FBC
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

		// Token: 0x06008BD4 RID: 35796 RVA: 0x00272DF0 File Offset: 0x00270FF0
		private void EnsureInheritScaleCacheIfNeeded()
		{
			if (this.InheritScaleCache != null)
			{
				return;
			}
			this.InheritScaleCache = this.InheritScaleIter().ToFrozenDictionary((DicIntFloat kvp) => kvp.Key, (DicIntFloat kvp) => kvp.Value, null);
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x00272E58 File Offset: 0x00271058
		private void EnsureInheritSourceCacheIfNeeded()
		{
			if (this.InheritSourceCache != null)
			{
				return;
			}
			this.InheritSourceCache = this.InheritSourceIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x00272EBE File Offset: 0x002710BE
		[NullableContext(2)]
		public FrozenDictionary<int, float> GetInheritScaleFrozenDict(int key)
		{
			this.EnsureInheritScaleCacheIfNeeded();
			return this.InheritScaleCache;
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x00272ECC File Offset: 0x002710CC
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetInheritSourceFrozenDict(int key)
		{
			this.EnsureInheritSourceCacheIfNeeded();
			return this.InheritSourceCache;
		}

		// Token: 0x04004E46 RID: 20038
		private Table __p;

		// Token: 0x04004E47 RID: 20039
		[Nullable(2)]
		private FrozenDictionary<int, float> InheritScaleCache;

		// Token: 0x04004E48 RID: 20040
		[Nullable(2)]
		private FrozenDictionary<int, int> InheritSourceCache;
	}
}
