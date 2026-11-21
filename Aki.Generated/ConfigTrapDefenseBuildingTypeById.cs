using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFF RID: 2815
	public class ConfigTrapDefenseBuildingTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600420E RID: 16910 RVA: 0x001D251F File Offset: 0x001D071F
		static ConfigTrapDefenseBuildingTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBuildingTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBuildingTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600420F RID: 16911 RVA: 0x001D2540 File Offset: 0x001D0740
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

		// Token: 0x06004210 RID: 16912 RVA: 0x001D25BF File Offset: 0x001D07BF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTypeById.LogPair = null;
			ConfigTrapDefenseBuildingTypeById.HandleId = 0;
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x001D25CD File Offset: 0x001D07CD
		public static void Init()
		{
			ConfigTrapDefenseBuildingTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBuildingTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBuildingType` where Id=?");
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x001D25E8 File Offset: 0x001D07E8
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

		// Token: 0x04004CDF RID: 19679
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CE0 RID: 19680
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004CE1 RID: 19681
		private const string TABLE = "TrapDefenseBuildingType";

		// Token: 0x04004CE2 RID: 19682
		private const string COMMAND = "select BinData from `TrapDefenseBuildingType` where Id=?";

		// Token: 0x04004CE3 RID: 19683
		private const string KEY_PREFIX = "TrapDefenseBuildingTypeById";

		// Token: 0x04004CE4 RID: 19684
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CE5 RID: 19685
		private static int HandleId;
	}
}
