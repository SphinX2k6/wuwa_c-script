using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A86 RID: 2694
	public class ConfigSurvivorsWaveByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F38 RID: 16184 RVA: 0x001C23F0 File Offset: 0x001C05F0
		static ConfigSurvivorsWaveByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWaveByLevel.CreateStaticDefaultValue), new Action(ConfigSurvivorsWaveByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x001C2410 File Offset: 0x001C0610
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

		// Token: 0x06003F3A RID: 16186 RVA: 0x001C248F File Offset: 0x001C068F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWaveByLevel.LogPair = null;
			ConfigSurvivorsWaveByLevel.HandleId = 0;
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x001C249D File Offset: 0x001C069D
		public static void Init()
		{
			ConfigSurvivorsWaveByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWaveByLevel.HandleId, "db_survivors.db", "select BinData from `SurvivorsWave` where Level=?");
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x001C24B8 File Offset: 0x001C06B8
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

		// Token: 0x04004990 RID: 18832
		private const string DB = "db_survivors.db";

		// Token: 0x04004991 RID: 18833
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x04004992 RID: 18834
		private const string TABLE = "SurvivorsWave";

		// Token: 0x04004993 RID: 18835
		private const string COMMAND = "select BinData from `SurvivorsWave` where Level=?";

		// Token: 0x04004994 RID: 18836
		private const string KEY_PREFIX = "SurvivorsWaveByLevel";

		// Token: 0x04004995 RID: 18837
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004996 RID: 18838
		private static int HandleId;
	}
}
