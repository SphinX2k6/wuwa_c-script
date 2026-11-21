using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000243 RID: 579
	public class ConfigDrinksRoleInviteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D96 RID: 3478 RVA: 0x000A9F13 File Offset: 0x000A8113
		static ConfigDrinksRoleInviteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRoleInviteAll.CreateStaticDefaultValue), new Action(ConfigDrinksRoleInviteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x000A9F34 File Offset: 0x000A8134
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksRoleInviteAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksRoleInviteAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksRoleInvite"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksRoleInvite`")
			});
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x000A9FB3 File Offset: 0x000A81B3
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRoleInviteAll.LogPair = null;
			ConfigDrinksRoleInviteAll.HandleId = 0;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x000A9FC1 File Offset: 0x000A81C1
		public static void Init()
		{
			ConfigDrinksRoleInviteAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRoleInviteAll.HandleId, "db_drinks.db", "select BinData from `DrinksRoleInvite`");
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000A9FDC File Offset: 0x000A81DC
		[NullableContext(2)]
		public static IReadOnlyList<DrinksRoleInvite> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksRoleInviteAll.HandleId, ConfigDrinksRoleInviteAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DrinksRoleInvite> readOnlyList = (IReadOnlyList<DrinksRoleInvite>)ConfigCommon.GetConfig("DrinksRoleInviteAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DrinksRoleInvite> list = new List<DrinksRoleInvite>();
			while (ConfigCommon.Step(ConfigDrinksRoleInviteAll.HandleId, false, ConfigDrinksRoleInviteAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksRoleInviteAll.HandleId, 0, ConfigDrinksRoleInviteAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDrinksRoleInviteAll.HandleId, ConfigDrinksRoleInviteAll.LogPair);
					return null;
				}
				DrinksRoleInvite rootAsDrinksRoleInvite = DrinksRoleInvite.GetRootAsDrinksRoleInvite(new ByteBuffer(item2));
				list.Add(rootAsDrinksRoleInvite);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DrinksRoleInviteAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDrinksRoleInviteAll.HandleId, ConfigDrinksRoleInviteAll.LogPair);
			return list;
		}

		// Token: 0x04000FB9 RID: 4025
		private const string DB = "db_drinks.db";

		// Token: 0x04000FBA RID: 4026
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000FBB RID: 4027
		private const string TABLE = "DrinksRoleInvite";

		// Token: 0x04000FBC RID: 4028
		private const string COMMAND = "select BinData from `DrinksRoleInvite`";

		// Token: 0x04000FBD RID: 4029
		private const string KEY_PREFIX = "DrinksRoleInviteAll";

		// Token: 0x04000FBE RID: 4030
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FBF RID: 4031
		private static int HandleId;
	}
}
