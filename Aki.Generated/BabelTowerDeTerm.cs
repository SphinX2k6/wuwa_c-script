using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1F RID: 2847
	public struct BabelTowerDeTerm : IFlatbufferObject
	{
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x001DCD14 File Offset: 0x001DAF14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004ABE RID: 19134 RVA: 0x001DCD21 File Offset: 0x001DAF21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x001DCD28 File Offset: 0x001DAF28
		public static BabelTowerDeTerm GetRootAsBabelTowerDeTerm(ByteBuffer _bb)
		{
			return BabelTowerDeTerm.GetRootAsBabelTowerDeTerm(_bb, default(BabelTowerDeTerm));
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x001DCD44 File Offset: 0x001DAF44
		public static BabelTowerDeTerm GetRootAsBabelTowerDeTerm(ByteBuffer _bb, BabelTowerDeTerm obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x001DCD61 File Offset: 0x001DAF61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x001DCD70 File Offset: 0x001DAF70
		public BabelTowerDeTerm __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x001DCD80 File Offset: 0x001DAF80
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x001DCDBC File Offset: 0x001DAFBC
		public int GroupId
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

		// Token: 0x06004AC5 RID: 19141 RVA: 0x001DCDF8 File Offset: 0x001DAFF8
		public int DifficultPreLevel(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06004AC6 RID: 19142 RVA: 0x001DCE38 File Offset: 0x001DB038
		public int DifficultPreLevelLength
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

		// Token: 0x06004AC7 RID: 19143 RVA: 0x001DCE63 File Offset: 0x001DB063
		public Span<int> GetDifficultPreLevelBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x001DCE72 File Offset: 0x001DB072
		public int[] GetDifficultPreLevelArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x001DCE8C File Offset: 0x001DB08C
		public DicIntInt? DifficultPreLevelStar(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06004ACA RID: 19146 RVA: 0x001DCEF0 File Offset: 0x001DB0F0
		public int DifficultPreLevelStarLength
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

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06004ACB RID: 19147 RVA: 0x001DCF1C File Offset: 0x001DB11C
		public int Star
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

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06004ACC RID: 19148 RVA: 0x001DCF5C File Offset: 0x001DB15C
		public int Line
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06004ACD RID: 19149 RVA: 0x001DCF9C File Offset: 0x001DB19C
		public string Texture
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

		// Token: 0x06004ACE RID: 19150 RVA: 0x001DCFD4 File Offset: 0x001DB1D4
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x001DCFE4 File Offset: 0x001DB1E4
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x001DCFFC File Offset: 0x001DB1FC
		public string NameText
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

		// Token: 0x06004AD1 RID: 19153 RVA: 0x001DD034 File Offset: 0x001DB234
		public Span<byte> GetNameTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x001DD044 File Offset: 0x001DB244
		public byte[] GetNameTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x001DD05C File Offset: 0x001DB25C
		public string DesText
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

		// Token: 0x06004AD4 RID: 19156 RVA: 0x001DD094 File Offset: 0x001DB294
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x001DD0A4 File Offset: 0x001DB2A4
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x001DD0BC File Offset: 0x001DB2BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultPreLevelIter()或GetDifficultPreLevelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DifficultPreLevel()
		{
			BabelTowerDeTerm babelTowerDeTerm = this;
			return babelTowerDeTerm.GetDifficultPreLevelArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x001DD0E0 File Offset: 0x001DB2E0
		[NullableContext(1)]
		public readonly IEnumerable<int> DifficultPreLevelIter()
		{
			BabelTowerDeTerm.<DifficultPreLevelIter>d__37 <DifficultPreLevelIter>d__ = new BabelTowerDeTerm.<DifficultPreLevelIter>d__37(-2);
			<DifficultPreLevelIter>d__.<>3__<>4__this = this;
			return <DifficultPreLevelIter>d__;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x001DD0F8 File Offset: 0x001DB2F8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DifficultPreLevelStarFrozenDict()缓存字典，遍历请使用DifficultPreLevelStarIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DifficultPreLevelStar()
		{
			return this.DifficultPreLevelStarIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x001DD14E File Offset: 0x001DB34E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DifficultPreLevelStarIter()
		{
			BabelTowerDeTerm.<DifficultPreLevelStarIter>d__39 <DifficultPreLevelStarIter>d__ = new BabelTowerDeTerm.<DifficultPreLevelStarIter>d__39(-2);
			<DifficultPreLevelStarIter>d__.<>3__<>4__this = this;
			return <DifficultPreLevelStarIter>d__;
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x001DD164 File Offset: 0x001DB364
		public int? GetDifficultPreLevelStar(int key)
		{
			this.EnsureDifficultPreLevelStarCacheIfNeeded();
			int value;
			if (!this.DifficultPreLevelStarCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x001DD198 File Offset: 0x001DB398
		private void EnsureDifficultPreLevelStarCacheIfNeeded()
		{
			if (this.DifficultPreLevelStarCache != null)
			{
				return;
			}
			this.DifficultPreLevelStarCache = this.DifficultPreLevelStarIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x001DD1FE File Offset: 0x001DB3FE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDifficultPreLevelStarFrozenDict(int key)
		{
			this.EnsureDifficultPreLevelStarCacheIfNeeded();
			return this.DifficultPreLevelStarCache;
		}

		// Token: 0x04004B0F RID: 19215
		private Table __p;

		// Token: 0x04004B10 RID: 19216
		[Nullable(2)]
		private FrozenDictionary<int, int> DifficultPreLevelStarCache;
	}
}
