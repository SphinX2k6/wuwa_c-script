using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000218 RID: 536
	public class ConfigDownLoadTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C93 RID: 3219 RVA: 0x000A0A23 File Offset: 0x0009EC23
		static ConfigDownLoadTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadTabAll.CreateStaticDefaultValue), new Action(ConfigDownLoadTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000A0A44 File Offset: 0x0009EC44
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

		// Token: 0x06000C95 RID: 3221 RVA: 0x000A0AC3 File Offset: 0x0009ECC3
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadTabAll.LogPair = null;
			ConfigDownLoadTabAll.HandleId = 0;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000A0AD1 File Offset: 0x0009ECD1
		public static void Init()
		{
			ConfigDownLoadTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadTabAll.HandleId, "db_download.db", "select BinData from `DownLoadTab`");
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000A0AEC File Offset: 0x0009ECEC
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

		// Token: 0x04000E8C RID: 3724
		private const string DB = "db_download.db";

		// Token: 0x04000E8D RID: 3725
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000E8E RID: 3726
		private const string TABLE = "DownLoadTab";

		// Token: 0x04000E8F RID: 3727
		private const string COMMAND = "select BinData from `DownLoadTab`";

		// Token: 0x04000E90 RID: 3728
		private const string KEY_PREFIX = "DownLoadTabAll";

		// Token: 0x04000E91 RID: 3729
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E92 RID: 3730
		private static int HandleId;
	}
}
