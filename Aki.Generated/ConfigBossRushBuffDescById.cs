using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010E RID: 270
	public class ConfigBossRushBuffDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000655 RID: 1621 RVA: 0x0007D6E3 File Offset: 0x0007B8E3
		static ConfigBossRushBuffDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushBuffDescById.CreateStaticDefaultValue), new Action(ConfigBossRushBuffDescById.ResetStaticDefaultValue));
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0007D704 File Offset: 0x0007B904
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

		// Token: 0x06000657 RID: 1623 RVA: 0x0007D783 File Offset: 0x0007B983
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushBuffDescById.LogPair = null;
			ConfigBossRushBuffDescById.HandleId = 0;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0007D791 File Offset: 0x0007B991
		public static void Init()
		{
			ConfigBossRushBuffDescById.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushBuffDescById.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushBuffDesc` where Id=?");
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0007D7AC File Offset: 0x0007B9AC
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

		// Token: 0x04000746 RID: 1862
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x04000747 RID: 1863
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x04000748 RID: 1864
		private const string TABLE = "BossRushBuffDesc";

		// Token: 0x04000749 RID: 1865
		private const string COMMAND = "select BinData from `BossRushBuffDesc` where Id=?";

		// Token: 0x0400074A RID: 1866
		private const string KEY_PREFIX = "BossRushBuffDescById";

		// Token: 0x0400074B RID: 1867
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400074C RID: 1868
		private static int HandleId;
	}
}
