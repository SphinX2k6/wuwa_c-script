using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000529 RID: 1321
	public class ConfigMapTravelConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F01 RID: 7937 RVA: 0x00108807 File Offset: 0x00106A07
		static ConfigMapTravelConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapTravelConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigMapTravelConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00108828 File Offset: 0x00106A28
		public static void CreateStaticDefaultValue()
		{
			ConfigMapTravelConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapTravelConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "MapTravelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MapTravelConfig` where ActivityId=?")
			});
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x001088A7 File Offset: 0x00106AA7
		public static void ResetStaticDefaultValue()
		{
			ConfigMapTravelConfigByActivityId.LogPair = null;
			ConfigMapTravelConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06001F04 RID: 7940 RVA: 0x001088B5 File Offset: 0x00106AB5
		public static void Init()
		{
			ConfigMapTravelConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMapTravelConfigByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `MapTravelConfig` where ActivityId=?");
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x001088D0 File Offset: 0x00106AD0
		public static MapTravelConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapTravelConfigByActivityId.HandleId, ConfigMapTravelConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapTravelConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapTravelConfig?(MapTravelConfig.GetRootAsMapTravelConfig(configBuffer));
				}
			}
			ConfigMapTravelConfigByActivityId.LogPair.Clear();
			ConfigMapTravelConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigMapTravelConfigByActivityId.HandleId, 1, p0ActivityId, ConfigMapTravelConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigMapTravelConfigByActivityId.HandleId, true, ConfigMapTravelConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapTravelConfigByActivityId.HandleId, ConfigMapTravelConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapTravelConfigByActivityId.HandleId, 0, ConfigMapTravelConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapTravelConfigByActivityId.HandleId, ConfigMapTravelConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapTravelConfig rootAsMapTravelConfig = MapTravelConfig.GetRootAsMapTravelConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapTravelConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapTravelConfigByActivityId.HandleId, ConfigMapTravelConfigByActivityId.LogPair);
			return new MapTravelConfig?(rootAsMapTravelConfig);
		}

		// Token: 0x04002403 RID: 9219
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04002404 RID: 9220
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04002405 RID: 9221
		private const string TABLE = "MapTravelConfig";

		// Token: 0x04002406 RID: 9222
		private const string COMMAND = "select BinData from `MapTravelConfig` where ActivityId=?";

		// Token: 0x04002407 RID: 9223
		private const string KEY_PREFIX = "MapTravelConfigByActivityId";

		// Token: 0x04002408 RID: 9224
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002409 RID: 9225
		private static int HandleId;
	}
}
