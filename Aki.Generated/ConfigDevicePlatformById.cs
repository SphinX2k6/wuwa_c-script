using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000216 RID: 534
	public class ConfigDevicePlatformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x000A4063 File Offset: 0x000A2263
		static ConfigDevicePlatformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDevicePlatformById.CreateStaticDefaultValue), new Action(ConfigDevicePlatformById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000A4084 File Offset: 0x000A2284
		public static void CreateStaticDefaultValue()
		{
			ConfigDevicePlatformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDevicePlatformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_deviceplatform.db"),
				new ValueTuple<string, object>("文件", "s.设备平台.xlsx"),
				new ValueTuple<string, object>("表名", "DevicePlatform"),
				new ValueTuple<string, object>("语句", "select BinData from `DevicePlatform` where Id=?")
			});
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000A4103 File Offset: 0x000A2303
		public static void ResetStaticDefaultValue()
		{
			ConfigDevicePlatformById.LogPair = null;
			ConfigDevicePlatformById.HandleId = 0;
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000A4111 File Offset: 0x000A2311
		public static void Init()
		{
			ConfigDevicePlatformById.HandleId = ConfigCommon.InitDataStatement(ConfigDevicePlatformById.HandleId, "db_deviceplatform.db", "select BinData from `DevicePlatform` where Id=?");
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000A412C File Offset: 0x000A232C
		public static DevicePlatform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDevicePlatformById.HandleId, ConfigDevicePlatformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DevicePlatformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DevicePlatform?(DevicePlatform.GetRootAsDevicePlatform(configBuffer));
				}
			}
			ConfigDevicePlatformById.LogPair.Clear();
			ConfigDevicePlatformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDevicePlatformById.HandleId, 1, p0Id, ConfigDevicePlatformById.LogPair) || ConfigCommon.Step(ConfigDevicePlatformById.HandleId, true, ConfigDevicePlatformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDevicePlatformById.HandleId, ConfigDevicePlatformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDevicePlatformById.HandleId, 0, ConfigDevicePlatformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDevicePlatformById.HandleId, ConfigDevicePlatformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DevicePlatform rootAsDevicePlatform = DevicePlatform.GetRootAsDevicePlatform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DevicePlatformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDevicePlatformById.HandleId, ConfigDevicePlatformById.LogPair);
			return new DevicePlatform?(rootAsDevicePlatform);
		}

		// Token: 0x04000E7E RID: 3710
		private const string DB = "db_deviceplatform.db";

		// Token: 0x04000E7F RID: 3711
		private const string FILE = "s.设备平台.xlsx";

		// Token: 0x04000E80 RID: 3712
		private const string TABLE = "DevicePlatform";

		// Token: 0x04000E81 RID: 3713
		private const string COMMAND = "select BinData from `DevicePlatform` where Id=?";

		// Token: 0x04000E82 RID: 3714
		private const string KEY_PREFIX = "DevicePlatformById";

		// Token: 0x04000E83 RID: 3715
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E84 RID: 3716
		private static int HandleId;
	}
}
