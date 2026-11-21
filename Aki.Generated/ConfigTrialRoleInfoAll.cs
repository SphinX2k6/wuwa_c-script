using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B28 RID: 2856
	public class ConfigTrialRoleInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004304 RID: 17156 RVA: 0x001D7E44 File Offset: 0x001D6044
		static ConfigTrialRoleInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialRoleInfoAll.CreateStaticDefaultValue), new Action(ConfigTrialRoleInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x001D7E64 File Offset: 0x001D6064
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialRoleInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialRoleInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrialRoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialRoleInfo`")
			});
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x001D7EE3 File Offset: 0x001D60E3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialRoleInfoAll.LogPair = null;
			ConfigTrialRoleInfoAll.HandleId = 0;
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x001D7EF1 File Offset: 0x001D60F1
		public static void Init()
		{
			ConfigTrialRoleInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrialRoleInfoAll.HandleId, "db_trial_role.db", "select BinData from `TrialRoleInfo`");
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x001D7F0C File Offset: 0x001D610C
		[NullableContext(2)]
		public static IReadOnlyList<TrialRoleInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialRoleInfoAll.HandleId, ConfigTrialRoleInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrialRoleInfo> readOnlyList = (IReadOnlyList<TrialRoleInfo>)ConfigCommon.GetConfig("TrialRoleInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrialRoleInfo> list = new List<TrialRoleInfo>();
			while (ConfigCommon.Step(ConfigTrialRoleInfoAll.HandleId, false, ConfigTrialRoleInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialRoleInfoAll.HandleId, 0, ConfigTrialRoleInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrialRoleInfoAll.HandleId, ConfigTrialRoleInfoAll.LogPair);
					return null;
				}
				TrialRoleInfo rootAsTrialRoleInfo = TrialRoleInfo.GetRootAsTrialRoleInfo(new ByteBuffer(item2));
				list.Add(rootAsTrialRoleInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrialRoleInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrialRoleInfoAll.HandleId, ConfigTrialRoleInfoAll.LogPair);
			return list;
		}

		// Token: 0x04004DFE RID: 19966
		private const string DB = "db_trial_role.db";

		// Token: 0x04004DFF RID: 19967
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004E00 RID: 19968
		private const string TABLE = "TrialRoleInfo";

		// Token: 0x04004E01 RID: 19969
		private const string COMMAND = "select BinData from `TrialRoleInfo`";

		// Token: 0x04004E02 RID: 19970
		private const string KEY_PREFIX = "TrialRoleInfoAll";

		// Token: 0x04004E03 RID: 19971
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E04 RID: 19972
		private static int HandleId;
	}
}
