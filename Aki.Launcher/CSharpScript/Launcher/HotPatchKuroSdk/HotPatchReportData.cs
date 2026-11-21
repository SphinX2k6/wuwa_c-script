using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001EE RID: 494
	public class HotPatchReportData : IStaticVariableResetter
	{
		// Token: 0x06000D23 RID: 3363 RVA: 0x00050FB3 File Offset: 0x0004F1B3
		static HotPatchReportData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchReportData.CreateStaticDefaultValue), new Action(HotPatchReportData.ResetStaticDefaultValue));
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00050FD4 File Offset: 0x0004F1D4
		[NullableContext(2)]
		public static SdkReportData CreateData(ESdkHotPatchReportEnum type, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] Dictionary<string, string> dataMap)
		{
			if (BaseConfigController.Instance.GetPublicValue("SdkArea") == "CN")
			{
				return null;
			}
			if (HotPatchReportData.SdkReportTypeMap.Count == 0)
			{
				HotPatchReportData.SdkReportTypeMap[0] = (([Nullable(new byte[]
				{
					2,
					1,
					1
				})] Dictionary<string, string> dataMap) => new SdkLogoReportData(dataMap));
				HotPatchReportData.SdkReportTypeMap[1] = (([Nullable(new byte[]
				{
					2,
					1,
					1
				})] Dictionary<string, string> dataMap) => new SdkCheckVersionStart(dataMap));
				HotPatchReportData.SdkReportTypeMap[2] = (([Nullable(new byte[]
				{
					2,
					1,
					1
				})] Dictionary<string, string> dataMap) => new SdkCheckVersionEnd(dataMap));
				HotPatchReportData.SdkReportTypeMap[3] = (([Nullable(new byte[]
				{
					2,
					1,
					1
				})] Dictionary<string, string> dataMap) => new SdkCheckVersionFail(dataMap));
				HotPatchReportData.SdkReportTypeMap[4] = (([Nullable(new byte[]
				{
					2,
					1,
					1
				})] Dictionary<string, string> dataMap) => new SdkResourceDownloadStart(dataMap));
				HotPatchReportData.SdkReportTypeMap[5] = (([Nullable(new byte[]
				{
					2,
					1,
					1
				})] Dictionary<string, string> dataMap) => new SdkResourceDownloadEnd(dataMap));
				HotPatchReportData.SdkReportTypeMap[6] = (([Nullable(new byte[]
				{
					2,
					1,
					1
				})] Dictionary<string, string> dataMap) => new SdkResourceDownloadFail(dataMap));
			}
			Func<Dictionary<string, string>, SdkReportData> func;
			if (!HotPatchReportData.SdkReportTypeMap.TryGetValue((int)type, out func))
			{
				return null;
			}
			return func(dataMap2);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0005114B File Offset: 0x0004F34B
		public static void CreateStaticDefaultValue()
		{
			HotPatchReportData.SdkReportTypeMap = new Dictionary<int, Func<Dictionary<string, string>, SdkReportData>>();
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00051157 File Offset: 0x0004F357
		public static void ResetStaticDefaultValue()
		{
			HotPatchReportData.SdkReportTypeMap = null;
		}

		// Token: 0x04000840 RID: 2112
		[Nullable(new byte[]
		{
			1,
			1,
			2,
			1,
			1,
			1
		})]
		private static Dictionary<int, Func<Dictionary<string, string>, SdkReportData>> SdkReportTypeMap;
	}
}
