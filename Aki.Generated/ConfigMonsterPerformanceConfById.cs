using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056E RID: 1390
	public class ConfigMonsterPerformanceConfById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020A1 RID: 8353 RVA: 0x00115550 File Offset: 0x00113750
		static ConfigMonsterPerformanceConfById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterPerformanceConfById.CreateStaticDefaultValue), new Action(ConfigMonsterPerformanceConfById.ResetStaticDefaultValue));
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00115570 File Offset: 0x00113770
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

		// Token: 0x060020A3 RID: 8355 RVA: 0x001155EF File Offset: 0x001137EF
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterPerformanceConfById.LogPair = null;
			ConfigMonsterPerformanceConfById.HandleId = 0;
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x001155FD File Offset: 0x001137FD
		public static void Init()
		{
			ConfigMonsterPerformanceConfById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterPerformanceConfById.HandleId, "db_monster_info.db", "select BinData from `MonsterPerformanceConf` where MonsterPerformanceId=?");
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00115618 File Offset: 0x00113818
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

		// Token: 0x040025E6 RID: 9702
		private const string DB = "db_monster_info.db";

		// Token: 0x040025E7 RID: 9703
		private const string FILE = "g.怪物战斗配置.xlsx";

		// Token: 0x040025E8 RID: 9704
		private const string TABLE = "MonsterPerformanceConf";

		// Token: 0x040025E9 RID: 9705
		private const string COMMAND = "select BinData from `MonsterPerformanceConf` where MonsterPerformanceId=?";

		// Token: 0x040025EA RID: 9706
		private const string KEY_PREFIX = "MonsterPerformanceConfById";

		// Token: 0x040025EB RID: 9707
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025EC RID: 9708
		private static int HandleId;
	}
}
