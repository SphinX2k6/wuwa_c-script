using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062A RID: 1578
	public class ConfigNewTowerWaveByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600250C RID: 9484 RVA: 0x0012E8F4 File Offset: 0x0012CAF4
		static ConfigNewTowerWaveByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerWaveByLevel.CreateStaticDefaultValue), new Action(ConfigNewTowerWaveByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0012E914 File Offset: 0x0012CB14
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerWaveByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerWaveByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerWave"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerWave` where Level=?")
			});
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x0012E993 File Offset: 0x0012CB93
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerWaveByLevel.LogPair = null;
			ConfigNewTowerWaveByLevel.HandleId = 0;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x0012E9A1 File Offset: 0x0012CBA1
		public static void Init()
		{
			ConfigNewTowerWaveByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerWaveByLevel.HandleId, "db_newtower.db", "select BinData from `NewTowerWave` where Level=?");
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0012E9BC File Offset: 0x0012CBBC
		[NullableContext(2)]
		public static IReadOnlyList<NewTowerWave> GetConfigList(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerWaveByLevel.HandleId, ConfigNewTowerWaveByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerWaveByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				IReadOnlyList<NewTowerWave> readOnlyList = (IReadOnlyList<NewTowerWave>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewTowerWaveByLevel.LogPair.Clear();
			ConfigNewTowerWaveByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigNewTowerWaveByLevel.HandleId, 1, p0Level, ConfigNewTowerWaveByLevel.LogPair))
			{
				ConfigCommon.Reset(ConfigNewTowerWaveByLevel.HandleId, ConfigNewTowerWaveByLevel.LogPair);
				return null;
			}
			List<NewTowerWave> list = new List<NewTowerWave>();
			while (ConfigCommon.Step(ConfigNewTowerWaveByLevel.HandleId, false, ConfigNewTowerWaveByLevel.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerWaveByLevel.HandleId, 0, ConfigNewTowerWaveByLevel.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewTowerWaveByLevel.HandleId, ConfigNewTowerWaveByLevel.LogPair);
					return null;
				}
				NewTowerWave rootAsNewTowerWave = NewTowerWave.GetRootAsNewTowerWave(new ByteBuffer(item2));
				list.Add(rootAsNewTowerWave);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerWaveByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewTowerWaveByLevel.HandleId, ConfigNewTowerWaveByLevel.LogPair);
			return list;
		}

		// Token: 0x04002B0C RID: 11020
		private const string DB = "db_newtower.db";

		// Token: 0x04002B0D RID: 11021
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002B0E RID: 11022
		private const string TABLE = "NewTowerWave";

		// Token: 0x04002B0F RID: 11023
		private const string COMMAND = "select BinData from `NewTowerWave` where Level=?";

		// Token: 0x04002B10 RID: 11024
		private const string KEY_PREFIX = "NewTowerWaveByLevel";

		// Token: 0x04002B11 RID: 11025
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B12 RID: 11026
		private static int HandleId;
	}
}
