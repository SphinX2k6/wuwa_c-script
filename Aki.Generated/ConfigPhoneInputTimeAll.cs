using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D5 RID: 1749
	public class ConfigPhoneInputTimeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600290E RID: 10510 RVA: 0x001452D4 File Offset: 0x001434D4
		static ConfigPhoneInputTimeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneInputTimeAll.CreateStaticDefaultValue), new Action(ConfigPhoneInputTimeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x001452F4 File Offset: 0x001434F4
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

		// Token: 0x06002910 RID: 10512 RVA: 0x00145373 File Offset: 0x00143573
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneInputTimeAll.LogPair = null;
			ConfigPhoneInputTimeAll.HandleId = 0;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00145381 File Offset: 0x00143581
		public static void Init()
		{
			ConfigPhoneInputTimeAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneInputTimeAll.HandleId, "db_phonemsg.db", "select BinData from `PhoneInputTime`");
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x0014539C File Offset: 0x0014359C
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

		// Token: 0x04002FB9 RID: 12217
		private const string DB = "db_phonemsg.db";

		// Token: 0x04002FBA RID: 12218
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04002FBB RID: 12219
		private const string TABLE = "PhoneInputTime";

		// Token: 0x04002FBC RID: 12220
		private const string COMMAND = "select BinData from `PhoneInputTime`";

		// Token: 0x04002FBD RID: 12221
		private const string KEY_PREFIX = "PhoneInputTimeAll";

		// Token: 0x04002FBE RID: 12222
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FBF RID: 12223
		private static int HandleId;
	}
}
