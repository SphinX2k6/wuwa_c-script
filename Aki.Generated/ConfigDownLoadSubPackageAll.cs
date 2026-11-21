using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000227 RID: 551
	public class ConfigDownLoadSubPackageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CED RID: 3309 RVA: 0x000A6348 File Offset: 0x000A4548
		static ConfigDownLoadSubPackageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDownLoadSubPackageAll.CreateStaticDefaultValue), new Action(ConfigDownLoadSubPackageAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x000A6368 File Offset: 0x000A4568
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

		// Token: 0x06000CEF RID: 3311 RVA: 0x000A63E7 File Offset: 0x000A45E7
		public static void ResetStaticDefaultValue()
		{
			ConfigDownLoadSubPackageAll.LogPair = null;
			ConfigDownLoadSubPackageAll.HandleId = 0;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000A63F5 File Offset: 0x000A45F5
		public static void Init()
		{
			ConfigDownLoadSubPackageAll.HandleId = ConfigCommon.InitDataStatement(ConfigDownLoadSubPackageAll.HandleId, "db_download.db", "select BinData from `DownLoadSubPackage`");
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000A6410 File Offset: 0x000A4610
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

		// Token: 0x04000EF5 RID: 3829
		private const string DB = "db_download.db";

		// Token: 0x04000EF6 RID: 3830
		private const string FILE = "b.包体管理.xlsx";

		// Token: 0x04000EF7 RID: 3831
		private const string TABLE = "DownLoadSubPackage";

		// Token: 0x04000EF8 RID: 3832
		private const string COMMAND = "select BinData from `DownLoadSubPackage`";

		// Token: 0x04000EF9 RID: 3833
		private const string KEY_PREFIX = "DownLoadSubPackageAll";

		// Token: 0x04000EFA RID: 3834
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EFB RID: 3835
		private static int HandleId;
	}
}
