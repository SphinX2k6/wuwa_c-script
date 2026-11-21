using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000126 RID: 294
	public class ConfigBossRushTaskTabByTabId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x00084293 File Offset: 0x00082493
		static ConfigBossRushTaskTabByTabId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskTabByTabId.CreateStaticDefaultValue), new Action(ConfigBossRushTaskTabByTabId.ResetStaticDefaultValue));
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000842B4 File Offset: 0x000824B4
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushTaskTabByTabId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushTaskTabByTabId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushTaskTab` where TabId=?")
			});
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00084333 File Offset: 0x00082533
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskTabByTabId.LogPair = null;
			ConfigBossRushTaskTabByTabId.HandleId = 0;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00084341 File Offset: 0x00082541
		public static void Init()
		{
			ConfigBossRushTaskTabByTabId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskTabByTabId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskTab` where TabId=?");
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0008435C File Offset: 0x0008255C
		public static BossRushTaskTab? GetConfig(int p0TabId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushTaskTabByTabId.HandleId, ConfigBossRushTaskTabByTabId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushTaskTabByTabId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TabId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushTaskTab?(BossRushTaskTab.GetRootAsBossRushTaskTab(configBuffer));
				}
			}
			ConfigBossRushTaskTabByTabId.LogPair.Clear();
			ConfigBossRushTaskTabByTabId.LogPair.Add(new ValueTuple<string, object>("TabId", p0TabId));
			if (!ConfigCommon.BindInt(ConfigBossRushTaskTabByTabId.HandleId, 1, p0TabId, ConfigBossRushTaskTabByTabId.LogPair) || ConfigCommon.Step(ConfigBossRushTaskTabByTabId.HandleId, true, ConfigBossRushTaskTabByTabId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushTaskTabByTabId.HandleId, ConfigBossRushTaskTabByTabId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushTaskTabByTabId.HandleId, 0, ConfigBossRushTaskTabByTabId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushTaskTabByTabId.HandleId, ConfigBossRushTaskTabByTabId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushTaskTab rootAsBossRushTaskTab = BossRushTaskTab.GetRootAsBossRushTaskTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushTaskTabByTabId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TabId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushTaskTabByTabId.HandleId, ConfigBossRushTaskTabByTabId.LogPair);
			return new BossRushTaskTab?(rootAsBossRushTaskTab);
		}

		// Token: 0x040007EE RID: 2030
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007EF RID: 2031
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007F0 RID: 2032
		private const string TABLE = "BossRushTaskTab";

		// Token: 0x040007F1 RID: 2033
		private const string COMMAND = "select BinData from `BossRushTaskTab` where TabId=?";

		// Token: 0x040007F2 RID: 2034
		private const string KEY_PREFIX = "BossRushTaskTabByTabId";

		// Token: 0x040007F3 RID: 2035
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007F4 RID: 2036
		private static int HandleId;
	}
}
