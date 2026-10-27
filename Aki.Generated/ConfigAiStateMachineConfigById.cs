using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200008C RID: 140
	public class ConfigAiStateMachineConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000348 RID: 840 RVA: 0x0006C1DC File Offset: 0x0006A3DC
		static ConfigAiStateMachineConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAiStateMachineConfigById.CreateStaticDefaultValue), new Action(ConfigAiStateMachineConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0006C1FC File Offset: 0x0006A3FC
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

		// Token: 0x0600034A RID: 842 RVA: 0x0006C27B File Offset: 0x0006A47B
		public static void ResetStaticDefaultValue()
		{
			ConfigAiStateMachineConfigById.LogPair = null;
			ConfigAiStateMachineConfigById.HandleId = 0;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0006C289 File Offset: 0x0006A489
		public static void Init()
		{
			ConfigAiStateMachineConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigAiStateMachineConfigById.HandleId, "db_aistatemachineconfig.db", "select BinData from `AiStateMachineConfig` where Id=?");
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0006C2A4 File Offset: 0x0006A4A4
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

		// Token: 0x040003B8 RID: 952
		private const string DB = "db_aistatemachineconfig.db";

		// Token: 0x040003B9 RID: 953
		private const string FILE = "z.战斗/a.AI/a.AI状态机.csv";

		// Token: 0x040003BA RID: 954
		private const string TABLE = "AiStateMachineConfig";

		// Token: 0x040003BB RID: 955
		private const string COMMAND = "select BinData from `AiStateMachineConfig` where Id=?";

		// Token: 0x040003BC RID: 956
		private const string KEY_PREFIX = "AiStateMachineConfigById";

		// Token: 0x040003BD RID: 957
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040003BE RID: 958
		private static int HandleId;
	}
}
