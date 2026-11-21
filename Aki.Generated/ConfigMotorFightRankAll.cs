using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AD RID: 1453
	public class ConfigMotorFightRankAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600221B RID: 8731 RVA: 0x0011DE20 File Offset: 0x0011C020
		static ConfigMotorFightRankAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightRankAll.CreateStaticDefaultValue), new Action(ConfigMotorFightRankAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0011DE40 File Offset: 0x0011C040
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightRankAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightRankAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightRank"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightRank`")
			});
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0011DEBF File Offset: 0x0011C0BF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightRankAll.LogPair = null;
			ConfigMotorFightRankAll.HandleId = 0;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x0011DECD File Offset: 0x0011C0CD
		public static void Init()
		{
			ConfigMotorFightRankAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightRankAll.HandleId, "db_motorfight.db", "select BinData from `MotorFightRank`");
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x0011DEE8 File Offset: 0x0011C0E8
		[NullableContext(2)]
		public static IReadOnlyList<MotorFightRank> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightRankAll.HandleId, ConfigMotorFightRankAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorFightRank> readOnlyList = (IReadOnlyList<MotorFightRank>)ConfigCommon.GetConfig("MotorFightRankAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorFightRank> list = new List<MotorFightRank>();
			while (ConfigCommon.Step(ConfigMotorFightRankAll.HandleId, false, ConfigMotorFightRankAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightRankAll.HandleId, 0, ConfigMotorFightRankAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorFightRankAll.HandleId, ConfigMotorFightRankAll.LogPair);
					return null;
				}
				MotorFightRank rootAsMotorFightRank = MotorFightRank.GetRootAsMotorFightRank(new ByteBuffer(item2));
				list.Add(rootAsMotorFightRank);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorFightRankAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorFightRankAll.HandleId, ConfigMotorFightRankAll.LogPair);
			return list;
		}

		// Token: 0x0400279F RID: 10143
		private const string DB = "db_motorfight.db";

		// Token: 0x040027A0 RID: 10144
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027A1 RID: 10145
		private const string TABLE = "MotorFightRank";

		// Token: 0x040027A2 RID: 10146
		private const string COMMAND = "select BinData from `MotorFightRank`";

		// Token: 0x040027A3 RID: 10147
		private const string KEY_PREFIX = "MotorFightRankAll";

		// Token: 0x040027A4 RID: 10148
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027A5 RID: 10149
		private static int HandleId;
	}
}
