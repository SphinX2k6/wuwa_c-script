using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A54 RID: 2644
	public class ConfigTrialRoleInfoByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E0C RID: 15884 RVA: 0x001B8C43 File Offset: 0x001B6E43
		static ConfigTrialRoleInfoByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialRoleInfoByGroupId.CreateStaticDefaultValue), new Action(ConfigTrialRoleInfoByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x001B8C64 File Offset: 0x001B6E64
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

		// Token: 0x06003E0E RID: 15886 RVA: 0x001B8CE3 File Offset: 0x001B6EE3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialRoleInfoByGroupId.LogPair = null;
			ConfigTrialRoleInfoByGroupId.HandleId = 0;
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x001B8CF1 File Offset: 0x001B6EF1
		public static void Init()
		{
			ConfigTrialRoleInfoByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigTrialRoleInfoByGroupId.HandleId, "db_trial_role.db", "select BinData from `TrialRoleInfo` where GroupId = ?");
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x001B8D0C File Offset: 0x001B6F0C
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

		// Token: 0x04004832 RID: 18482
		private const string DB = "db_trial_role.db";

		// Token: 0x04004833 RID: 18483
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004834 RID: 18484
		private const string TABLE = "TrialRoleInfo";

		// Token: 0x04004835 RID: 18485
		private const string COMMAND = "select BinData from `TrialRoleInfo` where GroupId = ?";

		// Token: 0x04004836 RID: 18486
		private const string KEY_PREFIX = "TrialRoleInfoByGroupId";

		// Token: 0x04004837 RID: 18487
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004838 RID: 18488
		private static int HandleId;
	}
}
