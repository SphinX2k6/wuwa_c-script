using System;

namespace System
{
	// Token: 0x02000122 RID: 290
	public readonly struct GCMemoryInfo
	{
		// Token: 0x0600119E RID: 4510 RVA: 0x00030C42 File Offset: 0x0002EE42
		internal GCMemoryInfo(GCMemoryInfoData data)
		{
			this._data = data;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x00030C4B File Offset: 0x0002EE4B
		public long HighMemoryLoadThresholdBytes
		{
			get
			{
				return this._data._highMemoryLoadThresholdBytes;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00030C58 File Offset: 0x0002EE58
		public long MemoryLoadBytes
		{
			get
			{
				return this._data._memoryLoadBytes;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00030C65 File Offset: 0x0002EE65
		public long TotalAvailableMemoryBytes
		{
			get
			{
				return this._data._totalAvailableMemoryBytes;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00030C72 File Offset: 0x0002EE72
		public long HeapSizeBytes
		{
			get
			{
				return this._data._heapSizeBytes;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00030C7F File Offset: 0x0002EE7F
		public long FragmentedBytes
		{
			get
			{
				return this._data._fragmentedBytes;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00030C8C File Offset: 0x0002EE8C
		public long Index
		{
			get
			{
				return this._data._index;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00030C99 File Offset: 0x0002EE99
		public int Generation
		{
			get
			{
				return this._data._generation;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00030CA6 File Offset: 0x0002EEA6
		public bool Compacted
		{
			get
			{
				return this._data._compacted > 0;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00030CB6 File Offset: 0x0002EEB6
		public bool Concurrent
		{
			get
			{
				return this._data._concurrent > 0;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00030CC6 File Offset: 0x0002EEC6
		public long TotalCommittedBytes
		{
			get
			{
				return this._data._totalCommittedBytes;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00030CD3 File Offset: 0x0002EED3
		public long PromotedBytes
		{
			get
			{
				return this._data._promotedBytes;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		public long PinnedObjectsCount
		{
			get
			{
				return this._data._pinnedObjectsCount;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00030CED File Offset: 0x0002EEED
		public long FinalizationPendingCount
		{
			get
			{
				return this._data._finalizationPendingCount;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00030CFA File Offset: 0x0002EEFA
		public ReadOnlySpan<TimeSpan> PauseDurations
		{
			get
			{
				return this._data.PauseDurationsAsSpan;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00030D07 File Offset: 0x0002EF07
		public double PauseTimePercentage
		{
			get
			{
				return (double)this._data._pauseTimePercentage / 100.0;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00030D1F File Offset: 0x0002EF1F
		public ReadOnlySpan<GCGenerationInfo> GenerationInfo
		{
			get
			{
				return this._data.GenerationInfoAsSpan;
			}
		}

		// Token: 0x040003C3 RID: 963
		private readonly GCMemoryInfoData _data;
	}
}
