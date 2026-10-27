using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000891 RID: 2193
	public class ConfigRoleDevCulProjectConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003378 RID: 13176 RVA: 0x0017C55F File Offset: 0x0017A75F
		static ConfigRoleDevCulProjectConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevCulProjectConfigById.CreateStaticDefaultValue), new Action(ConfigRoleDevCulProjectConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x0017C580 File Offset: 0x0017A780
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevCulProjectConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevCulProjectConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevCulProjectConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevCulProjectConfig` where Id=?")
			});
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x0017C5FF File Offset: 0x0017A7FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevCulProjectConfigById.LogPair = null;
			ConfigRoleDevCulProjectConfigById.HandleId = 0;
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x0017C60D File Offset: 0x0017A80D
		public static void Init()
		{
			ConfigRoleDevCulProjectConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevCulProjectConfigById.HandleId, "db_roledev.db", "select BinData from `RoleDevCulProjectConfig` where Id=?");
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x0017C628 File Offset: 0x0017A828
		public static RoleDevCulProjectConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevCulProjectConfigById.HandleId, ConfigRoleDevCulProjectConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevCulProjectConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleDevCulProjectConfig?(RoleDevCulProjectConfig.GetRootAsRoleDevCulProjectConfig(configBuffer));
				}
			}
			ConfigRoleDevCulProjectConfigById.LogPair.Clear();
			ConfigRoleDevCulProjectConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleDevCulProjectConfigById.HandleId, 1, p0Id, ConfigRoleDevCulProjectConfigById.LogPair) || ConfigCommon.Step(ConfigRoleDevCulProjectConfigById.HandleId, true, ConfigRoleDevCulProjectConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleDevCulProjectConfigById.HandleId, ConfigRoleDevCulProjectConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevCulProjectConfigById.HandleId, 0, ConfigRoleDevCulProjectConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleDevCulProjectConfigById.HandleId, ConfigRoleDevCulProjectConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleDevCulProjectConfig rootAsRoleDevCulProjectConfig = RoleDevCulProjectConfig.GetRootAsRoleDevCulProjectConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleDevCulProjectConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleDevCulProjectConfigById.HandleId, ConfigRoleDevCulProjectConfigById.LogPair);
			return new RoleDevCulProjectConfig?(rootAsRoleDevCulProjectConfig);
		}

		// Token: 0x04003BDD RID: 15325
		private const string DB = "db_roledev.db";

		// Token: 0x04003BDE RID: 15326
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003BDF RID: 15327
		private const string TABLE = "RoleDevCulProjectConfig";

		// Token: 0x04003BE0 RID: 15328
		private const string COMMAND = "select BinData from `RoleDevCulProjectConfig` where Id=?";

		// Token: 0x04003BE1 RID: 15329
		private const string KEY_PREFIX = "RoleDevCulProjectConfigById";

		// Token: 0x04003BE2 RID: 15330
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BE3 RID: 15331
		private static int HandleId;
	}
}
