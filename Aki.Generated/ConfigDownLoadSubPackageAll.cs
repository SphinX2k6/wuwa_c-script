using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000215 RID: 533
	public class ConfigDownLoadSubPackageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C81 RID: 3201 RVA: 0x000A0410 File Offset: 0x0009E610
		static ConfigDownLoadSubPackageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadSubPackageAll.CreateStaticDefaultValue), new Action(ConfigDownLoadSubPackageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000A0430 File Offset: 0x0009E630
		public static void CreateStaticDefaultValue()
		{
			ConfigDownLoadSubPackageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDownLoadSubPackageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_download.db"),
				new ValueTuple<string, object>("文件", "b.包体管理.xlsx"),
				new ValueTuple<string, object>("表名", "DownLoadSubPackage"),
				new ValueTuple<string, object>("语句", "select BinData from `DownLoadSubPackage`")
			});
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000A04AF File Offset: 0x0009E6AF
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadSubPackageAll.LogPair = null;
			ConfigDownLoadSubPackageAll.HandleId = 0;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000A04BD File Offset: 0x0009E6BD
		public static void Init()
		{
			ConfigDownLoadSubPackageAll.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadSubPackageAll.HandleId, "db_download.db", "select BinData from `DownLoadSubPackage`");
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000A04D8 File Offset: 0x0009E6D8
		[NullableContext(2)]
		public static IReadOnlyList<DownLoadSubPackage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDownLoadSubPackageAll.HandleId, ConfigDownLoadSubPackageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DownLoadSubPackage> readOnlyList = (IReadOnlyList<DownLoadSubPackage>)ConfigCommon.GetConfig("DownLoadSubPackageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DownLoadSubPackage> list = new List<DownLoadSubPackage>();
			while (ConfigCommon.Step(ConfigDownLoadSubPackageAll.HandleId, false, ConfigDownLoadSubPackageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDownLoadSubPackageAll.HandleId, 0, ConfigDownLoadSubPackageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDownLoadSubPackageAll.HandleId, ConfigDownLoadSubPackageAll.LogPair);
					return null;
				}
				DownLoadSubPackage rootAsDownLoadSubPackage = DownLoadSubPackage.GetRootAsDownLoadSubPackage(new ByteBuffer(item2));
				list.Add(rootAsDownLoadSubPackage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DownLoadSubPackageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDownLoadSubPackageAll.HandleId, ConfigDownLoadSubPackageAll.LogPair);
			return list;
		}

		// Token: 0x04000E77 RID: 3703
		private const string DB = "db_download.db";

		// Token: 0x04000E78 RID: 3704
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000E79 RID: 3705
		private const string TABLE = "DownLoadSubPackage";

		// Token: 0x04000E7A RID: 3706
		private const string COMMAND = "select BinData from `DownLoadSubPackage`";

		// Token: 0x04000E7B RID: 3707
		private const string KEY_PREFIX = "DownLoadSubPackageAll";

		// Token: 0x04000E7C RID: 3708
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E7D RID: 3709
		private static int HandleId;
	}
}
