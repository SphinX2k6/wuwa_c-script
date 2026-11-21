using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200034C RID: 844
	public class ConfigFlowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013CD RID: 5069 RVA: 0x000CCC2C File Offset: 0x000CAE2C
		static ConfigFlowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlowById.CreateStaticDefaultValue), new Action(ConfigFlowById.ResetStaticDefaultValue));
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x000CCC4C File Offset: 0x000CAE4C
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

		// Token: 0x060013CF RID: 5071 RVA: 0x000CCCCB File Offset: 0x000CAECB
		public static void ResetStaticDefaultValue()
		{
			ConfigFlowById.LogPair = null;
			ConfigFlowById.HandleId = 0;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x000CCCD9 File Offset: 0x000CAED9
		public static void Init()
		{
			ConfigFlowById.HandleId = ConfigCommon.InitDataStatement(ConfigFlowById.HandleId, "db_flow.db", "select BinData from `Flow` where Id=?");
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x000CCCF4 File Offset: 0x000CAEF4
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

		// Token: 0x040016F8 RID: 5880
		private const string DB = "db_flow.db";

		// Token: 0x040016F9 RID: 5881
		private const string FILE = "UniverseEditor/Flow/剧情_*";

		// Token: 0x040016FA RID: 5882
		private const string TABLE = "Flow";

		// Token: 0x040016FB RID: 5883
		private const string COMMAND = "select BinData from `Flow` where Id=?";

		// Token: 0x040016FC RID: 5884
		private const string KEY_PREFIX = "FlowById";

		// Token: 0x040016FD RID: 5885
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016FE RID: 5886
		private static int HandleId;
	}
}
