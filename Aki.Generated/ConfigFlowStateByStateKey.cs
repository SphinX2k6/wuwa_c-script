using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000338 RID: 824
	public class ConfigFlowStateByStateKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001355 RID: 4949 RVA: 0x000C6919 File Offset: 0x000C4B19
		static ConfigFlowStateByStateKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlowStateByStateKey.CreateStaticDefaultValue), new Action(ConfigFlowStateByStateKey.ResetStaticDefaultValue));
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000C6938 File Offset: 0x000C4B38
		public static void CreateStaticDefaultValue()
		{
			ConfigFlowStateByStateKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlowStateByStateKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flowstate.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Flow/剧情状态_*"),
				new ValueTuple<string, object>("表名", "FlowState"),
				new ValueTuple<string, object>("语句", "select BinData from `FlowState` where StateKey=?")
			});
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000C69B7 File Offset: 0x000C4BB7
		public static void ResetStaticDefaultValue()
		{
			ConfigFlowStateByStateKey.LogPair = null;
			ConfigFlowStateByStateKey.HandleId = 0;
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x000C69C5 File Offset: 0x000C4BC5
		public static void Init()
		{
			ConfigFlowStateByStateKey.HandleId = ConfigCommon.InitDataStatement(ConfigFlowStateByStateKey.HandleId, "db_flowstate.db", "select BinData from `FlowState` where StateKey=?");
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x000C69E0 File Offset: 0x000C4BE0
		public static FlowState? GetConfig(string p0StateKey, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlowStateByStateKey.HandleId, ConfigFlowStateByStateKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("FlowStateByStateKey#" + p0StateKey);
				if (configBuffer != null)
				{
					return new FlowState?(FlowState.GetRootAsFlowState(configBuffer));
				}
			}
			ConfigFlowStateByStateKey.LogPair.Clear();
			ConfigFlowStateByStateKey.LogPair.Add(new ValueTuple<string, object>("StateKey", p0StateKey));
			if (!ConfigCommon.BindString(ConfigFlowStateByStateKey.HandleId, 1, p0StateKey, ConfigFlowStateByStateKey.LogPair) || ConfigCommon.Step(ConfigFlowStateByStateKey.HandleId, true, ConfigFlowStateByStateKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlowStateByStateKey.HandleId, ConfigFlowStateByStateKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlowStateByStateKey.HandleId, 0, ConfigFlowStateByStateKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlowStateByStateKey.HandleId, ConfigFlowStateByStateKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlowState rootAsFlowState = FlowState.GetRootAsFlowState(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("FlowStateByStateKey#" + p0StateKey, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlowStateByStateKey.HandleId, ConfigFlowStateByStateKey.LogPair);
			return new FlowState?(rootAsFlowState);
		}

		// Token: 0x0400166C RID: 5740
		private const string DB = "db_flowstate.db";

		// Token: 0x0400166D RID: 5741
		private const string FILE = "UniverseEditor/Flow/剧情状态_*";

		// Token: 0x0400166E RID: 5742
		private const string TABLE = "FlowState";

		// Token: 0x0400166F RID: 5743
		private const string COMMAND = "select BinData from `FlowState` where StateKey=?";

		// Token: 0x04001670 RID: 5744
		private const string KEY_PREFIX = "FlowStateByStateKey";

		// Token: 0x04001671 RID: 5745
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001672 RID: 5746
		private static int HandleId;
	}
}
