using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AA RID: 682
	public class ConfigExploreProgressByArea : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001001 RID: 4097 RVA: 0x000B7863 File Offset: 0x000B5A63
		static ConfigExploreProgressByArea()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressByArea.CreateStaticDefaultValue), new Action(ConfigExploreProgressByArea.ResetStaticDefaultValue));
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000B7884 File Offset: 0x000B5A84
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreProgressByArea.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreProgressByArea.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreProgress"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreProgress` where Area=?")
			});
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000B7903 File Offset: 0x000B5B03
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressByArea.LogPair = null;
			ConfigExploreProgressByArea.HandleId = 0;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x000B7911 File Offset: 0x000B5B11
		public static void Init()
		{
			ConfigExploreProgressByArea.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressByArea.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgress` where Area=?");
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000B792C File Offset: 0x000B5B2C
		[NullableContext(2)]
		public static IReadOnlyList<ExploreProgress> GetConfigList(int p0Area, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreProgressByArea.HandleId, ConfigExploreProgressByArea.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreProgressByArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Area);
				IReadOnlyList<ExploreProgress> readOnlyList = (IReadOnlyList<ExploreProgress>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigExploreProgressByArea.LogPair.Clear();
			ConfigExploreProgressByArea.LogPair.Add(new ValueTuple<string, object>("Area", p0Area));
			if (!ConfigCommon.BindInt(ConfigExploreProgressByArea.HandleId, 1, p0Area, ConfigExploreProgressByArea.LogPair))
			{
				ConfigCommon.Reset(ConfigExploreProgressByArea.HandleId, ConfigExploreProgressByArea.LogPair);
				return null;
			}
			List<ExploreProgress> list = new List<ExploreProgress>();
			while (ConfigCommon.Step(ConfigExploreProgressByArea.HandleId, false, ConfigExploreProgressByArea.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreProgressByArea.HandleId, 0, ConfigExploreProgressByArea.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreProgressByArea.HandleId, ConfigExploreProgressByArea.LogPair);
					return null;
				}
				ExploreProgress rootAsExploreProgress = ExploreProgress.GetRootAsExploreProgress(new ByteBuffer(item2));
				list.Add(rootAsExploreProgress);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreProgressByArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Area);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreProgressByArea.HandleId, ConfigExploreProgressByArea.LogPair);
			return list;
		}

		// Token: 0x0400128A RID: 4746
		private const string DB = "db_explore_progress.db";

		// Token: 0x0400128B RID: 4747
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x0400128C RID: 4748
		private const string TABLE = "ExploreProgress";

		// Token: 0x0400128D RID: 4749
		private const string COMMAND = "select BinData from `ExploreProgress` where Area=?";

		// Token: 0x0400128E RID: 4750
		private const string KEY_PREFIX = "ExploreProgressByArea";

		// Token: 0x0400128F RID: 4751
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001290 RID: 4752
		private static int HandleId;
	}
}
