using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000296 RID: 662
	public class ConfigExploreProgressByArea : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F89 RID: 3977 RVA: 0x000B159F File Offset: 0x000AF79F
		static ConfigExploreProgressByArea()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressByArea.CreateStaticDefaultValue), new Action(ConfigExploreProgressByArea.ResetStaticDefaultValue));
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000B15C0 File Offset: 0x000AF7C0
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

		// Token: 0x06000F8B RID: 3979 RVA: 0x000B163F File Offset: 0x000AF83F
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressByArea.LogPair = null;
			ConfigExploreProgressByArea.HandleId = 0;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000B164D File Offset: 0x000AF84D
		public static void Init()
		{
			ConfigExploreProgressByArea.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressByArea.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgress` where Area=?");
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000B1668 File Offset: 0x000AF868
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

		// Token: 0x040011FE RID: 4606
		private const string DB = "db_explore_progress.db";

		// Token: 0x040011FF RID: 4607
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001200 RID: 4608
		private const string TABLE = "ExploreProgress";

		// Token: 0x04001201 RID: 4609
		private const string COMMAND = "select BinData from `ExploreProgress` where Area=?";

		// Token: 0x04001202 RID: 4610
		private const string KEY_PREFIX = "ExploreProgressByArea";

		// Token: 0x04001203 RID: 4611
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001204 RID: 4612
		private static int HandleId;
	}
}
