using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB1 RID: 3249
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchSkillType : IFlatbufferObject
	{
		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x060073DF RID: 29663 RVA: 0x0023C3CC File Offset: 0x0023A5CC
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x0023C3D9 File Offset: 0x0023A5D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x0023C3E0 File Offset: 0x0023A5E0
		[NullableContext(0)]
		public static FloroRanchSkillType GetRootAsFloroRanchSkillType(ByteBuffer _bb)
		{
			return FloroRanchSkillType.GetRootAsFloroRanchSkillType(_bb, default(FloroRanchSkillType));
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x0023C3FC File Offset: 0x0023A5FC
		[NullableContext(0)]
		public static FloroRanchSkillType GetRootAsFloroRanchSkillType(ByteBuffer _bb, FloroRanchSkillType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x0023C419 File Offset: 0x0023A619
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x0023C428 File Offset: 0x0023A628
		[NullableContext(0)]
		public FloroRanchSkillType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x060073E5 RID: 29669 RVA: 0x0023C438 File Offset: 0x0023A638
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

		// Token: 0x060073E6 RID: 29670 RVA: 0x0023C474 File Offset: 0x0023A674
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x060073E7 RID: 29671 RVA: 0x0023C4D4 File Offset: 0x0023A6D4
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

		// Token: 0x060073E8 RID: 29672 RVA: 0x0023C500 File Offset: 0x0023A700
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x060073E9 RID: 29673 RVA: 0x0023C560 File Offset: 0x0023A760
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

		// Token: 0x060073EA RID: 29674 RVA: 0x0023C58C File Offset: 0x0023A78C
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x060073EB RID: 29675 RVA: 0x0023C5F0 File Offset: 0x0023A7F0
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

		// Token: 0x060073EC RID: 29676 RVA: 0x0023C61C File Offset: 0x0023A81C
		[Obsolete("已废弃，请使用Param1FrozenDict()缓存字典，遍历请使用Param1Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x0023C672 File Offset: 0x0023A872
		public readonly IEnumerable<DicStringString> Param1Iter()
		{
			FloroRanchSkillType.<Param1Iter>d__20 <Param1Iter>d__ = new FloroRanchSkillType.<Param1Iter>d__20(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x0023C688 File Offset: 0x0023A888
		[Obsolete("已废弃，请使用Param2FrozenDict()缓存字典，遍历请使用Param2Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x0023C6DE File Offset: 0x0023A8DE
		public readonly IEnumerable<DicStringString> Param2Iter()
		{
			FloroRanchSkillType.<Param2Iter>d__22 <Param2Iter>d__ = new FloroRanchSkillType.<Param2Iter>d__22(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x0023C6F4 File Offset: 0x0023A8F4
		[Obsolete("已废弃，请使用Param3FrozenDict()缓存字典，遍历请使用Param3Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x0023C74A File Offset: 0x0023A94A
		public readonly IEnumerable<DicStringString> Param3Iter()
		{
			FloroRanchSkillType.<Param3Iter>d__24 <Param3Iter>d__ = new FloroRanchSkillType.<Param3Iter>d__24(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x0023C760 File Offset: 0x0023A960
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

		// Token: 0x060073F3 RID: 29683 RVA: 0x0023C788 File Offset: 0x0023A988
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

		// Token: 0x060073F4 RID: 29684 RVA: 0x0023C7B0 File Offset: 0x0023A9B0
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

		// Token: 0x060073F5 RID: 29685 RVA: 0x0023C7D8 File Offset: 0x0023A9D8
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x0023C840 File Offset: 0x0023AA40
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x0023C8A8 File Offset: 0x0023AAA8
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x0023C90E File Offset: 0x0023AB0E
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

		// Token: 0x060073F9 RID: 29689 RVA: 0x0023C91C File Offset: 0x0023AB1C
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

		// Token: 0x060073FA RID: 29690 RVA: 0x0023C92A File Offset: 0x0023AB2A
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

		// Token: 0x04004D16 RID: 19734
		private Table __p;

		// Token: 0x04004D17 RID: 19735
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04004D18 RID: 19736
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x04004D19 RID: 19737
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;
	}
}
