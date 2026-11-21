using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D86 RID: 3462
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchBuffType : IFlatbufferObject
	{
		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x0600788E RID: 30862 RVA: 0x00258080 File Offset: 0x00256280
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x0025808D File Offset: 0x0025628D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x00258094 File Offset: 0x00256294
		[NullableContext(0)]
		public static FloroRanchBuffType GetRootAsFloroRanchBuffType(ByteBuffer _bb)
		{
			return FloroRanchBuffType.GetRootAsFloroRanchBuffType(_bb, default(FloroRanchBuffType));
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x002580B0 File Offset: 0x002562B0
		[NullableContext(0)]
		public static FloroRanchBuffType GetRootAsFloroRanchBuffType(ByteBuffer _bb, FloroRanchBuffType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x002580CD File Offset: 0x002562CD
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x002580DC File Offset: 0x002562DC
		[NullableContext(0)]
		public FloroRanchBuffType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06007894 RID: 30868 RVA: 0x002580EC File Offset: 0x002562EC
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

		// Token: 0x06007895 RID: 30869 RVA: 0x00258128 File Offset: 0x00256328
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06007896 RID: 30870 RVA: 0x00258188 File Offset: 0x00256388
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

		// Token: 0x06007897 RID: 30871 RVA: 0x002581B4 File Offset: 0x002563B4
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06007898 RID: 30872 RVA: 0x00258214 File Offset: 0x00256414
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

		// Token: 0x06007899 RID: 30873 RVA: 0x00258240 File Offset: 0x00256440
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x002582A4 File Offset: 0x002564A4
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

		// Token: 0x0600789B RID: 30875 RVA: 0x002582D0 File Offset: 0x002564D0
		public Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x00258326 File Offset: 0x00256526
		public IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchBuffType.<Param1Iter>d__20 <Param1Iter>d__ = new FloroRanchBuffType.<Param1Iter>d__20(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x0025833C File Offset: 0x0025653C
		public Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x00258392 File Offset: 0x00256592
		public IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchBuffType.<Param2Iter>d__22 <Param2Iter>d__ = new FloroRanchBuffType.<Param2Iter>d__22(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x0600789F RID: 30879 RVA: 0x002583A8 File Offset: 0x002565A8
		public Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x002583FE File Offset: 0x002565FE
		public IEnumerable<DicStringString> Param3Iter()
		{
			FloroRanchBuffType.<Param3Iter>d__24 <Param3Iter>d__ = new FloroRanchBuffType.<Param3Iter>d__24(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x00258414 File Offset: 0x00256614
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

		// Token: 0x060078A2 RID: 30882 RVA: 0x0025843C File Offset: 0x0025663C
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

		// Token: 0x060078A3 RID: 30883 RVA: 0x00258464 File Offset: 0x00256664
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

		// Token: 0x060078A4 RID: 30884 RVA: 0x0025848C File Offset: 0x0025668C
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x002584F4 File Offset: 0x002566F4
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x0025855C File Offset: 0x0025675C
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x002585C2 File Offset: 0x002567C2
		public FrozenDictionary<string, string> GetParam1FrozenDict()
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x002585D0 File Offset: 0x002567D0
		public FrozenDictionary<string, string> GetParam2FrozenDict()
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x002585DE File Offset: 0x002567DE
		public FrozenDictionary<string, string> GetParam3FrozenDict()
		{
			this.EnsureParam3CacheIfNeeded();
			return this.Param3Cache;
		}

		// Token: 0x040052E4 RID: 21220
		private Table __p;

		// Token: 0x040052E5 RID: 21221
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x040052E6 RID: 21222
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x040052E7 RID: 21223
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;
	}
}
