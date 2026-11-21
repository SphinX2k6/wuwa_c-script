using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022A RID: 554
	public class ConfigDownLoadTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CFF RID: 3327 RVA: 0x000A695B File Offset: 0x000A4B5B
		static ConfigDownLoadTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadTabAll.CreateStaticDefaultValue), new Action(ConfigDownLoadTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000A697C File Offset: 0x000A4B7C
		public static void CreateStaticDefaultValue()
		{
			ConfigDownLoadTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDownLoadTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "DownLoadTab"),
				new ValueTuple<string, object>("语句", "select BinData from `DownLoadTab`")
			});
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000A69FB File Offset: 0x000A4BFB
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadTabAll.LogPair = null;
			ConfigDownLoadTabAll.HandleId = 0;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000A6A09 File Offset: 0x000A4C09
		public static void Init()
		{
			ConfigDownLoadTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadTabAll.HandleId, "db_download.db", "select BinData from `DownLoadTab`");
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000A6A24 File Offset: 0x000A4C24
		[NullableContext(2)]
		public static IReadOnlyList<DownLoadTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDownLoadTabAll.HandleId, ConfigDownLoadTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DownLoadTab> readOnlyList = (IReadOnlyList<DownLoadTab>)ConfigCommon.GetConfig("DownLoadTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DownLoadTab> list = new List<DownLoadTab>();
			while (ConfigCommon.Step(ConfigDownLoadTabAll.HandleId, false, ConfigDownLoadTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDownLoadTabAll.HandleId, 0, ConfigDownLoadTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDownLoadTabAll.HandleId, ConfigDownLoadTabAll.LogPair);
					return null;
				}
				DownLoadTab rootAsDownLoadTab = DownLoadTab.GetRootAsDownLoadTab(new ByteBuffer(item2));
				list.Add(rootAsDownLoadTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DownLoadTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDownLoadTabAll.HandleId, ConfigDownLoadTabAll.LogPair);
			return list;
		}

		// Token: 0x04000F0A RID: 3850
		private const string DB = "db_download.db";

		// Token: 0x04000F0B RID: 3851
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000F0C RID: 3852
		private const string TABLE = "DownLoadTab";

		// Token: 0x04000F0D RID: 3853
		private const string COMMAND = "select BinData from `DownLoadTab`";

		// Token: 0x04000F0E RID: 3854
		private const string KEY_PREFIX = "DownLoadTabAll";

		// Token: 0x04000F0F RID: 3855
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F10 RID: 3856
		private static int HandleId;
	}
}
