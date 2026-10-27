using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000205 RID: 517
	public class ConfigDevicePlatformByPidAndVid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C21 RID: 3105 RVA: 0x0009E374 File Offset: 0x0009C574
		static ConfigDevicePlatformByPidAndVid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDevicePlatformByPidAndVid.CreateStaticDefaultValue), new Action(ConfigDevicePlatformByPidAndVid.ResetStaticDefaultValue));
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0009E394 File Offset: 0x0009C594
		public static void CreateStaticDefaultValue()
		{
			ConfigDevicePlatformByPidAndVid.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDevicePlatformByPidAndVid.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_deviceplatform.db"),
				new ValueTuple<string, object>("文件", "s.设备平台.xlsx"),
				new ValueTuple<string, object>("表名", "DevicePlatform"),
				new ValueTuple<string, object>("语句", "select BinData from `DevicePlatform` where PidAndVid=?")
			});
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0009E413 File Offset: 0x0009C613
		public static void ResetStaticDefaultValue()
		{
			ConfigDevicePlatformByPidAndVid.LogPair = null;
			ConfigDevicePlatformByPidAndVid.HandleId = 0;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0009E421 File Offset: 0x0009C621
		public static void Init()
		{
			ConfigDevicePlatformByPidAndVid.HandleId = ConfigCommon.InitDataStatement(ConfigDevicePlatformByPidAndVid.HandleId, "db_deviceplatform.db", "select BinData from `DevicePlatform` where PidAndVid=?");
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0009E43C File Offset: 0x0009C63C
		public static DevicePlatform? GetConfig(string p0PidAndVid, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDevicePlatformByPidAndVid.HandleId, ConfigDevicePlatformByPidAndVid.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("DevicePlatformByPidAndVid#" + p0PidAndVid);
				if (configBuffer != null)
				{
					return new DevicePlatform?(DevicePlatform.GetRootAsDevicePlatform(configBuffer));
				}
			}
			ConfigDevicePlatformByPidAndVid.LogPair.Clear();
			ConfigDevicePlatformByPidAndVid.LogPair.Add(new ValueTuple<string, object>("PidAndVid", p0PidAndVid));
			if (!ConfigCommon.BindString(ConfigDevicePlatformByPidAndVid.HandleId, 1, p0PidAndVid, ConfigDevicePlatformByPidAndVid.LogPair) || ConfigCommon.Step(ConfigDevicePlatformByPidAndVid.HandleId, true, ConfigDevicePlatformByPidAndVid.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDevicePlatformByPidAndVid.HandleId, ConfigDevicePlatformByPidAndVid.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDevicePlatformByPidAndVid.HandleId, 0, ConfigDevicePlatformByPidAndVid.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDevicePlatformByPidAndVid.HandleId, ConfigDevicePlatformByPidAndVid.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DevicePlatform rootAsDevicePlatform = DevicePlatform.GetRootAsDevicePlatform(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("DevicePlatformByPidAndVid#" + p0PidAndVid, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDevicePlatformByPidAndVid.HandleId, ConfigDevicePlatformByPidAndVid.LogPair);
			return new DevicePlatform?(rootAsDevicePlatform);
		}

		// Token: 0x04000E07 RID: 3591
		private const string DB = "db_deviceplatform.db";

		// Token: 0x04000E08 RID: 3592
		private const string FILE = "s.设备平台.xlsx";

		// Token: 0x04000E09 RID: 3593
		private const string TABLE = "DevicePlatform";

		// Token: 0x04000E0A RID: 3594
		private const string COMMAND = "select BinData from `DevicePlatform` where PidAndVid=?";

		// Token: 0x04000E0B RID: 3595
		private const string KEY_PREFIX = "DevicePlatformByPidAndVid";

		// Token: 0x04000E0C RID: 3596
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E0D RID: 3597
		private static int HandleId;
	}
}
