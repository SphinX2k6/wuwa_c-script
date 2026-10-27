using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F6 RID: 2038
	public class ConfigRhythmShipLevelByPlanet : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FD6 RID: 12246 RVA: 0x001679FC File Offset: 0x00165BFC
		static ConfigRhythmShipLevelByPlanet()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipLevelByPlanet.CreateStaticDefaultValue), new Action(ConfigRhythmShipLevelByPlanet.ResetStaticDefaultValue));
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00167A1C File Offset: 0x00165C1C
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

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00167A9B File Offset: 0x00165C9B
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipLevelByPlanet.LogPair = null;
			ConfigRhythmShipLevelByPlanet.HandleId = 0;
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00167AA9 File Offset: 0x00165CA9
		public static void Init()
		{
			ConfigRhythmShipLevelByPlanet.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipLevelByPlanet.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipLevel` where Planet=?");
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00167AC4 File Offset: 0x00165CC4
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

		// Token: 0x040037A0 RID: 14240
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037A1 RID: 14241
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037A2 RID: 14242
		private const string TABLE = "RhythmShipLevel";

		// Token: 0x040037A3 RID: 14243
		private const string COMMAND = "select BinData from `RhythmShipLevel` where Planet=?";

		// Token: 0x040037A4 RID: 14244
		private const string KEY_PREFIX = "RhythmShipLevelByPlanet";

		// Token: 0x040037A5 RID: 14245
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037A6 RID: 14246
		private static int HandleId;
	}
}
