using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000605 RID: 1541
	public class ConfigNewTowerScoreLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600242E RID: 9262 RVA: 0x00126204 File Offset: 0x00124404
		static ConfigNewTowerScoreLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerScoreLevelById.CreateStaticDefaultValue), new Action(ConfigNewTowerScoreLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00126224 File Offset: 0x00124424
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerScoreLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerScoreLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerScoreLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerScoreLevel` where Id=?")
			});
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x001262A3 File Offset: 0x001244A3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerScoreLevelById.LogPair = null;
			ConfigNewTowerScoreLevelById.HandleId = 0;
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x001262B1 File Offset: 0x001244B1
		public static void Init()
		{
			ConfigNewTowerScoreLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerScoreLevelById.HandleId, "db_newtower.db", "select BinData from `NewTowerScoreLevel` where Id=?");
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x001262CC File Offset: 0x001244CC
		public static NewTowerScoreLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerScoreLevelById.HandleId, ConfigNewTowerScoreLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerScoreLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerScoreLevel?(NewTowerScoreLevel.GetRootAsNewTowerScoreLevel(configBuffer));
				}
			}
			ConfigNewTowerScoreLevelById.LogPair.Clear();
			ConfigNewTowerScoreLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerScoreLevelById.HandleId, 1, p0Id, ConfigNewTowerScoreLevelById.LogPair) || ConfigCommon.Step(ConfigNewTowerScoreLevelById.HandleId, true, ConfigNewTowerScoreLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerScoreLevelById.HandleId, ConfigNewTowerScoreLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerScoreLevelById.HandleId, 0, ConfigNewTowerScoreLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerScoreLevelById.HandleId, ConfigNewTowerScoreLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerScoreLevel rootAsNewTowerScoreLevel = NewTowerScoreLevel.GetRootAsNewTowerScoreLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerScoreLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerScoreLevelById.HandleId, ConfigNewTowerScoreLevelById.LogPair);
			return new NewTowerScoreLevel?(rootAsNewTowerScoreLevel);
		}

		// Token: 0x04002A09 RID: 10761
		private const string DB = "db_newtower.db";

		// Token: 0x04002A0A RID: 10762
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A0B RID: 10763
		private const string TABLE = "NewTowerScoreLevel";

		// Token: 0x04002A0C RID: 10764
		private const string COMMAND = "select BinData from `NewTowerScoreLevel` where Id=?";

		// Token: 0x04002A0D RID: 10765
		private const string KEY_PREFIX = "NewTowerScoreLevelById";

		// Token: 0x04002A0E RID: 10766
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A0F RID: 10767
		private static int HandleId;
	}
}
