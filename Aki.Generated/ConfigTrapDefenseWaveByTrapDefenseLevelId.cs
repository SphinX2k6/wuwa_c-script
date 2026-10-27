using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A47 RID: 2631
	public class ConfigTrapDefenseWaveByTrapDefenseLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DBE RID: 15806 RVA: 0x001B6F91 File Offset: 0x001B5191
		static ConfigTrapDefenseWaveByTrapDefenseLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseWaveByTrapDefenseLevelId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseWaveByTrapDefenseLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DBF RID: 15807 RVA: 0x001B6FB0 File Offset: 0x001B51B0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseWave"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=?")
			});
		}

		// Token: 0x06003DC0 RID: 15808 RVA: 0x001B702F File Offset: 0x001B522F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair = null;
			ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId = 0;
		}

		// Token: 0x06003DC1 RID: 15809 RVA: 0x001B703D File Offset: 0x001B523D
		public static void Init()
		{
			ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=?");
		}

		// Token: 0x06003DC2 RID: 15810 RVA: 0x001B7058 File Offset: 0x001B5258
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseWave> GetConfigList(int p0TrapDefenseLevelId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseWaveByTrapDefenseLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TrapDefenseLevelId);
				IReadOnlyList<TrapDefenseWave> readOnlyList = (IReadOnlyList<TrapDefenseWave>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair.Clear();
			ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair.Add(new ValueTuple<string, object>("TrapDefenseLevelId", p0TrapDefenseLevelId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, 1, p0TrapDefenseLevelId, ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair);
				return null;
			}
			List<TrapDefenseWave> list = new List<TrapDefenseWave>();
			while (ConfigCommon.Step(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, false, ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, 0, ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair);
					return null;
				}
				TrapDefenseWave rootAsTrapDefenseWave = TrapDefenseWave.GetRootAsTrapDefenseWave(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseWave);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseWaveByTrapDefenseLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TrapDefenseLevelId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair);
			return list;
		}

		// Token: 0x040047D7 RID: 18391
		private const string DB = "db_trapdefense.db";

		// Token: 0x040047D8 RID: 18392
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x040047D9 RID: 18393
		private const string TABLE = "TrapDefenseWave";

		// Token: 0x040047DA RID: 18394
		private const string COMMAND = "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=?";

		// Token: 0x040047DB RID: 18395
		private const string KEY_PREFIX = "TrapDefenseWaveByTrapDefenseLevelId";

		// Token: 0x040047DC RID: 18396
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047DD RID: 18397
		private static int HandleId;
	}
}
