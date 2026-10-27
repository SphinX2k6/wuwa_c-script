using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000322 RID: 802
	public class ConfigFloroRanchRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012D1 RID: 4817 RVA: 0x000C3C54 File Offset: 0x000C1E54
		static ConfigFloroRanchRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigFloroRanchRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000C3C74 File Offset: 0x000C1E74
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchReward"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchReward` where ActivityId=?")
			});
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000C3CF3 File Offset: 0x000C1EF3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRewardByActivityId.LogPair = null;
			ConfigFloroRanchRewardByActivityId.HandleId = 0;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000C3D01 File Offset: 0x000C1F01
		public static void Init()
		{
			ConfigFloroRanchRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRewardByActivityId.HandleId, "db_flororanch.db", "select BinData from `FloroRanchReward` where ActivityId=?");
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000C3D1C File Offset: 0x000C1F1C
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRewardByActivityId.HandleId, ConfigFloroRanchRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FloroRanchReward> readOnlyList = (IReadOnlyList<FloroRanchReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFloroRanchRewardByActivityId.LogPair.Clear();
			ConfigFloroRanchRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFloroRanchRewardByActivityId.HandleId, 1, p0ActivityId, ConfigFloroRanchRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFloroRanchRewardByActivityId.HandleId, ConfigFloroRanchRewardByActivityId.LogPair);
				return null;
			}
			List<FloroRanchReward> list = new List<FloroRanchReward>();
			while (ConfigCommon.Step(ConfigFloroRanchRewardByActivityId.HandleId, false, ConfigFloroRanchRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRewardByActivityId.HandleId, 0, ConfigFloroRanchRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchRewardByActivityId.HandleId, ConfigFloroRanchRewardByActivityId.LogPair);
					return null;
				}
				FloroRanchReward rootAsFloroRanchReward = FloroRanchReward.GetRootAsFloroRanchReward(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchRewardByActivityId.HandleId, ConfigFloroRanchRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x040015D2 RID: 5586
		private const string DB = "db_flororanch.db";

		// Token: 0x040015D3 RID: 5587
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015D4 RID: 5588
		private const string TABLE = "FloroRanchReward";

		// Token: 0x040015D5 RID: 5589
		private const string COMMAND = "select BinData from `FloroRanchReward` where ActivityId=?";

		// Token: 0x040015D6 RID: 5590
		private const string KEY_PREFIX = "FloroRanchRewardByActivityId";

		// Token: 0x040015D7 RID: 5591
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015D8 RID: 5592
		private static int HandleId;
	}
}
