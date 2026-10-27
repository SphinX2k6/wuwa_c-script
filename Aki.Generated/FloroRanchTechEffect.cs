using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBA RID: 3258
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchTechEffect : IFlatbufferObject
	{
		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x060074C9 RID: 29897 RVA: 0x0023E801 File Offset: 0x0023CA01
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x0023E80E File Offset: 0x0023CA0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x0023E818 File Offset: 0x0023CA18
		[NullableContext(0)]
		public static FloroRanchTechEffect GetRootAsFloroRanchTechEffect(ByteBuffer _bb)
		{
			return FloroRanchTechEffect.GetRootAsFloroRanchTechEffect(_bb, default(FloroRanchTechEffect));
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x0023E834 File Offset: 0x0023CA34
		[NullableContext(0)]
		public static FloroRanchTechEffect GetRootAsFloroRanchTechEffect(ByteBuffer _bb, FloroRanchTechEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x0023E851 File Offset: 0x0023CA51
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x0023E860 File Offset: 0x0023CA60
		[NullableContext(0)]
		public FloroRanchTechEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x060074CF RID: 29903 RVA: 0x0023E870 File Offset: 0x0023CA70
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

		// Token: 0x060074D0 RID: 29904 RVA: 0x0023E8AC File Offset: 0x0023CAAC
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x060074D1 RID: 29905 RVA: 0x0023E90C File Offset: 0x0023CB0C
		public int Param1Length
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

		// Token: 0x060074D2 RID: 29906 RVA: 0x0023E938 File Offset: 0x0023CB38
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x060074D3 RID: 29907 RVA: 0x0023E998 File Offset: 0x0023CB98
		public int Param2Length
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

		// Token: 0x060074D4 RID: 29908 RVA: 0x0023E9C4 File Offset: 0x0023CBC4
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x060074D5 RID: 29909 RVA: 0x0023EA28 File Offset: 0x0023CC28
		public int Param3Length
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

		// Token: 0x060074D6 RID: 29910 RVA: 0x0023EA54 File Offset: 0x0023CC54
		[Obsolete("已废弃，请使用Param1FrozenDict()缓存字典，遍历请使用Param1Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x0023EAAA File Offset: 0x0023CCAA
		public readonly IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchTechEffect.<Param1Iter>d__20 <Param1Iter>d__ = new FloroRanchTechEffect.<Param1Iter>d__20(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x0023EAC0 File Offset: 0x0023CCC0
		[Obsolete("已废弃，请使用Param2FrozenDict()缓存字典，遍历请使用Param2Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x0023EB16 File Offset: 0x0023CD16
		public readonly IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchTechEffect.<Param2Iter>d__22 <Param2Iter>d__ = new FloroRanchTechEffect.<Param2Iter>d__22(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x0023EB2C File Offset: 0x0023CD2C
		[Obsolete("已废弃，请使用Param3FrozenDict()缓存字典，遍历请使用Param3Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x0023EB82 File Offset: 0x0023CD82
		public readonly IEnumerable<DicStringString> Param3Iter()
		{
			FloroRanchTechEffect.<Param3Iter>d__24 <Param3Iter>d__ = new FloroRanchTechEffect.<Param3Iter>d__24(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x0023EB98 File Offset: 0x0023CD98
		[return: Nullable(2)]
		public string GetParam1(string key)
		{
			this.EnsureParam1CacheIfNeeded();
			string result;
			if (!this.Param1Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x0023EBC0 File Offset: 0x0023CDC0
		[return: Nullable(2)]
		public string GetParam2(string key)
		{
			this.EnsureParam2CacheIfNeeded();
			string result;
			if (!this.Param2Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x0023EBE8 File Offset: 0x0023CDE8
		[return: Nullable(2)]
		public string GetParam3(string key)
		{
			this.EnsureParam3CacheIfNeeded();
			string result;
			if (!this.Param3Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x0023EC10 File Offset: 0x0023CE10
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x0023EC78 File Offset: 0x0023CE78
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x0023ECE0 File Offset: 0x0023CEE0
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x0023ED46 File Offset: 0x0023CF46
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam1FrozenDict(string key)
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x0023ED54 File Offset: 0x0023CF54
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam2FrozenDict(string key)
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x0023ED62 File Offset: 0x0023CF62
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam3FrozenDict(string key)
		{
			this.EnsureParam3CacheIfNeeded();
			return this.Param3Cache;
		}

		// Token: 0x04004D27 RID: 19751
		private Table __p;

		// Token: 0x04004D28 RID: 19752
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04004D29 RID: 19753
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x04004D2A RID: 19754
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;
	}
}
