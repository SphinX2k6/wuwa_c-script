using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C4 RID: 1220
	public class ConfigKurotatoWeaponGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x000FB0DC File Offset: 0x000F92DC
		static ConfigKurotatoWeaponGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponGroupAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x000FB0FC File Offset: 0x000F92FC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWeaponGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWeaponGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_武器.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWeaponGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWeaponGroup`")
			});
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x000FB17B File Offset: 0x000F937B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponGroupAll.LogPair = null;
			ConfigKurotatoWeaponGroupAll.HandleId = 0;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000FB189 File Offset: 0x000F9389
		public static void Init()
		{
			ConfigKurotatoWeaponGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponGroupAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeaponGroup`");
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x000FB1A4 File Offset: 0x000F93A4
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoWeaponGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWeaponGroupAll.HandleId, ConfigKurotatoWeaponGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoWeaponGroup> readOnlyList = (IReadOnlyList<KurotatoWeaponGroup>)ConfigCommon.GetConfig("KurotatoWeaponGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoWeaponGroup> list = new List<KurotatoWeaponGroup>();
			while (ConfigCommon.Step(ConfigKurotatoWeaponGroupAll.HandleId, false, ConfigKurotatoWeaponGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWeaponGroupAll.HandleId, 0, ConfigKurotatoWeaponGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoWeaponGroupAll.HandleId, ConfigKurotatoWeaponGroupAll.LogPair);
					return null;
				}
				KurotatoWeaponGroup rootAsKurotatoWeaponGroup = KurotatoWeaponGroup.GetRootAsKurotatoWeaponGroup(new ByteBuffer(item2));
				list.Add(rootAsKurotatoWeaponGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoWeaponGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoWeaponGroupAll.HandleId, ConfigKurotatoWeaponGroupAll.LogPair);
			return list;
		}

		// Token: 0x04002140 RID: 8512
		private const string DB = "db_kurotato.db";

		// Token: 0x04002141 RID: 8513
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x04002142 RID: 8514
		private const string TABLE = "KurotatoWeaponGroup";

		// Token: 0x04002143 RID: 8515
		private const string COMMAND = "select BinData from `KurotatoWeaponGroup`";

		// Token: 0x04002144 RID: 8516
		private const string KEY_PREFIX = "KurotatoWeaponGroupAll";

		// Token: 0x04002145 RID: 8517
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002146 RID: 8518
		private static int HandleId;
	}
}
