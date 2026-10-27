using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008BB RID: 2235
	public class ConfigRolePropertyGrowthByLevelAndBreachLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003475 RID: 13429 RVA: 0x00181B2B File Offset: 0x0017FD2B
		static ConfigRolePropertyGrowthByLevelAndBreachLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRolePropertyGrowthByLevelAndBreachLevel.CreateStaticDefaultValue), new Action(ConfigRolePropertyGrowthByLevelAndBreachLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00181B4C File Offset: 0x0017FD4C
		public static void CreateStaticDefaultValue()
		{
			ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_property.db"),
				new ValueTuple<string, object>("文件", "s.属性.xlsx"),
				new ValueTuple<string, object>("表名", "RolePropertyGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `RolePropertyGrowth` where Level = ? AND BreachLevel = ?")
			});
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x00181BCB File Offset: 0x0017FDCB
		public static void ResetStaticDefaultValue()
		{
			ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair = null;
			ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId = 0;
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00181BD9 File Offset: 0x0017FDD9
		public static void Init()
		{
			ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId = ConfigCommon.InitDataStatement(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, "db_property.db", "select BinData from `RolePropertyGrowth` where Level = ? AND BreachLevel = ?");
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00181BF4 File Offset: 0x0017FDF4
		public static RolePropertyGrowth? GetConfig(int p0Level, int p1BreachLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RolePropertyGrowthByLevelAndBreachLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1BreachLevel);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RolePropertyGrowth?(RolePropertyGrowth.GetRootAsRolePropertyGrowth(configBuffer));
				}
			}
			ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair.Clear();
			ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair.Add(new ValueTuple<string, object>("BreachLevel", p1BreachLevel));
			if (!ConfigCommon.BindInt(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, 1, p0Level, ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair) || !ConfigCommon.BindInt(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, 2, p1BreachLevel, ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair) || ConfigCommon.Step(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, true, ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, 0, ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RolePropertyGrowth rootAsRolePropertyGrowth = RolePropertyGrowth.GetRootAsRolePropertyGrowth(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("RolePropertyGrowthByLevelAndBreachLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1BreachLevel);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair);
			return new RolePropertyGrowth?(rootAsRolePropertyGrowth);
		}

		// Token: 0x04003D03 RID: 15619
		private const string DB = "db_property.db";

		// Token: 0x04003D04 RID: 15620
		private const string FILE = "s.属性.xlsx";

		// Token: 0x04003D05 RID: 15621
		private const string TABLE = "RolePropertyGrowth";

		// Token: 0x04003D06 RID: 15622
		private const string COMMAND = "select BinData from `RolePropertyGrowth` where Level = ? AND BreachLevel = ?";

		// Token: 0x04003D07 RID: 15623
		private const string KEY_PREFIX = "RolePropertyGrowthByLevelAndBreachLevel";

		// Token: 0x04003D08 RID: 15624
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D09 RID: 15625
		private static int HandleId;
	}
}
