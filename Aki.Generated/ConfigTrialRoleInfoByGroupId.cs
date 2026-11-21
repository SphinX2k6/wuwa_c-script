using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B29 RID: 2857
	public class ConfigTrialRoleInfoByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600430A RID: 17162 RVA: 0x001D7FD7 File Offset: 0x001D61D7
		static ConfigTrialRoleInfoByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialRoleInfoByGroupId.CreateStaticDefaultValue), new Action(ConfigTrialRoleInfoByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x001D7FF8 File Offset: 0x001D61F8
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialRoleInfoByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialRoleInfoByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrialRoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialRoleInfo` where GroupId = ?")
			});
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x001D8077 File Offset: 0x001D6277
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialRoleInfoByGroupId.LogPair = null;
			ConfigTrialRoleInfoByGroupId.HandleId = 0;
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x001D8085 File Offset: 0x001D6285
		public static void Init()
		{
			ConfigTrialRoleInfoByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigTrialRoleInfoByGroupId.HandleId, "db_trial_role.db", "select BinData from `TrialRoleInfo` where GroupId = ?");
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x001D80A0 File Offset: 0x001D62A0
		[NullableContext(2)]
		public static IReadOnlyList<TrialRoleInfo> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialRoleInfoByGroupId.HandleId, ConfigTrialRoleInfoByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialRoleInfoByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<TrialRoleInfo> readOnlyList = (IReadOnlyList<TrialRoleInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrialRoleInfoByGroupId.LogPair.Clear();
			ConfigTrialRoleInfoByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigTrialRoleInfoByGroupId.HandleId, 1, p0GroupId, ConfigTrialRoleInfoByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigTrialRoleInfoByGroupId.HandleId, ConfigTrialRoleInfoByGroupId.LogPair);
				return null;
			}
			List<TrialRoleInfo> list = new List<TrialRoleInfo>();
			while (ConfigCommon.Step(ConfigTrialRoleInfoByGroupId.HandleId, false, ConfigTrialRoleInfoByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialRoleInfoByGroupId.HandleId, 0, ConfigTrialRoleInfoByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrialRoleInfoByGroupId.HandleId, ConfigTrialRoleInfoByGroupId.LogPair);
					return null;
				}
				TrialRoleInfo rootAsTrialRoleInfo = TrialRoleInfo.GetRootAsTrialRoleInfo(new ByteBuffer(item2));
				list.Add(rootAsTrialRoleInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialRoleInfoByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrialRoleInfoByGroupId.HandleId, ConfigTrialRoleInfoByGroupId.LogPair);
			return list;
		}

		// Token: 0x04004E05 RID: 19973
		private const string DB = "db_trial_role.db";

		// Token: 0x04004E06 RID: 19974
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004E07 RID: 19975
		private const string TABLE = "TrialRoleInfo";

		// Token: 0x04004E08 RID: 19976
		private const string COMMAND = "select BinData from `TrialRoleInfo` where GroupId = ?";

		// Token: 0x04004E09 RID: 19977
		private const string KEY_PREFIX = "TrialRoleInfoByGroupId";

		// Token: 0x04004E0A RID: 19978
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E0B RID: 19979
		private static int HandleId;
	}
}
