using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D7 RID: 2263
	public class ConfigRolePropertyGrowthByLevelAndBreachLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600351D RID: 13597 RVA: 0x00188E13 File Offset: 0x00187013
		static ConfigRolePropertyGrowthByLevelAndBreachLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRolePropertyGrowthByLevelAndBreachLevel.CreateStaticDefaultValue), new Action(ConfigRolePropertyGrowthByLevelAndBreachLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00188E34 File Offset: 0x00187034
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

		// Token: 0x0600351F RID: 13599 RVA: 0x00188EB3 File Offset: 0x001870B3
		public static void ResetStaticDefaultValue()
		{
			ConfigRolePropertyGrowthByLevelAndBreachLevel.LogPair = null;
			ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId = 0;
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x00188EC1 File Offset: 0x001870C1
		public static void Init()
		{
			ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId = ConfigCommon.InitDataStatement(ConfigRolePropertyGrowthByLevelAndBreachLevel.HandleId, "db_property.db", "select BinData from `RolePropertyGrowth` where Level = ? AND BreachLevel = ?");
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x00188EDC File Offset: 0x001870DC
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

		// Token: 0x04003DC7 RID: 15815
		private const string DB = "db_property.db";

		// Token: 0x04003DC8 RID: 15816
		private const string FILE = "s.属性.xlsx";

		// Token: 0x04003DC9 RID: 15817
		private const string TABLE = "RolePropertyGrowth";

		// Token: 0x04003DCA RID: 15818
		private const string COMMAND = "select BinData from `RolePropertyGrowth` where Level = ? AND BreachLevel = ?";

		// Token: 0x04003DCB RID: 15819
		private const string KEY_PREFIX = "RolePropertyGrowthByLevelAndBreachLevel";

		// Token: 0x04003DCC RID: 15820
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DCD RID: 15821
		private static int HandleId;
	}
}
