using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200101F RID: 4127
	public struct RogueSeason : IFlatbufferObject
	{
		// Token: 0x1700310B RID: 12555
		// (get) Token: 0x0600C4C4 RID: 50372 RVA: 0x002F1870 File Offset: 0x002EFA70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x002F187D File Offset: 0x002EFA7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x002F1884 File Offset: 0x002EFA84
		public static RogueSeason GetRootAsRogueSeason(ByteBuffer _bb)
		{
			return RogueSeason.GetRootAsRogueSeason(_bb, default(RogueSeason));
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x002F18A0 File Offset: 0x002EFAA0
		public static RogueSeason GetRootAsRogueSeason(ByteBuffer _bb, RogueSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x002F18BD File Offset: 0x002EFABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x002F18CC File Offset: 0x002EFACC
		public RogueSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700310C RID: 12556
		// (get) Token: 0x0600C4CA RID: 50378 RVA: 0x002F18DC File Offset: 0x002EFADC
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

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0600C4CB RID: 50379 RVA: 0x002F1918 File Offset: 0x002EFB18
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x0600C4CC RID: 50380 RVA: 0x002F1954 File Offset: 0x002EFB54
		public string SeasonName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x002F198B File Offset: 0x002EFB8B
		public Span<byte> GetSeasonNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C4CE RID: 50382 RVA: 0x002F199A File Offset: 0x002EFB9A
		public byte[] GetSeasonNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x0600C4CF RID: 50383 RVA: 0x002F19B4 File Offset: 0x002EFBB4
		public int PointItem
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x0600C4D0 RID: 50384 RVA: 0x002F19F4 File Offset: 0x002EFBF4
		public int InstanceDungeonEntrance
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x002F1A34 File Offset: 0x002EFC34
		public DicIntIntArray? InstanceDungeonList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x0600C4D2 RID: 50386 RVA: 0x002F1A98 File Offset: 0x002EFC98
		public int InstanceDungeonListLength
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

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x002F1AC4 File Offset: 0x002EFCC4
		public DicIntString? InstanceDungeonTypeName(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x0600C4D4 RID: 50388 RVA: 0x002F1B28 File Offset: 0x002EFD28
		public int InstanceDungeonTypeNameLength
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

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x0600C4D5 RID: 50389 RVA: 0x002F1B54 File Offset: 0x002EFD54
		public int ChallengeInstanceId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x0600C4D6 RID: 50390 RVA: 0x002F1B94 File Offset: 0x002EFD94
		public int SaveDataMaxNum
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0600C4D7 RID: 50391 RVA: 0x002F1BD4 File Offset: 0x002EFDD4
		public string TabIcon
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C4D8 RID: 50392 RVA: 0x002F1C0C File Offset: 0x002EFE0C
		public Span<byte> GetTabIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C4D9 RID: 50393 RVA: 0x002F1C1C File Offset: 0x002EFE1C
		public byte[] GetTabIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0600C4DA RID: 50394 RVA: 0x002F1C34 File Offset: 0x002EFE34
		public int ShopId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x0600C4DB RID: 50395 RVA: 0x002F1C74 File Offset: 0x002EFE74
		public int Achievement
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0600C4DC RID: 50396 RVA: 0x002F1CB4 File Offset: 0x002EFEB4
		public int ParamId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0600C4DD RID: 50397 RVA: 0x002F1CF4 File Offset: 0x002EFEF4
		public string RogueThemeType
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C4DE RID: 50398 RVA: 0x002F1D2C File Offset: 0x002EFF2C
		public Span<byte> GetRogueThemeTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600C4DF RID: 50399 RVA: 0x002F1D3C File Offset: 0x002EFF3C
		public byte[] GetRogueThemeTypeArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C4E0 RID: 50400 RVA: 0x002F1D54 File Offset: 0x002EFF54
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InstanceDungeonListFrozenDict()缓存字典，遍历请使用InstanceDungeonListIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> InstanceDungeonList()
		{
			return this.InstanceDungeonListIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600C4E1 RID: 50401 RVA: 0x002F1DAA File Offset: 0x002EFFAA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> InstanceDungeonListIter()
		{
			RogueSeason.<InstanceDungeonListIter>d__45 <InstanceDungeonListIter>d__ = new RogueSeason.<InstanceDungeonListIter>d__45(-2);
			<InstanceDungeonListIter>d__.<>3__<>4__this = this;
			return <InstanceDungeonListIter>d__;
		}

		// Token: 0x0600C4E2 RID: 50402 RVA: 0x002F1DC0 File Offset: 0x002EFFC0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用InstanceDungeonTypeNameFrozenDict()缓存字典，遍历请使用InstanceDungeonTypeNameIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> InstanceDungeonTypeName()
		{
			return this.InstanceDungeonTypeNameIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C4E3 RID: 50403 RVA: 0x002F1E16 File Offset: 0x002F0016
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> InstanceDungeonTypeNameIter()
		{
			RogueSeason.<InstanceDungeonTypeNameIter>d__47 <InstanceDungeonTypeNameIter>d__ = new RogueSeason.<InstanceDungeonTypeNameIter>d__47(-2);
			<InstanceDungeonTypeNameIter>d__.<>3__<>4__this = this;
			return <InstanceDungeonTypeNameIter>d__;
		}

		// Token: 0x0600C4E4 RID: 50404 RVA: 0x002F1E2C File Offset: 0x002F002C
		public IntArray? GetInstanceDungeonList(int key)
		{
			this.EnsureInstanceDungeonListCacheIfNeeded();
			IntArray value;
			if (!this.InstanceDungeonListCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600C4E5 RID: 50405 RVA: 0x002F1E60 File Offset: 0x002F0060
		[NullableContext(2)]
		public string GetInstanceDungeonTypeName(int key)
		{
			this.EnsureInstanceDungeonTypeNameCacheIfNeeded();
			string result;
			if (!this.InstanceDungeonTypeNameCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600C4E6 RID: 50406 RVA: 0x002F1E88 File Offset: 0x002F0088
		private void EnsureInstanceDungeonListCacheIfNeeded()
		{
			if (this.InstanceDungeonListCache != null)
			{
				return;
			}
			this.InstanceDungeonListCache = this.InstanceDungeonListIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600C4E7 RID: 50407 RVA: 0x002F1EF0 File Offset: 0x002F00F0
		private void EnsureInstanceDungeonTypeNameCacheIfNeeded()
		{
			if (this.InstanceDungeonTypeNameCache != null)
			{
				return;
			}
			this.InstanceDungeonTypeNameCache = this.InstanceDungeonTypeNameIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C4E8 RID: 50408 RVA: 0x002F1F56 File Offset: 0x002F0156
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetInstanceDungeonListFrozenDict(int key)
		{
			this.EnsureInstanceDungeonListCacheIfNeeded();
			return this.InstanceDungeonListCache;
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x002F1F64 File Offset: 0x002F0164
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetInstanceDungeonTypeNameFrozenDict(int key)
		{
			this.EnsureInstanceDungeonTypeNameCacheIfNeeded();
			return this.InstanceDungeonTypeNameCache;
		}

		// Token: 0x0400510F RID: 20751
		private Table __p;

		// Token: 0x04005110 RID: 20752
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> InstanceDungeonListCache;

		// Token: 0x04005111 RID: 20753
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> InstanceDungeonTypeNameCache;
	}
}
