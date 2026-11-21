using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000441 RID: 1089
	public class ConfigInfrLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600198F RID: 6543 RVA: 0x000EDB34 File Offset: 0x000EBD34
		static ConfigInfrLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrLevelAll.CreateStaticDefaultValue), new Action(ConfigInfrLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000EDB54 File Offset: 0x000EBD54
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

		// Token: 0x06001991 RID: 6545 RVA: 0x000EDBD3 File Offset: 0x000EBDD3
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrLevelAll.LogPair = null;
			ConfigInfrLevelAll.HandleId = 0;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000EDBE1 File Offset: 0x000EBDE1
		public static void Init()
		{
			ConfigInfrLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrLevelAll.HandleId, "db_infrastructure.db", "select BinData from `InfrLevel`");
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000EDBFC File Offset: 0x000EBDFC
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

		// Token: 0x04001DAB RID: 7595
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DAC RID: 7596
		private const string FILE = "j.基建.xlsx";

		// Token: 0x04001DAD RID: 7597
		private const string TABLE = "InfrLevel";

		// Token: 0x04001DAE RID: 7598
		private const string COMMAND = "select BinData from `InfrLevel`";

		// Token: 0x04001DAF RID: 7599
		private const string KEY_PREFIX = "InfrLevelAll";

		// Token: 0x04001DB0 RID: 7600
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DB1 RID: 7601
		private static int HandleId;
	}
}
