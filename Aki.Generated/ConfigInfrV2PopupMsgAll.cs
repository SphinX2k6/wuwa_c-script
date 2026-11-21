using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044E RID: 1102
	public class ConfigInfrV2PopupMsgAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x000EF60C File Offset: 0x000ED80C
		static ConfigInfrV2PopupMsgAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2PopupMsgAll.CreateStaticDefaultValue), new Action(ConfigInfrV2PopupMsgAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000EF62C File Offset: 0x000ED82C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2PopupMsgAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2PopupMsgAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2PopupMsg"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2PopupMsg`")
			});
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000EF6AB File Offset: 0x000ED8AB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2PopupMsgAll.LogPair = null;
			ConfigInfrV2PopupMsgAll.HandleId = 0;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x000EF6B9 File Offset: 0x000ED8B9
		public static void Init()
		{
			ConfigInfrV2PopupMsgAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2PopupMsgAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2PopupMsg`");
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x000EF6D4 File Offset: 0x000ED8D4
		[NullableContext(2)]
		public static IReadOnlyList<InfrV2PopupMsg> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2PopupMsgAll.HandleId, ConfigInfrV2PopupMsgAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrV2PopupMsg> readOnlyList = (IReadOnlyList<InfrV2PopupMsg>)ConfigCommon.GetConfig("InfrV2PopupMsgAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrV2PopupMsg> list = new List<InfrV2PopupMsg>();
			while (ConfigCommon.Step(ConfigInfrV2PopupMsgAll.HandleId, false, ConfigInfrV2PopupMsgAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2PopupMsgAll.HandleId, 0, ConfigInfrV2PopupMsgAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrV2PopupMsgAll.HandleId, ConfigInfrV2PopupMsgAll.LogPair);
					return null;
				}
				InfrV2PopupMsg rootAsInfrV2PopupMsg = InfrV2PopupMsg.GetRootAsInfrV2PopupMsg(new ByteBuffer(item2));
				list.Add(rootAsInfrV2PopupMsg);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrV2PopupMsgAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrV2PopupMsgAll.HandleId, ConfigInfrV2PopupMsgAll.LogPair);
			return list;
		}

		// Token: 0x04001E06 RID: 7686
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E07 RID: 7687
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E08 RID: 7688
		private const string TABLE = "InfrV2PopupMsg";

		// Token: 0x04001E09 RID: 7689
		private const string COMMAND = "select BinData from `InfrV2PopupMsg`";

		// Token: 0x04001E0A RID: 7690
		private const string KEY_PREFIX = "InfrV2PopupMsgAll";

		// Token: 0x04001E0B RID: 7691
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E0C RID: 7692
		private static int HandleId;
	}
}
