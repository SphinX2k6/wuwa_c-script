using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000680 RID: 1664
	public class ConfigPhantomBattleMasterTitleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002710 RID: 10000 RVA: 0x0013692C File Offset: 0x00134B2C
		static ConfigPhantomBattleMasterTitleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMasterTitleAll.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMasterTitleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x0013694C File Offset: 0x00134B4C
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

		// Token: 0x06002712 RID: 10002 RVA: 0x001369CB File Offset: 0x00134BCB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMasterTitleAll.LogPair = null;
			ConfigPhantomBattleMasterTitleAll.HandleId = 0;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x001369D9 File Offset: 0x00134BD9
		public static void Init()
		{
			ConfigPhantomBattleMasterTitleAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMasterTitleAll.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMasterTitle`");
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x001369F4 File Offset: 0x00134BF4
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

		// Token: 0x04002D66 RID: 11622
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D67 RID: 11623
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D68 RID: 11624
		private const string TABLE = "PhantomBattleMasterTitle";

		// Token: 0x04002D69 RID: 11625
		private const string COMMAND = "select BinData from `PhantomBattleMasterTitle`";

		// Token: 0x04002D6A RID: 11626
		private const string KEY_PREFIX = "PhantomBattleMasterTitleAll";

		// Token: 0x04002D6B RID: 11627
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D6C RID: 11628
		private static int HandleId;
	}
}
