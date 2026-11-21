using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0D RID: 2573
	public class ConfigSolarSchoolRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C62 RID: 15458 RVA: 0x001B20A3 File Offset: 0x001B02A3
		static ConfigSolarSchoolRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x001B20C4 File Offset: 0x001B02C4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRole"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRole` where Id=?")
			});
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x001B2143 File Offset: 0x001B0343
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleById.LogPair = null;
			ConfigSolarSchoolRoleById.HandleId = 0;
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x001B2151 File Offset: 0x001B0351
		public static void Init()
		{
			ConfigSolarSchoolRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRole` where Id=?");
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x001B216C File Offset: 0x001B036C
		public static SolarSchoolRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleById.HandleId, ConfigSolarSchoolRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolRole?(SolarSchoolRole.GetRootAsSolarSchoolRole(configBuffer));
				}
			}
			ConfigSolarSchoolRoleById.LogPair.Clear();
			ConfigSolarSchoolRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleById.HandleId, 1, p0Id, ConfigSolarSchoolRoleById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolRoleById.HandleId, true, ConfigSolarSchoolRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleById.HandleId, ConfigSolarSchoolRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleById.HandleId, 0, ConfigSolarSchoolRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleById.HandleId, ConfigSolarSchoolRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolRole rootAsSolarSchoolRole = SolarSchoolRole.GetRootAsSolarSchoolRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleById.HandleId, ConfigSolarSchoolRoleById.LogPair);
			return new SolarSchoolRole?(rootAsSolarSchoolRole);
		}

		// Token: 0x04004641 RID: 17985
		private const string DB = "db_solarschool.db";

		// Token: 0x04004642 RID: 17986
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004643 RID: 17987
		private const string TABLE = "SolarSchoolRole";

		// Token: 0x04004644 RID: 17988
		private const string COMMAND = "select BinData from `SolarSchoolRole` where Id=?";

		// Token: 0x04004645 RID: 17989
		private const string KEY_PREFIX = "SolarSchoolRoleById";

		// Token: 0x04004646 RID: 17990
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004647 RID: 17991
		private static int HandleId;
	}
}
