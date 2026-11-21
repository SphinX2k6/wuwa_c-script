using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABF RID: 2751
	public class ConfigTotalTopUpRotationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600408E RID: 16526 RVA: 0x001C9D84 File Offset: 0x001C7F84
		static ConfigTotalTopUpRotationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRotationAll.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRotationAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x001C9DA4 File Offset: 0x001C7FA4
		public static void CreateStaticDefaultValue()
		{
			ConfigTotalTopUpRotationAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTotalTopUpRotationAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_totaltopup.db"),
				new ValueTuple<string, object>("文件", "l.累充活动.xlsx"),
				new ValueTuple<string, object>("表名", "TotalTopUpRotation"),
				new ValueTuple<string, object>("语句", "select BinData from `TotalTopUpRotation`")
			});
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x001C9E23 File Offset: 0x001C8023
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRotationAll.LogPair = null;
			ConfigTotalTopUpRotationAll.HandleId = 0;
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x001C9E31 File Offset: 0x001C8031
		public static void Init()
		{
			ConfigTotalTopUpRotationAll.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRotationAll.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpRotation`");
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x001C9E4C File Offset: 0x001C804C
		[NullableContext(2)]
		public static IReadOnlyList<TotalTopUpRotation> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTotalTopUpRotationAll.HandleId, ConfigTotalTopUpRotationAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TotalTopUpRotation> readOnlyList = (IReadOnlyList<TotalTopUpRotation>)ConfigCommon.GetConfig("TotalTopUpRotationAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TotalTopUpRotation> list = new List<TotalTopUpRotation>();
			while (ConfigCommon.Step(ConfigTotalTopUpRotationAll.HandleId, false, ConfigTotalTopUpRotationAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTotalTopUpRotationAll.HandleId, 0, ConfigTotalTopUpRotationAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTotalTopUpRotationAll.HandleId, ConfigTotalTopUpRotationAll.LogPair);
					return null;
				}
				TotalTopUpRotation rootAsTotalTopUpRotation = TotalTopUpRotation.GetRootAsTotalTopUpRotation(new ByteBuffer(item2));
				list.Add(rootAsTotalTopUpRotation);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TotalTopUpRotationAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTotalTopUpRotationAll.HandleId, ConfigTotalTopUpRotationAll.LogPair);
			return list;
		}

		// Token: 0x04004B1F RID: 19231
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004B20 RID: 19232
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004B21 RID: 19233
		private const string TABLE = "TotalTopUpRotation";

		// Token: 0x04004B22 RID: 19234
		private const string COMMAND = "select BinData from `TotalTopUpRotation`";

		// Token: 0x04004B23 RID: 19235
		private const string KEY_PREFIX = "TotalTopUpRotationAll";

		// Token: 0x04004B24 RID: 19236
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B25 RID: 19237
		private static int HandleId;
	}
}
