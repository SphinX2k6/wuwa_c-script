using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1C RID: 2844
	public class ConfigTrapDefenseWaveByTrapDefenseLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042BC RID: 17084 RVA: 0x001D6325 File Offset: 0x001D4525
		static ConfigTrapDefenseWaveByTrapDefenseLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseWaveByTrapDefenseLevelId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseWaveByTrapDefenseLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x001D6344 File Offset: 0x001D4544
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

		// Token: 0x060042BE RID: 17086 RVA: 0x001D63C3 File Offset: 0x001D45C3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseWaveByTrapDefenseLevelId.LogPair = null;
			ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId = 0;
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x001D63D1 File Offset: 0x001D45D1
		public static void Init()
		{
			ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseWaveByTrapDefenseLevelId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=?");
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x001D63EC File Offset: 0x001D45EC
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

		// Token: 0x04004DAA RID: 19882
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004DAB RID: 19883
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004DAC RID: 19884
		private const string TABLE = "TrapDefenseWave";

		// Token: 0x04004DAD RID: 19885
		private const string COMMAND = "select BinData from `TrapDefenseWave` where TrapDefenseLevelId=?";

		// Token: 0x04004DAE RID: 19886
		private const string KEY_PREFIX = "TrapDefenseWaveByTrapDefenseLevelId";

		// Token: 0x04004DAF RID: 19887
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DB0 RID: 19888
		private static int HandleId;
	}
}
