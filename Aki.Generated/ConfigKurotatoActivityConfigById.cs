using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000484 RID: 1156
	public class ConfigKurotatoActivityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x000F2BD8 File Offset: 0x000F0DD8
		static ConfigKurotatoActivityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoActivityConfigById.CreateStaticDefaultValue), new Action(ConfigKurotatoActivityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000F2BF8 File Offset: 0x000F0DF8
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoActivityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoActivityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_活动.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoActivityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoActivityConfig` where Id=?")
			});
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000F2C77 File Offset: 0x000F0E77
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoActivityConfigById.LogPair = null;
			ConfigKurotatoActivityConfigById.HandleId = 0;
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x000F2C85 File Offset: 0x000F0E85
		public static void Init()
		{
			ConfigKurotatoActivityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoActivityConfigById.HandleId, "db_kurotato.db", "select BinData from `KurotatoActivityConfig` where Id=?");
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x000F2CA0 File Offset: 0x000F0EA0
		public static KurotatoActivityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoActivityConfigById.HandleId, ConfigKurotatoActivityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoActivityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoActivityConfig?(KurotatoActivityConfig.GetRootAsKurotatoActivityConfig(configBuffer));
				}
			}
			ConfigKurotatoActivityConfigById.LogPair.Clear();
			ConfigKurotatoActivityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoActivityConfigById.HandleId, 1, p0Id, ConfigKurotatoActivityConfigById.LogPair) || ConfigCommon.Step(ConfigKurotatoActivityConfigById.HandleId, true, ConfigKurotatoActivityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoActivityConfigById.HandleId, ConfigKurotatoActivityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoActivityConfigById.HandleId, 0, ConfigKurotatoActivityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoActivityConfigById.HandleId, ConfigKurotatoActivityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoActivityConfig rootAsKurotatoActivityConfig = KurotatoActivityConfig.GetRootAsKurotatoActivityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoActivityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoActivityConfigById.HandleId, ConfigKurotatoActivityConfigById.LogPair);
			return new KurotatoActivityConfig?(rootAsKurotatoActivityConfig);
		}

		// Token: 0x04001F80 RID: 8064
		private const string DB = "db_kurotato.db";

		// Token: 0x04001F81 RID: 8065
		private const string FILE = "t.土豆兄弟_活动.xlsx";

		// Token: 0x04001F82 RID: 8066
		private const string TABLE = "KurotatoActivityConfig";

		// Token: 0x04001F83 RID: 8067
		private const string COMMAND = "select BinData from `KurotatoActivityConfig` where Id=?";

		// Token: 0x04001F84 RID: 8068
		private const string KEY_PREFIX = "KurotatoActivityConfigById";

		// Token: 0x04001F85 RID: 8069
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F86 RID: 8070
		private static int HandleId;
	}
}
