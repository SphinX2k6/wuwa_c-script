using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB6 RID: 3254
	public struct FloroRanchTargetType : IFlatbufferObject
	{
		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x0600747D RID: 29821 RVA: 0x0023DC58 File Offset: 0x0023BE58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x0023DC65 File Offset: 0x0023BE65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x0023DC6C File Offset: 0x0023BE6C
		public static FloroRanchTargetType GetRootAsFloroRanchTargetType(ByteBuffer _bb)
		{
			return FloroRanchTargetType.GetRootAsFloroRanchTargetType(_bb, default(FloroRanchTargetType));
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x0023DC88 File Offset: 0x0023BE88
		public static FloroRanchTargetType GetRootAsFloroRanchTargetType(ByteBuffer _bb, FloroRanchTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x0023DCA5 File Offset: 0x0023BEA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x0023DCB4 File Offset: 0x0023BEB4
		public FloroRanchTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06007483 RID: 29827 RVA: 0x0023DCC4 File Offset: 0x0023BEC4
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

		// Token: 0x06007484 RID: 29828 RVA: 0x0023DD00 File Offset: 0x0023BF00
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06007485 RID: 29829 RVA: 0x0023DD60 File Offset: 0x0023BF60
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

		// Token: 0x06007486 RID: 29830 RVA: 0x0023DD8C File Offset: 0x0023BF8C
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06007487 RID: 29831 RVA: 0x0023DDEC File Offset: 0x0023BFEC
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

		// Token: 0x06007488 RID: 29832 RVA: 0x0023DE18 File Offset: 0x0023C018
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param1FrozenDict()缓存字典，遍历请使用Param1Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x0023DE6E File Offset: 0x0023C06E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchTargetType.<Param1Iter>d__17 <Param1Iter>d__ = new FloroRanchTargetType.<Param1Iter>d__17(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x0023DE84 File Offset: 0x0023C084
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param2FrozenDict()缓存字典，遍历请使用Param2Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x0023DEDA File Offset: 0x0023C0DA
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchTargetType.<Param2Iter>d__19 <Param2Iter>d__ = new FloroRanchTargetType.<Param2Iter>d__19(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x0023DEF0 File Offset: 0x0023C0F0
		[NullableContext(1)]
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

		// Token: 0x0600748D RID: 29837 RVA: 0x0023DF18 File Offset: 0x0023C118
		[NullableContext(1)]
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

		// Token: 0x0600748E RID: 29838 RVA: 0x0023DF40 File Offset: 0x0023C140
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x0023DFA8 File Offset: 0x0023C1A8
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x0023E00E File Offset: 0x0023C20E
		[NullableContext(1)]
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

		// Token: 0x06007491 RID: 29841 RVA: 0x0023E01C File Offset: 0x0023C21C
		[NullableContext(1)]
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

		// Token: 0x04004D21 RID: 19745
		private Table __p;

		// Token: 0x04004D22 RID: 19746
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04004D23 RID: 19747
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;
	}
}
