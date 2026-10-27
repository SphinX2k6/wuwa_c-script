using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BF RID: 2239
	public class ConfigRoleQuestByRoleIdAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600348D RID: 13453 RVA: 0x001824A0 File Offset: 0x001806A0
		static ConfigRoleQuestByRoleIdAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleQuestByRoleIdAll.CreateStaticDefaultValue), new Action(ConfigRoleQuestByRoleIdAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x001824C0 File Offset: 0x001806C0
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

		// Token: 0x0600348F RID: 13455 RVA: 0x0018253F File Offset: 0x0018073F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleQuestByRoleIdAll.LogPair = null;
			ConfigRoleQuestByRoleIdAll.HandleId = 0;
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x0018254D File Offset: 0x0018074D
		public static void Init()
		{
			ConfigRoleQuestByRoleIdAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleQuestByRoleIdAll.HandleId, "db_rolequest.db", "select BinData from `RoleQuest` where RoleId =?");
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00182568 File Offset: 0x00180768
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

		// Token: 0x04003D1F RID: 15647
		private const string DB = "db_rolequest.db";

		// Token: 0x04003D20 RID: 15648
		private const string FILE = "j.角色任务.xlsx";

		// Token: 0x04003D21 RID: 15649
		private const string TABLE = "RoleQuest";

		// Token: 0x04003D22 RID: 15650
		private const string COMMAND = "select BinData from `RoleQuest` where RoleId =?";

		// Token: 0x04003D23 RID: 15651
		private const string KEY_PREFIX = "RoleQuestByRoleIdAll";

		// Token: 0x04003D24 RID: 15652
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D25 RID: 15653
		private static int HandleId;
	}
}
