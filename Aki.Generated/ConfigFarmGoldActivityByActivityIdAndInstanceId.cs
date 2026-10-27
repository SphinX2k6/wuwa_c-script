using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AB RID: 683
	public class ConfigFarmGoldActivityByActivityIdAndInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001007 RID: 4103 RVA: 0x000B401B File Offset: 0x000B221B
		static ConfigFarmGoldActivityByActivityIdAndInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFarmGoldActivityByActivityIdAndInstanceId.CreateStaticDefaultValue), new Action(ConfigFarmGoldActivityByActivityIdAndInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x000B403C File Offset: 0x000B223C
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

		// Token: 0x06001009 RID: 4105 RVA: 0x000B40BB File Offset: 0x000B22BB
		public static void ResetStaticDefaultValue()
		{
			ConfigFarmGoldActivityByActivityIdAndInstanceId.LogPair = null;
			ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId = 0;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000B40C9 File Offset: 0x000B22C9
		public static void Init()
		{
			ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigFarmGoldActivityByActivityIdAndInstanceId.HandleId, "db_farmgold.db", "select BinData from `FarmGoldActivity` where ActivityId=? And InstId=?");
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000B40E4 File Offset: 0x000B22E4
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

		// Token: 0x04001291 RID: 4753
		private const string DB = "db_farmgold.db";

		// Token: 0x04001292 RID: 4754
		private const string FILE = "b.爆金币活动.xlsx";

		// Token: 0x04001293 RID: 4755
		private const string TABLE = "FarmGoldActivity";

		// Token: 0x04001294 RID: 4756
		private const string COMMAND = "select BinData from `FarmGoldActivity` where ActivityId=? And InstId=?";

		// Token: 0x04001295 RID: 4757
		private const string KEY_PREFIX = "FarmGoldActivityByActivityIdAndInstanceId";

		// Token: 0x04001296 RID: 4758
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001297 RID: 4759
		private static int HandleId;
	}
}
