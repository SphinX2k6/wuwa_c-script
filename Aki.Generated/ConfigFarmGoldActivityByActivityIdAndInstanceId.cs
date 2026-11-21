using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C0 RID: 704
	public class ConfigFarmGoldActivityByActivityIdAndInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001085 RID: 4229 RVA: 0x000BA527 File Offset: 0x000B8727
		static ConfigFarmGoldActivityByActivityIdAndInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldActivityByActivityIdAndInstanceId.CreateStaticDefaultValue), new Action(ConfigFarmGoldActivityByActivityIdAndInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x000BA548 File Offset: 0x000B8748
		public static void CreateStaticDefaultValue()
		{
			ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_farmgold.db"),
				new ValueTuple<string, object>("文件", "b.爆金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "FarmGoldActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `FarmGoldActivity` where ActivityId=? And InstId=?")
			});
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x000BA5C7 File Offset: 0x000B87C7
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair = null;
			ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId = 0;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x000BA5D5 File Offset: 0x000B87D5
		public static void Init()
		{
			ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, "db_farmgold.db", "select BinData from `FarmGoldActivity` where ActivityId=? And InstId=?");
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000BA5F0 File Offset: 0x000B87F0
		[NullableContext(2)]
		public static IReadOnlyList<FarmGoldActivity> GetConfigList(int p0ActivityId, int p1InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldActivityByActivityIdAndInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstId);
				IReadOnlyList<FarmGoldActivity> readOnlyList = (IReadOnlyList<FarmGoldActivity>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair.Clear();
			ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair.Add(new ValueTuple<string, object>("InstId", p1InstId));
			if (!ConfigCommon.BindInt(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, 1, p0ActivityId, ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair) || !ConfigCommon.BindInt(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, 2, p1InstId, ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair))
			{
				ConfigCommon.Reset(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair);
				return null;
			}
			List<FarmGoldActivity> list = new List<FarmGoldActivity>();
			while (ConfigCommon.Step(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, false, ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, 0, ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair);
					return null;
				}
				FarmGoldActivity rootAsFarmGoldActivity = FarmGoldActivity.GetRootAsFarmGoldActivity(new ByteBuffer(item2));
				list.Add(rootAsFarmGoldActivity);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FarmGoldActivityByActivityIdAndInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1InstId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair);
			return list;
		}

		// Token: 0x04001324 RID: 4900
		private const string DB = "db_farmgold.db";

		// Token: 0x04001325 RID: 4901
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x04001326 RID: 4902
		private const string TABLE = "FarmGoldActivity";

		// Token: 0x04001327 RID: 4903
		private const string COMMAND = "select BinData from `FarmGoldActivity` where ActivityId=? And InstId=?";

		// Token: 0x04001328 RID: 4904
		private const string KEY_PREFIX = "FarmGoldActivityByActivityIdAndInstanceId";

		// Token: 0x04001329 RID: 4905
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400132A RID: 4906
		private static int HandleId;
	}
}
