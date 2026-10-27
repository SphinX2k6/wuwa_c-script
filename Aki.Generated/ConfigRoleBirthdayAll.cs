using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088A RID: 2186
	public class ConfigRoleBirthdayAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600334E RID: 13134 RVA: 0x0017B6DC File Offset: 0x001798DC
		static ConfigRoleBirthdayAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBirthdayAll.CreateStaticDefaultValue), new Action(ConfigRoleBirthdayAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0017B6FC File Offset: 0x001798FC
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

		// Token: 0x06003350 RID: 13136 RVA: 0x0017B77B File Offset: 0x0017997B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBirthdayAll.LogPair = null;
			ConfigRoleBirthdayAll.HandleId = 0;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x0017B789 File Offset: 0x00179989
		public static void Init()
		{
			ConfigRoleBirthdayAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBirthdayAll.HandleId, "db_birthday.db", "select BinData from `RoleBirthday`");
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x0017B7A4 File Offset: 0x001799A4
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

		// Token: 0x04003BAC RID: 15276
		private const string DB = "db_birthday.db";

		// Token: 0x04003BAD RID: 15277
		private const string FILE = "s.生日.xlsx";

		// Token: 0x04003BAE RID: 15278
		private const string TABLE = "RoleBirthday";

		// Token: 0x04003BAF RID: 15279
		private const string COMMAND = "select BinData from `RoleBirthday`";

		// Token: 0x04003BB0 RID: 15280
		private const string KEY_PREFIX = "RoleBirthdayAll";

		// Token: 0x04003BB1 RID: 15281
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BB2 RID: 15282
		private static int HandleId;
	}
}
