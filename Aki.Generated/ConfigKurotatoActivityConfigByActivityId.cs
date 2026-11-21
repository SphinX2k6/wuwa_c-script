using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000499 RID: 1177
	public class ConfigKurotatoActivityConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BA0 RID: 7072 RVA: 0x000F90E3 File Offset: 0x000F72E3
		static ConfigKurotatoActivityConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoActivityConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigKurotatoActivityConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x000F9104 File Offset: 0x000F7304
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

		// Token: 0x06001BA2 RID: 7074 RVA: 0x000F9183 File Offset: 0x000F7383
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoActivityConfigByActivityId.LogPair = null;
			ConfigKurotatoActivityConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x000F9191 File Offset: 0x000F7391
		public static void Init()
		{
			ConfigKurotatoActivityConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoActivityConfigByActivityId.HandleId, "db_kurotato.db", "select BinData from `KurotatoActivityConfig` where ActivityId=?");
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000F91AC File Offset: 0x000F73AC
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

		// Token: 0x04002013 RID: 8211
		private const string DB = "db_kurotato.db";

		// Token: 0x04002014 RID: 8212
		private const string FILE = "t.土豆兄弟_活动.xlsx";

		// Token: 0x04002015 RID: 8213
		private const string TABLE = "KurotatoActivityConfig";

		// Token: 0x04002016 RID: 8214
		private const string COMMAND = "select BinData from `KurotatoActivityConfig` where ActivityId=?";

		// Token: 0x04002017 RID: 8215
		private const string KEY_PREFIX = "KurotatoActivityConfigByActivityId";

		// Token: 0x04002018 RID: 8216
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002019 RID: 8217
		private static int HandleId;
	}
}
