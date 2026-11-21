using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000812 RID: 2066
	public class ConfigRhythmShipLevelByPlanet : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600307E RID: 12414 RVA: 0x0016ECE4 File Offset: 0x0016CEE4
		static ConfigRhythmShipLevelByPlanet()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipLevelByPlanet.CreateStaticDefaultValue), new Action(ConfigRhythmShipLevelByPlanet.ResetStaticDefaultValue));
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x0016ED04 File Offset: 0x0016CF04
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipLevelByPlanet.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipLevelByPlanet.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipLevel` where Planet=?")
			});
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x0016ED83 File Offset: 0x0016CF83
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipLevelByPlanet.LogPair = null;
			ConfigRhythmShipLevelByPlanet.HandleId = 0;
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0016ED91 File Offset: 0x0016CF91
		public static void Init()
		{
			ConfigRhythmShipLevelByPlanet.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipLevelByPlanet.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipLevel` where Planet=?");
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x0016EDAC File Offset: 0x0016CFAC
		[NullableContext(2)]
		public static IReadOnlyList<RhythmShipLevel> GetConfigList(int p0Planet, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipLevelByPlanet.HandleId, ConfigRhythmShipLevelByPlanet.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipLevelByPlanet");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Planet);
				IReadOnlyList<RhythmShipLevel> readOnlyList = (IReadOnlyList<RhythmShipLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRhythmShipLevelByPlanet.LogPair.Clear();
			ConfigRhythmShipLevelByPlanet.LogPair.Add(new ValueTuple<string, object>("Planet", p0Planet));
			if (!ConfigCommon.BindInt(ConfigRhythmShipLevelByPlanet.HandleId, 1, p0Planet, ConfigRhythmShipLevelByPlanet.LogPair))
			{
				ConfigCommon.Reset(ConfigRhythmShipLevelByPlanet.HandleId, ConfigRhythmShipLevelByPlanet.LogPair);
				return null;
			}
			List<RhythmShipLevel> list = new List<RhythmShipLevel>();
			while (ConfigCommon.Step(ConfigRhythmShipLevelByPlanet.HandleId, false, ConfigRhythmShipLevelByPlanet.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipLevelByPlanet.HandleId, 0, ConfigRhythmShipLevelByPlanet.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmShipLevelByPlanet.HandleId, ConfigRhythmShipLevelByPlanet.LogPair);
					return null;
				}
				RhythmShipLevel rootAsRhythmShipLevel = RhythmShipLevel.GetRootAsRhythmShipLevel(new ByteBuffer(item2));
				list.Add(rootAsRhythmShipLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipLevelByPlanet");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Planet);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmShipLevelByPlanet.HandleId, ConfigRhythmShipLevelByPlanet.LogPair);
			return list;
		}

		// Token: 0x04003864 RID: 14436
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003865 RID: 14437
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003866 RID: 14438
		private const string TABLE = "RhythmShipLevel";

		// Token: 0x04003867 RID: 14439
		private const string COMMAND = "select BinData from `RhythmShipLevel` where Planet=?";

		// Token: 0x04003868 RID: 14440
		private const string KEY_PREFIX = "RhythmShipLevelByPlanet";

		// Token: 0x04003869 RID: 14441
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400386A RID: 14442
		private static int HandleId;
	}
}
