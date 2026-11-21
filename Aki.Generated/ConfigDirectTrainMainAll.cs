using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000220 RID: 544
	public class ConfigDirectTrainMainAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CC3 RID: 3267 RVA: 0x000A556C File Offset: 0x000A376C
		static ConfigDirectTrainMainAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainMainAll.CreateStaticDefaultValue), new Action(ConfigDirectTrainMainAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x000A558C File Offset: 0x000A378C
		public static void CreateStaticDefaultValue()
		{
			ConfigDirectTrainMainAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDirectTrainMainAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_directtrain.db"),
				new ValueTuple<string, object>("文件", "j.剧情直通车活动.xlsx"),
				new ValueTuple<string, object>("表名", "DirectTrainMain"),
				new ValueTuple<string, object>("语句", "select BinData from `DirectTrainMain`")
			});
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000A560B File Offset: 0x000A380B
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainMainAll.LogPair = null;
			ConfigDirectTrainMainAll.HandleId = 0;
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000A5619 File Offset: 0x000A3819
		public static void Init()
		{
			ConfigDirectTrainMainAll.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainMainAll.HandleId, "db_directtrain.db", "select BinData from `DirectTrainMain`");
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x000A5634 File Offset: 0x000A3834
		[NullableContext(2)]
		public static IReadOnlyList<DirectTrainMain> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDirectTrainMainAll.HandleId, ConfigDirectTrainMainAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DirectTrainMain> readOnlyList = (IReadOnlyList<DirectTrainMain>)ConfigCommon.GetConfig("DirectTrainMainAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DirectTrainMain> list = new List<DirectTrainMain>();
			while (ConfigCommon.Step(ConfigDirectTrainMainAll.HandleId, false, ConfigDirectTrainMainAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDirectTrainMainAll.HandleId, 0, ConfigDirectTrainMainAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDirectTrainMainAll.HandleId, ConfigDirectTrainMainAll.LogPair);
					return null;
				}
				DirectTrainMain rootAsDirectTrainMain = DirectTrainMain.GetRootAsDirectTrainMain(new ByteBuffer(item2));
				list.Add(rootAsDirectTrainMain);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DirectTrainMainAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDirectTrainMainAll.HandleId, ConfigDirectTrainMainAll.LogPair);
			return list;
		}

		// Token: 0x04000EC4 RID: 3780
		private const string DB = "db_directtrain.db";

		// Token: 0x04000EC5 RID: 3781
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000EC6 RID: 3782
		private const string TABLE = "DirectTrainMain";

		// Token: 0x04000EC7 RID: 3783
		private const string COMMAND = "select BinData from `DirectTrainMain`";

		// Token: 0x04000EC8 RID: 3784
		private const string KEY_PREFIX = "DirectTrainMainAll";

		// Token: 0x04000EC9 RID: 3785
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ECA RID: 3786
		private static int HandleId;
	}
}
