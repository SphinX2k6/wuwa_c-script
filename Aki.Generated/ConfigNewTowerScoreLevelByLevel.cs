using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000606 RID: 1542
	public class ConfigNewTowerScoreLevelByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002434 RID: 9268 RVA: 0x0012644C File Offset: 0x0012464C
		static ConfigNewTowerScoreLevelByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerScoreLevelByLevel.CreateStaticDefaultValue), new Action(ConfigNewTowerScoreLevelByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0012646C File Offset: 0x0012466C
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

		// Token: 0x06002436 RID: 9270 RVA: 0x001264EB File Offset: 0x001246EB
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerScoreLevelByLevel.LogPair = null;
			ConfigNewTowerScoreLevelByLevel.HandleId = 0;
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x001264F9 File Offset: 0x001246F9
		public static void Init()
		{
			ConfigNewTowerScoreLevelByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerScoreLevelByLevel.HandleId, "db_newtower.db", "select BinData from `NewTowerScoreLevel` where Level=?");
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00126514 File Offset: 0x00124714
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

		// Token: 0x04002A10 RID: 10768
		private const string DB = "db_newtower.db";

		// Token: 0x04002A11 RID: 10769
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A12 RID: 10770
		private const string TABLE = "NewTowerScoreLevel";

		// Token: 0x04002A13 RID: 10771
		private const string COMMAND = "select BinData from `NewTowerScoreLevel` where Level=?";

		// Token: 0x04002A14 RID: 10772
		private const string KEY_PREFIX = "NewTowerScoreLevelByLevel";

		// Token: 0x04002A15 RID: 10773
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A16 RID: 10774
		private static int HandleId;
	}
}
