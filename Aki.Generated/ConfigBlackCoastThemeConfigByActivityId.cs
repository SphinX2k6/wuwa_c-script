using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000103 RID: 259
	public class ConfigBlackCoastThemeConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x0007FA1B File Offset: 0x0007DC1B
		static ConfigBlackCoastThemeConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0007FA3C File Offset: 0x0007DC3C
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackCoastThemeConfigByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackCoastThemeConfigByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackcoasttheme.db"),
				new ValueTuple<string, object>("文件", "h.黑海岸主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "BlackCoastThemeConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackCoastThemeConfig` where ActivityId=?")
			});
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0007FABB File Offset: 0x0007DCBB
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeConfigByActivityId.LogPair = null;
			ConfigBlackCoastThemeConfigByActivityId.HandleId = 0;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0007FAC9 File Offset: 0x0007DCC9
		public static void Init()
		{
			ConfigBlackCoastThemeConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeConfigByActivityId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeConfig` where ActivityId=?");
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0007FAE4 File Offset: 0x0007DCE4
		public static BlackCoastThemeConfig? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackCoastThemeConfigByActivityId.HandleId, ConfigBlackCoastThemeConfigByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BlackCoastThemeConfig?(BlackCoastThemeConfig.GetRootAsBlackCoastThemeConfig(configBuffer));
				}
			}
			ConfigBlackCoastThemeConfigByActivityId.LogPair.Clear();
			ConfigBlackCoastThemeConfigByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBlackCoastThemeConfigByActivityId.HandleId, 1, p0ActivityId, ConfigBlackCoastThemeConfigByActivityId.LogPair) || ConfigCommon.Step(ConfigBlackCoastThemeConfigByActivityId.HandleId, true, ConfigBlackCoastThemeConfigByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeConfigByActivityId.HandleId, ConfigBlackCoastThemeConfigByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackCoastThemeConfigByActivityId.HandleId, 0, ConfigBlackCoastThemeConfigByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeConfigByActivityId.HandleId, ConfigBlackCoastThemeConfigByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlackCoastThemeConfig rootAsBlackCoastThemeConfig = BlackCoastThemeConfig.GetRootAsBlackCoastThemeConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeConfigByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlackCoastThemeConfigByActivityId.HandleId, ConfigBlackCoastThemeConfigByActivityId.LogPair);
			return new BlackCoastThemeConfig?(rootAsBlackCoastThemeConfig);
		}

		// Token: 0x040006F9 RID: 1785
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x040006FA RID: 1786
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x040006FB RID: 1787
		private const string TABLE = "BlackCoastThemeConfig";

		// Token: 0x040006FC RID: 1788
		private const string COMMAND = "select BinData from `BlackCoastThemeConfig` where ActivityId=?";

		// Token: 0x040006FD RID: 1789
		private const string KEY_PREFIX = "BlackCoastThemeConfigByActivityId";

		// Token: 0x040006FE RID: 1790
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006FF RID: 1791
		private static int HandleId;
	}
}
