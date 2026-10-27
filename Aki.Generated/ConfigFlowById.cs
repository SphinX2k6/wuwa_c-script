using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000337 RID: 823
	public class ConfigFlowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600134F RID: 4943 RVA: 0x000C6720 File Offset: 0x000C4920
		static ConfigFlowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlowById.CreateStaticDefaultValue), new Action(ConfigFlowById.ResetStaticDefaultValue));
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000C6740 File Offset: 0x000C4940
		public static void CreateStaticDefaultValue()
		{
			ConfigFlowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flow.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Flow/剧情_*"),
				new ValueTuple<string, object>("表名", "Flow"),
				new ValueTuple<string, object>("语句", "select BinData from `Flow` where Id=?")
			});
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000C67BF File Offset: 0x000C49BF
		public static void ResetStaticDefaultValue()
		{
			ConfigFlowById.LogPair = null;
			ConfigFlowById.HandleId = 0;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x000C67CD File Offset: 0x000C49CD
		public static void Init()
		{
			ConfigFlowById.HandleId = ConfigCommon.InitDataStatement(ConfigFlowById.HandleId, "db_flow.db", "select BinData from `Flow` where Id=?");
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x000C67E8 File Offset: 0x000C49E8
		public static Flow? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlowById.HandleId, ConfigFlowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("FlowById#" + p0Id);
				if (configBuffer != null)
				{
					return new Flow?(Flow.GetRootAsFlow(configBuffer));
				}
			}
			ConfigFlowById.LogPair.Clear();
			ConfigFlowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigFlowById.HandleId, 1, p0Id, ConfigFlowById.LogPair) || ConfigCommon.Step(ConfigFlowById.HandleId, true, ConfigFlowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlowById.HandleId, ConfigFlowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlowById.HandleId, 0, ConfigFlowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlowById.HandleId, ConfigFlowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Flow rootAsFlow = Flow.GetRootAsFlow(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("FlowById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlowById.HandleId, ConfigFlowById.LogPair);
			return new Flow?(rootAsFlow);
		}

		// Token: 0x04001665 RID: 5733
		private const string DB = "db_flow.db";

		// Token: 0x04001666 RID: 5734
		private const string FILE = "UniverseEditor/Flow/剧情_*";

		// Token: 0x04001667 RID: 5735
		private const string TABLE = "Flow";

		// Token: 0x04001668 RID: 5736
		private const string COMMAND = "select BinData from `Flow` where Id=?";

		// Token: 0x04001669 RID: 5737
		private const string KEY_PREFIX = "FlowById";

		// Token: 0x0400166A RID: 5738
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400166B RID: 5739
		private static int HandleId;
	}
}
