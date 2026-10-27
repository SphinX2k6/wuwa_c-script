using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000230 RID: 560
	public class ConfigDrinksRequireListByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D24 RID: 3364 RVA: 0x000A3DA4 File Offset: 0x000A1FA4
		static ConfigDrinksRequireListByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRequireListByRoleId.CreateStaticDefaultValue), new Action(ConfigDrinksRequireListByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x000A3DC4 File Offset: 0x000A1FC4
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

		// Token: 0x06000D26 RID: 3366 RVA: 0x000A3E43 File Offset: 0x000A2043
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRequireListByRoleId.LogPair = null;
			ConfigDrinksRequireListByRoleId.HandleId = 0;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x000A3E51 File Offset: 0x000A2051
		public static void Init()
		{
			ConfigDrinksRequireListByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRequireListByRoleId.HandleId, "db_drinks.db", "select BinData from `DrinksRequireList` where RoleId=?");
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x000A3E6C File Offset: 0x000A206C
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

		// Token: 0x04000F34 RID: 3892
		private const string DB = "db_drinks.db";

		// Token: 0x04000F35 RID: 3893
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F36 RID: 3894
		private const string TABLE = "DrinksRequireList";

		// Token: 0x04000F37 RID: 3895
		private const string COMMAND = "select BinData from `DrinksRequireList` where RoleId=?";

		// Token: 0x04000F38 RID: 3896
		private const string KEY_PREFIX = "DrinksRequireListByRoleId";

		// Token: 0x04000F39 RID: 3897
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F3A RID: 3898
		private static int HandleId;
	}
}
