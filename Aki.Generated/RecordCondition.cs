using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108B RID: 4235
	[NullableContext(1)]
	[Nullable(0)]
	public struct RecordCondition : IFlatbufferObject
	{
		// Token: 0x17002DDA RID: 11738
		// (get) Token: 0x0600C070 RID: 49264 RVA: 0x002F6720 File Offset: 0x002F4920
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C071 RID: 49265 RVA: 0x002F672D File Offset: 0x002F492D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C072 RID: 49266 RVA: 0x002F6734 File Offset: 0x002F4934
		[NullableContext(0)]
		public static RecordCondition GetRootAsRecordCondition(ByteBuffer _bb)
		{
			return RecordCondition.GetRootAsRecordCondition(_bb, default(RecordCondition));
		}

		// Token: 0x0600C073 RID: 49267 RVA: 0x002F6750 File Offset: 0x002F4950
		[NullableContext(0)]
		public static RecordCondition GetRootAsRecordCondition(ByteBuffer _bb, RecordCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C074 RID: 49268 RVA: 0x002F676D File Offset: 0x002F496D
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C075 RID: 49269 RVA: 0x002F677C File Offset: 0x002F497C
		[NullableContext(0)]
		public RecordCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DDB RID: 11739
		// (get) Token: 0x0600C076 RID: 49270 RVA: 0x002F678C File Offset: 0x002F498C
		public int TypeId
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

		// Token: 0x17002DDC RID: 11740
		// (get) Token: 0x0600C077 RID: 49271 RVA: 0x002F67C8 File Offset: 0x002F49C8
		[Nullable(0)]
		public string Type
		{
			[NullableContext(0)]
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C078 RID: 49272 RVA: 0x002F67FF File Offset: 0x002F49FF
		[NullableContext(0)]
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C079 RID: 49273 RVA: 0x002F680E File Offset: 0x002F4A0E
		[NullableContext(0)]
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C07A RID: 49274 RVA: 0x002F6828 File Offset: 0x002F4A28
		public int Nullenable(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002DDD RID: 11741
		// (get) Token: 0x0600C07B RID: 49275 RVA: 0x002F6868 File Offset: 0x002F4A68
		public int NullenableLength
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

		// Token: 0x0600C07C RID: 49276 RVA: 0x002F6893 File Offset: 0x002F4A93
		[NullableContext(0)]
		public Span<int> GetNullenableBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600C07D RID: 49277 RVA: 0x002F68A2 File Offset: 0x002F4AA2
		[NullableContext(0)]
		public int[] GetNullenableArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600C07E RID: 49278 RVA: 0x002F68BC File Offset: 0x002F4ABC
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DDE RID: 11742
		// (get) Token: 0x0600C07F RID: 49279 RVA: 0x002F6920 File Offset: 0x002F4B20
		public int Param1Length
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

		// Token: 0x0600C080 RID: 49280 RVA: 0x002F694C File Offset: 0x002F4B4C
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DDF RID: 11743
		// (get) Token: 0x0600C081 RID: 49281 RVA: 0x002F69B0 File Offset: 0x002F4BB0
		public int Param2Length
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

		// Token: 0x0600C082 RID: 49282 RVA: 0x002F69DC File Offset: 0x002F4BDC
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DE0 RID: 11744
		// (get) Token: 0x0600C083 RID: 49283 RVA: 0x002F6A40 File Offset: 0x002F4C40
		public int Param3Length
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

		// Token: 0x0600C084 RID: 49284 RVA: 0x002F6A6C File Offset: 0x002F4C6C
		public DicStringString? Param4(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DE1 RID: 11745
		// (get) Token: 0x0600C085 RID: 49285 RVA: 0x002F6AD0 File Offset: 0x002F4CD0
		public int Param4Length
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

		// Token: 0x0600C086 RID: 49286 RVA: 0x002F6AFC File Offset: 0x002F4CFC
		public DicStringString? Param5(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x0600C087 RID: 49287 RVA: 0x002F6B60 File Offset: 0x002F4D60
		public int Param5Length
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

		// Token: 0x0600C088 RID: 49288 RVA: 0x002F6B8C File Offset: 0x002F4D8C
		public int[] Nullenable()
		{
			return this.GetNullenableArray();
		}

		// Token: 0x0600C089 RID: 49289 RVA: 0x002F6B94 File Offset: 0x002F4D94
		public IEnumerable<int> NullenableIter()
		{
			RecordCondition.<NullenableIter>d__35 <NullenableIter>d__ = new RecordCondition.<NullenableIter>d__35(-2);
			<NullenableIter>d__.<>3__<>4__this = this;
			return <NullenableIter>d__;
		}

		// Token: 0x0600C08A RID: 49290 RVA: 0x002F6BAC File Offset: 0x002F4DAC
		public Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600C08B RID: 49291 RVA: 0x002F6C02 File Offset: 0x002F4E02
		public IEnumerable<DicStringString> Param1Iter()
		{
			RecordCondition.<Param1Iter>d__37 <Param1Iter>d__ = new RecordCondition.<Param1Iter>d__37(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x0600C08C RID: 49292 RVA: 0x002F6C18 File Offset: 0x002F4E18
		public Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600C08D RID: 49293 RVA: 0x002F6C6E File Offset: 0x002F4E6E
		public IEnumerable<DicStringString> Param2Iter()
		{
			RecordCondition.<Param2Iter>d__39 <Param2Iter>d__ = new RecordCondition.<Param2Iter>d__39(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x0600C08E RID: 49294 RVA: 0x002F6C84 File Offset: 0x002F4E84
		public Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600C08F RID: 49295 RVA: 0x002F6CDA File Offset: 0x002F4EDA
		public IEnumerable<DicStringString> Param3Iter()
		{
			RecordCondition.<Param3Iter>d__41 <Param3Iter>d__ = new RecordCondition.<Param3Iter>d__41(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x0600C090 RID: 49296 RVA: 0x002F6CF0 File Offset: 0x002F4EF0
		public Dictionary<string, string> Param4()
		{
			return this.Param4Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600C091 RID: 49297 RVA: 0x002F6D46 File Offset: 0x002F4F46
		public IEnumerable<DicStringString> Param4Iter()
		{
			RecordCondition.<Param4Iter>d__43 <Param4Iter>d__ = new RecordCondition.<Param4Iter>d__43(-2);
			<Param4Iter>d__.<>3__<>4__this = this;
			return <Param4Iter>d__;
		}

		// Token: 0x0600C092 RID: 49298 RVA: 0x002F6D5C File Offset: 0x002F4F5C
		public Dictionary<string, string> Param5()
		{
			return this.Param5Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600C093 RID: 49299 RVA: 0x002F6DB2 File Offset: 0x002F4FB2
		public IEnumerable<DicStringString> Param5Iter()
		{
			RecordCondition.<Param5Iter>d__45 <Param5Iter>d__ = new RecordCondition.<Param5Iter>d__45(-2);
			<Param5Iter>d__.<>3__<>4__this = this;
			return <Param5Iter>d__;
		}

		// Token: 0x0600C094 RID: 49300 RVA: 0x002F6DC8 File Offset: 0x002F4FC8
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

		// Token: 0x0600C095 RID: 49301 RVA: 0x002F6DF0 File Offset: 0x002F4FF0
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

		// Token: 0x0600C096 RID: 49302 RVA: 0x002F6E18 File Offset: 0x002F5018
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

		// Token: 0x0600C097 RID: 49303 RVA: 0x002F6E40 File Offset: 0x002F5040
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

		// Token: 0x0600C098 RID: 49304 RVA: 0x002F6E68 File Offset: 0x002F5068
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

		// Token: 0x0600C099 RID: 49305 RVA: 0x002F6E90 File Offset: 0x002F5090
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C09A RID: 49306 RVA: 0x002F6EF8 File Offset: 0x002F50F8
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C09B RID: 49307 RVA: 0x002F6F60 File Offset: 0x002F5160
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C09C RID: 49308 RVA: 0x002F6FC8 File Offset: 0x002F51C8
		private void EnsureParam4CacheIfNeeded()
		{
			if (this.Param4Cache != null)
			{
				return;
			}
			this.Param4Cache = this.Param4Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C09D RID: 49309 RVA: 0x002F7030 File Offset: 0x002F5230
		private void EnsureParam5CacheIfNeeded()
		{
			if (this.Param5Cache != null)
			{
				return;
			}
			this.Param5Cache = this.Param5Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C09E RID: 49310 RVA: 0x002F7096 File Offset: 0x002F5296
		public FrozenDictionary<string, string> GetParam1FrozenDict()
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x0600C09F RID: 49311 RVA: 0x002F70A4 File Offset: 0x002F52A4
		public FrozenDictionary<string, string> GetParam2FrozenDict()
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x0600C0A0 RID: 49312 RVA: 0x002F70B2 File Offset: 0x002F52B2
		public FrozenDictionary<string, string> GetParam3FrozenDict()
		{
			this.EnsureParam3CacheIfNeeded();
			return this.Param3Cache;
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x002F70C0 File Offset: 0x002F52C0
		public FrozenDictionary<string, string> GetParam4FrozenDict()
		{
			this.EnsureParam4CacheIfNeeded();
			return this.Param4Cache;
		}

		// Token: 0x0600C0A2 RID: 49314 RVA: 0x002F70CE File Offset: 0x002F52CE
		public FrozenDictionary<string, string> GetParam5FrozenDict()
		{
			this.EnsureParam5CacheIfNeeded();
			return this.Param5Cache;
		}

		// Token: 0x0400565E RID: 22110
		private Table __p;

		// Token: 0x0400565F RID: 22111
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04005660 RID: 22112
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x04005661 RID: 22113
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;

		// Token: 0x04005662 RID: 22114
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param4Cache;

		// Token: 0x04005663 RID: 22115
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param5Cache;
	}
}
