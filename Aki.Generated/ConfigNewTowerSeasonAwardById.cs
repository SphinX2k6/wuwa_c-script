using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060A RID: 1546
	public class ConfigNewTowerSeasonAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600244C RID: 9292 RVA: 0x00126C57 File Offset: 0x00124E57
		static ConfigNewTowerSeasonAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonAwardById.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00126C78 File Offset: 0x00124E78
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerSeasonAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerSeasonAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerSeasonAward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerSeasonAward` where Id=?")
			});
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00126CF7 File Offset: 0x00124EF7
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonAwardById.LogPair = null;
			ConfigNewTowerSeasonAwardById.HandleId = 0;
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00126D05 File Offset: 0x00124F05
		public static void Init()
		{
			ConfigNewTowerSeasonAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonAwardById.HandleId, "db_newtower.db", "select BinData from `NewTowerSeasonAward` where Id=?");
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00126D20 File Offset: 0x00124F20
		public static NewTowerSeasonAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerSeasonAwardById.HandleId, ConfigNewTowerSeasonAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerSeasonAward?(NewTowerSeasonAward.GetRootAsNewTowerSeasonAward(configBuffer));
				}
			}
			ConfigNewTowerSeasonAwardById.LogPair.Clear();
			ConfigNewTowerSeasonAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerSeasonAwardById.HandleId, 1, p0Id, ConfigNewTowerSeasonAwardById.LogPair) || ConfigCommon.Step(ConfigNewTowerSeasonAwardById.HandleId, true, ConfigNewTowerSeasonAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonAwardById.HandleId, ConfigNewTowerSeasonAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerSeasonAwardById.HandleId, 0, ConfigNewTowerSeasonAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonAwardById.HandleId, ConfigNewTowerSeasonAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerSeasonAward rootAsNewTowerSeasonAward = NewTowerSeasonAward.GetRootAsNewTowerSeasonAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerSeasonAwardById.HandleId, ConfigNewTowerSeasonAwardById.LogPair);
			return new NewTowerSeasonAward?(rootAsNewTowerSeasonAward);
		}

		// Token: 0x04002A2C RID: 10796
		private const string DB = "db_newtower.db";

		// Token: 0x04002A2D RID: 10797
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A2E RID: 10798
		private const string TABLE = "NewTowerSeasonAward";

		// Token: 0x04002A2F RID: 10799
		private const string COMMAND = "select BinData from `NewTowerSeasonAward` where Id=?";

		// Token: 0x04002A30 RID: 10800
		private const string KEY_PREFIX = "NewTowerSeasonAwardById";

		// Token: 0x04002A31 RID: 10801
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A32 RID: 10802
		private static int HandleId;
	}
}
