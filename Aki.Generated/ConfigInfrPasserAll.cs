using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000443 RID: 1091
	public class ConfigInfrPasserAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600199B RID: 6555 RVA: 0x000EDF10 File Offset: 0x000EC110
		static ConfigInfrPasserAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPasserAll.CreateStaticDefaultValue), new Action(ConfigInfrPasserAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000EDF30 File Offset: 0x000EC130
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

		// Token: 0x0600199D RID: 6557 RVA: 0x000EDFAF File Offset: 0x000EC1AF
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPasserAll.LogPair = null;
			ConfigInfrPasserAll.HandleId = 0;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000EDFBD File Offset: 0x000EC1BD
		public static void Init()
		{
			ConfigInfrPasserAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPasserAll.HandleId, "db_infrastructure.db", "select BinData from `InfrPasser`");
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000EDFD8 File Offset: 0x000EC1D8
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

		// Token: 0x04001DB9 RID: 7609
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DBA RID: 7610
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001DBB RID: 7611
		private const string TABLE = "InfrPasser";

		// Token: 0x04001DBC RID: 7612
		private const string COMMAND = "select BinData from `InfrPasser`";

		// Token: 0x04001DBD RID: 7613
		private const string KEY_PREFIX = "InfrPasserAll";

		// Token: 0x04001DBE RID: 7614
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DBF RID: 7615
		private static int HandleId;
	}
}
