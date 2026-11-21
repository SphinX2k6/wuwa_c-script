using System;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000910 RID: 2320
	[EventSource(Guid = "49592C0F-5A05-516D-AA4B-A64E02026C89", Name = "System.Runtime")]
	[GeneratedCode("System.Private.CoreLib.Generators", "42.42.42.42")]
	internal sealed class RuntimeEventSource : EventSource
	{
		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06008D41 RID: 36161 RVA: 0x0015C154 File Offset: 0x0015A354
		internal static RuntimeEventSource Log { get; } = new RuntimeEventSource();

		// Token: 0x06008D42 RID: 36162 RVA: 0x000C2E1D File Offset: 0x000C101D
		private RuntimeEventSource(int _)
		{
		}

		// Token: 0x06008D43 RID: 36163 RVA: 0x0015C15B File Offset: 0x0015A35B
		[Event(1, Level = EventLevel.Informational, Keywords = (EventKeywords)1L)]
		internal void LogAppContextSwitch(string switchName, int value)
		{
			base.WriteEvent(1, switchName, value);
		}

		// Token: 0x06008D44 RID: 36164 RVA: 0x0015C166 File Offset: 0x0015A366
		[Event(2, Level = EventLevel.Informational, Keywords = (EventKeywords)2L)]
		internal void ProcessorCount(int processorCount)
		{
			base.WriteEvent(2, processorCount);
		}

		// Token: 0x06008D45 RID: 36165 RVA: 0x0015C170 File Offset: 0x0015A370
		protected override void OnEventCommand(EventCommandEventArgs command)
		{
			if (command.Command == EventCommand.Enable)
			{
				if (this._cpuTimeCounter == null)
				{
					string name = "cpu-usage";
					Func<double> metricProvider;
					if ((metricProvider = RuntimeEventSource.<>O.<0>__GetCpuUsage) == null)
					{
						metricProvider = (RuntimeEventSource.<>O.<0>__GetCpuUsage = new Func<double>(RuntimeEventSourceHelper.GetCpuUsage));
					}
					this._cpuTimeCounter = new PollingCounter(name, this, metricProvider)
					{
						DisplayName = "CPU Usage",
						DisplayUnits = "%"
					};
				}
				if (this._workingSetCounter == null)
				{
					this._workingSetCounter = new PollingCounter("working-set", this, () => (double)Environment.WorkingSet / 1000000.0)
					{
						DisplayName = "Working Set",
						DisplayUnits = "MB"
					};
				}
				if (this._gcHeapSizeCounter == null)
				{
					this._gcHeapSizeCounter = new PollingCounter("gc-heap-size", this, () => (double)GC.GetTotalMemory(false) / 1000000.0)
					{
						DisplayName = "GC Heap Size",
						DisplayUnits = "MB"
					};
				}
				if (this._gen0GCCounter == null)
				{
					this._gen0GCCounter = new IncrementingPollingCounter("gen-0-gc-count", this, () => (double)GC.CollectionCount(0))
					{
						DisplayName = "Gen 0 GC Count",
						DisplayRateTimeScale = new TimeSpan(0, 1, 0)
					};
				}
				if (this._gen1GCCounter == null)
				{
					this._gen1GCCounter = new IncrementingPollingCounter("gen-1-gc-count", this, () => (double)GC.CollectionCount(1))
					{
						DisplayName = "Gen 1 GC Count",
						DisplayRateTimeScale = new TimeSpan(0, 1, 0)
					};
				}
				if (this._gen2GCCounter == null)
				{
					this._gen2GCCounter = new IncrementingPollingCounter("gen-2-gc-count", this, () => (double)GC.CollectionCount(2))
					{
						DisplayName = "Gen 2 GC Count",
						DisplayRateTimeScale = new TimeSpan(0, 1, 0)
					};
				}
				if (this._gen0BudgetCounter == null)
				{
					this._gen0BudgetCounter = new PollingCounter("gen-0-gc-budget", this, () => (double)(-1L / 1000000L))
					{
						DisplayName = "Gen 0 GC Budget",
						DisplayUnits = "MB"
					};
				}
				if (this._threadPoolThreadCounter == null)
				{
					this._threadPoolThreadCounter = new PollingCounter("threadpool-thread-count", this, () => (double)ThreadPool.ThreadCount)
					{
						DisplayName = "ThreadPool Thread Count"
					};
				}
				if (this._monitorContentionCounter == null)
				{
					this._monitorContentionCounter = new IncrementingPollingCounter("monitor-lock-contention-count", this, () => (double)Monitor.LockContentionCount)
					{
						DisplayName = "Monitor Lock Contention Count",
						DisplayRateTimeScale = new TimeSpan(0, 0, 1)
					};
				}
				if (this._threadPoolQueueCounter == null)
				{
					this._threadPoolQueueCounter = new PollingCounter("threadpool-queue-length", this, () => (double)ThreadPool.PendingWorkItemCount)
					{
						DisplayName = "ThreadPool Queue Length"
					};
				}
				if (this._completedItemsCounter == null)
				{
					this._completedItemsCounter = new IncrementingPollingCounter("threadpool-completed-items-count", this, () => (double)ThreadPool.CompletedWorkItemCount)
					{
						DisplayName = "ThreadPool Completed Work Item Count",
						DisplayRateTimeScale = new TimeSpan(0, 0, 1)
					};
				}
				if (this._allocRateCounter == null)
				{
					this._allocRateCounter = new IncrementingPollingCounter("alloc-rate", this, () => (double)GC.GetTotalAllocatedBytes(false))
					{
						DisplayName = "Allocation Rate",
						DisplayUnits = "B",
						DisplayRateTimeScale = new TimeSpan(0, 0, 1)
					};
				}
				if (this._timerCounter == null)
				{
					this._timerCounter = new PollingCounter("active-timer-count", this, () => (double)Timer.ActiveCount)
					{
						DisplayName = "Number of Active Timers"
					};
				}
				if (this._fragmentationCounter == null)
				{
					this._fragmentationCounter = new PollingCounter("gc-fragmentation", this, delegate()
					{
						GCMemoryInfo gcmemoryInfo = GC.GetGCMemoryInfo();
						if (gcmemoryInfo.HeapSizeBytes == 0L)
						{
							return 0.0;
						}
						return (double)gcmemoryInfo.FragmentedBytes * 100.0 / (double)gcmemoryInfo.HeapSizeBytes;
					})
					{
						DisplayName = "GC Fragmentation",
						DisplayUnits = "%"
					};
				}
				if (this._committedCounter == null)
				{
					this._committedCounter = new PollingCounter("gc-committed", this, () => (double)GC.GetGCMemoryInfo().TotalCommittedBytes / 1000000.0)
					{
						DisplayName = "GC Committed Bytes",
						DisplayUnits = "MB"
					};
				}
				if (this._exceptionCounter == null)
				{
					this._exceptionCounter = new IncrementingPollingCounter("exception-count", this, () => Exception.GetExceptionCount())
					{
						DisplayName = "Exception Count",
						DisplayRateTimeScale = new TimeSpan(0, 0, 1)
					};
				}
				if (this._gcTimeCounter == null)
				{
					this._gcTimeCounter = new PollingCounter("time-in-gc", this, () => (double)GC.GetLastGCPercentTimeInGC())
					{
						DisplayName = "% Time in GC since last GC",
						DisplayUnits = "%"
					};
				}
				if (this._totalGcPauseTimeCounter == null)
				{
					this._totalGcPauseTimeCounter = new IncrementingPollingCounter("total-pause-time-by-gc", this, () => GC.GetTotalPauseDuration().TotalMilliseconds)
					{
						DisplayName = "Time paused by GC",
						DisplayUnits = "ms"
					};
				}
				if (this._gen0SizeCounter == null)
				{
					this._gen0SizeCounter = new PollingCounter("gen-0-size", this, () => GC.GetGenerationSize(0))
					{
						DisplayName = "Gen 0 Size",
						DisplayUnits = "B"
					};
				}
				if (this._gen1SizeCounter == null)
				{
					this._gen1SizeCounter = new PollingCounter("gen-1-size", this, () => GC.GetGenerationSize(1))
					{
						DisplayName = "Gen 1 Size",
						DisplayUnits = "B"
					};
				}
				if (this._gen2SizeCounter == null)
				{
					this._gen2SizeCounter = new PollingCounter("gen-2-size", this, () => GC.GetGenerationSize(2))
					{
						DisplayName = "Gen 2 Size",
						DisplayUnits = "B"
					};
				}
				if (this._lohSizeCounter == null)
				{
					this._lohSizeCounter = new PollingCounter("loh-size", this, () => GC.GetGenerationSize(3))
					{
						DisplayName = "LOH Size",
						DisplayUnits = "B"
					};
				}
				if (this._pohSizeCounter == null)
				{
					this._pohSizeCounter = new PollingCounter("poh-size", this, () => GC.GetGenerationSize(4))
					{
						DisplayName = "POH (Pinned Object Heap) Size",
						DisplayUnits = "B"
					};
				}
				if (this._assemblyCounter == null)
				{
					this._assemblyCounter = new PollingCounter("assembly-count", this, () => Assembly.GetAssemblyCount())
					{
						DisplayName = "Number of Assemblies Loaded"
					};
				}
				if (this._ilBytesJittedCounter == null)
				{
					this._ilBytesJittedCounter = new PollingCounter("il-bytes-jitted", this, () => (double)JitInfo.GetCompiledILBytes(false))
					{
						DisplayName = "IL Bytes Jitted",
						DisplayUnits = "B"
					};
				}
				if (this._methodsJittedCounter == null)
				{
					this._methodsJittedCounter = new PollingCounter("methods-jitted-count", this, () => (double)JitInfo.GetCompiledMethodCount(false))
					{
						DisplayName = "Number of Methods Jitted"
					};
				}
				if (this._jitTimeCounter == null)
				{
					this._jitTimeCounter = new IncrementingPollingCounter("time-in-jit", this, () => JitInfo.GetCompilationTime(false).TotalMilliseconds)
					{
						DisplayName = "Time spent in JIT",
						DisplayUnits = "ms",
						DisplayRateTimeScale = new TimeSpan(0, 0, 1)
					};
				}
				AppContext.LogSwitchValues(this);
				this.ProcessorCount(Environment.ProcessorCount);
			}
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x0015C9C8 File Offset: 0x0015ABC8
		private RuntimeEventSource() : base(new Guid(1230580751, 23045, 20845, 170, 75, 166, 78, 2, 2, 108, 137), "System.Runtime")
		{
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06008D47 RID: 36167 RVA: 0x0015CA0B File Offset: 0x0015AC0B
		private protected unsafe override ReadOnlySpan<byte> ProviderMetadata
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.5F3CB907C5006375EA5E7C8BBB37E62D3058462AD304ACE0722447D783CCD9B6), 17);
			}
		}

		// Token: 0x0400206A RID: 8298
		internal static readonly Guid EventSourceGuid = new Guid("49592C0F-5A05-516D-AA4B-A64E02026C89");

		// Token: 0x0400206B RID: 8299
		internal const string EventSourceName = "System.Runtime";

		// Token: 0x0400206D RID: 8301
		private PollingCounter _gcHeapSizeCounter;

		// Token: 0x0400206E RID: 8302
		private IncrementingPollingCounter _gen0GCCounter;

		// Token: 0x0400206F RID: 8303
		private IncrementingPollingCounter _gen1GCCounter;

		// Token: 0x04002070 RID: 8304
		private IncrementingPollingCounter _gen2GCCounter;

		// Token: 0x04002071 RID: 8305
		private PollingCounter _gen0BudgetCounter;

		// Token: 0x04002072 RID: 8306
		private PollingCounter _cpuTimeCounter;

		// Token: 0x04002073 RID: 8307
		private PollingCounter _workingSetCounter;

		// Token: 0x04002074 RID: 8308
		private PollingCounter _threadPoolThreadCounter;

		// Token: 0x04002075 RID: 8309
		private IncrementingPollingCounter _monitorContentionCounter;

		// Token: 0x04002076 RID: 8310
		private PollingCounter _threadPoolQueueCounter;

		// Token: 0x04002077 RID: 8311
		private IncrementingPollingCounter _completedItemsCounter;

		// Token: 0x04002078 RID: 8312
		private IncrementingPollingCounter _allocRateCounter;

		// Token: 0x04002079 RID: 8313
		private PollingCounter _timerCounter;

		// Token: 0x0400207A RID: 8314
		private PollingCounter _fragmentationCounter;

		// Token: 0x0400207B RID: 8315
		private PollingCounter _committedCounter;

		// Token: 0x0400207C RID: 8316
		private IncrementingPollingCounter _exceptionCounter;

		// Token: 0x0400207D RID: 8317
		private PollingCounter _gcTimeCounter;

		// Token: 0x0400207E RID: 8318
		private IncrementingPollingCounter _totalGcPauseTimeCounter;

		// Token: 0x0400207F RID: 8319
		private PollingCounter _gen0SizeCounter;

		// Token: 0x04002080 RID: 8320
		private PollingCounter _gen1SizeCounter;

		// Token: 0x04002081 RID: 8321
		private PollingCounter _gen2SizeCounter;

		// Token: 0x04002082 RID: 8322
		private PollingCounter _lohSizeCounter;

		// Token: 0x04002083 RID: 8323
		private PollingCounter _pohSizeCounter;

		// Token: 0x04002084 RID: 8324
		private PollingCounter _assemblyCounter;

		// Token: 0x04002085 RID: 8325
		private PollingCounter _ilBytesJittedCounter;

		// Token: 0x04002086 RID: 8326
		private PollingCounter _methodsJittedCounter;

		// Token: 0x04002087 RID: 8327
		private IncrementingPollingCounter _jitTimeCounter;

		// Token: 0x02000911 RID: 2321
		public static class Keywords
		{
			// Token: 0x04002088 RID: 8328
			public const EventKeywords AppContext = (EventKeywords)1L;

			// Token: 0x04002089 RID: 8329
			public const EventKeywords ProcessorCount = (EventKeywords)2L;
		}

		// Token: 0x02000912 RID: 2322
		private enum EventId
		{
			// Token: 0x0400208B RID: 8331
			AppContextSwitch = 1,
			// Token: 0x0400208C RID: 8332
			ProcessorCount
		}

		// Token: 0x02000913 RID: 2323
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400208D RID: 8333
			public static Func<double> <0>__GetCpuUsage;
		}
	}
}
