using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A71 RID: 2673
	public class ConfigSurvivorsLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EBA RID: 16058 RVA: 0x001BF51C File Offset: 0x001BD71C
		static ConfigSurvivorsLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigSurvivorsLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x001BF53C File Offset: 0x001BD73C
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsLevelByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsLevelByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsLevel` where ActivityId=?")
			});
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x001BF5BB File Offset: 0x001BD7BB
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsLevelByActivityId.LogPair = null;
			ConfigSurvivorsLevelByActivityId.HandleId = 0;
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x001BF5C9 File Offset: 0x001BD7C9
		public static void Init()
		{
			ConfigSurvivorsLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsLevelByActivityId.HandleId, "db_survivors.db", "select BinData from `SurvivorsLevel` where ActivityId=?");
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x001BF5E4 File Offset: 0x001BD7E4
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsLevel> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsLevelByActivityId.HandleId, ConfigSurvivorsLevelByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SurvivorsLevel> readOnlyList = (IReadOnlyList<SurvivorsLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsLevelByActivityId.LogPair.Clear();
			ConfigSurvivorsLevelByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSurvivorsLevelByActivityId.HandleId, 1, p0ActivityId, ConfigSurvivorsLevelByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsLevelByActivityId.HandleId, ConfigSurvivorsLevelByActivityId.LogPair);
				return null;
			}
			List<SurvivorsLevel> list = new List<SurvivorsLevel>();
			while (ConfigCommon.Step(ConfigSurvivorsLevelByActivityId.HandleId, false, ConfigSurvivorsLevelByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsLevelByActivityId.HandleId, 0, ConfigSurvivorsLevelByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsLevelByActivityId.HandleId, ConfigSurvivorsLevelByActivityId.LogPair);
					return null;
				}
				SurvivorsLevel rootAsSurvivorsLevel = SurvivorsLevel.GetRootAsSurvivorsLevel(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsLevelByActivityId.HandleId, ConfigSurvivorsLevelByActivityId.LogPair);
			return list;
		}

		// Token: 0x040048FD RID: 18685
		private const string DB = "db_survivors.db";

		// Token: 0x040048FE RID: 18686
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x040048FF RID: 18687
		private const string TABLE = "SurvivorsLevel";

		// Token: 0x04004900 RID: 18688
		private const string COMMAND = "select BinData from `SurvivorsLevel` where ActivityId=?";

		// Token: 0x04004901 RID: 18689
		private const string KEY_PREFIX = "SurvivorsLevelByActivityId";

		// Token: 0x04004902 RID: 18690
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004903 RID: 18691
		private static int HandleId;
	}
}
