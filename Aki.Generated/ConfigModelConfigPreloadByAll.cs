using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000559 RID: 1369
	public class ConfigModelConfigPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002023 RID: 8227 RVA: 0x00112947 File Offset: 0x00110B47
		static ConfigModelConfigPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigModelConfigPreloadByAll.CreateStaticDefaultValue), new Action(ConfigModelConfigPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00112968 File Offset: 0x00110B68
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

		// Token: 0x06002025 RID: 8229 RVA: 0x001129E7 File Offset: 0x00110BE7
		public static void ResetStaticDefaultValue()
		{
			ConfigModelConfigPreloadByAll.LogPair = null;
			ConfigModelConfigPreloadByAll.HandleId = 0;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x001129F5 File Offset: 0x00110BF5
		public static void Init()
		{
			ConfigModelConfigPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigModelConfigPreloadByAll.HandleId, "db_model_config_preload.db", "select BinData from `ModelConfigPreload`");
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00112A10 File Offset: 0x00110C10
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

		// Token: 0x04002553 RID: 9555
		private const string DB = "db_model_config_preload.db";

		// Token: 0x04002554 RID: 9556
		private const string FILE = "Preload/ModelConfigPreload.csv";

		// Token: 0x04002555 RID: 9557
		private const string TABLE = "ModelConfigPreload";

		// Token: 0x04002556 RID: 9558
		private const string COMMAND = "select BinData from `ModelConfigPreload`";

		// Token: 0x04002557 RID: 9559
		private const string KEY_PREFIX = "ModelConfigPreloadByAll";

		// Token: 0x04002558 RID: 9560
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002559 RID: 9561
		private static int HandleId;
	}
}
