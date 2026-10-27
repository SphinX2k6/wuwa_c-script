using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010C RID: 268
	public class ConfigBossRushBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0007D307 File Offset: 0x0007B507
		static ConfigBossRushBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushBuffById.CreateStaticDefaultValue), new Action(ConfigBossRushBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0007D328 File Offset: 0x0007B528
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

		// Token: 0x0600064B RID: 1611 RVA: 0x0007D3A7 File Offset: 0x0007B5A7
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushBuffById.LogPair = null;
			ConfigBossRushBuffById.HandleId = 0;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0007D3B5 File Offset: 0x0007B5B5
		public static void Init()
		{
			ConfigBossRushBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushBuffById.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushBuff` where Id=?");
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0007D3D0 File Offset: 0x0007B5D0
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

		// Token: 0x04000738 RID: 1848
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000739 RID: 1849
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x0400073A RID: 1850
		private const string TABLE = "BossRushBuff";

		// Token: 0x0400073B RID: 1851
		private const string COMMAND = "select BinData from `BossRushBuff` where Id=?";

		// Token: 0x0400073C RID: 1852
		private const string KEY_PREFIX = "BossRushBuffById";

		// Token: 0x0400073D RID: 1853
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400073E RID: 1854
		private static int HandleId;
	}
}
