using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x0200432B RID: 17195
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PerfExceedFramework : ControllerBase
	{
		// Token: 0x0602B6BF RID: 177855 RVA: 0x00C34AD4 File Offset: 0x00C32CD4
		protected unsafe override bool OnInit()
		{
			foreach (PerfExceedSubMetric perfExceedSubMetric in Enum.GetValues<PerfExceedSubMetric>())
			{
				this.StateMachines[perfExceedSubMetric] = new PerfExceedStateMachine(perfExceedSubMetric, PerfExceedThresholds.GetThreshold(perfExceedSubMetric), 3000, 60000, 3000);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LogReport;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "PerfExceed框架初始化完成";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("sampleIntervalMs", 500);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("sessionLimit", 50);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return true;
		}

		// Token: 0x0602B6C0 RID: 177856 RVA: 0x00C34B8A File Offset: 0x00C32D8A
		protected override bool OnClear()
		{
			if (this.SampleTimer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.SampleTimer);
				this.SampleTimer = null;
			}
			return true;
		}

		// Token: 0x0602B6C1 RID: 177857 RVA: 0x00C34BB0 File Offset: 0x00C32DB0
		private void OnSampleTick(float _)
		{
		}

		// Token: 0x170056EE RID: 22254
		// (get) Token: 0x0602B6C2 RID: 177858 RVA: 0x00C34BBD File Offset: 0x00C32DBD
		public static PerfExceedFramework Instance
		{
			get
			{
				return PerfExceedFramework._Instance;
			}
		}

		// Token: 0x0602B6C3 RID: 177859 RVA: 0x00C34BC4 File Offset: 0x00C32DC4
		public static PerfExceedFramework GetOrCreateInstance()
		{
			if (PerfExceedFramework._Instance == null)
			{
				PerfExceedFramework.CreateInstance();
			}
			return PerfExceedFramework._Instance;
		}

		// Token: 0x0602B6C4 RID: 177860 RVA: 0x00C34BD8 File Offset: 0x00C32DD8
		public static bool CreateInstance()
		{
			if (PerfExceedFramework._Instance != null)
			{
				return true;
			}
			PerfExceedFramework._Instance = new PerfExceedFramework();
			return true;
		}

		// Token: 0x0602B6C5 RID: 177861 RVA: 0x00C34BEE File Offset: 0x00C32DEE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B6C6 RID: 177862 RVA: 0x00C34BF0 File Offset: 0x00C32DF0
		public static void ResetStaticDefaultValue()
		{
			PerfExceedFramework._Instance = null;
		}

		// Token: 0x0602B6C7 RID: 177863 RVA: 0x00C34BF8 File Offset: 0x00C32DF8
		static PerfExceedFramework()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PerfExceedFramework.CreateStaticDefaultValue), new Action(PerfExceedFramework.ResetStaticDefaultValue));
		}

		// Token: 0x040177A4 RID: 96164
		private const float TIMER_INTERVAL_MS = 500f;

		// Token: 0x040177A5 RID: 96165
		private readonly NiagaraMetricProvider Provider = new NiagaraMetricProvider();

		// Token: 0x040177A6 RID: 96166
		private readonly PerfExceedReporter Reporter = new PerfExceedReporter();

		// Token: 0x040177A7 RID: 96167
		private readonly PerfExceedSessionLimiter SessionLimiter = new PerfExceedSessionLimiter(50);

		// Token: 0x040177A8 RID: 96168
		private readonly Dictionary<PerfExceedSubMetric, PerfExceedStateMachine> StateMachines = new Dictionary<PerfExceedSubMetric, PerfExceedStateMachine>();

		// Token: 0x040177A9 RID: 96169
		[Nullable(2)]
		private TimerHandle SampleTimer;

		// Token: 0x040177AA RID: 96170
		private bool LoggedFirstSample;

		// Token: 0x040177AB RID: 96171
		[Nullable(2)]
		private static PerfExceedFramework _Instance;
	}
}
