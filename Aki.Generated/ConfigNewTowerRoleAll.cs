using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000603 RID: 1539
	public class ConfigNewTowerRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002422 RID: 9250 RVA: 0x00125E28 File Offset: 0x00124028
		static ConfigNewTowerRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerRoleAll.CreateStaticDefaultValue), new Action(ConfigNewTowerRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00125E48 File Offset: 0x00124048
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

		// Token: 0x06002424 RID: 9252 RVA: 0x00125EC7 File Offset: 0x001240C7
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerRoleAll.LogPair = null;
			ConfigNewTowerRoleAll.HandleId = 0;
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00125ED5 File Offset: 0x001240D5
		public static void Init()
		{
			ConfigNewTowerRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerRoleAll.HandleId, "db_newtower.db", "select BinData from `NewTowerRole`");
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00125EF0 File Offset: 0x001240F0
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

		// Token: 0x040029FB RID: 10747
		private const string DB = "db_newtower.db";

		// Token: 0x040029FC RID: 10748
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029FD RID: 10749
		private const string TABLE = "NewTowerRole";

		// Token: 0x040029FE RID: 10750
		private const string COMMAND = "select BinData from `NewTowerRole`";

		// Token: 0x040029FF RID: 10751
		private const string KEY_PREFIX = "NewTowerRoleAll";

		// Token: 0x04002A00 RID: 10752
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A01 RID: 10753
		private static int HandleId;
	}
}
