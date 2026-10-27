using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000732 RID: 1842
	public class ConfigPinballTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B3C RID: 11068 RVA: 0x0014DDA4 File Offset: 0x0014BFA4
		static ConfigPinballTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballTaskAll.CreateStaticDefaultValue), new Action(ConfigPinballTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x0014DDC4 File Offset: 0x0014BFC4
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

		// Token: 0x06002B3E RID: 11070 RVA: 0x0014DE43 File Offset: 0x0014C043
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballTaskAll.LogPair = null;
			ConfigPinballTaskAll.HandleId = 0;
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x0014DE51 File Offset: 0x0014C051
		public static void Init()
		{
			ConfigPinballTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigPinballTaskAll.HandleId, "db_pinballbattle.db", "select BinData from `PinballTask`");
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0014DE6C File Offset: 0x0014C06C
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

		// Token: 0x04003244 RID: 12868
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003245 RID: 12869
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x04003246 RID: 12870
		private const string TABLE = "PinballTask";

		// Token: 0x04003247 RID: 12871
		private const string COMMAND = "select BinData from `PinballTask`";

		// Token: 0x04003248 RID: 12872
		private const string KEY_PREFIX = "PinballTaskAll";

		// Token: 0x04003249 RID: 12873
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400324A RID: 12874
		private static int HandleId;
	}
}
