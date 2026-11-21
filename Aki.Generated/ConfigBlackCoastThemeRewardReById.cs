using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000105 RID: 261
	public class ConfigBlackCoastThemeRewardReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x0007FE9B File Offset: 0x0007E09B
		static ConfigBlackCoastThemeRewardReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeRewardReById.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeRewardReById.ResetStaticDefaultValue));
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0007FEBC File Offset: 0x0007E0BC
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackCoastThemeRewardReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackCoastThemeRewardReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackcoasttheme.db"),
				new ValueTuple<string, object>("文件", "h.黑海岸主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "BlackCoastThemeRewardRe"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackCoastThemeRewardRe` where Id=?")
			});
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0007FF3B File Offset: 0x0007E13B
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeRewardReById.LogPair = null;
			ConfigBlackCoastThemeRewardReById.HandleId = 0;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0007FF49 File Offset: 0x0007E149
		public static void Init()
		{
			ConfigBlackCoastThemeRewardReById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeRewardReById.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeRewardRe` where Id=?");
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0007FF64 File Offset: 0x0007E164
		public static BlackCoastThemeRewardRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackCoastThemeRewardReById.HandleId, ConfigBlackCoastThemeRewardReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeRewardReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BlackCoastThemeRewardRe?(BlackCoastThemeRewardRe.GetRootAsBlackCoastThemeRewardRe(configBuffer));
				}
			}
			ConfigBlackCoastThemeRewardReById.LogPair.Clear();
			ConfigBlackCoastThemeRewardReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBlackCoastThemeRewardReById.HandleId, 1, p0Id, ConfigBlackCoastThemeRewardReById.LogPair) || ConfigCommon.Step(ConfigBlackCoastThemeRewardReById.HandleId, true, ConfigBlackCoastThemeRewardReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeRewardReById.HandleId, ConfigBlackCoastThemeRewardReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackCoastThemeRewardReById.HandleId, 0, ConfigBlackCoastThemeRewardReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeRewardReById.HandleId, ConfigBlackCoastThemeRewardReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlackCoastThemeRewardRe rootAsBlackCoastThemeRewardRe = BlackCoastThemeRewardRe.GetRootAsBlackCoastThemeRewardRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeRewardReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlackCoastThemeRewardReById.HandleId, ConfigBlackCoastThemeRewardReById.LogPair);
			return new BlackCoastThemeRewardRe?(rootAsBlackCoastThemeRewardRe);
		}

		// Token: 0x04000707 RID: 1799
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x04000708 RID: 1800
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x04000709 RID: 1801
		private const string TABLE = "BlackCoastThemeRewardRe";

		// Token: 0x0400070A RID: 1802
		private const string COMMAND = "select BinData from `BlackCoastThemeRewardRe` where Id=?";

		// Token: 0x0400070B RID: 1803
		private const string KEY_PREFIX = "BlackCoastThemeRewardReById";

		// Token: 0x0400070C RID: 1804
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400070D RID: 1805
		private static int HandleId;
	}
}
