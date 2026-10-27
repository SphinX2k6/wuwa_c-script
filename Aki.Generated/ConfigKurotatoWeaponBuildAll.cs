using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C0 RID: 1216
	public class ConfigKurotatoWeaponBuildAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C8B RID: 7307 RVA: 0x000FA87F File Offset: 0x000F8A7F
		static ConfigKurotatoWeaponBuildAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponBuildAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponBuildAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x000FA8A0 File Offset: 0x000F8AA0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponBuildAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponBuildAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeaponBuild"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeaponBuild`")
			});
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x000FA91F File Offset: 0x000F8B1F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponBuildAll.LogPair = null;
			ConfigKurotatoWeaponBuildAll.HandleId = 0;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x000FA92D File Offset: 0x000F8B2D
		public static void Init()
		{
			ConfigKurotatoWeaponBuildAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponBuildAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeaponBuild`");
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x000FA948 File Offset: 0x000F8B48
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoWeaponBuild> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponBuildAll.HandleId, ConfigKurotatoWeaponBuildAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoWeaponBuild> readOnlyList = (IReadOnlyList<KurotatoWeaponBuild>)ConfigCommon.GetConfig("KurotatoWeaponBuildAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoWeaponBuild> list = new List<KurotatoWeaponBuild>();
			while (ConfigCommon.Step(ConfigKurotatoWeaponBuildAll.HandleId, false, ConfigKurotatoWeaponBuildAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponBuildAll.HandleId, 0, ConfigKurotatoWeaponBuildAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoWeaponBuildAll.HandleId, ConfigKurotatoWeaponBuildAll.LogPair);
					return null;
				}
				KurotatoWeaponBuild rootAsKurotatoWeaponBuild = KurotatoWeaponBuild.GetRootAsKurotatoWeaponBuild(new ByteBuffer(item2));
				list.Add(rootAsKurotatoWeaponBuild);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoWeaponBuildAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponBuildAll.HandleId, ConfigKurotatoWeaponBuildAll.LogPair);
			return list;
		}

		// Token: 0x04002124 RID: 8484
		private const string DB = "db_kurotato.db";

		// Token: 0x04002125 RID: 8485
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x04002126 RID: 8486
		private const string TABLE = "KurotatoWeaponBuild";

		// Token: 0x04002127 RID: 8487
		private const string COMMAND = "select BinData from `KurotatoWeaponBuild`";

		// Token: 0x04002128 RID: 8488
		private const string KEY_PREFIX = "KurotatoWeaponBuildAll";

		// Token: 0x04002129 RID: 8489
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400212A RID: 8490
		private static int HandleId;
	}
}
