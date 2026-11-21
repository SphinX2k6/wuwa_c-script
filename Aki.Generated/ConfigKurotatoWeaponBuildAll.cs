using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D6 RID: 1238
	public class ConfigKurotatoWeaponBuildAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D0F RID: 7439 RVA: 0x00100FD3 File Offset: 0x000FF1D3
		static ConfigKurotatoWeaponBuildAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWeaponBuildAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWeaponBuildAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00100FF4 File Offset: 0x000FF1F4
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

		// Token: 0x06001D11 RID: 7441 RVA: 0x00101073 File Offset: 0x000FF273
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWeaponBuildAll.LogPair = null;
			ConfigKurotatoWeaponBuildAll.HandleId = 0;
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00101081 File Offset: 0x000FF281
		public static void Init()
		{
			ConfigKurotatoWeaponBuildAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWeaponBuildAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWeaponBuild`");
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0010109C File Offset: 0x000FF29C
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

		// Token: 0x040021BE RID: 8638
		private const string DB = "db_kurotato.db";

		// Token: 0x040021BF RID: 8639
		private const string FILE = "t.土豆兄弟_武器.xlsx";

		// Token: 0x040021C0 RID: 8640
		private const string TABLE = "KurotatoWeaponBuild";

		// Token: 0x040021C1 RID: 8641
		private const string COMMAND = "select BinData from `KurotatoWeaponBuild`";

		// Token: 0x040021C2 RID: 8642
		private const string KEY_PREFIX = "KurotatoWeaponBuildAll";

		// Token: 0x040021C3 RID: 8643
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021C4 RID: 8644
		private static int HandleId;
	}
}
