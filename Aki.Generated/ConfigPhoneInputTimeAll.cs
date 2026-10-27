using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BD RID: 1725
	public class ConfigPhoneInputTimeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600287E RID: 10366 RVA: 0x0013E858 File Offset: 0x0013CA58
		static ConfigPhoneInputTimeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneInputTimeAll.CreateStaticDefaultValue), new Action(ConfigPhoneInputTimeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0013E878 File Offset: 0x0013CA78
		public static void CreateStaticDefaultValue()
		{
			ConfigPhoneInputTimeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhoneInputTimeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhoneInputTime"),
				new ValueTuple<string, object>("语句", "select BinData from `PhoneInputTime`")
			});
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x0013E8F7 File Offset: 0x0013CAF7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneInputTimeAll.LogPair = null;
			ConfigPhoneInputTimeAll.HandleId = 0;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0013E905 File Offset: 0x0013CB05
		public static void Init()
		{
			ConfigPhoneInputTimeAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneInputTimeAll.HandleId, "db_phonemsg.db", "select BinData from `PhoneInputTime`");
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0013E920 File Offset: 0x0013CB20
		[NullableContext(2)]
		public static IReadOnlyList<PhoneInputTime> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhoneInputTimeAll.HandleId, ConfigPhoneInputTimeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhoneInputTime> readOnlyList = (IReadOnlyList<PhoneInputTime>)ConfigCommon.GetConfig("PhoneInputTimeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhoneInputTime> list = new List<PhoneInputTime>();
			while (ConfigCommon.Step(ConfigPhoneInputTimeAll.HandleId, false, ConfigPhoneInputTimeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhoneInputTimeAll.HandleId, 0, ConfigPhoneInputTimeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhoneInputTimeAll.HandleId, ConfigPhoneInputTimeAll.LogPair);
					return null;
				}
				PhoneInputTime rootAsPhoneInputTime = PhoneInputTime.GetRootAsPhoneInputTime(new ByteBuffer(item2));
				list.Add(rootAsPhoneInputTime);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhoneInputTimeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhoneInputTimeAll.HandleId, ConfigPhoneInputTimeAll.LogPair);
			return list;
		}

		// Token: 0x04002F11 RID: 12049
		private const string DB = "db_phonemsg.db";

		// Token: 0x04002F12 RID: 12050
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04002F13 RID: 12051
		private const string TABLE = "PhoneInputTime";

		// Token: 0x04002F14 RID: 12052
		private const string COMMAND = "select BinData from `PhoneInputTime`";

		// Token: 0x04002F15 RID: 12053
		private const string KEY_PREFIX = "PhoneInputTimeAll";

		// Token: 0x04002F16 RID: 12054
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F17 RID: 12055
		private static int HandleId;
	}
}
