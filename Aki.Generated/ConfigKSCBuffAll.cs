using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000477 RID: 1143
	public class ConfigKSCBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AD4 RID: 6868 RVA: 0x000F112F File Offset: 0x000EF32F
		static ConfigKSCBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKSCBuffAll.CreateStaticDefaultValue), new Action(ConfigKSCBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000F1150 File Offset: 0x000EF350
		public static void CreateStaticDefaultValue()
		{
			ConfigKSCBuffAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKSCBuffAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tdbuff.db"),
				new ValueTuple<string, object>("文件", "s.SimpleCombatBuff.xlsx"),
				new ValueTuple<string, object>("表名", "KSCBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `KSCBuff`")
			});
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000F11CF File Offset: 0x000EF3CF
		public static void ResetStaticDefaultValue()
		{
			ConfigKSCBuffAll.LogPair = null;
			ConfigKSCBuffAll.HandleId = 0;
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000F11DD File Offset: 0x000EF3DD
		public static void Init()
		{
			ConfigKSCBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigKSCBuffAll.HandleId, "db_tdbuff.db", "select BinData from `KSCBuff`");
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000F11F8 File Offset: 0x000EF3F8
		[NullableContext(2)]
		public static IReadOnlyList<KSCBuff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKSCBuffAll.HandleId, ConfigKSCBuffAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KSCBuff> readOnlyList = (IReadOnlyList<KSCBuff>)ConfigCommon.GetConfig("KSCBuffAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KSCBuff> list = new List<KSCBuff>();
			while (ConfigCommon.Step(ConfigKSCBuffAll.HandleId, false, ConfigKSCBuffAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKSCBuffAll.HandleId, 0, ConfigKSCBuffAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKSCBuffAll.HandleId, ConfigKSCBuffAll.LogPair);
					return null;
				}
				KSCBuff rootAsKSCBuff = KSCBuff.GetRootAsKSCBuff(new ByteBuffer(item2));
				list.Add(rootAsKSCBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KSCBuffAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKSCBuffAll.HandleId, ConfigKSCBuffAll.LogPair);
			return list;
		}

		// Token: 0x04001F25 RID: 7973
		private const string DB = "db_tdbuff.db";

		// Token: 0x04001F26 RID: 7974
		private const string FILE = "s.SimpleCombatBuff.xlsx";

		// Token: 0x04001F27 RID: 7975
		private const string TABLE = "KSCBuff";

		// Token: 0x04001F28 RID: 7976
		private const string COMMAND = "select BinData from `KSCBuff`";

		// Token: 0x04001F29 RID: 7977
		private const string KEY_PREFIX = "KSCBuffAll";

		// Token: 0x04001F2A RID: 7978
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F2B RID: 7979
		private static int HandleId;
	}
}
