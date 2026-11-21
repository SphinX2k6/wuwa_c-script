using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001241 RID: 4673
	public struct SurvivorsWave : IFlatbufferObject
	{
		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x0600E937 RID: 59703 RVA: 0x003525BE File Offset: 0x003507BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E938 RID: 59704 RVA: 0x003525CB File Offset: 0x003507CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E939 RID: 59705 RVA: 0x003525D4 File Offset: 0x003507D4
		public static SurvivorsWave GetRootAsSurvivorsWave(ByteBuffer _bb)
		{
			return SurvivorsWave.GetRootAsSurvivorsWave(_bb, default(SurvivorsWave));
		}

		// Token: 0x0600E93A RID: 59706 RVA: 0x003525F0 File Offset: 0x003507F0
		public static SurvivorsWave GetRootAsSurvivorsWave(ByteBuffer _bb, SurvivorsWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E93B RID: 59707 RVA: 0x0035260D File Offset: 0x0035080D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E93C RID: 59708 RVA: 0x0035261C File Offset: 0x0035081C
		public SurvivorsWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x0600E93D RID: 59709 RVA: 0x0035262C File Offset: 0x0035082C
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

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x0600E93E RID: 59710 RVA: 0x00352668 File Offset: 0x00350868
		public int Level
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

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0600E93F RID: 59711 RVA: 0x003526A4 File Offset: 0x003508A4
		public int Wave
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

		// Token: 0x0600E940 RID: 59712 RVA: 0x003526E0 File Offset: 0x003508E0
		public int WaveConditions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0600E941 RID: 59713 RVA: 0x00352720 File Offset: 0x00350920
		public int WaveConditionsLength
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

		// Token: 0x0600E942 RID: 59714 RVA: 0x0035274C File Offset: 0x0035094C
		public Span<int> GetWaveConditionsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E943 RID: 59715 RVA: 0x0035275C File Offset: 0x0035095C
		public int[] GetWaveConditionsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x0600E944 RID: 59716 RVA: 0x00352774 File Offset: 0x00350974
		public int WaveTime
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

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x0600E945 RID: 59717 RVA: 0x003527B4 File Offset: 0x003509B4
		public int EndlessModeWaveTime
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

		// Token: 0x0600E946 RID: 59718 RVA: 0x003527F4 File Offset: 0x003509F4
		public int ConditionSpawnIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x0600E947 RID: 59719 RVA: 0x00352834 File Offset: 0x00350A34
		public int ConditionSpawnIdsLength
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

		// Token: 0x0600E948 RID: 59720 RVA: 0x00352860 File Offset: 0x00350A60
		public Span<int> GetConditionSpawnIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E949 RID: 59721 RVA: 0x00352870 File Offset: 0x00350A70
		public int[] GetConditionSpawnIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600E94A RID: 59722 RVA: 0x00352888 File Offset: 0x00350A88
		public int EndlessModeConditionSpawnIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x0600E94B RID: 59723 RVA: 0x003528C8 File Offset: 0x00350AC8
		public int EndlessModeConditionSpawnIdsLength
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

		// Token: 0x0600E94C RID: 59724 RVA: 0x003528F4 File Offset: 0x00350AF4
		public Span<int> GetEndlessModeConditionSpawnIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E94D RID: 59725 RVA: 0x00352904 File Offset: 0x00350B04
		public int[] GetEndlessModeConditionSpawnIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x0600E94E RID: 59726 RVA: 0x0035291C File Offset: 0x00350B1C
		public int WaveType
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

		// Token: 0x0600E94F RID: 59727 RVA: 0x0035295C File Offset: 0x00350B5C
		public DicStringInt? TreasurePool(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x0600E950 RID: 59728 RVA: 0x003529C0 File Offset: 0x00350BC0
		public int TreasurePoolLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E951 RID: 59729 RVA: 0x003529EC File Offset: 0x00350BEC
		[NullableContext(1)]
		public int[] ConditionSpawnIds()
		{
			return this.GetConditionSpawnIdsArray();
		}

		// Token: 0x0600E952 RID: 59730 RVA: 0x003529F4 File Offset: 0x00350BF4
		[NullableContext(1)]
		public IEnumerable<int> ConditionSpawnIdsIter()
		{
			SurvivorsWave.<ConditionSpawnIdsIter>d__39 <ConditionSpawnIdsIter>d__ = new SurvivorsWave.<ConditionSpawnIdsIter>d__39(-2);
			<ConditionSpawnIdsIter>d__.<>3__<>4__this = this;
			return <ConditionSpawnIdsIter>d__;
		}

		// Token: 0x0600E953 RID: 59731 RVA: 0x00352A09 File Offset: 0x00350C09
		[NullableContext(1)]
		public int[] EndlessModeConditionSpawnIds()
		{
			return this.GetEndlessModeConditionSpawnIdsArray();
		}

		// Token: 0x0600E954 RID: 59732 RVA: 0x00352A11 File Offset: 0x00350C11
		[NullableContext(1)]
		public IEnumerable<int> EndlessModeConditionSpawnIdsIter()
		{
			SurvivorsWave.<EndlessModeConditionSpawnIdsIter>d__41 <EndlessModeConditionSpawnIdsIter>d__ = new SurvivorsWave.<EndlessModeConditionSpawnIdsIter>d__41(-2);
			<EndlessModeConditionSpawnIdsIter>d__.<>3__<>4__this = this;
			return <EndlessModeConditionSpawnIdsIter>d__;
		}

		// Token: 0x0600E955 RID: 59733 RVA: 0x00352A28 File Offset: 0x00350C28
		[NullableContext(1)]
		public Dictionary<string, int> TreasurePool()
		{
			return this.TreasurePoolIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600E956 RID: 59734 RVA: 0x00352A7E File Offset: 0x00350C7E
		[NullableContext(1)]
		public IEnumerable<DicStringInt> TreasurePoolIter()
		{
			SurvivorsWave.<TreasurePoolIter>d__43 <TreasurePoolIter>d__ = new SurvivorsWave.<TreasurePoolIter>d__43(-2);
			<TreasurePoolIter>d__.<>3__<>4__this = this;
			return <TreasurePoolIter>d__;
		}

		// Token: 0x0600E957 RID: 59735 RVA: 0x00352A93 File Offset: 0x00350C93
		[NullableContext(1)]
		public int[] WaveConditions()
		{
			return this.GetWaveConditionsArray();
		}

		// Token: 0x0600E958 RID: 59736 RVA: 0x00352A9B File Offset: 0x00350C9B
		[NullableContext(1)]
		public IEnumerable<int> WaveConditionsIter()
		{
			SurvivorsWave.<WaveConditionsIter>d__45 <WaveConditionsIter>d__ = new SurvivorsWave.<WaveConditionsIter>d__45(-2);
			<WaveConditionsIter>d__.<>3__<>4__this = this;
			return <WaveConditionsIter>d__;
		}

		// Token: 0x0600E959 RID: 59737 RVA: 0x00352AB0 File Offset: 0x00350CB0
		[NullableContext(1)]
		public int? GetTreasurePool(string key)
		{
			this.EnsureTreasurePoolCacheIfNeeded();
			int value;
			if (!this.TreasurePoolCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600E95A RID: 59738 RVA: 0x00352AE4 File Offset: 0x00350CE4
		private void EnsureTreasurePoolCacheIfNeeded()
		{
			if (this.TreasurePoolCache != null)
			{
				return;
			}
			this.TreasurePoolCache = this.TreasurePoolIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600E95B RID: 59739 RVA: 0x00352B4A File Offset: 0x00350D4A
		[NullableContext(1)]
		public FrozenDictionary<string, int> GetTreasurePoolFrozenDict()
		{
			this.EnsureTreasurePoolCacheIfNeeded();
			return this.TreasurePoolCache;
		}

		// Token: 0x04005888 RID: 22664
		private Table __p;

		// Token: 0x04005889 RID: 22665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> TreasurePoolCache;
	}
}
