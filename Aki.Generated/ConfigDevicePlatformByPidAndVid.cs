using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000217 RID: 535
	public class ConfigDevicePlatformByPidAndVid : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x000A42AC File Offset: 0x000A24AC
		static ConfigDevicePlatformByPidAndVid()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDevicePlatformByPidAndVid.CreateStaticDefaultValue), new Action(ConfigDevicePlatformByPidAndVid.ResetStaticDefaultValue));
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x000A42CC File Offset: 0x000A24CC
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

		// Token: 0x06000C8F RID: 3215 RVA: 0x000A434B File Offset: 0x000A254B
		public static void ResetStaticDefaultValue()
		{
			ConfigDevicePlatformByPidAndVid.LogPair = null;
			ConfigDevicePlatformByPidAndVid.HandleId = 0;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000A4359 File Offset: 0x000A2559
		public static void Init()
		{
			ConfigDevicePlatformByPidAndVid.HandleId = ConfigCommon.InitDataStatement(ConfigDevicePlatformByPidAndVid.HandleId, "db_deviceplatform.db", "select BinData from `DevicePlatform` where PidAndVid=?");
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000A4374 File Offset: 0x000A2574
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

		// Token: 0x04000E85 RID: 3717
		private const string DB = "db_deviceplatform.db";

		// Token: 0x04000E86 RID: 3718
		private const string FILE = "s.设备平台.xlsx";

		// Token: 0x04000E87 RID: 3719
		private const string TABLE = "DevicePlatform";

		// Token: 0x04000E88 RID: 3720
		private const string COMMAND = "select BinData from `DevicePlatform` where PidAndVid=?";

		// Token: 0x04000E89 RID: 3721
		private const string KEY_PREFIX = "DevicePlatformByPidAndVid";

		// Token: 0x04000E8A RID: 3722
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E8B RID: 3723
		private static int HandleId;
	}
}
