using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000438 RID: 1080
	public class ConfigInfrV2PopupMsgAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600195A RID: 6490 RVA: 0x000E8EB8 File Offset: 0x000E70B8
		static ConfigInfrV2PopupMsgAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2PopupMsgAll.CreateStaticDefaultValue), new Action(ConfigInfrV2PopupMsgAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x000E8ED8 File Offset: 0x000E70D8
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

		// Token: 0x0600195C RID: 6492 RVA: 0x000E8F57 File Offset: 0x000E7157
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2PopupMsgAll.LogPair = null;
			ConfigInfrV2PopupMsgAll.HandleId = 0;
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x000E8F65 File Offset: 0x000E7165
		public static void Init()
		{
			ConfigInfrV2PopupMsgAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2PopupMsgAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2PopupMsg`");
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x000E8F80 File Offset: 0x000E7180
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

		// Token: 0x04001D6C RID: 7532
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001D6D RID: 7533
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001D6E RID: 7534
		private const string TABLE = "InfrV2PopupMsg";

		// Token: 0x04001D6F RID: 7535
		private const string COMMAND = "select BinData from `InfrV2PopupMsg`";

		// Token: 0x04001D70 RID: 7536
		private const string KEY_PREFIX = "InfrV2PopupMsgAll";

		// Token: 0x04001D71 RID: 7537
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D72 RID: 7538
		private static int HandleId;
	}
}
