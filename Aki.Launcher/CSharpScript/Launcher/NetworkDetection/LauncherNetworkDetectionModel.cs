using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Platform;

namespace CSharpScript.Launcher.NetworkDetection
{
	// Token: 0x020001BD RID: 445
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherNetworkDetectionModel
	{
		// Token: 0x06000C1A RID: 3098 RVA: 0x0004CBD4 File Offset: 0x0004ADD4
		public static string GetGenericErrorCodeTips(ENetworkDetectionType detectionType, int errorCode, INetworkDetectionResult result)
		{
			string value = "ERROR CODE:";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			switch (detectionType)
			{
			case ENetworkDetectionType.Proxy:
				return LauncherConfigLib.Instance.GetHotPatchText("NetworkDetection_Proxy_Wrong") + (result as INetworkDetectionProxyResult).Address;
			case ENetworkDetectionType.Domain:
				value = LauncherConfigLib.Instance.GetHotPatchText("NetworkDetection_Domain_Wrong");
				break;
			case ENetworkDetectionType.Ping:
			{
				INetworkDetectionPingResult networkDetectionPingResult = result as INetworkDetectionPingResult;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 5);
				defaultInterpolatedStringHandler.AppendFormatted(LauncherConfigLib.Instance.GetHotPatchText("NetworkDetection_Ping_Wrong"));
				defaultInterpolatedStringHandler.AppendLiteral(" Min:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(networkDetectionPingResult.Result.Min);
				defaultInterpolatedStringHandler.AppendLiteral(",Max:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(networkDetectionPingResult.Result.Max);
				defaultInterpolatedStringHandler.AppendLiteral(",Min:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(networkDetectionPingResult.Result.Avg);
				defaultInterpolatedStringHandler.AppendLiteral(",Loss:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(networkDetectionPingResult.Result.Loss);
				value = defaultInterpolatedStringHandler.ToStringAndClear();
				break;
			}
			case ENetworkDetectionType.Http:
				value = LauncherConfigLib.Instance.GetHotPatchText("NetworkDetection_Http_Wrong");
				break;
			case ENetworkDetectionType.UdpPort:
				value = LauncherConfigLib.Instance.GetHotPatchText("NetworkDetection_Udp_Wrong");
				break;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendFormatted<int>(errorCode);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0004CD28 File Offset: 0x0004AF28
		public static string GenerateTraceCode()
		{
			List<int> list = new List<int>();
			for (int i = 0; i < 12; i++)
			{
				int item = Random.Shared.Next(0, 10);
				list.Add(item);
			}
			return string.Join<int>("", list);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0004CD68 File Offset: 0x0004AF68
		public static List<INetworkDetectionEntry> GetDetectionDataList()
		{
			if (Platform.Instance.IsWindowsPlatform())
			{
				List<INetworkDetectionEntry> list = new List<INetworkDetectionEntry>();
				foreach (INetworkDetectionEntry item in LauncherNetworkDetectionDefine.networkDetectionEntries)
				{
					list.Add(item);
				}
				return list;
			}
			List<INetworkDetectionEntry> list2 = new List<INetworkDetectionEntry>();
			foreach (INetworkDetectionEntry networkDetectionEntry in LauncherNetworkDetectionDefine.networkDetectionEntries)
			{
				if (networkDetectionEntry.Type != ENetworkDetectionType.TraceRoute)
				{
					list2.Add(networkDetectionEntry);
				}
			}
			return list2;
		}
	}
}
