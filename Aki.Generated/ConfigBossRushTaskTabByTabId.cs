using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000117 RID: 279
	public class ConfigBossRushTaskTabByTabId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0007E92F File Offset: 0x0007CB2F
		static ConfigBossRushTaskTabByTabId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushTaskTabByTabId.CreateStaticDefaultValue), new Action(ConfigBossRushTaskTabByTabId.ResetStaticDefaultValue));
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0007E950 File Offset: 0x0007CB50
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

		// Token: 0x0600068D RID: 1677 RVA: 0x0007E9CF File Offset: 0x0007CBCF
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushTaskTabByTabId.LogPair = null;
			ConfigBossRushTaskTabByTabId.HandleId = 0;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0007E9DD File Offset: 0x0007CBDD
		public static void Init()
		{
			ConfigBossRushTaskTabByTabId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushTaskTabByTabId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushTaskTab` where TabId=?");
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0007E9F8 File Offset: 0x0007CBF8
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

		// Token: 0x04000785 RID: 1925
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000786 RID: 1926
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000787 RID: 1927
		private const string TABLE = "BossRushTaskTab";

		// Token: 0x04000788 RID: 1928
		private const string COMMAND = "select BinData from `BossRushTaskTab` where TabId=?";

		// Token: 0x04000789 RID: 1929
		private const string KEY_PREFIX = "BossRushTaskTabByTabId";

		// Token: 0x0400078A RID: 1930
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400078B RID: 1931
		private static int HandleId;
	}
}
