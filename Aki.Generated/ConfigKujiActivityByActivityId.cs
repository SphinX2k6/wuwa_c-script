using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047C RID: 1148
	public class ConfigKujiActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AF2 RID: 6898 RVA: 0x000F1B1F File Offset: 0x000EFD1F
		static ConfigKujiActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKujiActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigKujiActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x000F1B40 File Offset: 0x000EFD40
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

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000F1BBF File Offset: 0x000EFDBF
		public static void ResetStaticDefaultValue()
		{
			ConfigKujiActivityByActivityId.LogPair = null;
			ConfigKujiActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000F1BCD File Offset: 0x000EFDCD
		public static void Init()
		{
			ConfigKujiActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigKujiActivityByActivityId.HandleId, "db_wuwukuji.db", "select BinData from `KujiActivity` where ActivityId=?");
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000F1BE8 File Offset: 0x000EFDE8
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

		// Token: 0x04001F48 RID: 8008
		private const string DB = "db_wuwukuji.db";

		// Token: 0x04001F49 RID: 8009
		private const string FILE = "w.呜呜一番赏.xlsx";

		// Token: 0x04001F4A RID: 8010
		private const string TABLE = "KujiActivity";

		// Token: 0x04001F4B RID: 8011
		private const string COMMAND = "select BinData from `KujiActivity` where ActivityId=?";

		// Token: 0x04001F4C RID: 8012
		private const string KEY_PREFIX = "KujiActivityByActivityId";

		// Token: 0x04001F4D RID: 8013
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F4E RID: 8014
		private static int HandleId;
	}
}
