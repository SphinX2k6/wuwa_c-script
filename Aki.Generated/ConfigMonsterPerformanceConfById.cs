using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000558 RID: 1368
	public class ConfigMonsterPerformanceConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600201D RID: 8221 RVA: 0x0010EDFC File Offset: 0x0010CFFC
		static ConfigMonsterPerformanceConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterPerformanceConfById.CreateStaticDefaultValue), new Action(ConfigMonsterPerformanceConfById.ResetStaticDefaultValue));
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0010EE1C File Offset: 0x0010D01C
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterPerformanceConfById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterPerformanceConfById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物战斗配置.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterPerformanceConf"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterPerformanceConf` where MonsterPerformanceId=?")
			});
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x0010EE9B File Offset: 0x0010D09B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterPerformanceConfById.LogPair = null;
			ConfigMonsterPerformanceConfById.HandleId = 0;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0010EEA9 File Offset: 0x0010D0A9
		public static void Init()
		{
			ConfigMonsterPerformanceConfById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterPerformanceConfById.HandleId, "db_monster_info.db", "select BinData from `MonsterPerformanceConf` where MonsterPerformanceId=?");
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0010EEC4 File Offset: 0x0010D0C4
		[NullableContext(2)]
		public static IReadOnlyList<MonsterPerformanceConf> GetConfigList(int p0MonsterPerformanceId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterPerformanceConfById.HandleId, ConfigMonsterPerformanceConfById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterPerformanceConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MonsterPerformanceId);
				IReadOnlyList<MonsterPerformanceConf> readOnlyList = (IReadOnlyList<MonsterPerformanceConf>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMonsterPerformanceConfById.LogPair.Clear();
			ConfigMonsterPerformanceConfById.LogPair.Add(new ValueTuple<string, object>("MonsterPerformanceId", p0MonsterPerformanceId));
			if (!ConfigCommon.BindInt(ConfigMonsterPerformanceConfById.HandleId, 1, p0MonsterPerformanceId, ConfigMonsterPerformanceConfById.LogPair))
			{
				ConfigCommon.Reset(ConfigMonsterPerformanceConfById.HandleId, ConfigMonsterPerformanceConfById.LogPair);
				return null;
			}
			List<MonsterPerformanceConf> list = new List<MonsterPerformanceConf>();
			while (ConfigCommon.Step(ConfigMonsterPerformanceConfById.HandleId, false, ConfigMonsterPerformanceConfById.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterPerformanceConfById.HandleId, 0, ConfigMonsterPerformanceConfById.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMonsterPerformanceConfById.HandleId, ConfigMonsterPerformanceConfById.LogPair);
					return null;
				}
				MonsterPerformanceConf rootAsMonsterPerformanceConf = MonsterPerformanceConf.GetRootAsMonsterPerformanceConf(new ByteBuffer(item2));
				list.Add(rootAsMonsterPerformanceConf);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterPerformanceConfById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MonsterPerformanceId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMonsterPerformanceConfById.HandleId, ConfigMonsterPerformanceConfById.LogPair);
			return list;
		}

		// Token: 0x0400254C RID: 9548
		private const string DB = "db_monster_info.db";

		// Token: 0x0400254D RID: 9549
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x0400254E RID: 9550
		private const string TABLE = "MonsterPerformanceConf";

		// Token: 0x0400254F RID: 9551
		private const string COMMAND = "select BinData from `MonsterPerformanceConf` where MonsterPerformanceId=?";

		// Token: 0x04002550 RID: 9552
		private const string KEY_PREFIX = "MonsterPerformanceConfById";

		// Token: 0x04002551 RID: 9553
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002552 RID: 9554
		private static int HandleId;
	}
}
