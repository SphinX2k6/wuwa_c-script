using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DF RID: 2271
	public class ConfigRoleSkinAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600354D RID: 13645 RVA: 0x0018A088 File Offset: 0x00188288
		static ConfigRoleSkinAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinAll.CreateStaticDefaultValue), new Action(ConfigRoleSkinAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0018A0A8 File Offset: 0x001882A8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkin`")
			});
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x0018A127 File Offset: 0x00188327
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinAll.LogPair = null;
			ConfigRoleSkinAll.HandleId = 0;
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x0018A135 File Offset: 0x00188335
		public static void Init()
		{
			ConfigRoleSkinAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinAll.HandleId, "db_role.db", "select BinData from `RoleSkin`");
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0018A150 File Offset: 0x00188350
		[NullableContext(2)]
		public static IReadOnlyList<RoleSkin> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinAll.HandleId, ConfigRoleSkinAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleSkin> readOnlyList = (IReadOnlyList<RoleSkin>)ConfigCommon.GetConfig("RoleSkinAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleSkin> list = new List<RoleSkin>();
			while (ConfigCommon.Step(ConfigRoleSkinAll.HandleId, false, ConfigRoleSkinAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinAll.HandleId, 0, ConfigRoleSkinAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleSkinAll.HandleId, ConfigRoleSkinAll.LogPair);
					return null;
				}
				RoleSkin rootAsRoleSkin = RoleSkin.GetRootAsRoleSkin(new ByteBuffer(item2));
				list.Add(rootAsRoleSkin);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleSkinAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleSkinAll.HandleId, ConfigRoleSkinAll.LogPair);
			return list;
		}

		// Token: 0x04003DFF RID: 15871
		private const string DB = "db_role.db";

		// Token: 0x04003E00 RID: 15872
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003E01 RID: 15873
		private const string TABLE = "RoleSkin";

		// Token: 0x04003E02 RID: 15874
		private const string COMMAND = "select BinData from `RoleSkin`";

		// Token: 0x04003E03 RID: 15875
		private const string KEY_PREFIX = "RoleSkinAll";

		// Token: 0x04003E04 RID: 15876
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E05 RID: 15877
		private static int HandleId;
	}
}
