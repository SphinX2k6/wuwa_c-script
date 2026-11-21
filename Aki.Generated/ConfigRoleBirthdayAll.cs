using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A6 RID: 2214
	public class ConfigRoleBirthdayAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033F6 RID: 13302 RVA: 0x001829C4 File Offset: 0x00180BC4
		static ConfigRoleBirthdayAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBirthdayAll.CreateStaticDefaultValue), new Action(ConfigRoleBirthdayAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x001829E4 File Offset: 0x00180BE4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBirthdayAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBirthdayAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_birthday.db"),
				new ValueTuple<string, object>("文件", "s.生日.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBirthday"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBirthday`")
			});
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00182A63 File Offset: 0x00180C63
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBirthdayAll.LogPair = null;
			ConfigRoleBirthdayAll.HandleId = 0;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00182A71 File Offset: 0x00180C71
		public static void Init()
		{
			ConfigRoleBirthdayAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBirthdayAll.HandleId, "db_birthday.db", "select BinData from `RoleBirthday`");
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00182A8C File Offset: 0x00180C8C
		[NullableContext(2)]
		public static IReadOnlyList<RoleBirthday> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBirthdayAll.HandleId, ConfigRoleBirthdayAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleBirthday> readOnlyList = (IReadOnlyList<RoleBirthday>)ConfigCommon.GetConfig("RoleBirthdayAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleBirthday> list = new List<RoleBirthday>();
			while (ConfigCommon.Step(ConfigRoleBirthdayAll.HandleId, false, ConfigRoleBirthdayAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBirthdayAll.HandleId, 0, ConfigRoleBirthdayAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleBirthdayAll.HandleId, ConfigRoleBirthdayAll.LogPair);
					return null;
				}
				RoleBirthday rootAsRoleBirthday = RoleBirthday.GetRootAsRoleBirthday(new ByteBuffer(item2));
				list.Add(rootAsRoleBirthday);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleBirthdayAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleBirthdayAll.HandleId, ConfigRoleBirthdayAll.LogPair);
			return list;
		}

		// Token: 0x04003C70 RID: 15472
		private const string DB = "db_birthday.db";

		// Token: 0x04003C71 RID: 15473
		private const string FILE = "s.生日.xlsx";

		// Token: 0x04003C72 RID: 15474
		private const string TABLE = "RoleBirthday";

		// Token: 0x04003C73 RID: 15475
		private const string COMMAND = "select BinData from `RoleBirthday`";

		// Token: 0x04003C74 RID: 15476
		private const string KEY_PREFIX = "RoleBirthdayAll";

		// Token: 0x04003C75 RID: 15477
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C76 RID: 15478
		private static int HandleId;
	}
}
