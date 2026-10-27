using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042D RID: 1069
	public class ConfigInfrPasserAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001917 RID: 6423 RVA: 0x000E77BC File Offset: 0x000E59BC
		static ConfigInfrPasserAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPasserAll.CreateStaticDefaultValue), new Action(ConfigInfrPasserAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000E77DC File Offset: 0x000E59DC
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrPasserAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrPasserAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建.xlsx"),
				new ValueTuple<string, object>("表名", "InfrPasser"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrPasser`")
			});
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x000E785B File Offset: 0x000E5A5B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPasserAll.LogPair = null;
			ConfigInfrPasserAll.HandleId = 0;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000E7869 File Offset: 0x000E5A69
		public static void Init()
		{
			ConfigInfrPasserAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPasserAll.HandleId, "db_infrastructure.db", "select BinData from `InfrPasser`");
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000E7884 File Offset: 0x000E5A84
		[NullableContext(2)]
		public static IReadOnlyList<InfrPasser> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrPasserAll.HandleId, ConfigInfrPasserAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrPasser> readOnlyList = (IReadOnlyList<InfrPasser>)ConfigCommon.GetConfig("InfrPasserAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrPasser> list = new List<InfrPasser>();
			while (ConfigCommon.Step(ConfigInfrPasserAll.HandleId, false, ConfigInfrPasserAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrPasserAll.HandleId, 0, ConfigInfrPasserAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrPasserAll.HandleId, ConfigInfrPasserAll.LogPair);
					return null;
				}
				InfrPasser rootAsInfrPasser = InfrPasser.GetRootAsInfrPasser(new ByteBuffer(item2));
				list.Add(rootAsInfrPasser);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrPasserAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrPasserAll.HandleId, ConfigInfrPasserAll.LogPair);
			return list;
		}

		// Token: 0x04001D1F RID: 7455
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D20 RID: 7456
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001D21 RID: 7457
		private const string TABLE = "InfrPasser";

		// Token: 0x04001D22 RID: 7458
		private const string COMMAND = "select BinData from `InfrPasser`";

		// Token: 0x04001D23 RID: 7459
		private const string KEY_PREFIX = "InfrPasserAll";

		// Token: 0x04001D24 RID: 7460
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D25 RID: 7461
		private static int HandleId;
	}
}
