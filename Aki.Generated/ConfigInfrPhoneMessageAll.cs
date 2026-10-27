using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042F RID: 1071
	public class ConfigInfrPhoneMessageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001923 RID: 6435 RVA: 0x000E7B98 File Offset: 0x000E5D98
		static ConfigInfrPhoneMessageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPhoneMessageAll.CreateStaticDefaultValue), new Action(ConfigInfrPhoneMessageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000E7BB8 File Offset: 0x000E5DB8
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

		// Token: 0x06001925 RID: 6437 RVA: 0x000E7C37 File Offset: 0x000E5E37
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPhoneMessageAll.LogPair = null;
			ConfigInfrPhoneMessageAll.HandleId = 0;
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x000E7C45 File Offset: 0x000E5E45
		public static void Init()
		{
			ConfigInfrPhoneMessageAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPhoneMessageAll.HandleId, "db_infrastructure.db", "select BinData from `InfrPhoneMessage`");
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x000E7C60 File Offset: 0x000E5E60
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

		// Token: 0x04001D2D RID: 7469
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D2E RID: 7470
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D2F RID: 7471
		private const string TABLE = "InfrPhoneMessage";

		// Token: 0x04001D30 RID: 7472
		private const string COMMAND = "select BinData from `InfrPhoneMessage`";

		// Token: 0x04001D31 RID: 7473
		private const string KEY_PREFIX = "InfrPhoneMessageAll";

		// Token: 0x04001D32 RID: 7474
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D33 RID: 7475
		private static int HandleId;
	}
}
