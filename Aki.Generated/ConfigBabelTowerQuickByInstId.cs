using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EA RID: 234
	public class ConfigBabelTowerQuickByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x0007C420 File Offset: 0x0007A620
		static ConfigBabelTowerQuickByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerQuickByInstId.CreateStaticDefaultValue), new Action(ConfigBabelTowerQuickByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0007C440 File Offset: 0x0007A640
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

		// Token: 0x0600057F RID: 1407 RVA: 0x0007C4BF File Offset: 0x0007A6BF
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerQuickByInstId.LogPair = null;
			ConfigBabelTowerQuickByInstId.HandleId = 0;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0007C4CD File Offset: 0x0007A6CD
		public static void Init()
		{
			ConfigBabelTowerQuickByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerQuickByInstId.HandleId, "db_babeltower.db", "select BinData from `BabelTowerQuick` where InstId=?");
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0007C4E8 File Offset: 0x0007A6E8
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

		// Token: 0x0400064A RID: 1610
		private const string DB = "db_babeltower.db";

		// Token: 0x0400064B RID: 1611
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400064C RID: 1612
		private const string TABLE = "BabelTowerQuick";

		// Token: 0x0400064D RID: 1613
		private const string COMMAND = "select BinData from `BabelTowerQuick` where InstId=?";

		// Token: 0x0400064E RID: 1614
		private const string KEY_PREFIX = "BabelTowerQuickByInstId";

		// Token: 0x0400064F RID: 1615
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000650 RID: 1616
		private static int HandleId;
	}
}
