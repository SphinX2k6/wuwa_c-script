using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEC RID: 2796
	public class ConfigTrapDefenseActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600419C RID: 16796 RVA: 0x001CFC74 File Offset: 0x001CDE74
		static ConfigTrapDefenseActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x001CFC94 File Offset: 0x001CDE94
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseActivity` where ActivityId=?")
			});
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x001CFD13 File Offset: 0x001CDF13
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseActivityByActivityId.LogPair = null;
			ConfigTrapDefenseActivityByActivityId.HandleId = 0;
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x001CFD21 File Offset: 0x001CDF21
		public static void Init()
		{
			ConfigTrapDefenseActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseActivityByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseActivity` where ActivityId=?");
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x001CFD3C File Offset: 0x001CDF3C
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseActivity> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseActivityByActivityId.HandleId, ConfigTrapDefenseActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TrapDefenseActivity> readOnlyList = (IReadOnlyList<TrapDefenseActivity>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseActivityByActivityId.LogPair.Clear();
			ConfigTrapDefenseActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseActivityByActivityId.HandleId, 1, p0ActivityId, ConfigTrapDefenseActivityByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseActivityByActivityId.HandleId, ConfigTrapDefenseActivityByActivityId.LogPair);
				return null;
			}
			List<TrapDefenseActivity> list = new List<TrapDefenseActivity>();
			while (ConfigCommon.Step(ConfigTrapDefenseActivityByActivityId.HandleId, false, ConfigTrapDefenseActivityByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseActivityByActivityId.HandleId, 0, ConfigTrapDefenseActivityByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseActivityByActivityId.HandleId, ConfigTrapDefenseActivityByActivityId.LogPair);
					return null;
				}
				TrapDefenseActivity rootAsTrapDefenseActivity = TrapDefenseActivity.GetRootAsTrapDefenseActivity(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseActivity);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseActivityByActivityId.HandleId, ConfigTrapDefenseActivityByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004C5A RID: 19546
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C5B RID: 19547
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004C5C RID: 19548
		private const string TABLE = "TrapDefenseActivity";

		// Token: 0x04004C5D RID: 19549
		private const string COMMAND = "select BinData from `TrapDefenseActivity` where ActivityId=?";

		// Token: 0x04004C5E RID: 19550
		private const string KEY_PREFIX = "TrapDefenseActivityByActivityId";

		// Token: 0x04004C5F RID: 19551
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C60 RID: 19552
		private static int HandleId;
	}
}
