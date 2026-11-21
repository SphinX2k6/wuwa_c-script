using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061B RID: 1563
	public class ConfigNewTowerRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024B2 RID: 9394 RVA: 0x0012C8A4 File Offset: 0x0012AAA4
		static ConfigNewTowerRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerRoleAll.CreateStaticDefaultValue), new Action(ConfigNewTowerRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x0012C8C4 File Offset: 0x0012AAC4
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerRole"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerRole`")
			});
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0012C943 File Offset: 0x0012AB43
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerRoleAll.LogPair = null;
			ConfigNewTowerRoleAll.HandleId = 0;
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0012C951 File Offset: 0x0012AB51
		public static void Init()
		{
			ConfigNewTowerRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerRoleAll.HandleId, "db_newtower.db", "select BinData from `NewTowerRole`");
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x0012C96C File Offset: 0x0012AB6C
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerRoleAll.HandleId, ConfigNewTowerRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewTowerRole> readOnlyList = (IReadOnlyList<NewTowerRole>)ConfigCommon.GetConfig("NewTowerRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewTowerRole> list = new List<NewTowerRole>();
			while (ConfigCommon.Step(ConfigNewTowerRoleAll.HandleId, false, ConfigNewTowerRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerRoleAll.HandleId, 0, ConfigNewTowerRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerRoleAll.HandleId, ConfigNewTowerRoleAll.LogPair);
					return null;
				}
				NewTowerRole rootAsNewTowerRole = NewTowerRole.GetRootAsNewTowerRole(new ByteBuffer(item2));
				list.Add(rootAsNewTowerRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewTowerRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerRoleAll.HandleId, ConfigNewTowerRoleAll.LogPair);
			return list;
		}

		// Token: 0x04002AA3 RID: 10915
		private const string DB = "db_newtower.db";

		// Token: 0x04002AA4 RID: 10916
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AA5 RID: 10917
		private const string TABLE = "NewTowerRole";

		// Token: 0x04002AA6 RID: 10918
		private const string COMMAND = "select BinData from `NewTowerRole`";

		// Token: 0x04002AA7 RID: 10919
		private const string KEY_PREFIX = "NewTowerRoleAll";

		// Token: 0x04002AA8 RID: 10920
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AA9 RID: 10921
		private static int HandleId;
	}
}
