using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000265 RID: 613
	public class ConfigEdgeRunnerTrialByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E62 RID: 3682 RVA: 0x000AE51C File Offset: 0x000AC71C
		static ConfigEdgeRunnerTrialByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerTrialByActivityId.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerTrialByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x000AE53C File Offset: 0x000AC73C
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

		// Token: 0x06000E64 RID: 3684 RVA: 0x000AE5BB File Offset: 0x000AC7BB
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerTrialByActivityId.LogPair = null;
			ConfigEdgeRunnerTrialByActivityId.HandleId = 0;
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000AE5C9 File Offset: 0x000AC7C9
		public static void Init()
		{
			ConfigEdgeRunnerTrialByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerTrialByActivityId.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerTrial` where ActivityId=?");
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000AE5E4 File Offset: 0x000AC7E4
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

		// Token: 0x040010A7 RID: 4263
		private const string DB = "db_edgerunner.db";

		// Token: 0x040010A8 RID: 4264
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x040010A9 RID: 4265
		private const string TABLE = "EdgeRunnerTrial";

		// Token: 0x040010AA RID: 4266
		private const string COMMAND = "select BinData from `EdgeRunnerTrial` where ActivityId=?";

		// Token: 0x040010AB RID: 4267
		private const string KEY_PREFIX = "EdgeRunnerTrialByActivityId";

		// Token: 0x040010AC RID: 4268
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010AD RID: 4269
		private static int HandleId;
	}
}
