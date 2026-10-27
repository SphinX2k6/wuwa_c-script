using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000252 RID: 594
	public class ConfigEdgeRunnerTrialByCyberPunkActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DF0 RID: 3568 RVA: 0x000A848F File Offset: 0x000A668F
		static ConfigEdgeRunnerTrialByCyberPunkActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTrialByCyberPunkActivityId.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTrialByCyberPunkActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000A84B0 File Offset: 0x000A66B0
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerTrial"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerTrial` where CyberPunkActivityId=?")
			});
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x000A852F File Offset: 0x000A672F
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair = null;
			ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId = 0;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000A853D File Offset: 0x000A673D
		public static void Init()
		{
			ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTrial` where CyberPunkActivityId=?");
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000A8558 File Offset: 0x000A6758
		[NullableContext(2)]
		public static IReadOnlyList<EdgeRunnerTrial> GetConfigList(int p0CyberPunkActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTrialByCyberPunkActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CyberPunkActivityId);
				IReadOnlyList<EdgeRunnerTrial> readOnlyList = (IReadOnlyList<EdgeRunnerTrial>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair.Clear();
			ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair.Add(new ValueTuple<string, object>("CyberPunkActivityId", p0CyberPunkActivityId));
			if (!ConfigCommon.BindInt(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, 1, p0CyberPunkActivityId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair);
				return null;
			}
			List<EdgeRunnerTrial> list = new List<EdgeRunnerTrial>();
			while (ConfigCommon.Step(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, false, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, 0, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair);
					return null;
				}
				EdgeRunnerTrial rootAsEdgeRunnerTrial = EdgeRunnerTrial.GetRootAsEdgeRunnerTrial(new ByteBuffer(item2));
				list.Add(rootAsEdgeRunnerTrial);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EdgeRunnerTrialByCyberPunkActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CyberPunkActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerTrialByCyberPunkActivityId.HandleId, ConfigEdgeRunnerTrialByCyberPunkActivityId.LogPair);
			return list;
		}

		// Token: 0x04001022 RID: 4130
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001023 RID: 4131
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001024 RID: 4132
		private const string TABLE = "EdgeRunnerTrial";

		// Token: 0x04001025 RID: 4133
		private const string COMMAND = "select BinData from `EdgeRunnerTrial` where CyberPunkActivityId=?";

		// Token: 0x04001026 RID: 4134
		private const string KEY_PREFIX = "EdgeRunnerTrialByCyberPunkActivityId";

		// Token: 0x04001027 RID: 4135
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001028 RID: 4136
		private static int HandleId;
	}
}
