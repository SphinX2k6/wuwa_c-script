using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000204 RID: 516
	public class ConfigDevicePlatformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C1B RID: 3099 RVA: 0x0009E12B File Offset: 0x0009C32B
		static ConfigDevicePlatformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDevicePlatformById.CreateStaticDefaultValue), new Action(ConfigDevicePlatformById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0009E14C File Offset: 0x0009C34C
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

		// Token: 0x06000C1D RID: 3101 RVA: 0x0009E1CB File Offset: 0x0009C3CB
		public static void ResetStaticDefaultValue()
		{
			ConfigDevicePlatformById.LogPair = null;
			ConfigDevicePlatformById.HandleId = 0;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0009E1D9 File Offset: 0x0009C3D9
		public static void Init()
		{
			ConfigDevicePlatformById.HandleId = ConfigCommon.InitDataStatement(ConfigDevicePlatformById.HandleId, "db_deviceplatform.db", "select BinData from `DevicePlatform` where Id=?");
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0009E1F4 File Offset: 0x0009C3F4
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

		// Token: 0x04000E00 RID: 3584
		private const string DB = "db_deviceplatform.db";

		// Token: 0x04000E01 RID: 3585
		private const string FILE = "s.设备平台.xlsx";

		// Token: 0x04000E02 RID: 3586
		private const string TABLE = "DevicePlatform";

		// Token: 0x04000E03 RID: 3587
		private const string COMMAND = "select BinData from `DevicePlatform` where Id=?";

		// Token: 0x04000E04 RID: 3588
		private const string KEY_PREFIX = "DevicePlatformById";

		// Token: 0x04000E05 RID: 3589
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E06 RID: 3590
		private static int HandleId;
	}
}
