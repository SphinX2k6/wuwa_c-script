using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000094 RID: 148
	public class ConfigAiStateMachineConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00070A90 File Offset: 0x0006EC90
		static ConfigAiStateMachineConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiStateMachineConfigById.CreateStaticDefaultValue), new Action(ConfigAiStateMachineConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00070AB0 File Offset: 0x0006ECB0
		public static void CreateStaticDefaultValue()
		{
			ConfigAiStateMachineConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAiStateMachineConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_aistatemachineconfig.db"),
				new ValueTuple<string, object>("文件", "z.战斗/a.AI/a.AI状态机.csv"),
				new ValueTuple<string, object>("表名", "AiStateMachineConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `AiStateMachineConfig` where Id=?")
			});
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00070B2F File Offset: 0x0006ED2F
		public static void ResetStaticDefaultValue()
		{
			ConfigAiStateMachineConfigById.LogPair = null;
			ConfigAiStateMachineConfigById.HandleId = 0;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00070B3D File Offset: 0x0006ED3D
		public static void Init()
		{
			ConfigAiStateMachineConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAiStateMachineConfigById.HandleId, "db_aistatemachineconfig.db", "select BinData from `AiStateMachineConfig` where Id=?");
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00070B58 File Offset: 0x0006ED58
		public static AiStateMachineConfig? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAiStateMachineConfigById.HandleId, ConfigAiStateMachineConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("AiStateMachineConfigById#" + p0Id);
				if (configBuffer != null)
				{
					return new AiStateMachineConfig?(AiStateMachineConfig.GetRootAsAiStateMachineConfig(configBuffer));
				}
			}
			ConfigAiStateMachineConfigById.LogPair.Clear();
			ConfigAiStateMachineConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigAiStateMachineConfigById.HandleId, 1, p0Id, ConfigAiStateMachineConfigById.LogPair) || ConfigCommon.Step(ConfigAiStateMachineConfigById.HandleId, true, ConfigAiStateMachineConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAiStateMachineConfigById.HandleId, ConfigAiStateMachineConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAiStateMachineConfigById.HandleId, 0, ConfigAiStateMachineConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAiStateMachineConfigById.HandleId, ConfigAiStateMachineConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AiStateMachineConfig rootAsAiStateMachineConfig = AiStateMachineConfig.GetRootAsAiStateMachineConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("AiStateMachineConfigById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAiStateMachineConfigById.HandleId, ConfigAiStateMachineConfigById.LogPair);
			return new AiStateMachineConfig?(rootAsAiStateMachineConfig);
		}

		// Token: 0x040003F0 RID: 1008
		private const string DB = "db_aistatemachineconfig.db";

		// Token: 0x040003F1 RID: 1009
		private const string FILE = "z.战斗/a.AI/a.AI状态机.csv";

		// Token: 0x040003F2 RID: 1010
		private const string TABLE = "AiStateMachineConfig";

		// Token: 0x040003F3 RID: 1011
		private const string COMMAND = "select BinData from `AiStateMachineConfig` where Id=?";

		// Token: 0x040003F4 RID: 1012
		private const string KEY_PREFIX = "AiStateMachineConfigById";

		// Token: 0x040003F5 RID: 1013
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003F6 RID: 1014
		private static int HandleId;
	}
}
