using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042B RID: 1067
	public class ConfigInfrLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600190B RID: 6411 RVA: 0x000E73E0 File Offset: 0x000E55E0
		static ConfigInfrLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrLevelAll.CreateStaticDefaultValue), new Action(ConfigInfrLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x000E7400 File Offset: 0x000E5600
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrLevel`")
			});
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x000E747F File Offset: 0x000E567F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrLevelAll.LogPair = null;
			ConfigInfrLevelAll.HandleId = 0;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x000E748D File Offset: 0x000E568D
		public static void Init()
		{
			ConfigInfrLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrLevelAll.HandleId, "db_infrastructure.db", "select BinData from `InfrLevel`");
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000E74A8 File Offset: 0x000E56A8
		[NullableContext(2)]
		public static IReadOnlyList<InfrLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrLevelAll.HandleId, ConfigInfrLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrLevel> readOnlyList = (IReadOnlyList<InfrLevel>)ConfigCommon.GetConfig("InfrLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrLevel> list = new List<InfrLevel>();
			while (ConfigCommon.Step(ConfigInfrLevelAll.HandleId, false, ConfigInfrLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrLevelAll.HandleId, 0, ConfigInfrLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrLevelAll.HandleId, ConfigInfrLevelAll.LogPair);
					return null;
				}
				InfrLevel rootAsInfrLevel = InfrLevel.GetRootAsInfrLevel(new ByteBuffer(item2));
				list.Add(rootAsInfrLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrLevelAll.HandleId, ConfigInfrLevelAll.LogPair);
			return list;
		}

		// Token: 0x04001D11 RID: 7441
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D12 RID: 7442
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D13 RID: 7443
		private const string TABLE = "InfrLevel";

		// Token: 0x04001D14 RID: 7444
		private const string COMMAND = "select BinData from `InfrLevel`";

		// Token: 0x04001D15 RID: 7445
		private const string KEY_PREFIX = "InfrLevelAll";

		// Token: 0x04001D16 RID: 7446
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D17 RID: 7447
		private static int HandleId;
	}
}
