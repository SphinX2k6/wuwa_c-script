using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000910 RID: 2320
	public class ConfigRoleTowerTokenAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003673 RID: 13939 RVA: 0x0019061C File Offset: 0x0018E81C
		static ConfigRoleTowerTokenAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerTokenAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerTokenAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x0019063C File Offset: 0x0018E83C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerTokenAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerTokenAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_信物.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerToken"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerToken`")
			});
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x001906BB File Offset: 0x0018E8BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerTokenAll.LogPair = null;
			ConfigRoleTowerTokenAll.HandleId = 0;
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x001906C9 File Offset: 0x0018E8C9
		public static void Init()
		{
			ConfigRoleTowerTokenAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerTokenAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerToken`");
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x001906E4 File Offset: 0x0018E8E4
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerToken> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerTokenAll.HandleId, ConfigRoleTowerTokenAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerToken> readOnlyList = (IReadOnlyList<RoleTowerToken>)ConfigCommon.GetConfig("RoleTowerTokenAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerToken> list = new List<RoleTowerToken>();
			while (ConfigCommon.Step(ConfigRoleTowerTokenAll.HandleId, false, ConfigRoleTowerTokenAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerTokenAll.HandleId, 0, ConfigRoleTowerTokenAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerTokenAll.HandleId, ConfigRoleTowerTokenAll.LogPair);
					return null;
				}
				RoleTowerToken rootAsRoleTowerToken = RoleTowerToken.GetRootAsRoleTowerToken(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerToken);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerTokenAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerTokenAll.HandleId, ConfigRoleTowerTokenAll.LogPair);
			return list;
		}

		// Token: 0x04003F56 RID: 16214
		private const string DB = "db_roletower.db";

		// Token: 0x04003F57 RID: 16215
		private const string FILE = "j.角色爬塔_信物.xlsx";

		// Token: 0x04003F58 RID: 16216
		private const string TABLE = "RoleTowerToken";

		// Token: 0x04003F59 RID: 16217
		private const string COMMAND = "select BinData from `RoleTowerToken`";

		// Token: 0x04003F5A RID: 16218
		private const string KEY_PREFIX = "RoleTowerTokenAll";

		// Token: 0x04003F5B RID: 16219
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F5C RID: 16220
		private static int HandleId;
	}
}
