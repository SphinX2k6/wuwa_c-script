using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2B RID: 2859
	public class ConfigTrialRoleInfoByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004316 RID: 17174 RVA: 0x001D8458 File Offset: 0x001D6658
		static ConfigTrialRoleInfoByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialRoleInfoByType.CreateStaticDefaultValue), new Action(ConfigTrialRoleInfoByType.ResetStaticDefaultValue));
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x001D8478 File Offset: 0x001D6678
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialRoleInfoByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialRoleInfoByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrialRoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialRoleInfo` where Type = ?")
			});
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x001D84F7 File Offset: 0x001D66F7
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialRoleInfoByType.LogPair = null;
			ConfigTrialRoleInfoByType.HandleId = 0;
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x001D8505 File Offset: 0x001D6705
		public static void Init()
		{
			ConfigTrialRoleInfoByType.HandleId = ConfigCommon.InitDataStatement(ConfigTrialRoleInfoByType.HandleId, "db_trial_role.db", "select BinData from `TrialRoleInfo` where Type = ?");
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x001D8520 File Offset: 0x001D6720
		[NullableContext(2)]
		public static IReadOnlyList<TrialRoleInfo> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialRoleInfoByType.HandleId, ConfigTrialRoleInfoByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialRoleInfoByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<TrialRoleInfo> readOnlyList = (IReadOnlyList<TrialRoleInfo>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrialRoleInfoByType.LogPair.Clear();
			ConfigTrialRoleInfoByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigTrialRoleInfoByType.HandleId, 1, p0Type, ConfigTrialRoleInfoByType.LogPair))
			{
				ConfigCommon.Reset(ConfigTrialRoleInfoByType.HandleId, ConfigTrialRoleInfoByType.LogPair);
				return null;
			}
			List<TrialRoleInfo> list = new List<TrialRoleInfo>();
			while (ConfigCommon.Step(ConfigTrialRoleInfoByType.HandleId, false, ConfigTrialRoleInfoByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialRoleInfoByType.HandleId, 0, ConfigTrialRoleInfoByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrialRoleInfoByType.HandleId, ConfigTrialRoleInfoByType.LogPair);
					return null;
				}
				TrialRoleInfo rootAsTrialRoleInfo = TrialRoleInfo.GetRootAsTrialRoleInfo(new ByteBuffer(item2));
				list.Add(rootAsTrialRoleInfo);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialRoleInfoByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrialRoleInfoByType.HandleId, ConfigTrialRoleInfoByType.LogPair);
			return list;
		}

		// Token: 0x04004E13 RID: 19987
		private const string DB = "db_trial_role.db";

		// Token: 0x04004E14 RID: 19988
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004E15 RID: 19989
		private const string TABLE = "TrialRoleInfo";

		// Token: 0x04004E16 RID: 19990
		private const string COMMAND = "select BinData from `TrialRoleInfo` where Type = ?";

		// Token: 0x04004E17 RID: 19991
		private const string KEY_PREFIX = "TrialRoleInfoByType";

		// Token: 0x04004E18 RID: 19992
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E19 RID: 19993
		private static int HandleId;
	}
}
