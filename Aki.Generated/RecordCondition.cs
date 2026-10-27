using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA3 RID: 4003
	[NullableContext(1)]
	[Nullable(0)]
	public struct RecordCondition : IFlatbufferObject
	{
		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x0600BA26 RID: 47654 RVA: 0x002D9F19 File Offset: 0x002D8119
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BA27 RID: 47655 RVA: 0x002D9F26 File Offset: 0x002D8126
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BA28 RID: 47656 RVA: 0x002D9F30 File Offset: 0x002D8130
		[NullableContext(0)]
		public static RecordCondition GetRootAsRecordCondition(ByteBuffer _bb)
		{
			return RecordCondition.GetRootAsRecordCondition(_bb, default(RecordCondition));
		}

		// Token: 0x0600BA29 RID: 47657 RVA: 0x002D9F4C File Offset: 0x002D814C
		[NullableContext(0)]
		public static RecordCondition GetRootAsRecordCondition(ByteBuffer _bb, RecordCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BA2A RID: 47658 RVA: 0x002D9F69 File Offset: 0x002D8169
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BA2B RID: 47659 RVA: 0x002D9F78 File Offset: 0x002D8178
		[NullableContext(0)]
		public RecordCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x002D9F88 File Offset: 0x002D8188
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

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x0600BA2D RID: 47661 RVA: 0x002D9FC4 File Offset: 0x002D81C4
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

		// Token: 0x0600BA2E RID: 47662 RVA: 0x002D9FFB File Offset: 0x002D81FB
		[NullableContext(0)]
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BA2F RID: 47663 RVA: 0x002DA00A File Offset: 0x002D820A
		[NullableContext(0)]
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x002DA024 File Offset: 0x002D8224
		public int Nullenable(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0600BA31 RID: 47665 RVA: 0x002DA064 File Offset: 0x002D8264
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

		// Token: 0x0600BA32 RID: 47666 RVA: 0x002DA08F File Offset: 0x002D828F
		[NullableContext(0)]
		public Span<int> GetNullenableBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x002DA09E File Offset: 0x002D829E
		[NullableContext(0)]
		public int[] GetNullenableArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x002DA0B8 File Offset: 0x002D82B8
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0600BA35 RID: 47669 RVA: 0x002DA11C File Offset: 0x002D831C
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

		// Token: 0x0600BA36 RID: 47670 RVA: 0x002DA148 File Offset: 0x002D8348
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0600BA37 RID: 47671 RVA: 0x002DA1AC File Offset: 0x002D83AC
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

		// Token: 0x0600BA38 RID: 47672 RVA: 0x002DA1D8 File Offset: 0x002D83D8
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0600BA39 RID: 47673 RVA: 0x002DA23C File Offset: 0x002D843C
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

		// Token: 0x0600BA3A RID: 47674 RVA: 0x002DA268 File Offset: 0x002D8468
		public DicStringString? Param4(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x0600BA3B RID: 47675 RVA: 0x002DA2CC File Offset: 0x002D84CC
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

		// Token: 0x0600BA3C RID: 47676 RVA: 0x002DA2F8 File Offset: 0x002D84F8
		public DicStringString? Param5(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x0600BA3D RID: 47677 RVA: 0x002DA35C File Offset: 0x002D855C
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

		// Token: 0x0600BA3E RID: 47678 RVA: 0x002DA388 File Offset: 0x002D8588
		[Obsolete("本方法用于缓存,遍历请使用NullenableIter()或GetNullenableBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Nullenable()
		{
			RecordCondition recordCondition = this;
			return recordCondition.GetNullenableArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BA3F RID: 47679 RVA: 0x002DA3AC File Offset: 0x002D85AC
		public readonly IEnumerable<int> NullenableIter()
		{
			RecordCondition.<NullenableIter>d__35 <NullenableIter>d__ = new RecordCondition.<NullenableIter>d__35(-2);
			<NullenableIter>d__.<>3__<>4__this = this;
			return <NullenableIter>d__;
		}

		// Token: 0x0600BA40 RID: 47680 RVA: 0x002DA3C4 File Offset: 0x002D85C4
		[Obsolete("已废弃，请使用Param1FrozenDict()缓存字典，遍历请使用Param1Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600BA41 RID: 47681 RVA: 0x002DA41A File Offset: 0x002D861A
		public readonly IEnumerable<DicStringString> Param1Iter()
		{
			RecordCondition.<Param1Iter>d__37 <Param1Iter>d__ = new RecordCondition.<Param1Iter>d__37(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x002DA430 File Offset: 0x002D8630
		[Obsolete("已废弃，请使用Param2FrozenDict()缓存字典，遍历请使用Param2Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600BA43 RID: 47683 RVA: 0x002DA486 File Offset: 0x002D8686
		public readonly IEnumerable<DicStringString> Param2Iter()
		{
			RecordCondition.<Param2Iter>d__39 <Param2Iter>d__ = new RecordCondition.<Param2Iter>d__39(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x0600BA44 RID: 47684 RVA: 0x002DA49C File Offset: 0x002D869C
		[Obsolete("已废弃，请使用Param3FrozenDict()缓存字典，遍历请使用Param3Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600BA45 RID: 47685 RVA: 0x002DA4F2 File Offset: 0x002D86F2
		public readonly IEnumerable<DicStringString> Param3Iter()
		{
			RecordCondition.<Param3Iter>d__41 <Param3Iter>d__ = new RecordCondition.<Param3Iter>d__41(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x0600BA46 RID: 47686 RVA: 0x002DA508 File Offset: 0x002D8708
		[Obsolete("已废弃，请使用Param4FrozenDict()缓存字典，遍历请使用Param4Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param4()
		{
			return this.Param4Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600BA47 RID: 47687 RVA: 0x002DA55E File Offset: 0x002D875E
		public readonly IEnumerable<DicStringString> Param4Iter()
		{
			RecordCondition.<Param4Iter>d__43 <Param4Iter>d__ = new RecordCondition.<Param4Iter>d__43(-2);
			<Param4Iter>d__.<>3__<>4__this = this;
			return <Param4Iter>d__;
		}

		// Token: 0x0600BA48 RID: 47688 RVA: 0x002DA574 File Offset: 0x002D8774
		[Obsolete("已废弃，请使用Param5FrozenDict()缓存字典，遍历请使用Param5Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param5()
		{
			return this.Param5Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600BA49 RID: 47689 RVA: 0x002DA5CA File Offset: 0x002D87CA
		public readonly IEnumerable<DicStringString> Param5Iter()
		{
			RecordCondition.<Param5Iter>d__45 <Param5Iter>d__ = new RecordCondition.<Param5Iter>d__45(-2);
			<Param5Iter>d__.<>3__<>4__this = this;
			return <Param5Iter>d__;
		}

		// Token: 0x0600BA4A RID: 47690 RVA: 0x002DA5E0 File Offset: 0x002D87E0
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

		// Token: 0x0600BA4B RID: 47691 RVA: 0x002DA608 File Offset: 0x002D8808
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

		// Token: 0x0600BA4C RID: 47692 RVA: 0x002DA630 File Offset: 0x002D8830
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

		// Token: 0x0600BA4D RID: 47693 RVA: 0x002DA658 File Offset: 0x002D8858
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

		// Token: 0x0600BA4E RID: 47694 RVA: 0x002DA680 File Offset: 0x002D8880
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

		// Token: 0x0600BA4F RID: 47695 RVA: 0x002DA6A8 File Offset: 0x002D88A8
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x002DA710 File Offset: 0x002D8910
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600BA51 RID: 47697 RVA: 0x002DA778 File Offset: 0x002D8978
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600BA52 RID: 47698 RVA: 0x002DA7E0 File Offset: 0x002D89E0
		private void EnsureParam4CacheIfNeeded()
		{
			if (this.Param4Cache != null)
			{
				return;
			}
			this.Param4Cache = this.Param4Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600BA53 RID: 47699 RVA: 0x002DA848 File Offset: 0x002D8A48
		private void EnsureParam5CacheIfNeeded()
		{
			if (this.Param5Cache != null)
			{
				return;
			}
			this.Param5Cache = this.Param5Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600BA54 RID: 47700 RVA: 0x002DA8AE File Offset: 0x002D8AAE
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

		// Token: 0x0600BA55 RID: 47701 RVA: 0x002DA8BC File Offset: 0x002D8ABC
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

		// Token: 0x0600BA56 RID: 47702 RVA: 0x002DA8CA File Offset: 0x002D8ACA
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

		// Token: 0x0600BA57 RID: 47703 RVA: 0x002DA8D8 File Offset: 0x002D8AD8
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

		// Token: 0x0600BA58 RID: 47704 RVA: 0x002DA8E6 File Offset: 0x002D8AE6
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

		// Token: 0x04005076 RID: 20598
		private Table __p;

		// Token: 0x04005077 RID: 20599
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04005078 RID: 20600
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x04005079 RID: 20601
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;

		// Token: 0x0400507A RID: 20602
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param4Cache;

		// Token: 0x0400507B RID: 20603
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param5Cache;
	}
}
