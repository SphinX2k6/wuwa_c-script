using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000298 RID: 664
	public class ConfigEntrustRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F95 RID: 3989 RVA: 0x000B5191 File Offset: 0x000B3391
		static ConfigEntrustRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntrustRoleAll.CreateStaticDefaultValue), new Action(ConfigEntrustRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000B51B0 File Offset: 0x000B33B0
		public static void CreateStaticDefaultValue()
		{
			ConfigEntrustRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntrustRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "EntrustRole"),
				new ValueTuple<string, object>("语句", "select BinData from `EntrustRole`")
			});
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000B522F File Offset: 0x000B342F
		public static void ResetStaticDefaultValue()
		{
			ConfigEntrustRoleAll.LogPair = null;
			ConfigEntrustRoleAll.HandleId = 0;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000B523D File Offset: 0x000B343D
		public static void Init()
		{
			ConfigEntrustRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigEntrustRoleAll.HandleId, "db_moonchasing.db", "select BinData from `EntrustRole`");
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000B5258 File Offset: 0x000B3458
		[NullableContext(2)]
		public static IReadOnlyList<EntrustRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntrustRoleAll.HandleId, ConfigEntrustRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EntrustRole> readOnlyList = (IReadOnlyList<EntrustRole>)ConfigCommon.GetConfig("EntrustRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EntrustRole> list = new List<EntrustRole>();
			while (ConfigCommon.Step(ConfigEntrustRoleAll.HandleId, false, ConfigEntrustRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntrustRoleAll.HandleId, 0, ConfigEntrustRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEntrustRoleAll.HandleId, ConfigEntrustRoleAll.LogPair);
					return null;
				}
				EntrustRole rootAsEntrustRole = EntrustRole.GetRootAsEntrustRole(new ByteBuffer(item2));
				list.Add(rootAsEntrustRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EntrustRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEntrustRoleAll.HandleId, ConfigEntrustRoleAll.LogPair);
			return list;
		}

		// Token: 0x0400120C RID: 4620
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400120D RID: 4621
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400120E RID: 4622
		private const string TABLE = "EntrustRole";

		// Token: 0x0400120F RID: 4623
		private const string COMMAND = "select BinData from `EntrustRole`";

		// Token: 0x04001210 RID: 4624
		private const string KEY_PREFIX = "EntrustRoleAll";

		// Token: 0x04001211 RID: 4625
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001212 RID: 4626
		private static int HandleId;
	}
}
