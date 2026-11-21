using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074A RID: 1866
	public class ConfigPinballTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BCC RID: 11212 RVA: 0x00154820 File Offset: 0x00152A20
		static ConfigPinballTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballTaskAll.CreateStaticDefaultValue), new Action(ConfigPinballTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x00154840 File Offset: 0x00152A40
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_活动.xlsx"),
				new ValueTuple<string, object>("表名", "PinballTask"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballTask`")
			});
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x001548BF File Offset: 0x00152ABF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballTaskAll.LogPair = null;
			ConfigPinballTaskAll.HandleId = 0;
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x001548CD File Offset: 0x00152ACD
		public static void Init()
		{
			ConfigPinballTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballTaskAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballTask`");
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x001548E8 File Offset: 0x00152AE8
		[NullableContext(2)]
		public static IReadOnlyList<PinballTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballTaskAll.HandleId, ConfigPinballTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PinballTask> readOnlyList = (IReadOnlyList<PinballTask>)ConfigCommon.GetConfig("PinballTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PinballTask> list = new List<PinballTask>();
			while (ConfigCommon.Step(ConfigPinballTaskAll.HandleId, false, ConfigPinballTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballTaskAll.HandleId, 0, ConfigPinballTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballTaskAll.HandleId, ConfigPinballTaskAll.LogPair);
					return null;
				}
				PinballTask rootAsPinballTask = PinballTask.GetRootAsPinballTask(new ByteBuffer(item2));
				list.Add(rootAsPinballTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PinballTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballTaskAll.HandleId, ConfigPinballTaskAll.LogPair);
			return list;
		}

		// Token: 0x040032EC RID: 13036
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032ED RID: 13037
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x040032EE RID: 13038
		private const string TABLE = "PinballTask";

		// Token: 0x040032EF RID: 13039
		private const string COMMAND = "select BinData from `PinballTask`";

		// Token: 0x040032F0 RID: 13040
		private const string KEY_PREFIX = "PinballTaskAll";

		// Token: 0x040032F1 RID: 13041
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032F2 RID: 13042
		private static int HandleId;
	}
}
