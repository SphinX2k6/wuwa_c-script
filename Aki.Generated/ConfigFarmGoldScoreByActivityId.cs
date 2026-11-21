using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C7 RID: 711
	public class ConfigFarmGoldScoreByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010AF RID: 4271 RVA: 0x000BB3FF File Offset: 0x000B95FF
		static ConfigFarmGoldScoreByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldScoreByActivityId.CreateStaticDefaultValue), new Action(ConfigFarmGoldScoreByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x000BB420 File Offset: 0x000B9620
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

		// Token: 0x060010B1 RID: 4273 RVA: 0x000BB49F File Offset: 0x000B969F
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldScoreByActivityId.LogPair = null;
			ConfigFarmGoldScoreByActivityId.HandleId = 0;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x000BB4AD File Offset: 0x000B96AD
		public static void Init()
		{
			ConfigFarmGoldScoreByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldScoreByActivityId.HandleId, "db_farmgold.db", "select BinData from `FarmGoldScore` where ActivityId=?");
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x000BB4C8 File Offset: 0x000B96C8
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

		// Token: 0x04001355 RID: 4949
		private const string DB = "db_farmgold.db";

		// Token: 0x04001356 RID: 4950
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x04001357 RID: 4951
		private const string TABLE = "FarmGoldScore";

		// Token: 0x04001358 RID: 4952
		private const string COMMAND = "select BinData from `FarmGoldScore` where ActivityId=?";

		// Token: 0x04001359 RID: 4953
		private const string KEY_PREFIX = "FarmGoldScoreByActivityId";

		// Token: 0x0400135A RID: 4954
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400135B RID: 4955
		private static int HandleId;
	}
}
