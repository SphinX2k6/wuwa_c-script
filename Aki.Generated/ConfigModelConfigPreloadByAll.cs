using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000543 RID: 1347
	public class ConfigModelConfigPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F9F RID: 8095 RVA: 0x0010C1F3 File Offset: 0x0010A3F3
		static ConfigModelConfigPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigModelConfigPreloadByAll.CreateStaticDefaultValue), new Action(ConfigModelConfigPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x0010C214 File Offset: 0x0010A414
		public static void CreateStaticDefaultValue()
		{
			ConfigModelConfigPreloadByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigModelConfigPreloadByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_model_config_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/ModelConfigPreload.csv"),
				new ValueTuple<string, object>("表名", "ModelConfigPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `ModelConfigPreload`")
			});
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0010C293 File Offset: 0x0010A493
		public static void ResetStaticDefaultValue()
		{
			ConfigModelConfigPreloadByAll.LogPair = null;
			ConfigModelConfigPreloadByAll.HandleId = 0;
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x0010C2A1 File Offset: 0x0010A4A1
		public static void Init()
		{
			ConfigModelConfigPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigModelConfigPreloadByAll.HandleId, "db_model_config_preload.db", "select BinData from `ModelConfigPreload`");
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x0010C2BC File Offset: 0x0010A4BC
		[NullableContext(2)]
		public static IReadOnlyList<ModelConfigPreload> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigModelConfigPreloadByAll.HandleId, ConfigModelConfigPreloadByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ModelConfigPreload> readOnlyList = (IReadOnlyList<ModelConfigPreload>)ConfigCommon.GetConfig("ModelConfigPreloadByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ModelConfigPreload> list = new List<ModelConfigPreload>();
			while (ConfigCommon.Step(ConfigModelConfigPreloadByAll.HandleId, false, ConfigModelConfigPreloadByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigModelConfigPreloadByAll.HandleId, 0, ConfigModelConfigPreloadByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigModelConfigPreloadByAll.HandleId, ConfigModelConfigPreloadByAll.LogPair);
					return null;
				}
				ModelConfigPreload rootAsModelConfigPreload = ModelConfigPreload.GetRootAsModelConfigPreload(new ByteBuffer(item2));
				list.Add(rootAsModelConfigPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ModelConfigPreloadByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigModelConfigPreloadByAll.HandleId, ConfigModelConfigPreloadByAll.LogPair);
			return list;
		}

		// Token: 0x040024B9 RID: 9401
		private const string DB = "db_model_config_preload.db";

		// Token: 0x040024BA RID: 9402
		private const string FILE = "Preload/ModelConfigPreload.csv";

		// Token: 0x040024BB RID: 9403
		private const string TABLE = "ModelConfigPreload";

		// Token: 0x040024BC RID: 9404
		private const string COMMAND = "select BinData from `ModelConfigPreload`";

		// Token: 0x040024BD RID: 9405
		private const string KEY_PREFIX = "ModelConfigPreloadByAll";

		// Token: 0x040024BE RID: 9406
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024BF RID: 9407
		private static int HandleId;
	}
}
