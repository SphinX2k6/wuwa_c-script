using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CF RID: 207
	public class ConfigBabelTowerDeTermAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004DB RID: 1243 RVA: 0x000751F8 File Offset: 0x000733F8
		static ConfigBabelTowerDeTermAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDeTermAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerDeTermAll.ResetStaticDefaultValue));
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00075218 File Offset: 0x00073418
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDeTermAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDeTermAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDeTerm"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDeTerm`")
			});
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00075297 File Offset: 0x00073497
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDeTermAll.LogPair = null;
			ConfigBabelTowerDeTermAll.HandleId = 0;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000752A5 File Offset: 0x000734A5
		public static void Init()
		{
			ConfigBabelTowerDeTermAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDeTermAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDeTerm`");
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000752C0 File Offset: 0x000734C0
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerDeTerm> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDeTermAll.HandleId, ConfigBabelTowerDeTermAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerDeTerm> readOnlyList = (IReadOnlyList<BabelTowerDeTerm>)ConfigCommon.GetConfig("BabelTowerDeTermAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerDeTerm> list = new List<BabelTowerDeTerm>();
			while (ConfigCommon.Step(ConfigBabelTowerDeTermAll.HandleId, false, ConfigBabelTowerDeTermAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDeTermAll.HandleId, 0, ConfigBabelTowerDeTermAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerDeTermAll.HandleId, ConfigBabelTowerDeTermAll.LogPair);
					return null;
				}
				BabelTowerDeTerm rootAsBabelTowerDeTerm = BabelTowerDeTerm.GetRootAsBabelTowerDeTerm(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerDeTerm);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerDeTermAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerDeTermAll.HandleId, ConfigBabelTowerDeTermAll.LogPair);
			return list;
		}

		// Token: 0x0400058D RID: 1421
		private const string DB = "db_babeltower.db";

		// Token: 0x0400058E RID: 1422
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400058F RID: 1423
		private const string TABLE = "BabelTowerDeTerm";

		// Token: 0x04000590 RID: 1424
		private const string COMMAND = "select BinData from `BabelTowerDeTerm`";

		// Token: 0x04000591 RID: 1425
		private const string KEY_PREFIX = "BabelTowerDeTermAll";

		// Token: 0x04000592 RID: 1426
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000593 RID: 1427
		private static int HandleId;
	}
}
