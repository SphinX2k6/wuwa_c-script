using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000611 RID: 1553
	public class ConfigNewTowerWaveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002476 RID: 9334 RVA: 0x00127C30 File Offset: 0x00125E30
		static ConfigNewTowerWaveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerWaveById.CreateStaticDefaultValue), new Action(ConfigNewTowerWaveById.ResetStaticDefaultValue));
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00127C50 File Offset: 0x00125E50
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

		// Token: 0x06002478 RID: 9336 RVA: 0x00127CCF File Offset: 0x00125ECF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerWaveById.LogPair = null;
			ConfigNewTowerWaveById.HandleId = 0;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00127CDD File Offset: 0x00125EDD
		public static void Init()
		{
			ConfigNewTowerWaveById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerWaveById.HandleId, "db_newtower.db", "select BinData from `NewTowerWave` where Id=?");
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00127CF8 File Offset: 0x00125EF8
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

		// Token: 0x04002A5D RID: 10845
		private const string DB = "db_newtower.db";

		// Token: 0x04002A5E RID: 10846
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A5F RID: 10847
		private const string TABLE = "NewTowerWave";

		// Token: 0x04002A60 RID: 10848
		private const string COMMAND = "select BinData from `NewTowerWave` where Id=?";

		// Token: 0x04002A61 RID: 10849
		private const string KEY_PREFIX = "NewTowerWaveById";

		// Token: 0x04002A62 RID: 10850
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A63 RID: 10851
		private static int HandleId;
	}
}
