using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011E RID: 286
	public class ConfigBossRushMapMarkByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x00083290 File Offset: 0x00081490
		static ConfigBossRushMapMarkByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBossRushMapMarkByActivityId.CreateStaticDefaultValue), new Action(ConfigBossRushMapMarkByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000832B0 File Offset: 0x000814B0
		public static void CreateStaticDefaultValue()
		{
			ConfigBossRushMapMarkByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBossRushMapMarkByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bossrushactivity.db"),
				new ValueTuple<string, object>("文件", "b.bossrush活动.xlsx"),
				new ValueTuple<string, object>("表名", "BossRushMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `BossRushMapMark` where ActivityId=?")
			});
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0008332F File Offset: 0x0008152F
		public static void ResetStaticDefaultValue()
		{
			ConfigBossRushMapMarkByActivityId.LogPair = null;
			ConfigBossRushMapMarkByActivityId.HandleId = 0;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0008333D File Offset: 0x0008153D
		public static void Init()
		{
			ConfigBossRushMapMarkByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBossRushMapMarkByActivityId.HandleId, "db_bossrushactivity.db", "select BinData from `BossRushMapMark` where ActivityId=?");
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00083358 File Offset: 0x00081558
		public static BossRushMapMark? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBossRushMapMarkByActivityId.HandleId, ConfigBossRushMapMarkByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushMapMarkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BossRushMapMark?(BossRushMapMark.GetRootAsBossRushMapMark(configBuffer));
				}
			}
			ConfigBossRushMapMarkByActivityId.LogPair.Clear();
			ConfigBossRushMapMarkByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBossRushMapMarkByActivityId.HandleId, 1, p0ActivityId, ConfigBossRushMapMarkByActivityId.LogPair) || ConfigCommon.Step(ConfigBossRushMapMarkByActivityId.HandleId, true, ConfigBossRushMapMarkByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBossRushMapMarkByActivityId.HandleId, ConfigBossRushMapMarkByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBossRushMapMarkByActivityId.HandleId, 0, ConfigBossRushMapMarkByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBossRushMapMarkByActivityId.HandleId, ConfigBossRushMapMarkByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BossRushMapMark rootAsBossRushMapMark = BossRushMapMark.GetRootAsBossRushMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BossRushMapMarkByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBossRushMapMarkByActivityId.HandleId, ConfigBossRushMapMarkByActivityId.LogPair);
			return new BossRushMapMark?(rootAsBossRushMapMark);
		}

		// Token: 0x040007B6 RID: 1974
		private const string DB = "db_bossrushactivity.db";

		// Token: 0x040007B7 RID: 1975
		private const string FILE = "b.bossrush活动.xlsx";

		// Token: 0x040007B8 RID: 1976
		private const string TABLE = "BossRushMapMark";

		// Token: 0x040007B9 RID: 1977
		private const string COMMAND = "select BinData from `BossRushMapMark` where ActivityId=?";

		// Token: 0x040007BA RID: 1978
		private const string KEY_PREFIX = "BossRushMapMarkByActivityId";

		// Token: 0x040007BB RID: 1979
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007BC RID: 1980
		private static int HandleId;
	}
}
