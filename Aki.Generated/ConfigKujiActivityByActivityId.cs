using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000492 RID: 1170
	public class ConfigKujiActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B76 RID: 7030 RVA: 0x000F8273 File Offset: 0x000F6473
		static ConfigKujiActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigKujiActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x000F8294 File Offset: 0x000F6494
		public static void CreateStaticDefaultValue()
		{
			ConfigKujiActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKujiActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_wuwukuji.db"),
				new ValueTuple<string, object>("文件", "w.呜呜一番赏.xlsx"),
				new ValueTuple<string, object>("表名", "KujiActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `KujiActivity` where ActivityId=?")
			});
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x000F8313 File Offset: 0x000F6513
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiActivityByActivityId.LogPair = null;
			ConfigKujiActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x000F8321 File Offset: 0x000F6521
		public static void Init()
		{
			ConfigKujiActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigKujiActivityByActivityId.HandleId, "db_wuwukuji.db", "select BinData from `KujiActivity` where ActivityId=?");
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x000F833C File Offset: 0x000F653C
		public static KujiActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKujiActivityByActivityId.HandleId, ConfigKujiActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KujiActivity?(KujiActivity.GetRootAsKujiActivity(configBuffer));
				}
			}
			ConfigKujiActivityByActivityId.LogPair.Clear();
			ConfigKujiActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigKujiActivityByActivityId.HandleId, 1, p0ActivityId, ConfigKujiActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigKujiActivityByActivityId.HandleId, true, ConfigKujiActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKujiActivityByActivityId.HandleId, ConfigKujiActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKujiActivityByActivityId.HandleId, 0, ConfigKujiActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKujiActivityByActivityId.HandleId, ConfigKujiActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KujiActivity rootAsKujiActivity = KujiActivity.GetRootAsKujiActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KujiActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKujiActivityByActivityId.HandleId, ConfigKujiActivityByActivityId.LogPair);
			return new KujiActivity?(rootAsKujiActivity);
		}

		// Token: 0x04001FE2 RID: 8162
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001FE3 RID: 8163
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001FE4 RID: 8164
		private const string TABLE = "KujiActivity";

		// Token: 0x04001FE5 RID: 8165
		private const string COMMAND = "select BinData from `KujiActivity` where ActivityId=?";

		// Token: 0x04001FE6 RID: 8166
		private const string KEY_PREFIX = "KujiActivityByActivityId";

		// Token: 0x04001FE7 RID: 8167
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FE8 RID: 8168
		private static int HandleId;
	}
}
