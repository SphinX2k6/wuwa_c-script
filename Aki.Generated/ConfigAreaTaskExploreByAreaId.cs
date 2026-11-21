using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B3 RID: 179
	public class ConfigAreaTaskExploreByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x00074EA5 File Offset: 0x000730A5
		static ConfigAreaTaskExploreByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTaskExploreByAreaId.CreateStaticDefaultValue), new Action(ConfigAreaTaskExploreByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00074EC4 File Offset: 0x000730C4
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaTaskExploreByAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaTaskExploreByAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "AreaTaskExplore"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaTaskExplore` where Area=?")
			});
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00074F43 File Offset: 0x00073143
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTaskExploreByAreaId.LogPair = null;
			ConfigAreaTaskExploreByAreaId.HandleId = 0;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00074F51 File Offset: 0x00073151
		public static void Init()
		{
			ConfigAreaTaskExploreByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTaskExploreByAreaId.HandleId, "db_explore_progress.db", "select BinData from `AreaTaskExplore` where Area=?");
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00074F6C File Offset: 0x0007316C
		[NullableContext(2)]
		public static IReadOnlyList<AreaTaskExplore> GetConfigList(int p0Area, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaTaskExploreByAreaId.HandleId, ConfigAreaTaskExploreByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTaskExploreByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Area);
				IReadOnlyList<AreaTaskExplore> readOnlyList = (IReadOnlyList<AreaTaskExplore>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAreaTaskExploreByAreaId.LogPair.Clear();
			ConfigAreaTaskExploreByAreaId.LogPair.Add(new ValueTuple<string, object>("Area", p0Area));
			if (!ConfigCommon.BindInt(ConfigAreaTaskExploreByAreaId.HandleId, 1, p0Area, ConfigAreaTaskExploreByAreaId.LogPair))
			{
				ConfigCommon.Reset(ConfigAreaTaskExploreByAreaId.HandleId, ConfigAreaTaskExploreByAreaId.LogPair);
				return null;
			}
			List<AreaTaskExplore> list = new List<AreaTaskExplore>();
			while (ConfigCommon.Step(ConfigAreaTaskExploreByAreaId.HandleId, false, ConfigAreaTaskExploreByAreaId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaTaskExploreByAreaId.HandleId, 0, ConfigAreaTaskExploreByAreaId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaTaskExploreByAreaId.HandleId, ConfigAreaTaskExploreByAreaId.LogPair);
					return null;
				}
				AreaTaskExplore rootAsAreaTaskExplore = AreaTaskExplore.GetRootAsAreaTaskExplore(new ByteBuffer(item2));
				list.Add(rootAsAreaTaskExplore);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaTaskExploreByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Area);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaTaskExploreByAreaId.HandleId, ConfigAreaTaskExploreByAreaId.LogPair);
			return list;
		}

		// Token: 0x040004C9 RID: 1225
		private const string DB = "db_explore_progress.db";

		// Token: 0x040004CA RID: 1226
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x040004CB RID: 1227
		private const string TABLE = "AreaTaskExplore";

		// Token: 0x040004CC RID: 1228
		private const string COMMAND = "select BinData from `AreaTaskExplore` where Area=?";

		// Token: 0x040004CD RID: 1229
		private const string KEY_PREFIX = "AreaTaskExploreByAreaId";

		// Token: 0x040004CE RID: 1230
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004CF RID: 1231
		private static int HandleId;
	}
}
