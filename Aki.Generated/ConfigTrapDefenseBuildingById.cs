using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFC RID: 2812
	public class ConfigTrapDefenseBuildingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041FC RID: 16892 RVA: 0x001D1EFC File Offset: 0x001D00FC
		static ConfigTrapDefenseBuildingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBuildingById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBuildingById.ResetStaticDefaultValue));
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x001D1F1C File Offset: 0x001D011C
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

		// Token: 0x060041FE RID: 16894 RVA: 0x001D1F9B File Offset: 0x001D019B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingById.LogPair = null;
			ConfigTrapDefenseBuildingById.HandleId = 0;
		}

		// Token: 0x060041FF RID: 16895 RVA: 0x001D1FA9 File Offset: 0x001D01A9
		public static void Init()
		{
			ConfigTrapDefenseBuildingById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBuildingById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBuilding` where Id=?");
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x001D1FC4 File Offset: 0x001D01C4
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

		// Token: 0x04004CCA RID: 19658
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CCB RID: 19659
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004CCC RID: 19660
		private const string TABLE = "TrapDefenseBuilding";

		// Token: 0x04004CCD RID: 19661
		private const string COMMAND = "select BinData from `TrapDefenseBuilding` where Id=?";

		// Token: 0x04004CCE RID: 19662
		private const string KEY_PREFIX = "TrapDefenseBuildingById";

		// Token: 0x04004CCF RID: 19663
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CD0 RID: 19664
		private static int HandleId;
	}
}
