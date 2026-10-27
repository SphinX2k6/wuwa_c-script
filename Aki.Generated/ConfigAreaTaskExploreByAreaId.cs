using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AB RID: 171
	public class ConfigAreaTaskExploreByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000403 RID: 1027 RVA: 0x000705F1 File Offset: 0x0006E7F1
		static ConfigAreaTaskExploreByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTaskExploreByAreaId.CreateStaticDefaultValue), new Action(ConfigAreaTaskExploreByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00070610 File Offset: 0x0006E810
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

		// Token: 0x06000405 RID: 1029 RVA: 0x0007068F File Offset: 0x0006E88F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTaskExploreByAreaId.LogPair = null;
			ConfigAreaTaskExploreByAreaId.HandleId = 0;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0007069D File Offset: 0x0006E89D
		public static void Init()
		{
			ConfigAreaTaskExploreByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTaskExploreByAreaId.HandleId, "db_explore_progress.db", "select BinData from `AreaTaskExplore` where Area=?");
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000706B8 File Offset: 0x0006E8B8
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

		// Token: 0x04000491 RID: 1169
		private const string DB = "db_explore_progress.db";

		// Token: 0x04000492 RID: 1170
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04000493 RID: 1171
		private const string TABLE = "AreaTaskExplore";

		// Token: 0x04000494 RID: 1172
		private const string COMMAND = "select BinData from `AreaTaskExplore` where Area=?";

		// Token: 0x04000495 RID: 1173
		private const string KEY_PREFIX = "AreaTaskExploreByAreaId";

		// Token: 0x04000496 RID: 1174
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000497 RID: 1175
		private static int HandleId;
	}
}
