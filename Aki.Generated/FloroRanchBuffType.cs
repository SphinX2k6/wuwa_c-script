using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA2 RID: 3234
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchBuffType : IFlatbufferObject
	{
		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06007283 RID: 29315 RVA: 0x002390D4 File Offset: 0x002372D4
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x002390E1 File Offset: 0x002372E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x002390E8 File Offset: 0x002372E8
		[NullableContext(0)]
		public static FloroRanchBuffType GetRootAsFloroRanchBuffType(ByteBuffer _bb)
		{
			return FloroRanchBuffType.GetRootAsFloroRanchBuffType(_bb, default(FloroRanchBuffType));
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x00239104 File Offset: 0x00237304
		[NullableContext(0)]
		public static FloroRanchBuffType GetRootAsFloroRanchBuffType(ByteBuffer _bb, FloroRanchBuffType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x00239121 File Offset: 0x00237321
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x00239130 File Offset: 0x00237330
		[NullableContext(0)]
		public FloroRanchBuffType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06007289 RID: 29321 RVA: 0x00239140 File Offset: 0x00237340
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

		// Token: 0x0600728A RID: 29322 RVA: 0x0023917C File Offset: 0x0023737C
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x0600728B RID: 29323 RVA: 0x002391DC File Offset: 0x002373DC
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

		// Token: 0x0600728C RID: 29324 RVA: 0x00239208 File Offset: 0x00237408
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x0600728D RID: 29325 RVA: 0x00239268 File Offset: 0x00237468
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

		// Token: 0x0600728E RID: 29326 RVA: 0x00239294 File Offset: 0x00237494
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600728F RID: 29327 RVA: 0x002392F8 File Offset: 0x002374F8
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

		// Token: 0x06007290 RID: 29328 RVA: 0x00239324 File Offset: 0x00237524
		[Obsolete("已废弃，请使用Param1FrozenDict()缓存字典，遍历请使用Param1Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x0023937A File Offset: 0x0023757A
		public readonly IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchBuffType.<Param1Iter>d__20 <Param1Iter>d__ = new FloroRanchBuffType.<Param1Iter>d__20(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x00239390 File Offset: 0x00237590
		[Obsolete("已废弃，请使用Param2FrozenDict()缓存字典，遍历请使用Param2Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x002393E6 File Offset: 0x002375E6
		public readonly IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchBuffType.<Param2Iter>d__22 <Param2Iter>d__ = new FloroRanchBuffType.<Param2Iter>d__22(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x002393FC File Offset: 0x002375FC
		[Obsolete("已废弃，请使用Param3FrozenDict()缓存字典，遍历请使用Param3Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x00239452 File Offset: 0x00237652
		public readonly IEnumerable<DicStringString> Param3Iter()
		{
			FloroRanchBuffType.<Param3Iter>d__24 <Param3Iter>d__ = new FloroRanchBuffType.<Param3Iter>d__24(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x06007296 RID: 29334 RVA: 0x00239468 File Offset: 0x00237668
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

		// Token: 0x06007297 RID: 29335 RVA: 0x00239490 File Offset: 0x00237690
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

		// Token: 0x06007298 RID: 29336 RVA: 0x002394B8 File Offset: 0x002376B8
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

		// Token: 0x06007299 RID: 29337 RVA: 0x002394E0 File Offset: 0x002376E0
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x00239548 File Offset: 0x00237748
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x002395B0 File Offset: 0x002377B0
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x00239616 File Offset: 0x00237816
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

		// Token: 0x0600729D RID: 29341 RVA: 0x00239624 File Offset: 0x00237824
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

		// Token: 0x0600729E RID: 29342 RVA: 0x00239632 File Offset: 0x00237832
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

		// Token: 0x04004D00 RID: 19712
		private Table __p;

		// Token: 0x04004D01 RID: 19713
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04004D02 RID: 19714
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x04004D03 RID: 19715
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;
	}
}
