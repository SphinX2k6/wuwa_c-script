using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000284 RID: 644
	public class ConfigEntrustRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x000AEECD File Offset: 0x000AD0CD
		static ConfigEntrustRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntrustRoleAll.CreateStaticDefaultValue), new Action(ConfigEntrustRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000AEEEC File Offset: 0x000AD0EC
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

		// Token: 0x06000F1F RID: 3871 RVA: 0x000AEF6B File Offset: 0x000AD16B
		public static void ResetStaticDefaultValue()
		{
			ConfigEntrustRoleAll.LogPair = null;
			ConfigEntrustRoleAll.HandleId = 0;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000AEF79 File Offset: 0x000AD179
		public static void Init()
		{
			ConfigEntrustRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigEntrustRoleAll.HandleId, "db_moonchasing.db", "select BinData from `EntrustRole`");
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000AEF94 File Offset: 0x000AD194
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

		// Token: 0x04001180 RID: 4480
		private const string DB = "db_moonchasing.db";

		// Token: 0x04001181 RID: 4481
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04001182 RID: 4482
		private const string TABLE = "EntrustRole";

		// Token: 0x04001183 RID: 4483
		private const string COMMAND = "select BinData from `EntrustRole`";

		// Token: 0x04001184 RID: 4484
		private const string KEY_PREFIX = "EntrustRoleAll";

		// Token: 0x04001185 RID: 4485
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001186 RID: 4486
		private static int HandleId;
	}
}
