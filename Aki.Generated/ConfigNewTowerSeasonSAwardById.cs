using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000625 RID: 1573
	public class ConfigNewTowerSeasonSAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024EE RID: 9454 RVA: 0x0012DD9C File Offset: 0x0012BF9C
		static ConfigNewTowerSeasonSAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerSeasonSAwardById.CreateStaticDefaultValue), new Action(ConfigNewTowerSeasonSAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0012DDBC File Offset: 0x0012BFBC
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerSeasonSAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerSeasonSAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerSeasonSAward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerSeasonSAward` where Id=?")
			});
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0012DE3B File Offset: 0x0012C03B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerSeasonSAwardById.LogPair = null;
			ConfigNewTowerSeasonSAwardById.HandleId = 0;
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x0012DE49 File Offset: 0x0012C049
		public static void Init()
		{
			ConfigNewTowerSeasonSAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerSeasonSAwardById.HandleId, "db_newtower.db", "select BinData from `NewTowerSeasonSAward` where Id=?");
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x0012DE64 File Offset: 0x0012C064
		public static NewTowerSeasonSAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerSeasonSAwardById.HandleId, ConfigNewTowerSeasonSAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonSAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerSeasonSAward?(NewTowerSeasonSAward.GetRootAsNewTowerSeasonSAward(configBuffer));
				}
			}
			ConfigNewTowerSeasonSAwardById.LogPair.Clear();
			ConfigNewTowerSeasonSAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerSeasonSAwardById.HandleId, 1, p0Id, ConfigNewTowerSeasonSAwardById.LogPair) || ConfigCommon.Step(ConfigNewTowerSeasonSAwardById.HandleId, true, ConfigNewTowerSeasonSAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonSAwardById.HandleId, ConfigNewTowerSeasonSAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerSeasonSAwardById.HandleId, 0, ConfigNewTowerSeasonSAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerSeasonSAwardById.HandleId, ConfigNewTowerSeasonSAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerSeasonSAward rootAsNewTowerSeasonSAward = NewTowerSeasonSAward.GetRootAsNewTowerSeasonSAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerSeasonSAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerSeasonSAwardById.HandleId, ConfigNewTowerSeasonSAwardById.LogPair);
			return new NewTowerSeasonSAward?(rootAsNewTowerSeasonSAward);
		}

		// Token: 0x04002AE9 RID: 10985
		private const string DB = "db_newtower.db";

		// Token: 0x04002AEA RID: 10986
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AEB RID: 10987
		private const string TABLE = "NewTowerSeasonSAward";

		// Token: 0x04002AEC RID: 10988
		private const string COMMAND = "select BinData from `NewTowerSeasonSAward` where Id=?";

		// Token: 0x04002AED RID: 10989
		private const string KEY_PREFIX = "NewTowerSeasonSAwardById";

		// Token: 0x04002AEE RID: 10990
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AEF RID: 10991
		private static int HandleId;
	}
}
