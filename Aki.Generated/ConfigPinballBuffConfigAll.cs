using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000725 RID: 1829
	public class ConfigPinballBuffConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AEE RID: 10990 RVA: 0x0014F880 File Offset: 0x0014DA80
		static ConfigPinballBuffConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballBuffConfigAll.CreateStaticDefaultValue), new Action(ConfigPinballBuffConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x0014F8A0 File Offset: 0x0014DAA0
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballBuffConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballBuffConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_通用.xlsx"),
				new ValueTuple<string, object>("表名", "PinballBuffConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballBuffConfig`")
			});
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x0014F91F File Offset: 0x0014DB1F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballBuffConfigAll.LogPair = null;
			ConfigPinballBuffConfigAll.HandleId = 0;
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x0014F92D File Offset: 0x0014DB2D
		public static void Init()
		{
			ConfigPinballBuffConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballBuffConfigAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballBuffConfig`");
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0014F948 File Offset: 0x0014DB48
		[NullableContext(2)]
		public static IReadOnlyList<PinballBuffConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballBuffConfigAll.HandleId, ConfigPinballBuffConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballBuffConfig> readOnlyList = (IReadOnlyList<PinballBuffConfig>)ConfigCommon.GetConfig("PinballBuffConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballBuffConfig> list = new List<PinballBuffConfig>();
			while (ConfigCommon.Step(ConfigPinballBuffConfigAll.HandleId, false, ConfigPinballBuffConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballBuffConfigAll.HandleId, 0, ConfigPinballBuffConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballBuffConfigAll.HandleId, ConfigPinballBuffConfigAll.LogPair);
					return null;
				}
				PinballBuffConfig rootAsPinballBuffConfig = PinballBuffConfig.GetRootAsPinballBuffConfig(new ByteBuffer(item2));
				list.Add(rootAsPinballBuffConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballBuffConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballBuffConfigAll.HandleId, ConfigPinballBuffConfigAll.LogPair);
			return list;
		}

		// Token: 0x040031E9 RID: 12777
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031EA RID: 12778
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x040031EB RID: 12779
		private const string TABLE = "PinballBuffConfig";

		// Token: 0x040031EC RID: 12780
		private const string COMMAND = "select BinData from `PinballBuffConfig`";

		// Token: 0x040031ED RID: 12781
		private const string KEY_PREFIX = "PinballBuffConfigAll";

		// Token: 0x040031EE RID: 12782
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031EF RID: 12783
		private static int HandleId;
	}
}
