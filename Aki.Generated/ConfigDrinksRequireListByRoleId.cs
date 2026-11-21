using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000242 RID: 578
	public class ConfigDrinksRequireListByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D90 RID: 3472 RVA: 0x000A9CDC File Offset: 0x000A7EDC
		static ConfigDrinksRequireListByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRequireListByRoleId.CreateStaticDefaultValue), new Action(ConfigDrinksRequireListByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000A9CFC File Offset: 0x000A7EFC
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksRequireListByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksRequireListByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksRequireList"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksRequireList` where RoleId=?")
			});
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000A9D7B File Offset: 0x000A7F7B
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRequireListByRoleId.LogPair = null;
			ConfigDrinksRequireListByRoleId.HandleId = 0;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000A9D89 File Offset: 0x000A7F89
		public static void Init()
		{
			ConfigDrinksRequireListByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRequireListByRoleId.HandleId, "db_drinks.db", "select BinData from `DrinksRequireList` where RoleId=?");
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000A9DA4 File Offset: 0x000A7FA4
		[NullableContext(2)]
		public static IReadOnlyList<DrinksRequireList> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksRequireListByRoleId.HandleId, ConfigDrinksRequireListByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksRequireListByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<DrinksRequireList> readOnlyList = (IReadOnlyList<DrinksRequireList>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDrinksRequireListByRoleId.LogPair.Clear();
			ConfigDrinksRequireListByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigDrinksRequireListByRoleId.HandleId, 1, p0RoleId, ConfigDrinksRequireListByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigDrinksRequireListByRoleId.HandleId, ConfigDrinksRequireListByRoleId.LogPair);
				return null;
			}
			List<DrinksRequireList> list = new List<DrinksRequireList>();
			while (ConfigCommon.Step(ConfigDrinksRequireListByRoleId.HandleId, false, ConfigDrinksRequireListByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksRequireListByRoleId.HandleId, 0, ConfigDrinksRequireListByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDrinksRequireListByRoleId.HandleId, ConfigDrinksRequireListByRoleId.LogPair);
					return null;
				}
				DrinksRequireList rootAsDrinksRequireList = DrinksRequireList.GetRootAsDrinksRequireList(new ByteBuffer(item2));
				list.Add(rootAsDrinksRequireList);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DrinksRequireListByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDrinksRequireListByRoleId.HandleId, ConfigDrinksRequireListByRoleId.LogPair);
			return list;
		}

		// Token: 0x04000FB2 RID: 4018
		private const string DB = "db_drinks.db";

		// Token: 0x04000FB3 RID: 4019
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000FB4 RID: 4020
		private const string TABLE = "DrinksRequireList";

		// Token: 0x04000FB5 RID: 4021
		private const string COMMAND = "select BinData from `DrinksRequireList` where RoleId=?";

		// Token: 0x04000FB6 RID: 4022
		private const string KEY_PREFIX = "DrinksRequireListByRoleId";

		// Token: 0x04000FB7 RID: 4023
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FB8 RID: 4024
		private static int HandleId;
	}
}
