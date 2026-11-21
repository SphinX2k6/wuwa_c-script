using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061E RID: 1566
	public class ConfigNewTowerScoreLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024C4 RID: 9412 RVA: 0x0012CEC8 File Offset: 0x0012B0C8
		static ConfigNewTowerScoreLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerScoreLevelByLevel.CreateStaticDefaultValue), new Action(ConfigNewTowerScoreLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0012CEE8 File Offset: 0x0012B0E8
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerScoreLevelByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerScoreLevelByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerScoreLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerScoreLevel` where Level=?")
			});
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x0012CF67 File Offset: 0x0012B167
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerScoreLevelByLevel.LogPair = null;
			ConfigNewTowerScoreLevelByLevel.HandleId = 0;
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0012CF75 File Offset: 0x0012B175
		public static void Init()
		{
			ConfigNewTowerScoreLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerScoreLevelByLevel.HandleId, "db_newtower.db", "select BinData from `NewTowerScoreLevel` where Level=?");
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x0012CF90 File Offset: 0x0012B190
		public static NewTowerScoreLevel? GetConfig(string p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerScoreLevelByLevel.HandleId, ConfigNewTowerScoreLevelByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("NewTowerScoreLevelByLevel#" + p0Level);
				if (configBuffer != null)
				{
					return new NewTowerScoreLevel?(NewTowerScoreLevel.GetRootAsNewTowerScoreLevel(configBuffer));
				}
			}
			ConfigNewTowerScoreLevelByLevel.LogPair.Clear();
			ConfigNewTowerScoreLevelByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindString(ConfigNewTowerScoreLevelByLevel.HandleId, 1, p0Level, ConfigNewTowerScoreLevelByLevel.LogPair) || ConfigCommon.Step(ConfigNewTowerScoreLevelByLevel.HandleId, true, ConfigNewTowerScoreLevelByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerScoreLevelByLevel.HandleId, ConfigNewTowerScoreLevelByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerScoreLevelByLevel.HandleId, 0, ConfigNewTowerScoreLevelByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerScoreLevelByLevel.HandleId, ConfigNewTowerScoreLevelByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerScoreLevel rootAsNewTowerScoreLevel = NewTowerScoreLevel.GetRootAsNewTowerScoreLevel(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("NewTowerScoreLevelByLevel#" + p0Level, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerScoreLevelByLevel.HandleId, ConfigNewTowerScoreLevelByLevel.LogPair);
			return new NewTowerScoreLevel?(rootAsNewTowerScoreLevel);
		}

		// Token: 0x04002AB8 RID: 10936
		private const string DB = "db_newtower.db";

		// Token: 0x04002AB9 RID: 10937
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002ABA RID: 10938
		private const string TABLE = "NewTowerScoreLevel";

		// Token: 0x04002ABB RID: 10939
		private const string COMMAND = "select BinData from `NewTowerScoreLevel` where Level=?";

		// Token: 0x04002ABC RID: 10940
		private const string KEY_PREFIX = "NewTowerScoreLevelByLevel";

		// Token: 0x04002ABD RID: 10941
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ABE RID: 10942
		private static int HandleId;
	}
}
