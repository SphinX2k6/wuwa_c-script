using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000629 RID: 1577
	public class ConfigNewTowerWaveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002506 RID: 9478 RVA: 0x0012E6AC File Offset: 0x0012C8AC
		static ConfigNewTowerWaveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerWaveById.CreateStaticDefaultValue), new Action(ConfigNewTowerWaveById.ResetStaticDefaultValue));
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x0012E6CC File Offset: 0x0012C8CC
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerWaveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerWaveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerWave"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerWave` where Id=?")
			});
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0012E74B File Offset: 0x0012C94B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerWaveById.LogPair = null;
			ConfigNewTowerWaveById.HandleId = 0;
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x0012E759 File Offset: 0x0012C959
		public static void Init()
		{
			ConfigNewTowerWaveById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerWaveById.HandleId, "db_newtower.db", "select BinData from `NewTowerWave` where Id=?");
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0012E774 File Offset: 0x0012C974
		public static NewTowerWave? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerWaveById.HandleId, ConfigNewTowerWaveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerWaveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerWave?(NewTowerWave.GetRootAsNewTowerWave(configBuffer));
				}
			}
			ConfigNewTowerWaveById.LogPair.Clear();
			ConfigNewTowerWaveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerWaveById.HandleId, 1, p0Id, ConfigNewTowerWaveById.LogPair) || ConfigCommon.Step(ConfigNewTowerWaveById.HandleId, true, ConfigNewTowerWaveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerWaveById.HandleId, ConfigNewTowerWaveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerWaveById.HandleId, 0, ConfigNewTowerWaveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerWaveById.HandleId, ConfigNewTowerWaveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerWave rootAsNewTowerWave = NewTowerWave.GetRootAsNewTowerWave(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerWaveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerWaveById.HandleId, ConfigNewTowerWaveById.LogPair);
			return new NewTowerWave?(rootAsNewTowerWave);
		}

		// Token: 0x04002B05 RID: 11013
		private const string DB = "db_newtower.db";

		// Token: 0x04002B06 RID: 11014
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002B07 RID: 11015
		private const string TABLE = "NewTowerWave";

		// Token: 0x04002B08 RID: 11016
		private const string COMMAND = "select BinData from `NewTowerWave` where Id=?";

		// Token: 0x04002B09 RID: 11017
		private const string KEY_PREFIX = "NewTowerWaveById";

		// Token: 0x04002B0A RID: 11018
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B0B RID: 11019
		private static int HandleId;
	}
}
