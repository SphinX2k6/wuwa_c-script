using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000107 RID: 263
	public class ConfigBlackCoastThemeStageReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x0008031B File Offset: 0x0007E51B
		static ConfigBlackCoastThemeStageReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeStageReById.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeStageReById.ResetStaticDefaultValue));
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0008033C File Offset: 0x0007E53C
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackCoastThemeStageReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackCoastThemeStageReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackcoasttheme.db"),
				new ValueTuple<string, object>("文件", "h.黑海岸主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "BlackCoastThemeStageRe"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackCoastThemeStageRe` where Id=?")
			});
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x000803BB File Offset: 0x0007E5BB
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeStageReById.LogPair = null;
			ConfigBlackCoastThemeStageReById.HandleId = 0;
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000803C9 File Offset: 0x0007E5C9
		public static void Init()
		{
			ConfigBlackCoastThemeStageReById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeStageReById.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeStageRe` where Id=?");
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000803E4 File Offset: 0x0007E5E4
		public static BlackCoastThemeStageRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackCoastThemeStageReById.HandleId, ConfigBlackCoastThemeStageReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeStageReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BlackCoastThemeStageRe?(BlackCoastThemeStageRe.GetRootAsBlackCoastThemeStageRe(configBuffer));
				}
			}
			ConfigBlackCoastThemeStageReById.LogPair.Clear();
			ConfigBlackCoastThemeStageReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBlackCoastThemeStageReById.HandleId, 1, p0Id, ConfigBlackCoastThemeStageReById.LogPair) || ConfigCommon.Step(ConfigBlackCoastThemeStageReById.HandleId, true, ConfigBlackCoastThemeStageReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeStageReById.HandleId, ConfigBlackCoastThemeStageReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackCoastThemeStageReById.HandleId, 0, ConfigBlackCoastThemeStageReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlackCoastThemeStageReById.HandleId, ConfigBlackCoastThemeStageReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlackCoastThemeStageRe rootAsBlackCoastThemeStageRe = BlackCoastThemeStageRe.GetRootAsBlackCoastThemeStageRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackCoastThemeStageReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlackCoastThemeStageReById.HandleId, ConfigBlackCoastThemeStageReById.LogPair);
			return new BlackCoastThemeStageRe?(rootAsBlackCoastThemeStageRe);
		}

		// Token: 0x04000715 RID: 1813
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x04000716 RID: 1814
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x04000717 RID: 1815
		private const string TABLE = "BlackCoastThemeStageRe";

		// Token: 0x04000718 RID: 1816
		private const string COMMAND = "select BinData from `BlackCoastThemeStageRe` where Id=?";

		// Token: 0x04000719 RID: 1817
		private const string KEY_PREFIX = "BlackCoastThemeStageReById";

		// Token: 0x0400071A RID: 1818
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400071B RID: 1819
		private static int HandleId;
	}
}
