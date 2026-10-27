using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000714 RID: 1812
	public class ConfigPinballDailyConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A88 RID: 10888 RVA: 0x00149C94 File Offset: 0x00147E94
		static ConfigPinballDailyConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDailyConfigAll.CreateStaticDefaultValue), new Action(ConfigPinballDailyConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00149CB4 File Offset: 0x00147EB4
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballDailyConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballDailyConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballDailyConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballDailyConfig`")
			});
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00149D33 File Offset: 0x00147F33
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDailyConfigAll.LogPair = null;
			ConfigPinballDailyConfigAll.HandleId = 0;
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x00149D41 File Offset: 0x00147F41
		public static void Init()
		{
			ConfigPinballDailyConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDailyConfigAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballDailyConfig`");
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00149D5C File Offset: 0x00147F5C
		[NullableContext(2)]
		public static IReadOnlyList<PinballDailyConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballDailyConfigAll.HandleId, ConfigPinballDailyConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballDailyConfig> readOnlyList = (IReadOnlyList<PinballDailyConfig>)ConfigCommon.GetConfig("PinballDailyConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballDailyConfig> list = new List<PinballDailyConfig>();
			while (ConfigCommon.Step(ConfigPinballDailyConfigAll.HandleId, false, ConfigPinballDailyConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballDailyConfigAll.HandleId, 0, ConfigPinballDailyConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballDailyConfigAll.HandleId, ConfigPinballDailyConfigAll.LogPair);
					return null;
				}
				PinballDailyConfig rootAsPinballDailyConfig = PinballDailyConfig.GetRootAsPinballDailyConfig(new ByteBuffer(item2));
				list.Add(rootAsPinballDailyConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballDailyConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballDailyConfigAll.HandleId, ConfigPinballDailyConfigAll.LogPair);
			return list;
		}

		// Token: 0x04003172 RID: 12658
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003173 RID: 12659
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x04003174 RID: 12660
		private const string TABLE = "PinballDailyConfig";

		// Token: 0x04003175 RID: 12661
		private const string COMMAND = "select BinData from `PinballDailyConfig`";

		// Token: 0x04003176 RID: 12662
		private const string KEY_PREFIX = "PinballDailyConfigAll";

		// Token: 0x04003177 RID: 12663
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003178 RID: 12664
		private static int HandleId;
	}
}
