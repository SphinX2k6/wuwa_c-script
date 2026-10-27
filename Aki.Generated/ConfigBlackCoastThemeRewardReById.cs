using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F6 RID: 246
	public class ConfigBlackCoastThemeRewardReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x0007A537 File Offset: 0x00078737
		static ConfigBlackCoastThemeRewardReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeRewardReById.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeRewardReById.ResetStaticDefaultValue));
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0007A558 File Offset: 0x00078758
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

		// Token: 0x060005C7 RID: 1479 RVA: 0x0007A5D7 File Offset: 0x000787D7
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeRewardReById.LogPair = null;
			ConfigBlackCoastThemeRewardReById.HandleId = 0;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0007A5E5 File Offset: 0x000787E5
		public static void Init()
		{
			ConfigBlackCoastThemeRewardReById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeRewardReById.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeRewardRe` where Id=?");
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0007A600 File Offset: 0x00078800
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

		// Token: 0x0400069E RID: 1694
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x0400069F RID: 1695
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x040006A0 RID: 1696
		private const string TABLE = "BlackCoastThemeRewardRe";

		// Token: 0x040006A1 RID: 1697
		private const string COMMAND = "select BinData from `BlackCoastThemeRewardRe` where Id=?";

		// Token: 0x040006A2 RID: 1698
		private const string KEY_PREFIX = "BlackCoastThemeRewardReById";

		// Token: 0x040006A3 RID: 1699
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006A4 RID: 1700
		private static int HandleId;
	}
}
