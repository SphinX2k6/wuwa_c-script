using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DE RID: 222
	public class ConfigBabelTowerDeTermAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000535 RID: 1333 RVA: 0x0007AB5C File Offset: 0x00078D5C
		static ConfigBabelTowerDeTermAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDeTermAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerDeTermAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0007AB7C File Offset: 0x00078D7C
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

		// Token: 0x06000537 RID: 1335 RVA: 0x0007ABFB File Offset: 0x00078DFB
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDeTermAll.LogPair = null;
			ConfigBabelTowerDeTermAll.HandleId = 0;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0007AC09 File Offset: 0x00078E09
		public static void Init()
		{
			ConfigBabelTowerDeTermAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDeTermAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDeTerm`");
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0007AC24 File Offset: 0x00078E24
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

		// Token: 0x040005F6 RID: 1526
		private const string DB = "db_babeltower.db";

		// Token: 0x040005F7 RID: 1527
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005F8 RID: 1528
		private const string TABLE = "BabelTowerDeTerm";

		// Token: 0x040005F9 RID: 1529
		private const string COMMAND = "select BinData from `BabelTowerDeTerm`";

		// Token: 0x040005FA RID: 1530
		private const string KEY_PREFIX = "BabelTowerDeTermAll";

		// Token: 0x040005FB RID: 1531
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005FC RID: 1532
		private static int HandleId;
	}
}
