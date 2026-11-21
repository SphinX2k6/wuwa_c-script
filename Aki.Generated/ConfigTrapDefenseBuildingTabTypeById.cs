using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFD RID: 2813
	public class ConfigTrapDefenseBuildingTabTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004202 RID: 16898 RVA: 0x001D2144 File Offset: 0x001D0344
		static ConfigTrapDefenseBuildingTabTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBuildingTabTypeById.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBuildingTabTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x001D2164 File Offset: 0x001D0364
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

		// Token: 0x06004204 RID: 16900 RVA: 0x001D21E3 File Offset: 0x001D03E3
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTabTypeById.LogPair = null;
			ConfigTrapDefenseBuildingTabTypeById.HandleId = 0;
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x001D21F1 File Offset: 0x001D03F1
		public static void Init()
		{
			ConfigTrapDefenseBuildingTabTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBuildingTabTypeById.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBuildingTabType` where Id=?");
		}

		// Token: 0x06004206 RID: 16902 RVA: 0x001D220C File Offset: 0x001D040C
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

		// Token: 0x04004CD1 RID: 19665
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CD2 RID: 19666
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004CD3 RID: 19667
		private const string TABLE = "TrapDefenseBuildingTabType";

		// Token: 0x04004CD4 RID: 19668
		private const string COMMAND = "select BinData from `TrapDefenseBuildingTabType` where Id=?";

		// Token: 0x04004CD5 RID: 19669
		private const string KEY_PREFIX = "TrapDefenseBuildingTabTypeById";

		// Token: 0x04004CD6 RID: 19670
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CD7 RID: 19671
		private static int HandleId;
	}
}
