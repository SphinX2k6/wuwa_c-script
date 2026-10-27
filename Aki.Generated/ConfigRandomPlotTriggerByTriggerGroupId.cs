using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AF RID: 1967
	public class ConfigRandomPlotTriggerByTriggerGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E2C RID: 11820 RVA: 0x0015E504 File Offset: 0x0015C704
		static ConfigRandomPlotTriggerByTriggerGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRandomPlotTriggerByTriggerGroupId.CreateStaticDefaultValue), new Action(ConfigRandomPlotTriggerByTriggerGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x0015E524 File Offset: 0x0015C724
		public static void CreateStaticDefaultValue()
		{
			ConfigRandomPlotTriggerByTriggerGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRandomPlotTriggerByTriggerGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_randomplot.db"),
				new ValueTuple<string, object>("文件", "x.系统随机剧情.xlsx"),
				new ValueTuple<string, object>("表名", "RandomPlotTrigger"),
				new ValueTuple<string, object>("语句", "select BinData from `RandomPlotTrigger` where TriggerGroupId=?")
			});
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x0015E5A3 File Offset: 0x0015C7A3
		public static void ResetStaticDefaultValue()
		{
			ConfigRandomPlotTriggerByTriggerGroupId.LogPair = null;
			ConfigRandomPlotTriggerByTriggerGroupId.HandleId = 0;
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0015E5B1 File Offset: 0x0015C7B1
		public static void Init()
		{
			ConfigRandomPlotTriggerByTriggerGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, "db_randomplot.db", "select BinData from `RandomPlotTrigger` where TriggerGroupId=?");
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x0015E5CC File Offset: 0x0015C7CC
		[NullableContext(2)]
		public static IReadOnlyList<RandomPlotTrigger> GetConfigList(int p0TriggerGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, ConfigRandomPlotTriggerByTriggerGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RandomPlotTriggerByTriggerGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TriggerGroupId);
				IReadOnlyList<RandomPlotTrigger> readOnlyList = (IReadOnlyList<RandomPlotTrigger>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRandomPlotTriggerByTriggerGroupId.LogPair.Clear();
			ConfigRandomPlotTriggerByTriggerGroupId.LogPair.Add(new ValueTuple<string, object>("TriggerGroupId", p0TriggerGroupId));
			if (!ConfigCommon.BindInt(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, 1, p0TriggerGroupId, ConfigRandomPlotTriggerByTriggerGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, ConfigRandomPlotTriggerByTriggerGroupId.LogPair);
				return null;
			}
			List<RandomPlotTrigger> list = new List<RandomPlotTrigger>();
			while (ConfigCommon.Step(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, false, ConfigRandomPlotTriggerByTriggerGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, 0, ConfigRandomPlotTriggerByTriggerGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, ConfigRandomPlotTriggerByTriggerGroupId.LogPair);
					return null;
				}
				RandomPlotTrigger rootAsRandomPlotTrigger = RandomPlotTrigger.GetRootAsRandomPlotTrigger(new ByteBuffer(item2));
				list.Add(rootAsRandomPlotTrigger);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RandomPlotTriggerByTriggerGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TriggerGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, ConfigRandomPlotTriggerByTriggerGroupId.LogPair);
			return list;
		}

		// Token: 0x040035AF RID: 13743
		private const string DB = "db_randomplot.db";

		// Token: 0x040035B0 RID: 13744
		private const string FILE = "x.系统随机剧情.xlsx";

		// Token: 0x040035B1 RID: 13745
		private const string TABLE = "RandomPlotTrigger";

		// Token: 0x040035B2 RID: 13746
		private const string COMMAND = "select BinData from `RandomPlotTrigger` where TriggerGroupId=?";

		// Token: 0x040035B3 RID: 13747
		private const string KEY_PREFIX = "RandomPlotTriggerByTriggerGroupId";

		// Token: 0x040035B4 RID: 13748
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035B5 RID: 13749
		private static int HandleId;
	}
}
