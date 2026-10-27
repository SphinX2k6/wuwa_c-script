using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F4 RID: 244
	public class ConfigBlackCoastThemeConfigByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x0007A0B7 File Offset: 0x000782B7
		static ConfigBlackCoastThemeConfigByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeConfigByActivityId.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeConfigByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0007A0D8 File Offset: 0x000782D8
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

		// Token: 0x060005BB RID: 1467 RVA: 0x0007A157 File Offset: 0x00078357
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeConfigByActivityId.LogPair = null;
			ConfigBlackCoastThemeConfigByActivityId.HandleId = 0;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0007A165 File Offset: 0x00078365
		public static void Init()
		{
			ConfigBlackCoastThemeConfigByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeConfigByActivityId.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeConfig` where ActivityId=?");
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0007A180 File Offset: 0x00078380
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

		// Token: 0x04000690 RID: 1680
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x04000691 RID: 1681
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x04000692 RID: 1682
		private const string TABLE = "BlackCoastThemeConfig";

		// Token: 0x04000693 RID: 1683
		private const string COMMAND = "select BinData from `BlackCoastThemeConfig` where ActivityId=?";

		// Token: 0x04000694 RID: 1684
		private const string KEY_PREFIX = "BlackCoastThemeConfigByActivityId";

		// Token: 0x04000695 RID: 1685
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000696 RID: 1686
		private static int HandleId;
	}
}
