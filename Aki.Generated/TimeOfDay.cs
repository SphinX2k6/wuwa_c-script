using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112C RID: 4396
	public struct TimeOfDay : IFlatbufferObject
	{
		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x0600DEB2 RID: 57010 RVA: 0x0032D7E1 File Offset: 0x0032B9E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x0032D7EE File Offset: 0x0032B9EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DEB4 RID: 57012 RVA: 0x0032D7F8 File Offset: 0x0032B9F8
		public static TimeOfDay GetRootAsTimeOfDay(ByteBuffer _bb)
		{
			return TimeOfDay.GetRootAsTimeOfDay(_bb, default(TimeOfDay));
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x0032D814 File Offset: 0x0032BA14
		public static TimeOfDay GetRootAsTimeOfDay(ByteBuffer _bb, TimeOfDay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x0032D831 File Offset: 0x0032BA31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x0032D840 File Offset: 0x0032BA40
		public TimeOfDay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x0600DEB8 RID: 57016 RVA: 0x0032D850 File Offset: 0x0032BA50
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

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x0600DEB9 RID: 57017 RVA: 0x0032D88C File Offset: 0x0032BA8C
		public int InitTime
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

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x0600DEBA RID: 57018 RVA: 0x0032D8C8 File Offset: 0x0032BAC8
		public int Rate
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DEBB RID: 57019 RVA: 0x0032D904 File Offset: 0x0032BB04
		public DicIntInt? StateSpan(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x0600DEBC RID: 57020 RVA: 0x0032D968 File Offset: 0x0032BB68
		public int StateSpanLength
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

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x0600DEBD RID: 57021 RVA: 0x0032D994 File Offset: 0x0032BB94
		public int A
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

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0600DEBE RID: 57022 RVA: 0x0032D9D4 File Offset: 0x0032BBD4
		public int V
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DEBF RID: 57023 RVA: 0x0032DA14 File Offset: 0x0032BC14
		public string BanTag(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x0600DEC0 RID: 57024 RVA: 0x0032DA50 File Offset: 0x0032BC50
		public int BanTagLength
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

		// Token: 0x0600DEC1 RID: 57025 RVA: 0x0032DA7C File Offset: 0x0032BC7C
		public DicIntString? TimePreset(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x0600DEC2 RID: 57026 RVA: 0x0032DAE0 File Offset: 0x0032BCE0
		public int TimePresetLength
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

		// Token: 0x0600DEC3 RID: 57027 RVA: 0x0032DB0C File Offset: 0x0032BD0C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BanTagIter()或GetBanTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] BanTag()
		{
			return this.BanTagIter().ToArray<string>();
		}

		// Token: 0x0600DEC4 RID: 57028 RVA: 0x0032DB19 File Offset: 0x0032BD19
		[NullableContext(1)]
		public readonly IEnumerable<string> BanTagIter()
		{
			TimeOfDay.<BanTagIter>d__28 <BanTagIter>d__ = new TimeOfDay.<BanTagIter>d__28(-2);
			<BanTagIter>d__.<>3__<>4__this = this;
			return <BanTagIter>d__;
		}

		// Token: 0x0600DEC5 RID: 57029 RVA: 0x0032DB30 File Offset: 0x0032BD30
		[NullableContext(1)]
		[Obsolete("已废弃，请使用StateSpanFrozenDict()缓存字典，遍历请使用StateSpanIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> StateSpan()
		{
			return this.StateSpanIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DEC6 RID: 57030 RVA: 0x0032DB86 File Offset: 0x0032BD86
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> StateSpanIter()
		{
			TimeOfDay.<StateSpanIter>d__30 <StateSpanIter>d__ = new TimeOfDay.<StateSpanIter>d__30(-2);
			<StateSpanIter>d__.<>3__<>4__this = this;
			return <StateSpanIter>d__;
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x0032DB9C File Offset: 0x0032BD9C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TimePresetFrozenDict()缓存字典，遍历请使用TimePresetIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TimePreset()
		{
			return this.TimePresetIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x0032DBF2 File Offset: 0x0032BDF2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TimePresetIter()
		{
			TimeOfDay.<TimePresetIter>d__32 <TimePresetIter>d__ = new TimeOfDay.<TimePresetIter>d__32(-2);
			<TimePresetIter>d__.<>3__<>4__this = this;
			return <TimePresetIter>d__;
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x0032DC08 File Offset: 0x0032BE08
		public int? GetStateSpan(int key)
		{
			this.EnsureStateSpanCacheIfNeeded();
			int value;
			if (!this.StateSpanCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x0032DC3C File Offset: 0x0032BE3C
		[NullableContext(2)]
		public string GetTimePreset(int key)
		{
			this.EnsureTimePresetCacheIfNeeded();
			string result;
			if (!this.TimePresetCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x0032DC64 File Offset: 0x0032BE64
		private void EnsureStateSpanCacheIfNeeded()
		{
			if (this.StateSpanCache != null)
			{
				return;
			}
			this.StateSpanCache = this.StateSpanIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x0032DCCC File Offset: 0x0032BECC
		private void EnsureTimePresetCacheIfNeeded()
		{
			if (this.TimePresetCache != null)
			{
				return;
			}
			this.TimePresetCache = this.TimePresetIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600DECD RID: 57037 RVA: 0x0032DD32 File Offset: 0x0032BF32
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetStateSpanFrozenDict(int key)
		{
			this.EnsureStateSpanCacheIfNeeded();
			return this.StateSpanCache;
		}

		// Token: 0x0600DECE RID: 57038 RVA: 0x0032DD40 File Offset: 0x0032BF40
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTimePresetFrozenDict(int key)
		{
			this.EnsureTimePresetCacheIfNeeded();
			return this.TimePresetCache;
		}

		// Token: 0x0400526A RID: 21098
		private Table __p;

		// Token: 0x0400526B RID: 21099
		[Nullable(2)]
		private FrozenDictionary<int, int> StateSpanCache;

		// Token: 0x0400526C RID: 21100
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TimePresetCache;
	}
}
