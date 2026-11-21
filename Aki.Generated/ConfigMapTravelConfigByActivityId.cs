using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053F RID: 1343
	public class ConfigMapTravelConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F85 RID: 8069 RVA: 0x0010EF5B File Offset: 0x0010D15B
		static ConfigMapTravelConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapTravelConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigMapTravelConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0010EF7C File Offset: 0x0010D17C
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

		// Token: 0x06001F87 RID: 8071 RVA: 0x0010EFFB File Offset: 0x0010D1FB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapTravelConfigByActivityId.LogPair = null;
			ConfigMapTravelConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0010F009 File Offset: 0x0010D209
		public static void Init()
		{
			ConfigMapTravelConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigMapTravelConfigByActivityId.HandleId, "db_activitymaptravel.db", "select BinData from `MapTravelConfig` where ActivityId=?");
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0010F024 File Offset: 0x0010D224
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

		// Token: 0x0400249D RID: 9373
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x0400249E RID: 9374
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x0400249F RID: 9375
		private const string TABLE = "MapTravelConfig";

		// Token: 0x040024A0 RID: 9376
		private const string COMMAND = "select BinData from `MapTravelConfig` where ActivityId=?";

		// Token: 0x040024A1 RID: 9377
		private const string KEY_PREFIX = "MapTravelConfigByActivityId";

		// Token: 0x040024A2 RID: 9378
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024A3 RID: 9379
		private static int HandleId;
	}
}
