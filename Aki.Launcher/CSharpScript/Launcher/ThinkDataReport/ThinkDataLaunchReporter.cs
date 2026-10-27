using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.ThinkDataReport
{
	// Token: 0x020000FF RID: 255
	[NullableContext(1)]
	[Nullable(0)]
	public class ThinkDataLaunchReporter : Singleton
	{
		// Token: 0x0600086E RID: 2158 RVA: 0x0003E879 File Offset: 0x0003CA79
		public void InitializeInstance()
		{
			RealThinkDataLaunchReporter.InitializeInstance();
			RealKRDataLaunchReporter.InitializeInstance();
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0003E885 File Offset: 0x0003CA85
		public void CalibrateInstanceTime()
		{
			RealThinkDataLaunchReporter.CalibrateInstanceTime();
			RealKRDataLaunchReporter.CalibrateInstanceTime();
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0003E891 File Offset: 0x0003CA91
		public void Report(string key, string jsonLog)
		{
			RealThinkDataLaunchReporter.Report(key, jsonLog);
			RealKRDataLaunchReporter.Report(key, jsonLog);
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0003E8A1 File Offset: 0x0003CAA1
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

		// Token: 0x06000872 RID: 2162 RVA: 0x0003E8C4 File Offset: 0x0003CAC4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0003E8C6 File Offset: 0x0003CAC6
		public static void ResetStaticDefaultValue()
		{
			ThinkDataLaunchReporter instance = ThinkDataLaunchReporter._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			ThinkDataLaunchReporter._instance = null;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0003E8DF File Offset: 0x0003CADF
		static ThinkDataLaunchReporter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ThinkDataLaunchReporter.CreateStaticDefaultValue), new Action(ThinkDataLaunchReporter.ResetStaticDefaultValue));
		}

		// Token: 0x040004B9 RID: 1209
		public const bool ENABLE_THINKING_ANALYTICS = true;

		// Token: 0x040004BA RID: 1210
		public const bool ENABLE_KD_ANALYTICS = true;

		// Token: 0x040004BB RID: 1211
		public const int EXIT_WAIT_TIME = 1;

		// Token: 0x040004BC RID: 1212
		public const int MAX_PENDING_LOG = 1000;

		// Token: 0x040004BD RID: 1213
		public const int SEND_HTTP_TIMEOUT = 10000;

		// Token: 0x040004BE RID: 1214
		public const int CALIBRATE_INTERVAL = 10;

		// Token: 0x040004BF RID: 1215
		public const bool CALIBRATE_STOP_TIMER = true;

		// Token: 0x040004C0 RID: 1216
		public string ClientVersion = "";

		// Token: 0x040004C1 RID: 1217
		[Nullable(2)]
		private static ThinkDataLaunchReporter _instance;
	}
}
