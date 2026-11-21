using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DB RID: 2267
	public class ConfigRoleQuestByRoleIdAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003535 RID: 13621 RVA: 0x00189788 File Offset: 0x00187988
		static ConfigRoleQuestByRoleIdAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleQuestByRoleIdAll.CreateStaticDefaultValue), new Action(ConfigRoleQuestByRoleIdAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x001897A8 File Offset: 0x001879A8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleQuestByRoleIdAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleQuestByRoleIdAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rolequest.db"),
				new ValueTuple<string, object>("文件", "j.角色任务.xlsx"),
				new ValueTuple<string, object>("表名", "RoleQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleQuest` where RoleId =?")
			});
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x00189827 File Offset: 0x00187A27
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleQuestByRoleIdAll.LogPair = null;
			ConfigRoleQuestByRoleIdAll.HandleId = 0;
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00189835 File Offset: 0x00187A35
		public static void Init()
		{
			ConfigRoleQuestByRoleIdAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleQuestByRoleIdAll.HandleId, "db_rolequest.db", "select BinData from `RoleQuest` where RoleId =?");
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00189850 File Offset: 0x00187A50
		[NullableContext(2)]
		public static IReadOnlyList<RoleQuest> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleQuestByRoleIdAll.HandleId, ConfigRoleQuestByRoleIdAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQuestByRoleIdAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<RoleQuest> readOnlyList = (IReadOnlyList<RoleQuest>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleQuestByRoleIdAll.LogPair.Clear();
			ConfigRoleQuestByRoleIdAll.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleQuestByRoleIdAll.HandleId, 1, p0RoleId, ConfigRoleQuestByRoleIdAll.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleQuestByRoleIdAll.HandleId, ConfigRoleQuestByRoleIdAll.LogPair);
				return null;
			}
			List<RoleQuest> list = new List<RoleQuest>();
			while (ConfigCommon.Step(ConfigRoleQuestByRoleIdAll.HandleId, false, ConfigRoleQuestByRoleIdAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleQuestByRoleIdAll.HandleId, 0, ConfigRoleQuestByRoleIdAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleQuestByRoleIdAll.HandleId, ConfigRoleQuestByRoleIdAll.LogPair);
					return null;
				}
				RoleQuest rootAsRoleQuest = RoleQuest.GetRootAsRoleQuest(new ByteBuffer(item2));
				list.Add(rootAsRoleQuest);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleQuestByRoleIdAll");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleQuestByRoleIdAll.HandleId, ConfigRoleQuestByRoleIdAll.LogPair);
			return list;
		}

		// Token: 0x04003DE3 RID: 15843
		private const string DB = "db_rolequest.db";

		// Token: 0x04003DE4 RID: 15844
		private const string FILE = "j.角色任务.xlsx";

		// Token: 0x04003DE5 RID: 15845
		private const string TABLE = "RoleQuest";

		// Token: 0x04003DE6 RID: 15846
		private const string COMMAND = "select BinData from `RoleQuest` where RoleId =?";

		// Token: 0x04003DE7 RID: 15847
		private const string KEY_PREFIX = "RoleQuestByRoleIdAll";

		// Token: 0x04003DE8 RID: 15848
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DE9 RID: 15849
		private static int HandleId;
	}
}
