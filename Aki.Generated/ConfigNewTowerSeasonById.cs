using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060C RID: 1548
	public class ConfigNewTowerSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002458 RID: 9304 RVA: 0x001270D7 File Offset: 0x001252D7
		static ConfigNewTowerSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonById.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x001270F8 File Offset: 0x001252F8
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerSeasonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerSeasonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerSeason` where Id=?")
			});
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00127177 File Offset: 0x00125377
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonById.LogPair = null;
			ConfigNewTowerSeasonById.HandleId = 0;
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00127185 File Offset: 0x00125385
		public static void Init()
		{
			ConfigNewTowerSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonById.HandleId, "db_newtower.db", "select BinData from `NewTowerSeason` where Id=?");
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x001271A0 File Offset: 0x001253A0
		public static NewTowerSeason? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerSeasonById.HandleId, ConfigNewTowerSeasonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerSeason?(NewTowerSeason.GetRootAsNewTowerSeason(configBuffer));
				}
			}
			ConfigNewTowerSeasonById.LogPair.Clear();
			ConfigNewTowerSeasonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerSeasonById.HandleId, 1, p0Id, ConfigNewTowerSeasonById.LogPair) || ConfigCommon.Step(ConfigNewTowerSeasonById.HandleId, true, ConfigNewTowerSeasonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonById.HandleId, ConfigNewTowerSeasonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerSeasonById.HandleId, 0, ConfigNewTowerSeasonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonById.HandleId, ConfigNewTowerSeasonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerSeason rootAsNewTowerSeason = NewTowerSeason.GetRootAsNewTowerSeason(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerSeasonById.HandleId, ConfigNewTowerSeasonById.LogPair);
			return new NewTowerSeason?(rootAsNewTowerSeason);
		}

		// Token: 0x04002A3A RID: 10810
		private const string DB = "db_newtower.db";

		// Token: 0x04002A3B RID: 10811
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A3C RID: 10812
		private const string TABLE = "NewTowerSeason";

		// Token: 0x04002A3D RID: 10813
		private const string COMMAND = "select BinData from `NewTowerSeason` where Id=?";

		// Token: 0x04002A3E RID: 10814
		private const string KEY_PREFIX = "NewTowerSeasonById";

		// Token: 0x04002A3F RID: 10815
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A40 RID: 10816
		private static int HandleId;
	}
}
