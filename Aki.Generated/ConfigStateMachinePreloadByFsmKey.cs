using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A66 RID: 2662
	public class ConfigStateMachinePreloadByFsmKey : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E78 RID: 15992 RVA: 0x001BDB5B File Offset: 0x001BBD5B
		static ConfigStateMachinePreloadByFsmKey()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigStateMachinePreloadByFsmKey.CreateStaticDefaultValue), new Action(ConfigStateMachinePreloadByFsmKey.ResetStaticDefaultValue));
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x001BDB7C File Offset: 0x001BBD7C
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

		// Token: 0x06003E7A RID: 15994 RVA: 0x001BDBFB File Offset: 0x001BBDFB
		public static void ResetStaticDefaultValue()
		{
			ConfigStateMachinePreloadByFsmKey.LogPair = null;
			ConfigStateMachinePreloadByFsmKey.HandleId = 0;
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x001BDC09 File Offset: 0x001BBE09
		public static void Init()
		{
			ConfigStateMachinePreloadByFsmKey.HandleId = ConfigCommon.InitDataStatement(ConfigStateMachinePreloadByFsmKey.HandleId, "db_state_machine_preload.db", "select BinData from `StateMachinePreload` where FsmKey=?");
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x001BDC24 File Offset: 0x001BBE24
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

		// Token: 0x040048B0 RID: 18608
		private const string DB = "db_state_machine_preload.db";

		// Token: 0x040048B1 RID: 18609
		private const string FILE = "Preload/StateMachinePreload.csv";

		// Token: 0x040048B2 RID: 18610
		private const string TABLE = "StateMachinePreload";

		// Token: 0x040048B3 RID: 18611
		private const string COMMAND = "select BinData from `StateMachinePreload` where FsmKey=?";

		// Token: 0x040048B4 RID: 18612
		private const string KEY_PREFIX = "StateMachinePreloadByFsmKey";

		// Token: 0x040048B5 RID: 18613
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048B6 RID: 18614
		private static int HandleId;
	}
}
