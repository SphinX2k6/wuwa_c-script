using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F8 RID: 248
	public class ConfigBlackCoastThemeStageReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x0007A9B7 File Offset: 0x00078BB7
		static ConfigBlackCoastThemeStageReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackCoastThemeStageReById.CreateStaticDefaultValue), new Action(ConfigBlackCoastThemeStageReById.ResetStaticDefaultValue));
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0007A9D8 File Offset: 0x00078BD8
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

		// Token: 0x060005D3 RID: 1491 RVA: 0x0007AA57 File Offset: 0x00078C57
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackCoastThemeStageReById.LogPair = null;
			ConfigBlackCoastThemeStageReById.HandleId = 0;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0007AA65 File Offset: 0x00078C65
		public static void Init()
		{
			ConfigBlackCoastThemeStageReById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackCoastThemeStageReById.HandleId, "db_blackcoasttheme.db", "select BinData from `BlackCoastThemeStageRe` where Id=?");
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0007AA80 File Offset: 0x00078C80
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

		// Token: 0x040006AC RID: 1708
		private const string DB = "db_blackcoasttheme.db";

		// Token: 0x040006AD RID: 1709
		private const string FILE = "h.黑海岸主题活动.xlsx";

		// Token: 0x040006AE RID: 1710
		private const string TABLE = "BlackCoastThemeStageRe";

		// Token: 0x040006AF RID: 1711
		private const string COMMAND = "select BinData from `BlackCoastThemeStageRe` where Id=?";

		// Token: 0x040006B0 RID: 1712
		private const string KEY_PREFIX = "BlackCoastThemeStageReById";

		// Token: 0x040006B1 RID: 1713
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006B2 RID: 1714
		private static int HandleId;
	}
}
