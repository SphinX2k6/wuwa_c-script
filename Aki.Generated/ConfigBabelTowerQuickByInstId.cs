using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DB RID: 219
	public class ConfigBabelTowerQuickByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x00076ABC File Offset: 0x00074CBC
		static ConfigBabelTowerQuickByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerQuickByInstId.CreateStaticDefaultValue), new Action(ConfigBabelTowerQuickByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00076ADC File Offset: 0x00074CDC
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerQuickByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerQuickByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerQuick"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerQuick` where InstId=?")
			});
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00076B5B File Offset: 0x00074D5B
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerQuickByInstId.LogPair = null;
			ConfigBabelTowerQuickByInstId.HandleId = 0;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00076B69 File Offset: 0x00074D69
		public static void Init()
		{
			ConfigBabelTowerQuickByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerQuickByInstId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerQuick` where InstId=?");
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00076B84 File Offset: 0x00074D84
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerQuick> GetConfigList(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerQuickByInstId.HandleId, ConfigBabelTowerQuickByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerQuickByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				IReadOnlyList<BabelTowerQuick> readOnlyList = (IReadOnlyList<BabelTowerQuick>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBabelTowerQuickByInstId.LogPair.Clear();
			ConfigBabelTowerQuickByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigBabelTowerQuickByInstId.HandleId, 1, p0InstId, ConfigBabelTowerQuickByInstId.LogPair))
			{
				ConfigCommon.Reset(ConfigBabelTowerQuickByInstId.HandleId, ConfigBabelTowerQuickByInstId.LogPair);
				return null;
			}
			List<BabelTowerQuick> list = new List<BabelTowerQuick>();
			while (ConfigCommon.Step(ConfigBabelTowerQuickByInstId.HandleId, false, ConfigBabelTowerQuickByInstId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerQuickByInstId.HandleId, 0, ConfigBabelTowerQuickByInstId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerQuickByInstId.HandleId, ConfigBabelTowerQuickByInstId.LogPair);
					return null;
				}
				BabelTowerQuick rootAsBabelTowerQuick = BabelTowerQuick.GetRootAsBabelTowerQuick(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerQuick);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerQuickByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerQuickByInstId.HandleId, ConfigBabelTowerQuickByInstId.LogPair);
			return list;
		}

		// Token: 0x040005E1 RID: 1505
		private const string DB = "db_babeltower.db";

		// Token: 0x040005E2 RID: 1506
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005E3 RID: 1507
		private const string TABLE = "BabelTowerQuick";

		// Token: 0x040005E4 RID: 1508
		private const string COMMAND = "select BinData from `BabelTowerQuick` where InstId=?";

		// Token: 0x040005E5 RID: 1509
		private const string KEY_PREFIX = "BabelTowerQuickByInstId";

		// Token: 0x040005E6 RID: 1510
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005E7 RID: 1511
		private static int HandleId;
	}
}
