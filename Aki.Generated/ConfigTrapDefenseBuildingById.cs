using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A27 RID: 2599
	public class ConfigTrapDefenseBuildingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CFE RID: 15614 RVA: 0x001B2B68 File Offset: 0x001B0D68
		static ConfigTrapDefenseBuildingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBuildingById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBuildingById.ResetStaticDefaultValue));
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x001B2B88 File Offset: 0x001B0D88
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBuildingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_机关.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBuilding"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBuilding` where Id=?")
			});
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x001B2C07 File Offset: 0x001B0E07
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingById.LogPair = null;
			ConfigTrapDefenseBuildingById.HandleId = 0;
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x001B2C15 File Offset: 0x001B0E15
		public static void Init()
		{
			ConfigTrapDefenseBuildingById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBuildingById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBuilding` where Id=?");
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x001B2C30 File Offset: 0x001B0E30
		public static TrapDefenseBuilding? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBuildingById.HandleId, ConfigTrapDefenseBuildingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBuildingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBuilding?(TrapDefenseBuilding.GetRootAsTrapDefenseBuilding(configBuffer));
				}
			}
			ConfigTrapDefenseBuildingById.LogPair.Clear();
			ConfigTrapDefenseBuildingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBuildingById.HandleId, 1, p0Id, ConfigTrapDefenseBuildingById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBuildingById.HandleId, true, ConfigTrapDefenseBuildingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBuildingById.HandleId, ConfigTrapDefenseBuildingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBuildingById.HandleId, 0, ConfigTrapDefenseBuildingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBuildingById.HandleId, ConfigTrapDefenseBuildingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBuilding rootAsTrapDefenseBuilding = TrapDefenseBuilding.GetRootAsTrapDefenseBuilding(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBuildingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBuildingById.HandleId, ConfigTrapDefenseBuildingById.LogPair);
			return new TrapDefenseBuilding?(rootAsTrapDefenseBuilding);
		}

		// Token: 0x040046F7 RID: 18167
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046F8 RID: 18168
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x040046F9 RID: 18169
		private const string TABLE = "TrapDefenseBuilding";

		// Token: 0x040046FA RID: 18170
		private const string COMMAND = "select BinData from `TrapDefenseBuilding` where Id=?";

		// Token: 0x040046FB RID: 18171
		private const string KEY_PREFIX = "TrapDefenseBuildingById";

		// Token: 0x040046FC RID: 18172
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046FD RID: 18173
		private static int HandleId;
	}
}
