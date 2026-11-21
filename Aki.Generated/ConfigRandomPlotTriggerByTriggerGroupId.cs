using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C9 RID: 1993
	public class ConfigRandomPlotTriggerByTriggerGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EC8 RID: 11976 RVA: 0x00165410 File Offset: 0x00163610
		static ConfigRandomPlotTriggerByTriggerGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRandomPlotTriggerByTriggerGroupId.CreateStaticDefaultValue), new Action(ConfigRandomPlotTriggerByTriggerGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00165430 File Offset: 0x00163630
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

		// Token: 0x06002ECA RID: 11978 RVA: 0x001654AF File Offset: 0x001636AF
		public static void ResetStaticDefaultValue()
		{
			ConfigRandomPlotTriggerByTriggerGroupId.LogPair = null;
			ConfigRandomPlotTriggerByTriggerGroupId.HandleId = 0;
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x001654BD File Offset: 0x001636BD
		public static void Init()
		{
			ConfigRandomPlotTriggerByTriggerGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigRandomPlotTriggerByTriggerGroupId.HandleId, "db_randomplot.db", "select BinData from `RandomPlotTrigger` where TriggerGroupId=?");
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x001654D8 File Offset: 0x001636D8
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

		// Token: 0x04003665 RID: 13925
		private const string DB = "db_randomplot.db";

		// Token: 0x04003666 RID: 13926
		private const string FILE = "x.系统随机剧情.xlsx";

		// Token: 0x04003667 RID: 13927
		private const string TABLE = "RandomPlotTrigger";

		// Token: 0x04003668 RID: 13928
		private const string COMMAND = "select BinData from `RandomPlotTrigger` where TriggerGroupId=?";

		// Token: 0x04003669 RID: 13929
		private const string KEY_PREFIX = "RandomPlotTriggerByTriggerGroupId";

		// Token: 0x0400366A RID: 13930
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400366B RID: 13931
		private static int HandleId;
	}
}
