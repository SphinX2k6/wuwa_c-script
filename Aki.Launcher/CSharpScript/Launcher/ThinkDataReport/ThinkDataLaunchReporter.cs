using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.ThinkDataReport
{
	// Token: 0x02000103 RID: 259
	[NullableContext(1)]
	[Nullable(0)]
	public class ThinkDataLaunchReporter : Singleton
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x00040C19 File Offset: 0x0003EE19
		public void InitializeInstance()
		{
			RealThinkDataLaunchReporter.InitializeInstance();
			RealKRDataLaunchReporter.InitializeInstance();
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00040C25 File Offset: 0x0003EE25
		public void CalibrateInstanceTime()
		{
			RealThinkDataLaunchReporter.CalibrateInstanceTime();
			RealKRDataLaunchReporter.CalibrateInstanceTime();
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00040C31 File Offset: 0x0003EE31
		public void Report(string key, string jsonLog)
		{
			RealThinkDataLaunchReporter.Report(key, jsonLog);
			RealKRDataLaunchReporter.Report(key, jsonLog);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00040C41 File Offset: 0x0003EE41
		public static ThinkDataLaunchReporter Instance
		{
			get
			{
				if (ThinkDataLaunchReporter._instance == null)
				{
					ThinkDataLaunchReporter._instance = new ThinkDataLaunchReporter();
					ThinkDataLaunchReporter._instance.OnInit();
				}
				return ThinkDataLaunchReporter._instance;
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00040C64 File Offset: 0x0003EE64
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00040C66 File Offset: 0x0003EE66
		public static void ResetStaticDefaultValue()
		{
			ThinkDataLaunchReporter instance = ThinkDataLaunchReporter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			ThinkDataLaunchReporter._instance = null;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00040C7F File Offset: 0x0003EE7F
		static ThinkDataLaunchReporter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ThinkDataLaunchReporter.CreateStaticDefaultValue), new Action(ThinkDataLaunchReporter.ResetStaticDefaultValue));
		}

		// Token: 0x040004F4 RID: 1268
		public const bool ENABLE_THINKING_ANALYTICS = true;

		// Token: 0x040004F5 RID: 1269
		public const bool ENABLE_KD_ANALYTICS = true;

		// Token: 0x040004F6 RID: 1270
		public const int EXIT_WAIT_TIME = 1;

		// Token: 0x040004F7 RID: 1271
		public const int MAX_PENDING_LOG = 1000;

		// Token: 0x040004F8 RID: 1272
		public const int SEND_HTTP_TIMEOUT = 10000;

		// Token: 0x040004F9 RID: 1273
		public const int CALIBRATE_INTERVAL = 10;

		// Token: 0x040004FA RID: 1274
		public const bool CALIBRATE_STOP_TIMER = true;

		// Token: 0x040004FB RID: 1275
		public string ClientVersion = "";

		// Token: 0x040004FC RID: 1276
		[Nullable(2)]
		private static ThinkDataLaunchReporter _instance;
	}
}
