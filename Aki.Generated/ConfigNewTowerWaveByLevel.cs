using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000612 RID: 1554
	public class ConfigNewTowerWaveByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600247C RID: 9340 RVA: 0x00127E78 File Offset: 0x00126078
		static ConfigNewTowerWaveByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerWaveByLevel.CreateStaticDefaultValue), new Action(ConfigNewTowerWaveByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00127E98 File Offset: 0x00126098
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

		// Token: 0x0600247E RID: 9342 RVA: 0x00127F17 File Offset: 0x00126117
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerWaveByLevel.LogPair = null;
			ConfigNewTowerWaveByLevel.HandleId = 0;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00127F25 File Offset: 0x00126125
		public static void Init()
		{
			ConfigNewTowerWaveByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerWaveByLevel.HandleId, "db_newtower.db", "select BinData from `NewTowerWave` where Level=?");
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00127F40 File Offset: 0x00126140
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

		// Token: 0x04002A64 RID: 10852
		private const string DB = "db_newtower.db";

		// Token: 0x04002A65 RID: 10853
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A66 RID: 10854
		private const string TABLE = "NewTowerWave";

		// Token: 0x04002A67 RID: 10855
		private const string COMMAND = "select BinData from `NewTowerWave` where Level=?";

		// Token: 0x04002A68 RID: 10856
		private const string KEY_PREFIX = "NewTowerWaveByLevel";

		// Token: 0x04002A69 RID: 10857
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A6A RID: 10858
		private static int HandleId;
	}
}
