using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001262 RID: 4706
	public struct TimeOfDay : IFlatbufferObject
	{
		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x0600EC20 RID: 60448 RVA: 0x00358DB5 File Offset: 0x00356FB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EC21 RID: 60449 RVA: 0x00358DC2 File Offset: 0x00356FC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EC22 RID: 60450 RVA: 0x00358DCC File Offset: 0x00356FCC
		public static TimeOfDay GetRootAsTimeOfDay(ByteBuffer _bb)
		{
			return TimeOfDay.GetRootAsTimeOfDay(_bb, default(TimeOfDay));
		}

		// Token: 0x0600EC23 RID: 60451 RVA: 0x00358DE8 File Offset: 0x00356FE8
		public static TimeOfDay GetRootAsTimeOfDay(ByteBuffer _bb, TimeOfDay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EC24 RID: 60452 RVA: 0x00358E05 File Offset: 0x00357005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EC25 RID: 60453 RVA: 0x00358E14 File Offset: 0x00357014
		public TimeOfDay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x0600EC26 RID: 60454 RVA: 0x00358E24 File Offset: 0x00357024
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

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x0600EC27 RID: 60455 RVA: 0x00358E60 File Offset: 0x00357060
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

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x0600EC28 RID: 60456 RVA: 0x00358E9C File Offset: 0x0035709C
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

		// Token: 0x0600EC29 RID: 60457 RVA: 0x00358ED8 File Offset: 0x003570D8
		public DicIntInt? StateSpan(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x0600EC2A RID: 60458 RVA: 0x00358F3C File Offset: 0x0035713C
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

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x0600EC2B RID: 60459 RVA: 0x00358F68 File Offset: 0x00357168
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

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x0600EC2C RID: 60460 RVA: 0x00358FA8 File Offset: 0x003571A8
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

		// Token: 0x0600EC2D RID: 60461 RVA: 0x00358FE8 File Offset: 0x003571E8
		public string BanTag(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x0600EC2E RID: 60462 RVA: 0x00359024 File Offset: 0x00357224
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

		// Token: 0x0600EC2F RID: 60463 RVA: 0x00359050 File Offset: 0x00357250
		public DicIntString? TimePreset(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0600EC30 RID: 60464 RVA: 0x003590B4 File Offset: 0x003572B4
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

		// Token: 0x0600EC31 RID: 60465 RVA: 0x003590E0 File Offset: 0x003572E0
		[NullableContext(1)]
		public string[] BanTag()
		{
			return this.BanTagIter().ToArray<string>();
		}

		// Token: 0x0600EC32 RID: 60466 RVA: 0x003590ED File Offset: 0x003572ED
		[NullableContext(1)]
		public IEnumerable<string> BanTagIter()
		{
			TimeOfDay.<BanTagIter>d__28 <BanTagIter>d__ = new TimeOfDay.<BanTagIter>d__28(-2);
			<BanTagIter>d__.<>3__<>4__this = this;
			return <BanTagIter>d__;
		}

		// Token: 0x0600EC33 RID: 60467 RVA: 0x00359104 File Offset: 0x00357304
		[NullableContext(1)]
		public Dictionary<int, int> StateSpan()
		{
			return this.StateSpanIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600EC34 RID: 60468 RVA: 0x0035915A File Offset: 0x0035735A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> StateSpanIter()
		{
			TimeOfDay.<StateSpanIter>d__30 <StateSpanIter>d__ = new TimeOfDay.<StateSpanIter>d__30(-2);
			<StateSpanIter>d__.<>3__<>4__this = this;
			return <StateSpanIter>d__;
		}

		// Token: 0x0600EC35 RID: 60469 RVA: 0x00359170 File Offset: 0x00357370
		[NullableContext(1)]
		public Dictionary<int, string> TimePreset()
		{
			return this.TimePresetIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600EC36 RID: 60470 RVA: 0x003591C6 File Offset: 0x003573C6
		[NullableContext(1)]
		public IEnumerable<DicIntString> TimePresetIter()
		{
			TimeOfDay.<TimePresetIter>d__32 <TimePresetIter>d__ = new TimeOfDay.<TimePresetIter>d__32(-2);
			<TimePresetIter>d__.<>3__<>4__this = this;
			return <TimePresetIter>d__;
		}

		// Token: 0x0600EC37 RID: 60471 RVA: 0x003591DC File Offset: 0x003573DC
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

		// Token: 0x0600EC38 RID: 60472 RVA: 0x00359210 File Offset: 0x00357410
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

		// Token: 0x0600EC39 RID: 60473 RVA: 0x00359238 File Offset: 0x00357438
		private void EnsureStateSpanCacheIfNeeded()
		{
			if (this.StateSpanCache != null)
			{
				return;
			}
			this.StateSpanCache = this.StateSpanIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600EC3A RID: 60474 RVA: 0x003592A0 File Offset: 0x003574A0
		private void EnsureTimePresetCacheIfNeeded()
		{
			if (this.TimePresetCache != null)
			{
				return;
			}
			this.TimePresetCache = this.TimePresetIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600EC3B RID: 60475 RVA: 0x00359306 File Offset: 0x00357506
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetStateSpanFrozenDict()
		{
			this.EnsureStateSpanCacheIfNeeded();
			return this.StateSpanCache;
		}

		// Token: 0x0600EC3C RID: 60476 RVA: 0x00359314 File Offset: 0x00357514
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetTimePresetFrozenDict()
		{
			this.EnsureTimePresetCacheIfNeeded();
			return this.TimePresetCache;
		}

		// Token: 0x040058AD RID: 22701
		private Table __p;

		// Token: 0x040058AE RID: 22702
		[Nullable(2)]
		private FrozenDictionary<int, int> StateSpanCache;

		// Token: 0x040058AF RID: 22703
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TimePresetCache;
	}
}
