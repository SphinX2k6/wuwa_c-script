using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CB RID: 203
	public class ConfigBabelTowerBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00074A40 File Offset: 0x00072C40
		static ConfigBabelTowerBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerBuffAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00074A60 File Offset: 0x00072C60
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerBuffAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerBuffAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerBuff`")
			});
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00074ADF File Offset: 0x00072CDF
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerBuffAll.LogPair = null;
			ConfigBabelTowerBuffAll.HandleId = 0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00074AED File Offset: 0x00072CED
		public static void Init()
		{
			ConfigBabelTowerBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerBuffAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerBuff`");
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00074B08 File Offset: 0x00072D08
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerBuff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerBuffAll.HandleId, ConfigBabelTowerBuffAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerBuff> readOnlyList = (IReadOnlyList<BabelTowerBuff>)ConfigCommon.GetConfig("BabelTowerBuffAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerBuff> list = new List<BabelTowerBuff>();
			while (ConfigCommon.Step(ConfigBabelTowerBuffAll.HandleId, false, ConfigBabelTowerBuffAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerBuffAll.HandleId, 0, ConfigBabelTowerBuffAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerBuffAll.HandleId, ConfigBabelTowerBuffAll.LogPair);
					return null;
				}
				BabelTowerBuff rootAsBabelTowerBuff = BabelTowerBuff.GetRootAsBabelTowerBuff(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerBuffAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerBuffAll.HandleId, ConfigBabelTowerBuffAll.LogPair);
			return list;
		}

		// Token: 0x04000571 RID: 1393
		private const string DB = "db_babeltower.db";

		// Token: 0x04000572 RID: 1394
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000573 RID: 1395
		private const string TABLE = "BabelTowerBuff";

		// Token: 0x04000574 RID: 1396
		private const string COMMAND = "select BinData from `BabelTowerBuff`";

		// Token: 0x04000575 RID: 1397
		private const string KEY_PREFIX = "BabelTowerBuffAll";

		// Token: 0x04000576 RID: 1398
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000577 RID: 1399
		private static int HandleId;
	}
}
