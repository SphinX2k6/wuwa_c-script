using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000901 RID: 2305
	public class ConfigRoleTowerRewardTabByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003619 RID: 13849 RVA: 0x0018E797 File Offset: 0x0018C997
		static ConfigRoleTowerRewardTabByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRewardTabByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleTowerRewardTabByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x0018E7B8 File Offset: 0x0018C9B8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRewardTabByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRewardTabByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerRewardTab` where ActivityId=?")
			});
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0018E837 File Offset: 0x0018CA37
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRewardTabByActivityId.LogPair = null;
			ConfigRoleTowerRewardTabByActivityId.HandleId = 0;
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0018E845 File Offset: 0x0018CA45
		public static void Init()
		{
			ConfigRoleTowerRewardTabByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRewardTabByActivityId.HandleId, "db_roletower.db", "select BinData from `RoleTowerRewardTab` where ActivityId=?");
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0018E860 File Offset: 0x0018CA60
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerRewardTab> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRewardTabByActivityId.HandleId, ConfigRoleTowerRewardTabByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoleTowerRewardTab> readOnlyList = (IReadOnlyList<RoleTowerRewardTab>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerRewardTabByActivityId.LogPair.Clear();
			ConfigRoleTowerRewardTabByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerRewardTabByActivityId.HandleId, 1, p0ActivityId, ConfigRoleTowerRewardTabByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerRewardTabByActivityId.HandleId, ConfigRoleTowerRewardTabByActivityId.LogPair);
				return null;
			}
			List<RoleTowerRewardTab> list = new List<RoleTowerRewardTab>();
			while (ConfigCommon.Step(ConfigRoleTowerRewardTabByActivityId.HandleId, false, ConfigRoleTowerRewardTabByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRewardTabByActivityId.HandleId, 0, ConfigRoleTowerRewardTabByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerRewardTabByActivityId.HandleId, ConfigRoleTowerRewardTabByActivityId.LogPair);
					return null;
				}
				RoleTowerRewardTab rootAsRoleTowerRewardTab = RoleTowerRewardTab.GetRootAsRoleTowerRewardTab(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerRewardTab);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRewardTabByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerRewardTabByActivityId.HandleId, ConfigRoleTowerRewardTabByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003EED RID: 16109
		private const string DB = "db_roletower.db";

		// Token: 0x04003EEE RID: 16110
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003EEF RID: 16111
		private const string TABLE = "RoleTowerRewardTab";

		// Token: 0x04003EF0 RID: 16112
		private const string COMMAND = "select BinData from `RoleTowerRewardTab` where ActivityId=?";

		// Token: 0x04003EF1 RID: 16113
		private const string KEY_PREFIX = "RoleTowerRewardTabByActivityId";

		// Token: 0x04003EF2 RID: 16114
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EF3 RID: 16115
		private static int HandleId;
	}
}
