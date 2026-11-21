using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E3 RID: 227
	public class ConfigBabelTowerDifficultyByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x0007B54B File Offset: 0x0007974B
		static ConfigBabelTowerDifficultyByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDifficultyByActivityId.CreateStaticDefaultValue), new Action(ConfigBabelTowerDifficultyByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0007B56C File Offset: 0x0007976C
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDifficultyByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDifficulty` where ActivityId=?")
			});
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0007B5EB File Offset: 0x000797EB
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyByActivityId.LogPair = null;
			ConfigBabelTowerDifficultyByActivityId.HandleId = 0;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0007B5F9 File Offset: 0x000797F9
		public static void Init()
		{
			ConfigBabelTowerDifficultyByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDifficultyByActivityId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDifficulty` where ActivityId=?");
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0007B614 File Offset: 0x00079814
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerDifficulty> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDifficultyByActivityId.HandleId, ConfigBabelTowerDifficultyByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDifficultyByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<BabelTowerDifficulty> readOnlyList = (IReadOnlyList<BabelTowerDifficulty>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBabelTowerDifficultyByActivityId.LogPair.Clear();
			ConfigBabelTowerDifficultyByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigBabelTowerDifficultyByActivityId.HandleId, 1, p0ActivityId, ConfigBabelTowerDifficultyByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigBabelTowerDifficultyByActivityId.HandleId, ConfigBabelTowerDifficultyByActivityId.LogPair);
				return null;
			}
			List<BabelTowerDifficulty> list = new List<BabelTowerDifficulty>();
			while (ConfigCommon.Step(ConfigBabelTowerDifficultyByActivityId.HandleId, false, ConfigBabelTowerDifficultyByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDifficultyByActivityId.HandleId, 0, ConfigBabelTowerDifficultyByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerDifficultyByActivityId.HandleId, ConfigBabelTowerDifficultyByActivityId.LogPair);
					return null;
				}
				BabelTowerDifficulty rootAsBabelTowerDifficulty = BabelTowerDifficulty.GetRootAsBabelTowerDifficulty(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerDifficulty);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDifficultyByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerDifficultyByActivityId.HandleId, ConfigBabelTowerDifficultyByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000619 RID: 1561
		private const string DB = "db_babeltower.db";

		// Token: 0x0400061A RID: 1562
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400061B RID: 1563
		private const string TABLE = "BabelTowerDifficulty";

		// Token: 0x0400061C RID: 1564
		private const string COMMAND = "select BinData from `BabelTowerDifficulty` where ActivityId=?";

		// Token: 0x0400061D RID: 1565
		private const string KEY_PREFIX = "BabelTowerDifficultyByActivityId";

		// Token: 0x0400061E RID: 1566
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400061F RID: 1567
		private static int HandleId;
	}
}
