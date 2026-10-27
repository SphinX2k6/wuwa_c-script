using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D4 RID: 212
	public class ConfigBabelTowerDifficultyByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004F9 RID: 1273 RVA: 0x00075BE7 File Offset: 0x00073DE7
		static ConfigBabelTowerDifficultyByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDifficultyByActivityId.CreateStaticDefaultValue), new Action(ConfigBabelTowerDifficultyByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00075C08 File Offset: 0x00073E08
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

		// Token: 0x060004FB RID: 1275 RVA: 0x00075C87 File Offset: 0x00073E87
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDifficultyByActivityId.LogPair = null;
			ConfigBabelTowerDifficultyByActivityId.HandleId = 0;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00075C95 File Offset: 0x00073E95
		public static void Init()
		{
			ConfigBabelTowerDifficultyByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDifficultyByActivityId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDifficulty` where ActivityId=?");
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00075CB0 File Offset: 0x00073EB0
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

		// Token: 0x040005B0 RID: 1456
		private const string DB = "db_babeltower.db";

		// Token: 0x040005B1 RID: 1457
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005B2 RID: 1458
		private const string TABLE = "BabelTowerDifficulty";

		// Token: 0x040005B3 RID: 1459
		private const string COMMAND = "select BinData from `BabelTowerDifficulty` where ActivityId=?";

		// Token: 0x040005B4 RID: 1460
		private const string KEY_PREFIX = "BabelTowerDifficultyByActivityId";

		// Token: 0x040005B5 RID: 1461
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005B6 RID: 1462
		private static int HandleId;
	}
}
