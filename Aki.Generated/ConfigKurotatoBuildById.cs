using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000486 RID: 1158
	public class ConfigKurotatoBuildById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B2E RID: 6958 RVA: 0x000F2FB3 File Offset: 0x000F11B3
		static ConfigKurotatoBuildById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoBuildById.CreateStaticDefaultValue), new Action(ConfigKurotatoBuildById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x000F2FD4 File Offset: 0x000F11D4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoBuildById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoBuildById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_抽取规则.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoBuild` where Id=?")
			});
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x000F3053 File Offset: 0x000F1253
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoBuildById.LogPair = null;
			ConfigKurotatoBuildById.HandleId = 0;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x000F3061 File Offset: 0x000F1261
		public static void Init()
		{
			ConfigKurotatoBuildById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoBuildById.HandleId, "db_kurotato.db", "select BinData from `KurotatoBuild` where Id=?");
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x000F307C File Offset: 0x000F127C
		public static KurotatoBuild? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoBuildById.HandleId, ConfigKurotatoBuildById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoBuild?(KurotatoBuild.GetRootAsKurotatoBuild(configBuffer));
				}
			}
			ConfigKurotatoBuildById.LogPair.Clear();
			ConfigKurotatoBuildById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoBuildById.HandleId, 1, p0Id, ConfigKurotatoBuildById.LogPair) || ConfigCommon.Step(ConfigKurotatoBuildById.HandleId, true, ConfigKurotatoBuildById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoBuildById.HandleId, ConfigKurotatoBuildById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoBuildById.HandleId, 0, ConfigKurotatoBuildById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoBuildById.HandleId, ConfigKurotatoBuildById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoBuild rootAsKurotatoBuild = KurotatoBuild.GetRootAsKurotatoBuild(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoBuildById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoBuildById.HandleId, ConfigKurotatoBuildById.LogPair);
			return new KurotatoBuild?(rootAsKurotatoBuild);
		}

		// Token: 0x04001F8E RID: 8078
		private const string DB = "db_kurotato.db";

		// Token: 0x04001F8F RID: 8079
		private const string FILE = "t.土豆兄弟_抽取规则.xlsx";

		// Token: 0x04001F90 RID: 8080
		private const string TABLE = "KurotatoBuild";

		// Token: 0x04001F91 RID: 8081
		private const string COMMAND = "select BinData from `KurotatoBuild` where Id=?";

		// Token: 0x04001F92 RID: 8082
		private const string KEY_PREFIX = "KurotatoBuildById";

		// Token: 0x04001F93 RID: 8083
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F94 RID: 8084
		private static int HandleId;
	}
}
