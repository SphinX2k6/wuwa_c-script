using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B2 RID: 690
	public class ConfigFarmGoldScoreByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x000B4EF3 File Offset: 0x000B30F3
		static ConfigFarmGoldScoreByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldScoreByActivityId.CreateStaticDefaultValue), new Action(ConfigFarmGoldScoreByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000B4F14 File Offset: 0x000B3114
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldScoreByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldScoreByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldScore"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldScore` where ActivityId=?")
			});
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000B4F93 File Offset: 0x000B3193
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldScoreByActivityId.LogPair = null;
			ConfigFarmGoldScoreByActivityId.HandleId = 0;
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000B4FA1 File Offset: 0x000B31A1
		public static void Init()
		{
			ConfigFarmGoldScoreByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldScoreByActivityId.HandleId, "db_farmgold.db", "select BinData from `FarmGoldScore` where ActivityId=?");
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000B4FBC File Offset: 0x000B31BC
		[NullableContext(2)]
		public static IReadOnlyList<FarmGoldScore> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldScoreByActivityId.HandleId, ConfigFarmGoldScoreByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldScoreByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FarmGoldScore> readOnlyList = (IReadOnlyList<FarmGoldScore>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFarmGoldScoreByActivityId.LogPair.Clear();
			ConfigFarmGoldScoreByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFarmGoldScoreByActivityId.HandleId, 1, p0ActivityId, ConfigFarmGoldScoreByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFarmGoldScoreByActivityId.HandleId, ConfigFarmGoldScoreByActivityId.LogPair);
				return null;
			}
			List<FarmGoldScore> list = new List<FarmGoldScore>();
			while (ConfigCommon.Step(ConfigFarmGoldScoreByActivityId.HandleId, false, ConfigFarmGoldScoreByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldScoreByActivityId.HandleId, 0, ConfigFarmGoldScoreByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFarmGoldScoreByActivityId.HandleId, ConfigFarmGoldScoreByActivityId.LogPair);
					return null;
				}
				FarmGoldScore rootAsFarmGoldScore = FarmGoldScore.GetRootAsFarmGoldScore(new ByteBuffer(item2));
				list.Add(rootAsFarmGoldScore);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldScoreByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFarmGoldScoreByActivityId.HandleId, ConfigFarmGoldScoreByActivityId.LogPair);
			return list;
		}

		// Token: 0x040012C2 RID: 4802
		private const string DB = "db_farmgold.db";

		// Token: 0x040012C3 RID: 4803
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x040012C4 RID: 4804
		private const string TABLE = "FarmGoldScore";

		// Token: 0x040012C5 RID: 4805
		private const string COMMAND = "select BinData from `FarmGoldScore` where ActivityId=?";

		// Token: 0x040012C6 RID: 4806
		private const string KEY_PREFIX = "FarmGoldScoreByActivityId";

		// Token: 0x040012C7 RID: 4807
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012C8 RID: 4808
		private static int HandleId;
	}
}
