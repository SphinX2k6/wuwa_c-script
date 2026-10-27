using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020E RID: 526
	public class ConfigDirectTrainMainAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C57 RID: 3159 RVA: 0x0009F634 File Offset: 0x0009D834
		static ConfigDirectTrainMainAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDirectTrainMainAll.CreateStaticDefaultValue), new Action(ConfigDirectTrainMainAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0009F654 File Offset: 0x0009D854
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

		// Token: 0x06000C59 RID: 3161 RVA: 0x0009F6D3 File Offset: 0x0009D8D3
		public static void ResetStaticDefaultValue()
		{
			ConfigDirectTrainMainAll.LogPair = null;
			ConfigDirectTrainMainAll.HandleId = 0;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0009F6E1 File Offset: 0x0009D8E1
		public static void Init()
		{
			ConfigDirectTrainMainAll.HandleId = ConfigCommon.InitDataStatement(ConfigDirectTrainMainAll.HandleId, "db_directtrain.db", "select BinData from `DirectTrainMain`");
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0009F6FC File Offset: 0x0009D8FC
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

		// Token: 0x04000E46 RID: 3654
		private const string DB = "db_directtrain.db";

		// Token: 0x04000E47 RID: 3655
		private const string FILE = "j.剧情直通车活动.xlsx";

		// Token: 0x04000E48 RID: 3656
		private const string TABLE = "DirectTrainMain";

		// Token: 0x04000E49 RID: 3657
		private const string COMMAND = "select BinData from `DirectTrainMain`";

		// Token: 0x04000E4A RID: 3658
		private const string KEY_PREFIX = "DirectTrainMainAll";

		// Token: 0x04000E4B RID: 3659
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E4C RID: 3660
		private static int HandleId;
	}
}
