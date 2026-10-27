using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000231 RID: 561
	public class ConfigDrinksRoleInviteAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x000A3FDB File Offset: 0x000A21DB
		static ConfigDrinksRoleInviteAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksRoleInviteAll.CreateStaticDefaultValue), new Action(ConfigDrinksRoleInviteAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000A3FFC File Offset: 0x000A21FC
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

		// Token: 0x06000D2C RID: 3372 RVA: 0x000A407B File Offset: 0x000A227B
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksRoleInviteAll.LogPair = null;
			ConfigDrinksRoleInviteAll.HandleId = 0;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000A4089 File Offset: 0x000A2289
		public static void Init()
		{
			ConfigDrinksRoleInviteAll.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksRoleInviteAll.HandleId, "db_drinks.db", "select BinData from `DrinksRoleInvite`");
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000A40A4 File Offset: 0x000A22A4
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

		// Token: 0x04000F3B RID: 3899
		private const string DB = "db_drinks.db";

		// Token: 0x04000F3C RID: 3900
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F3D RID: 3901
		private const string TABLE = "DrinksRoleInvite";

		// Token: 0x04000F3E RID: 3902
		private const string COMMAND = "select BinData from `DrinksRoleInvite`";

		// Token: 0x04000F3F RID: 3903
		private const string KEY_PREFIX = "DrinksRoleInviteAll";

		// Token: 0x04000F40 RID: 3904
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F41 RID: 3905
		private static int HandleId;
	}
}
