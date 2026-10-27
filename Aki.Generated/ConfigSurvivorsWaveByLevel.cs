using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B1 RID: 2481
	public class ConfigSurvivorsWaveByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A3A RID: 14906 RVA: 0x001A305C File Offset: 0x001A125C
		static ConfigSurvivorsWaveByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWaveByLevel.CreateStaticDefaultValue), new Action(ConfigSurvivorsWaveByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x001A307C File Offset: 0x001A127C
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWaveByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWaveByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWave"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWave` where Level=?")
			});
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x001A30FB File Offset: 0x001A12FB
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWaveByLevel.LogPair = null;
			ConfigSurvivorsWaveByLevel.HandleId = 0;
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x001A3109 File Offset: 0x001A1309
		public static void Init()
		{
			ConfigSurvivorsWaveByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWaveByLevel.HandleId, "db_survivors.db", "select BinData from `SurvivorsWave` where Level=?");
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x001A3124 File Offset: 0x001A1324
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsWave> GetConfigList(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWaveByLevel.HandleId, ConfigSurvivorsWaveByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWaveByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				IReadOnlyList<SurvivorsWave> readOnlyList = (IReadOnlyList<SurvivorsWave>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSurvivorsWaveByLevel.LogPair.Clear();
			ConfigSurvivorsWaveByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWaveByLevel.HandleId, 1, p0Level, ConfigSurvivorsWaveByLevel.LogPair))
			{
				ConfigCommon.Reset(ConfigSurvivorsWaveByLevel.HandleId, ConfigSurvivorsWaveByLevel.LogPair);
				return null;
			}
			List<SurvivorsWave> list = new List<SurvivorsWave>();
			while (ConfigCommon.Step(ConfigSurvivorsWaveByLevel.HandleId, false, ConfigSurvivorsWaveByLevel.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWaveByLevel.HandleId, 0, ConfigSurvivorsWaveByLevel.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsWaveByLevel.HandleId, ConfigSurvivorsWaveByLevel.LogPair);
					return null;
				}
				SurvivorsWave rootAsSurvivorsWave = SurvivorsWave.GetRootAsSurvivorsWave(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsWave);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWaveByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsWaveByLevel.HandleId, ConfigSurvivorsWaveByLevel.LogPair);
			return list;
		}

		// Token: 0x040043BD RID: 17341
		private const string DB = "db_survivors.db";

		// Token: 0x040043BE RID: 17342
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x040043BF RID: 17343
		private const string TABLE = "SurvivorsWave";

		// Token: 0x040043C0 RID: 17344
		private const string COMMAND = "select BinData from `SurvivorsWave` where Level=?";

		// Token: 0x040043C1 RID: 17345
		private const string KEY_PREFIX = "SurvivorsWaveByLevel";

		// Token: 0x040043C2 RID: 17346
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043C3 RID: 17347
		private static int HandleId;
	}
}
