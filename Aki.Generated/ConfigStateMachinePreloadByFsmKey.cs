using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000991 RID: 2449
	public class ConfigStateMachinePreloadByFsmKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600397A RID: 14714 RVA: 0x0019E7C7 File Offset: 0x0019C9C7
		static ConfigStateMachinePreloadByFsmKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigStateMachinePreloadByFsmKey.CreateStaticDefaultValue), new Action(ConfigStateMachinePreloadByFsmKey.ResetStaticDefaultValue));
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x0019E7E8 File Offset: 0x0019C9E8
		public static void CreateStaticDefaultValue()
		{
			ConfigStateMachinePreloadByFsmKey.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigStateMachinePreloadByFsmKey.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_state_machine_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/StateMachinePreload.csv"),
				new ValueTuple<string, object>("表名", "StateMachinePreload"),
				new ValueTuple<string, object>("语句", "select BinData from `StateMachinePreload` where FsmKey=?")
			});
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x0019E867 File Offset: 0x0019CA67
		public static void ResetStaticDefaultValue()
		{
			ConfigStateMachinePreloadByFsmKey.LogPair = null;
			ConfigStateMachinePreloadByFsmKey.HandleId = 0;
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x0019E875 File Offset: 0x0019CA75
		public static void Init()
		{
			ConfigStateMachinePreloadByFsmKey.HandleId = ConfigCommon.InitDataStatement(ConfigStateMachinePreloadByFsmKey.HandleId, "db_state_machine_preload.db", "select BinData from `StateMachinePreload` where FsmKey=?");
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x0019E890 File Offset: 0x0019CA90
		public static StateMachinePreload? GetConfig(string p0FsmKey, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigStateMachinePreloadByFsmKey.HandleId, ConfigStateMachinePreloadByFsmKey.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("StateMachinePreloadByFsmKey#" + p0FsmKey);
				if (configBuffer != null)
				{
					return new StateMachinePreload?(StateMachinePreload.GetRootAsStateMachinePreload(configBuffer));
				}
			}
			ConfigStateMachinePreloadByFsmKey.LogPair.Clear();
			ConfigStateMachinePreloadByFsmKey.LogPair.Add(new ValueTuple<string, object>("FsmKey", p0FsmKey));
			if (!ConfigCommon.BindString(ConfigStateMachinePreloadByFsmKey.HandleId, 1, p0FsmKey, ConfigStateMachinePreloadByFsmKey.LogPair) || ConfigCommon.Step(ConfigStateMachinePreloadByFsmKey.HandleId, true, ConfigStateMachinePreloadByFsmKey.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigStateMachinePreloadByFsmKey.HandleId, ConfigStateMachinePreloadByFsmKey.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigStateMachinePreloadByFsmKey.HandleId, 0, ConfigStateMachinePreloadByFsmKey.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigStateMachinePreloadByFsmKey.HandleId, ConfigStateMachinePreloadByFsmKey.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			StateMachinePreload rootAsStateMachinePreload = StateMachinePreload.GetRootAsStateMachinePreload(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("StateMachinePreloadByFsmKey#" + p0FsmKey, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigStateMachinePreloadByFsmKey.HandleId, ConfigStateMachinePreloadByFsmKey.LogPair);
			return new StateMachinePreload?(rootAsStateMachinePreload);
		}

		// Token: 0x040042DD RID: 17117
		private const string DB = "db_state_machine_preload.db";

		// Token: 0x040042DE RID: 17118
		private const string FILE = "Preload/StateMachinePreload.csv";

		// Token: 0x040042DF RID: 17119
		private const string TABLE = "StateMachinePreload";

		// Token: 0x040042E0 RID: 17120
		private const string COMMAND = "select BinData from `StateMachinePreload` where FsmKey=?";

		// Token: 0x040042E1 RID: 17121
		private const string KEY_PREFIX = "StateMachinePreloadByFsmKey";

		// Token: 0x040042E2 RID: 17122
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042E3 RID: 17123
		private static int HandleId;
	}
}
