using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D82 RID: 3458
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchActionType : IFlatbufferObject
	{
		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x0600780D RID: 30733 RVA: 0x002568FD File Offset: 0x00254AFD
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x0025690A File Offset: 0x00254B0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x00256914 File Offset: 0x00254B14
		[NullableContext(0)]
		public static FloroRanchActionType GetRootAsFloroRanchActionType(ByteBuffer _bb)
		{
			return FloroRanchActionType.GetRootAsFloroRanchActionType(_bb, default(FloroRanchActionType));
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x00256930 File Offset: 0x00254B30
		[NullableContext(0)]
		public static FloroRanchActionType GetRootAsFloroRanchActionType(ByteBuffer _bb, FloroRanchActionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x0025694D File Offset: 0x00254B4D
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x0025695C File Offset: 0x00254B5C
		[NullableContext(0)]
		public FloroRanchActionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06007813 RID: 30739 RVA: 0x0025696C File Offset: 0x00254B6C
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

		// Token: 0x06007814 RID: 30740 RVA: 0x002569A8 File Offset: 0x00254BA8
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06007815 RID: 30741 RVA: 0x00256A08 File Offset: 0x00254C08
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

		// Token: 0x06007816 RID: 30742 RVA: 0x00256A34 File Offset: 0x00254C34
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06007817 RID: 30743 RVA: 0x00256A94 File Offset: 0x00254C94
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

		// Token: 0x06007818 RID: 30744 RVA: 0x00256AC0 File Offset: 0x00254CC0
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06007819 RID: 30745 RVA: 0x00256B24 File Offset: 0x00254D24
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

		// Token: 0x0600781A RID: 30746 RVA: 0x00256B50 File Offset: 0x00254D50
		public DicStringString? Param4(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x0600781B RID: 30747 RVA: 0x00256BB4 File Offset: 0x00254DB4
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

		// Token: 0x0600781C RID: 30748 RVA: 0x00256BE0 File Offset: 0x00254DE0
		public DicStringString? Param5(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x0600781D RID: 30749 RVA: 0x00256C44 File Offset: 0x00254E44
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

		// Token: 0x0600781E RID: 30750 RVA: 0x00256C70 File Offset: 0x00254E70
		public DicStringString? Param6(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x0600781F RID: 30751 RVA: 0x00256CD4 File Offset: 0x00254ED4
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

		// Token: 0x06007820 RID: 30752 RVA: 0x00256D00 File Offset: 0x00254F00
		public DicStringString? Param7(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06007821 RID: 30753 RVA: 0x00256D64 File Offset: 0x00254F64
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

		// Token: 0x06007822 RID: 30754 RVA: 0x00256D90 File Offset: 0x00254F90
		public Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x00256DE6 File Offset: 0x00254FE6
		public IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchActionType.<Param1Iter>d__32 <Param1Iter>d__ = new FloroRanchActionType.<Param1Iter>d__32(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00256DFC File Offset: 0x00254FFC
		public Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x00256E52 File Offset: 0x00255052
		public IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchActionType.<Param2Iter>d__34 <Param2Iter>d__ = new FloroRanchActionType.<Param2Iter>d__34(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x00256E68 File Offset: 0x00255068
		public Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x00256EBE File Offset: 0x002550BE
		public IEnumerable<DicStringString> Param3Iter()
		{
			FloroRanchActionType.<Param3Iter>d__36 <Param3Iter>d__ = new FloroRanchActionType.<Param3Iter>d__36(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00256ED4 File Offset: 0x002550D4
		public Dictionary<string, string> Param4()
		{
			return this.Param4Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00256F2A File Offset: 0x0025512A
		public IEnumerable<DicStringString> Param4Iter()
		{
			FloroRanchActionType.<Param4Iter>d__38 <Param4Iter>d__ = new FloroRanchActionType.<Param4Iter>d__38(-2);
			<Param4Iter>d__.<>3__<>4__this = this;
			return <Param4Iter>d__;
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00256F40 File Offset: 0x00255140
		public Dictionary<string, string> Param5()
		{
			return this.Param5Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00256F96 File Offset: 0x00255196
		public IEnumerable<DicStringString> Param5Iter()
		{
			FloroRanchActionType.<Param5Iter>d__40 <Param5Iter>d__ = new FloroRanchActionType.<Param5Iter>d__40(-2);
			<Param5Iter>d__.<>3__<>4__this = this;
			return <Param5Iter>d__;
		}

		// Token: 0x0600782C RID: 30764 RVA: 0x00256FAC File Offset: 0x002551AC
		public Dictionary<string, string> Param6()
		{
			return this.Param6Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00257002 File Offset: 0x00255202
		public IEnumerable<DicStringString> Param6Iter()
		{
			FloroRanchActionType.<Param6Iter>d__42 <Param6Iter>d__ = new FloroRanchActionType.<Param6Iter>d__42(-2);
			<Param6Iter>d__.<>3__<>4__this = this;
			return <Param6Iter>d__;
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x00257018 File Offset: 0x00255218
		public Dictionary<string, string> Param7()
		{
			return this.Param7Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x0025706E File Offset: 0x0025526E
		public IEnumerable<DicStringString> Param7Iter()
		{
			FloroRanchActionType.<Param7Iter>d__44 <Param7Iter>d__ = new FloroRanchActionType.<Param7Iter>d__44(-2);
			<Param7Iter>d__.<>3__<>4__this = this;
			return <Param7Iter>d__;
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00257084 File Offset: 0x00255284
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

		// Token: 0x06007831 RID: 30769 RVA: 0x002570AC File Offset: 0x002552AC
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

		// Token: 0x06007832 RID: 30770 RVA: 0x002570D4 File Offset: 0x002552D4
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

		// Token: 0x06007833 RID: 30771 RVA: 0x002570FC File Offset: 0x002552FC
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

		// Token: 0x06007834 RID: 30772 RVA: 0x00257124 File Offset: 0x00255324
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

		// Token: 0x06007835 RID: 30773 RVA: 0x0025714C File Offset: 0x0025534C
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

		// Token: 0x06007836 RID: 30774 RVA: 0x00257174 File Offset: 0x00255374
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

		// Token: 0x06007837 RID: 30775 RVA: 0x0025719C File Offset: 0x0025539C
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x00257204 File Offset: 0x00255404
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x0025726C File Offset: 0x0025546C
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x002572D4 File Offset: 0x002554D4
		private void EnsureParam4CacheIfNeeded()
		{
			if (this.Param4Cache != null)
			{
				return;
			}
			this.Param4Cache = this.Param4Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x0025733C File Offset: 0x0025553C
		private void EnsureParam5CacheIfNeeded()
		{
			if (this.Param5Cache != null)
			{
				return;
			}
			this.Param5Cache = this.Param5Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x002573A4 File Offset: 0x002555A4
		private void EnsureParam6CacheIfNeeded()
		{
			if (this.Param6Cache != null)
			{
				return;
			}
			this.Param6Cache = this.Param6Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x0025740C File Offset: 0x0025560C
		private void EnsureParam7CacheIfNeeded()
		{
			if (this.Param7Cache != null)
			{
				return;
			}
			this.Param7Cache = this.Param7Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00257472 File Offset: 0x00255672
		public FrozenDictionary<string, string> GetParam1FrozenDict()
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00257480 File Offset: 0x00255680
		public FrozenDictionary<string, string> GetParam2FrozenDict()
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x0025748E File Offset: 0x0025568E
		public FrozenDictionary<string, string> GetParam3FrozenDict()
		{
			this.EnsureParam3CacheIfNeeded();
			return this.Param3Cache;
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x0025749C File Offset: 0x0025569C
		public FrozenDictionary<string, string> GetParam4FrozenDict()
		{
			this.EnsureParam4CacheIfNeeded();
			return this.Param4Cache;
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x002574AA File Offset: 0x002556AA
		public FrozenDictionary<string, string> GetParam5FrozenDict()
		{
			this.EnsureParam5CacheIfNeeded();
			return this.Param5Cache;
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x002574B8 File Offset: 0x002556B8
		public FrozenDictionary<string, string> GetParam6FrozenDict()
		{
			this.EnsureParam6CacheIfNeeded();
			return this.Param6Cache;
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x002574C6 File Offset: 0x002556C6
		public FrozenDictionary<string, string> GetParam7FrozenDict()
		{
			this.EnsureParam7CacheIfNeeded();
			return this.Param7Cache;
		}

		// Token: 0x040052D9 RID: 21209
		private Table __p;

		// Token: 0x040052DA RID: 21210
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x040052DB RID: 21211
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x040052DC RID: 21212
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;

		// Token: 0x040052DD RID: 21213
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param4Cache;

		// Token: 0x040052DE RID: 21214
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param5Cache;

		// Token: 0x040052DF RID: 21215
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param6Cache;

		// Token: 0x040052E0 RID: 21216
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param7Cache;
	}
}
