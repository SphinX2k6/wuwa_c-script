using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000445 RID: 1093
	public class ConfigInfrPhoneMessageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019A7 RID: 6567 RVA: 0x000EE2EC File Offset: 0x000EC4EC
		static ConfigInfrPhoneMessageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPhoneMessageAll.CreateStaticDefaultValue), new Action(ConfigInfrPhoneMessageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000EE30C File Offset: 0x000EC50C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrPhoneMessageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrPhoneMessageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrPhoneMessage"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrPhoneMessage`")
			});
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x000EE38B File Offset: 0x000EC58B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPhoneMessageAll.LogPair = null;
			ConfigInfrPhoneMessageAll.HandleId = 0;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x000EE399 File Offset: 0x000EC599
		public static void Init()
		{
			ConfigInfrPhoneMessageAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPhoneMessageAll.HandleId, "db_infrastructure.db", "select BinData from `InfrPhoneMessage`");
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000EE3B4 File Offset: 0x000EC5B4
		[NullableContext(2)]
		public static IReadOnlyList<InfrPhoneMessage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrPhoneMessageAll.HandleId, ConfigInfrPhoneMessageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrPhoneMessage> readOnlyList = (IReadOnlyList<InfrPhoneMessage>)ConfigCommon.GetConfig("InfrPhoneMessageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrPhoneMessage> list = new List<InfrPhoneMessage>();
			while (ConfigCommon.Step(ConfigInfrPhoneMessageAll.HandleId, false, ConfigInfrPhoneMessageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrPhoneMessageAll.HandleId, 0, ConfigInfrPhoneMessageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrPhoneMessageAll.HandleId, ConfigInfrPhoneMessageAll.LogPair);
					return null;
				}
				InfrPhoneMessage rootAsInfrPhoneMessage = InfrPhoneMessage.GetRootAsInfrPhoneMessage(new ByteBuffer(item2));
				list.Add(rootAsInfrPhoneMessage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrPhoneMessageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrPhoneMessageAll.HandleId, ConfigInfrPhoneMessageAll.LogPair);
			return list;
		}

		// Token: 0x04001DC7 RID: 7623
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DC8 RID: 7624
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001DC9 RID: 7625
		private const string TABLE = "InfrPhoneMessage";

		// Token: 0x04001DCA RID: 7626
		private const string COMMAND = "select BinData from `InfrPhoneMessage`";

		// Token: 0x04001DCB RID: 7627
		private const string KEY_PREFIX = "InfrPhoneMessageAll";

		// Token: 0x04001DCC RID: 7628
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DCD RID: 7629
		private static int HandleId;
	}
}
