using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061D RID: 1565
	public class ConfigNewTowerScoreLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024BE RID: 9406 RVA: 0x0012CC80 File Offset: 0x0012AE80
		static ConfigNewTowerScoreLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerScoreLevelById.CreateStaticDefaultValue), new Action(ConfigNewTowerScoreLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x0012CCA0 File Offset: 0x0012AEA0
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

		// Token: 0x060024C0 RID: 9408 RVA: 0x0012CD1F File Offset: 0x0012AF1F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerScoreLevelById.LogPair = null;
			ConfigNewTowerScoreLevelById.HandleId = 0;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0012CD2D File Offset: 0x0012AF2D
		public static void Init()
		{
			ConfigNewTowerScoreLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerScoreLevelById.HandleId, "db_newtower.db", "select BinData from `NewTowerScoreLevel` where Id=?");
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x0012CD48 File Offset: 0x0012AF48
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

		// Token: 0x04002AB1 RID: 10929
		private const string DB = "db_newtower.db";

		// Token: 0x04002AB2 RID: 10930
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AB3 RID: 10931
		private const string TABLE = "NewTowerScoreLevel";

		// Token: 0x04002AB4 RID: 10932
		private const string COMMAND = "select BinData from `NewTowerScoreLevel` where Id=?";

		// Token: 0x04002AB5 RID: 10933
		private const string KEY_PREFIX = "NewTowerScoreLevelById";

		// Token: 0x04002AB6 RID: 10934
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AB7 RID: 10935
		private static int HandleId;
	}
}
