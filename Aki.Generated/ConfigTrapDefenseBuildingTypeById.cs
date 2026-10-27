using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2A RID: 2602
	public class ConfigTrapDefenseBuildingTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D10 RID: 15632 RVA: 0x001B318B File Offset: 0x001B138B
		static ConfigTrapDefenseBuildingTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBuildingTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBuildingTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x001B31AC File Offset: 0x001B13AC
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBuildingTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_机关.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBuildingType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBuildingType` where Id=?")
			});
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x001B322B File Offset: 0x001B142B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTypeById.LogPair = null;
			ConfigTrapDefenseBuildingTypeById.HandleId = 0;
		}

		// Token: 0x06003D13 RID: 15635 RVA: 0x001B3239 File Offset: 0x001B1439
		public static void Init()
		{
			ConfigTrapDefenseBuildingTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBuildingTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBuildingType` where Id=?");
		}

		// Token: 0x06003D14 RID: 15636 RVA: 0x001B3254 File Offset: 0x001B1454
		public static TrapDefenseBuildingType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBuildingTypeById.HandleId, ConfigTrapDefenseBuildingTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBuildingTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBuildingType?(TrapDefenseBuildingType.GetRootAsTrapDefenseBuildingType(configBuffer));
				}
			}
			ConfigTrapDefenseBuildingTypeById.LogPair.Clear();
			ConfigTrapDefenseBuildingTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBuildingTypeById.HandleId, 1, p0Id, ConfigTrapDefenseBuildingTypeById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBuildingTypeById.HandleId, true, ConfigTrapDefenseBuildingTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBuildingTypeById.HandleId, ConfigTrapDefenseBuildingTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBuildingTypeById.HandleId, 0, ConfigTrapDefenseBuildingTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBuildingTypeById.HandleId, ConfigTrapDefenseBuildingTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBuildingType rootAsTrapDefenseBuildingType = TrapDefenseBuildingType.GetRootAsTrapDefenseBuildingType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBuildingTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBuildingTypeById.HandleId, ConfigTrapDefenseBuildingTypeById.LogPair);
			return new TrapDefenseBuildingType?(rootAsTrapDefenseBuildingType);
		}

		// Token: 0x0400470C RID: 18188
		private const string DB = "db_trapdefense.db";

		// Token: 0x0400470D RID: 18189
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x0400470E RID: 18190
		private const string TABLE = "TrapDefenseBuildingType";

		// Token: 0x0400470F RID: 18191
		private const string COMMAND = "select BinData from `TrapDefenseBuildingType` where Id=?";

		// Token: 0x04004710 RID: 18192
		private const string KEY_PREFIX = "TrapDefenseBuildingTypeById";

		// Token: 0x04004711 RID: 18193
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004712 RID: 18194
		private static int HandleId;
	}
}
