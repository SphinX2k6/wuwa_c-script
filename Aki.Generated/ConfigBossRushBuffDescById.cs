using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011D RID: 285
	public class ConfigBossRushBuffDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x00083047 File Offset: 0x00081247
		static ConfigBossRushBuffDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushBuffDescById.CreateStaticDefaultValue), new Action(ConfigBossRushBuffDescById.ResetStaticDefaultValue));
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00083068 File Offset: 0x00081268
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushBuffDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushBuffDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushBuffDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushBuffDesc` where Id=?")
			});
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000830E7 File Offset: 0x000812E7
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushBuffDescById.LogPair = null;
			ConfigBossRushBuffDescById.HandleId = 0;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000830F5 File Offset: 0x000812F5
		public static void Init()
		{
			ConfigBossRushBuffDescById.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushBuffDescById.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushBuffDesc` where Id=?");
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00083110 File Offset: 0x00081310
		public static BossRushBuffDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushBuffDescById.HandleId, ConfigBossRushBuffDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushBuffDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushBuffDesc?(BossRushBuffDesc.GetRootAsBossRushBuffDesc(configBuffer));
				}
			}
			ConfigBossRushBuffDescById.LogPair.Clear();
			ConfigBossRushBuffDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossRushBuffDescById.HandleId, 1, p0Id, ConfigBossRushBuffDescById.LogPair) || ConfigCommon.Step(ConfigBossRushBuffDescById.HandleId, true, ConfigBossRushBuffDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushBuffDescById.HandleId, ConfigBossRushBuffDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushBuffDescById.HandleId, 0, ConfigBossRushBuffDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushBuffDescById.HandleId, ConfigBossRushBuffDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushBuffDesc rootAsBossRushBuffDesc = BossRushBuffDesc.GetRootAsBossRushBuffDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushBuffDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushBuffDescById.HandleId, ConfigBossRushBuffDescById.LogPair);
			return new BossRushBuffDesc?(rootAsBossRushBuffDesc);
		}

		// Token: 0x040007AF RID: 1967
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007B0 RID: 1968
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007B1 RID: 1969
		private const string TABLE = "BossRushBuffDesc";

		// Token: 0x040007B2 RID: 1970
		private const string COMMAND = "select BinData from `BossRushBuffDesc` where Id=?";

		// Token: 0x040007B3 RID: 1971
		private const string KEY_PREFIX = "BossRushBuffDescById";

		// Token: 0x040007B4 RID: 1972
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007B5 RID: 1973
		private static int HandleId;
	}
}
