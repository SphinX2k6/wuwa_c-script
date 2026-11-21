using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049A RID: 1178
	public class ConfigKurotatoActivityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BA6 RID: 7078 RVA: 0x000F932C File Offset: 0x000F752C
		static ConfigKurotatoActivityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoActivityConfigById.CreateStaticDefaultValue), new Action(ConfigKurotatoActivityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x000F934C File Offset: 0x000F754C
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

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000F93CB File Offset: 0x000F75CB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoActivityConfigById.LogPair = null;
			ConfigKurotatoActivityConfigById.HandleId = 0;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000F93D9 File Offset: 0x000F75D9
		public static void Init()
		{
			ConfigKurotatoActivityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoActivityConfigById.HandleId, "db_kurotato.db", "select BinData from `KurotatoActivityConfig` where Id=?");
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000F93F4 File Offset: 0x000F75F4
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

		// Token: 0x0400201A RID: 8218
		private const string DB = "db_kurotato.db";

		// Token: 0x0400201B RID: 8219
		private const string FILE = "t.土豆兄弟_活动.xlsx";

		// Token: 0x0400201C RID: 8220
		private const string TABLE = "KurotatoActivityConfig";

		// Token: 0x0400201D RID: 8221
		private const string COMMAND = "select BinData from `KurotatoActivityConfig` where Id=?";

		// Token: 0x0400201E RID: 8222
		private const string KEY_PREFIX = "KurotatoActivityConfigById";

		// Token: 0x0400201F RID: 8223
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002020 RID: 8224
		private static int HandleId;
	}
}
