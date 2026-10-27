using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C1 RID: 1473
	public class ConfigMotorSceneAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002293 RID: 8851 RVA: 0x0011D09C File Offset: 0x0011B29C
		static ConfigMotorSceneAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSceneAll.CreateStaticDefaultValue), new Action(ConfigMotorSceneAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x0011D0BC File Offset: 0x0011B2BC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorSceneAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorSceneAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorScene"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorScene`")
			});
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0011D13B File Offset: 0x0011B33B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSceneAll.LogPair = null;
			ConfigMotorSceneAll.HandleId = 0;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0011D149 File Offset: 0x0011B349
		public static void Init()
		{
			ConfigMotorSceneAll.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSceneAll.HandleId, "db_motordiy.db", "select BinData from `MotorScene`");
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0011D164 File Offset: 0x0011B364
		[NullableContext(2)]
		public static IReadOnlyList<MotorScene> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorSceneAll.HandleId, ConfigMotorSceneAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MotorScene> readOnlyList = (IReadOnlyList<MotorScene>)ConfigCommon.GetConfig("MotorSceneAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MotorScene> list = new List<MotorScene>();
			while (ConfigCommon.Step(ConfigMotorSceneAll.HandleId, false, ConfigMotorSceneAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorSceneAll.HandleId, 0, ConfigMotorSceneAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorSceneAll.HandleId, ConfigMotorSceneAll.LogPair);
					return null;
				}
				MotorScene rootAsMotorScene = MotorScene.GetRootAsMotorScene(new ByteBuffer(item2));
				list.Add(rootAsMotorScene);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MotorSceneAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorSceneAll.HandleId, ConfigMotorSceneAll.LogPair);
			return list;
		}

		// Token: 0x0400282B RID: 10283
		private const string DB = "db_motordiy.db";

		// Token: 0x0400282C RID: 10284
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x0400282D RID: 10285
		private const string TABLE = "MotorScene";

		// Token: 0x0400282E RID: 10286
		private const string COMMAND = "select BinData from `MotorScene`";

		// Token: 0x0400282F RID: 10287
		private const string KEY_PREFIX = "MotorSceneAll";

		// Token: 0x04002830 RID: 10288
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002831 RID: 10289
		private static int HandleId;
	}
}
