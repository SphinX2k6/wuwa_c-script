using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9E RID: 3230
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchActionType : IFlatbufferObject
	{
		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06007202 RID: 29186 RVA: 0x00237935 File Offset: 0x00235B35
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x00237942 File Offset: 0x00235B42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x0023794C File Offset: 0x00235B4C
		[NullableContext(0)]
		public static FloroRanchActionType GetRootAsFloroRanchActionType(ByteBuffer _bb)
		{
			return FloroRanchActionType.GetRootAsFloroRanchActionType(_bb, default(FloroRanchActionType));
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x00237968 File Offset: 0x00235B68
		[NullableContext(0)]
		public static FloroRanchActionType GetRootAsFloroRanchActionType(ByteBuffer _bb, FloroRanchActionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x00237985 File Offset: 0x00235B85
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x00237994 File Offset: 0x00235B94
		[NullableContext(0)]
		public FloroRanchActionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06007208 RID: 29192 RVA: 0x002379A4 File Offset: 0x00235BA4
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

		// Token: 0x06007209 RID: 29193 RVA: 0x002379E0 File Offset: 0x00235BE0
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x0600720A RID: 29194 RVA: 0x00237A40 File Offset: 0x00235C40
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

		// Token: 0x0600720B RID: 29195 RVA: 0x00237A6C File Offset: 0x00235C6C
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x0600720C RID: 29196 RVA: 0x00237ACC File Offset: 0x00235CCC
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

		// Token: 0x0600720D RID: 29197 RVA: 0x00237AF8 File Offset: 0x00235CF8
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x0600720E RID: 29198 RVA: 0x00237B5C File Offset: 0x00235D5C
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

		// Token: 0x0600720F RID: 29199 RVA: 0x00237B88 File Offset: 0x00235D88
		public DicStringString? Param4(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06007210 RID: 29200 RVA: 0x00237BEC File Offset: 0x00235DEC
		public int Param4Length
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

		// Token: 0x06007211 RID: 29201 RVA: 0x00237C18 File Offset: 0x00235E18
		public DicStringString? Param5(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06007212 RID: 29202 RVA: 0x00237C7C File Offset: 0x00235E7C
		public int Param5Length
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

		// Token: 0x06007213 RID: 29203 RVA: 0x00237CA8 File Offset: 0x00235EA8
		public DicStringString? Param6(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06007214 RID: 29204 RVA: 0x00237D0C File Offset: 0x00235F0C
		public int Param6Length
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

		// Token: 0x06007215 RID: 29205 RVA: 0x00237D38 File Offset: 0x00235F38
		public DicStringString? Param7(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06007216 RID: 29206 RVA: 0x00237D9C File Offset: 0x00235F9C
		public int Param7Length
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

		// Token: 0x06007217 RID: 29207 RVA: 0x00237DC8 File Offset: 0x00235FC8
		[Obsolete("已废弃，请使用Param1FrozenDict()缓存字典，遍历请使用Param1Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x00237E1E File Offset: 0x0023601E
		public readonly IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchActionType.<Param1Iter>d__32 <Param1Iter>d__ = new FloroRanchActionType.<Param1Iter>d__32(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x00237E34 File Offset: 0x00236034
		[Obsolete("已废弃，请使用Param2FrozenDict()缓存字典，遍历请使用Param2Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x00237E8A File Offset: 0x0023608A
		public readonly IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchActionType.<Param2Iter>d__34 <Param2Iter>d__ = new FloroRanchActionType.<Param2Iter>d__34(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x00237EA0 File Offset: 0x002360A0
		[Obsolete("已废弃，请使用Param3FrozenDict()缓存字典，遍历请使用Param3Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x00237EF6 File Offset: 0x002360F6
		public readonly IEnumerable<DicStringString> Param3Iter()
		{
			FloroRanchActionType.<Param3Iter>d__36 <Param3Iter>d__ = new FloroRanchActionType.<Param3Iter>d__36(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00237F0C File Offset: 0x0023610C
		[Obsolete("已废弃，请使用Param4FrozenDict()缓存字典，遍历请使用Param4Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param4()
		{
			return this.Param4Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x00237F62 File Offset: 0x00236162
		public readonly IEnumerable<DicStringString> Param4Iter()
		{
			FloroRanchActionType.<Param4Iter>d__38 <Param4Iter>d__ = new FloroRanchActionType.<Param4Iter>d__38(-2);
			<Param4Iter>d__.<>3__<>4__this = this;
			return <Param4Iter>d__;
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00237F78 File Offset: 0x00236178
		[Obsolete("已废弃，请使用Param5FrozenDict()缓存字典，遍历请使用Param5Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param5()
		{
			return this.Param5Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00237FCE File Offset: 0x002361CE
		public readonly IEnumerable<DicStringString> Param5Iter()
		{
			FloroRanchActionType.<Param5Iter>d__40 <Param5Iter>d__ = new FloroRanchActionType.<Param5Iter>d__40(-2);
			<Param5Iter>d__.<>3__<>4__this = this;
			return <Param5Iter>d__;
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x00237FE4 File Offset: 0x002361E4
		[Obsolete("已废弃，请使用Param6FrozenDict()缓存字典，遍历请使用Param6Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param6()
		{
			return this.Param6Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x0023803A File Offset: 0x0023623A
		public readonly IEnumerable<DicStringString> Param6Iter()
		{
			FloroRanchActionType.<Param6Iter>d__42 <Param6Iter>d__ = new FloroRanchActionType.<Param6Iter>d__42(-2);
			<Param6Iter>d__.<>3__<>4__this = this;
			return <Param6Iter>d__;
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x00238050 File Offset: 0x00236250
		[Obsolete("已废弃，请使用Param7FrozenDict()缓存字典，遍历请使用Param7Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param7()
		{
			return this.Param7Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x002380A6 File Offset: 0x002362A6
		public readonly IEnumerable<DicStringString> Param7Iter()
		{
			FloroRanchActionType.<Param7Iter>d__44 <Param7Iter>d__ = new FloroRanchActionType.<Param7Iter>d__44(-2);
			<Param7Iter>d__.<>3__<>4__this = this;
			return <Param7Iter>d__;
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x002380BC File Offset: 0x002362BC
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

		// Token: 0x06007226 RID: 29222 RVA: 0x002380E4 File Offset: 0x002362E4
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

		// Token: 0x06007227 RID: 29223 RVA: 0x0023810C File Offset: 0x0023630C
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

		// Token: 0x06007228 RID: 29224 RVA: 0x00238134 File Offset: 0x00236334
		[return: Nullable(2)]
		public string GetParam4(string key)
		{
			this.EnsureParam4CacheIfNeeded();
			string result;
			if (!this.Param4Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x0023815C File Offset: 0x0023635C
		[return: Nullable(2)]
		public string GetParam5(string key)
		{
			this.EnsureParam5CacheIfNeeded();
			string result;
			if (!this.Param5Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x00238184 File Offset: 0x00236384
		[return: Nullable(2)]
		public string GetParam6(string key)
		{
			this.EnsureParam6CacheIfNeeded();
			string result;
			if (!this.Param6Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x002381AC File Offset: 0x002363AC
		[return: Nullable(2)]
		public string GetParam7(string key)
		{
			this.EnsureParam7CacheIfNeeded();
			string result;
			if (!this.Param7Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x002381D4 File Offset: 0x002363D4
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x0023823C File Offset: 0x0023643C
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x002382A4 File Offset: 0x002364A4
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x0023830C File Offset: 0x0023650C
		private void EnsureParam4CacheIfNeeded()
		{
			if (this.Param4Cache != null)
			{
				return;
			}
			this.Param4Cache = this.Param4Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00238374 File Offset: 0x00236574
		private void EnsureParam5CacheIfNeeded()
		{
			if (this.Param5Cache != null)
			{
				return;
			}
			this.Param5Cache = this.Param5Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x002383DC File Offset: 0x002365DC
		private void EnsureParam6CacheIfNeeded()
		{
			if (this.Param6Cache != null)
			{
				return;
			}
			this.Param6Cache = this.Param6Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x00238444 File Offset: 0x00236644
		private void EnsureParam7CacheIfNeeded()
		{
			if (this.Param7Cache != null)
			{
				return;
			}
			this.Param7Cache = this.Param7Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x002384AA File Offset: 0x002366AA
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

		// Token: 0x06007234 RID: 29236 RVA: 0x002384B8 File Offset: 0x002366B8
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

		// Token: 0x06007235 RID: 29237 RVA: 0x002384C6 File Offset: 0x002366C6
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

		// Token: 0x06007236 RID: 29238 RVA: 0x002384D4 File Offset: 0x002366D4
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam4FrozenDict(string key)
		{
			this.EnsureParam4CacheIfNeeded();
			return this.Param4Cache;
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x002384E2 File Offset: 0x002366E2
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam5FrozenDict(string key)
		{
			this.EnsureParam5CacheIfNeeded();
			return this.Param5Cache;
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x002384F0 File Offset: 0x002366F0
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam6FrozenDict(string key)
		{
			this.EnsureParam6CacheIfNeeded();
			return this.Param6Cache;
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x002384FE File Offset: 0x002366FE
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam7FrozenDict(string key)
		{
			this.EnsureParam7CacheIfNeeded();
			return this.Param7Cache;
		}

		// Token: 0x04004CF5 RID: 19701
		private Table __p;

		// Token: 0x04004CF6 RID: 19702
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04004CF7 RID: 19703
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x04004CF8 RID: 19704
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;

		// Token: 0x04004CF9 RID: 19705
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param4Cache;

		// Token: 0x04004CFA RID: 19706
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param5Cache;

		// Token: 0x04004CFB RID: 19707
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param6Cache;

		// Token: 0x04004CFC RID: 19708
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param7Cache;
	}
}
