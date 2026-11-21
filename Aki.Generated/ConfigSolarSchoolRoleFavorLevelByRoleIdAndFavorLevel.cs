using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A13 RID: 2579
	public class ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C86 RID: 15494 RVA: 0x001B2CBB File Offset: 0x001B0EBB
		static ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x001B2CDC File Offset: 0x001B0EDC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleFavorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleFavorLevel` where RoleId=? AND FavorLevel=?")
			});
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x001B2D5B File Offset: 0x001B0F5B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair = null;
			ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId = 0;
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x001B2D69 File Offset: 0x001B0F69
		public static void Init()
		{
			ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleFavorLevel` where RoleId=? AND FavorLevel=?");
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x001B2D84 File Offset: 0x001B0F84
		public static SolarSchoolRoleFavorLevel? GetConfig(int p0RoleId, int p1FavorLevel, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleFavorLevelByRoleIdAndFavorLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1FavorLevel);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolRoleFavorLevel?(SolarSchoolRoleFavorLevel.GetRootAsSolarSchoolRoleFavorLevel(configBuffer));
				}
			}
			ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair.Clear();
			ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair.Add(new ValueTuple<string, object>("FavorLevel", p1FavorLevel));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, 1, p0RoleId, ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair) || !ConfigCommon.BindInt(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, 2, p1FavorLevel, ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair) || ConfigCommon.Step(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, true, ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, 0, ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolRoleFavorLevel rootAsSolarSchoolRoleFavorLevel = SolarSchoolRoleFavorLevel.GetRootAsSolarSchoolRoleFavorLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleFavorLevelByRoleIdAndFavorLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1FavorLevel);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.HandleId, ConfigSolarSchoolRoleFavorLevelByRoleIdAndFavorLevel.LogPair);
			return new SolarSchoolRoleFavorLevel?(rootAsSolarSchoolRoleFavorLevel);
		}

		// Token: 0x0400466B RID: 18027
		private const string DB = "db_solarschool.db";

		// Token: 0x0400466C RID: 18028
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x0400466D RID: 18029
		private const string TABLE = "SolarSchoolRoleFavorLevel";

		// Token: 0x0400466E RID: 18030
		private const string COMMAND = "select BinData from `SolarSchoolRoleFavorLevel` where RoleId=? AND FavorLevel=?";

		// Token: 0x0400466F RID: 18031
		private const string KEY_PREFIX = "SolarSchoolRoleFavorLevelByRoleIdAndFavorLevel";

		// Token: 0x04004670 RID: 18032
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004671 RID: 18033
		private static int HandleId;
	}
}
