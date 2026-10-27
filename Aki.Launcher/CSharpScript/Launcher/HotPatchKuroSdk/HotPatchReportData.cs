using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.HotPatchKuroSdk
{
	// Token: 0x020001E9 RID: 489
	public class HotPatchReportData : IStaticVariableResetter
	{
		// Token: 0x06000CE2 RID: 3298 RVA: 0x0004E4C7 File Offset: 0x0004C6C7
		static HotPatchReportData()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(HotPatchReportData.CreateStaticDefaultValue), new Action(HotPatchReportData.ResetStaticDefaultValue));
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0004E4E8 File Offset: 0x0004C6E8
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

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0004E65F File Offset: 0x0004C85F
		public static void CreateStaticDefaultValue()
		{
			HotPatchReportData.SdkReportTypeMap = new Dictionary<int, Func<Dictionary<string, string>, SdkReportData>>();
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0004E66B File Offset: 0x0004C86B
		public static void ResetStaticDefaultValue()
		{
			HotPatchReportData.SdkReportTypeMap = null;
		}

		// Token: 0x04000800 RID: 2048
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
