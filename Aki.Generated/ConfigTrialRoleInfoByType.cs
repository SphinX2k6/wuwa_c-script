using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A56 RID: 2646
	public class ConfigTrialRoleInfoByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E18 RID: 15896 RVA: 0x001B90C4 File Offset: 0x001B72C4
		static ConfigTrialRoleInfoByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialRoleInfoByType.CreateStaticDefaultValue), new Action(ConfigTrialRoleInfoByType.ResetStaticDefaultValue));
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x001B90E4 File Offset: 0x001B72E4
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

		// Token: 0x06003E1A RID: 15898 RVA: 0x001B9163 File Offset: 0x001B7363
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialRoleInfoByType.LogPair = null;
			ConfigTrialRoleInfoByType.HandleId = 0;
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x001B9171 File Offset: 0x001B7371
		public static void Init()
		{
			ConfigTrialRoleInfoByType.HandleId = ConfigCommon.InitDataStatement(ConfigTrialRoleInfoByType.HandleId, "db_trial_role.db", "select BinData from `TrialRoleInfo` where Type = ?");
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x001B918C File Offset: 0x001B738C
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

		// Token: 0x04004840 RID: 18496
		private const string DB = "db_trial_role.db";

		// Token: 0x04004841 RID: 18497
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004842 RID: 18498
		private const string TABLE = "TrialRoleInfo";

		// Token: 0x04004843 RID: 18499
		private const string COMMAND = "select BinData from `TrialRoleInfo` where Type = ?";

		// Token: 0x04004844 RID: 18500
		private const string KEY_PREFIX = "TrialRoleInfoByType";

		// Token: 0x04004845 RID: 18501
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004846 RID: 18502
		private static int HandleId;
	}
}
