using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9E RID: 3486
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchTechEffect : IFlatbufferObject
	{
		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06007AD4 RID: 31444 RVA: 0x0025D54D File Offset: 0x0025B74D
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x0025D55A File Offset: 0x0025B75A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x0025D564 File Offset: 0x0025B764
		[NullableContext(0)]
		public static FloroRanchTechEffect GetRootAsFloroRanchTechEffect(ByteBuffer _bb)
		{
			return FloroRanchTechEffect.GetRootAsFloroRanchTechEffect(_bb, default(FloroRanchTechEffect));
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x0025D580 File Offset: 0x0025B780
		[NullableContext(0)]
		public static FloroRanchTechEffect GetRootAsFloroRanchTechEffect(ByteBuffer _bb, FloroRanchTechEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AD8 RID: 31448 RVA: 0x0025D59D File Offset: 0x0025B79D
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AD9 RID: 31449 RVA: 0x0025D5AC File Offset: 0x0025B7AC
		[NullableContext(0)]
		public FloroRanchTechEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x06007ADA RID: 31450 RVA: 0x0025D5BC File Offset: 0x0025B7BC
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

		// Token: 0x06007ADB RID: 31451 RVA: 0x0025D5F8 File Offset: 0x0025B7F8
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x06007ADC RID: 31452 RVA: 0x0025D658 File Offset: 0x0025B858
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

		// Token: 0x06007ADD RID: 31453 RVA: 0x0025D684 File Offset: 0x0025B884
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x06007ADE RID: 31454 RVA: 0x0025D6E4 File Offset: 0x0025B8E4
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

		// Token: 0x06007ADF RID: 31455 RVA: 0x0025D710 File Offset: 0x0025B910
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x06007AE0 RID: 31456 RVA: 0x0025D774 File Offset: 0x0025B974
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

		// Token: 0x06007AE1 RID: 31457 RVA: 0x0025D7A0 File Offset: 0x0025B9A0
		public Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x0025D7F6 File Offset: 0x0025B9F6
		public IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchTechEffect.<Param1Iter>d__20 <Param1Iter>d__ = new FloroRanchTechEffect.<Param1Iter>d__20(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x0025D80C File Offset: 0x0025BA0C
		public Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x0025D862 File Offset: 0x0025BA62
		public IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchTechEffect.<Param2Iter>d__22 <Param2Iter>d__ = new FloroRanchTechEffect.<Param2Iter>d__22(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x0025D878 File Offset: 0x0025BA78
		public Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007AE6 RID: 31462 RVA: 0x0025D8CE File Offset: 0x0025BACE
		public IEnumerable<DicStringString> Param3Iter()
		{
			FloroRanchTechEffect.<Param3Iter>d__24 <Param3Iter>d__ = new FloroRanchTechEffect.<Param3Iter>d__24(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x0025D8E4 File Offset: 0x0025BAE4
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

		// Token: 0x06007AE8 RID: 31464 RVA: 0x0025D90C File Offset: 0x0025BB0C
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

		// Token: 0x06007AE9 RID: 31465 RVA: 0x0025D934 File Offset: 0x0025BB34
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

		// Token: 0x06007AEA RID: 31466 RVA: 0x0025D95C File Offset: 0x0025BB5C
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x0025D9C4 File Offset: 0x0025BBC4
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x0025DA2C File Offset: 0x0025BC2C
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007AED RID: 31469 RVA: 0x0025DA92 File Offset: 0x0025BC92
		public FrozenDictionary<string, string> GetParam1FrozenDict()
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x06007AEE RID: 31470 RVA: 0x0025DAA0 File Offset: 0x0025BCA0
		public FrozenDictionary<string, string> GetParam2FrozenDict()
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x06007AEF RID: 31471 RVA: 0x0025DAAE File Offset: 0x0025BCAE
		public FrozenDictionary<string, string> GetParam3FrozenDict()
		{
			this.EnsureParam3CacheIfNeeded();
			return this.Param3Cache;
		}

		// Token: 0x0400530B RID: 21259
		private Table __p;

		// Token: 0x0400530C RID: 21260
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x0400530D RID: 21261
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x0400530E RID: 21262
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;
	}
}
