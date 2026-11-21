using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011B RID: 283
	public class ConfigBossRushBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x00082C6B File Offset: 0x00080E6B
		static ConfigBossRushBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushBuffById.CreateStaticDefaultValue), new Action(ConfigBossRushBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00082C8C File Offset: 0x00080E8C
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushBuff` where Id=?")
			});
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00082D0B File Offset: 0x00080F0B
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushBuffById.LogPair = null;
			ConfigBossRushBuffById.HandleId = 0;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00082D19 File Offset: 0x00080F19
		public static void Init()
		{
			ConfigBossRushBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushBuffById.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushBuff` where Id=?");
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00082D34 File Offset: 0x00080F34
		public static BossRushBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushBuffById.HandleId, ConfigBossRushBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushBuff?(BossRushBuff.GetRootAsBossRushBuff(configBuffer));
				}
			}
			ConfigBossRushBuffById.LogPair.Clear();
			ConfigBossRushBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBossRushBuffById.HandleId, 1, p0Id, ConfigBossRushBuffById.LogPair) || ConfigCommon.Step(ConfigBossRushBuffById.HandleId, true, ConfigBossRushBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushBuffById.HandleId, ConfigBossRushBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushBuffById.HandleId, 0, ConfigBossRushBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushBuffById.HandleId, ConfigBossRushBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushBuff rootAsBossRushBuff = BossRushBuff.GetRootAsBossRushBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushBuffById.HandleId, ConfigBossRushBuffById.LogPair);
			return new BossRushBuff?(rootAsBossRushBuff);
		}

		// Token: 0x040007A1 RID: 1953
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007A2 RID: 1954
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007A3 RID: 1955
		private const string TABLE = "BossRushBuff";

		// Token: 0x040007A4 RID: 1956
		private const string COMMAND = "select BinData from `BossRushBuff` where Id=?";

		// Token: 0x040007A5 RID: 1957
		private const string KEY_PREFIX = "BossRushBuffById";

		// Token: 0x040007A6 RID: 1958
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007A7 RID: 1959
		private static int HandleId;
	}
}
