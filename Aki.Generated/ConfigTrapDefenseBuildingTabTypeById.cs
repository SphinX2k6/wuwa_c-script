using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A28 RID: 2600
	public class ConfigTrapDefenseBuildingTabTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D04 RID: 15620 RVA: 0x001B2DB0 File Offset: 0x001B0FB0
		static ConfigTrapDefenseBuildingTabTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBuildingTabTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBuildingTabTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x001B2DD0 File Offset: 0x001B0FD0
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTabTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBuildingTabTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_机关.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBuildingTabType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBuildingTabType` where Id=?")
			});
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x001B2E4F File Offset: 0x001B104F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTabTypeById.LogPair = null;
			ConfigTrapDefenseBuildingTabTypeById.HandleId = 0;
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x001B2E5D File Offset: 0x001B105D
		public static void Init()
		{
			ConfigTrapDefenseBuildingTabTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBuildingTabTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBuildingTabType` where Id=?");
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x001B2E78 File Offset: 0x001B1078
		public static TrapDefenseBuildingTabType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBuildingTabTypeById.HandleId, ConfigTrapDefenseBuildingTabTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBuildingTabTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseBuildingTabType?(TrapDefenseBuildingTabType.GetRootAsTrapDefenseBuildingTabType(configBuffer));
				}
			}
			ConfigTrapDefenseBuildingTabTypeById.LogPair.Clear();
			ConfigTrapDefenseBuildingTabTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseBuildingTabTypeById.HandleId, 1, p0Id, ConfigTrapDefenseBuildingTabTypeById.LogPair) || ConfigCommon.Step(ConfigTrapDefenseBuildingTabTypeById.HandleId, true, ConfigTrapDefenseBuildingTabTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBuildingTabTypeById.HandleId, ConfigTrapDefenseBuildingTabTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBuildingTabTypeById.HandleId, 0, ConfigTrapDefenseBuildingTabTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseBuildingTabTypeById.HandleId, ConfigTrapDefenseBuildingTabTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseBuildingTabType rootAsTrapDefenseBuildingTabType = TrapDefenseBuildingTabType.GetRootAsTrapDefenseBuildingTabType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseBuildingTabTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBuildingTabTypeById.HandleId, ConfigTrapDefenseBuildingTabTypeById.LogPair);
			return new TrapDefenseBuildingTabType?(rootAsTrapDefenseBuildingTabType);
		}

		// Token: 0x040046FE RID: 18174
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046FF RID: 18175
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004700 RID: 18176
		private const string TABLE = "TrapDefenseBuildingTabType";

		// Token: 0x04004701 RID: 18177
		private const string COMMAND = "select BinData from `TrapDefenseBuildingTabType` where Id=?";

		// Token: 0x04004702 RID: 18178
		private const string KEY_PREFIX = "TrapDefenseBuildingTabTypeById";

		// Token: 0x04004703 RID: 18179
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004704 RID: 18180
		private static int HandleId;
	}
}
