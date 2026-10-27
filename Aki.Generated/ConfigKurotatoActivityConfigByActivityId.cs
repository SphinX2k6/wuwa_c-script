using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000483 RID: 1155
	public class ConfigKurotatoActivityConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B1C RID: 6940 RVA: 0x000F298F File Offset: 0x000F0B8F
		static ConfigKurotatoActivityConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoActivityConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigKurotatoActivityConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000F29B0 File Offset: 0x000F0BB0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoActivityConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoActivityConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_活动.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoActivityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoActivityConfig` where ActivityId=?")
			});
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x000F2A2F File Offset: 0x000F0C2F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoActivityConfigByActivityId.LogPair = null;
			ConfigKurotatoActivityConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000F2A3D File Offset: 0x000F0C3D
		public static void Init()
		{
			ConfigKurotatoActivityConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoActivityConfigByActivityId.HandleId, "db_kurotato.db", "select BinData from `KurotatoActivityConfig` where ActivityId=?");
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x000F2A58 File Offset: 0x000F0C58
		public static KurotatoActivityConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoActivityConfigByActivityId.HandleId, ConfigKurotatoActivityConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoActivityConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoActivityConfig?(KurotatoActivityConfig.GetRootAsKurotatoActivityConfig(configBuffer));
				}
			}
			ConfigKurotatoActivityConfigByActivityId.LogPair.Clear();
			ConfigKurotatoActivityConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigKurotatoActivityConfigByActivityId.HandleId, 1, p0ActivityId, ConfigKurotatoActivityConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigKurotatoActivityConfigByActivityId.HandleId, true, ConfigKurotatoActivityConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoActivityConfigByActivityId.HandleId, ConfigKurotatoActivityConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoActivityConfigByActivityId.HandleId, 0, ConfigKurotatoActivityConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoActivityConfigByActivityId.HandleId, ConfigKurotatoActivityConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoActivityConfig rootAsKurotatoActivityConfig = KurotatoActivityConfig.GetRootAsKurotatoActivityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoActivityConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoActivityConfigByActivityId.HandleId, ConfigKurotatoActivityConfigByActivityId.LogPair);
			return new KurotatoActivityConfig?(rootAsKurotatoActivityConfig);
		}

		// Token: 0x04001F79 RID: 8057
		private const string DB = "db_kurotato.db";

		// Token: 0x04001F7A RID: 8058
		private const string FILE = "t.土豆兄弟_活动.xlsx";

		// Token: 0x04001F7B RID: 8059
		private const string TABLE = "KurotatoActivityConfig";

		// Token: 0x04001F7C RID: 8060
		private const string COMMAND = "select BinData from `KurotatoActivityConfig` where ActivityId=?";

		// Token: 0x04001F7D RID: 8061
		private const string KEY_PREFIX = "KurotatoActivityConfigByActivityId";

		// Token: 0x04001F7E RID: 8062
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F7F RID: 8063
		private static int HandleId;
	}
}
