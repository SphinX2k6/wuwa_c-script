using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DE RID: 2014
	public class ConfigRegressTrialRoleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F46 RID: 12102 RVA: 0x00164643 File Offset: 0x00162843
		static ConfigRegressTrialRoleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressTrialRoleByActivityId.CreateStaticDefaultValue), new Action(ConfigRegressTrialRoleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x00164664 File Offset: 0x00162864
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressTrialRoleByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressTrialRoleByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressTrialRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressTrialRole` where ActivityId=?")
			});
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x001646E3 File Offset: 0x001628E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressTrialRoleByActivityId.LogPair = null;
			ConfigRegressTrialRoleByActivityId.HandleId = 0;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x001646F1 File Offset: 0x001628F1
		public static void Init()
		{
			ConfigRegressTrialRoleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRegressTrialRoleByActivityId.HandleId, "db_regressactivity.db", "select BinData from `RegressTrialRole` where ActivityId=?");
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x0016470C File Offset: 0x0016290C
		[NullableContext(2)]
		public static IReadOnlyList<RegressTrialRole> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressTrialRoleByActivityId.HandleId, ConfigRegressTrialRoleByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressTrialRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RegressTrialRole> readOnlyList = (IReadOnlyList<RegressTrialRole>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRegressTrialRoleByActivityId.LogPair.Clear();
			ConfigRegressTrialRoleByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRegressTrialRoleByActivityId.HandleId, 1, p0ActivityId, ConfigRegressTrialRoleByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRegressTrialRoleByActivityId.HandleId, ConfigRegressTrialRoleByActivityId.LogPair);
				return null;
			}
			List<RegressTrialRole> list = new List<RegressTrialRole>();
			while (ConfigCommon.Step(ConfigRegressTrialRoleByActivityId.HandleId, false, ConfigRegressTrialRoleByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressTrialRoleByActivityId.HandleId, 0, ConfigRegressTrialRoleByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressTrialRoleByActivityId.HandleId, ConfigRegressTrialRoleByActivityId.LogPair);
					return null;
				}
				RegressTrialRole rootAsRegressTrialRole = RegressTrialRole.GetRootAsRegressTrialRole(new ByteBuffer(item2));
				list.Add(rootAsRegressTrialRole);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressTrialRoleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressTrialRoleByActivityId.HandleId, ConfigRegressTrialRoleByActivityId.LogPair);
			return list;
		}

		// Token: 0x040036F8 RID: 14072
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036F9 RID: 14073
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036FA RID: 14074
		private const string TABLE = "RegressTrialRole";

		// Token: 0x040036FB RID: 14075
		private const string COMMAND = "select BinData from `RegressTrialRole` where ActivityId=?";

		// Token: 0x040036FC RID: 14076
		private const string KEY_PREFIX = "RegressTrialRoleByActivityId";

		// Token: 0x040036FD RID: 14077
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036FE RID: 14078
		private static int HandleId;
	}
}
