using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A17 RID: 2583
	public class ConfigTrapDefenseActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C9E RID: 15518 RVA: 0x001B08E0 File Offset: 0x001AEAE0
		static ConfigTrapDefenseActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x001B0900 File Offset: 0x001AEB00
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

		// Token: 0x06003CA0 RID: 15520 RVA: 0x001B097F File Offset: 0x001AEB7F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseActivityByActivityId.LogPair = null;
			ConfigTrapDefenseActivityByActivityId.HandleId = 0;
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x001B098D File Offset: 0x001AEB8D
		public static void Init()
		{
			ConfigTrapDefenseActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseActivityByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseActivity` where ActivityId=?");
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x001B09A8 File Offset: 0x001AEBA8
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

		// Token: 0x04004687 RID: 18055
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004688 RID: 18056
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004689 RID: 18057
		private const string TABLE = "TrapDefenseActivity";

		// Token: 0x0400468A RID: 18058
		private const string COMMAND = "select BinData from `TrapDefenseActivity` where ActivityId=?";

		// Token: 0x0400468B RID: 18059
		private const string KEY_PREFIX = "TrapDefenseActivityByActivityId";

		// Token: 0x0400468C RID: 18060
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400468D RID: 18061
		private static int HandleId;
	}
}
