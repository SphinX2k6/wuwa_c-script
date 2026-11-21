using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000698 RID: 1688
	public class ConfigPhantomBattleMasterTitleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027A0 RID: 10144 RVA: 0x0013D3A8 File Offset: 0x0013B5A8
		static ConfigPhantomBattleMasterTitleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMasterTitleAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMasterTitleAll.ResetStaticDefaultValue));
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x0013D3C8 File Offset: 0x0013B5C8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMasterTitleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMasterTitleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMasterTitle"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMasterTitle`")
			});
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0013D447 File Offset: 0x0013B647
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMasterTitleAll.LogPair = null;
			ConfigPhantomBattleMasterTitleAll.HandleId = 0;
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x0013D455 File Offset: 0x0013B655
		public static void Init()
		{
			ConfigPhantomBattleMasterTitleAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMasterTitleAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMasterTitle`");
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x0013D470 File Offset: 0x0013B670
		[NullableContext(2)]
		public static IReadOnlyList<PhantomBattleMasterTitle> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMasterTitleAll.HandleId, ConfigPhantomBattleMasterTitleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhantomBattleMasterTitle> readOnlyList = (IReadOnlyList<PhantomBattleMasterTitle>)ConfigCommon.GetConfig("PhantomBattleMasterTitleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhantomBattleMasterTitle> list = new List<PhantomBattleMasterTitle>();
			while (ConfigCommon.Step(ConfigPhantomBattleMasterTitleAll.HandleId, false, ConfigPhantomBattleMasterTitleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMasterTitleAll.HandleId, 0, ConfigPhantomBattleMasterTitleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomBattleMasterTitleAll.HandleId, ConfigPhantomBattleMasterTitleAll.LogPair);
					return null;
				}
				PhantomBattleMasterTitle rootAsPhantomBattleMasterTitle = PhantomBattleMasterTitle.GetRootAsPhantomBattleMasterTitle(new ByteBuffer(item2));
				list.Add(rootAsPhantomBattleMasterTitle);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhantomBattleMasterTitleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMasterTitleAll.HandleId, ConfigPhantomBattleMasterTitleAll.LogPair);
			return list;
		}

		// Token: 0x04002E0E RID: 11790
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002E0F RID: 11791
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002E10 RID: 11792
		private const string TABLE = "PhantomBattleMasterTitle";

		// Token: 0x04002E11 RID: 11793
		private const string COMMAND = "select BinData from `PhantomBattleMasterTitle`";

		// Token: 0x04002E12 RID: 11794
		private const string KEY_PREFIX = "PhantomBattleMasterTitleAll";

		// Token: 0x04002E13 RID: 11795
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E14 RID: 11796
		private static int HandleId;
	}
}
