using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE6 RID: 3814
	public struct PhantomFetterGroup : IFlatbufferObject
	{
		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x0600A889 RID: 43145 RVA: 0x002B30E7 File Offset: 0x002B12E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A88A RID: 43146 RVA: 0x002B30F4 File Offset: 0x002B12F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A88B RID: 43147 RVA: 0x002B30FC File Offset: 0x002B12FC
		public static PhantomFetterGroup GetRootAsPhantomFetterGroup(ByteBuffer _bb)
		{
			return PhantomFetterGroup.GetRootAsPhantomFetterGroup(_bb, default(PhantomFetterGroup));
		}

		// Token: 0x0600A88C RID: 43148 RVA: 0x002B3118 File Offset: 0x002B1318
		public static PhantomFetterGroup GetRootAsPhantomFetterGroup(ByteBuffer _bb, PhantomFetterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A88D RID: 43149 RVA: 0x002B3135 File Offset: 0x002B1335
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A88E RID: 43150 RVA: 0x002B3144 File Offset: 0x002B1344
		public PhantomFetterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x0600A88F RID: 43151 RVA: 0x002B3154 File Offset: 0x002B1354
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

		// Token: 0x0600A890 RID: 43152 RVA: 0x002B3190 File Offset: 0x002B1390
		public DicIntInt? FetterMap(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x0600A891 RID: 43153 RVA: 0x002B31F0 File Offset: 0x002B13F0
		public int FetterMapLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x0600A892 RID: 43154 RVA: 0x002B321C File Offset: 0x002B141C
		public int FetterType
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

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x0600A893 RID: 43155 RVA: 0x002B3258 File Offset: 0x002B1458
		public string FetterGroupName
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

		// Token: 0x0600A894 RID: 43156 RVA: 0x002B3290 File Offset: 0x002B1490
		public Span<byte> GetFetterGroupNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x002B32A0 File Offset: 0x002B14A0
		public byte[] GetFetterGroupNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x0600A896 RID: 43158 RVA: 0x002B32B8 File Offset: 0x002B14B8
		public int AccessId
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

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x0600A897 RID: 43159 RVA: 0x002B32F8 File Offset: 0x002B14F8
		public string FetterGroupDesc
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

		// Token: 0x0600A898 RID: 43160 RVA: 0x002B3330 File Offset: 0x002B1530
		public Span<byte> GetFetterGroupDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x002B3340 File Offset: 0x002B1540
		public byte[] GetFetterGroupDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x0600A89A RID: 43162 RVA: 0x002B3358 File Offset: 0x002B1558
		public int SortId
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

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x0600A89B RID: 43163 RVA: 0x002B3398 File Offset: 0x002B1598
		public string FetterElementColor
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

		// Token: 0x0600A89C RID: 43164 RVA: 0x002B33D0 File Offset: 0x002B15D0
		public Span<byte> GetFetterElementColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A89D RID: 43165 RVA: 0x002B33E0 File Offset: 0x002B15E0
		public byte[] GetFetterElementColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x0600A89E RID: 43166 RVA: 0x002B33F8 File Offset: 0x002B15F8
		public string FetterElementPath
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

		// Token: 0x0600A89F RID: 43167 RVA: 0x002B3430 File Offset: 0x002B1630
		public Span<byte> GetFetterElementPathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A8A0 RID: 43168 RVA: 0x002B3440 File Offset: 0x002B1640
		public byte[] GetFetterElementPathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x0600A8A1 RID: 43169 RVA: 0x002B3458 File Offset: 0x002B1658
		public string AimModelElementPath
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

		// Token: 0x0600A8A2 RID: 43170 RVA: 0x002B3490 File Offset: 0x002B1690
		public Span<byte> GetAimModelElementPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A8A3 RID: 43171 RVA: 0x002B34A0 File Offset: 0x002B16A0
		public byte[] GetAimModelElementPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A8A4 RID: 43172 RVA: 0x002B34B8 File Offset: 0x002B16B8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FetterMapFrozenDict()缓存字典，遍历请使用FetterMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FetterMap()
		{
			return this.FetterMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A8A5 RID: 43173 RVA: 0x002B350E File Offset: 0x002B170E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FetterMapIter()
		{
			PhantomFetterGroup.<FetterMapIter>d__40 <FetterMapIter>d__ = new PhantomFetterGroup.<FetterMapIter>d__40(-2);
			<FetterMapIter>d__.<>3__<>4__this = this;
			return <FetterMapIter>d__;
		}

		// Token: 0x0600A8A6 RID: 43174 RVA: 0x002B3524 File Offset: 0x002B1724
		public int? GetFetterMap(int key)
		{
			this.EnsureFetterMapCacheIfNeeded();
			int value;
			if (!this.FetterMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A8A7 RID: 43175 RVA: 0x002B3558 File Offset: 0x002B1758
		private void EnsureFetterMapCacheIfNeeded()
		{
			if (this.FetterMapCache != null)
			{
				return;
			}
			this.FetterMapCache = this.FetterMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A8A8 RID: 43176 RVA: 0x002B35BE File Offset: 0x002B17BE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFetterMapFrozenDict(int key)
		{
			this.EnsureFetterMapCacheIfNeeded();
			return this.FetterMapCache;
		}

		// Token: 0x04004FA7 RID: 20391
		private Table __p;

		// Token: 0x04004FA8 RID: 20392
		[Nullable(2)]
		private FrozenDictionary<int, int> FetterMapCache;
	}
}
