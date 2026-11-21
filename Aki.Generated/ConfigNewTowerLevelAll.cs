using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000614 RID: 1556
	public class ConfigNewTowerLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002488 RID: 9352 RVA: 0x0012B990 File Offset: 0x00129B90
		static ConfigNewTowerLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerLevelAll.CreateStaticDefaultValue), new Action(ConfigNewTowerLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0012B9B0 File Offset: 0x00129BB0
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerLevel`")
			});
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0012BA2F File Offset: 0x00129C2F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerLevelAll.LogPair = null;
			ConfigNewTowerLevelAll.HandleId = 0;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0012BA3D File Offset: 0x00129C3D
		public static void Init()
		{
			ConfigNewTowerLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerLevelAll.HandleId, "db_newtower.db", "select BinData from `NewTowerLevel`");
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0012BA58 File Offset: 0x00129C58
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerLevelAll.HandleId, ConfigNewTowerLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewTowerLevel> readOnlyList = (IReadOnlyList<NewTowerLevel>)ConfigCommon.GetConfig("NewTowerLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewTowerLevel> list = new List<NewTowerLevel>();
			while (ConfigCommon.Step(ConfigNewTowerLevelAll.HandleId, false, ConfigNewTowerLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerLevelAll.HandleId, 0, ConfigNewTowerLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerLevelAll.HandleId, ConfigNewTowerLevelAll.LogPair);
					return null;
				}
				NewTowerLevel rootAsNewTowerLevel = NewTowerLevel.GetRootAsNewTowerLevel(new ByteBuffer(item2));
				list.Add(rootAsNewTowerLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewTowerLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerLevelAll.HandleId, ConfigNewTowerLevelAll.LogPair);
			return list;
		}

		// Token: 0x04002A72 RID: 10866
		private const string DB = "db_newtower.db";

		// Token: 0x04002A73 RID: 10867
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A74 RID: 10868
		private const string TABLE = "NewTowerLevel";

		// Token: 0x04002A75 RID: 10869
		private const string COMMAND = "select BinData from `NewTowerLevel`";

		// Token: 0x04002A76 RID: 10870
		private const string KEY_PREFIX = "NewTowerLevelAll";

		// Token: 0x04002A77 RID: 10871
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A78 RID: 10872
		private static int HandleId;
	}
}
