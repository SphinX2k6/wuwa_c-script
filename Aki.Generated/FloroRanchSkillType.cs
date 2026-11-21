using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D95 RID: 3477
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchSkillType : IFlatbufferObject
	{
		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x0025B248 File Offset: 0x00259448
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x0025B255 File Offset: 0x00259455
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060079EC RID: 31212 RVA: 0x0025B25C File Offset: 0x0025945C
		[NullableContext(0)]
		public static FloroRanchSkillType GetRootAsFloroRanchSkillType(ByteBuffer _bb)
		{
			return FloroRanchSkillType.GetRootAsFloroRanchSkillType(_bb, default(FloroRanchSkillType));
		}

		// Token: 0x060079ED RID: 31213 RVA: 0x0025B278 File Offset: 0x00259478
		[NullableContext(0)]
		public static FloroRanchSkillType GetRootAsFloroRanchSkillType(ByteBuffer _bb, FloroRanchSkillType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060079EE RID: 31214 RVA: 0x0025B295 File Offset: 0x00259495
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060079EF RID: 31215 RVA: 0x0025B2A4 File Offset: 0x002594A4
		[NullableContext(0)]
		public FloroRanchSkillType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x060079F0 RID: 31216 RVA: 0x0025B2B4 File Offset: 0x002594B4
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

		// Token: 0x060079F1 RID: 31217 RVA: 0x0025B2F0 File Offset: 0x002594F0
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x060079F2 RID: 31218 RVA: 0x0025B350 File Offset: 0x00259550
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

		// Token: 0x060079F3 RID: 31219 RVA: 0x0025B37C File Offset: 0x0025957C
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x060079F4 RID: 31220 RVA: 0x0025B3DC File Offset: 0x002595DC
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

		// Token: 0x060079F5 RID: 31221 RVA: 0x0025B408 File Offset: 0x00259608
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x060079F6 RID: 31222 RVA: 0x0025B46C File Offset: 0x0025966C
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

		// Token: 0x060079F7 RID: 31223 RVA: 0x0025B498 File Offset: 0x00259698
		public Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060079F8 RID: 31224 RVA: 0x0025B4EE File Offset: 0x002596EE
		public IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchSkillType.<Param1Iter>d__20 <Param1Iter>d__ = new FloroRanchSkillType.<Param1Iter>d__20(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x060079F9 RID: 31225 RVA: 0x0025B504 File Offset: 0x00259704
		public Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060079FA RID: 31226 RVA: 0x0025B55A File Offset: 0x0025975A
		public IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchSkillType.<Param2Iter>d__22 <Param2Iter>d__ = new FloroRanchSkillType.<Param2Iter>d__22(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x060079FB RID: 31227 RVA: 0x0025B570 File Offset: 0x00259770
		public Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060079FC RID: 31228 RVA: 0x0025B5C6 File Offset: 0x002597C6
		public IEnumerable<DicStringString> Param3Iter()
		{
			FloroRanchSkillType.<Param3Iter>d__24 <Param3Iter>d__ = new FloroRanchSkillType.<Param3Iter>d__24(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x060079FD RID: 31229 RVA: 0x0025B5DC File Offset: 0x002597DC
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

		// Token: 0x060079FE RID: 31230 RVA: 0x0025B604 File Offset: 0x00259804
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

		// Token: 0x060079FF RID: 31231 RVA: 0x0025B62C File Offset: 0x0025982C
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

		// Token: 0x06007A00 RID: 31232 RVA: 0x0025B654 File Offset: 0x00259854
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x0025B6BC File Offset: 0x002598BC
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x0025B724 File Offset: 0x00259924
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x0025B78A File Offset: 0x0025998A
		public FrozenDictionary<string, string> GetParam1FrozenDict()
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x06007A04 RID: 31236 RVA: 0x0025B798 File Offset: 0x00259998
		public FrozenDictionary<string, string> GetParam2FrozenDict()
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x0025B7A6 File Offset: 0x002599A6
		public FrozenDictionary<string, string> GetParam3FrozenDict()
		{
			this.EnsureParam3CacheIfNeeded();
			return this.Param3Cache;
		}

		// Token: 0x040052FA RID: 21242
		private Table __p;

		// Token: 0x040052FB RID: 21243
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x040052FC RID: 21244
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x040052FD RID: 21245
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;
	}
}
