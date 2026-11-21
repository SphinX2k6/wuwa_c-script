using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072C RID: 1836
	public class ConfigPinballDailyConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B18 RID: 11032 RVA: 0x00150710 File Offset: 0x0014E910
		static ConfigPinballDailyConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDailyConfigAll.CreateStaticDefaultValue), new Action(ConfigPinballDailyConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00150730 File Offset: 0x0014E930
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

		// Token: 0x06002B1A RID: 11034 RVA: 0x001507AF File Offset: 0x0014E9AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDailyConfigAll.LogPair = null;
			ConfigPinballDailyConfigAll.HandleId = 0;
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x001507BD File Offset: 0x0014E9BD
		public static void Init()
		{
			ConfigPinballDailyConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDailyConfigAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballDailyConfig`");
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x001507D8 File Offset: 0x0014E9D8
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

		// Token: 0x0400321A RID: 12826
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400321B RID: 12827
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x0400321C RID: 12828
		private const string TABLE = "PinballDailyConfig";

		// Token: 0x0400321D RID: 12829
		private const string COMMAND = "select BinData from `PinballDailyConfig`";

		// Token: 0x0400321E RID: 12830
		private const string KEY_PREFIX = "PinballDailyConfigAll";

		// Token: 0x0400321F RID: 12831
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003220 RID: 12832
		private static int HandleId;
	}
}
