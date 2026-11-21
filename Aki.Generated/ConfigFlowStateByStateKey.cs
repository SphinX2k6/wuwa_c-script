using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034D RID: 845
	public class ConfigFlowStateByStateKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013D3 RID: 5075 RVA: 0x000CCE25 File Offset: 0x000CB025
		static ConfigFlowStateByStateKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlowStateByStateKey.CreateStaticDefaultValue), new Action(ConfigFlowStateByStateKey.ResetStaticDefaultValue));
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000CCE44 File Offset: 0x000CB044
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

		// Token: 0x060013D5 RID: 5077 RVA: 0x000CCEC3 File Offset: 0x000CB0C3
		public static void ResetStaticDefaultValue()
		{
			ConfigFlowStateByStateKey.LogPair = null;
			ConfigFlowStateByStateKey.HandleId = 0;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x000CCED1 File Offset: 0x000CB0D1
		public static void Init()
		{
			ConfigFlowStateByStateKey.HandleId = ConfigCommon.InitDataStatement(ConfigFlowStateByStateKey.HandleId, "db_flowstate.db", "select BinData from `FlowState` where StateKey=?");
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x000CCEEC File Offset: 0x000CB0EC
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

		// Token: 0x040016FF RID: 5887
		private const string DB = "db_flowstate.db";

		// Token: 0x04001700 RID: 5888
		private const string FILE = "UniverseEditor/Flow/剧情状态_*";

		// Token: 0x04001701 RID: 5889
		private const string TABLE = "FlowState";

		// Token: 0x04001702 RID: 5890
		private const string COMMAND = "select BinData from `FlowState` where StateKey=?";

		// Token: 0x04001703 RID: 5891
		private const string KEY_PREFIX = "FlowStateByStateKey";

		// Token: 0x04001704 RID: 5892
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001705 RID: 5893
		private static int HandleId;
	}
}
