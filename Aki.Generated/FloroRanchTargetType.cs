using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D9A RID: 3482
	public struct FloroRanchTargetType : IFlatbufferObject
	{
		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06007A88 RID: 31368 RVA: 0x0025C9C0 File Offset: 0x0025ABC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x0025C9CD File Offset: 0x0025ABCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x0025C9D4 File Offset: 0x0025ABD4
		public static FloroRanchTargetType GetRootAsFloroRanchTargetType(ByteBuffer _bb)
		{
			return FloroRanchTargetType.GetRootAsFloroRanchTargetType(_bb, default(FloroRanchTargetType));
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x0025C9F0 File Offset: 0x0025ABF0
		public static FloroRanchTargetType GetRootAsFloroRanchTargetType(ByteBuffer _bb, FloroRanchTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x0025CA0D File Offset: 0x0025AC0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x0025CA1C File Offset: 0x0025AC1C
		public FloroRanchTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06007A8E RID: 31374 RVA: 0x0025CA2C File Offset: 0x0025AC2C
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

		// Token: 0x06007A8F RID: 31375 RVA: 0x0025CA68 File Offset: 0x0025AC68
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x0025CAC8 File Offset: 0x0025ACC8
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

		// Token: 0x06007A91 RID: 31377 RVA: 0x0025CAF4 File Offset: 0x0025ACF4
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x0025CB54 File Offset: 0x0025AD54
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

		// Token: 0x06007A93 RID: 31379 RVA: 0x0025CB80 File Offset: 0x0025AD80
		[NullableContext(1)]
		public Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x0025CBD6 File Offset: 0x0025ADD6
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchTargetType.<Param1Iter>d__17 <Param1Iter>d__ = new FloroRanchTargetType.<Param1Iter>d__17(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x0025CBEC File Offset: 0x0025ADEC
		[NullableContext(1)]
		public Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x0025CC42 File Offset: 0x0025AE42
		[NullableContext(1)]
		public IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchTargetType.<Param2Iter>d__19 <Param2Iter>d__ = new FloroRanchTargetType.<Param2Iter>d__19(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x0025CC58 File Offset: 0x0025AE58
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

		// Token: 0x06007A98 RID: 31384 RVA: 0x0025CC80 File Offset: 0x0025AE80
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

		// Token: 0x06007A99 RID: 31385 RVA: 0x0025CCA8 File Offset: 0x0025AEA8
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x0025CD10 File Offset: 0x0025AF10
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x0025CD76 File Offset: 0x0025AF76
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam1FrozenDict()
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x0025CD84 File Offset: 0x0025AF84
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetParam2FrozenDict()
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x04005305 RID: 21253
		private Table __p;

		// Token: 0x04005306 RID: 21254
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04005307 RID: 21255
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;
	}
}
