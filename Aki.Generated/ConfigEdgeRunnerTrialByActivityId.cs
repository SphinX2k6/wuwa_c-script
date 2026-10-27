using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000251 RID: 593
	public class ConfigEdgeRunnerTrialByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DEA RID: 3562 RVA: 0x000A8258 File Offset: 0x000A6458
		static ConfigEdgeRunnerTrialByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTrialByActivityId.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTrialByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000A8278 File Offset: 0x000A6478
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerTrialByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerTrial"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerTrial` where ActivityId=?")
			});
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000A82F7 File Offset: 0x000A64F7
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialByActivityId.LogPair = null;
			ConfigEdgeRunnerTrialByActivityId.HandleId = 0;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000A8305 File Offset: 0x000A6505
		public static void Init()
		{
			ConfigEdgeRunnerTrialByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTrialByActivityId.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTrial` where ActivityId=?");
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000A8320 File Offset: 0x000A6520
		[NullableContext(2)]
		public static IReadOnlyList<EdgeRunnerTrial> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerTrialByActivityId.HandleId, ConfigEdgeRunnerTrialByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTrialByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<EdgeRunnerTrial> readOnlyList = (IReadOnlyList<EdgeRunnerTrial>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEdgeRunnerTrialByActivityId.LogPair.Clear();
			ConfigEdgeRunnerTrialByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerTrialByActivityId.HandleId, 1, p0ActivityId, ConfigEdgeRunnerTrialByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigEdgeRunnerTrialByActivityId.HandleId, ConfigEdgeRunnerTrialByActivityId.LogPair);
				return null;
			}
			List<EdgeRunnerTrial> list = new List<EdgeRunnerTrial>();
			while (ConfigCommon.Step(ConfigEdgeRunnerTrialByActivityId.HandleId, false, ConfigEdgeRunnerTrialByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerTrialByActivityId.HandleId, 0, ConfigEdgeRunnerTrialByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEdgeRunnerTrialByActivityId.HandleId, ConfigEdgeRunnerTrialByActivityId.LogPair);
					return null;
				}
				EdgeRunnerTrial rootAsEdgeRunnerTrial = EdgeRunnerTrial.GetRootAsEdgeRunnerTrial(new ByteBuffer(item2));
				list.Add(rootAsEdgeRunnerTrial);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTrialByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerTrialByActivityId.HandleId, ConfigEdgeRunnerTrialByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400101B RID: 4123
		private const string DB = "db_edgerunner.db";

		// Token: 0x0400101C RID: 4124
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x0400101D RID: 4125
		private const string TABLE = "EdgeRunnerTrial";

		// Token: 0x0400101E RID: 4126
		private const string COMMAND = "select BinData from `EdgeRunnerTrial` where ActivityId=?";

		// Token: 0x0400101F RID: 4127
		private const string KEY_PREFIX = "EdgeRunnerTrialByActivityId";

		// Token: 0x04001020 RID: 4128
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001021 RID: 4129
		private static int HandleId;
	}
}
