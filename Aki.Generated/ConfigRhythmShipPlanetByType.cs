using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F9 RID: 2041
	public class ConfigRhythmShipPlanetByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FE8 RID: 12264 RVA: 0x00168010 File Offset: 0x00166210
		static ConfigRhythmShipPlanetByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipPlanetByType.CreateStaticDefaultValue), new Action(ConfigRhythmShipPlanetByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00168030 File Offset: 0x00166230
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipPlanetByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipPlanetByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipPlanet"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipPlanet` where Type=?")
			});
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x001680AF File Offset: 0x001662AF
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipPlanetByType.LogPair = null;
			ConfigRhythmShipPlanetByType.HandleId = 0;
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x001680BD File Offset: 0x001662BD
		public static void Init()
		{
			ConfigRhythmShipPlanetByType.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipPlanetByType.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipPlanet` where Type=?");
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x001680D8 File Offset: 0x001662D8
		[NullableContext(2)]
		public static IReadOnlyList<RhythmShipPlanet> GetConfigList(int p0Type, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipPlanetByType.HandleId, ConfigRhythmShipPlanetByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipPlanetByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				IReadOnlyList<RhythmShipPlanet> readOnlyList = (IReadOnlyList<RhythmShipPlanet>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRhythmShipPlanetByType.LogPair.Clear();
			ConfigRhythmShipPlanetByType.LogPair.Add(new ValueTuple<string, object>("Type", p0Type));
			if (!ConfigCommon.BindInt(ConfigRhythmShipPlanetByType.HandleId, 1, p0Type, ConfigRhythmShipPlanetByType.LogPair))
			{
				ConfigCommon.Reset(ConfigRhythmShipPlanetByType.HandleId, ConfigRhythmShipPlanetByType.LogPair);
				return null;
			}
			List<RhythmShipPlanet> list = new List<RhythmShipPlanet>();
			while (ConfigCommon.Step(ConfigRhythmShipPlanetByType.HandleId, false, ConfigRhythmShipPlanetByType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipPlanetByType.HandleId, 0, ConfigRhythmShipPlanetByType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmShipPlanetByType.HandleId, ConfigRhythmShipPlanetByType.LogPair);
					return null;
				}
				RhythmShipPlanet rootAsRhythmShipPlanet = RhythmShipPlanet.GetRootAsRhythmShipPlanet(new ByteBuffer(item2));
				list.Add(rootAsRhythmShipPlanet);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmShipPlanetByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Type);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmShipPlanetByType.HandleId, ConfigRhythmShipPlanetByType.LogPair);
			return list;
		}

		// Token: 0x040037B5 RID: 14261
		private const string DB = "db_rhythmship.db";

		// Token: 0x040037B6 RID: 14262
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x040037B7 RID: 14263
		private const string TABLE = "RhythmShipPlanet";

		// Token: 0x040037B8 RID: 14264
		private const string COMMAND = "select BinData from `RhythmShipPlanet` where Type=?";

		// Token: 0x040037B9 RID: 14265
		private const string KEY_PREFIX = "RhythmShipPlanetByType";

		// Token: 0x040037BA RID: 14266
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037BB RID: 14267
		private static int HandleId;
	}
}
